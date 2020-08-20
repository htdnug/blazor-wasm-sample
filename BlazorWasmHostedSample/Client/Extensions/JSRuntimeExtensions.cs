using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BlazorWasmHostedSample.Client.Extensions
{
    public static class JSRuntimeExtensions
    {
        public static ValueTask<T> LocalStorageGet<T>(this IJSRuntime js, string key)
        {
            return js.InvokeAsync<T>("htdnug.localStorageGet", key);
        }

        public async static Task LocalStorageSet<T>(this IJSRuntime js, string key, T value)
        {
            await js.InvokeVoidAsync("htdnug.localStorageSet", key, value);
        }
    }
}
