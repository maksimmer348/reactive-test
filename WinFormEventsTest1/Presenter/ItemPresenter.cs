namespace WinFormEventsTest1;

public class ItemPresenter : BasePresenter<SuperForm>
{
    public event Action<Item> OnSaveItem;

    //для отладки рандом
    Random r = new Random();

    //private ItemModel itemModel;

    private Item item;

    public ItemPresenter(SuperForm form, Item item) : base(form)
    {
        this.item = item;
        //itemModel = new ItemModel();
    }

    public void SaveItemInList()
    {
        var rnd = r.Next(0, 20);
        var rnd1 = r.Next(20, 100);

        if (!string.IsNullOrWhiteSpace(Form.tBoxItemName.Text))
        {
            item.Id = rnd;
            item.Name = Form.tBoxItemName.Text;
            item.Id = rnd1;
            //itemModel.SaveItem(item);
        }
        else
        {
            Form.CreateMessage("Назоваитье прграмму");
            return;
        }

        OnSaveItem?.Invoke(item);
    }
    
}