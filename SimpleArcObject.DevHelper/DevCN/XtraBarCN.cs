using DevExpress.XtraBars.Localization;

namespace SAO.DevHelper.DevCN
{
    /// <summary>
    /// 工具栏控件汉化类
    ///
    /// add by andy 20120521
    /// </summary>
    public class XtraBarCN : BarLocalizer
    {
        //DevExpress.XtraBars.Docking.DockManagerResXLocalizer
        //DevExpress.XtraBars.Docking.DockManagerStringId.p
        public override string GetLocalizedString(BarString id)
        {
            if (id != BarString.SkinCaptions)
            {
                switch (id)
                {
                    case BarString.AddOrRemove:
                        return "添加或移除按钮";

                    case BarString.BarAllItems:
                        return "(所有项)";

                    case BarString.BarUnassignedItems:
                        return "(未设定项)";

                    case BarString.CloseButton:
                        return "关闭";

                    case BarString.CustomizeButton:
                        return "自定义(&C)...";

                    case BarString.CustomizeWindowCaption:
                        return "自定义";

                    case BarString.HelpButton:
                        return "帮助";

                    case BarString.MaximizeButton:
                        return "最大化";

                    case BarString.MenuAnimationFade:
                        return "减弱";

                    case BarString.MenuAnimationNone:
                        return "无";

                    case BarString.MenuAnimationRandom:
                        return "任意";

                    case BarString.MenuAnimationSlide:
                        return "滑动";

                    case BarString.MenuAnimationSystem:
                        return "（系统默认值）";

                    case BarString.MenuAnimationUnfold:
                        return "展开";

                    case BarString.MinimizeButton:
                        return "最小化";

                    case BarString.NewMenuName:
                        return "主菜单";

                    case BarString.NewStatusBarName:
                        return "状态栏";

                    case BarString.NewToolbarCaption:
                        return "新建工具栏";

                    case BarString.NewToolbarCustomNameFormat:
                        return "自定义工具栏";

                    case BarString.NewToolbarName:
                        return "工具";

                    case BarString.None:
                        return string.Empty;

                    case BarString.PopupMenuEditor:
                        return "弹出菜单编辑器";

                    case BarString.RenameToolbarCaption:
                        return "重命名工具栏";

                    case BarString.ResetBar:
                        return "确定要对 '{0}' 工具栏所做的改动进行重置吗？";

                    case BarString.ResetBarCaption:
                        return "自定义";

                    case BarString.ResetButton:
                        return "重新设置工具栏(&R)";

                    case BarString.RestoreButton:
                        return "恢复工具栏";

                    case BarString.RibbonAllPages:
                        return "(所有页)";

                    case BarString.RibbonGalleryFilter:
                        return "所有组";

                    case BarString.RibbonGalleryFilterNone:
                        return "无";

                    case BarString.RibbonToolbarAbove:
                        return "在功能区上方显示快速访问工具栏";

                    case BarString.RibbonToolbarAdd:
                        return "添加到快速访问工具栏";

                    case BarString.RibbonToolbarBelow:
                        return "在功能区下方显示快速访问工具栏";

                    case BarString.RibbonToolbarMinimizeRibbon:
                        return "最小化功能区";

                    case BarString.RibbonToolbarRemove:
                        return "从快速访问工具栏中删除";

                    case BarString.RibbonUnassignedPages:
                        return "(未设定页)";

                    case BarString.ToolBarMenu:
                        return "重设(&R)$删除(&D)$!命名(&N)$!标准(&L)$总使用文字(&T)$在菜单中只用文字(&O)$图像与文本(&A)$!开始一组(&G)$常用的(&M)";

                    case BarString.ToolbarNameCaption:
                        return "工具栏名称(&T):";

                    case BarString.SkinsBonus:
                        return "扩展皮肤";

                    case BarString.SkinsMain:
                        return "默认皮肤";

                    case BarString.SkinsOffice:
                        return "Office系列皮肤";

                    case BarString.SkinsTheme:
                        return "主题皮肤";

                    default:
                        break;
                }
            }
            else
            {
                var defaultSkinCaptions = base.GetLocalizedString(id);
                var newSkinCaptions = defaultSkinCaptions
                    .Replace("|DevExpress Style|", "|默认风格|")
                    .Replace("|Caramel|", "|焦糖风格|")
                    .Replace("|Money Twins|", "|浅蓝天空|")
                    .Replace("|DevExpress Dark Style|", "|深黑夜空|")
                    .Replace("|iMaginary|", "|虚幻风格|")
                    .Replace("|Lilian|", "|百合风格|")
                    .Replace("|Black|", "|黑色经典|")
                    .Replace("|Blue|", "|蓝色经典|")
                    .Replace("|Office 2010 Blue|", "|Office 2010 蓝色|")
                    .Replace("|Office 2010 Black|", "|Office 2010 黑色|")
                    .Replace("|Office 2010 Silver|", "|Office 2010 银色|")
                    .Replace("|Office 2007 Blue|", "|Office 2007 蓝色|")
                    .Replace("|Office 2007 Black|", "|Office 2007 黑色|")
                    .Replace("|Office 2007 Silver|", "|Office 2007 银色|")
                    .Replace("|Office 2007 Green|", "|Office 2007 绿色|")
                    .Replace("|Seven|", "|Win7 蓝色|")
                    .Replace("|Seven Classic|", "|Win7 经典|")
                    .Replace("|Darkroom|", "|暗室风格|")
                    .Replace("|McSkin|", "|苹果皮肤|")
                    .Replace("|Sharp|", "|锐利风格|")
                    .Replace("|Sharp Plus|", "|新锐风格|")
                    .Replace("|Foggy|", "|灰雾风格|")
                    .Replace("|Dark Side|", "|黑色光泽|")
                    .Replace("|Xmas (Blue)|", "|温暖冬日|")
                    .Replace("|Springtime|", "|绿色春天|")
                    .Replace("|Summer|", "|清凉夏日|")
                    .Replace("|Pumpkin|", "|万圣节|")
                    .Replace("|Valentine|", "|可爱粉色|")
                    .Replace("|Stardust|", "|蓝色光泽|")
                    .Replace("|Coffee|", "|咖啡风格|")
                    .Replace("|Glass Oceans|", "|玻璃海洋|")
                    .Replace("|High Contrast|", "|高对比度|")
                    .Replace("|Liquid Sky|", "|液态天空|")
                    .Replace("|London Liquid Sky|", "|伦敦天空|")
                    .Replace("|The Asphalt World|", "|柏油风格|")
                    .Replace("|Blueprint|", "|蓝色素描|")
                    .Replace("|Whiteprint|", "|白色素描|")
                    .Replace("|VS2010|", "|VS2010|")
                    .Replace("|Metropolis|", "|Win8 白色|")
                    .Replace("|Metropolis Dark|", "|Win8 深黑|");
                return newSkinCaptions;
            }
            return string.Empty;
        }
    }
}