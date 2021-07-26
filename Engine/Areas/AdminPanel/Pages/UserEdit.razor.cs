﻿using Microsoft.AspNetCore.Components;
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
        private UserManager<IdentityUser> userManager { get; set; }
        [Inject]
        private RoleManager<IdentityRole> roleManager { get; set; }
        [Inject]
        private ISnackbar Snackbar { get; set; }
        private bool Busy;
        private IdentityUser EditedItem;
        private IEnumerable<IdentityRole> UserRoles = new List<IdentityRole>();
        protected async override Task OnInitializedAsync()
        {
            Busy = true;
            try
            {
                EditedItem = await userManager.FindByIdAsync(UserId);
                UserRoles = roleManager.Roles.ToList();
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
        private async Task UpdateUser()
        {
            await userManager.UpdateAsync(EditedItem);
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