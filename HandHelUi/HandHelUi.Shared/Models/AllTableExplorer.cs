using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandHelUi.Shared.Models
{
  
    public class AllTableExplorer
    {
        public List<VacantTableExplorer>? Vacant { get; set; }
        public List<OccupiedTableExplorer>? Occupied { get; set; }
    }

    public class VacantTableExplorer
    {
        public string? TableNo { get; set; }
        public string? Status { get; set; }
        public string? RMSC_STD { get; set; }
        public string? RMSC_COD { get; set; }
        public string? RMSC_TBLSTS { get; set; }
    }

    public class OccupiedTableExplorer
    {
        public string? RkotPop { get; set; }
        public string? OutletId { get; set; }
        public string? RsumTim { get; set; }
        public string? RkotNo { get; set; }
        public string? RsumTbl { get; set; }
        public string? RsumStw { get; set; }
        public string? RsumCvr { get; set; }
        public string? RsumAmt { get; set; }
        public string? RkotQty { get; set; }
        public string? RkotRat { get; set; }
        public string? ItemName { get; set; }
        public string? RkotRem { get; set; }
        public string? Amount { get; set; }
    }

    public class TableInfo
    {
        public string TableNo { get; set; } = "";
        public string? OrderNo { get; set; }
        public string? PosNo { get; set; }
        public string? Outlet { get; set; }
        public string? Status { get; set; }
        public string? Steward { get; set; }
        public string? Time { get; set; }
        public string? Cover { get; set; }
        public string? Quantity { get; set; }
        public string? Rate { get; set; }
        public string? ItemName { get; set; }
        public string? Amount { get; set; }
    }
}
