using Engine.Models.BaseClasses;
using Engine.Models.Interfaces;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Engine.Models.Localization;

namespace Engine.Areas.AdminPanel.Pages
{
    public partial class MenuEdit
    {
        [Parameter]
        public int MenuId { get; set; }
        [Inject]
        private IMenu MyMenu { get; set; }
        [Inject]
        private NavigationManager Nav { get; set; }
        [Inject]
        private ISnackbar Snackbar { get; set; }
        private bool Busy;
        private Menu EditedItem = new Menu();
        private string[] _selectorValue = { "main", "top", "left", "right", "bottom", "footer" };
        protected override async Task OnInitializedAsync()
        {
            Busy = true;
            try
            {
                EditedItem = await MyMenu.GetMenu(MenuId);
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
            if ((EditedItem.Title != string.Empty || EditedItem.Title != "") && (EditedItem.Menutype != string.Empty || EditedItem.Menutype != ""))
            {
                await MyMenu.UpdateMenu(EditedItem);
                Snackbar.Add(MainDictionary.MessageCode["MENU_CHANGED"], Severity.Success);
                Cancel();
            }
            else if (EditedItem.Title != string.Empty || EditedItem.Title != "")
            {
                Snackbar.Add(MainDictionary.MessageCode["TITLE_EMPTY"], Severity.Error);
            }
            else
            {
                Snackbar.Add(MainDictionary.MessageCode["POSITION_EMPTY"], Severity.Error);
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
