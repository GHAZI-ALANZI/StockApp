﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using StockApp.Model.ViewModel.Base;

namespace StockApp.Model.ViewModel.Store
{
  public  class EditStoreViewModel:BaseViewModel
    {
        [Required]
        [MaxLength(30)]
        [Display(Name = "Store Name")]
        public string StoreName { get; set; }

        [Required]
        [MaxLength(10)]
        [Display(Name = "Store Code")]
        public string StoreCode { get; set; }
    }
}
