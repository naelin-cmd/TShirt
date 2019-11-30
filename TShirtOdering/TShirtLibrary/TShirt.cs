using SQLite;
using System;
using System.Text;
using SQLitePCL;

namespace TShirtLibrary
{
    public class TShirt
    {
 [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string TShirtSize { get; set; }
        public DateTime DateofOrder { get; set; }
        public string Color { get; set; }
        public string ShippingAddress { get; set; }

    }
}
