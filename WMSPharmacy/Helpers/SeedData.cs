using System;
using System.Collections.Generic;
using System.Data.Entity;
using WMSPharmacy.Model;

namespace WMSPharmacy.Helpers
{
    class SeedData : DropCreateDatabaseIfModelChanges<WmsPharmacyContext>
    {
        public SeedData(WmsPharmacyContext context)
        {
            //Создать и заполнить базу 

            //Все для упрощения ознокомления

            using (context)
            {
                //Типы товаров 
                var medicinesTypesList = new List<MedicinesTypes>
                {
                    new MedicinesTypes {MedicinesTypeName = "Patio"},
                    new MedicinesTypes {MedicinesTypeName = "Outdoors"},
                    new MedicinesTypes {MedicinesTypeName = "Pharmacy"},
                    new MedicinesTypes {MedicinesTypeName = "Electronics"},
                    new MedicinesTypes {MedicinesTypeName = "Pharmacy"},
                    new MedicinesTypes {MedicinesTypeName = "Garden"},
                    new MedicinesTypes {MedicinesTypeName = "Books"},
                    new MedicinesTypes {MedicinesTypeName = "Clothing"},
                    new MedicinesTypes {MedicinesTypeName = "Sports"},
                    new MedicinesTypes {MedicinesTypeName = "Jewelry"},
                    new MedicinesTypes {MedicinesTypeName = "Electronics"},
                    new MedicinesTypes {MedicinesTypeName = "Music"},
                    new MedicinesTypes {MedicinesTypeName = "Baby"},
                    new MedicinesTypes {MedicinesTypeName = "Movies"},
                    new MedicinesTypes {MedicinesTypeName = "Garden"},
                    new MedicinesTypes {MedicinesTypeName = "Books"},
                    new MedicinesTypes {MedicinesTypeName = "Health"},
                    new MedicinesTypes {MedicinesTypeName = "Outdoors"},
                    new MedicinesTypes {MedicinesTypeName = "Audible"},
                    new MedicinesTypes {MedicinesTypeName = "Clothing"},
                    new MedicinesTypes {MedicinesTypeName = "Shoes"},
                    new MedicinesTypes {MedicinesTypeName = "Sports"},
                    new MedicinesTypes {MedicinesTypeName = "Gifts"},
                    new MedicinesTypes {MedicinesTypeName = "Audible"},
                    new MedicinesTypes {MedicinesTypeName = "Office"},
                    new MedicinesTypes {MedicinesTypeName = "Computers"},
                    new MedicinesTypes {MedicinesTypeName = "Clothing"},
                    new MedicinesTypes {MedicinesTypeName = "Crafts"},
                    new MedicinesTypes {MedicinesTypeName = "Shoes"},
                    new MedicinesTypes {MedicinesTypeName = "Shoes"},
                    new MedicinesTypes {MedicinesTypeName = "Health"},
                    new MedicinesTypes {MedicinesTypeName = "Crafts"},
                    new MedicinesTypes {MedicinesTypeName = "Health"},
                    new MedicinesTypes {MedicinesTypeName = "Clothing"},
                    new MedicinesTypes {MedicinesTypeName = "Jewelry"},
                    new MedicinesTypes {MedicinesTypeName = "Books"},
                    new MedicinesTypes {MedicinesTypeName = "Garden"},
                    new MedicinesTypes {MedicinesTypeName = "Music"},
                    new MedicinesTypes {MedicinesTypeName = "Computers"},
                    new MedicinesTypes {MedicinesTypeName = "Books"},
                    new MedicinesTypes {MedicinesTypeName = "Crafts"},
                    new MedicinesTypes {MedicinesTypeName = "Outdoors"},
                    new MedicinesTypes {MedicinesTypeName = "Health"},
                    new MedicinesTypes {MedicinesTypeName = "Beauty"},
                    new MedicinesTypes {MedicinesTypeName = "Accessories"},
                    new MedicinesTypes {MedicinesTypeName = "Baby"},
                    new MedicinesTypes {MedicinesTypeName = "Games"},
                    new MedicinesTypes {MedicinesTypeName = "Gifts"},
                    new MedicinesTypes {MedicinesTypeName = "Baby"},
                    new MedicinesTypes {MedicinesTypeName = "Pharmacy"}
                };

                context.MedicinesTypes.AddRange(medicinesTypesList);
                context.SaveChanges();

                //Производители
                var manufacturersList = new List<Manufacturers>
                {
                    new Manufacturers {ManufacturerName = "Smart H-Mobile Co."},
                    new Manufacturers {ManufacturerName = "Federal Space Research Groups"},
                    new Manufacturers {ManufacturerName = "3WorldWide Partners Corporation"},
                    new Manufacturers {ManufacturerName = "Special Engineering Group"},
                    new Manufacturers {ManufacturerName = "General B-Mobile Corp."},
                    new Manufacturers {ManufacturerName = "Professional Wind Energy Inc."},
                    new Manufacturers {ManufacturerName = "Home Protection Corporation"},
                    new Manufacturers {ManufacturerName = "Home High-Technologies Group"},
                    new Manufacturers {ManufacturerName = "Pacific O-Mobile Group"},
                    new Manufacturers {ManufacturerName = "North Space Research Inc."},
                    new Manufacturers {ManufacturerName = "Union High-Technologies Corp."},
                    new Manufacturers {ManufacturerName = "Union Trust Inc."},
                    new Manufacturers {ManufacturerName = "Professional Business Co."},
                    new Manufacturers {ManufacturerName = "East Space Explore Corp."},
                    new Manufacturers {ManufacturerName = "First High-Technologies Inc."},
                    new Manufacturers {ManufacturerName = "North Telecom Corp."},
                    new Manufacturers {ManufacturerName = "South Travel Inc."},
                    new Manufacturers {ManufacturerName = "Pacific High-Technologies Group"},
                    new Manufacturers {ManufacturerName = "Canadian High-Technologies Inc."},
                    new Manufacturers {ManufacturerName = "WorldWide M-Mobile Co."},
                    new Manufacturers {ManufacturerName = "Special High Corporation"},
                    new Manufacturers {ManufacturerName = "First Systems Corporation"},
                    new Manufacturers {ManufacturerName = "International High Corp."},
                    new Manufacturers {ManufacturerName = "Creative Explore Corporation"},
                    new Manufacturers {ManufacturerName = "City G Wireless Co."},
                    new Manufacturers {ManufacturerName = "Creative Research Corp."},
                    new Manufacturers {ManufacturerName = "Canadian Space Explore Corp."},
                    new Manufacturers {ManufacturerName = "Future High-Technologies Co."},
                    new Manufacturers {ManufacturerName = "International Industry Inc."},
                    new Manufacturers {ManufacturerName = "West Coast I-Mobile Group"},
                    new Manufacturers {ManufacturerName = "Western Data Corp."},
                    new Manufacturers {ManufacturerName = "American Travel Corp."},
                    new Manufacturers {ManufacturerName = "National Data Corp."},
                    new Manufacturers {ManufacturerName = "American Explore Co."},
                    new Manufacturers {ManufacturerName = "National High Corporation"},
                    new Manufacturers {ManufacturerName = "Domestic Space Research Inc."},
                    new Manufacturers {ManufacturerName = "Smart Services Group"},
                    new Manufacturers {ManufacturerName = "Future S-Mobile Corp."},
                    new Manufacturers {ManufacturerName = "Special Space Explore Corp."},
                    new Manufacturers {ManufacturerName = "Future High Corporation"},
                    new Manufacturers {ManufacturerName = "Global Devices Corporation"},
                    new Manufacturers {ManufacturerName = "Western Petroleum Co."},
                    new Manufacturers {ManufacturerName = "National Mobile Inc."},
                    new Manufacturers {ManufacturerName = "Advanced E-Mobile Inc."},
                    new Manufacturers {ManufacturerName = "East Green Resources Group"},
                    new Manufacturers {ManufacturerName = "North Nuclear Resources Inc."}
                };

                context.Manufacturers.AddRange(manufacturersList);
                context.SaveChanges();

                //Роли
                var userRolesList = new List<UserRoles>
                {
                    new UserRoles {NameRole = "Администратор"},
                    new UserRoles {NameRole = "Computer Operator"},
                    new UserRoles {NameRole = "Travel Agent"},
                    new UserRoles {NameRole = "Application Development Supervisor"},
                    new UserRoles {NameRole = "Marketing Manager"},
                    new UserRoles {NameRole = "Application Engineer"},
                    new UserRoles {NameRole = "Technical Manager"},
                    new UserRoles {NameRole = "Assistant Vice President"},
                    new UserRoles {NameRole = "Service Manager"},
                    new UserRoles {NameRole = "QA Engineer"},
                    new UserRoles {NameRole = "Communication Consultant"},
                    new UserRoles {NameRole = "Senior Specialist"},
                    new UserRoles {NameRole = "Secretary"},
                    new UserRoles {NameRole = "Contract Manager"},
                    new UserRoles {NameRole = "Chief Technology Officer"},
                    new UserRoles {NameRole = "Contract Advisor"},
                    new UserRoles {NameRole = "Network Administrator"},
                    new UserRoles {NameRole = "Technical Specialist"},
                    new UserRoles {NameRole = "Area Administrator"},
                    new UserRoles {NameRole = "Finance Controller"},
                    new UserRoles {NameRole = "Senior Manager"},
                    new UserRoles {NameRole = "Secretary"},
                    new UserRoles {NameRole = "Senior Specialist"},
                    new UserRoles {NameRole = "Secretary"},
                    new UserRoles {NameRole = "Commercial Director"},
                    new UserRoles {NameRole = "Vice President"},
                    new UserRoles {NameRole = "Senior Advisor"},
                    new UserRoles {NameRole = "Channel Sales Manager"},
                    new UserRoles {NameRole = "Sales Coordinator"},
                    new UserRoles {NameRole = "Solution Architect"},
                    new UserRoles {NameRole = "Branch Manager"},
                    new UserRoles {NameRole = "President"},
                    new UserRoles {NameRole = "Chief Financial Officer"},
                    new UserRoles {NameRole = "Support Manager"},
                    new UserRoles {NameRole = "Advisor"},
                    new UserRoles {NameRole = "Director of Sales"},
                    new UserRoles {NameRole = "Business Analyst"},
                    new UserRoles {NameRole = "Business Consultant"},
                    new UserRoles {NameRole = "Billing Manager"},
                    new UserRoles {NameRole = "Customer Relations Supervisor"},
                    new UserRoles {NameRole = "Security Manager"},
                    new UserRoles {NameRole = "Vice President"},
                    new UserRoles {NameRole = "Assistant"},
                    new UserRoles {NameRole = "Director of Customer Support"},
                    new UserRoles {NameRole = "Secretary"},
                    new UserRoles {NameRole = "Project Manager"},
                    new UserRoles {NameRole = "Business Analyst"},
                    new UserRoles {NameRole = "Travel Agent"},
                    new UserRoles {NameRole = "Regional Manager"},
                    new UserRoles {NameRole = "Finance Manager"}
                };

                context.UserRoles.AddRange(userRolesList);
                context.SaveChanges();

                //Пользователи
                var usersList = new List<Users>
                {
                    new Users()
                    {
                        LastName = "Администратор",
                        FirstName = "Администратор",
                        MiddleName = "Администратор",
                        UserRole = 1,
                        Email = "admin",
                        Password = "$2y$10$0TdIkMfFe0Kytdx792aeDufHuIIbcP3uKOJaWUxLnEWlRZeKHC6ay"
                    },
                    new Users()
                    {
                        LastName = "Noland",
                        FirstName = "Kathrine",
                        MiddleName = "I.",
                        UserRole = 10,
                        Email = "CletusAlford929@nowhere.com",
                        Password = "25CWqtZnoitxRXkXsniHNGfSnIyncsKu73bww293yDU="
                    },
                    new Users()
                    {
                        LastName = "Hinto",
                        FirstName = "Rodrick",
                        MiddleName = "A",
                        UserRole = 11,
                        Email = " Beatty@nowhere.com",
                        Password = "Hh2R/jVO4L/05gfE+AlqGqT1qMxNIBOv4V5leMpuBoE="
                    },
                    new Users()
                    {
                        LastName = "Ritchey",
                        FirstName = "Kareem",
                        MiddleName = "Jewel",
                        UserRole = 48,
                        Email = "mftalix5377@nowhere.com",
                        Password = "EW6GiiENs6rnan869JBapy07lCpPKCq9onFCzg/D8j4="
                    },
                    new Users()
                    {
                        LastName = "Nole",
                        FirstName = "Avelina",
                        MiddleName = "U",
                        UserRole = 21,
                        Email = "Clemons391@example.com",
                        Password = "$2a$11$9awbtwC5K3hchEgQBCTN1u2mtPB3hrHw5rdfr69nI6"
                    },
                    new Users()
                    {
                        LastName = "Ritchie",
                        FirstName = "Jerrod",
                        MiddleName = "Abram",
                        UserRole = 35,
                        Email = "AllenHeffner446@example.com",
                        Password = "PPE3MkhWmTaWJ9JEMdogbwabGh87qOFsqDYOsGiBk5k="
                    },
                    new Users()
                    {
                        LastName = "Leggett",
                        FirstName = "Hermila",
                        MiddleName = "Reinaldo",
                        UserRole = 7,
                        Email = "HaskinsA577@example.com",
                        Password = "qyk1k2XjxA6KF8bBrgJBUuLhawU71c5OiLJ5ZGLkbAI="
                    },
                    new Users()
                    {
                        LastName = "Noona",
                        FirstName = "Deborah",
                        MiddleName = "Ernest",
                        UserRole = 5,
                        Email = "Archer@example.com",
                        Password = "CRZeqbknwzqDX4qhejVo4HpP+zyArxBfwtFcNDw/LWE="
                    },
                    new Users()
                    {
                        LastName = "Bales",
                        FirstName = "Alene",
                        MiddleName = "Jarrett",
                        UserRole = 29,
                        Email = "Upton@example.com",
                        Password = "xbckpwdSvFrgdtia9Uwtu+JYmlVNOg4nPQ+i/bNvZI4="
                    },
                    new Users()
                    {
                        LastName = "Hirsch",
                        FirstName = "Victorina",
                        MiddleName = "C.",
                        UserRole = 14,
                        Email = "Britt@example.com",
                        Password = "$2a$11$TroGXhFH0zO1cisZdssXXuxslrJqR.IsfnnkaL4vqV.awek11o.sW"
                    },
                    new Users()
                    {
                        LastName = "Ritter",
                        FirstName = "Marlo",
                        MiddleName = "X",
                        UserRole = 31,
                        Email = "Polly.Logan@nowhere.com",
                        Password = "ouemX7N4s0ELRPbpDwsRFFFLkJXwP10pQsdxSAbEn2U="
                    },
                    new Users()
                    {
                        LastName = "Sepulveda",
                        FirstName = "Lida",
                        MiddleName = "J",
                        UserRole = 36,
                        Email = "Gerald_R.Kinder@nowhere.com",
                        Password = "EIJg4qob4KdEpiS5cEmMqUfgMZP5JIcvm2ZU6gFnX/k="
                    },
                    new Users()
                    {
                        LastName = "Norfleet",
                        FirstName = "Migno",
                        MiddleName = "B",
                        UserRole = 13,
                        Email = "RichBuckner86@example.com",
                        Password = "E52h8Y+pofyZXWyCAxuq9xCzVTgnXU06XFqPAu7GAOI="
                    },
                    new Users()
                    {
                        LastName = "Tucker",
                        FirstName = "Jill",
                        MiddleName = "Q.",
                        UserRole = 21,
                        Email = "AntonySotelo@nowhere.com",
                        Password = "lnF7isJLhRAO+j5L2Ttnn+EpkAGG8xSXvzvoOEBWXXE="
                    },
                    new Users()
                    {
                        LastName = "Lehma",
                        FirstName = "Deloris",
                        MiddleName = "Abraham",
                        UserRole = 21,
                        Email = "CyndiVallejo@nowhere.com",
                        Password = "hIeLNeWjI2GVu1DxzORQy7xCGsHBpxNm9QpFMeu2+hc="
                    },
                    new Users()
                    {
                        LastName = "Rivas",
                        FirstName = "Abraham",
                        MiddleName = "Q",
                        UserRole = 1,
                        Email = " Sipes947@example.com",
                        Password = "fJhFZ4GIMNMLkWUROTjcR/kPv12uqR4UB/VAtn6nYYU="
                    },
                    new Users()
                    {
                        LastName = "Serna",
                        FirstName = "Manual",
                        MiddleName = "Hiram",
                        UserRole = 31,
                        Email = " Lavender@example.com",
                        Password = "TVQZychU2F/z4SLLJXlxZgHJ+u/zXrcd9ItViVOAu9o="
                    },
                    new Users()
                    {
                        LastName = "Noriega",
                        FirstName = "Dave",
                        MiddleName = "A",
                        UserRole = 32,
                        Email = " ScottKaye7@example.com",
                        Password = "rhjU0u7MB167ReWdaG7wIyviUokPGGDtQcQIkMFq19k="
                    },
                    new Users()
                    {
                        LastName = "Hitchcock",
                        FirstName = "Bento",
                        MiddleName = "T",
                        UserRole = 20,
                        Email = "Jewet@example.com",
                        Password = "R6XFzQrbc84O2+Zqp7T0/RPnB5WN//k+/5RRlwxTMu0="
                    },
                    new Users()
                    {
                        LastName = "Tuggle",
                        FirstName = "Jaso",
                        MiddleName = "O",
                        UserRole = 42,
                        Email = "AmadaCutler@example.com",
                        Password = "Y9IxvajDl1tzCH7+N4w2LHsQ64KI4WuQLNH2Xw18zoU="
                    },
                    new Users()
                    {
                        LastName = "Calhou",
                        FirstName = "Javier",
                        MiddleName = "Alec",
                        UserRole = 18,
                        Email = "Adams8@example.com",
                        Password = "aGiCwvLYJe+5dskYv71zuHfvDMaP9AXsF3wk00YR6QI="
                    },
                    new Users()
                    {
                        LastName = "Rivera",
                        FirstName = "Margart",
                        MiddleName = "Alexis",
                        UserRole = 1,
                        Email = "Carroll.Treadway@nowhere.com",
                        Password = "tY0V6JqVMyK3rI/A1uN3EMHqzSXYME79ACkEyxjvYsY="
                    },
                    new Users()
                    {
                        LastName = "Gist",
                        FirstName = "Odis",
                        MiddleName = "Javier",
                        UserRole = 48,
                        Email = " SallyAcker@nowhere.com",
                        Password = "TN9WPklW+2zOHjSK8gMS8TetcyGvUr948NeB98XNxa0="
                    },
                    new Users()
                    {
                        LastName = "Norma",
                        FirstName = "Antonia",
                        MiddleName = "T.",
                        UserRole = 44,
                        Email = " CedricAdcock@example.com",
                        Password = "EehTkRKDUB45Nj8CG6+d4tIhCUMD/0wBWzFnXy8YWBI="
                    },
                    new Users()
                    {
                        LastName = "Lehman",
                        FirstName = "Rodrigo",
                        MiddleName = "B",
                        UserRole = 37,
                        Email = " ktrwdldr.dfckx@example.com",
                        Password = "+tgLQCpJvlE1xts8+bRgUzAZBctX0mh+HQpT/GWanTA="
                    },
                    new Users()
                    {
                        LastName = "Rivers",
                        FirstName = "Ashly",
                        MiddleName = null,
                        UserRole = 4,
                        Email = " AckerF78@example.com",
                        Password = "QO0Xy5iroCnDRVuyEZ/47Y+yf0NIwdBUMZai/GXgNcc="
                    },
                    new Users()
                    {
                        LastName = "Norris",
                        FirstName = "Liane",
                        MiddleName = "Nathaniel",
                        UserRole = 34,
                        Email = " Leighton95@example.com",
                        Password = "8nxLz1TGIZuRd2GU2UYWy2Ufv4VjkqSjgXCNuNdbSv8="
                    },
                    new Users()
                    {
                        LastName = "Hobbs",
                        FirstName = "Addie",
                        MiddleName = "Efre",
                        UserRole = 26,
                        Email = " Blair822@example.com",
                        Password = "DNp+dqIySq/Iuz+ziR/jHacqP+XtOLTQzWeNXRmFWpc="
                    },
                    new Users()
                    {
                        LastName = "Leigh",
                        FirstName = "Minnie",
                        MiddleName = "Q",
                        UserRole = 39,
                        Email = " AbbieFite378@nowhere.com",
                        Password = "7RvaxiaNTrdki0p4kRH7iae2JWwKh8/Ryv8IuB//rH8="
                    },
                    new Users()
                    {
                        LastName = "Dooley",
                        FirstName = "Shakira",
                        MiddleName = "B",
                        UserRole = 37,
                        Email = " Lytle@example.com",
                        Password = "WdqGwkw5IfVUrRNtLoq3Fc6jpqcpFUMGuA9anNJeX4w="
                    },
                    new Users()
                    {
                        LastName = "Hobso",
                        FirstName = "Jed",
                        MiddleName = null,
                        UserRole = 20,
                        Email = "PaigeAnaya@example.com",
                        Password = "Cc9OGwPk/BPd0fmHBjasG27k2KdbKE5KXgkZWhLKchQ="
                    },
                    new Users()
                    {
                        LastName = "Ball",
                        FirstName = "Marcie",
                        MiddleName = "J",
                        UserRole = 1,
                        Email = " IolaHorowitz@nowhere.com",
                        Password = "AkXBYSIhn70+BYI9ukp/Gm9MYQNChMnHOqNqLjkBO2c="
                    },
                    new Users()
                    {
                        LastName = "Givens",
                        FirstName = "Arline",
                        MiddleName = "R.",
                        UserRole = 1,
                        Email = "Her@nowhere.com",
                        Password = "/FjkfFmuS5Vm7gTP5wEs0baFNgAhWRcyEKoSyNTwflM="
                    },
                    new Users()
                    {
                        LastName = "Rizzo",
                        FirstName = "Mel",
                        MiddleName = "Robby",
                        UserRole = 34,
                        Email = "Agnes.Osgood9@example.com",
                        Password = "X/kw9PtKcwykjFYbZ70buJC/FyGtigE0F8VNTj9Wm+0="
                    },
                    new Users()
                    {
                        LastName = "Dora",
                        FirstName = "Ciara",
                        MiddleName = "Z",
                        UserRole = 7,
                        Email = "Corey.Tran@nowhere.com",
                        Password = "N9vpvTXHPvh88dkuWc16zNtuztBxK/KWosAwdgc+310="
                    },
                    new Users()
                    {
                        LastName = "Serrano",
                        FirstName = "Adela",
                        MiddleName = "Ricky",
                        UserRole = 7,
                        Email = "IzolaShoemaker@example.com",
                        Password = "Er+SpbC5dnPStgHmM7keuSieaSTPj9zM6VoAKxKjb5M="
                    },
                    new Users()
                    {
                        LastName = "Calkins",
                        FirstName = "Jarrod",
                        MiddleName = "V.",
                        UserRole = 18,
                        Email = " BentonWoody@example.com",
                        Password = "jPGAwrT/SXN2TvW+kdVPff7JbwdAsFUQVl+v0WfKiT0="
                    },
                    new Users()
                    {
                        LastName = "North",
                        FirstName = "Alene",
                        MiddleName = "A",
                        UserRole = 9,
                        Email = "Chester_HKelsey@example.com",
                        Password = "Q7zaApYRnd0GEhhhsnmZj2TjWQ5eEJwLZyhWSAQ9jMA="
                    },
                    new Users()
                    {
                        LastName = "Roach",
                        FirstName = "Della",
                        MiddleName = "Abram",
                        UserRole = 15,
                        Email = "Reddick@nowhere.com",
                        Password = "fEzx52mCpzCoajxNu6z7JCFjMoFAkcSxcAjuMKKbpDY="
                    },
                    new Users()
                    {
                        LastName = "Gladde",
                        FirstName = "Larry",
                        MiddleName = "F",
                        UserRole = 19,
                        Email = "Dionne_Albertson@nowhere.com",
                        Password = "XZHwsjmOWA+YjdIOmTc0Xhye7Jt0N9r7Yp02fPHk9w8="
                    },
                    new Users()
                    {
                        LastName = "Ballard",
                        FirstName = "Germaine",
                        MiddleName = "Z",
                        UserRole = 21,
                        Email = " Agustina_Berrios@example.com",
                        Password = "2Gb6COttyx36LUQMSsAR/2CAsM0UDqelfgqpGBZZghQ="
                    },
                    new Users()
                    {
                        LastName = "Norto",
                        FirstName = "Andreas",
                        MiddleName = "Columbus",
                        UserRole = 3,
                        Email = "Mchugh738@nowhere.com",
                        Password = "XH0wNVCdSpah47zMya/LHZO8791H0GKuyGYMGEggCpg="
                    },
                    new Users()
                    {
                        LastName = "Roark",
                        FirstName = "Mac",
                        MiddleName = "R",
                        UserRole = 36,
                        Email = "Bunnell@nowhere.com",
                        Password = "il4gOiN+UEQyyRRK2D/uA3oKqYQxTpyA34ZIbhlE="
                    },
                    new Users()
                    {
                        LastName = "Norwood",
                        FirstName = "Destiny",
                        MiddleName = "Y.",
                        UserRole = 31,
                        Email = "Negrete3@example.com",
                        Password = "c5dWs4TyADFRS6OhpCAq2ny0EetaUlTkumTRnO4qYd0="
                    },
                    new Users()
                    {
                        LastName = "Hodge",
                        FirstName = "Carrol",
                        MiddleName = "Marcellus",
                        UserRole = 22,
                        Email = " vxvf8@example.com",
                        Password = "rBEzn/qPJwxPeB4KOSK7HIDZ3ubktpEco0U47ZrgPKo="
                    },
                    new Users()
                    {
                        LastName = "Lemaster",
                        FirstName = "Lucas",
                        MiddleName = "Y",
                        UserRole = 31,
                        Email = "Bollinger@nowhere.com",
                        Password = "mHp8AFziDHqcg0CvMhmsKlg55Tvb8GZ9U6TMDwueClU="
                    },
                    new Users()
                    {
                        LastName = "Turley",
                        FirstName = "Aurelio",
                        MiddleName = "B",
                        UserRole = 44,
                        Email = "Biggs192@example.com",
                        Password = "V55KZ0lv8f6YX/UlNzEwj/aiLC75lNRxjrk0u48cFbo="
                    },
                    new Users()
                    {
                        LastName = "Sessions",
                        FirstName = "Daniella",
                        MiddleName = null,
                        UserRole = 5,
                        Email = "Asia_Dube@example.com",
                        Password = "jl9uKja5kI/t5C0P1ciYgKPa86/kPoKHe432NeqP5og="
                    },
                    new Users()
                    {
                        LastName = "Hodges",
                        FirstName = "Da",
                        MiddleName = "Lando",
                        UserRole = 32,
                        Email = " Daley@example.com",
                        Password = "$2a$11$zMl4hOmcvAugLw7v4GYUIZOwbeS5N1ns2BYt6YIUKO"
                    }
                };

                context.Users.AddRange(usersList);
                context.SaveChanges();

                //Товары
                var medicinesList = new List<Medicines>
                {
                    new Medicines()
                    {
                        MedicineName = "Lisitamlam",
                        Manufacturer = 1,
                        MedicinesType = 8,
                        Quantity = 95,
                        Price = 38155.86,
                        Description =
                            "Sed eos quia qui at. Quam iure quisquam sit. Nemo et, odit sit quos nulla doloribus ipsa beatae est! Omnis et esse explicabo? Fuga sit sed. Doloremque perspiciatis quasi fugit maiores aut quos necessitatibus qui omnis! Quae voluptatem ut temporibus facilis quasi provident laborum quo qui voluptatem perspiciatis. Nihil officiis et accusamus officia porro architecto, sit voluptatem nesciunt illum voluptas? Ad dolorum placeat molestiae dolorem earum doloremque!Id totam itaque ad et eligendi et magni. Dolores doloremque accusantium et minus nobis unde vero dolore ad laboriosam. Debitis dolor quia? Incidunt natus nulla. Harum officiis provident. Repellendus beatae cumque; nulla nihil quo.",
                        Structure =
                            "Unspecified focal traumatic brain injury with loss of consciousness of any duration with death due to brain injury prior to regaining consciousness, sequela",
                        Diseases = "Driver of hv veh injured in nonclsn trnsp acc in traf, subs",
                        IsDrug = true
                    },
                    new Medicines()
                    {
                        MedicineName = "Hapaperanor",
                        Manufacturer = 23,
                        MedicinesType = 28,
                        Quantity = 40,
                        Price = 9656.68,
                        Description =
                            "Soluta modi, et omnis enim et ea ipsam est qui iusto ducimus. Qui vel ea architecto accusamus et impedit natus dolorem quis est sit. Quaerat numquam et quia blanditiis voluptas eius! Voluptatem fuga et accusamus consequatur dignissimos. Animi a sit ut.Animi officia voluptatibus voluptatem porro est rerum ut tenetur animi illum asperiores. Veniam exercitationem, quae placeat dolorem expedita optio nobis voluptas impedit harum sed. Blanditiis consequatur esse et, aut sit iure labore molestias dicta fugit consequatur. Esse corrupti ex est consectetur sit molestias dolore minima rerum error ipsam!",
                        Structure =
                            "Displaced fracture of middle third of navicular [scaphoid] bone of left wrist, initial encounter for open fracture",
                        Diseases = "Acute lacrimal canaliculitis of right lacrimal passage",
                        IsDrug = false
                    },
                    new Medicines()
                    {
                        MedicineName = "Enacurphane",
                        Manufacturer = 18,
                        MedicinesType = 27,
                        Quantity = 88,
                        Price = 89668.47,
                        Description =
                            "Autem qui ullam ut assumenda vero labore perspiciatis sed incidunt natus dignissimos. Sunt delectus qui illum autem in eaque aut possimus aut officiis omnis? Voluptate vitae nihil in illo harum doloribus non provident optio ullam enim.",
                        Structure = "Subluxation of metacarpophalangeal joint of unspecified thumb, sequela",
                        Diseases = "Insect bite (nonvenomous) of other finger, subs encntr",
                        IsDrug = false
                    },
                    new Medicines()
                    {
                        MedicineName = "Acycarpamdex",
                        Manufacturer = 42,
                        MedicinesType = 45,
                        Quantity = 42,
                        Price = 55445.18,
                        Description =
                            "Ipsum sed ullam. Molestiae ut nostrum cumque labore. Laboriosam fugit quia sint magnam tenetur est omnis. Soluta odio non voluptas sunt sit sunt sit pariatur; iste earum sit ullam sint reprehenderit libero alias omnis.Quia amet deleniti animi voluptates debitis sunt consectetur. Ullam est qui rem veritatis repudiandae esse sed. Quae sed quos provident quis et explicabo; placeat sed accusamus, sapiente et aspernatur error optio enim qui dolores consequatur. Deleniti recusandae sed tempora! Exercitationem id velit, consequatur et consequatur sunt in natus ut quas accusamus. Aut temporibus possimus non, qui dolorem sed consequuntur illo autem ut in!",
                        Structure = "Meningeal adhesions (cerebral) (spinal)",
                        Diseases = "Toxic effect of contact w oth jellyfish, self-harm, sequela",
                        IsDrug = true
                    },
                    new Medicines()
                    {
                        MedicineName = "Melihydrorex",
                        Manufacturer = 20,
                        MedicinesType = 1,
                        Quantity = 47,
                        Price = 31347.69,
                        Description =
                            "Qui consequatur aspernatur inventore esse aspernatur nemo ab corporis eos neque sint.",
                        Structure =
                            "Injury of unspecified nerve at lower leg level, unspecified leg, subsequent encounter",
                        Diseases = "Terrorism w chemical weapons, terrorist injured, subs",
                        IsDrug = true
                    },
                    new Medicines()
                    {
                        MedicineName = "Arisoprobid",
                        Manufacturer = 45,
                        MedicinesType = 28,
                        Quantity = 49,
                        Price = 27930.9,
                        Description =
                            "Corrupti voluptates ut qui fugit nulla iusto. Harum omnis vitae voluptatem, et laborum dolor nemo minima et quam repellendus. Et vero sed quos, voluptatem repudiandae aliquid maxime fugiat est corrupti nihil! Praesentium illo, laudantium qui rem rerum est accusantium fugit ut eos unde. Molestias nihil dicta non suscipit assumenda delectus iure fugit debitis sunt sed. Aperiam vero facere ut, vero dignissimos velit non debitis qui voluptates id. Obcaecati tenetur natus quod corporis id nemo voluptas ut voluptates sint magni. Ullam qui incidunt dolorem odio harum nemo sit omnis et in animi.",
                        Structure =
                            "Nondisplaced comminuted fracture of shaft of radius, right arm, subsequent encounter for open fracture type IIIA, IIIB, or IIIC with malunion",
                        Diseases = "Unspecified subluxation of unspecified radial head, sequela",
                        IsDrug = true
                    },
                    new Medicines()
                    {
                        MedicineName = "Hibihydroxol",
                        Manufacturer = 30,
                        MedicinesType = 21,
                        Quantity = 82,
                        Price = 16268.61,
                        Description =
                            "Exercitationem sed fugit hic ut dolorem ipsa vero nihil rem nulla excepturi. Ut culpa vel unde, quae quia vel sed reprehenderit consequuntur eos pariatur! Natus praesentium vel qui cupiditate error qui autem accusantium consequuntur nihil fugit...",
                        Structure =
                            "Poisoning by glucocorticoids and synthetic analogues, assault, subsequent encounter",
                        Diseases = "Unspecified subluxation of right foot, sequela",
                        IsDrug = false
                    },
                    new Medicines()
                    {
                        MedicineName = "Decotancept",
                        Manufacturer = 18,
                        MedicinesType = 23,
                        Quantity = 29,
                        Price = 11942.48,
                        Description =
                            "Consequatur eligendi quia quis unde quisquam et. Animi fugiat et hic ipsum voluptatem eos error quod! Nihil autem ex enim nam magnam soluta. Est omnis ex; porro eligendi harum corporis sunt deserunt est expedita voluptatem. Nam hic unde omnis ut omnis et provident necessitatibus voluptatem praesentium sint! Ut soluta incidunt deleniti minima amet quidem ipsum deleniti itaque fugit omnis. Ullam veritatis odio quia consectetur dolor nihil voluptates rerum et labore fuga. Explicabo illo voluptas illum molestiae aut fuga omnis voluptatem non esse dolore. Et dicta quod, aut officiis tenetur architecto assumenda fugit dolor perferendis et.",
                        Structure = "Unspecified displaced fracture of fifth cervical vertebra, sequela",
                        Diseases = "Squamous blepharitis right lower eyelid",
                        IsDrug = true
                    },
                    new Medicines()
                    {
                        MedicineName = "Zylasidorm",
                        Manufacturer = 19,
                        MedicinesType = 42,
                        Quantity = 97,
                        Price = 532.34,
                        Description =
                            "Quis et, quis ut suscipit alias perspiciatis sunt sapiente unde sit ducimus; vitae maxime distinctio. Odio aut modi dolorem placeat nihil cum a. Sapiente sunt beatae aperiam. Quisquam perspiciatis eos natus obcaecati eaque debitis culpa reprehenderit voluptatem tenetur et! Quia nesciunt sequi deserunt error aut rerum sed laborum quas...Aut non sed inventore. Facere voluptatum neque enim autem et possimus sapiente molestiae quasi voluptatem dignissimos. Ex quibusdam quae quasi repellat. Soluta sapiente sit laborum sit omnis assumenda et inventore enim accusamus? Illum fugit velit explicabo aut rem laborum qui! Reiciendis sed aut architecto, laudantium qui fugiat perspiciatis voluptas tempore quo quia. Perferendis vel animi!",
                        Structure = "Displaced segmental fracture of shaft of left fibula, sequela",
                        Diseases = "Lac w/o fb of unsp lesser toe(s) w/o damage to nail, sequela",
                        IsDrug = true
                    },
                    new Medicines()
                    {
                        MedicineName = "Gentamahex",
                        Manufacturer = 42,
                        MedicinesType = 11,
                        Quantity = 49,
                        Price = 293.73,
                        Description =
                            "Fugit non velit id illo totam ad ut mollitia laborum a sit. Iste sit excepturi obcaecati dolor iste unde aperiam rerum voluptas quia esse. Aut culpa qui molestiae perspiciatis explicabo repellat expedita cupiditate magni perspiciatis tempore; natus dolorum, impedit commodi iste consequuntur natus laboriosam rem suscipit quia eos. Odio maxime ipsum ut iste reprehenderit enim veritatis consequatur et error animi!Possimus quia enim vel ipsam consectetur eos voluptates facere sed quo explicabo. Repellat iste non voluptatem numquam velit eos ratione vitae odit esse praesentium.",
                        Structure = "Assault by other gas, air or spring-operated gun, subsequent encounter",
                        Diseases = "Corrosion of first degree of lower back, initial encounter",
                        IsDrug = false
                    },
                    new Medicines()
                    {
                        MedicineName = "Afchloridetad",
                        Manufacturer = 39,
                        MedicinesType = 4,
                        Quantity = 17,
                        Price = 49194.61,
                        Description =
                            "Est voluptates ipsum et sed voluptatem perspiciatis vel corporis ut doloribus sed. Adipisci aut eum repudiandae voluptatem et laboriosam officiis vitae vel, quia mollitia. Enim laudantium ut quia error inventore ut qui ut non et sit. Aut est impedit minus qui maxime impedit quis voluptatem at quia aperiam...",
                        Structure = "Gastric contents in pharynx causing other injury, sequela",
                        Diseases = "Nondisp fx of med condyle of l humer, 7thG",
                        IsDrug = true
                    },
                    new Medicines()
                    {
                        MedicineName = "Baychloridelat",
                        Manufacturer = 3,
                        MedicinesType = 37,
                        Quantity = 45,
                        Price = 70392.02,
                        Description =
                            "Qui cupiditate aut aperiam magni nihil soluta nemo excepturi vel reprehenderit eum; voluptates omnis rerum, sapiente qui numquam eius voluptate magni fugit officia sit. Qui eveniet voluptas id quia iste repudiandae consequuntur numquam animi eos aut. Voluptatem omnis nesciunt ad aut soluta magni ut sit accusantium exercitationem aut! Asperiores corrupti aliquam officiis itaque, quisquam fugit quia at laudantium illum magnam. Blanditiis ut consequatur, laborum sit quia tempora magnam natus ipsa deserunt quia.",
                        Structure =
                            "Unspecified fracture of lower end of right ulna, subsequent encounter for open fracture type I or II with delayed healing",
                        Diseases = "Disp fx of lower epiphysis (separation) of l femur, sequela",
                        IsDrug = false
                    },
                    new Medicines()
                    {
                        MedicineName = "Alponapex",
                        Manufacturer = 27,
                        MedicinesType = 8,
                        Quantity = 84,
                        Price = 83424.14,
                        Description =
                            "Sint doloribus reiciendis cumque, voluptas consequatur laboriosam aut enim sequi ut ratione.",
                        Structure = "Maternal care for malpresentation of fetus, unspecified, fetus 5",
                        Diseases = "Serum neuropathy",
                        IsDrug = true
                    },
                    new Medicines()
                    {
                        MedicineName = "Loxanaque",
                        Manufacturer = 11,
                        MedicinesType = 1,
                        Quantity = 72,
                        Price = 5.23,
                        Description =
                            "Molestias totam sint tenetur nulla nemo quasi unde error, aut iste porro. Unde rerum, consequuntur est sequi possimus et est aliquam fuga vero et. Non cupiditate, perferendis dolores sit tempore rerum laborum modi in nihil corporis. Voluptas enim quod unde est et dolor quia dolor aliquid sed omnis; sequi perspiciatis sunt qui vel et libero unde perspiciatis omnis quibusdam error? Ullam aliquam odio provident tenetur rem ut nisi velit similique ea voluptas.Et sunt tempora quia, ut veniam sequi et voluptate corrupti et nihil.",
                        Structure =
                            "Displaced comminuted fracture of shaft of unspecified fibula, initial encounter for open fracture type I or II",
                        Diseases = "Oth physl fx low end rad, r arm, subs for fx w routn heal",
                        IsDrug = false
                    },
                    new Medicines()
                    {
                        MedicineName = "Amcisilliq",
                        Manufacturer = 10,
                        MedicinesType = 42,
                        Quantity = 96,
                        Price = 44751.67,
                        Description =
                            "Nisi rerum beatae temporibus quo dolor iste voluptate dolor officiis omnis sed. Illo ex sed, reprehenderit velit sit placeat eum autem aut laudantium obcaecati. Cum non unde animi dolores in aliquid omnis quaerat et quis ad? Error enim, aut saepe ducimus autem non ut doloremque excepturi quidem sed. Itaque iure sit ut vel enim optio nihil, nesciunt accusamus et sit. Deleniti voluptatem assumenda inventore omnis possimus magnam aspernatur qui vitae eos rerum. Molestiae dolorem expedita ut, placeat ut exercitationem repellat voluptatem eligendi neque quae.",
                        Structure = "Small cell B-cell lymphoma, spleen",
                        Diseases = "Underweight",
                        IsDrug = false
                    },
                    new Medicines()
                    {
                        MedicineName = "Zapratraque",
                        Manufacturer = 19,
                        MedicinesType = 3,
                        Quantity = 9,
                        Price = 39132.99,
                        Description =
                            "Nihil dolorem voluptas sit numquam molestiae eligendi soluta est tempore doloribus ut. Nihil doloremque, id asperiores rerum aut velit odio ducimus aut error id.",
                        Structure =
                            "Puncture wound of abdominal wall without foreign body, left lower quadrant without penetration into peritoneal cavity, initial encounter",
                        Diseases = "Infect/inflm reaction due to indwell urinary catheter, subs",
                        IsDrug = false
                    },
                    new Medicines()
                    {
                        MedicineName = "Polyfade",
                        Manufacturer = 2,
                        MedicinesType = 5,
                        Quantity = 11,
                        Price = 511.6,
                        Description =
                            "Explicabo quis est ea officia et; magni molestiae tempora rerum. Itaque tempore sequi. Consequatur facere eligendi; iste fugiat tempora numquam nam et, culpa laborum et ut. Error minus nihil sit. Et repellendus voluptatem quo ratione asperiores voluptate quam aut ad et odit.Rerum fugit odit odio libero natus quia nihil magnam quibusdam saepe temporibus. Iste voluptatem assumenda modi! Maxime officia dolorem inventore consequuntur pariatur aliquid dicta. Veritatis voluptatibus unde necessitatibus ut nobis. Non eius aliquam. Quos accusantium omnis ex iste. Earum officiis eius unde inventore aspernatur est sit, aut architecto consequuntur eum; expedita quam quo facilis.",
                        Structure = "Adverse effect of anticholinesterase agents, sequela",
                        Diseases = "Displ spiral fx shaft of ulna, unsp arm, 7thJ",
                        IsDrug = false
                    },
                    new Medicines()
                    {
                        MedicineName = "Azizoque",
                        Manufacturer = 34,
                        MedicinesType = 24,
                        Quantity = 96,
                        Price = 7517.34,
                        Description =
                            "Voluptas sit expedita excepturi dolor unde quam est amet magnam quas molestias.Vel veniam sapiente voluptatem omnis tenetur consequatur dolorem neque natus cupiditate explicabo. Corrupti sed repellendus molestias amet quo delectus accusantium quis laborum expedita distinctio; vero ut debitis qui doloremque incidunt est et sed et autem nisi.",
                        Structure = "Malignant neoplasm of peripheral nerves of trunk, unspecified",
                        Diseases = "Nondisp fx of med phalanx of unsp less toe(s), 7thK",
                        IsDrug = true
                    },
                    new Medicines()
                    {
                        MedicineName = "Basconmuc",
                        Manufacturer = 29,
                        MedicinesType = 33,
                        Quantity = 91,
                        Price = 89605.78,
                        Description =
                            "Ut et quod omnis eaque totam. Accusantium id sed soluta nihil aspernatur fuga obcaecati harum iste. Nobis beatae et sunt assumenda autem quod culpa beatae fugit? Iste laboriosam voluptatem deleniti et.Libero temporibus quo et rerum et. Ut eos molestiae nemo dolore. Sunt distinctio provident alias aliquid maiores quo! Sit totam sit corrupti sapiente blanditiis ut velit. Corrupti perspiciatis, ipsam a architecto ea quia omnis error quidem sit eveniet! Rerum odio animi rerum, in iste adipisci cumque unde velit voluptatem quibusdam. Quae aut consequatur iste recusandae sit est voluptatem natus aut, quia porro.",
                        Structure =
                            "Unspecified fracture of upper end of right ulna, subsequent encounter for open fracture type IIIA, IIIB, or IIIC with nonunion",
                        Diseases = "Nondisp simp suprcndl fx w/o intrcndl fx r humer, 7thD",
                        IsDrug = false
                    },
                    new Medicines()
                    {
                        MedicineName = "Floclopin",
                        Manufacturer = 24,
                        MedicinesType = 33,
                        Quantity = 41,
                        Price = 67531.58,
                        Description = "Tempore porro sapiente ut harum eos laudantium omnis at sunt tempore sint.",
                        Structure = "Other chronic osteomyelitis, unspecified shoulder",
                        Diseases = "Fall into storm drain or manhole, subsequent encounter",
                        IsDrug = false
                    },
                    new Medicines()
                    {
                        MedicineName = "Hapapaxin",
                        Manufacturer = 14,
                        MedicinesType = 4,
                        Quantity = 56,
                        Price = 17746.64,
                        Description =
                            "Ut perferendis quas voluptate ullam, quia dolorem enim natus omnis et. Consequatur qui eum inventore cumque voluptatum autem? Qui sed explicabo, eius et minus velit consequatur id ea praesentium natus. Eius hic cum quia qui. Aut et dolorem, quam vel unde aperiam aut laboriosam excepturi deserunt nesciunt! Et sint nesciunt quo architecto deserunt autem ad temporibus pariatur aperiam minima? Dolor et ipsam cumque doloribus esse sequi eos illum nemo minus et. Odit accusantium illo laboriosam, omnis voluptatem ut odit beatae non eum facilis. Repellendus quasi et, laboriosam natus ipsum deleniti odio voluptatum ut odio eos.",
                        Structure = "Toxic effect of venom of bees, intentional self-harm, sequela",
                        Diseases = "Insect bite (nonvenomous) of l bk wl of thorax, sequela",
                        IsDrug = true
                    },
                    new Medicines()
                    {
                        MedicineName = "Adichloridene",
                        Manufacturer = 10,
                        MedicinesType = 32,
                        Quantity = 40,
                        Price = 51938.61,
                        Description =
                            "Sed officiis culpa tenetur cupiditate voluptatem quidem ut et eum aut vel. Veritatis ut veniam iste, soluta ea suscipit ex excepturi nobis! Sed sit delectus. Possimus qui tenetur natus unde nostrum illo maiores qui. Sequi vitae ad dolores quia unde adipisci. Unde vero minima enim sit. Dolorem ut rerum nisi nostrum nisi non ad excepturi, aliquam eos sit; eos minima molestias et ipsam placeat quis laboriosam soluta possimus assumenda temporibus. Et quia qui quas assumenda rerum consectetur ut sit sunt eligendi rerum; alias velit porro nisi, deleniti consequatur eaque sed architecto error aliquam veritatis.",
                        Structure = "Abnormal lead level in blood",
                        Diseases = "Displaced pilon fx left tibia, subs for clos fx w routn heal",
                        IsDrug = false
                    },
                    new Medicines()
                    {
                        MedicineName = "Carvicloque",
                        Manufacturer = 33,
                        MedicinesType = 22,
                        Quantity = 32,
                        Price = 66363.37,
                        Description =
                            "Qui ratione porro sed. Aut a et aut. Aperiam nemo ducimus tempore sint esse. Et suscipit non et omnis dolorem! Harum ea et quis nesciunt. Perferendis est cupiditate dolorum. Tempora totam nam natus odio repellat deserunt.Enim quas, est illum natus sed nesciunt ex dolorem porro sunt. Sed voluptas ex. Ab quae omnis rerum id magnam fugit maiores? Fugiat dignissimos cumque vero quod iste voluptatem voluptatum. Cum ut sed quo quod. Earum quasi non quaerat porro? Possimus commodi voluptatem iste iure voluptas consequuntur id eius est deleniti. Magnam vel rem, reiciendis tempora dolor numquam aut obcaecati sit. Magnam corrupti, eveniet sit et quasi totam dolorem delectus sit tempora dolores!",
                        Structure = "Malignant neoplasm of anterior wall of bladder",
                        Diseases = "Laceration of musc/fasc/tend at shldr/up arm, left arm, init",
                        IsDrug = false
                    },
                    new Medicines()
                    {
                        MedicineName = "Vomaclopren",
                        Manufacturer = 12,
                        MedicinesType = 23,
                        Quantity = 39,
                        Price = 79449.02,
                        Description =
                            "Eos odit consequatur nihil maxime eligendi harum accusantium dolor consequatur ut ipsum.",
                        Structure =
                            "Nondisplaced transverse fracture of unspecified patella, subsequent encounter for open fracture type IIIA, IIIB, or IIIC with routine healing",
                        Diseases = "Oth injury due to oth accident to oth powered wtrcrft, subs",
                        IsDrug = true
                    },
                    new Medicines()
                    {
                        MedicineName = "Osatanvir",
                        Manufacturer = 15,
                        MedicinesType = 47,
                        Quantity = 81,
                        Price = 67982.72,
                        Description =
                            "Voluptates voluptas rerum aut itaque quia et laudantium at similique quisquam impedit. Quia aliquid vitae architecto perspiciatis ad omnis rem doloremque soluta porro sed! Ipsa perspiciatis voluptatem veniam ut qui, cupiditate asperiores qui perspiciatis voluptatem voluptas. Non voluptatem ut voluptatum eos error aperiam unde earum rem delectus assumenda. Omnis atque sapiente unde incidunt eum natus consequuntur possimus cupiditate ex cum. Sed cum unde ea neque sit sed ut distinctio error tempora unde.",
                        Structure = "Partial traumatic amputation of left breast, sequela",
                        Diseases = "Assault by unspecified sharp object, initial encounter",
                        IsDrug = true
                    },
                    new Medicines()
                    {
                        MedicineName = "Felocarpamvant",
                        Manufacturer = 34,
                        MedicinesType = 13,
                        Quantity = 71,
                        Price = 7417.94,
                        Description =
                            "Dolorem a odit rem perferendis. Sit harum necessitatibus. Id labore consequatur quia laborum et eum iste blanditiis et perspiciatis expedita. Et aut unde quo ratione, ut sit dolorem iusto sunt consequatur rem. Aspernatur non quia similique reiciendis perspiciatis et non omnis, laborum praesentium maiores! Expedita eveniet ut natus accusamus, dolorum voluptatem quia eum sint voluptate ratione.Accusamus rerum aperiam sit ipsam eum rerum ut sit cum earum ipsam. Ipsa sed tempore perferendis error sed ea reprehenderit itaque eos soluta nemo. Atque aut unde quaerat quis saepe quas velit dolores quas eum quo!",
                        Structure =
                            "Unspecified fracture of right patella, subsequent encounter for open fracture type IIIA, IIIB, or IIIC with delayed healing",
                        Diseases = "Fx of skull and facial bones, subs for fx w delay heal",
                        IsDrug = true
                    },
                    new Medicines()
                    {
                        MedicineName = "Laxosoprozol",
                        Manufacturer = 32,
                        MedicinesType = 41,
                        Quantity = 3,
                        Price = 61219.28,
                        Description =
                            "In quasi ut dolorem mollitia vel quia quasi. Voluptatem est sit sequi, perspiciatis perferendis nihil id consequatur natus. Quas possimus laboriosam voluptatem delectus consequatur est aut odio. Magnam maxime corrupti similique doloremque officia hic sit aperiam. Ad ut dolor sit perspiciatis sit.Molestias dolorem ex praesentium laudantium accusantium enim. Quidem unde et quo cumque. Voluptate voluptatem non eius; aut cum enim sed culpa voluptas perspiciatis unde. Non deserunt non ea quam et ut saepe! Voluptas tempora natus, blanditiis fugit est necessitatibus reprehenderit quas natus nihil sint. Quasi hic unde vel rerum. Nihil vel velit voluptas tenetur inventore ad recusandae dolor.",
                        Structure =
                            "Toxic effect of unspecified halogen derivatives of aliphatic and aromatic hydrocarbons, undetermined, sequela",
                        Diseases = "Phantom limb syndrome without pain",
                        IsDrug = true
                    },
                    new Medicines()
                    {
                        MedicineName = "Oxitamphane",
                        Manufacturer = 20,
                        MedicinesType = 40,
                        Quantity = 46,
                        Price = 16879.95,
                        Description =
                            "Eius debitis sed autem ut ratione saepe est eos voluptatem. Similique ab sed nisi ratione molestiae quas nemo accusantium. Culpa ipsa dolores eveniet sed eius animi quae atque amet et id? Omnis porro dolor voluptate ut eaque voluptatibus beatae totam rem qui voluptatem. Sunt odit libero et? Rem expedita autem accusantium eos voluptatem. Necessitatibus nesciunt dolor quia et aut temporibus soluta quia quis amet ullam. Amet veniam dolor et!Fugit labore optio quia consequatur laudantium omnis laudantium est; voluptatibus qui repellendus. Qui ad inventore autem nihil reprehenderit repudiandae et! Autem voluptate unde aut excepturi.",
                        Structure = "Laceration of deep palmar arch of unspecified hand, subsequent encounter",
                        Diseases = "Disp fx of coracoid process, unsp shoulder, init for clos fx",
                        IsDrug = true
                    },
                    new Medicines()
                    {
                        MedicineName = "Paramaino",
                        Manufacturer = 34,
                        MedicinesType = 37,
                        Quantity = 94,
                        Price = 3.62,
                        Description =
                            "Est eos id quam. Placeat nobis ipsum quos pariatur rerum porro cum. Quia dolores id dignissimos minus ipsum sunt aspernatur! Dignissimos aut, quia fuga dolorum cum eum et sed dolorum eum non? Iste vel accusamus nesciunt, sunt iusto ipsam non ea aut sequi velit! Optio provident id vel quae voluptatem tempore labore error natus omnis nihil. Ipsum delectus nisi accusantium minus excepturi corporis nihil est ea, voluptatem et. Et eos nulla non vero sapiente voluptas, eos consequuntur unde tempora ea. Ut commodi a sunt ut illo inventore et tempora vel facilis est.",
                        Structure =
                            "Asphyxiation due to mechanical threat to breathing due to other causes, assault, subsequent encounter",
                        Diseases = "Separation of muscle (nontraumatic), unspecified hand",
                        IsDrug = false
                    },
                    new Medicines()
                    {
                        MedicineName = "Losasoprotex",
                        Manufacturer = 36,
                        MedicinesType = 47,
                        Quantity = 6,
                        Price = 86457.69,
                        Description =
                            "Voluptatem sit et iste ut voluptas ipsam molestiae nulla ex voluptatem suscipit. Numquam reiciendis sunt molestiae quod et magni vel at dolorem eos laudantium. Voluptas at, nihil dolor et iusto libero vitae voluptas iste dolores vero.",
                        Structure = "Other epilepsy, not intractable, without status epilepticus",
                        Diseases = "Drown due to oth accident to fishing boat, init",
                        IsDrug = true
                    },
                    new Medicines()
                    {
                        MedicineName = "Zytosoprocin",
                        Manufacturer = 5,
                        MedicinesType = 13,
                        Quantity = 6,
                        Price = 91425.78,
                        Description =
                            "Deleniti unde itaque sit eaque natus modi et atque suscipit velit quibusdam; beatae nihil velit maxime in incidunt, eligendi voluptate mollitia dolor sit facilis.",
                        Structure =
                            "Other physeal fracture of upper end of right femur, subsequent encounter for fracture with delayed healing",
                        Diseases = "Granulation of postmastoidectomy cavity, bilateral ears",
                        IsDrug = false
                    },
                    new Medicines()
                    {
                        MedicineName = "Laxospocose",
                        Manufacturer = 16,
                        MedicinesType = 46,
                        Quantity = 69,
                        Price = 54599.22,
                        Description =
                            "Ut molestias non. Iusto ut qui reprehenderit porro doloremque est; voluptatem placeat unde consectetur, reiciendis pariatur illo quis sint enim. Voluptatem iure voluptatem debitis quia dolores quam molestiae perspiciatis rerum minima sit. Rem voluptatem voluptas dolorem id quia incidunt et quidem molestias sit eius. Aliquid quos omnis, quis corporis voluptatem ipsa vitae nesciunt reprehenderit veniam non. Non libero, quibusdam reprehenderit et ullam non esse sequi tempora aut adipisci. Aliquid qui consectetur aperiam minima autem quaerat fuga ut accusantium ut ab; quo corporis odit quidem ratione cumque distinctio ipsam dolorem natus ratione ducimus.",
                        Structure = "Solar retinopathy, bilateral",
                        Diseases = "Displ spiral fx shaft of ulna, r arm, 7thG",
                        IsDrug = false
                    },
                    new Medicines()
                    {
                        MedicineName = "Aprobutamxel",
                        Manufacturer = 8,
                        MedicinesType = 19,
                        Quantity = 7,
                        Price = 4835.62,
                        Description =
                            "Repudiandae quia maiores illum eius molestiae et quia. Qui natus deleniti dolorum reprehenderit et, aut debitis eveniet voluptatibus. Consequatur nisi dolorem eum aliquam temporibus modi nostrum? Sit omnis et ad voluptatem autem dolorum nemo nihil. Debitis omnis fugit rem autem, aut veritatis eaque quo repellat velit iusto. Quia sit illo asperiores inventore consequatur eum magnam exercitationem laboriosam optio pariatur! Quod omnis id nostrum ut aperiam rerum cupiditate rerum non blanditiis facere. Aut qui rerum veniam necessitatibus dolores ut perspiciatis beatae mollitia repellendus ratione. Et quia reiciendis, quia perspiciatis alias et quo velit sit beatae laudantium.",
                        Structure = "Restless legs syndrome",
                        Diseases = "Oth fx shaft of l ulna, 7thR",
                        IsDrug = false
                    },
                    new Medicines()
                    {
                        MedicineName = "Eryspoxel",
                        Manufacturer = 44,
                        MedicinesType = 28,
                        Quantity = 90,
                        Price = 548.13,
                        Description =
                            "Quia sit et nulla veniam ut eos nesciunt odit et non a. Accusantium consequuntur sunt a ex esse, sint rerum molestias sint dignissimos aut...",
                        Structure = "Unspecified open wound of left thumb with damage to nail, subsequent encounter",
                        Diseases = "Disp fx of lateral condyle of unsp femr, 7thM",
                        IsDrug = true
                    },
                    new Medicines()
                    {
                        MedicineName = "Veloperavir",
                        Manufacturer = 10,
                        MedicinesType = 19,
                        Quantity = 15,
                        Price = 5853.83,
                        Description =
                            "Perspiciatis omnis iure aut sed dolorem sed velit. Consequatur voluptas ipsam architecto incidunt consequatur neque debitis est quod molestias quia? Reiciendis dolorem ad quia odit, ut omnis voluptatum animi iste sit. Sit recusandae qui. Voluptate laudantium ipsum ut aspernatur, natus est et repudiandae in. Placeat culpa error non cum rem quo nesciunt perspiciatis molestias quae earum! Praesentium consequatur error. Facere quam facilis et est error esse incidunt facilis. Doloribus labore nisi et consequatur suscipit.Esse aut dicta facilis enim libero tenetur eos natus. Ipsam qui sit. Assumenda explicabo et! Iste consequatur voluptatem. Voluptates repellendus ut. Voluptas aut autem! Perferendis et vel.",
                        Structure =
                            "Unspecified injury of extensor muscle, fascia and tendon of right little finger at wrist and hand level, subsequent encounter",
                        Diseases = "Disp fx of shaft of left clavicle, subs for fx w nonunion",
                        IsDrug = true
                    },
                    new Medicines()
                    {
                        MedicineName = "Neocurvex",
                        Manufacturer = 22,
                        MedicinesType = 19,
                        Quantity = 92,
                        Price = 9453.18,
                        Description =
                            "Voluptatem sed obcaecati atque amet cupiditate ipsa ullam consequatur veniam rerum deserunt. Illo ex facere sit omnis mollitia dolores qui nobis doloribus ratione quis. Ipsum recusandae, debitis eligendi quia fugit natus eveniet eum facilis cum repudiandae!Amet et expedita unde ut, et omnis numquam qui eaque quis dignissimos. Aliquid suscipit fuga, ullam delectus praesentium velit consequatur ipsam similique delectus distinctio. Eum laudantium nesciunt omnis perferendis ut, eius dolor perspiciatis nihil minus recusandae. Officiis optio eligendi laudantium voluptas natus obcaecati modi sequi aut quas dolorem.",
                        Structure =
                            "Strain of muscle(s) and tendon(s) of the rotator cuff of left shoulder, initial encounter",
                        Diseases = "Displaced spiral fracture of shaft of left femur, init",
                        IsDrug = false
                    },
                    new Medicines()
                    {
                        MedicineName = "Medroperipren",
                        Manufacturer = 1,
                        MedicinesType = 4,
                        Quantity = 84,
                        Price = 41354.99,
                        Description =
                            "Ratione sit dolorum ullam rerum qui quibusdam qui provident consequuntur; qui alias ipsam tempora sunt. Veritatis et ut quibusdam. Fugit autem aut vero quidem inventore eligendi veniam culpa, consequatur eos quisquam! Ad sint debitis aut repudiandae cupiditate quis cum quo et voluptatum aut. Ducimus porro unde, iste perferendis provident vitae libero molestiae non qui ab? Dolores quo quis harum velit quo, dolore ipsam distinctio quae nihil eaque. Et aut nihil omnis enim, fugit error assumenda velit animi sit perspiciatis! Optio est fugit reprehenderit esse consequuntur, rem vitae mollitia est quia ut.",
                        Structure = "Subacute osteomyelitis, left humerus",
                        Diseases = "Traumatic arthropathy, left wrist",
                        IsDrug = true
                    },
                    new Medicines()
                    {
                        MedicineName = "Candicarpamtan",
                        Manufacturer = 41,
                        MedicinesType = 20,
                        Quantity = 39,
                        Price = 61258.06,
                        Description =
                            "Suscipit quas delectus nemo aut sunt aliquid dolor est hic delectus tenetur. Quia ratione qui est illum quia omnis tenetur reprehenderit accusantium id natus. Molestiae sequi aut est veniam quos quasi laboriosam provident omnis est quia! Eaque tempore accusamus culpa eum iste pariatur, consequuntur dolores sed in consequatur? Laudantium suscipit nesciunt optio natus placeat et non nihil repellat suscipit rerum. Eius recusandae est aspernatur aliquam doloremque, minima omnis expedita delectus illum deleniti.",
                        Structure =
                            "Maternal care for other known or suspected poor fetal growth, unspecified trimester, other fetus",
                        Diseases = "Strain flexor musc/fasc/tend r mid fngr at wrs/hnd lv, subs",
                        IsDrug = true
                    },
                    new Medicines()
                    {
                        MedicineName = "Influfaino",
                        Manufacturer = 13,
                        MedicinesType = 43,
                        Quantity = 76,
                        Price = 7406.51,
                        Description =
                            "Qui et ut numquam accusantium voluptatem consequatur. Odit placeat unde ipsa voluptas perspiciatis modi molestiae error labore. Rerum et rerum non sed amet quasi aliquid.Adipisci fugit rem iure natus id velit, tempore velit perspiciatis ea ipsam. Ab ipsum quisquam quod quo et! Vitae iste dolorem voluptatem quis recusandae, quisquam tenetur facilis qui voluptas qui? Ea non animi veniam similique est. Voluptatum quo reiciendis unde animi quam debitis. Ullam nam modi autem ut et sed blanditiis id rerum porro qui. Earum temporibus eligendi! Et id cupiditate at. Consequatur dolorem non qui est pariatur doloribus sunt dolore quo quod voluptatem.",
                        Structure =
                            "Nondisplaced fracture of lateral condyle of right femur, subsequent encounter for open fracture type IIIA, IIIB, or IIIC with delayed healing",
                        Diseases = "Puncture wound with foreign body of left breast, sequela",
                        IsDrug = true
                    },
                    new Medicines()
                    {
                        MedicineName = "Chlorninor",
                        Manufacturer = 41,
                        MedicinesType = 1,
                        Quantity = 73,
                        Price = 48968.71,
                        Description =
                            "Quia labore dolores fugiat aperiam et fugit, dignissimos deleniti unde est dignissimos.Aut sed doloribus sed ut quisquam sit vel error enim in enim. Est debitis qui quam, rerum laborum voluptatum eaque temporibus sit dignissimos molestias. Provident sit sunt sed magnam expedita necessitatibus sit eos ea ab veritatis.",
                        Structure =
                            "Pathological fracture, left tibia, subsequent encounter for fracture with routine healing",
                        Diseases = "Car passenger injured in collision w SUV nontraf, subs",
                        IsDrug = true
                    },
                    new Medicines()
                    {
                        MedicineName = "Iproxadene",
                        Manufacturer = 5,
                        MedicinesType = 20,
                        Quantity = 65,
                        Price = 7465.87,
                        Description =
                            "Enim voluptatem ut. Eum id iure maiores nostrum molestias. Autem distinctio maxime ut, porro nihil enim voluptate vitae officiis. Omnis et quam, aut consectetur autem aut cum et praesentium omnis! Dolorum aliquam blanditiis necessitatibus distinctio ut enim. Suscipit dolorem est consequatur sed nemo! Ex ea voluptatem sit, obcaecati quaerat eveniet sit et iure sed et. Quod porro numquam sit ipsum rem consequuntur consequatur sed minus dolorem qui? Sint aut eos perferendis modi beatae et sunt itaque aut et dolor. Eum dolores quis qui nesciunt quaerat qui sit quaerat quia consequuntur ex.",
                        Structure = "Other classical Hodgkin lymphoma, lymph nodes of axilla and upper limb",
                        Diseases = "Corros 3rd deg mu sites of shldr/up lmb, ex wrs/hnd, sqla",
                        IsDrug = false
                    },
                    new Medicines()
                    {
                        MedicineName = "Betathromypren",
                        Manufacturer = 30,
                        MedicinesType = 17,
                        Quantity = 41,
                        Price = 1951.38,
                        Description =
                            "Et autem iusto qui esse odio repudiandae quibusdam porro ut sit molestiae. Quae quaerat voluptates sunt recusandae unde suscipit at suscipit ea qui eos. Nulla voluptatibus suscipit quidem rerum eum vel amet asperiores nemo totam dignissimos.",
                        Structure =
                            "Other fractures of lower end of right radius, subsequent encounter for open fracture type I or II with delayed healing",
                        Diseases = "Labor and delivery comp by vascular lesion of cord, fetus 4",
                        IsDrug = false
                    },
                    new Medicines()
                    {
                        MedicineName = "Afsoprozyl",
                        Manufacturer = 3,
                        MedicinesType = 12,
                        Quantity = 9,
                        Price = 93739.55,
                        Description =
                            "Rerum et minus ea optio, animi quam suscipit recusandae natus. Qui illum quia neque fuga perspiciatis fugit et illo eum. Nostrum vel ut recusandae sunt et repellat sed. Voluptatibus quisquam esse molestiae dolor aut non velit. Enim eligendi perspiciatis vel iste qui eveniet ut.Laboriosam ex veniam ut quo possimus facere adipisci. Et unde velit aut est. Omnis tenetur quia dolores quos nostrum. Et ratione pariatur aperiam natus! Veritatis dolores nihil qui recusandae. Doloribus odit aut recusandae sunt voluptatem quisquam ut! Dolor accusantium vel expedita et dolor consequatur, atque ad quas architecto voluptatum? Cupiditate beatae sed. Consequatur natus dolorem. Et iste qui.",
                        Structure =
                            "Nondisplaced spiral fracture of shaft of left tibia, subsequent encounter for closed fracture with malunion",
                        Diseases = "Nonspecific lymphadenitis, unspecified",
                        IsDrug = true
                    },
                    new Medicines()
                    {
                        MedicineName = "Acipabid",
                        Manufacturer = 44,
                        MedicinesType = 15,
                        Quantity = 32,
                        Price = 8983.59,
                        Description =
                            "Nisi adipisci debitis rerum illum. Ab qui natus reiciendis! Consectetur qui, et facere repellendus provident magnam consectetur nemo quo repellat dignissimos.Corrupti cupiditate at, unde explicabo dolorem eum voluptas et perspiciatis eveniet placeat. Nostrum aut architecto nihil et blanditiis error delectus quia consequatur officia vitae? Voluptatem praesentium cumque ipsa dolorem perspiciatis consequatur, unde nisi ut nam omnis! Laudantium error voluptatem est culpa laborum dolor officiis maiores aut vel debitis. Corrupti recusandae perferendis, sed beatae explicabo cum voluptatem unde consectetur natus distinctio. Provident sit obcaecati est iure vitae possimus optio consequatur dolorum accusantium labore.",
                        Structure = "Unspecified injury of left external jugular vein, subsequent encounter",
                        Diseases = "Person inj in clsn betw car and 2/3-whl mv, nontraf, sequela",
                        IsDrug = false
                    },
                    new Medicines()
                    {
                        MedicineName = "Candixafen",
                        Manufacturer = 4,
                        MedicinesType = 4,
                        Quantity = 95,
                        Price = 84545.28,
                        Description =
                            "Adipisci eveniet officiis voluptatum molestiae ipsam velit voluptatem voluptatibus earum blanditiis vero.",
                        Structure = "Unspecified complication following an ectopic and molar pregnancy",
                        Diseases = "Unspecified lagophthalmos left upper eyelid",
                        IsDrug = true
                    },
                    new Medicines()
                    {
                        MedicineName = "Dermoxaino",
                        Manufacturer = 25,
                        MedicinesType = 47,
                        Quantity = 4,
                        Price = 70537.49,
                        Description =
                            "Iste obcaecati aspernatur quia quis et voluptate rerum minima perspiciatis. Voluptas error impedit et beatae tempore molestias molestiae. Voluptatem eos dignissimos error beatae consequuntur inventore, error tempora velit ut necessitatibus! Qui non sit.Expedita molestias debitis iste sit quis. Ratione neque sed rem ducimus dolorem sed recusandae. Est quis laboriosam facilis culpa sequi consequatur velit non. Quia qui culpa minima, aliquid libero et voluptatem similique atque veniam quos. Dolorem architecto suscipit. Commodi veritatis est temporibus odit facere possimus illo nihil obcaecati. Et perspiciatis animi? Et praesentium a! Quaerat ipsum temporibus, minus eos laborum adipisci qui sit quam ut labore.",
                        Structure = "Superficial foreign body of right ear, sequela",
                        Diseases = "Unspecified transfusion reaction, sequela",
                        IsDrug = true
                    },
                    new Medicines()
                    {
                        MedicineName = "Dexidipizyl",
                        Manufacturer = 34,
                        MedicinesType = 8,
                        Quantity = 69,
                        Price = 34602.07,
                        Description =
                            "Commodi quae quos velit voluptatem ducimus aut veniam optio quia sapiente fuga. Repellendus perferendis voluptatem maiores ut saepe esse quis quam sit aspernatur amet. Sed earum quos cupiditate sequi quidem voluptatem natus aliquid maiores ab iure! Vel velit, eum hic ut molestias nihil omnis provident pariatur voluptatem ea.",
                        Structure = "Agenesis and aplasia of uterus",
                        Diseases = "Exposure to infrared radiation, subsequent encounter",
                        IsDrug = false
                    },
                    new Medicines()
                    {
                        MedicineName = "Tamoperaque",
                        Manufacturer = 36,
                        MedicinesType = 48,
                        Quantity = 3,
                        Price = 43.92,
                        Description =
                            "Aliquid ex iste ut dolorem error nesciunt, rerum repellat earum quisquam ut. Natus mollitia perferendis velit id voluptatem numquam, quisquam eos pariatur voluptatem ut; consequatur distinctio aut quia nobis sunt tempora, magnam et exercitationem neque quia; officia et consequuntur cum rem aliquam id, optio doloribus explicabo temporibus molestiae.",
                        Structure = "Other vascular syndromes of brain in cerebrovascular diseases",
                        Diseases = "Oth malignant neoplasm skin/ left upper limb, inc shoulder",
                        IsDrug = false
                    },
                    new Medicines()
                    {
                        MedicineName = "Allerpurilat",
                        Manufacturer = 43,
                        MedicinesType = 2,
                        Quantity = 19,
                        Price = 20451.99,
                        Description =
                            "Excepturi accusantium rerum autem sit assumenda et. Ex dolorum nam perspiciatis error vel natus impedit! Totam voluptatem dolorem. Consequatur quia ipsam earum non. Quia voluptatum natus earum voluptatum temporibus tempore doloribus! Vel voluptatibus ratione dolorem necessitatibus ut. Architecto dicta rerum provident dolores natus? Repellendus rerum est quis aut.Quod ad voluptatem omnis deleniti a quas. Soluta enim ut fuga quidem; cumque ullam ut itaque ipsum. Voluptas pariatur nam sit natus eos; ut iusto maiores dolores at? Obcaecati inventore veritatis nisi quia autem rerum voluptas vel sapiente unde non. Voluptates omnis pariatur? Qui vitae nihil delectus. Alias sunt ullam. A dolor laboriosam.",
                        Structure = "Myositis ossificans progressiva, unspecified finger(s)",
                        Diseases = "Unsp fracture of left femur, init for opn fx type I/2",
                        IsDrug = false
                    },
                    new Medicines()
                    {
                        MedicineName = "Dynadipicept",
                        Manufacturer = 24,
                        MedicinesType = 17,
                        Quantity = 6,
                        Price = 1053.31,
                        Description =
                            "Corrupti alias rerum vel laudantium aut ut in unde ea. Voluptatem ullam illo ut aut numquam. Sequi itaque, laudantium fugit nesciunt repellat omnis eveniet natus perspiciatis reprehenderit dolores. Ipsa error quisquam assumenda laudantium; ea voluptate eveniet perspiciatis exercitationem quia et; numquam voluptatem dolorem alias assumenda rerum iste vero consequatur tenetur veniam.Soluta molestias consequatur natus et voluptas similique eum qui ratione corporis. Maiores quo quisquam ut iure! Exercitationem aliquam, a aut sunt sed aut vero inventore omnis eius temporibus. Laborum animi quod odit qui pariatur ducimus sunt est ut et nihil!",
                        Structure =
                            "Displaced comminuted fracture of shaft of radius, right arm, initial encounter for open fracture type I or II",
                        Diseases = "Late congenital syphilitic arthropathy",
                        IsDrug = false
                    }
                };

                context.Medicines.AddRange(medicinesList);
                context.SaveChanges();

                //История
                var historyList = new List<History>
                {
                    new History()
                    {
                        UserName = 29,
                        Medicines = 32,
                        WasQuantity = 16,
                        HasQuantity = 3,
                        DateOfChange = DateTime.Parse(@"19/06/2021 17:35:00")
                    },
                    new History()
                    {
                        UserName = 24,
                        Medicines = 23,
                        WasQuantity = 29,
                        HasQuantity = 44,
                        DateOfChange = DateTime.Parse(@"06/05/2021 12:12:00")
                    },
                    new History()
                    {
                        UserName = 26,
                        Medicines = 41,
                        WasQuantity = 31,
                        HasQuantity = 7,
                        DateOfChange = DateTime.Parse(@"01/12/2012 19:47:00")
                    },
                    new History()
                    {
                        UserName = 2,
                        Medicines = 21,
                        WasQuantity = 83,
                        HasQuantity = 61,
                        DateOfChange = DateTime.Parse("03/02/2021 13:29:00")
                    },
                    new History()
                    {
                        UserName = 13,
                        Medicines = 32,
                        WasQuantity = 83,
                        HasQuantity = 99,
                        DateOfChange = DateTime.Parse("06/09/2021 14:00:00")
                    },
                    new History()
                    {
                        UserName = 9,
                        Medicines = 49,
                        WasQuantity = 85,
                        HasQuantity = 84,
                        DateOfChange = DateTime.Parse("12/04/2021 15:46:00")
                    },
                    new History()
                    {
                        UserName = 31,
                        Medicines = 18,
                        WasQuantity = 36,
                        HasQuantity = 69,
                        DateOfChange = DateTime.Parse("04/01/2021 18:02:00")
                    },
                    new History()
                    {
                        UserName = 48,
                        Medicines = 40,
                        WasQuantity = 63,
                        HasQuantity = 8,
                        DateOfChange = DateTime.Parse("12/02/2021 20:43:00")
                    },
                    new History()
                    {
                        UserName = 6,
                        Medicines = 3,
                        WasQuantity = 49,
                        HasQuantity = 35,
                        DateOfChange = DateTime.Parse("01/06/2021 11:05:00")
                    },
                    new History()
                    {
                        UserName = 46,
                        Medicines = 22,
                        WasQuantity = 95,
                        HasQuantity = 46,
                        DateOfChange = DateTime.Parse("06/05/2021 14:25:00")
                    },
                    new History()
                    {
                        UserName = 33,
                        Medicines = 28,
                        WasQuantity = 4,
                        HasQuantity = 82,
                        DateOfChange = DateTime.Parse("02/02/2021 07:37:00")
                    },
                    new History()
                    {
                        UserName = 40,
                        Medicines = 1,
                        WasQuantity = 24,
                        HasQuantity = 5,
                        DateOfChange = DateTime.Parse("12/12/2021 19:50:00")
                    },
                    new History()
                    {
                        UserName = 19,
                        Medicines = 44,
                        WasQuantity = 48,
                        HasQuantity = 4,
                        DateOfChange = DateTime.Parse("09/11/2021 19:21:00")
                    },
                    new History()
                    {
                        UserName = 44,
                        Medicines = 6,
                        WasQuantity = 84,
                        HasQuantity = 32,
                        DateOfChange = DateTime.Parse("06/10/2021 20:43:00")
                    },
                    new History()
                    {
                        UserName = 14,
                        Medicines = 31,
                        WasQuantity = 79,
                        HasQuantity = 74,
                        DateOfChange = DateTime.Parse("12/10/2021 00:33:00")
                    },
                    new History()
                    {
                        UserName = 25,
                        Medicines = 47,
                        WasQuantity = 98,
                        HasQuantity = 85,
                        DateOfChange = DateTime.Parse("07/08/2021 23:39:00")
                    },
                    new History()
                    {
                        UserName = 20,
                        Medicines = 50,
                        WasQuantity = 25,
                        HasQuantity = 96,
                        DateOfChange = DateTime.Parse("01/12/2021 13:02:00")
                    },
                    new History()
                    {
                        UserName = 36,
                        Medicines = 42,
                        WasQuantity = 5,
                        HasQuantity = 90,
                        DateOfChange = DateTime.Parse("04/09/2021 10:19:00")
                    },
                    new History()
                    {
                        UserName = 16,
                        Medicines = 48,
                        WasQuantity = 13,
                        HasQuantity = 85,
                        DateOfChange = DateTime.Parse("11/11/2021 20:16:00")
                    },
                    new History()
                    {
                        UserName = 16,
                        Medicines = 11,
                        WasQuantity = 92,
                        HasQuantity = 23,
                        DateOfChange = DateTime.Parse("04/02/2021 08:14:00")
                    },
                    new History()
                    {
                        UserName = 4,
                        Medicines = 34,
                        WasQuantity = 30,
                        HasQuantity = 4,
                        DateOfChange = DateTime.Parse("02/09/2021 17:51:00")
                    },
                    new History()
                    {
                        UserName = 29,
                        Medicines = 24,
                        WasQuantity = 31,
                        HasQuantity = 22,
                        DateOfChange = DateTime.Parse("12/04/2021 01:17:00")
                    },
                    new History()
                    {
                        UserName = 33,
                        Medicines = 6,
                        WasQuantity = 85,
                        HasQuantity = 13,
                        DateOfChange = DateTime.Parse("02/07/2021 01:55:00")
                    },
                    new History()
                    {
                        UserName = 10,
                        Medicines = 8,
                        WasQuantity = 20,
                        HasQuantity = 18,
                        DateOfChange = DateTime.Parse("08/12/2021 22:19:00")
                    },
                    new History()
                    {
                        UserName = 30,
                        Medicines = 16,
                        WasQuantity = 7,
                        HasQuantity = 59,
                        DateOfChange = DateTime.Parse("12/12/2021 20:00:00")
                    },
                    new History()
                    {
                        UserName = 38,
                        Medicines = 18,
                        WasQuantity = 20,
                        HasQuantity = 67,
                        DateOfChange = DateTime.Parse("11/11/2021 03:05:00")
                    },
                    new History()
                    {
                        UserName = 34,
                        Medicines = 11,
                        WasQuantity = 56,
                        HasQuantity = 76,
                        DateOfChange = DateTime.Parse("10/08/2021 21:53:00")
                    },
                    new History()
                    {
                        UserName = 9,
                        Medicines = 22,
                        WasQuantity = 39,
                        HasQuantity = 6,
                        DateOfChange = DateTime.Parse("03/06/2021 22:19:00")
                    },
                    new History()
                    {
                        UserName = 13,
                        Medicines = 40,
                        WasQuantity = 2,
                        HasQuantity = 29,
                        DateOfChange = DateTime.Parse("11/07/2021 15:04:00")
                    },
                    new History()
                    {
                        UserName = 7,
                        Medicines = 38,
                        WasQuantity = 77,
                        HasQuantity = 98,
                        DateOfChange = DateTime.Parse("04/03/2021 14:08:00")
                    },
                    new History()
                    {
                        UserName = 23,
                        Medicines = 33,
                        WasQuantity = 76,
                        HasQuantity = 9,
                        DateOfChange = DateTime.Parse(@"01/08/2021 15:59:00")
                    },
                    new History()
                    {
                        UserName = 30,
                        Medicines = 24,
                        WasQuantity = 7,
                        HasQuantity = 25,
                        DateOfChange = DateTime.Parse("10/03/2021 23:28:00")
                    },
                    new History()
                    {
                        UserName = 25,
                        Medicines = 8,
                        WasQuantity = 55,
                        HasQuantity = 1,
                        DateOfChange = DateTime.Parse("06/05/2021 12:03:00")
                    },
                    new History()
                    {
                        UserName = 46,
                        Medicines = 2,
                        WasQuantity = 10,
                        HasQuantity = 13,
                        DateOfChange = DateTime.Parse(@"05/12/2021 14:59:00")
                    },
                    new History()
                    {
                        UserName = 41,
                        Medicines = 49,
                        WasQuantity = 64,
                        HasQuantity = 67,
                        DateOfChange = DateTime.Parse("03/05/2021 15:06:00")
                    },
                    new History()
                    {
                        UserName = 40,
                        Medicines = 45,
                        WasQuantity = 62,
                        HasQuantity = 69,
                        DateOfChange = DateTime.Parse("03/07/2021 21:33:00")
                    },
                    new History()
                    {
                        UserName = 15,
                        Medicines = 4,
                        WasQuantity = 89,
                        HasQuantity = 77,
                        DateOfChange = DateTime.Parse("12/04/2021 21:34:00")
                    },
                    new History()
                    {
                        UserName = 22,
                        Medicines = 12,
                        WasQuantity = 6,
                        HasQuantity = 26,
                        DateOfChange = DateTime.Parse("12/03/2021 11:15:00")
                    },
                    new History()
                    {
                        UserName = 4,
                        Medicines = 4,
                        WasQuantity = 11,
                        HasQuantity = 46,
                        DateOfChange = DateTime.Parse("04/05/2021 15:15:00")
                    },
                    new History()
                    {
                        UserName = 3,
                        Medicines = 16,
                        WasQuantity = 39,
                        HasQuantity = 89,
                        DateOfChange = DateTime.Parse("07/07/2021 16:43:00")
                    },
                    new History()
                    {
                        UserName = 23,
                        Medicines = 12,
                        WasQuantity = 67,
                        HasQuantity = 7,
                        DateOfChange = DateTime.Parse("12/02/2021 17:04:00")
                    },
                    new History()
                    {
                        UserName = 29,
                        Medicines = 30,
                        WasQuantity = 95,
                        HasQuantity = 89,
                        DateOfChange = DateTime.Parse("03/12/2021 17:01:00")
                    },
                    new History()
                    {
                        UserName = 32,
                        Medicines = 24,
                        WasQuantity = 38,
                        HasQuantity = 50,
                        DateOfChange = DateTime.Parse("01/02/2021 00:54:00")
                    },
                    new History()
                    {
                        UserName = 22,
                        Medicines = 11,
                        WasQuantity = 1,
                        HasQuantity = 80,
                        DateOfChange = DateTime.Parse("02/11/2021 21:48:00")
                    },
                    new History()
                    {
                        UserName = 9,
                        Medicines = 37,
                        WasQuantity = 3,
                        HasQuantity = 79,
                        DateOfChange = DateTime.Parse("03/09/2021 20:39:00")
                    },
                    new History()
                    {
                        UserName = 34,
                        Medicines = 22,
                        WasQuantity = 61,
                        HasQuantity = 32,
                        DateOfChange = DateTime.Parse("02/02/2021 12:18:00")
                    },
                    new History()
                    {
                        UserName = 32,
                        Medicines = 45,
                        WasQuantity = 17,
                        HasQuantity = 77,
                        DateOfChange = DateTime.Parse("07/06/2021 14:59:00")
                    },
                    new History()
                    {
                        UserName = 6,
                        Medicines = 6,
                        WasQuantity = 23,
                        HasQuantity = 65,
                        DateOfChange = DateTime.Parse("09/12/2021 14:20:00")
                    },
                    new History()
                    {
                        UserName = 22,
                        Medicines = 45,
                        WasQuantity = 49,
                        HasQuantity = 11,
                        DateOfChange = DateTime.Parse("01/04/2021 20:23:00")
                    },
                    new History()
                    {
                        UserName = 29,
                        Medicines = 39,
                        WasQuantity = 50,
                        HasQuantity = 17,
                        DateOfChange = DateTime.Parse("06/04/2021 17:06:00")
                    }
                };

                context.History.AddRange(historyList);
                context.SaveChanges();
            }
        }
    }
}