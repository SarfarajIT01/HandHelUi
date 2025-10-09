using HandHelUi.Shared.Models;
using Microsoft.AspNetCore.Components;


namespace HandHelUi.Shared.Services
{
    public class TableSelectionService
    {
        public PfbRmscMst? SelectedTable { get; set; }
        public event Action? RequestTableSelected;
        public event Action? OnTableSelected;
        public void TriggerTableSelected()
        {
            RequestTableSelected?.Invoke();
        }
        public void SelectTable(PfbRmscMst table)
        {
            SelectedTable = table;
            OnTableSelected?.Invoke();
        }
    }
}
