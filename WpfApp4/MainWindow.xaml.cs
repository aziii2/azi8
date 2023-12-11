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

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            private void  Button_Click(object sender, RoutedEventArgs e)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "image Files|*.jpg;*jpeg;*.png;*.gif;*.bmp";
                if (openFileDialog.ShowDialog() == true)
                {
                    BitmapImage bitmap = new BitmapImage(new Uri(openFileDialog.FileName));
                    imageControl.Source = bitmap;
                }
            }
            MarathonSkillsEntities db = new MarathonSkillsEntities();
            int id;
            public MySponsor(int _id)
            {
                id = _id;
                InitializeComponent();
                var user = db.User.Where(x => x.ID == id).SingleOrDefault();
                var logo = db.Fund.Where(x => x.ID == user.ID_Fund).Select(x => x.Logo).SingleOrDefault();
                if (logo != null)
                {
                    Logo.Source = Img.ToBitmapImage(logo);
                    txt_fund.Text = db.Fund.Where(x => x.ID == user.ID_Fund).Select(x => x.Name).SingleOrDefault();
                    txt_fund_Copy.Text = Convert.ToString(db.Fund.Where(x => x.ID == user.ID_Fund).Select(x => x.Money).SingleOrDefault());
                    int sponsor_id = (int)db.Fund.Where(y => y.ID == user.ID_Fund).Select(u => u.ID_Sponsor).SingleOrDefault();
                    if (sponsor_id == 0)
                    {
                        MessageBox.Show("Нет спонсора", "Ошибка сервера");
                    }
                    else
                    {
                        grid_sponsor.ItemsSource = db.SponsorRunner.Where(x => x.ID == sponsor_id).ToList();
                    }

                }
                else
                {
                    MessageBox.Show("У вас нет спонсора", "Ошибка");
                }

            }
        }
}
