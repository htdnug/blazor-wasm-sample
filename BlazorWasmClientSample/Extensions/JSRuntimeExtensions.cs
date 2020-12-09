using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BlazorWasmClientSample.Extensions
{
    public static class JSRuntimeExtensions
    {
        public static ValueTask<T> LocalStorageGet<T>(this IJSRuntime js, string key) => js.InvokeAsync<T>("jk.localStorageGet", key);
        public async static Task LocalStorageSet<T>(this IJSRuntime js, string key, T value) => await js.InvokeVoidAsync("jk.localStorageSet", key, value);

        public static async Task ResetPageTitle(this IJSRuntime js) => await js.InvokeVoidAsync("jk.resetPageTitle");
        public static async Task SetPageTitle(this IJSRuntime js, string text) => await js.InvokeVoidAsync("jk.setPageTitle", text);
    }
}
