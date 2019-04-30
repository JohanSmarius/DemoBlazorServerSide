using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFromServer.JavaScriptInterop
{
    public interface IJavaScriptInterop
    {
        Task<bool> Confirm(string message);
    }
}
