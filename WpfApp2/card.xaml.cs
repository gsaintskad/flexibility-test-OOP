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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for card.xaml
    /// </summary>
    public partial class card : UserControl
    {
        public static readonly DependencyProperty SourceOfImageProperty = DependencyProperty.Register("SourceOfImage", typeof(string), typeof(card), new PropertyMetadata(string.Empty));
        public static readonly DependencyProperty AuthorNickNameProperty = DependencyProperty.Register("AuthorNickName", typeof(string), typeof(card), new PropertyMetadata(string.Empty));
        public static readonly DependencyProperty TrackNameProperty = DependencyProperty.Register("TrackName", typeof(string), typeof(card), new PropertyMetadata(string.Empty));

        public string SourceOfImage
        {
            get { return (string)GetValue(SourceOfImageProperty); }
            set { SetValue(SourceOfImageProperty, value); }
        }

        public string AuthorNickName
        {
            get { return (string)GetValue(AuthorNickNameProperty); }
            set { SetValue(AuthorNickNameProperty, value); }
        }
        public string TrackName
        {
            get { return (string)GetValue(TrackNameProperty); }
            set { SetValue(TrackNameProperty, value); }
        }
        public card()
        {
            InitializeComponent();
        }
        public card(string authorNickName)
        {
            this.AuthorNickName = authorNickName;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //tutaj musi być request do bazy danych aby pobrać track

             MessageBox.Show(this.AuthorNickName);
        }

        

        private void myCard_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            cardBorder.Width=e.NewSize.Width;
            horizontSP.Width=e.NewSize.Width;
        }


       
    }
}
