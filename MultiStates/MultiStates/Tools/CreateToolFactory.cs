using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace MultiStates.Tools
{
    

    static class CreateToolFactory
    {
        // 实例化相应绘制工具并返回
        public static Tool getDrawTool(int i,Options p)
        {
            switch (i)
            {
                case 0:
                    return new DrawLine(p);
                case 1:
                    return new DrawCircle(p);
                case 2:
                    return new DrawRectangle(p);
                case 3:
                    return new DrawEllipse(p);
                case 4:
                    return new DrawPolyline(p);
                case 5:
                    return new DrawPolygon(p,false);
                case 6:
                    return new DrawPolygon(p,true);
                case 7:
                    return new DrawRectangle(p, true);
                case 8:
                    return new DrawCircle(p, true);
                default:
                    return new DrawLine(p);
            }
            
        }
    }
}
