using System;
using System.Threading.Tasks;

namespace BlazorDialog;

public interface IDialogService : IAsyncDisposable
{
    ValueTask CloseDialogAsync(Dialog dialog);
    ValueTask ShowDialogAsync(Dialog dialog);
}
