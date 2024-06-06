using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    public class style
    {
        public string font_name { get; set; }

         int font_size;
        public int FontSize
        {
            get { return font_size; }
            set
            {
                if (value > 0)
                {
                    font_size = value;
                }
                else
                {
                    // You can handle the case when the value is not greater than 0
                    // For example, you can throw an exception or set a default value.
                    //throw new ArgumentException("Font size must be greater than 0.");
                    font_size = 1;
                }
            }
        }
        public Color font_color { get; set;}
        public bool is_bold { get; set; }
        public bool is_italic { get; set; }
        public bool is_underline { get; set; }


    }
}
