namespace WinFormEventsTest1;

public class ListModel
{
    //private Item item = new();
    private List<Item> listItems = new ();
    public event Action<List<Item>> OnChangedListItems;
  

    

    public void SaveItemInList(Item savedItem)
    { 
        listItems.Add(savedItem);
        OnChangedListItems?.Invoke(listItems);
    }
}