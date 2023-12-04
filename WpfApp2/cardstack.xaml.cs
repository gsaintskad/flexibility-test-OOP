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
    /// Interaction logic for cardstack.xaml
    /// </summary>
    public partial class cardstack : UserControl
    {
        public cardstack()
        {
            InitializeComponent();


            // funkcja ktora bedzie pobierala info z DB
            AddChildElements();
            //  root.AddChild(new card();
        }

        
        private List<string> fill_list()
        {
            var list = new List<string>();
           for(int i = 0; i <50; i++) 
            {
                Random random = new Random();
                list.Add(random.Next(1, 100).ToString());
            }
           return list;
        }
       
  
        private void AddChildElements()
        {
            List<string> names = fill_list();
            //mainSP.Children.Add(c);
            foreach(string name in names)
            {   
           //     button.Click += () => { buttonclick(button); };
                mainSP.Children.Add(new card(name));
          
            }

        }
        

    }
}
