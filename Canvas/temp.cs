using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Use;

namespace MyCanvas
{
    public static class temp
    {
        internal static double itRatio;
        /// <summary>
        /// 将对应的Heatmap的值转换成canvas的实际坐标，
        /// result[i,0]和result[0,j]
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public static double[,] TransXY(List<int> x, List<int> y,Canvas canvas)
        {
            
            int _M = x.Count;
            int _N = y.Count;
            double[,] _point = new double[_M+1,_N+1];       
            double[] canvasX = new double[_M];
            double[] canvasY = new double[_N];
            double height = canvas.ActualHeight;
            double width = canvas.ActualWidth;
            for (int i = 1; i < _M+1; i++)
            {
                _point[i,0] = (width / _M) * x[i];
            }
            for (int j = 1; j < _N+1; j++)
            {
                _point[0,j] =height- (height / _N) * y[j];
            }
            return _point;

        }

        /// <summary>
        /// 求出所在多边形内的数据数和整体数据数的比值
        /// </summary>
        /// <param name="data"></param>
        /// <param name="polygon"></param>
        /// <returns></returns>
        public static double RatioIn(double[] data, List<Point> polygon)
        {
            itRatio = 0;
            //TODO：将polygon转换成对应的坐标中的点，然后求出在其中的数据数目！！换个转换思路

            return itRatio;
        }
    }
}
