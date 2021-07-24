using Engine.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
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
        private IDbContextFactory<AppDbContext> DbFactory { get; set; }
        private AppDbContext Context { get; set; }
        private string searchString = "";
        private IdentityRole selectedItem = null;
        private bool disabled = false;
        private bool dense = false;
        private bool hover = true;
        private bool enabled = true;
        private IEnumerable<IdentityRole> Elements = new List<IdentityRole>();
        private bool Busy;
        private HashSet<IdentityRole> selectedItems = new HashSet<IdentityRole>();
        protected override async Task OnInitializedAsync()
        {            
            Busy = true;
            try
            {
                Context = DbFactory.CreateDbContext();
                Elements = await Context.AspNetRoles.ToListAsync();
            }
            finally
            {
                Busy = false;
            }
            await base.OnInitializedAsync();
        }
        private bool FilterFunc(IdentityRole element)
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

        private void GroupDelete()
        {

        }

    }
}
