using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Button button1 = new Button();
            button1.Text = "Click Me";
            EventHandler someSomeFunctionPointer = new EventHandler(ExecuteMe);
            button1.Click += someSomeFunctionPointer;

            this.Controls.Add(button1);
        }

        public void ExecuteMe(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked me!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
