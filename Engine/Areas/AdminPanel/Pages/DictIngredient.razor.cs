using Engine.Models.BaseClasses;
using Engine.Models.Interfaces;
using Engine.Models.Localization;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Engine.Areas.AdminPanel.Pages
{
    public partial class DictIngredient
    {
        [Inject] private ISnackbar Snackbar { get; set; }

        [Inject] private IDialogService DialogService { get; set; }

        [Inject] private IIngredientCategory IngredientCategory { get; set; }

        [Inject] private IIngredient Ingredient { get; set; }

        private static List<CategoryWrapper> WrappedCategories { get; set; }
//      private static IEnumerable<Ingredient> Ingredients { get; set; }

        private HashSet<Ingredient> selectedItems = new();
        
        private string searchString = "";

        protected override async Task OnInitializedAsync()
        {
            var categories = await IngredientCategory.GetAll();
            WrappedCategories = categories.ConvertAll(c => new CategoryWrapper(c));
        }

        private bool FilterFunc(Ingredient element)
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

        private async Task ShowBtnPress(CategoryWrapper wrapper)
        {
            if (wrapper.IsFolded)
            {
                if (wrapper.Category.Ingredients == null)
                    wrapper.Category.Ingredients = await Ingredient.GetByCategory(wrapper.Category);
                wrapper.IsFolded = false;
            }
            else wrapper.IsFolded = true;
        }

        private async Task DeleteIngredients()
        {
            if (selectedItems.Count > 0)
            {
                bool? result = await DialogService.ShowMessageBox(
                    MainDictionary.MessageCode["DELETE_ATTENTION"],
                    MainDictionary.MessageCode["DELETE_MESSAGE"],
                    yesText: MainDictionary.MessageCode["DELETE_YES"],
                    cancelText: MainDictionary.MessageCode["DELETE_CANCEL"]
                );

                if (result == true)
                {
                    Ingredient.DeleteIngredients(selectedItems.ToList()); // c await возникают ошибки удаления
                    WrappedCategories
                        .FindAll(w => w.Category.Ingredients != null)
                        .ForEach(w => w.Category.Ingredients.RemoveAll(i => selectedItems.Contains(i)));
                    Snackbar.Add(MainDictionary.MessageCode["INGREDIENT_DELETE"], Severity.Error);
                }
            }
            else Snackbar.Add(MainDictionary.MessageCode["SELECT_OBJ_TO_DELETE"], Severity.Info);
        }

        private class CategoryWrapper
        {
            public IngredientCategory Category { get; private set; }

            public bool IsFolded { get; set; }

            public CategoryWrapper(IngredientCategory ingredientCategory)
            {
                Category = ingredientCategory;
                IsFolded = true;
            }
        }
    }
}
