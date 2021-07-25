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
    public partial class MenuItemEdit
    {
        [Parameter]
        public int MenuId { get; set; }
        [Parameter]
        public string MenuItemId { get; set; }
        [Inject]
        private IMenuItem MyMenuItem { get; set; }
        [Inject]
        private NavigationManager Nav { get; set; }
        [Inject]
        private ISnackbar Snackbar { get; set; }
        private bool Busy;
        private MenuItem EditedItem;
        protected override async Task OnInitializedAsync()
        {
            Busy = true;
            try
            {
                int x = 0;
                Int32.TryParse(MenuItemId, out x);
                EditedItem = await MyMenuItem.GetMenuItem(x);
            }
            finally
            {
                Busy = false;
            }
            await base.OnInitializedAsync();
        }
        /// <summary>
        /// Сохранить
        /// </summary>
        private async Task UpdateMenu()
        {
            if ((EditedItem.Title != string.Empty || EditedItem.Title != "") && (EditedItem.Link != string.Empty || EditedItem.Link != ""))
            {
                await MyMenuItem.UpdateMenuItem(EditedItem);
                Snackbar.Add(MainDictionary.MessageCode["MENU_CHANGED"], Severity.Success);
                Cancel();
            }
            else if (EditedItem.Title == string.Empty || EditedItem.Title == "")
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
            Nav.NavigateTo($"/administrator/menu/list");
        }

    }
}
