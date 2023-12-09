using System;
using System.Collections.Generic;
using System.Text;
using StockApp.Model.ViewModel.Base;

namespace StockApp.Model.ViewModel.Store
{
    public class ListStoreViewModel : BaseViewModel
    {
        public string StoreName { get; set; }
        public string StoreCode { get; set; }
    }
}
