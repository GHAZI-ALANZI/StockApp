
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Web.Mvc;
using StockApp.Model.ViewModel.Base;

namespace StockApp.Model.ViewModel.Report.StoreStock
{
    public class SearchStoreStockReportViewModel : BaseViewModel
    {
        [Display(Name = "Product")]
        public int? ProductId { get; set; }

        [Display(Name = "Store")]
        public int? StoreId { get; set; }
        public IEnumerable<SelectListItem> StoreList { get; set; }
        public IEnumerable<SelectListItem> ProductList { get; set; }
    }
}
