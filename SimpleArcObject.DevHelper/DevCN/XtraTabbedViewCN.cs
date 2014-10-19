using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraBars.Docking2010;

namespace SAO.DevHelper.DevCN
{
    /// <summary>
    /// 多文档汉化类
    /// </summary>
    class XtraTabbedViewCN : DocumentManagerLocalizer
    {
        public override string Language
        {
            get
            {
                return "简体中文";
            }
        }
        //DevExpress.XtraBars.Docking.DockManagerResXLocalizer
        // DevExpress.XtraBars.Docking.DockManagerStringId 
        public override string GetLocalizedString(DocumentManagerStringId id)
        {
            switch (id)
            {
                case DocumentManagerStringId.CommandActivate:
                    return "激活";
                case DocumentManagerStringId.CommandArrangeIcons:
                    return "排列图标";
                case DocumentManagerStringId.CommandBack:
                    return "返回";
                case DocumentManagerStringId.CommandClose:
                    return "关闭";
                case DocumentManagerStringId.CommandCloseAll:
                    return "关闭所有";
                case DocumentManagerStringId.CommandCloseAllButPinned:
                    return "关闭所有非固定";
                case DocumentManagerStringId.CommandCloseAllButThis:
                    return "除此之外全关闭";
                case DocumentManagerStringId.CommandDock:
                    return "停靠为选项卡式文档";
                case DocumentManagerStringId.CommandExit:
                    return "退出";
                case DocumentManagerStringId.CommandFloat:
                    return "浮动";
                case DocumentManagerStringId.CommandHome:
                    return "主页";
                case DocumentManagerStringId.CommandHorizontalOrientation:
                    return "水平的";
                case DocumentManagerStringId.CommandMaximize:
                    return "最大化";
                case DocumentManagerStringId.CommandMinimizeAll:
                    return "最小化窗口";
                case DocumentManagerStringId.CommandMoveToNextDocumentGroup:
                    return "移动到下一个选项卡";
                case DocumentManagerStringId.CommandMoveToPrevDocumentGroup:
                    return "移动到上一个选项卡";
                case DocumentManagerStringId.CommandNewDocumentGroup:
                    return "新建选项卡";
                case DocumentManagerStringId.CommandNewHorizontalDocumentGroup:
                    return "水平排列选项卡";
                case DocumentManagerStringId.CommandNewVerticalDocumentGroup:
                    return "垂直排列选项卡";
                case DocumentManagerStringId.CommandRestore:
                    return "还原";
                case DocumentManagerStringId.CommandRestoreAll:
                    return "还原窗口";
                case DocumentManagerStringId.CommandTileHorizontal:
                    return "垂直平铺";
                case DocumentManagerStringId.CommandTileVertical:
                    return "水平平铺";
                case DocumentManagerStringId.CommandVerticalOrientation:
                    return "垂直的";
                case DocumentManagerStringId.LoadingIndicatorDescription:
                    return "正在加载...";
                case DocumentManagerStringId.OpenedWindowsDialogNameColumnCaption:
                    return "名称";
                case DocumentManagerStringId.OpenedWindowsDialogPathColumnCaption:
                    return "路径";
                case DocumentManagerStringId.CommandOpenedWindowsDialog:
                    return "窗口管理";
                case DocumentManagerStringId.SplashScreenCaption:
                    return "正在加载...";
                default:
                    return "...";
            }
        }
    }
}
