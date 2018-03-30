using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        public void ChangePicture()
        {
            if (File.Exists(ImageAdapter.CurrentImagePath))
            {
                pictureBox1.ImageLocation = ImageAdapter.CurrentImagePath;
                Image img = new Bitmap(ImageAdapter.CurrentImagePath);
                this.Width = pictureBox1.Width = img.Width;
                this.Height = pictureBox1.Height = img.Height;
                var scrarea = Screen.PrimaryScreen.WorkingArea;
                this.Left = scrarea.X + scrarea.Width - this.Width;
            }
        }

        public void ChangeOpacity()
        {
            this.Opacity = ImageAdapter.Opacity;
        }
        public void WaifuForm_Load(object sender, EventArgs e)
        {
            var scrarea = Screen.PrimaryScreen.WorkingArea;
            this.Top = 0;
            this.Left = scrarea.X + scrarea.Width - this.Width;
            this.BackColor = Color.Lime;
            //this.AllowTransparency = true;
            this.TransparencyKey = Color.Lime;
        }
    }
}
