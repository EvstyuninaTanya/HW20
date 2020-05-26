using System;
using System.Collections.Generic;
using System.Text;

namespace HW20.Business_object
{
    public class Product
    {
        public string productName { get; set; }
        public string category { get; set; }
        public string cat { get; set; }
        public string supplier { get; set; }
        public string sup { get; set; }
        public string setUnitPrice { get; set; }
        public string searchUnitPrice { get; set; }
        public string quantityPerUnit { get; set; }
        public string unitsInStock { get; set; }
        public string unitsOnOrder { get; set; }
        public string reorderLvl { get; set; }
        public Product(string productName, string category, string cat, string supplier, string sup, string setUnitPrice, string searchUnitPrice, string quantityPerUnit, string unitsInStock, string unitsOnOrder, string reorderLvl)
        {
            this.productName = productName;
            this.category = category;
            this.cat = cat;
            this.supplier = supplier;
            this.sup = sup;
            this.setUnitPrice = setUnitPrice;
            this.searchUnitPrice = searchUnitPrice;
            this.quantityPerUnit = quantityPerUnit;
            this.unitsInStock = unitsInStock;
            this.unitsOnOrder = unitsOnOrder;
            this.reorderLvl = reorderLvl;
        }
    }
}
