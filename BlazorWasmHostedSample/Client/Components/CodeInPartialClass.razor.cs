using System.Threading.Tasks;

namespace BlazorWasmHostedSample.Client.Components
{
    public partial class CodeInPartialClass
    {
        private bool isLoading = true;

        protected override async Task OnInitializedAsync()
        {
            await Task.Delay(5000);
            this.isLoading = false;
            await base.OnInitializedAsync(); // Important to keep 'base.' calls in Blazor. OnParameterSet is a must.
        }
    }
}
