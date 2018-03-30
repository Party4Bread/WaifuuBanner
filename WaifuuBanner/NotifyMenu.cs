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
    public partial class NotifyMenu : Form
    {
        public NotifyMenu()
        {
            InitializeComponent();
        }

        private void NotifyMenu_Load(object sender, EventArgs e)
        {
            var scrarea=Screen.PrimaryScreen.WorkingArea;
            this.Top = scrarea.Y + scrarea.Height - this.Height;
            this.Left = scrarea.X + scrarea.Width - this.Width;
        }

        private void ExitBtnClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void imgchngbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog imgOpenFileDialog = new OpenFileDialog();
            if (imgOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImageAdapter.CurrentImagePath=imgOpenFileDialog.FileName;
            }
        }

        private void opacityTrackBar_Scroll(object sender, EventArgs e)
        {
            ImageAdapter.Opacity=((TrackBar) sender).Value;
        }

        private void opacityTrackBar_ValueChanged(object sender, EventArgs e)
        {
            ImageAdapter.Opacity = ((TrackBar)sender).Value;
        }
    }
}
