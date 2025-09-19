using HandHelUi.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace HandHeldUi.Shared.Services
{
    public class CartState
    {
        [Parameter] public float CurrentGroupIndex { get; set;}
        public List<CartItem> CartItems { get; private set; } = new List<CartItem>();
        public bool IsCartOpen { get; set; } = false;
        public event Action? OnCartChanged;
        public event Action? RequestToggleCart;
        public event Action? OnMaxSubItemsReached; 
        public event Action? MaxSubItemsReached; 
        List<float> groupMinQtyList = new();
        List<float> groupMaxQtyList = new();

        public void PrepareGroupLimits(MenuItem parentItem)
        {
            groupMinQtyList.Clear();
            groupMaxQtyList.Clear();

            if (parentItem.CommonAddons?.Count > 0)
            {
                foreach (var group in parentItem.CommonAddons)
                {
                    groupMinQtyList.Add(group.Min(item => item.SubMinQty ?? 0));
                    groupMaxQtyList.Add(group.Max(item => item.SubMaxQty ?? 0));
                }
            }
            else if (parentItem.SubItems?.Count > 0)
            {
                foreach (var group in parentItem.SubItems)
                {
                    groupMinQtyList.Add(group.Min(item => item.SubMinQty ?? 0));
                    groupMaxQtyList.Add(group.Max(item => item.SubMaxQty ?? 0));
                }
            }
        }

        public void AddToCart(MenuItem menuItem)
        {
            
            var existingItem = CartItems.FirstOrDefault(ci => ci.Name == menuItem.ItemName && ci.ItemCode == menuItem.ItemCode);
            if (existingItem != null)
            {
                existingItem.Qty++;
            }

            //else if (menuItem.SubItems?.Count < 1 || menuItem.SubItems.Any(sub=> sub.MinQty < 1))
            else if (menuItem.CommonAddons == null && menuItem.SubItems.Count < 1 || menuItem.SubItems.Any(subList => subList.Any(sub => (sub.SubMinQty ?? 0) < 1)))
            {
                CartItems.Add(new CartItem
                {
                    Name = menuItem.ItemName,
                    Qty = 1,
                    Price = menuItem.Rates ?? 0,
                    ItemCode = menuItem.ItemCode,
                    TaxType = menuItem.TaxType,
                    TaxStruCode = menuItem.TaxStruCode,
                    CartSubItem = new List<CartSubItem>()
                });
            }
            else if (menuItem.SubItems == null && menuItem.CommonAddons.Count < 1 || menuItem.CommonAddons.Any(subList => subList.Any(sub => (sub.SubMinQty ?? 0) < 1)))
            {
                CartItems.Add(new CartItem
                {
                    Name = menuItem.ItemName,
                    Qty = 1,
                    Price = menuItem.Rates ?? 0,
                    ItemCode = menuItem.ItemCode,
                    TaxType = menuItem.TaxType,
                    TaxStruCode = menuItem.TaxStruCode,
                    CartSubItem = new List<CartSubItem>()
                });
            }
            else if (menuItem.CommonAddons?.Count < 1 && menuItem.SubItems?.Count < 1)
            {
                CartItems.Add(new CartItem
                {
                    Name = menuItem.ItemName,
                    Qty = 1,
                    Price = menuItem.Rates ?? 0,
                    ItemCode = menuItem.ItemCode,
                    TaxType = menuItem.TaxType,
                    TaxStruCode = menuItem.TaxStruCode,
                    CartSubItem = new List<CartSubItem>()
                });
            }
            NotifyChange();
        }
        public void AddSubItemToCart(MenuItem parentItem, SubItem subItem, int groupIndex)
        {
            if (subItem == null || string.IsNullOrEmpty(subItem.SubItemName)) return;

            
            float groupMin = groupIndex < groupMinQtyList.Count ? groupMinQtyList[groupIndex] : (subItem.SubMinQty ?? 0);
            float groupMax = groupIndex < groupMaxQtyList.Count ? groupMaxQtyList[groupIndex] : (subItem.SubMaxQty ?? 0);

         
            var parentCartItem = CartItems.FirstOrDefault(ci => ci.Name == parentItem.ItemName && ci.ItemCode == parentItem.ItemCode);
            if (parentCartItem == null)
            {
                parentCartItem = new CartItem
                {
                    Name = parentItem.ItemName,
                    Qty = 1,
                    Price = parentItem.Rates ?? 0,
                    ItemCode = parentItem.ItemCode,
                    TaxType = parentItem.TaxType,
                    IsAddon = subItem.IsAddon == "A" ? "Y": null,
                    IsSubitem = subItem.IsSubitem == "S" ? "Y": null,
                    TaxStruCode = parentItem.TaxStruCode,
                    CartSubItem = new List<CartSubItem>()
                };
                CartItems.Add(parentCartItem);
            }

            var existingSubItem = parentCartItem.CartSubItem.FirstOrDefault(csi => csi.SubItemName == subItem.SubItemName);
            if (existingSubItem != null)
            {
                //OnMaxSubItemsReached?.Invoke();
                return;
            }

            int groupCount = parentCartItem.CartSubItem.Count(csi => csi.SubGrpName == subItem.SubGrpName);

            if (groupCount >= groupMax)
            {
                MaxSubItemsReached?.Invoke();
                return;
            }

            // Add subitem
            parentCartItem.CartSubItem.Add(new CartSubItem
            {
                SubMinQty = subItem.SubMinQty,
                SubGrpName = subItem.SubGrpName,
                SubItemName = subItem.SubItemName,
                SubItemRates = subItem.SubItemRates
            });

            groupCount++;

            if (groupCount >= groupMax)
            {
                //if(parentItem.CommonAddons.Count - 1 == CurrentGroupIndex)
                //OnMaxSubItemsReached?.Invoke();
                return;
            }

            else if (groupCount >= groupMin)
            {
                
            }

            NotifyChange();
        }

        public void DecreaseItemQty(string itemName, string? subItemName = null)
            {
            if (string.IsNullOrEmpty(subItemName))
            {
                // Handle main item quantity decrease
                var existingItem = CartItems.FirstOrDefault(ci => ci.Name == itemName);
                if (existingItem != null)
                {
                    if (existingItem.Qty > 1)
                    {
                        existingItem.Qty--;
                    }
                    else
                    {
                        CartItems.Remove(existingItem);
                    }
                    NotifyChange();
                }
            }
            else
            {
                // Handle sub-item removal
                var parentItem = CartItems.FirstOrDefault(ci => ci.Name == itemName);
                if (parentItem != null)
                {
                    var subItem = parentItem.CartSubItem.FirstOrDefault(csi => csi.SubItemName == subItemName);
                    if (subItem != null)
                    {
                        parentItem.CartSubItem.Remove(subItem);
                        if(parentItem.CartSubItem.Count < 1)
                        {
                            OnMaxSubItemsReached?.Invoke();
                        }
                        // Remove parent item if it has no sub-items and Qty is 0
                        if (!parentItem.CartSubItem.Any() && parentItem.Qty == 0)
                        {
                            CartItems.Remove(parentItem);
                        }
                        NotifyChange();
                    }
                }
            }
        }

        public void IncreaseQty(CartItem item)
        {
            item.Qty++;
            NotifyChange();
        }

        public void DecreaseQty(CartItem item)
        {
            if (item.Qty > 1)
            {
                item.Qty--;
            }
            else
            {
                CartItems.Remove(item);
            }
            if (!CartItems.Any())
            {
                IsCartOpen = false;
            }
            NotifyChange();
        }

        public void ClearCart()
        {
            CartItems.Clear();
            IsCartOpen = false;
            NotifyChange();
        }

        public void TriggerToggleCart()
        {
            RequestToggleCart?.Invoke();
        }

        private void NotifyChange()
        {
            OnCartChanged?.Invoke();
        }

        public bool IsSubItemInCart(string itemName, string subItemName)
        {
            return CartItems.Any(ci => ci.Name == itemName && 
                                       ci.CartSubItem.Any(csi => csi.SubItemName == subItemName));
        }
    }
}