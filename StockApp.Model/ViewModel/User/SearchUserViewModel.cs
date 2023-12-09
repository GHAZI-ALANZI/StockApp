using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using StockApp.Model.ViewModel.Base;

namespace StockApp.Model.ViewModel.User
{
    public class SearchUserViewModel : BaseViewModel
    {

        [Display]
        public string Email { get; set; }

        [Display]
        public string Name { get; set; }

        [Display]
        public string Surname { get; set; }
    }
}
