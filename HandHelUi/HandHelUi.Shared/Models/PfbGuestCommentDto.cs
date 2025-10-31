using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandHelUi.Shared.Models
{
    public class PfbGuestCommentDto
    {
        public string? OutletId { get; set; }
        public string? GCode { get; set; }
        public DateTime? GDov { get; set; }
        public DateTime? GTov { get; set; }
        public string? GBill { get; set; }
        public string? GVisitAs { get; set; }
        public string? GFov { get; set; }
        public string? GNegC { get; set; }
        public string? GPosC { get; set; }
        public string? GComment { get; set; }

        // Newly added columns
        public string? Steward { get; set; }
        public string? TableName { get; set; }
        public short? NoPax { get; set; }
        public string? FoodQuality { get; set; }
        public string? ServiceQuality { get; set; }
        public string? DiningQuality { get; set; }
        public string? ReferenceBy { get; set; }
        public string? MResp { get; set; }

        public DateTime? Birthday { get; set; }
        public DateTime? Anniversary { get; set; }
        public string? NewVisitor { get; set; }
        public string? NewGender { get; set; }

        public DateTime? Dob { get; set; }              //    Temp Param
        public DateTime? Mday { get; set; }            //    Temp Param
        public string? Email { get; set; }              //    Temp Param
        public string? GName { get; set; }             //    Temp Param
        public List<DynamicRatingItem> DynamicRating { get; set; } = new();
    }
    public class DynamicRatingItem
    {
        public string? group { get; set; }
        public string? rating { get; set; }
    }
}
