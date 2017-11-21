﻿using Fsd.Bartek.Ex4.Data.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Fsd.Bartek.Ex4.Web.Models
{
    public partial class ProductAddModel
    {
        //TODO validation message
        [Required]
        public string Producer { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public double Price { get; set; }

        [Required]
        [RegularExpression("([0-9][0-9][.][0-9][0-9][.][0-9]{4}|[0-9][.][0-9][0-9][.][0-9]{4})", ErrorMessage = "Invalid First Name")]
        public string ProductionData { get; set; }

        [Required]
        public int Type { get; set; }

        public IEnumerable<ProductSelectType> TypeList { get; set; }

        public bool AddFailed { get; set; }

        public ProductAddModel()
        {
            TypeList = new List<ProductSelectType>
            {
                new ProductSelectType()
                {
                    Id = 0,
                    Type = ProductsType.Computer
                },
                new ProductSelectType()
                {
                    Id = 1,
                    Type = ProductsType.Phone
                },
                new ProductSelectType()
                {
                    Id = 2,
                    Type = ProductsType.Book
                },
                new ProductSelectType()
                {
                    Id = 3,
                    Type = ProductsType.Software
                },
                new ProductSelectType()
                {
                    Id = 4,
                    Type = ProductsType.HeadPhones
                },
                new ProductSelectType()
                {
                    Id = 5,
                    Type = ProductsType.Hardware
                },
                new ProductSelectType()
                {
                    Id = 6,
                    Type = ProductsType.Watch
                }
            };
        }
    }
}