using System;
using ClassLibraryNetStandard;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnHiButtonPressed(object sender, EventArgs e)
    {
        var userName = userNameInput.Text;
        var dialog = new MessageDialog(this, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, User.SayHello(userName));
        dialog.Run();
        dialog.Destroy();
    }
}
