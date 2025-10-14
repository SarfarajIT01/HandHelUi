using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HandHelUi.Shared.Pages.Menu;

namespace HandHelUi.Shared.Models
{
    public class OrderItem
    {
        public DateTime? Date { get; set; }
        public string? PosCode { get; set; }         
        public string? PosName { get; set; }
        public string? OutletId { get; set; }
        public string? TableNumber { get; set; }
        public string? TableNo2 { get; set; }
        public float? TotalAmount { get; set; }
        public string? OrderNumber { get; set; }
        public string? OrderType { get; set; }
        public string? OrderStatus { get; set; }
        public string? GuestCode { get; set; }
        public string? GuestName { get; set; }
        public string? RSUM_BIL { get; set; }
        public short? Covor { get; set; }
        public string? RSUM_NAR { get; set; }
        public string? TotalItems { get; set; }          
        public string? RSUM_KOT { get; set; }
        public string? RSUM_CshC { get; set; }
        public string? RSUM_CSH { get; set; }
        public string? RSUM_EDT { get; set; }            
        public float? RSUM_AMT { get; set; }
        public string? RSUM_SUBTBL { get; set; }
        public string? RSUM_TIM { get; set; }
        public string? HH_DISC { get; set; }
        public string? RSUM_REMTYP { get; set; }
        public string? OrderRemark { get; set; }
        public string? TotalDisc { get; set; }
        public string? StewardEmpId { get; set; }
        public List<CartItems>? CartItem { get; set; }
    }

    public class CartItems
    {
        public string? RKOT_POP { get; set; }
        public string? RKOT_NO { get; set; }
        public string? RKOT_TYP { get; set; }
        public string? ItemName { get; set; }
        public string? ItemCode { get; set; }
        public float? Price { get; set; }
        public float? Quantity { get; set; }
        public float? RKOT_TAX { get; set; }
        public Int16? RKOT_SNO { get; set; }
        public string? TaxType { get; set; }
        public DateTime? RKOT_DAT { get; set; }
        public string? RKOT_TAXTYP { get; set; }
        public string? RKOT_REM { get; set; }
        public float? Rmnu_RAT { get; set; }
        public float? RKOT_DISC { get; set; }
        public string? RKOT_ADDON { get; set; }
        public string? TaxStruCode { get; set; }
        public string? RKOT_CVR { get; set; }
        public string? IsAddon { get; set; }
        public string? IsSubItem { get; set; }
        public string? RKOT_Modifier { get; set; }
        public string? GRP_SUB { get; set; }
        public string? RKOT_WQTY { get; set; }
        public string? RKOT_TYPE { get; set; }
        public string? RKOT_COMBO { get; set; }
        public string? COMBO_CODE { get; set; }
        public string? COMBO_FLAG { get; set; }
        public decimal? DiscountPer2 { get; set; }
        public decimal? Discount2 { get; set; }
        public string? OrderNo { get; set; }
        public string? RMNU_MODF { get; set; }
        public string? RMNU_ADDON_COD { get; set; }
        public string? RMNU_ADDON_STD { get; set; }
        public float? RMNU_ADDON_RATE { get; set; }
        public string? RMNU_M_COD { get; set; }
        public string? RMNU_M_STD { get; set; }
        public string? GRPSubName { get; set; }
        public string? UmeshSign { get; set; }
        public List<CartSubItems>? SubItem { get; set; }
    }

    public class CartSubItems
    {
        //[Required]
        public string? RKOT_POP { get; set; }
        public string? RKOT_NO { get; set; }
        public string? SubItemName { get; set; }
        public DateTime? RKOT_DAT { get; set; }
        public string? RKOT_MNU { get; set; }
        public Int16? RKOT_SNO { get; set; }
        public string? SubitemNo { get; set; }
        public Int16? SUB_SN { get; set; }
        public Int16? SUB_QTY { get; set; }
        public float? SubItemRates { get; set; }

    }
}
