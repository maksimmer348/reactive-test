namespace WinFormEventsTest1;

public class SuperPresenter : BasePresenter<SuperForm>
{
   
    public ListPresenter ListPresenter;
    public ItemPresenter ItemPresenter;
    public SuperPresenter(SuperForm form) : base(form)
    {
        ListPresenter = new ListPresenter(form);
       
        ListPresenter.OnChangedItem += ListPresenter_ChangedItem;
        ListPresenter.OnMode += ListPresenter_ItemMode;
    }

    private void ListPresenter_ChangedItem(Item item, bool readOnly)
    {
        if (readOnly)
        {
            return;
        }
        ItemPresenter = new ItemPresenter(Form, item);
        ItemPresenter.OnSaveItem += ItemPresenter_SaveItem;
    }

    private void ItemPresenter_SaveItem(Item savedItem)
    {
        ListPresenter.SaveItemInList(savedItem);
    }

    private void ListPresenter_ItemMode(Mode m)
    {
        if (m == Mode.ListItem)
        {
            Form.ListItemsMode();
        }
        if (m == Mode.Item)
        {
            Form.ItemMode();
        }
    }

    

    private void ItemPresenter_ItemChange(Item item)
    {
        Form.listViewItemInfo.Items.Add(item.Id.ToString());
        Form.listViewItemInfo.Items.Add(item.Id.ToString(item.Name));
        Form.listViewItemInfo.Items.Add(item.Id.ToString( item.Description));
    }
    
}