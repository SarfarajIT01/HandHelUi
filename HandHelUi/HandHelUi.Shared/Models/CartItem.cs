using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandHelUi.Shared.Models
{
    public class CartItem
    {
        public string? Name { get; set; }
        public int Qty { get; set; }
        public string? TaxType { get; set; }
        public string? TaxStruCode { get; set; }
        public string? IsAddon { get; set; }
        public string? IsSubitem { get; set; }
        public float Price { get; set; }
        public string? ItemCode { get; set; }
        public List<CartSubItem> CartSubItem { get; set; } = new();
    }

    public class CartSubItem
    {
        public float? SubMinQty { get; set; }
        public string? SubGrpName { get; set; }
        public string? SubItemName { get; set; }
        public float? SubItemRates { get; set; }
    }
}
