using Microsoft.AspNetCore.Components;

namespace TodoWeb.Client.Components;

partial class Todo
{
    [Parameter]
    public TodoItem Item { get; set; }

    [Parameter]
    public Action<TodoItem> RemoveAction { get; set;}

    [Parameter]
    public Action StateHasChangedAction { get; set; }

    public void ToggleEditing()
    {
        Item.Editing = !Item.Editing;
    }

    public void Remove()
    {
        RemoveAction(Item);
    }

    public void ToggleCompleted()
    {
        Item.Completed = !Item.Completed;
        StateHasChangedAction();
    }

}
