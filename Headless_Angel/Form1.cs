using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Headless_Angel
{
    public partial class Form1 : Form
        
    {
        CalclatorMetods MasterMetod = new CalclatorMetods();
        int Number1 = Convert.ToInt32(TextBox1.Value);
        int Number2 = Convert.ToInt32(Textbox2.Value);
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InputValue();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InputValue();

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            

        }
        bool InputValue()
        {
            bool isvalid = true;

            if (TextBox1.Value == 0)
            {
                isvalid = false;
                MessageBox.Show("کره خر اینپوت هنوز خالیه که ");
            }
            else
            {
                if (Textbox2.Value == 0)
                {
                    isvalid = false;
                    MessageBox.Show("مگه من مسخره تویم شتر ");
                }
            }
            return isvalid;

        }
    }
}
