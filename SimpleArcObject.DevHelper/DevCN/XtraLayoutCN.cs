using DevExpress.XtraLayout.Localization;

namespace SAO.DevHelper.DevCN
{
    public class XtraLayoutCN : LayoutLocalizer
    {
        public override string GetLocalizedString(LayoutStringId id)
        {
            switch (id)
            {
                case LayoutStringId.ResetLayoutMenuText:
                    return "重置菜单名称";

                default:
                    return base.GetLocalizedString(id);
            }
        }
    }
}