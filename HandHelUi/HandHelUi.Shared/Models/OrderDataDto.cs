using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandHelUi.Shared.Models
{
    public class OrderDataDto
    {
        public string RBIL_TAXFREE { get; set; }
       
        public string Tbl { get; set; }
        public string Stw { get; set; }
        public int Amount { get; set; }
        public float TotalTax { get; set; }
        public float RBIL_TAMT { get; set; }
        public float RBIL_TOTAL { get; set; }
        public float RBIL_STX { get; set; }
        public float RBIL_OTX { get; set; }
        public float RBIL_DC1 { get; set; }
        public float RBIL_CVCHR2 { get; set; }
        public float RBIL_ROUND { get; set; }
        public float RBIL_TaxableDisc { get; set; }
        public List<string> ItemCode { get; set; }
        public List<string> StrQty { get; set; }
        public string pos { get; set; }
        public string cvr { get; set; }
        public string run_date { get; set; }


        public string flag { get; set; } = string.Empty;

        public string token { get; set; } = string.Empty;
        public string odrem { get; set; } = string.Empty;
        public string odtype { get; set; } = string.Empty;
        public List<string> ItemRemark { get; set; }
        public List<string> strAddon { get; set; }
        public string GstName { get; set; } = string.Empty;
        public List<string> strModi { get; set; }
        public List<string> strCombo { get; set; }
        public List<string> strHappy { get; set; }
        public List<string> strdisc { get; set; }
        public List<string> sub_item { get; set; }
        public List<string> cover_item { get; set; }
        public List<string> meal_item { get; set; }
        public string Disc_code { get; set; } = string.Empty;
        public string Disc_per { get; set; } = string.Empty;
        public string G_Code { get; set; } = string.Empty;
        public string G_Name { get; set; } = string.Empty;
        public List<TaxStructureGroupWise> TaxStructureGroupWise { get; set; }
        public List<TaxStructure> TaxStructure { get; set; }
        public List<TaxStructure2> TaxStructure2 { get; set; }
        public List<RKOT_TRN_DATA> RKOT_TRN_DATA { get; set; }

    }

    public class CurrBillItem
    {
        public string DisPer { get; set; }
        public string RKOT_SNO { get; set; }
    }
    public class TaxStructure
    {
        public string RTax_TCode { get; set; }
        public string RTax_OnAmt { get; set; }
        public string RTax_TaxAmt { get; set; }
    }
    public class TaxStructure2
    {
        public string seriesFlag { get; set; }
        public string RTax_TCode { get; set; }
        public string RTax_OnAmt { get; set; }
        public string RTax_TaxAmt { get; set; }
        public string RTax_TaxTyp { get; set; }
        public float TotalTax { get; set; }
        public float Otrcharge { get; set; }
        public float TotalSC { get; set; }
    }
    public class TaxStructureGroupWise
    {
        public string RTax_TCode { get; set; }
        public string RTax_OnAmt { get; set; }
        public string RTax_TaxAmt { get; set; }
        public string seriesFlag { get; set; }
        public string RBIL_TAMT { get; set; }
        public string RBIL_NAMT { get; set; }
        public string RBIL_STX { get; set; }
        public string RBIL_OTX { get; set; }
        public string RBIL_DC1 { get; set; }
        public string RBIL_CVCHR2 { get; set; }
        public string RBIL_ROUND { get; set; }
        public string RBIL_TaxableDisc { get; set; }
        public string RBIL_TOTAL { get; set; }

    }


    public class RKOT_TRN_DATA
    {
        public string RKOT_NO { get; set; }
        public string ItemCode { get; set; }
        public string DiscountPer { get; set; }
        public string RKOT_SNO { get; set; }
    }
}
