using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace BlazorFromServer.JavaScriptInterop
{
    public class JavaScriptInterop : IJavaScriptInterop
    {
        private readonly IJSRuntime _jsRuntime;

        public JavaScriptInterop(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime ?? throw new System.ArgumentNullException(nameof(jsRuntime));
        }

        public Task<bool> Confirm(string message)
        {
            return _jsRuntime.InvokeAsync<bool>("helperfunction.confirm", message);
        }
    }
}
