using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace BlazorFromServer.App.JavaScriptInterop
{
    public static class JavaScriptInterop
    {
        public static Task<bool> Confirm(string message)
        {
            return JSRuntime.Current.InvokeAsync<bool>("helperfunction.confirm", message);
        }
    }
}
