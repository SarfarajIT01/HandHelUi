using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandHelUi.Shared.Models
{
    public class MenuItem
    {
        public string? ItemCode { get; set; }
        public string? PosCode { get; set; }
        public string? PosName { get; set; }
        public string? GroupName { get; set; }
        public string? GroupCode { get; set; }
        public string? MenuCatCode { get; set; }
        public string? ItemName { get; set; }
        public string? VegNonVeg { get; set; }
        public string? MenuCategory { get; set; }
        public string? MenuCategoryName { get; set; }
        public string? OutletId { get; set; }
        public float? Rates { get; set; }
        public DateTime? FromDate { get; set; }
        public string? TaxType { get; set; }
        public string? TaxStruCode { get; set; }
        public float? MinRate { get; set; }
        public float? MaxRate { get; set; }

        // Add a collection for sub-items
        public List<List<SubItem>> SubItems { get; set; } = new();
        public List<List<CommonAddon>> CommonAddons { get; set; } = new();

    }

    public class SubItem
    {
        public Int16? SubGrpId { get; set; }
        public string? SubGrpName { get; set; }
        public string? SubItemName { get; set; }
        public float? SubItemRates { get; set; }
        public float? SubMinQty { get; set; }
        public float? SubMaxQty { get; set; }
        public string? IsAddon { get; set; }
        public string? SubitemNo { get; set; }
        public string? IsSubitem { get; set; }
    }

    public class CommonAddon
    {
        public Int16? SubGrpId { get; set; }
        public string? SubGrpName { get; set; }
        public string? SubItemName { get; set; }
        public float? SubItemRates { get; set; }
        public float? SubMinQty { get; set; }
        public float? SubMaxQty { get; set; }
    }

    //public class MenuItem
    //{
    //    public string? ItemCode { get; set; }
    //    public string? PosCode { get; set; }
    //    public string? PosName { get; set; }
    //    public string? GroupName { get; set; }
    //    public string? GroupCode { get; set; }
    //    public string? MenuCatCode { get; set; }
    //    public string? ItemName { get; set; }
    //    public string? VegNonVeg { get; set; }
    //    public string? MenuCategory { get; set; }
    //    public string? MenuCategoryName { get; set; }
    //    public string? OutletId { get; set; }
    //    public float? Rates { get; set; }
    //    public DateTime? FromDate { get; set; }
    //    public string? TaxType { get; set; }
    //    public float? MinRate { get; set; }
    //    public float? MaxRate { get; set; }



    //    // ✅ Change from List<SubItem> to grouped list
    //    public List<SubItemGroup> SubItemGroups { get; set; } = new();
    //}

    //public class SubItemGroup
    //{
    //    public string SubGrpName { get; set; }
    //    public List<SubItem> Items { get; set; } = new();
    //}

    //public class SubItem
    //{
    //    public string SubItemName { get; set; }
    //    public float SubItemRates { get; set; }
    //    public float MinQty { get; set; }
    //    public float MaxQty { get; set; }
    //}

}
