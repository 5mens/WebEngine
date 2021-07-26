using Engine.Models.BaseClasses;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Engine.Areas.AdminPanel.Pages
{
    public partial class UserGroups
    {
        [Inject]
        private NavigationManager Nav { get; set; }
        [Inject]
        private RoleManager<UserGroup> roleManager { get; set; }
        private string searchString = "";
        private UserGroup selectedItem = null;
        private bool disabled = false;
        private bool dense = false;
        private bool hover = true;
        private bool enabled = true;
        private IEnumerable<UserGroup> Elements = new List<UserGroup>();
        private bool Busy;
        private HashSet<UserGroup> selectedItems = new HashSet<UserGroup>();
        
        protected override async Task OnInitializedAsync()
        {            
            Busy = true;
            try
            {
                Elements = roleManager.Roles.ToList();
            }
            finally
            {
                Busy = false;
            }
            await base.OnInitializedAsync();
        }
        private bool FilterFunc(UserGroup element)
        {
            if (string.IsNullOrWhiteSpace(searchString))
                return true;
            if (element.Name.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                return true;
            if (element.NormalizedName.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                return true;
            if ($"{element.NormalizedName} {element.Name}".Contains(searchString))
                return true;
            return false;
        }
        private void GroupEdit()
        {
            if (selectedItems.Count == 1)
            {
                foreach (var item in selectedItems)
                {
                    Nav.NavigateTo($"/administrator/user/groups/{item.Id}/edit");
                }
            }
        }

        private async Task GroupDelete()
        {
            foreach (var item in selectedItems)
            {
                await roleManager.DeleteAsync(item);
            }
            Elements = roleManager.Roles.ToList();
        }

    }
}
