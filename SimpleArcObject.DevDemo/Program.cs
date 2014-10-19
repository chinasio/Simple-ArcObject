using SimpleArcObject.Framework.Manager;
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
            ESRI.ArcGIS.RuntimeManager.Bind(ESRI.ArcGIS.ProductCode.EngineOrDesktop);
            ILogger pLogger = LogManager.GetLogger("Main");
            pLogger.Error("测试字符");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
