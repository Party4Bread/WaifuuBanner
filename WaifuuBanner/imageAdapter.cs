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
        private static float _opacity = 1;
        public static float Opacity
        {
            get => _opacity;
            set
            {
                _opacity = value;
                ActiveWaifuForm?.ChangeOpacity();
            }
        }

        private static float _scale = 1;
        public static float Scale
        {
            get=>_scale;
            set
            {
                _scale = value;
                ActiveWaifuForm?.ChangeScale();
            }
        }
    }
}
