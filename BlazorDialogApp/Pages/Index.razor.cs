using System.Threading.Tasks;
using BlazorDialog;
using Microsoft.AspNetCore.Components;

namespace BlazorDialogApp.Pages;

public partial class Index : ComponentBase
{
    private Dialog dialog;

    [Inject]
    private IDialogService DialogService { get; set; }

    private async Task OpenDialog() => await DialogService.ShowDialogAsync(dialog);
    private async Task CloseDialog() => await DialogService.CloseDialogAsync(dialog);
}
