using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using StockApp.Model.ViewModel.Base;

namespace StockApp.Model.ViewModel.Category
{
    public class EditCategoryViewModel : BaseViewModel
    {
        [Required]
        [MaxLength(30)]
        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }
    }
}
