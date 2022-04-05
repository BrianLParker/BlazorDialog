using System;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace BlazorDialog;

public class DialogService : IAsyncDisposable, IDialogService
{
    private readonly Lazy<Task<IJSObjectReference>> moduleTask;

    public DialogService(IJSRuntime jsRuntime)
    {
        moduleTask = new(() => jsRuntime.InvokeAsync<IJSObjectReference>(
           "import", "./_content/BlazorDialog/dialogJsInterop.js").AsTask());
    }

    public async ValueTask ShowDialogAsync(Dialog dialog)
    {
        var module = await moduleTask.Value;
        await module.InvokeVoidAsync("showDialog", dialog.dialogElement);
    }

    public async ValueTask CloseDialogAsync(Dialog dialog)
    {
        var module = await moduleTask.Value;
        await module.InvokeVoidAsync("closeDialog", dialog.dialogElement);
    }

    public async ValueTask DisposeAsync()
    {
        if (moduleTask.IsValueCreated)
        {
            var module = await moduleTask.Value;
            await module.DisposeAsync();
        }
    }
}
