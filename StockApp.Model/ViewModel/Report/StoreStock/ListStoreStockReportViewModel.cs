﻿using System;
using System.Collections.Generic;
using System.Text;
using StockApp.Model.ViewModel.Base;

namespace StockApp.Model.ViewModel.Report.StoreStock
{
    public class ListStoreStockReportViewModel : BaseViewModel
    {
        public string QTY { get; set; }
        public string StoreFullName { get; set; }
        public string ProductFullName { get; set; }
    }
}
