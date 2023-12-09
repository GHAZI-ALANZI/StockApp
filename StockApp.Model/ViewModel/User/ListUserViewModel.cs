using System;
using System.Collections.Generic;
using System.Text;
using StockApp.Model.ViewModel.Base;

namespace StockApp.Model.ViewModel.User
{
    public class ListUserViewModel : BaseViewModel
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
