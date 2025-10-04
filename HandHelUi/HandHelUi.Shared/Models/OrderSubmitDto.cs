using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandHelUi.Shared.Models
{
    public class OrderSubmitDto
    {
        public DateTime Date { get; set; }
        [Required]
        public string POS { get; set; }
        public string TableNo { get; set; }
        public string TableNo2 { get; set; }
        [Required]
        public string OrderNo { get; set; }
        public string OrderType { get; set; }
        public string OrderStatus { get; set; }
        public string guest_code { get; set; }
        public string guest_name { get; set; }
        public string RSUM_CVR { get; set; }
        public string RSUM_NAR { get; set; }
        public string RSUM_CshC { get; set; }
        public string RSUM_TBL { get; set; }
        [Required]
        public string RSUM_POP { get; set; }
        public string RSUM_BIL { get; set; }
        [Required]
        public string RSUM_KOT { get; set; }
        public string RSUM_NO { get; set; }
        public string RSUM_CSH { get; set; }
        public string RSUM_EDT { get; set; }
        public string RSUM_TYP { get; set; }

        public float RSUM_AMT { get; set; }
        public string RSUM_SUBTBL { get; set; }
        public string RSUM_STW { get; set; }
        public string RSUM_STS { get; set; }
        public string RSUM_DAT { get; set; }
        public string RSUM_TIM { get; set; }
        public string HH_DISC { get; set; }
        public string RSUM_REMTYP { get; set; }
        public string RSUM_REM { get; set; }
        public string ordertyp { get; set; }
        public string Remark { get; set; }
        public string DISC_TYP { get; set; }
        public string TotalDisc { get; set; }

        public List<itemdetail> itemdata { get; set; }
        //public List<Bill_Parameter> billdata { get; set; }
        public string GRPSubName { get; set; }

        //public List<TaxStructure> TaxStructure { get; set; }
        //public List<TaxStructureGroupWise> TaxStructureGroupWise { get; set; }
        //public List<TaxStructure2> TaxStructure2 { get; set; }
        //public List<RKOT_TRN_DATA> RKOT_TRN_DATA { get; set; }
        //public List<CurrBillItem> CurrBillItem { get; set; }
        public string RBIL_TAXFREE { get; set; }
        public string RBIL_NAMT { get; set; }
        public string RBIL_TAMT { get; set; }

    }

    public class itemdetail
    {
        public string ItemCat { get; set; }
        public string ItemCat2 { get; set; }
        public string ItemGrp { get; set; }
        public string ItemGrp2 { get; set; }
        public string VEG_NONVEG { get; set; }
        public string ItemName { get; set; }

        public string RKOT_POP { get; set; }
        public string RKOT_NO { get; set; }
        public string RKOT_TYP { get; set; }
        public string RKOT_MNU { get; set; }
        public float RKOT_RAT { get; set; }
        public float RKOT_QTY { get; set; }
        public float RKOT_TAX { get; set; }
        public Int16 RKOT_SNO { get; set; }
        public DateTime RKOT_DAT { get; set; }
        public string RKOT_TAXTYP { get; set; }
        public string RKOT_REM { get; set; }
        public float Rmnu_RAT { get; set; }
        public float RKOT_DISC { get; set; }
        public string RKOT_ADDON { get; set; }
        public string RKOT_STax { get; set; }
        public string RKOT_CVR { get; set; }
        public string RKOT_ISAddon { get; set; }
        public string RKOT_SubItem { get; set; }
        public string RKOT_Modifier { get; set; }
        public string GRP_SUB { get; set; }
        public string RKOT_WQTY { get; set; }
        public string RKOT_TYPE { get; set; }
        public string RKOT_COMBO { get; set; }
        public string COMBO_CODE { get; set; }
        public string COMBO_FLAG { get; set; }
        public string DISC_TYP { get; set; }
        public string DiscountPer2 { get; set; }
        public string Discount2 { get; set; }
        public string UmeshSign { get; set; }
        public string GRPsubGroupID { get; set; }
        public string OrderNo { get; set; }
        public string RMNU_DiscA { get; set; }
        public string SerialNoStartWith { get; set; }
        public string RSUM_GcdName { get; set; }
        public string RSUM_GCD { get; set; }
        public string TableInstruction { get; set; }


        //public List<RMS_SUB_ITEM_TRN> SUB_ITEM_TRN { get; set; }
        //public List<RMS_RKOT_MAN> RMS_RKOT_MAN { get; set; }


        // RMS_RMNU_MST

        public string GRP_SUBITEM { get; set; }
        public string RMNU_ADDON { get; set; }
        public string RMNU_MODF { get; set; }
        public string RMNU_MODIFIER { get; set; }
        public string RMNU_SUBU { get; set; }


        //   RMS_RMNU_ADDON
        public string RMNU_ADDON_COD { get; set; }
        public string RMNU_ADDON_STD { get; set; }
        public float RMNU_ADDON_RAT { get; set; }
        public float RMNU_ADDON_RATE { get; set; }

        //   RMS_RMNU_MODIFIER
        public string RMNU_M_COD { get; set; }
        public string RMNU_M_STD { get; set; }

        //   RMS_RKOT_MAN
        //public List<RMS_RKOT_MAN> RKOT_MAN { get; set; }
        public string GRPSubName { get; set; }
        public List<string> GRPSubNameList { get; set; } = new List<string>();
        public List<string> GRPsubGroupIDList { get; set; } = new List<string>();

    }
}
