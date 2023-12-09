using Microsoft.AspNetCore.Http;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using StockApp.Model.ViewModel.Base;
using System.Web.Mvc;

namespace StockApp.Model.ViewModel.Product
{
    public class SearchProductViewModel : BaseViewModel
    {
      
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
 
        [Display(Name = "Barcode")]
        public string Barcode { get; set; }

        [Display(Name = "Category")]
        public int? CategoryId { get; set; }
  
        [Display(Name = "Unit Of Measure")]
        public int? UnitOfMeasureId { get; set; }

        public IEnumerable<SelectListItem> CategoryList { get; set; }
        public IEnumerable<SelectListItem> UnitOfMeasureList { get; set; }
    }
}
