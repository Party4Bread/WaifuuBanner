using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaifuuBanner
{
    static class ImageAdapter
    {
        private static string _currentimagepath;
        public static string CurrentImagePath
        {
            get => _currentimagepath;
            set
            {
                _currentimagepath = value;
                ActiveWaifuForm?.ChangePicture();
            }
        }
        public static WaifuForm ActiveWaifuForm;
        private static int _opacity = 100;
        public static int Opacity
        {
            get => _opacity;
            set
            {
                _opacity = value;
                ActiveWaifuForm?.ChangeOpacity();
            }
        }
    }
}
