using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task
{

    public partial class Form2 : Form
    {
        public delegate void add_style(style style);

        public event add_style Add;
        protected virtual void OnAdd(style st)
        {
            if (Add != null)
            {
                Add(st);
            }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            style sst = new style();
            sst.font_name = comboBox1.Text;

            try
            {
                sst.FontSize = int.Parse(numericUpDown1.Value.ToString());
                // If the assignment succeeds, continue with your code
            }
            catch (ArgumentException ex)
            {
                // Handle the exception, e.g., show an error message
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (checkBox1.Checked == true)
            {
                sst.is_bold = true;
            }


            if (checkBox2.Checked == true)
            {
                sst.is_italic = true;
            }

            if (checkBox3.Checked == true)
            {
                sst.is_underline = true;
            }


            if (radioButton1.Checked == true)
            {
                sst.font_color = Color.Red;
            }
            else if (radioButton2.Checked == true)
            {
                sst.font_color = Color.Blue;
            }
            else if (radioButton3.Checked == true)
            {

                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    sst.font_color = colorDialog1.Color;
                }
            }

            OnAdd(sst);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
