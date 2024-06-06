namespace task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form2 form2 = new Form2();
            form2.Show();
            form2.Add += Add_on;
            
        }
        public void Add_on(style sat)
        {
            

            textBox1.Font = new Font(sat.font_name,sat.FontSize);
            textBox1.ForeColor = sat.font_color;
           
            FontStyle combinedStyle = FontStyle.Regular; // Initialize with the default style

            if (sat.is_bold)
            {
                combinedStyle |= FontStyle.Bold; // Add Bold to the style
            }

            if (sat.is_italic)
            {
                combinedStyle |= FontStyle.Italic; // Add Italic to the style
            }

            if (sat.is_underline)
            {
                combinedStyle |= FontStyle.Underline; // Add Underline to the style
            }

            textBox1.Font = new Font(textBox1.Font, combinedStyle);
        }
    }
}
