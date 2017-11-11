using System;
using System.Collections.Generic;
using Fsd.Kamil.Cs.Ex4.Data.Entities;
using Fsd.Kamil.Cs.Ex4.Data.Enums;
using PagedList;

namespace Fsd.Kamil.Cs.Ex4.Services.Services.Products
{
    public class ManualProductService : IManualProductService
    {
        public List<Product> OurProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    Producer = "Łowicz",
                    Model = "Truskawkowy",
                    Price = "5,20",
                    ProductionDate = new DateTime(2017,04,30),
                    Type = ProductTypes.Spożywcze
                },

                new Product
                {
                    Producer = "Domestos",
                    Model = "Morska bryza",
                    Price = "12,99",
                    ProductionDate = new DateTime(2017,10,4),
                    Type =ProductTypes.Chemia
                },

                new Product
                {
                    Producer = "Bluza",
                    Model = "Kaptur",
                    Price = "75,00",
                    ProductionDate = new DateTime(2017,09,03),
                    Type = ProductTypes.Ubrania
                },

                new Product
                {
                    Producer = "Samsung",
                    Model = "S9",
                    Price = "1234,00",
                    ProductionDate = new DateTime(2017,03,14),
                    Type = ProductTypes.Elektroniczne
                },

                new Product
                {
                    Producer = "Cif",
                    Model = "Łazienka",
                    Price = "32,99",
                    ProductionDate = new DateTime(2017,10,03),
                    Type = ProductTypes.Chemia
                },

                new Product
                {
                    Producer = "Vizir",
                    Model = "Bielsza biel",
                    Price = "45,00",
                    ProductionDate = new DateTime(2017,02,22),
                    Type = ProductTypes.Chemia
                },

                new Product
                {
                    Producer = "SmartGPS",
                    Model = "20N45",
                    Price = "349,99",
                    ProductionDate = new DateTime(2017,05,14),
                    Type = ProductTypes.Elektroniczne
                },

                new Product
                {
                    Producer = "Pierogi",
                    Model = "Ruskie",
                    Price = "14,00",
                    ProductionDate = new DateTime(2017,05,14),
                    Type = ProductTypes.Spożywcze
                },

                new Product
                {
                    Producer = "Bułka",
                    Model = "Zwykła",
                    Price = "0,50",
                    ProductionDate = new DateTime(2017,05,14),
                    Type = ProductTypes.Spożywcze
                },

                new Product
                {
                    Producer = "Jogurt",
                    Model = "Naturalny",
                    Price = "1,50",
                    ProductionDate = new DateTime(2017,08,31),
                    Type = ProductTypes.Spożywcze
                },

                new Product
                {
                    Producer = "Spodnie",
                    Model = "Ładne",
                    Price = "120,00",
                    ProductionDate = new DateTime(2017,03,20),
                    Type = ProductTypes.Ubrania
                },

                new Product
                {
                    Producer = "Robot kuchenny",
                    Model = "Master 2000",
                    Price = "439,99",
                    ProductionDate = new DateTime(2017,01,07),
                    Type = ProductTypes.Elektroniczne
                },
                new Product
                {
                    Producer = "Nokia",
                    Model = "3310",
                    Price = "200,00",
                    ProductionDate = new DateTime(2008,04,11),
                    Type = ProductTypes.Elektroniczne
                },

                new Product
                {
                    Producer = "Koszulka",
                    Model = "Lewandowski",
                    Price = "99,00",
                    ProductionDate = new DateTime(2017,06,30),
                    Type = ProductTypes.Ubrania
                },

                new Product
                {
                    Producer = "Samsung",
                    Model = "TVTR340",
                    Price = "3000,00",
                    ProductionDate = new DateTime(2016,12,11),
                    Type = ProductTypes.Elektroniczne
                },

                new Product
                {
                    Producer = "Sony",
                    Model = "Telefon",
                    Price = "750,00",
                    ProductionDate = new DateTime(2016,12,14),
                    Type = ProductTypes.Elektroniczne
                },

                new Product
                {
                    Producer = "CzystaSzyba",
                    Model = "Płyn do spryskiwaczy 2.0",
                    Price = "23",
                    ProductionDate = new DateTime(2017,11,07),
                    Type = ProductTypes.Chemia
                },

                new Product
                {
                    Producer = "Ludwik",
                    Model = "Cytrynowy",
                    Price = "5,99",
                    ProductionDate = new DateTime(2017,05,12),
                    Type = ProductTypes.Chemia
                },

                new Product
                {
                    Producer = "Lampka",
                    Model = "Nocna Power5",
                    Price = "78,24",
                    ProductionDate = new DateTime(2016,10,13),
                    Type = ProductTypes.Elektroniczne
                },

                new Product
                {
                    Producer = "Spodnie",
                    Model = "WF",
                    Price = "33,44",
                    ProductionDate = new DateTime(2017,07,08),
                    Type = ProductTypes.Ubrania
                }
            };
        }

        public IEnumerable<Product> GetProducts()
        {
            return OurProducts();
        }

        public IEnumerable<Product> SetPageItems(int page, int items)
        {
            List<Product> products = OurProducts();

            List<Product> OurProductsPageItems = new List<Product>();

            for (int i = 0; i <= (items - 1); i++)
            {
                OurProductsPageItems.Add(products[i]);
            }
            //chciałem zrobić z podziałem na strony (ToPageList), ale na razie się nie udało :/
            return OurProductsPageItems;
        }
    }
}
