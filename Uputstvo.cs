using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A10Blok
{
    public partial class Uputstvo : Form
    {
        public Uputstvo()
        {
            InitializeComponent();
        }

        private void Uputstvo_Load(object sender, EventArgs e)
        {
            richTextBox1.LoadFile(@"C:\Users\KLabinet 49-2\source\repos\Maja Rancic IV-1\A10Blok\A10.rtf");
        }
    }
}
