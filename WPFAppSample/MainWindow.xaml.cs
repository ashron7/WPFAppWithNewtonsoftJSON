using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFAppSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public class Account
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Sex { get; set; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Account account = new Account();
            account.Name = "Ashronaldosrkira 7";
            account.Age = 29;
            account.Sex = "Male";

            string json = JsonConvert.SerializeObject(account);
            var accountObj = JsonConvert.DeserializeObject<Account>(json);

            //Serialization to JSON
            TxtBlock.Text = json;

            //Deserialization to JSON
            TxtBlock.Text = accountObj.Name;
        }
    }
}
