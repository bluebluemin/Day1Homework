using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Homework1.Models.ViewModels
{
    public class CreateMoneyViewModel
    {
        [DisplayName("類別")]
        public int Type { get; set; }
        [DisplayName("金額")]
        public int Cost { get; set; }
        [DisplayName("日期")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CostDate { get; set; }
        [DisplayName("備註")]
        [DataType(DataType.MultilineText)]
        public string Memo { get; set; }
    }
}