using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaifuuBanner
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            NotifyIcon notifyIcon = new NotifyIcon();
            notifyIcon.Icon = Properties.Resources.MainIcon;
            notifyIcon.Click += (obj, e) =>
            {
                NotifyMenu notifyMenu = new NotifyMenu();
                notifyMenu.Show();
            };
            notifyIcon.Visible = true;
            notifyIcon.ShowBalloonTip(4000,"알림 아이콘에 있어요!",
                "하단 아이콘을 눌러서 설정할 수 있어요",ToolTipIcon.Info);
            ImageAdapter.CurrentImagePath = "";
            ImageAdapter.ActiveWaifuForm=new WaifuForm();
            ImageAdapter.ActiveWaifuForm.Show();
            Application.Run();
        }
    }
}
