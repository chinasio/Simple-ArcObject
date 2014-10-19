using SAO.DevHelper.DevCN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SimpleArcObject.DevDemo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //绑定arcengine许可
            ESRI.ArcGIS.RuntimeManager.Bind(ESRI.ArcGIS.ProductCode.EngineOrDesktop);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //注册皮肤
            DevExpress.UserSkins.BonusSkins.Register();
            //标题样式取消透明效果
            DevExpress.Skins.SkinManager.EnableFormSkins();
            //默认皮肤
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Money Twins");
            //汉化
            DevCN.Init();


            Application.Run(new MainForm());
        }
    }
}
