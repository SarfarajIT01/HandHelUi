using HandHelUi.Shared.Models;
using Microsoft.AspNetCore.Components;


namespace HandHelUi.Shared.Services
{
    public class TableSelectionService
    {
        //public float CurrentGroupIndex { get; set; }
        public PfbRmscMst? SelectedTable { get; set; }
        public event Action? RequestTableSelected;
        public void TriggerTableSelected()
        {
            RequestTableSelected?.Invoke();
        }

        //public void GetTabDetails()
        //{

        //}
    }
}
