using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;



namespace C_14
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
            Form1.ActiveForm.Visible = false;
        }
    }
}
