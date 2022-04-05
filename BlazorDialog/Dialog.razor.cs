using System.Collections.Generic;
using Microsoft.AspNetCore.Components;

namespace BlazorDialog;

public partial class Dialog : ComponentBase
{
    internal ElementReference dialogElement;
    [Parameter]
    public RenderFragment ChildContent { get; set; }

    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object> CapturedAttributes { get; set; }
}
