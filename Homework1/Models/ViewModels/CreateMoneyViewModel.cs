using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homework1.Models.ViewModels
{
    public class CreateMoneyViewModel
    {
        [Required]
        [DisplayName("類別")]      
        public int Type { get; set; }
        [Required]
        [DisplayName("金額")]
        [RegularExpression(@"[1-9]+[0-9]*", ErrorMessage ="只能輸入正整數")]
        public int Cost { get; set; }
        [Required]
        [DisplayName("日期")]
        [DataType(DataType.Date)]
        [Remote("Index", "Valid", ErrorMessage = "{0}不得大於今天")]
        public DateTime CostDate { get; set; }
        [Required(AllowEmptyStrings = false)]
        [DisplayName("備註")]
        [DataType(DataType.MultilineText)]
        [StringLength(100, ErrorMessage = "{0}最多輸入{1}個字元")]
        public string Memo { get; set; }
    }
}