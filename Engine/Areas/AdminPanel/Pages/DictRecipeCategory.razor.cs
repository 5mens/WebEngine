using Engine.Models.BaseClasses;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Engine.Areas.AdminPanel.Pages
{
    public partial class DictRecipeCategory
    {
        private string searchString = "";
        private HashSet<UserRecipeCategory> selectedItems = new HashSet<UserRecipeCategory>();
        private static IEnumerable<UserRecipeCategory> Recipes { get; set; }
        private string iconPicture { get; set; }
        private Color iconColor { get; set; }

        protected override void OnInitialized()
        {
            FillRecipes();
        }

        private bool FilterFunc(UserRecipeCategory element)
        {
            if (string.IsNullOrWhiteSpace(searchString))
                return true;
            if (element.Name.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                return true;
            if (element.Desc.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                return true;
            if ($"{element.Id} {element.Name}".Contains(searchString))
                return true;
            return false;
        }

        private void FillRecipes()
        {
            IList<UserRecipeCategory> recipes = new List<UserRecipeCategory>() {
            new UserRecipeCategory() { Id = 1, Name = "Основные блюда", Category = null, ShowDetails = true},
            new UserRecipeCategory() { Id = 2, Name = "Запеканка", ShowDetails = true },
            new UserRecipeCategory() { Id = 3, Name = "Пюре", ShowDetails = true},
            new UserRecipeCategory() { Id = 4, Name = "Супы", Category = null, ShowDetails = true},
            new UserRecipeCategory() { Id = 5, Name = "Суп-пюре", ShowDetails = true}
            };
            recipes[0].Category = new List<UserRecipeCategory>() { recipes[1], recipes[2] };
            recipes[3].Category = new List<UserRecipeCategory>() { recipes[4] };

            Recipes = recipes.Where(p => p.Category != null);
        }


        private void ShowBtnPress(int nr)
        {
            UserRecipeCategory tmpRecipe = Recipes.First(p => p.Id == nr);
            tmpRecipe.ShowDetails = !tmpRecipe.ShowDetails;
        }
    }
}
