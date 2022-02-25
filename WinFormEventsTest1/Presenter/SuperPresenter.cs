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
        ItemPresenter.OnSaveItem += ItemPresenter_ShowItem;
        ItemPresenter.OnMode += ListPresenter_ItemMode;
    }

    private void ItemPresenter_ShowItem(Item item)
    {
        Form.listViewItemInfo.Items.Clear();
        Form.listViewItemInfo.Items.Add(item.Id.ToString());
        Form.listViewItemInfo.Items.Add(item.Id.ToString(item.Name));
        Form.listViewItemInfo.Items.Add(item.Id.ToString(item.Description));
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

//     private void ListModel_ChangedPrograms(Item item)
//     {
//         Form.listViewItemInfo.Clear();
//         ListViewItem itemListView = new()
//         {
//             Text = item.Name,
//             Tag = item,
//         };
//
//         Form.listViewPrograms.Items.Add(item);
//     }
// }
}
    