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
        /// 应用程序的主入口点。
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

            ConnectionHelper.Connect(AutoCreateOption.DatabaseAndSchema);
            //Application.Run(new MainForm());
        }
    }
}
