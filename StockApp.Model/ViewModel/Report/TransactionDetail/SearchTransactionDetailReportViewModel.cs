﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Web.Mvc;
using StockApp.Model.ViewModel.Base;

namespace StockApp.Model.ViewModel.Report.TransactionDetail
{
    public class SearchTransactionDetailReportViewModel: BaseViewModel
    {
        [Display(Name = "Transaction Code")]
        public string TransactionCode { get; set; }

        [Display(Name = "Product")]
        public int? ProductId { get; set; }

        [Display(Name = "Store")]
        public int? StoreId { get; set; }

        [Display(Name = "To Store")]
        public int? ToStoreId { get; set; }

        [Display(Name = "Start Date")]
        public string SearchStartDate { get; set; }

        [Display(Name = "End Date")]
        public string SearchEndDate { get; set; }

        [Display(Name = "Transaction Type")]
        public int? TransactionTypeId { get; set; }

        public IEnumerable<SelectListItem> StoreList { get; set; }
        public IEnumerable<SelectListItem> ProductList { get; set; }
        public IEnumerable<SelectListItem> ToStoreList { get; set; }
    }
}
