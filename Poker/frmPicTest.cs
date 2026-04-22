using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poker
{
    public partial class frmPicTest : Form
    {
        public frmPicTest()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int picNum = random.Next(1, 53);
            picTest.Image =Properties.Resources.ResourceManager.GetObject($"pic{picNum}") as Image;
            lblNum.Text = picNum.ToString();
        }
    }
}
