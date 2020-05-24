using System;
using System.Collections.Generic;
using System.Text;

namespace HW20.Business_object
{
    public class Product
    {
        public string productNameId { get; set; }
        public string categoryId { get; set; }
        public string supplierId { get; set; }
        public string unitPriceId { get; set; }
        public string quantityPerUnitId { get; set; }
        public string unitsInStockId { get; set; }
        public string unitsOnOrderId { get; set; }
        public string reorderLvlId { get; set; }
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
        public Product(string prodactNameId,     string productName, 
                       string categoryId,        string category,        string cat, 
                       string supplierId,        string supplier,        string sup, 
                       string unitPriceId,       string setUnitPrice,    string searchUnitPrice, 
                       string quantityPerUnitId, string quantityPerUnit, 
                       string unitsInStockId,    string unitsInStock, 
                       string unitsOnOrderId,    string unitsOnOrder, 
                       string reorderLvlId,      string reorderLvl)
        {
            this.productNameId = prodactNameId;
            this.productName = productName;
            this.categoryId = categoryId;
            this.category = category;
            this.cat = cat;
            this.supplierId = supplierId;
            this.supplier = supplier;
            this.sup = sup;
            this.unitPriceId = unitPriceId;
            this.setUnitPrice = setUnitPrice;
            this.searchUnitPrice = searchUnitPrice;
            this.quantityPerUnitId = quantityPerUnitId;
            this.quantityPerUnit = quantityPerUnit;
            this.unitsInStockId = unitsInStockId;
            this.unitsInStock = unitsInStock;
            this.unitsOnOrderId = unitsOnOrderId;
            this.unitsOnOrder = unitsOnOrder;
            this.reorderLvlId = reorderLvlId;
            this.reorderLvl = reorderLvl;
        }
    }
}
