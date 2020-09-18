using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Inlamningsuppgift_2.Views
{
    /// <summary>
    /// Interaction logic for MessageWiewControl.xaml
    /// </summary>
    public partial class MessageWiewControl : UserControl
    {
        public MessageWiewControl()
        {
            InitializeComponent();
        }

        private void btnViewMessage_Click(object sender, RoutedEventArgs e)
        {
            time.Text = "mon 16.32";
            subject.Text = "Tortilla Reminder!";
            from.Text = "Yukio <yukio@ronin.com>";
            to.Text = "James Howlett";
            body.Text = "Hey Wolverine, Just reminding you to buy tortillas, we are out of them and taco tuesday is a must.  //Yukio";
            btnReply.Content= "REPLY";
            btnReplyAll.Content = "REPLY ALL";
            btnForward.Content = "FORWARD"; 
        }
    }
}
