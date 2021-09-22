using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace WMSPharmacy.Forms
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        private void SplashLoad(object sender, EventArgs e)
        {
            startTimer.Start();

            //-1 нужен для правильного вписывания gif в progressbar
            circleProgressBar.Location = new Point
            (
                Width / 2 - circleProgressBar.Width / 2 - 1,
                Height / 2 - circleProgressBar.Height / 2 - 1
            );
        }

        #region Рисование gif

        //Стандартный PictureBox поддерживает прозрачность в изображениях
        //Но не поддерживает прозрачность в gif
        //Это выглядит некрасиво
        //Поэтому обработаваю gif, как набор изображений

        //Номер текущего кадра
        private int _frameCounter;

        private static readonly Image Image = Properties.Resources.Preloader;

        //Переключатель изображений
        private readonly FrameDimension _frameDimension = new FrameDimension(Image.FrameDimensionsList[0]);

        private void SplashPaint(object sender, PaintEventArgs e)
        {
            //Рисование гиф
            e.Graphics.DrawImage(
                Image,
                Width / 2 - Image.Width / 2,
                Height / 2 - Image.Height / 2);
        }

        #endregion

        private void StartTimerTick(object sender, EventArgs e)
        {
            //Заполнение bunifu circle progressbar 
            if (circleProgressBar.Value == 100)
            {
                startTimer.Stop();
                Hide();

                var loginForm = new LoginForm();
                loginForm.Show();
            }
            else
            {
                circleProgressBar.Value += 1;
            }

            //В gif 30 кадров
            //Но воспроизводится слишком быстро, притормаживаем
            _frameCounter += 5;
            if (_frameCounter < 300)
            {
                Image.SelectActiveFrame(_frameDimension, _frameCounter / 10);
            }
            //Реплей gif
            else
            {
                _frameCounter = 0;
            }
        }
    }
}
