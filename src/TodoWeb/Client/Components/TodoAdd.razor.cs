using Microsoft.AspNetCore.Components;

namespace TodoWeb.Client.Components;

partial class TodoAdd
{
    [Parameter]
    public Action<TodoItem> AddItemAction { get; set; }

    private string _newItemText = string.Empty;

    public void Add()
    {
        var newTodo = new TodoItem { Title = _newItemText, Completed = false, Editing = false};

        AddItemAction(newTodo);
        _newItemText = string.Empty;
    }
}
