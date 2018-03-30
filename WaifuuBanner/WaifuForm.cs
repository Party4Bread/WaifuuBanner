using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaifuuBanner
{
    public partial class WaifuForm : Form
    {
        public WaifuForm()
        {
            InitializeComponent();
        }

        private void WaifuForm_Load(object sender, EventArgs e)
        {
            var scrarea = Screen.PrimaryScreen.WorkingArea;
            this.Top = 0;
            this.Left = scrarea.X + scrarea.Width - this.Width;
            this.Opacity = ImageAdapter.Opacity;
            pictureBox1.ImageLocation = ImageAdapter.CurrentImagePath??"";
            this.BackColor = Color.Lime;
            this.AllowTransparency = true;
            //this.TransparencyKey = Color.Lime;
        }
    }
}
