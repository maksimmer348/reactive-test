namespace WinFormEventsTest1;

public class ItemModel
{
    public event Action<Item> OnItemChange;
    private Item item;

   
    public void SaveItem(int id, string name, string desc)
    {
        item.Id = id;
        item.Name = name;
        item.Description = desc;
        OnItemChange?.Invoke(item);
    }
    
     
    public void DontSaveItem()
    {
        OnItemChange?.Invoke(item);
    }
}