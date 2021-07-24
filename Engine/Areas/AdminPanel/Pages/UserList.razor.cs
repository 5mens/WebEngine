﻿using Engine.Data;
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
        private IDbContextFactory<AppDbContext> DbFactory { get; set; }        
        private AppDbContext Context { get; set; }
        private IEnumerable<IdentityUser> Elements = new List<IdentityUser>();
        private HashSet<IdentityUser> selectedItems = new HashSet<IdentityUser>();
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
                Context = DbFactory.CreateDbContext();
                Elements = await Context.AspNetUsers.ToListAsync();
            }
            finally
            {
                Busy = false;
            }
            await base.OnInitializedAsync();
        }

        private void UserEdit() {
            if (selectedItems.Count == 1)
            {
                foreach (var item in selectedItems)
                {
                    Nav.NavigateTo($"/administrator/user/{item.Id}/edit");
                }
            }
        }

        private void UserBan(bool context) { 
        
        }

        private void UserDelete() { 
        
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

        private Color CheckBoxColor(bool context) {
            if (!context)
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
