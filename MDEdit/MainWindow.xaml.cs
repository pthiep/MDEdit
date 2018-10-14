using System;
using System.ComponentModel;
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
using MahApps.Metro.Controls;

namespace MDEdit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow, INotifyPropertyChanged
    {
        private string xMDSource;
        public string XMDSource {
            get => xMDSource;
            set {
                xMDSource = value;
                OnPropertyChanged("XMDSource");
            }            
        }          

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            XMDSource = "This is MD";
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string newName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(newName));
            }
        }

        private void TestString_Click(object sender, RoutedEventArgs e)
        {
            //string richText = new TextRange(Richtextbox.Document.ContentStart, Richtextbox.Document.ContentEnd).Text;
            //MessageBox.Show(richText);
            MessageBox.Show(xMDSource);
        }

        //private void rtbXMDSource_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    XMDSource = rtbXMDSource.Text;
        //}
    }
}
