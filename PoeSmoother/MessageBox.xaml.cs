using System.Media;
using System.Windows;

namespace PoeSmoother;

public partial class MessageBox : Window
{
    public MessageBox(string message, string title = "PoE Smoother")
    {
        InitializeComponent();
        TitleText.Text = title;
        MessageText.Text = message;
    }

    private void OkButton_Click(object sender, RoutedEventArgs e)
    {
        DialogResult = true;
        Close();
    }

    public static void Show(string message, string title = "PoE Smoother")
    {
        // Play notification sound
        SystemSounds.Asterisk.Play();
        
        var dialog = new MessageBox(message, title);
        
        if (Application.Current.MainWindow != null)
        {
            dialog.Owner = Application.Current.MainWindow;
            dialog.WindowStartupLocation = WindowStartupLocation.CenterOwner;
        }
        
        dialog.ShowDialog();
    }
}
