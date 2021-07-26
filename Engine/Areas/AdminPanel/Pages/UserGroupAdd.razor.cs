using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Engine.Data;
using Microsoft.AspNetCore.Identity;
using Engine.Models.BaseClasses;

namespace Engine.Areas.AdminPanel.Pages
{
    public partial class UserGroupAdd {
        [Inject]
        private NavigationManager Nav { get; set; }                
        private UserGroup newGroup = new UserGroup();
        [Inject]
        private RoleManager<UserGroup> roleManager { get; set; }
        /// <summary>
        /// Сохранить
        /// </summary>
        private async Task OnButtonClicked()
        {
            if (newGroup.Name != string.Empty || newGroup.Name != "")
            {
                if (!await roleManager.RoleExistsAsync(newGroup.Name))
                {
                    await roleManager.CreateAsync(newGroup);
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
    }    
}
