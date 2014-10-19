using DevExpress.XtraNavBar;

namespace SAO.DevHelper.DevCN
{
    public class XtraNavBarCN : NavBarLocalizer
    {
        public override string GetLocalizedString(NavBarStringId id)
        {
            switch (id)
            {
                case NavBarStringId.NavPaneMenuAddRemoveButtons:
                    return "添加删除按钮";

                case NavBarStringId.NavPaneOptionsFormDescription:
                    return "浮动窗体";

                default:
                    return base.GetLocalizedString(id);
            }
        }
    }
}