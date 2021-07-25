using Engine.Models.BaseClasses;
using Engine.Models.Interfaces;
using Engine.Models.Localization;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Engine.Areas.AdminPanel.Pages
{
    public partial class MenuItems
    {
        #region Parameters
        [Parameter]
        public int MenuId { get; set; } = 0;
        #endregion
        #region Injects
        [Inject]
        private NavigationManager Nav { get; set; }
        [Inject]
        private IMenuItem MyMenuItem { get; set; }
        [Inject]
        private IMenu MyMenu { get; set; }
        [Inject]
        private ISnackbar Snackbar { get; set; }
        [Inject]
        #endregion
        #region Variables
        private IDialogService DialogService { get; set; }
        private string searchString = "";
        private string myMenuName = "";
        private MenuItem selectedItem = null;
        private bool disabled = false;
        private bool dense = false;
        private bool hover = true;
        private bool enabled = true;
        private IEnumerable<MenuItem> Elements = new List<MenuItem>();
        private Menu menu = new Menu();
        private bool Busy;
        private HashSet<MenuItem> selectedItems = new HashSet<MenuItem>();
        private string state = string.Empty;
        #endregion
        #region Methods
        protected override async Task OnInitializedAsync()
        {
            Busy = true;

            try
            {
                Elements = await MyMenuItem.GetMenuItemsById(MenuId);
                menu = await MyMenu.GetMenu(MenuId);
                myMenuName = menu.Title;
            }
            finally
            {
                Busy = false;
            }
            await base.OnInitializedAsync();
        }
        private bool FilterFunc(MenuItem element)
        {
            if (string.IsNullOrWhiteSpace(searchString))
                return true;
            if (element.Title.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                return true;
            if (element.Desc.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                return true;
            if ($"{element.Id} {element.Menutype}".Contains(searchString))
                return true;
            return false;
        }

        private void AddNewMenu()
        {
            Nav.NavigateTo($"/administrator/menu/{MenuId}/item/add");
        }

        private void EditMenu()
        {
            if (selectedItems.Count == 1)
            {
                foreach (var item in selectedItems)
                {
                    Nav.NavigateTo($"/administrator/menu/{MenuId}/item/{item.Id}/edit");
                }
            }
        }        
        private async Task DeleteMenuItem()
        {            
            if (selectedItems.Count > 0)
            {
                bool? result = await DialogService.ShowMessageBox(
                    MainDictionary.MessageCode["DELETE_ATTENTION"],
                    MainDictionary.MessageCode["DELETE_MESSAGE"],
                    yesText: MainDictionary.MessageCode["DELETE_YES"], cancelText: MainDictionary.MessageCode["DELETE_CANCEL"]);
                state = result == null ? "Cancelled" : "Deleted!";
                StateHasChanged();
                if (result == true)
                {
                    await MyMenuItem.DeleteMenuItem(selectedItems.ToList());
                    Elements = await MyMenuItem.GetMenuItemsById(MenuId);
                    Snackbar.Add(MainDictionary.MessageCode["MENU_DELETE"], Severity.Error);
                }
            }
            else
            {
                Snackbar.Add(MainDictionary.MessageCode["SELECT_OBJ_TO_DELETE"], Severity.Info);
            }
        }

        private async Task Publish(MenuItem menuItem)
        {
            menuItem.Published = (menuItem.Published) ? false : true;
            Busy = true;
            try
            {
                await MyMenuItem.UpdateMenuItem(menuItem);
            }
            finally
            {
                Busy = false;
            }
            if (menuItem.Published)
            {
                Snackbar.Add(MainDictionary.MessageCode["PUBLISH"], Severity.Success);
            }
            else
            {
                Snackbar.Add(MainDictionary.MessageCode["UNPUBLISH"], Severity.Success);
            }
            Elements = await MyMenuItem.GetMenuItemsById(MenuId);
        }
        #endregion
    }
}
