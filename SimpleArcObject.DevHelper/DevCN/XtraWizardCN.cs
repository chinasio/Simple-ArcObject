using DevExpress.XtraWizard.Localization;

namespace SAO.DevHelper.DevCN
{
    /// <summary>
    /// 向导控件汉化
    ///
    /// 20131127 add by lrm
    /// </summary>
    public class XtraWizardCN : WizardLocalizer
    {
        public override string GetLocalizedString(WizardStringId id)
        {
            switch (id)
            {
                case WizardStringId.CancelText:
                    return "取消";

                case WizardStringId.CaptionError:
                    return "错误";

                case WizardStringId.CompletionPageFinishText:
                    return "您已经顺利完成向导";

                case WizardStringId.CompletionPageProceedText:
                    return "单击结束关闭向导";

                case WizardStringId.CompletionPageTitleText:
                    return "您已经顺利完成向导";

                case WizardStringId.InteriorPageTitleText:
                    return "向导页标题";

                case WizardStringId.FinishText:
                    return "完成";

                case WizardStringId.NextText:
                    return "下一步";

                case WizardStringId.PreviousText:
                    return "上一步";

                case WizardStringId.HelpText:
                    return "帮助";

                case WizardStringId.PageDescriptionText:
                    return "向导页说明:帮助拥护完成子任务";

                case WizardStringId.WelcomePageProceedText:
                    return "单击下一步继续";

                case WizardStringId.WelcomePageTitleText:
                    return "欢迎使用向导";

                case WizardStringId.WizardTitle:
                    return "向导标题";

                default:
                    return base.GetLocalizedString(id);
            }
        }
    }
}