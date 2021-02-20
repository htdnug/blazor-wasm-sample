using System.Threading.Tasks;

namespace BlazorWasmClientSample.Components
{
    public partial class CodePartialClass
    {
        private bool isLoading = true;

        protected override async Task OnInitializedAsync()
        {
            await Task.Delay(3000);
            this.isLoading = false;
            await base.OnInitializedAsync(); // Important to keep 'base.' calls in Blazor. OnParameterSet is a must.
        }
    }
}
