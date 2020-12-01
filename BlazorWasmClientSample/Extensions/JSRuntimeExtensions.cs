using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BlazorWasmClientSample.Extensions
{
    public static class JSRuntimeExtensions
    {
        public static ValueTask<T> LocalStorageGet<T>(this IJSRuntime js, string key)
        {
            return js.InvokeAsync<T>("jk.localStorageGet", key);
        }

        public async static Task LocalStorageSet<T>(this IJSRuntime js, string key, T value)
        {
            await js.InvokeVoidAsync("jk.localStorageSet", key, value);
        }
    }
}
