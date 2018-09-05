using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chashproperties
{
    public interface Shape
    {
        string GetShape();
    }
    public interface Color
    {
        string GetColor();
    }
    public class Draw : Shape,Color
    {
        public string shape, clr;
        
        public string Shape
        {
            set
            {
                shape = value;
            }
        }
        public string Color
        {
            set
            {
                clr = value;
            }
        }
        public string GetShape()
        {
            return shape;
        }
        public string GetColor()
        {
            return clr;
        }
    }
    
}
