using System;
using System.Collections.Generic;
using System.Text;
using StockApp.Model.ViewModel.Base;

namespace StockApp.Model.ViewModel.UnitOfMeasure
{
    public class SearchUnitOfMeasureViewModel : BaseViewModel
    {
        public string UnitOfMeasureName { get; set; }
        public string Isocode { get; set; }
    }
}
