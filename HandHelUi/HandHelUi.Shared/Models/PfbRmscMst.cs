using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandHelUi.Shared.Models
{
    public partial class PfbRmscMst
    {
        public string RmscCod { get; set; } = null!;

        public string? OutletId { get; set; }

        public string? RmscTyp { get; set; }

        public string? RmscPop { get; set; }

        public string? RmscSht { get; set; }

        public string? RmscStd { get; set; }

        public string? RmscRem { get; set; }

        public string? RmscSft { get; set; }

        public string? RmscGcd { get; set; }

        public string? RmscSmode { get; set; }

        public decimal? RmscCommi { get; set; }

        public string? RmscPic { get; set; }

        public double? RmscBcolor { get; set; }

        public string? RmscGlcode { get; set; }

        public short? RmscRow { get; set; }

        public short? RmscColumn { get; set; }

        public short? RmscCover { get; set; }

        public string? RmscFloor { get; set; }

        public int? RmscPicLeft { get; set; }

        public int? RmscPicTop { get; set; }

        public int? RmscPicWidth { get; set; }

        public int? RmscPicHeight { get; set; }

        public string? RmscPic1 { get; set; }

        public string? RmscPic2 { get; set; }

        public string? RmscFname { get; set; }

        public short? RmscFsize { get; set; }

        public string? RmscStatus { get; set; }

        public string? RmscTblsts { get; set; }

        public string? RmscShape { get; set; }

        public string? TblFlag { get; set; }

        public string? LinkId { get; set; }

        // Add the missing property
        [NotMapped]
        public float TableAmt { get; set; }
        [NotMapped]
        public string? RunCvr { get; set; }
        [NotMapped]
        public string? RunSTW { get; set; }
        [NotMapped]
        public string? RunGuestCode { get; set; }
        [NotMapped]
        public string? RunGuestName { get; set; }
        [NotMapped]
        public string? FloorDesc { get; set; } // Add this property
    }
}
