using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandHelUi.Shared.Models
{
    public class PfbRkotSumDto
    {
        public string RsumKot { get; set; } = null!;
        public string? OutletId { get; set; }
        public string? RsumPop { get; set; }
        public string? RsumSubtbl { get; set; }
        public DateTime? RsumDat { get; set; }
        public string? RsumTbl { get; set; }
        public string? RsumStw { get; set; }
        public short? RsumCvr { get; set; }
        public string? RsumNar { get; set; }
        public string? RsumGcd { get; set; }
        public string? RsumTim { get; set; }
        public string? RsumSts { get; set; }
        public string? RsumBil { get; set; }
        public string? RsumPrn { get; set; }
        public string? RsumTyp { get; set; }
        public string? RsumCng { get; set; }
        public string? RsumCsh { get; set; }
        public string? RsumEdt { get; set; }
        public decimal? RsumAmt { get; set; }
        public string? RsumId { get; set; }
        public short? RsumNo { get; set; }
        public string? RsumRemtyp { get; set; }
        public string? RsumRem { get; set; }
        public string? RsumCshC { get; set; }
        public string? RsumGcdName { get; set; }
        public string? RsumKds { get; set; }
        public string? RsumDiscTyp { get; set; }

        //public List<RMS_RKOT_TRN> itemdata { get; set; }
        //public List<RMS_RBILL_SUM1> BillData { get; set; }
        //public List<TaxStructure> TaxStructure { get; set; }
        //public List<TaxStructure2> TaxStructure2 { get; set; }
        //public List<RKOT_TRN_DATA> RKOT_TRN_DATA { get; set; }
        public string? RBIL_TAXFREE { get; set; }
    }
    public class importaintTableDetail
    {
        public string? RSUM_KOT { get; set; }
        public DateTime? RSUM_DAT { get; set; }
        public string? RSUM_TBL { get; set; }
        public string? RSUM_STW { get; set; }
        public Int16? RSUM_CVR { get; set; }
        public string? RSUM_TIM { get; set; }
        public string? RSUM_CSH { get; set; }
        public string? RSUM_TYP { get; set; }
        public Int16? RSUM_NO { get; set; }
        public string? NextBill { get; set; }
    }
}
