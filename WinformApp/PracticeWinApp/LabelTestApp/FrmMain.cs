using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelTestApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LblAutoSize.Text = LblManualSize.Text = string.Empty;
        }

        private void BtnPushText_Click(object sender, EventArgs e)
        {
            string sample1 = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Eum, nesciunt. Aut aperiam doloremque natus aliquid architecto, nemo culpa reprehenderit nisi voluptatum atque nulla. Odio hic recusandae magni eligendi adipisci consequatur!";
            string sample2 = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Blanditiis, inventore cum? Optio consequuntur eos veniam mollitia odit labore neque accusamus iusto, voluptates delectus praesentium ipsum, excepturi quis velit at error!";

            LblAutoSize.Text = sample1;
            LblManualSize.Text = sample2;

        }
    }
}
