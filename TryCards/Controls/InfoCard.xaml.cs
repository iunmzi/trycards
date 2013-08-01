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

namespace TryCards.Controls
{
    /// <summary>
    /// Interaction logic for InfoCard.xaml
    /// </summary>
    public partial class InfoCard : UserControl
    {
        public InfoCard()
        {
            InitializeComponent();
        }

        Brush GridMainDefault = Brushes.LightGray;
        Brush GridMainHighlight = Brushes.LightBlue;


        private void On_Border_MouseEnter(object sender, MouseEventArgs e)
        {
            this.grdMain.Background = this.GridMainHighlight;
        }

        private void On_Border_MouseLeave(object sender, MouseEventArgs e)
        {
            this.grdMain.Background = this.GridMainDefault;
        }
    }
}
