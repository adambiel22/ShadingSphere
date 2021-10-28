using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Filling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Point a = new Point(1, 2);
            Point b = a.;
            b.X = 3;
            Debug.WriteLine(a);
            Debug.WriteLine(b);
        }

    }
}
