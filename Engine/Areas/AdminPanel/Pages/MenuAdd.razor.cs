using Engine.Data;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Engine.Models.Interfaces;
using MudBlazor;
using Engine.Models.BaseClasses;

namespace Engine.Areas.AdminPanel.Pages
{
    public partial class MenuAdd
    {
        [Inject]
        private IMenu MyMenu { get; set; }
        [Inject]
        private NavigationManager Nav { get; set; }
        [Inject]
        private ISnackbar Snackbar { get; set; }
        private Menu NewMenu;

        private string[] _selectorValue = { "main", "top", "left", "right", "bottom", "footer" };
        protected override async Task OnInitializedAsync()
        {
            NewMenu = new();
            NewMenu.Title = string.Empty;
            NewMenu.Menutype = string.Empty;
            NewMenu.Published = false;
            await base.OnInitializedAsync();
        }
        /// <summary>
        /// Сохранить
        /// </summary>
        private async Task OnButtonClicked()
        {            
            if ((NewMenu.Title != string.Empty || NewMenu.Title != "") && (NewMenu.Menutype != string.Empty || NewMenu.Menutype != ""))
            {                
                await MyMenu.AddNewMenu(NewMenu);
                Snackbar.Add("Меню добавлено", Severity.Success);
                Cancel();
            }
            else if (NewMenu.Title != string.Empty || NewMenu.Title != "")
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
