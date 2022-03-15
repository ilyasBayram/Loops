using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        #region while loop
        private void button1_Click(object sender, EventArgs e)
        {
            //it clars the listbox for next click.
            //otherwise values will be written with every click.
            listBox1.Items.Clear();
           
            int i = 1;

            while (i<10)
            {
                listBox1.Items.Add(i);
                i++;
            }

        }
        #endregion

        #region do while loop
        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            int i = 1;

            do
            {
                listBox2.Items.Add(i);
                i++;
            } while (i<10);

            
        }
        #endregion

        #region for loop
        private void button3_Click(object sender, EventArgs e)
        {
            
            listBox3.Items.Clear();

            for (int i = 0; i < 10; i++)
            {
                listBox3.Items.Add(i);
            }

            
        }
        #endregion
    }
}
