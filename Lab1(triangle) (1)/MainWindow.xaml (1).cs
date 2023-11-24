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
using Serilog.Events;
using Serilog;



namespace Lab1_triangle_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            Log.Logger = new LoggerConfiguration().WriteTo.File(@"C:\Users\dvilli\Desktop\log.txt").CreateLogger();
            Log.Information("Запуск.");
            InitializeComponent();

        }
        //метод, который вызывает другие методы

        //штука которая запрещает ввод каких либо значений в строку
        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            foreach (char c in e.Text)
            {
                if (!char.IsDigit(c) && c != ',' && c != '-' && c !='.')
                {
                    e.Handled = true; // Отменяем ввод недопустимого символа
                    break;

                }
                
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            VivodA.Text = "";
            VivodB.Text = "";
            VivodC.Text = "";
            string st1 = storonaA.Text;
            string st2 = storonaB.Text;
            string st3 = storonaC.Text;

            //Controller.ControllerTest(st1, st2, st3);
            (string result, int[] verts, string error, string EmailMessage) = new Controller().ControllerTest(st1, st2, st3); //вызов метода
            TypeVivod.Text = result;

            VivodA.Text = "(X)" + verts[0] + "  (Y)  " + verts[1];
            VivodB.Text = "(X)" + verts[2] + "  (Y)  " + verts[3];
            VivodC.Text = "(X)" + verts[4] + "  (Y)  " + verts[5];
            MessageBox.Show(EmailMessage);

        }
    }
}
