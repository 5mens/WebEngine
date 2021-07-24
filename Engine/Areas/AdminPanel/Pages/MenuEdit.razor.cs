using Engine.Models.BaseClasses;
using Engine.Models.Interfaces;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        private Menu EditedItem;
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
                Snackbar.Add("Меню изменено", Severity.Success);
                Cancel();
            }
            else if (EditedItem.Title != string.Empty || EditedItem.Title != "")
            {
                Snackbar.Add("Необходимо заполнить наименование меню", Severity.Error);
            }
            else
            {
                Snackbar.Add("Выберите положение меню", Severity.Error);
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
