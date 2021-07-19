

using Blazeditor.TinyMCE;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Engine.Areas.AdminPanel.Pages
{
    public partial class ArticleAdd
    {
        DateTime? date = DateTime.Now;
        
        const string initialText = "";
        private TextEditor TextEditor;
        private string data = string.Empty;
        private string onchangedData = string.Empty;

        private string _articleAuthor;
        private string _articleTitle;
        private string _articleCategory;

        /// <summary>
        /// Временная хрень для того, чтобы возвращать имя пользователя
        /// </summary>
        protected async override Task OnInitializedAsync()
        {
            var authstate = await GetAuthenticationStateAsync.GetAuthenticationStateAsync();
            var user = authstate.User;
            _articleAuthor = user.Identity.Name;
            await base.OnInitializedAsync();
        }

        private BlazeditorOption textEditorOption = new BlazeditorOption
        {
            Toolbar = "undo redo | styleselect | bold italic | alignleft aligncenter alignright alignjustify | outdent indent | link",
            ShowMenuBar = true,
            PasteAsText = true,
            PasteDataImage = true
        };
        public async Task GetContent()
        {
            data = await TextEditor.GetContent();
        }

        public async Task ClearContent() => await TextEditor.SetContent(string.Empty);

        async Task OnChange(string returnValue)
        {
            await Task.Run(() =>
            {
                onchangedData = returnValue;
            });
        }

        private bool resetValueOnEmptyText;
        private bool coerceText;
        private bool coerceValue;
        private string value1, value2;
        private string[] states =
        {
        "Alabama", "Alaska", "American Samoa", "Arizona",
        "Arkansas", "California", "Colorado", "Connecticut",
        "Delaware", "District of Columbia", "Federated States of Micronesia",
        "Florida", "Georgia", "Guam", "Hawaii", "Idaho",
        "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky",
        "Louisiana", "Maine", "Marshall Islands", "Maryland",
        "Massachusetts", "Michigan", "Minnesota", "Mississippi",
        "Missouri", "Montana", "Nebraska", "Nevada",
        "New Hampshire", "New Jersey", "New Mexico", "New York",
        "North Carolina", "North Dakota", "Northern Mariana Islands", "Ohio",
        "Oklahoma", "Oregon", "Palau", "Pennsylvania", "Puerto Rico",
        "Rhode Island", "South Carolina", "South Dakota", "Tennessee",
        "Texas", "Utah", "Vermont", "Virgin Island", "Virginia",
        "Washington", "West Virginia", "Wisconsin", "Wyoming",
    };

        private async Task<IEnumerable<string>> Search1(string value)
        {
            // In real life use an asynchronous function for fetching data from an api.
            await Task.Delay(5);

            // if text is null or empty, show complete list
            if (string.IsNullOrEmpty(value))
                return states;
            return states.Where(x => x.Contains(value, StringComparison.InvariantCultureIgnoreCase));
        }

        private async Task<IEnumerable<string>> Search2(string value)
        {
            // In real life use an asynchronous function for fetching data from an api.
            await Task.Delay(5);

            // if text is null or empty, don't return values (drop-down will not open)
            if (string.IsNullOrEmpty(value))
                return new string[0];
            return states.Where(x => x.Contains(value, StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
