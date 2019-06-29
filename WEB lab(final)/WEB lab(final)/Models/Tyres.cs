using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WEB_lab_final_.Models
{
    public class Tyres
    {
        [Key]
        public int TyreId { set; get; }
        public string Brand { set; get; }
        public string Country { set; get; }
        [RegularExpression(@"^[\d]{3}/[\d]{2}/[\d]{2}$", ErrorMessage ="Input will  be in xxx/xx/xx format x = 0123...")]
        public string Size { set; get; }
        public string Condition { set; get; }
        public int Quantity { set; get; }
        public double Purchase_Price { set; get; }
        public double Selling_Price { set; get; }
    }
}