using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TarologProject.Pages
{
    public partial class GoodByeForm : Form
    {
        public GoodByeForm()
        {
            InitializeComponent();
            new Thread(() => { Thread.Sleep(3000); Application.Exit(); }).Start();
        }
    }
}
