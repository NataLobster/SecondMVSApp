using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SecondMVSApp.Models
{
    public class Purchase
    {
        //ID покупки
        public int PurchaseId { get; set; }
        //имя и фамилия покупателя
        public string Person { get; set; }
        //адрес покупателя
        public string Address { get; set; }
        //Id книги
        public int BookId { get; set; }
        //дата покупки
        public DateTime Date { get; set; }
    }
}