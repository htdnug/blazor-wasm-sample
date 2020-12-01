using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace BlazorWasmClientSample.Components.Models
{
    public class CodeInheritsComponent : ComponentBase
    {
        public bool IsLoading { get; set; } = true;

        protected override async Task OnInitializedAsync()
        {
            await Task.Delay(3000);
            this.IsLoading = false;
            await base.OnInitializedAsync(); // Important to keep 'base.' calls in Blazor. OnParameterSet is a must.
        }
    }
}
