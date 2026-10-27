using System;
using System.Windows.Forms;

class MyDialog : Form
{
    public MyDialog()
    {
        Text = "Custom Dialog Box";
        Width = 300;
        Height = 150;

        Label l = new Label();
        l.Text = "Do you want to continue?";
        l.SetBounds(30, 20, 220, 25);

        Button b = new Button();
        b.Text = "OK";
        b.SetBounds(90, 60, 80, 30);
        b.Click += (s, e) => Close();

        Controls.Add(l);
        Controls.Add(b);
    }

    static void Main()
    {
        MyDialog d = new MyDialog();
        d.ShowDialog();
    }
}
