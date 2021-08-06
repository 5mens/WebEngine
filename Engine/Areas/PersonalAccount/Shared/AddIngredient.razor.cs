using Engine.Models.BaseClasses;
using Engine.Models.Interfaces;
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
        [Inject] private IIngredient MyIngredient { get; set; }
        [Inject] private ISnackbar Snackbar { get; set; }
        private UserIngredient NewIngredient = new UserIngredient();
        void AddIngredientClick()
        {
            OnButtonClick.InvokeAsync(new UserIngredient() { 
                Category = value.Category,
                Count = NewIngredient.Count,
                Desc = value.Desc,
                Image = value.Image,
                Name = value.Name,
                Price = NewIngredient.Price,
                UserName = NewIngredient.UserName,
                UserUnit = NewIngredient.UserUnit,
                Weight = NewIngredient.Weight
            });
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
            List<Ingredient> ingredient = new();
            states = await MyIngredient.GetAllIngredientLazy();
            await base.OnInitializedAsync();
        }

        private async Task<IEnumerable<Ingredient>> Search(string value)
        {
            await Task.Delay(5);
            if (string.IsNullOrEmpty(value))
                return null;
            return states.Where(x => x.Name.Contains(value, StringComparison.InvariantCultureIgnoreCase)).OrderBy(x =>x.Name);
        }
    }
}
