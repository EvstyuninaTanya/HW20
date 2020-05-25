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
        public string productNameId { get; set; }
        public string categoryId { get; set; }
        public string supplierId { get; set; }
        public string unitPriceId { get; set; }
        public string quantityPerUnitId { get; set; }
        public string unitsInStockId { get; set; }
        public string unitsOnOrderId { get; set; }
        public string reorderLvlId { get; set; }
        public Product(string prodactNameId, string categoryId, string supplierId, string unitPriceId, string quantityPerUnitId, string unitsInStockId, string unitsOnOrderId, string reorderLvlId)
        {
            this.productNameId = prodactNameId;
            this.categoryId = categoryId;
            this.supplierId = supplierId;
            this.unitPriceId = unitPriceId;
            this.quantityPerUnitId = quantityPerUnitId;
            this.unitsInStockId = unitsInStockId;
            this.unitsOnOrderId = unitsOnOrderId;;
            this.reorderLvlId = reorderLvlId;
        }
    }
}
