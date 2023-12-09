using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using StockApp.Model.ViewModel.Base;

namespace StockApp.Model.ViewModel.Store
{
    public class SearchStoreViewModel : BaseViewModel
    {

        [Display(Name = "Store Name")]
        public string StoreName { get; set; }


        [Display(Name = "Store Code")]
        public string StoreCode { get; set; }
    }
}
