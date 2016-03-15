using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Contacts;
using Windows.ApplicationModel.Email;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=234238

namespace MenuBook1
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Page1 : Page
    {
        public Page1()
        {
            this.InitializeComponent();
        }

        private async void email_Click(object sender, RoutedEventArgs e)
        {
            EmailMessage email = new EmailMessage();
            email.To.Add(new EmailRecipient("benjim.flores@outlook.com"));
            email.Subject = "Message Prueba";
            //var file = await GetTextFile();
            //email.Attachments.Add(new EmailAttachment(file.Name, file));
​            await EmailManager.ShowComposeNewEmailAsync(email);
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {

            Frame.Navigate(typeof(MainPage));
            /*
            if (button3.IsPressed == false)
                button3.Content = "\uE017";
            else
                button3.Content = "\uE711";*/
        }
    }
}
