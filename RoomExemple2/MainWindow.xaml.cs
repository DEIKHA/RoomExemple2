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
using RoomLibrary;
namespace RoomExemple2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Room> lstRoom = new List<Room>();
       
    
    
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BAddRoom_Click(object sender, RoutedEventArgs e)
        {
            Room room = new Room();
            room.RoomLength = Convert.ToDouble(TBLenghtR.Text);
            room.RoomWidth = Convert.ToDouble(TBLenghtR.Text);
            lstRoom.Add(room);
        }

        private void BAddLivingRoom_Click(object sender, RoutedEventArgs e)
        {
            LivingRoom livingRoom = new LivingRoom();
            livingRoom.RoomLength = Convert.ToDouble(TBLenghtR.Text);
            livingRoom.RoomWidth = Convert.ToDouble(TBLenghtR.Text);
            livingRoom.NumWin = Convert.ToInt32(TBNumW.Text);
            lstRoom.Add(livingRoom);
        }

        private void BAddOffice_Click(object sender, RoutedEventArgs e)
        {
            Office office = new Office();
            office.RoomLength = Convert.ToDouble(TBLenghtR.Text);
            office.RoomWidth = Convert.ToDouble(TBLenghtR.Text);
            office.NumSockets = Convert.ToInt32(TBNumS.Text);
            lstRoom.Add(office);
        }

        private void BGetList_Click(object sender, RoutedEventArgs e)
        {
            ListRooms.Content = "";
            foreach (Room r in lstRoom)
                ListRooms.Content += r.Info() + "\n";
           
        }
    }
}
