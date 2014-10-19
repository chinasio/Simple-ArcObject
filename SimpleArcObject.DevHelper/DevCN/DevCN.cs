using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SAO.DevHelper.DevCN
{

    public class DevCN
    {
        /// <summary>
        /// Dev控件汉化
        /// </summary>
        public static void Init()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("zh-CN");
            #region 旧的汉化模式，如果需要回复，需要将当前文件夹下CN结尾的类重新添加进来进行编译
            DevExpress.XtraEditors.Controls.Localizer.Active = new SAO.DevHelper.DevCN.LocalizerCN();
            DevExpress.XtraReports.Localization.ReportLocalizer.Active = new SAO.DevHelper.DevCN.XtraReportsCN();
            DevExpress.XtraPrinting.Localization.PreviewLocalizer.Active = new SAO.DevHelper.DevCN.XtraPrintingCN();
            DevExpress.XtraGrid.Localization.GridLocalizer.Active = new SAO.DevHelper.DevCN.GridControlCN();
            DevExpress.XtraTreeList.Localization.TreeListLocalizer.Active = new SAO.DevHelper.DevCN.TreelistCN();
            DevExpress.XtraBars.Localization.BarLocalizer.Active = new SAO.DevHelper.DevCN.XtraBarCN();
            DevExpress.XtraBars.Localization.BarLocalizer.Active.Customization = new SAO.DevHelper.DevCN.XtraBarsCustomizationCN();
            DevExpress.XtraLayout.Localization.LayoutLocalizer.Active = new SAO.DevHelper.DevCN.XtraLayoutCN();
            DevExpress.XtraNavBar.NavBarLocalizer.Active = new SAO.DevHelper.DevCN.XtraNavBarCN();
            DevExpress.XtraBars.Docking2010.DocumentManagerLocalizer.Active = new SAO.DevHelper.DevCN.XtraTabbedViewCN();
            DevExpress.XtraWizard.Localization.WizardLocalizer.Active = new SAO.DevHelper.DevCN.XtraWizardCN();
            #endregion
        }
    }
}
