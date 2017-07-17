using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Homework1.Models.ViewModels
{
    public class MoneyViewModel
    {
        
        [DisplayName("類別")]
        public string Type { get; set; }
        [DisplayName("金額")]
        public int Cost { get; set; }
        [DisplayName("日期")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",ApplyFormatInEditMode =true)]
        public DateTime CostDate { get; set; }
    }
}