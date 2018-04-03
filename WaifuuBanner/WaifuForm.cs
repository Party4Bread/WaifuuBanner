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

        public void ChangeScale()
        {
            if (pictureBox1.Image != null)
            {
                this.Width = pictureBox1.Width = (int)(pictureBox1.Image.Width * ImageAdapter.Scale);
                this.Height = pictureBox1.Height = (int)(pictureBox1.Image.Height * ImageAdapter.Scale);
                var scrarea = Screen.PrimaryScreen.WorkingArea;
                this.Left = scrarea.X + scrarea.Width - this.Width;
            }
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
