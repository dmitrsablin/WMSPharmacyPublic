using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspose.Words.Rendering;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using Spire.DataExport.Common;
using Spire.DataExport.RTF;
using DataTable = System.Data.DataTable;
using PageOrientation = Spire.DataExport.Common.PageOrientation;
using PDFExport = Spire.DataExport.PDF.PDFExport;

namespace WMSPharmacy.Helpers
{
    internal class Export
    {
        public static void ExportInDocument(DataTable table, string nameTable, TypeOfDocument typeOfDocument,
            string filePath)
        {
            try
            {
                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                }

                switch (typeOfDocument)
                {
                    case TypeOfDocument.Excel:
                        {
                            //Поиск самой длинной строки в столбце datatable
                            var maximumLengthForColumns = Enumerable.Range(0, table.Columns.Count)
                                .Select(col => table.AsEnumerable()
                                    .Select(row => row[col]).OfType<string>()
                                    .Max(val => val.Length)).ToList();

                            //Длинна слов в хеадерах
                            var headers = new List<int>();
                            foreach (DataColumn col in table.Columns)
                            {
                                headers.Add(col.ColumnName.Length);
                            }

                            using (var excelPackage =
                                new ExcelPackage(
                                    new FileInfo($@"{filePath}\{nameTable} {DateTime.Now:dd-MM-yyyy HH-mm-ss}.xlsx")))
                            {

                                ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets.Add(nameTable);
                                excelWorksheet.Cells["A1"].LoadFromDataTable(table, true);

                                //Определение нужной длинны ячейки, чтобы все показывалось, как надо
                                for (int i = 0; i < maximumLengthForColumns.Count; i++)
                                {
                                    if (headers[i] > maximumLengthForColumns[i])
                                    {
                                        excelWorksheet.Column(i + 1).Width = headers[i] + 2;
                                    }
                                    else
                                    {
                                        if (maximumLengthForColumns[i] >= 50)
                                        {
                                            excelWorksheet.Column(i + 1).Width = 50;
                                        }
                                        else
                                        {
                                            excelWorksheet.Column(i + 1).Width = maximumLengthForColumns[i] + 1;
                                        }
                                    }

                                    //Выравнивание по умолчаю снизу, выглядит не очень, исправляем 
                                    excelWorksheet.Column(i + 1).Style.VerticalAlignment = ExcelVerticalAlignment.Top;

                                    excelWorksheet.Column(i + 1).Style.WrapText = true;
                                }

                                excelPackage.SaveAsync();
                            }

                            break;
                        }

                    case TypeOfDocument.Word:
                        {
                            using (var rtfExport = new RTFExport())
                            {
                                rtfExport.DataSource = ExportSource.DataTable;
                                rtfExport.DataTable = table;
                                rtfExport.RTFOptions.PageOrientation = PageOrientation.Landscape;

                                rtfExport.FileName = $@"{filePath}\{nameTable} {DateTime.Now:dd-MM-yyyy HH-mm-ss}.doc";

                                rtfExport.SaveToFile();
                            }

                            break;
                        }

                    case TypeOfDocument.Pdf:
                        {
                            using (var pdfExport = new PDFExport())
                            {
                                pdfExport.DataSource = ExportSource.DataTable;
                                pdfExport.DataTable = table;
                                pdfExport.PDFOptions.PageOptions.Orientation = PageOrientation.Landscape;

                                pdfExport.SaveToFile($@"{filePath}\{nameTable} {DateTime.Now:dd-MM-yyyy HH-mm-ss}.pdf");
                            }

                            break;
                        }

                    case TypeOfDocument.SendOnPrinter:
                        {
                            //Сделал такой кринж потому, что spire "нормально" воспринимает datatable
                            //Функция печати стоит 800 долларов
                            //Aspose не принимает datatable, но печать бесплатная
                            var file = $@"{filePath}\{nameTable} {DateTime.Now:dd-MM-yyyy HH-mm-ss}.doc";
                            using (var rtfExport = new RTFExport())
                            {
                                rtfExport.DataSource = ExportSource.DataTable;
                                rtfExport.DataTable = table;
                                rtfExport.RTFOptions.PageOrientation = PageOrientation.Landscape;
                                rtfExport.FileName = file;

                                rtfExport.SaveToFile();
                            }

                            //Aspose по умолчанию не ассинхронный, 
                            //Ждать пока он отработает сомнительно, поэтому сделал task
                            Task.Run(() =>
                            {
                            // С сайта aspose, не трогать
                            AsposeWordsPrintDocument printDocument =
                                    new AsposeWordsPrintDocument(new Aspose.Words.Document(file))
                                    {
                                        PrinterSettings = new PrinterSettings(),
                                        PrintController = new StandardPrintController()
                                    };

                                printDocument.Print();
                            });

                            break;
                        }

                    default: throw new Exception();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }

    public enum TypeOfDocument
    {
        Excel,
        Word,
        Pdf,
        SendOnPrinter
    }
}