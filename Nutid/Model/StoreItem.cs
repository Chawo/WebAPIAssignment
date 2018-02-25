using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nutid.Model
{ 
    public class StoreItem
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public List<StoreItemDescription> StoreItemDescriptions { get; set; }
        public List<StoreItemPrice> StoreItemPrices { get; set; }
        public StoreDepartment StoreDepartment { get; set; }
        public string Barcode { get; set; }
        public List<StoreItemStorageAmount> StoreItemStorageAmounts { get; set; }
        public string ItemNumber { get; set; }
        public string CatalogNumber { get; set; }
        public string Extra1 { get; set; }
        public string Extra2 { get; set; }
        public string Extra3 { get; set; }
        public string Extra4 { get; set; }
        public string Extra5 { get; set; }
        public string Extra6 { get; set; }
        public string Extra7 { get; set; }
        public string Extra8 { get; set; }
        public string Extra9 { get; set; }
        public string Extra10 { get; set; }
        public string Extra11 { get; set; }
        public string Extra12 { get; set; }
        public Unit Unit { get; set; }
        public bool Deleted { get; set; }
    }

    public class StoreItemDescription
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int LandId { get; set; }
        public string Description { get; set; }
    }

    public class StoreItemPrice
    {
        public int Id { get; set; }
        public int LandId { get; set; }
        public decimal BuyPrice { get; set; }
        public decimal Sellprice { get; set; }
    }

    public class StoreDepartment
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int StoreId { get; set; }
        public bool Sales { get; set; }
        public List<StoreDepartmentName> StoreDepartmentNames { get; set; }
        public string Account { get; set; }
        public string IncomeAccount { get; set; }
        public string SalesAccount { get; set; }
        public bool Vmb { get; set; }
        public string SpcsAccount { get; set; }
    }

    public class StoreDepartmentName
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int LandId { get; set; }
    }


    public class StoreItemStorageAmount
    {
        public int Id { get; set; }
        public StorageSpot StorageSpot { get; set; }
        public decimal Amount { get; set; }
    }

    public class StorageSpot
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Description { get; set; }
        public bool IsDefault { get; set; }
    }

    public class Unit
    {
        public int Id { get; set; }
        public string Type { get; set; }
    }

}