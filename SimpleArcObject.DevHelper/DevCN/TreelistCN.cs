using DevExpress.XtraTreeList.Localization;

namespace SAO.DevHelper.DevCN
{
    /// <summary>
    /// Treelist控件汉化类
    ///
    /// add by andy 20120521
    /// </summary>
    public class TreelistCN : TreeListLocalizer
    {
        public override string GetLocalizedString(TreeListStringId id)
        {
            switch (id)
            {
                case TreeListStringId.ColumnCustomizationText:
                    return "自定义显示字段";

                case TreeListStringId.MenuColumnBestFit:
                    return "自动调整本列宽度";

                case TreeListStringId.MenuColumnBestFitAllColumns:
                    return "自动调整所有列宽度";

                case TreeListStringId.MenuColumnColumnCustomization:
                    return "显示/隐藏列";

                case TreeListStringId.MenuColumnSortAscending:
                    return "升序排序";

                case TreeListStringId.MenuColumnSortDescending:
                    return "降序排序";

                default:
                    return base.GetLocalizedString(id);
            }
        }
    }
}