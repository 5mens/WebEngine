using Engine.Models.BaseClasses;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Engine.Areas.AdminPanel.Pages
{
    public partial class UserGroupEdit
    {
        [Parameter]
        public string GroupId { get; set; }
        [Inject]
        private RoleManager<UserGroup> roleManager { get; set; }
        [Inject]
        private NavigationManager Nav { get; set; }
        private string _groupId;
        private UserGroup editedRole = null;
        protected override async Task OnInitializedAsync() {
            _groupId = GroupId;
            editedRole = await roleManager.FindByIdAsync(_groupId);
            await base.OnInitializedAsync();
        }

        private async Task UpdateRole() {
            await roleManager.UpdateAsync(editedRole);
            Cancel();
        }

        private void Cancel() {
            Nav.NavigateTo($"/administrator/user/groups");
        }
    }
}
