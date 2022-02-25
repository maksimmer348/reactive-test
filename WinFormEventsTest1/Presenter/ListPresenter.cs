namespace WinFormEventsTest1;

public class ListPresenter : BasePresenter<SuperForm>
{
    public event Action<Mode> OnMode;
    public event Action<string> OnErrorMessage;
    public event Action<Item, bool> OnChangedItem;
    
    private ListModel listModel;
    
    public ListPresenter(SuperForm form) : base(form)
    {
        listModel = new ListModel();
        listModel.OnChangedListItems += ListModel_ChangedListItems;
    }

  
    public void CreateItemBlank()
    {
        var item = new Item();
        OnChangedItem?.Invoke(item, false);
        OnMode?.Invoke(Mode.Item);
    }

    public void ChangeSelectItem()
    {
       
    }

    public void DeleteSelectItem()
    {
       
    }
    
    private bool ProgramExist(string message, out Item program)
    {
        if (Form.listViewItemsList.SelectedIndices.Count > 0)
        {
            program = (Item)Form.listViewItemsList.SelectedItems[0].Tag;
            return true;
        }
        
        OnErrorMessage?.Invoke(message);
        program = null;
        return false;
    }
    
    private void ListModel_ChangedListItems(List<Item> listItems)
    {
        Form.listViewItemsList.Clear();
        foreach (var program in listItems)
        {
            ListViewItem item = new()
            {
                Text = program.Name,
                Tag = program,
            };
            
            Form.listViewItemsList.Items.Add(item);
        }
        OnMode?.Invoke(Mode.Item);
    }

    public void SaveItemInList(Item savedItem)
    {
        listModel.SaveItemInList(savedItem);
        
    }
}