﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using StockApp.Model.ViewModel.Base;
using System.Web.Mvc;

namespace StockApp.Model.ViewModel.Product
{
    public class EditProductViewModel : BaseViewModel
    {
        [Required]
        [MaxLength(100)]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [MaxLength(50)]
        [Display(Name = "Barcode")]
        public string Barcode { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Image")]
        public string Image { get; set; }

        [Display(Name = "Image")]
        [RegularExpression(@"^.*\.(jpg|JPG|png|PNG|jpeg|JPEG)$")]
        public IFormFile ImageFile { get; set; }
        public string ImageDisplayURL { get; set; }

        [Display(Name = "Price")]
        public decimal? Price { get; set; }

        [Display(Name = "Category")]
        public int? CategoryId { get; set; }

        [Required]
        [Display(Name = "Unit Of Measure")]
        public int UnitOfMeasureId { get; set; }

        public IEnumerable<SelectListItem> CategoryList { get; set; }
        public IEnumerable<SelectListItem> UnitOfMeasureList { get; set; }
    }
}
