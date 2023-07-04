namespace TodoWeb.Client.Components;

partial class TodoList
{
    private readonly List<TodoItem> _items = new List<TodoItem>();

    public void ClearCompleted()
    {
        _items.RemoveAll(x => x.Completed);
    }

    public void RemoveItem(TodoItem item)
    {
        _items.Remove(item);
        StateHasChanged();
    }

    public void AddItem(TodoItem item)
    {
        _items.Add(item);
        StateHasChanged();
    }

    public void ToggleAll()
    {
        var allCompleted = _items.All(x => x.Completed);
        _items.ForEach(x => x.Completed = !allCompleted);
        StateHasChanged();
    }

    public void ItemStateChanged()
    {
        StateHasChanged();
    }
}
