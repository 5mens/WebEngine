using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Http;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace Engine.Areas.WebSite.Shared
{
    public partial class Login
    {
        [Inject]
        NavigationManager Nav { get; set; }

        [CascadingParameter] protected Task<AuthenticationState> AuthStat { get; set; }
        protected async override Task OnInitializedAsync()
        {            
            base.OnInitialized();
        }
    }
}
