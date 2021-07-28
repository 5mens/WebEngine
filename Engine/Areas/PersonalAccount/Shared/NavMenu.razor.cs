using Engine.Models.BaseClasses;
using Engine.Models.Interfaces;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Engine.Areas.PersonalAccount.Shared
{
    public partial class NavMenu
    {
        [Inject]
        IMenuItem menuItems { get; set; }
        [Inject]
        private IMenu MyMenu { get; set; }
        private List<MenuItem> mainMenu = new List<MenuItem>();
        protected async override Task OnInitializedAsync()
        {            
            try
            {
                mainMenu = await menuItems.GetMenuItemsById(MyMenu.GetMainMenu().Id);
            }
            finally
            {
                //
            }
            await base.OnInitializedAsync();
        }

        private string GetIcon(string icon) {
            switch (icon) {
                case "Message":
                    return Icons.Filled.Message;
                case "Contacts":
                    return Icons.Filled.Contacts;
                case "MenuBook":
                    return Icons.Filled.MenuBook;
                case "Reorder":
                    return Icons.Filled.Reorder;
                case "FoodBank":
                    return Icons.Filled.FoodBank;
                case "Calculate":
                    return Icons.Filled.Calculate;
                default:
                    return Icons.Filled.Home;
                    break;
            }
        }
    }
}
