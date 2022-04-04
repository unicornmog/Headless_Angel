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
        CalclatorMetods x= new CalclatorMetods();

        public Form1() // Master File
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) // Lode Scrin
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e) // TextBox2
        {
            

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)// TextBox1
        {

            

        }
        bool InputValue() // Form Validation
        {
            bool isvalid = true;

            if (TextBox1.Value == 0) 
            {
                isvalid = false;
                MessageBox.Show("کره خر اینپوت هنوز خالیه که "); // message Show Error For Validation TextBox1
            }
            else
            {
                if (Textbox2.Value == 0)
                {
                    isvalid = false;
                    MessageBox.Show("مگه من مسخره تویم شتر ");// message Show Error For Validation TextBox2
                }
            }
            return isvalid;

        }

        private void PlusEvent(object sender, EventArgs e)
        {

            if (InputValue())
            {
                int sum = x.Plus((int)TextBox1.Value, (int)Textbox2.Value);
                MessageBox.Show("" + sum);
               
            }
            
        }

        private void MulteplEvent(object sender, EventArgs e)
        {
            if (InputValue())
            {
                int sum = x.Multipl((int)TextBox1.Value, (int)Textbox2.Value);
                MessageBox.Show("" + sum);

            }
        }
    }
}
