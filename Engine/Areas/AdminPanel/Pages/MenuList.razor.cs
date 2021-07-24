using Engine.Data;
using Engine.Models.BaseClasses;
using Engine.Models.Interfaces;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Engine.Areas.AdminPanel.Pages
{
    public partial class MenuList
    {
        [Inject]
        private NavigationManager Nav { get; set; }
        [Inject]
        private IMenu MyMenu { get; set; }
        [Inject]
        private ISnackbar Snackbar { get; set; }
        [Inject] 
        private IDialogService DialogService { get; set; }
        private string searchString = "";
        private Menu selectedItem = null;
        private bool disabled = false;
        private bool dense = false;
        private bool hover = true;
        private bool enabled = true;
        private IEnumerable<Menu> Elements = new List<Menu>();
        private bool Busy;
        private HashSet<Menu> selectedItems = new HashSet<Menu>();
        string state = string.Empty;
        protected override async Task OnInitializedAsync()
        {
            Busy = true;
            try
            {
                Elements = await MyMenu.GetMenus();
            }
            finally
            {
                Busy = false;
            }
            await base.OnInitializedAsync();
        }
        private bool FilterFunc(Menu element)
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
            Nav.NavigateTo($"/administrator/menu/add");
        }

        private void EditMenu()
        {
            if (selectedItems.Count == 1)
            {
                foreach (var item in selectedItems)
                {
                    Nav.NavigateTo($"/administrator/menu/{item.Id}/edit");
                }
            }
        }

        private async Task DeleteMenu()
        {
            if (selectedItems.Count > 0)
            {
                state = "Вы действительно хотите удалить меню";
                bool? result = await DialogService.ShowMessageBox(
                    "Внимание",
                    "Вы действительно хотите удалить меню!",
                    yesText: "Удалить!", cancelText: "Отмена");
                state = result == null ? "Cancelled" : "Deleted!";
                StateHasChanged();
                if (result == true)
                {
                    await MyMenu.DeleteMenu(selectedItems.ToList());
                    Elements = await MyMenu.GetMenus();
                    Snackbar.Add("Меню удалено", Severity.Error);
                }
            }
            else
            {
                Snackbar.Add("Необходимо выбрать объекты для удаления", Severity.Info);
            }
        }
        private async Task Publish(Menu menu)
        {
            if (!menu.IsMain)
            {
                menu.Published = (menu.Published) ? false : true;
                Busy = true;
                try
                {
                    await MyMenu.UpdateMenu(menu);
                }
                finally
                {
                    Busy = false;
                }

                if (menu.Published)
                {
                    Snackbar.Add("Меню опубликовано", Severity.Success);
                }
                else
                {
                    Snackbar.Add("Меню снято с публикации", Severity.Success);
                }
                Elements = await MyMenu.GetMenus();
            }            
        }

    }
}
