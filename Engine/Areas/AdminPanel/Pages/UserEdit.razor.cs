using Engine.Models.BaseClasses;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Engine.Areas.AdminPanel.Pages
{
    public partial class UserEdit
    {
        [Parameter]
        public string UserId { get; set; }
        [Inject]
        private NavigationManager Nav { get; set; }
        [Inject]
        private UserManager<User> userManager { get; set; }
        [Inject]
        private RoleManager<UserGroup> roleManager { get; set; }
        [Inject]
        private ISnackbar Snackbar { get; set; }
        private bool Busy;
        private User EditedItem = new User();
        private IEnumerable<UserGroup> UserRoles = new List<UserGroup>();
        private List<EditedUserRoles> EditUserRoles = new List<EditedUserRoles>();
        IList<string> roles = new List<string>();

        private class EditedUserRoles : UserGroup { 
            public bool check { get; set; }
        }

        protected async override Task OnInitializedAsync()
        {
            Busy = true;
            try
            {
                EditedItem = await userManager.FindByIdAsync(UserId);
                roles = await userManager.GetRolesAsync(EditedItem);
                UserRoles = roleManager.Roles.ToList();
                CheckBox();
            }
            finally
            {
                Busy = false;
            }
            await base.OnInitializedAsync();
        }
        private void CheckBox() {
            bool checkBox = false;
            foreach (var item in UserRoles)
            {
                foreach (var userRole in roles)
                {
                    if (item.Name == userRole && checkBox == false) checkBox = true;
                }
                EditUserRoles.Add(new EditedUserRoles { Name = item.Name, check = checkBox });
                checkBox = false;
            }
        }
        private void CheckRole(string roleName) {
            foreach (var item in EditUserRoles)
            {
                if (item.Name == roleName)
                {
                    item.check = (item.check == true) ? false : true;
                }
            }
        }

        /// <summary>
        /// Сохранить
        /// </summary>
        private async Task UpdateUser()
        {
            await userManager.UpdateAsync(EditedItem);
            List<string> addRoles = new List<string>();
            foreach (var item in EditUserRoles)
            {
                if (item.check)
                {
                    addRoles.Add(item.Name);
                }
            }
            await userManager.RemoveFromRolesAsync(EditedItem, roles.ToArray());
            await userManager.AddToRolesAsync(EditedItem, addRoles.ToArray());
            Cancel();
        }
        /// <summary>
        /// Отмена
        /// </summary>
        private void Cancel()
        {
            Nav.NavigateTo($"/administrator/user/users");
        }

    }
}
