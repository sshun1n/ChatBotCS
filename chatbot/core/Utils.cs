using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chatbot.core
{
    public static class Utils
    {
        public static int GetTextHeight(Label label)
        {
            using (Graphics g = label.CreateGraphics())
            {
                SizeF size = g.MeasureString(label.Text, label.Font, 270);
                return (int)Math.Ceiling(size.Height);
            }
        }
    }
}
