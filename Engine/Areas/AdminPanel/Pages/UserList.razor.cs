using Engine.Data;
using Engine.Models.BaseClasses;
using Engine.Models.Localization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Engine.Areas.AdminPanel.Pages
{
    public partial class UserList
    {
        [Inject]
        private NavigationManager Nav { get; set; }
        [Inject]
        private UserManager<User> userManager { get; set; }
        [Inject]
        private IDialogService DialogService { get; set; }
        [Inject]
        private ISnackbar Snackbar { get; set; }
        private IEnumerable<User> Elements = new List<User>();
        private HashSet<User> selectedItems = new HashSet<User>();
        private bool Busy;
        private string searchString = "";
        private IdentityUser selectedItem = null;
        private bool disabled = false;
        private bool dense = false;
        private bool hover = true;
        private bool enabled = true;

        protected async override Task OnInitializedAsync()
        {
            Busy = true;
            try
            {
                Elements = await userManager.Users.ToListAsync();
            }
            finally
            {
                Busy = false;
            }
            await base.OnInitializedAsync();
        }

        private void UserEdit()
        {
            if (selectedItems.Count == 1)
            {
                foreach (var item in selectedItems)
                {
                    Nav.NavigateTo($"/administrator/user/{item.Id}/edit");
                }
            }
        }

        private async Task UserBan(User context)
        {            
            context.LockoutEnabled = context.LockoutEnabled ? true : false;
            context.LockoutEnd = !context.LockoutEnabled ? new DateTime(2500, 01, 01) : null ;
            await userManager.UpdateAsync(context);
            Elements = await userManager.Users.ToListAsync();
        }

        private async Task UserDelete()
        {
            
            if (selectedItems.Count > 0)
            {
                bool? result = await DialogService.ShowMessageBox(
                    MainDictionary.MessageCode["DELETE_ATTENTION"],
                    MainDictionary.MessageCode["DELETE_MESSAGE"],
                    yesText: MainDictionary.MessageCode["DELETE_YES"], cancelText: MainDictionary.MessageCode["DELETE_CANCEL"]);
                StateHasChanged();
                if (result == true)
                {
                    foreach (var item in selectedItems)
                    {
                        await userManager.DeleteAsync(item);
                    }
                    Elements = Elements = await userManager.Users.ToListAsync();
                    Snackbar.Add(MainDictionary.MessageCode["USER_DELETE"], Severity.Error);
                }
            }                        
        }

        private bool FilterFunc(IdentityUser element)
        {
            if (string.IsNullOrWhiteSpace(searchString))
                return true;
            if (element.UserName.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                return true;
            if (element.Email.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                return true;
            if ($"{element.UserName} {element.Email}".Contains(searchString))
                return true;
            return false;
        }

        private Color CheckBoxColor(bool context)
        {
            if (context)
            {
                return Color.Tertiary;
            }
            else
            {
                return Color.Secondary;
            }
        }
    }
}
