using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Validation
{
    public class InputWatcher : ComponentBase
    {
        private EditContext editContext;

        [CascadingParameter]
        protected EditContext EditContext
        {
            get => editContext;
            set
            {
                editContext = value;
                EditContext.OnFieldChanged += async (sender, e) =>
                {
                    await FieldChanged.InvokeAsync(e.FieldIdentifier.FieldName);
                };
            }
        }

        [Parameter]
        public EventCallback<string> FieldChanged { get; set; }

        public bool Validate()
        => EditContext?.Validate() ?? false;

    }
}
