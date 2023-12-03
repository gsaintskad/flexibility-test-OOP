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

          //  root.AddChild(new card();
        }


        private void mainSP_SizeChanged(object sender, SizeChangedEventArgs e)
        {
                
            rightSP.Width = root.Width-15;
            leftSP.Width = root.Width-15;


            if (root.Width > 900)
            {
                rightSP.Orientation = Orientation.Horizontal;
                leftSP.Orientation = Orientation.Horizontal;
            } 
            else
            {
                rightSP.Orientation=Orientation.Vertical;
                leftSP.Orientation=Orientation.Vertical;
            }


                //musze wywolywac ta funkcje przez bug zwiazany ze zmniejszeniem okna 
                rightSP_SizeChanged(sender,e);
        }

        private void rightSP_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (root.Width > 900)
            {
                c00.Width = rightSP.Width / 3;
                c01.Width = rightSP.Width / 3;
                c02.Width = rightSP.Width / 3;
                c10.Width = rightSP.Width / 3;
                c11.Width = rightSP.Width / 3;
                c12.Width = rightSP.Width / 3;
            }
            else
            {
                c00.Width = rightSP.Width;
                c01.Width = rightSP.Width;
                c02.Width = rightSP.Width;
                c10.Width = rightSP.Width;
                c11.Width = rightSP.Width;
                c12.Width = rightSP.Width;
            }
        }
    }
}
