using Engine.Models.BaseClasses;
using Engine.Models.Interfaces;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Engine.Areas.PersonalAccount.Pages
{
    public partial class Warehouse
    {
        [Inject] private IMyWarehouse MyWarehouseInj { get; set; }
        [Inject] private ISnackbar Snackbar { get; set; }
        [Inject] AuthenticationStateProvider GetAuthenticationStateAsync { get; set; }
        [Inject] private UserManager<User> userManager { get; set; }

        private MyWarehouse Whouse = new MyWarehouse();
        private User _user = new User();

        private bool addIngredient = false;
        private void AddIngredientClick() {
            addIngredient = true;
        }

        private void GetIngredient(UserIngredient ingredient) {
            if (Whouse.Ingredients == null)
            {
                Whouse.Ingredients = new List<UserIngredient>();
            }
            Whouse.Ingredients.Add(ingredient);
            MyWarehouseInj.UpdateUserWarehouse(Whouse);
            addIngredient = false;
        }

        protected override async Task OnInitializedAsync()
        {
            var authstate = await GetAuthenticationStateAsync.GetAuthenticationStateAsync();
            var user = authstate.User.Identity.Name;
            _user = await userManager.FindByNameAsync(user);
            Whouse = await MyWarehouseInj.GetUserWarehouse(_user);
            await base.OnInitializedAsync();
        }
    }
}
