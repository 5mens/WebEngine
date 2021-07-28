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
    public partial class MenuItemAdd
    {
        #region Parameters
        [Parameter]
        public int MenuId { get; set; }
        #endregion
        #region Injects
        [Inject]
        private IMenuItem MyMenuItem { get; set; }
        [Inject]
        private NavigationManager Nav { get; set; }
        [Inject]
        private ISnackbar Snackbar { get; set; }
        #endregion
        #region Variables
        private MenuItem NewMenuItem;
        #endregion
        protected override async Task OnInitializedAsync()
        {
            NewMenuItem = new();
            NewMenuItem.Title = string.Empty;
            NewMenuItem.Menutype = string.Empty;
            NewMenuItem.Published = false;
            NewMenuItem.Link = "#";
            NewMenuItem.MenuId = MenuId;
            await base.OnInitializedAsync();
        }
        /// <summary>
        /// Сохранить
        /// </summary>
        private async Task OnButtonClicked()
        {
            if ((NewMenuItem.Title != string.Empty || NewMenuItem.Title != "") && (NewMenuItem.Link != string.Empty || NewMenuItem.Link != ""))
            {
                await MyMenuItem.AddNewMenuItem(NewMenuItem);
                Snackbar.Add(MainDictionary.MessageCode["MENU_ADD"], Severity.Success);
                Cancel();
            }
            else if (NewMenuItem.Title == string.Empty || NewMenuItem.Title == "")
            {
                Snackbar.Add(MainDictionary.MessageCode["TITLE_EMPTY"], Severity.Error);
            }
            else
            {
                Snackbar.Add(MainDictionary.MessageCode["LINK_EMPTY"], Severity.Error);
            }
        }
        /// <summary>
        /// Отмена
        /// </summary>
        private void Cancel()
        {
            Nav.NavigateTo($"/administrator/menu/{MenuId}/items/");
        }
    }
}
