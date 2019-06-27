using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WEB_lab_final_.Models
{
    public class Sales
    {
        [Key]
        public int SaleId { set; get; }
        public int TyreId { set; get; }
        public int Quantity { set; get; }
        public string CustomerName { set; get; }
        [DataType(DataType.DateTime,ErrorMessage ="Invalid input")]
        public string TransitionDateTime { set; get; }
        public double CashReceived { set; get; }
    }
}