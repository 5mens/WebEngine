using Engine.Models.BaseClasses;
using Engine.Models.Interfaces;
using Engine.Models.Localization;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Engine.Areas.PersonalAccount.Shared
{
    public partial class AddIngredient
    {
        [Parameter] public EventCallback<UserIngredient> OnButtonClick { get; set; }
        [Parameter] public UserIngredient EditedItem { get; set; } = null;
        private UserIngredient NewIngredient = new UserIngredient();
        [Inject] private IIngredient MyIngredient { get; set; }
        [Inject] private ISnackbar Snackbar { get; set; }
        void AddIngredientClick()
        {
            if (!string.IsNullOrEmpty(value.Name))
            {
                OnButtonClick.InvokeAsync(new UserIngredient()
                {   
                    Ingredient = value,
                    Count = NewIngredient.Count,
                    Price = NewIngredient.Price,
                    UserName = NewIngredient.UserName,
                    UserUnit = NewIngredient.UserUnit,
                    Weight = NewIngredient.Weight
                });
                Snackbar.Add(MainDictionary.MessageCode["SAVE_SUCCES"], Severity.Success);
            }
            else
            {
                Snackbar.Add(MainDictionary.MessageCode["INGREDIENT_CATEGORY_EMTY"], Severity.Error);
            }
        }
        void CancelClick() {
            OnButtonClick.InvokeAsync(null);
        }
        public CultureInfo _ru = CultureInfo.GetCultureInfo("ru-RU");
        private bool resetValueOnEmptyText;
        private bool coerceText;
        private bool coerceValue;
        private Ingredient value = new Ingredient();
        private List<Ingredient> states = new List<Ingredient>();
        private string[] _selectorValue = { "гр", "кг", "шт", "ед", "л" };
        protected override async Task OnInitializedAsync()
        {
            if (EditedItem != null)
            {
                NewIngredient = EditedItem;
                value = EditedItem.Ingredient;
            }
            List<Ingredient> ingredient = new();
            states = await MyIngredient.GetAllIngredientLazy();
            await base.OnInitializedAsync();
        }

        private async Task<IEnumerable<Ingredient>> Search(string value)
        {
            await Task.Delay(5);
            if (string.IsNullOrEmpty(value))
                return null;
            return states.Where(x => x.Name.Contains(value, StringComparison.InvariantCultureIgnoreCase)).OrderBy(x => x.Name);
        }
    }
}
