using System;
using System.Windows.Forms;

class MainForm : Form
{
    public MainForm()
    {
        Text = "MDI Application";
        IsMdiContainer = true;
        Width = 600;
        Height = 400;

        MenuStrip menu = new MenuStrip();
        ToolStripMenuItem file = new ToolStripMenuItem("File");
        ToolStripMenuItem open = new ToolStripMenuItem("Open");

        open.Click += (s, e) =>
        {
            Form child = new Form();
            child.Text = "Child Window";
            child.MdiParent = this;
            child.Show();
        };

        file.DropDownItems.Add(open);
        menu.Items.Add(file);

        Controls.Add(menu);
        MainMenuStrip = menu;
    }

    static void Main()
    {
        Application.Run(new MainForm());
    }
}