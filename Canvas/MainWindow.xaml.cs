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

namespace MyCanvas
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<int> x= new List<int> { };
            List<int> y = new List<int> { };

         
       

            const int N =3;
            const int M =3;
          
            double[,] f= new double[N,M] ;

            for(int tem = 0; tem < N; tem++)
            {
                x.Add(tem);
            }
            for (int tem = 0; tem < M; tem++)
            {
                y.Add(tem);
            }
            int[] i = x.ToArray();
            int[]j = y.ToArray();

            f[1,1]= 1;

            
            heatmap.Plot(f,i,j);
            double a = chart.Width;
            double b = chart.Height;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //得到canvas的实际高度
            double width = canvas.ActualWidth;
            double height = canvas.ActualHeight;
            MessageBox.Show(width.ToString() +"\n"+ height.ToString());
        }
    }
}
