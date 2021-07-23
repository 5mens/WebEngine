using Engine.Data;
using Engine.Models.BaseClasses;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Engine.Areas.AdminPanel.Pages
{
    public partial class ArticleCategoryList
    {
        private string searchString = "";
        private Category selectedItem = null;
        private bool disabled = false;
        private bool dense = false;
        private bool hover = true;
        private bool enabled = true;
        private IEnumerable<Category> Elements = new List<Category>();
        private bool Busy;
        private AppDbContext Context { get; set; }
        private HashSet<Category> selectedItems = new HashSet<Category>();

        protected override async Task OnInitializedAsync()
        {
            Busy = true;

            try
            {
                Context = DbFactory.CreateDbContext();
                Elements = await Context.Category.ToListAsync();
            }
            finally
            {
                Busy = false;
            }

            await base.OnInitializedAsync();
        }
        private bool FilterFunc(Category element)
        {
            if (string.IsNullOrWhiteSpace(searchString))
                return true;
            if (element.Name.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                return true;
            if (element.Description.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                return true;
            return false;
        }

        private void AddCategory()
        {
            Nav.NavigateTo($"/administrator/article/category/add");
        }
    }
}
