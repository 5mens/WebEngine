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
        private IList<UserIngredient> userIngredients = new List<UserIngredient>();
        private User _user = new User();
        private IList<UserIngredient> selectedIngredients = new List<UserIngredient>();
        private HashSet<UserIngredient> selectedItems = new HashSet<UserIngredient>();
        private string searchString = "";
        private UserIngredient selectedItem = null;

        protected override async Task OnInitializedAsync()
        {
            Whouse = await GetUserWhAsync();
            if (Whouse == null)
            {
                MyWarehouse warehouse = new MyWarehouse();
                MyWarehouseInj.CreateUserWarehouse(warehouse);
                warehouse.User = _user;
                await MyWarehouseInj.UpdateUserWarehouse(warehouse);
            }
            else
            {
                userIngredients = await MyWarehouseInj.GetUserIngredients(Whouse);
                foreach (var item in userIngredients)
                {
                    item.Ingredient = new Ingredient();
                    item.Ingredient = MyWarehouseInj.GetIngredient(item.Id);
                }
            }
            await base.OnInitializedAsync();
        }

        private bool FilterFunc(UserIngredient element)
        {
            if (string.IsNullOrWhiteSpace(searchString))
                return true;            
            if (element.UserName.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                return true;
            if ($"{element.UserName}".Contains(searchString))
                return true;
            return false;
        }
        /// <summary>
        /// 0 - режим таблицы; 1 - добавление; 2 - редактирование
        /// </summary>
        private byte addIngredient = 0;
        private void AddIngredientClick() {
            addIngredient = 1;
        }

        private void EditIngredientClick()
        {
            addIngredient = 2;
        }

        private async Task GetIngredientAsync(UserIngredient ingredient) {
            if (ingredient == null)
            {
                addIngredient = 0;
            }
            else
            {
                if (addIngredient == 1)
                {
                    if (Whouse.Ingredients == null)
                    {
                        Whouse.Ingredients = new List<UserIngredient>();
                    }
                    Whouse.Ingredients.Add(ingredient);
                    await MyWarehouseInj.UpdateUserWarehouse(Whouse);
                }
                else
                {
                    await MyWarehouseInj.UpdateUserIngredient(ingredient);
                }
                userIngredients = await MyWarehouseInj.GetUserIngredients(Whouse);
                addIngredient = 0;
            }            
        }

        private async Task<MyWarehouse> GetUserWhAsync() {
            var authstate = await GetAuthenticationStateAsync.GetAuthenticationStateAsync();
            var user = authstate.User.Identity.Name;
            _user = await userManager.FindByNameAsync(user);
            return await MyWarehouseInj.GetUserWarehouse(_user);
        }
    }
}
