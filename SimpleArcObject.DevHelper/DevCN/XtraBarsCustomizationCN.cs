using DevExpress.XtraBars.Customization;

namespace SAO.DevHelper.DevCN
{
    /// <summary>
    /// add by andyojx 20130325
    ///
    /// 工具栏自定义窗体汉化类
    /// </summary>
    public class XtraBarsCustomizationCN : CustomizationControl
    {
        private System.ComponentModel.Container components = null;

        public XtraBarsCustomizationCN()
        {
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tpOptions.SuspendLayout();
            this.tpCommands.SuspendLayout();
            this.tpToolbars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolBarsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbCommands)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOptionsShowFullMenus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOptions_showFullMenusAfterDelay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOptions_showTips.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOptions_ShowShortcutInTips.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.tabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbNBDlgName.Properties)).BeginInit();
            this.pnlNBDlg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbOptions_largeIcons.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOptions_MenuAnimation.Properties)).BeginInit();
            this.SuspendLayout();

            this.btClose.Text = "关闭";
            this.btResetBar.Text = "重新设置(&R)";
            this.btRenameBar.Text = "重命名(&E)";
            this.btNewBar.Text = "新建(&N)";
            this.btDeleteBar.Text = "删除(&D)";
            this.btOptions_Reset.Text = "重置惯用数据(&R)";
            this.btNBDlgCancel.Text = "取消";
            this.btNBDlgOk.Text = "确定";
            this.tpOptions.Size = new System.Drawing.Size(354, 246);
            this.tpOptions.Text = "选项(&O)";
            this.tpCommands.Text = "命令(&C)";
            this.tpToolbars.Text = "工具栏(&B)";
            this.cbOptionsShowFullMenus.Properties.Caption = "始终显示整个菜单(&N)";
            this.cbOptions_showFullMenusAfterDelay.Properties.Caption = "鼠标指针短暂停留后显示完整菜单(&U)";
            this.cbOptions_largeIcons.Properties.Caption = "大图标(&L)";
            this.cbOptions_showTips.Properties.Caption = "显示关于工具栏屏幕提示(&T)";
            this.cbOptions_ShowShortcutInTips.Properties.Caption = "在屏幕提示中显示快捷键(&H)";
            this.lbDescCaption.Text = "详细说明";
            this.lbOptions_Other.Text = "其它";
            this.lbOptions_PCaption.Text = "个性化菜单和工具栏";
            this.lbCategoriesCaption.Text = "类别:";
            this.lbCommandsCaption.Text = "命令:";
            this.lbToolbarCaption.Text = "工具栏:";
            this.lbOptions_MenuAnimation.Text = "菜单动画设置(&M):";
            this.lbNBDlgCaption.Text = "工具栏名称(&T)";
            this.lbCommands.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.lbCommands.Appearance.Options.UseBackColor = true;
            this.Name = "XtraBarsCustomizationLocalization_CN";
            this.tpOptions.ResumeLayout(false);
            this.tpCommands.ResumeLayout(false);
            this.tpToolbars.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toolBarsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbCommands)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOptionsShowFullMenus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOptions_showFullMenusAfterDelay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOptions_showTips.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOptions_ShowShortcutInTips.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.tabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbNBDlgName.Properties)).EndInit();
            this.pnlNBDlg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbOptions_largeIcons.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOptions_MenuAnimation.Properties)).EndInit();
            this.ResumeLayout(false);
        }
    }
}