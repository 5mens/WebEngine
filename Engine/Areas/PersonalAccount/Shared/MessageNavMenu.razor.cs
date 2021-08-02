using Engine.Models.BaseClasses;
using Engine.Models.Interfaces;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Engine.Areas.PersonalAccount.Shared
{
    public partial class MessageNavMenu
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
                mainMenu = await menuItems.GetMenuItemsById(5);
            }
            finally
            {
                //
            }
            await base.OnInitializedAsync();
        }
    }
}
