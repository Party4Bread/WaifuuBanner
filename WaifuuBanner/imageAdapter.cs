using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaifuuBanner
{
    static class ImageAdapter
    {
        private static string currentimagepath;
        public static string CurrentImagePath
        {
            get => currentimagepath;
            set
            {
                currentimagepath = value;
                ActiveWaifuForm?.Dispose();
                ActiveWaifuForm=new WaifuForm();
                ActiveWaifuForm.Show();
            }
        }
        public static WaifuForm ActiveWaifuForm;
        public static int Opacity = 100;
    }
}
