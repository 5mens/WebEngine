using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Engine.Data;
using Microsoft.AspNetCore.Identity;

namespace Engine.Areas.AdminPanel.Pages
{
    public partial class UserGroupAdd {
        [Inject]
        private NavigationManager Nav { get; set; }                
        private string _groupName = string.Empty;
        [Inject]
        private RoleManager<IdentityRole> roleManager { get; set; }
        /// <summary>
        /// Сохранить
        /// </summary>
        private async Task OnButtonClicked()
        {
            if (_groupName != string.Empty || _groupName != "")
            {
                if (!await roleManager.RoleExistsAsync(_groupName))
                {
                    await roleManager.CreateAsync(new IdentityRole { Name = _groupName});
                }
            }
            
            Cancel();
        }
        /// <summary>
        /// Отмена
        /// </summary>
        private void Cancel()
        {
            Nav.NavigateTo($"/administrator/user/groups");
        }

        public static async Task InitializeAsync(RoleManager<IdentityRole> roleManager)
        {
            
            if (await roleManager.FindByNameAsync("employee") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("employee"));
            }
        }
    }    
}
