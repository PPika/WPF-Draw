using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Use;

namespace Canvas
{
    public static class temp
    {
        /// <summary>
        /// 将对应的Heatmap的值转换成canvas的实际坐标，
        /// result[i,0]和result[0,j]
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public static double[,] TransXY(List<int> x, List<int> y,double width , double height)
        {
            
            int _M = x.Count;
            int _N = y.Count;
            double[,] _point = new double[_M+1,_N+1];       
            double[] canvasX = new double[_M];
            double[] canvasY = new double[_N];
            for (int i = 1; i < _M+1; i++)
            {
                _point[i,0] = (width / _M) * x[i];
            }
            for (int j = 1; j < _N+1; j++)
            {
                _point[0,j] =width- (width / _N) * y[j];
            }
            return _point;

        }

        public static int InIt(double[,] spot,List<Point> polygon)
        {
            int result=0;
            double[,] _spot = spot;
            List<Point> _point = polygon;
            


            return result;
        }

    }
}
