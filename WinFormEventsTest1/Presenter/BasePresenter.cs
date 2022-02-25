namespace WinFormEventsTest1;

public enum Mode
{
    Item,
    ListItem
}
public abstract class BasePresenter <TForm> where TForm : Form
{
    protected TForm Form;

    protected BasePresenter(TForm form)
    {
        Form = form;
    }
    
    
}