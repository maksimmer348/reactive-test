

namespace WinFormEventsTest1;

public partial class SuperForm : Form
{
    private SuperPresenter superPresenter;
    public SuperForm()
    {
        InitializeComponent();
        superPresenter = new SuperPresenter(this);
        ListItemsMode();
    }

    #region ItemsList

    private void btnAdd_Click(object sender, EventArgs e)
    {
        superPresenter.ListPresenter.CreateItemBlank();
    }

    private void btnChange_Click(object sender, EventArgs e)
    {
        superPresenter.ListPresenter.ChangeSelectItem();
    }

    private void btnDel_Click(object sender, EventArgs e)
    {
        superPresenter.ListPresenter.DeleteSelectItem();
    }

    #endregion


    #region Item

    private void btnSave_Click(object sender, EventArgs e)
    {
        superPresenter.ItemPresenter.SaveItemInList();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
    }

    #endregion

    public void ListItemsMode()
    {
        groupBox2.Enabled = false;
        groupBox1.Enabled = true;
    }
    public void ItemMode()
    {
        groupBox2.Enabled = true;
        groupBox1.Enabled = false;
    }
    private void tBoxItemName_TextChanged(object sender, EventArgs e)
    {
    }

    private void listViewItemsList_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }

    private void listViewItemInfo_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    public void CreateMessage(string message)
    {
       
    }
}