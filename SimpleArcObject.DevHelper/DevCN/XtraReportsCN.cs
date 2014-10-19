using DevExpress.XtraReports.Localization;

namespace SAO.DevHelper.DevCN
{
    /// <summary>
    /// 报表控件汉化类
    ///
    /// add by andy 20120521
    /// 20140327 mod by lrm 增加了导出及输出图片的描述
    /// </summary>
    public class XtraReportsCN : ReportLocalizer
    {
        public override string Language
        {
            get
            {
                return "简体中文";
            }
        }

        public override string GetLocalizedString(ReportStringId id)
        {
            switch (id)
            {
                case ReportStringId.BandDsg_QuantityPerPage: return "一个带区/每页";//one band per page
                case ReportStringId.BandDsg_QuantityPerReport: return "一个带区/每页";//one band per report
                case ReportStringId.BCForm_Lbl_Binding: return "绑定";//Binding
                case ReportStringId.BCForm_Lbl_Property: return "属性";//Property
                case ReportStringId.CatAppearance: return "外观";//Appearance
                case ReportStringId.CatBehavior: return "行为";//Behavior
                case ReportStringId.CatData: return "数据";//Data
                case ReportStringId.CatDesign: return "设计";//Design
                case ReportStringId.CatLayout: return "布局";//Layout
                case ReportStringId.CatNavigation: return "导航";//Navigation
                case ReportStringId.CatPageSettings: return "页面设置";//Page Settings
                case ReportStringId.CatParameters: return "参数";//Parameters
                case ReportStringId.CatPrinting: return "打印";//Printing
                case ReportStringId.CatStructure: return "结构";//Structure
                case ReportStringId.CatUserDesigner: return "用户设计器";//User Designer
                // case ReportStringId.Cmd_AddCalculatedField: return "增加计算字段";//Add Calculated Field
                // case ReportStringId.Cmd_AddParameter: return "增加参数";//Add Parameter
                case ReportStringId.Cmd_AlignToGrid: return "对齐表格";//Align To &Grid
                case ReportStringId.Cmd_BandMoveDown: return "上移";//Move Down
                case ReportStringId.Cmd_BandMoveUp: return "下移动";//Move Up
                case ReportStringId.Cmd_BottomMargin: return "底部边距";//BottomMargin
                case ReportStringId.Cmd_BringToFront: return "置于顶层";//&Bring To Front
                // case ReportStringId.Cmd_ClearCalculatedFields: return "删除所有计算字段";//Remove All Calculated Fields
                // case ReportStringId.Cmd_ClearParameters: return "删除所有参数";//Remove All Parameters
                case ReportStringId.Cmd_Copy: return "复制";//Cop&y
                case ReportStringId.Cmd_Cut: return "剪切";//Cu&t
                case ReportStringId.Cmd_Delete: return "删除";//&Delete
                // case ReportStringId.Cmd_DeleteCalculatedField: return "删除";//Delete
                //  case ReportStringId.Cmd_DeleteParameter: return "删除";//Delete
                case ReportStringId.Cmd_Detail: return "详细内容";//Detail
                case ReportStringId.Cmd_DetailReport: return "详细报表";//DetailReport
                // case ReportStringId.Cmd_EditCalculatedFields: return "编辑计算字段...";//Edit Calculated Fields...
                //  case ReportStringId.Cmd_EditExpression: return "编辑表达式...";//Edit Expression...
                //  case ReportStringId.Cmd_EditParameters: return "编辑参数...";//Edit Parameters...
                case ReportStringId.Cmd_GroupFooter: return "分组尾";//GroupFooter
                case ReportStringId.Cmd_GroupHeader: return "分组头";//GroupHeader
                case ReportStringId.Cmd_InsertBand: return "插入带区";//Insert &Band
                case ReportStringId.Cmd_InsertDetailReport: return "插入详细的报表";//Insert Detail Report
                case ReportStringId.Cmd_InsertUnboundDetailReport: return "未绑定的";//Unbound
                case ReportStringId.Cmd_PageFooter: return "页脚";//PageFooter
                case ReportStringId.Cmd_PageHeader: return "页眉";//PageHeader
                case ReportStringId.Cmd_Paste: return "粘贴";//&Paste
                case ReportStringId.Cmd_Properties: return "属性";//P&roperties
                case ReportStringId.Cmd_ReportFooter: return "报表尾";//ReportFooter
                case ReportStringId.Cmd_ReportHeader: return "报表头";//ReportHeader
                case ReportStringId.Cmd_RtfClear: return "清除";//Clear
                case ReportStringId.Cmd_RtfLoad: return "载入文件...";//Load File...
                case ReportStringId.Cmd_SendToBack: return "置于底层";//&Send To Back
                case ReportStringId.Cmd_TableDelete: return "删除表";//De&lete
                case ReportStringId.Cmd_TableDeleteCell: return "删除单元格";//Ce&ll
                case ReportStringId.Cmd_TableDeleteColumn: return "删除列";//&Column
                case ReportStringId.Cmd_TableDeleteRow: return "删除行";//&Row
                case ReportStringId.Cmd_TableInsert: return "插入";//&Insert
                case ReportStringId.Cmd_TableInsertCell: return "插入单元格";//&Cell
                case ReportStringId.Cmd_TableInsertColumnToLeft: return "向左插入一列";//Column To &Left
                case ReportStringId.Cmd_TableInsertColumnToRight: return "向右插入一列";//Column To &Right
                case ReportStringId.Cmd_TableInsertRowAbove: return "向上插入一行";//Row &Above
                case ReportStringId.Cmd_TableInsertRowBelow: return "向下插入一行";//Row &Below
                case ReportStringId.Cmd_TopMargin: return "书眉";//TopMargin
                case ReportStringId.Cmd_ViewCode: return "查看代码";//View &Code
                case ReportStringId.DesignerStatus_Height: return "高度";//Height
                case ReportStringId.DesignerStatus_Location: return "位置";//Loc
                case ReportStringId.DesignerStatus_Size: return "大小";//Size
                case ReportStringId.Dlg_SaveFile_Title: return "保存;//{0};//";//Save ;//{0};//
                case ReportStringId.FRSForm_Caption: return "格式设置规则表编辑器";//Formatting Rule Sheet Editor
                case ReportStringId.FRSForm_Msg_MoreThanOneRule: return "您选择了多个格式设置规则";//You selected more than one formatting rule
                case ReportStringId.FRSForm_Msg_NoRuleSelected: return "不选择任何格式设置规则";//No formatting rules are selected
                case ReportStringId.FRSForm_TTip_AddRule: return "添加格式设置规则";//Add a formatting rule
                case ReportStringId.FRSForm_TTip_ClearRules: return "明确的格式设置规则";//Clear formatting rules
                case ReportStringId.FRSForm_TTip_PurgeRules: return "删除未使用的格式设置规则";//Delete unused formatting rules
                case ReportStringId.FRSForm_TTip_RemoveRule: return "删除格式设置规则";//Remove a formatting rule
                //case ReportStringId.FSForm_Btn_Cancel: return "取消";//Cancel
                //case ReportStringId.FSForm_Btn_Delete: return "删除";//Delete
                //case ReportStringId.FSForm_Btn_Ok: return "确定";//OK
                //case ReportStringId.FSForm_Cat_Currency: return "货币";//Currency
                //case ReportStringId.FSForm_Cat_DateTime: return "日期时间";//DateTime
                //case ReportStringId.FSForm_Cat_General: return "一般";//General
                //case ReportStringId.FSForm_Cat_Int32: return "整数";//Int32
                //case ReportStringId.FSForm_Cat_Number: return "数字";//Number
                //case ReportStringId.FSForm_Cat_Percent: return "百分比";//Percent
                //case ReportStringId.FSForm_Cat_Special: return "特殊";//Special
                //case ReportStringId.FSForm_GrBox_Sample: return "示例";//Sample
                //case ReportStringId.FSForm_Lbl_Category: return "种类";//Category
                //case ReportStringId.FSForm_Lbl_CustomGeneral: return "通用格式没有具体的数字格式";//General format has no specific number format
                //case ReportStringId.FSForm_Lbl_Prefix: return "前缀:";//Prefix:
                //case ReportStringId.FSForm_Lbl_Suffix: return "后缀:";//Suffix:
                //case ReportStringId.FSForm_Msg_BadSymbol: return "错误: 非法符号";//Error: Illegal symbol(s)
                //case ReportStringId.FSForm_Tab_Custom: return "自定义";//Custom
                //case ReportStringId.FSForm_Tab_StandardTypes: return "标准类型";//Standard Types
                //case ReportStringId.FSForm_Text: return "格式化字符串编辑器";//FormatString Editor
                case ReportStringId.GroupSort_AddGroup: return "新增群组";//Add a Group
                case ReportStringId.GroupSort_AddSort: return "新增排序";//Add a Sort
                case ReportStringId.GroupSort_Delete: return "删除";//Delete
                case ReportStringId.GroupSort_MoveDown: return "上移";//Move Down
                case ReportStringId.GroupSort_MoveUp: return "下移";//Move Up
                case ReportStringId.Msg_Caption: return "XtraReports";//XtraReports
                //case ReportStringId.Msg_ContainsIllegalSymbols: return "输入包含非法字符的格式化字符串.";//Input format string contains illegal symbol(s).
                case ReportStringId.Msg_CreateReportInstance: return "当前编辑的报表与你尝试打开的报表类型不同。 <br/>你想打开已经选中的报表吗？";//The report currently being edited is of a different type than the one you are trying to open.  Do you want to open the selected report anyway?
                case ReportStringId.Msg_CreateSomeInstance: return "在一个窗体上不能创建两个类实例";//Can;//t create two instances of a class on a form
                case ReportStringId.Msg_CyclicBookmarks: return "报表中有循环书签。";//There are cyclic bookmarks in the report.
                case ReportStringId.Msg_DontSupportMulticolumn: return "详细报表不支持多列。";//Detail reports don;//t support multicolumn.
                case ReportStringId.Msg_ErrorTitle: return "错误";//Error
                case ReportStringId.Msg_FileContentCorrupted: return "不能载入报表的布局设计。该文件可能已经损坏或者包含错误信息。";//Can;//t load the report;//s layout. The file is possibly corrupted or contains incorrect information.
                case ReportStringId.Msg_FileCorrupted: return "不能载入报表。该文件可能被损坏或者报表的部件已经丢失。";//Can;//t load the report. The file is possibly corrupted or report;//s assembly is missing.
                case ReportStringId.Msg_FileNotFound: return "文件找不到。";//File not found.
                case ReportStringId.Msg_FillDataError: return "在组装数据源的时候发生错误。程序抛出以下异常:";//Error when trying to populate the datasource. The following exception was thrown:
                case ReportStringId.Msg_GroupSortNoDataSource: return "若要添加新的分组或排序级别，第一次报告提供的数据源。";//To add a new grouping or sorting level, first provide a data source for the report.
                case ReportStringId.Msg_GroupSortWarning: return "组页眉或页脚，您想要删除不是空的。是否要删除这个乐队随其控件吗？";//The group header or footer you want to delete is not empty. Do you want to delete this band along with its controls?
                case ReportStringId.Msg_IncorrectArgument: return "错误的参数值";//Incorrect argument;//s value
                case ReportStringId.Msg_IncorrectBandType: return "错误的带区类型";//Incorrect band type
                case ReportStringId.Msg_IncorrectPadding: return "输入值必须等于或大于0.";//The padding should be greater than or equal to 0.
                case ReportStringId.Msg_InvalidCondition: return "条件必须是布尔值 ！";//The condition must be Boolean!
                case ReportStringId.Msg_InvalidExpression: return "指定的表达式包含非法字符(行 {0}, 列 {1}).";//The specified expression contains invalid symbols (line {0}, character {1}).
                case ReportStringId.Msg_InvalidMethodCall: return "对象的当前状态使得方法调用失败。";//This method call is invalid for the object;//s current state
                case ReportStringId.Msg_InvalidReportSource: return "不能作为当前报表的子报表";//Can not be set to a descendant of the current report
                //case ReportStringId.Msg_InvPropName: return "无效的属性名称";//Invalid property name
                case ReportStringId.Msg_LargeText: return "文本内容太大。";//Text is too large.
                case ReportStringId.Msg_NotEnoughMemoryToPaint: return "没有足够的内存来绘制。缩放级别将被重置。";//Not enough memory to paint. Zoom level will be reset.
                case ReportStringId.Msg_ReportImporting: return "正在载如报表布局.请等待...";//Importing a report layout. Please, wait...
                case ReportStringId.Msg_ScriptCodeIsNotCorrect: return "输入的代码不正确";//Entered code is not correct
                case ReportStringId.Msg_ScriptError: return "脚本中的错误如下:  {0}";//There are following errors in script(s):  {0}
                case ReportStringId.Msg_ScriptExecutionError: return "在程序{0}中的脚本执行时发生错误:  {1}  Procedure {0} 已经执行, 它不会被再调用。";//The following error occurred when the script in procedure {0}:   {1}  Procedure {0} was executed, it will not be called again.
                case ReportStringId.Msg_ScriptingPermissionErrorMessage: return "你没有足够的权限来执行报表中的这段脚本。    具体细节:    {0}";//You don;//t have sufficient permission to execute the scripts in this report.    Details:    {0}
                case ReportStringId.Msg_SerializationErrorTitle: return "错误";//Serialization Error
                case ReportStringId.Msg_ShapeRotationToolTip: return "使用Ctrl和鼠标左键来旋转形状";//Use Ctrl with the left mouse button to rotate the shape
                case ReportStringId.Msg_WarningControlsAreOutOfMargin: return "打印通知: 以下控件超出右页边距, 这将导致额外的页面被打印 - {0}.";//Printing warning: The following controls are outside the right page margin, and this will cause extra pages to be printed - {0}.
                case ReportStringId.Msg_WarningControlsAreOverlapped: return "输出通知: 以下空间出现重叠并且可能导致输出到HTML、XLS、和RTF不正确 - {0}.";//Export warning: The following controls are overlapped and may be exported to HTML, RTF, XLS, XLSX, CSV and Text incorrectly - {0}.
                case ReportStringId.Msg_WarningFontNameCantBeEmpty: return "字体名称不能为空。";//The Font name can;//t be empty.
                case ReportStringId.Msg_WarningRemoveCalculatedFields: return "该操作将从所有数据表中删除所有计算字段。您是否继续?";//This operation will remove all calculated fields from all data tables. Do you wish to proceed?
                case ReportStringId.Msg_WarningRemoveParameters: return "该操作将删除所有参数.您是否继续?";//This operation will remove all parameters. Do you wish to proceed?
                case ReportStringId.Msg_WarningUnsavedReports: return "印刷警告： 保存以下报表预览用最近的更改应用-{0} 的子报表。";//Printing warning: Save the following reports to preview subreports with recent changes applied - {0}.
                case ReportStringId.Msg_WrongReportClassName: return "在逆序列化过程中发生错误－可能由于错误的报表类名";//An error occurred during deserialization - possible wrong report class name
                case ReportStringId.MultiColumnDesignMsg1: return "重复列的间距";//Space for repeating columns.
                case ReportStringId.MultiColumnDesignMsg2: return "放置于此的控件不能正确打印";//Controls placed here will be printed incorrectly.
                case ReportStringId.PanelDesignMsg: return "请在这里放置控件以便于拼装";//Place controls here to keep them together
                //case ReportStringId.Parameter_Type_Boolean: return "Boolean";//Boolean
                //case ReportStringId.Parameter_Type_DateTime: return "DateTime";//DateTime
                //case ReportStringId.Parameter_Type_Decimal: return "Decimal";//Decimal
                //case ReportStringId.Parameter_Type_Double: return "Double";//Double
                //case ReportStringId.Parameter_Type_Float: return "Float";//Float
                //case ReportStringId.Parameter_Type_Int16: return "Int16";//Int16
                //case ReportStringId.Parameter_Type_Int32: return "Int32";//Int32
                //case ReportStringId.Parameter_Type_String: return "String";//String
                case ReportStringId.PivotGridForm_GroupMain_Caption: return "主要的";//Main
                case ReportStringId.PivotGridForm_GroupMain_Description: return "重要设置(字段, 布局).";//Main settings(Fields, Layout).
                case ReportStringId.PivotGridForm_GroupPrinting_Caption: return "打印";//Printing
                case ReportStringId.PivotGridForm_GroupPrinting_Description: return "当前XRPivotGrid打印选项处理.";//Printing option management for the current XRPivotGrid.
                case ReportStringId.PivotGridForm_ItemAppearances_Caption: return "外观";//Appearances
                case ReportStringId.PivotGridForm_ItemAppearances_Description: return "调整当前XRPivotGrid的打印外观.";//Adjust the print appearances of the current XRPivotGrid.
                case ReportStringId.PivotGridForm_ItemFields_Caption: return "字段";//Fields
                case ReportStringId.PivotGridForm_ItemFields_Description: return "处理字段.";//Manage fields.
                case ReportStringId.PivotGridForm_ItemLayout_Caption: return "布局";//Layout
                case ReportStringId.PivotGridForm_ItemLayout_Description: return "用户自定义当前XRPivotGrid的布局并预览数据.";//Customize the current XRPivotGrid;//s layout and preview its data.
                case ReportStringId.PivotGridForm_ItemSettings_Caption: return "打印设置";//Printing Settings
                case ReportStringId.PivotGridForm_ItemSettings_Description: return "调整当前XRPivotGrid的打印设置.";//Adjust the printing settings for the current XRPivotGrid.
                case ReportStringId.PivotGridFrame_Appearances_DescriptionText: return "选择一个或多个外观对象来自定义可见元素对应打印外观.";//Select one or more of the Appearance objects to customize the printing appearances of the corresponding visual elements.
                case ReportStringId.PivotGridFrame_Fields_ColumnsText: return "XRPivotGrid字段";//XRPivotGrid Fields
                case ReportStringId.PivotGridFrame_Fields_DescriptionText1: return "你可以添加和删除XRPivotGrid字段并修改其设置.";//You can add and delete XRPivotGrid fields and modify their settings.
                case ReportStringId.PivotGridFrame_Fields_DescriptionText2: return "选择并拖放字段到PivotGrid字段面板来创建PivotGrid字段.";//Select and drag field to the PivotGrid fields panel to create PivotGrid field.
                case ReportStringId.PivotGridFrame_Layouts_DescriptionText: return "修改XRPivotGrid的布局(排序设置,字段排列)并单击应用按钮来应用对当前XRPivotGrid的修改.你也可以保存布局到XML文件中(这使得其可以在设计时和运行时下加载并应用到其他视图).";//Modify the XRPivotGrid;//s layout (sorting settings, field arrangement) and click the Apply button to apply the modifications to the current XRPivotGrid. You can also save the layout to an XML file (this can be loaded and applied to other views at design time and runtime).
                case ReportStringId.PivotGridFrame_Layouts_SelectorCaption1: return "隐藏字段选择器";//Hide fields &selector
                case ReportStringId.PivotGridFrame_Layouts_SelectorCaption2: return "显示字段选择器";//Show fields &selector
                //case ReportStringId.PropGrid_TTip_Alphabetical: return "按字母顺序排列";//Alphabetical
                //case ReportStringId.PropGrid_TTip_Categorized: return "分类";//Categorized
                case ReportStringId.RepTabCtl_Designer: return "设计视图";//Designer
                case ReportStringId.RepTabCtl_HtmlView: return "HTML视图";//HTML View
                case ReportStringId.RepTabCtl_Preview: return "预览";//Preview
                case ReportStringId.RepTabCtl_ReportStatus: return "{0} {{PaperKind: {1}}}";//{0} {{ PaperKind: {1} }}
                case ReportStringId.RepTabCtl_Scripts: return "脚本";//Scripts
                case ReportStringId.RibbonXRDesign_AlignBottom_Caption: return "底部对齐";//Align Bottoms
                case ReportStringId.RibbonXRDesign_AlignBottom_STipContent: return "底部对齐所选控件";//Align the bottoms of the selected controls.
                case ReportStringId.RibbonXRDesign_AlignBottom_STipTitle: return "底部对齐";//Align Bottoms
                case ReportStringId.RibbonXRDesign_AlignHorizontalCenters_Caption: return "中间对齐";//Align Middles
                case ReportStringId.RibbonXRDesign_AlignHorizontalCenters_STipContent: return "沿水平方向中间对齐所选控件";//Align the centers of the selected controls horizontally.
                case ReportStringId.RibbonXRDesign_AlignHorizontalCenters_STipTitle: return "中间对齐";//Align Middles
                case ReportStringId.RibbonXRDesign_AlignLeft_Caption: return "左对齐";//Align Lefts
                case ReportStringId.RibbonXRDesign_AlignLeft_STipContent: return "左对齐所选控件";//Left align the selected controls.
                case ReportStringId.RibbonXRDesign_AlignLeft_STipTitle: return "左对齐";//Align Lefts
                case ReportStringId.RibbonXRDesign_AlignRight_Caption: return "右对齐";//Align Rights
                case ReportStringId.RibbonXRDesign_AlignRight_STipContent: return "右对齐所选控件";//Right align the selected controls.
                case ReportStringId.RibbonXRDesign_AlignRight_STipTitle: return "右对齐";//Align Rights
                case ReportStringId.RibbonXRDesign_AlignToGrid_Caption: return "网格对齐";//Align to Grid
                case ReportStringId.RibbonXRDesign_AlignToGrid_STipContent: return "网格对齐所选控件位置";//Align the positions of the selected controls to the grid.
                case ReportStringId.RibbonXRDesign_AlignToGrid_STipTitle: return "网格对齐";//Align to Grid
                case ReportStringId.RibbonXRDesign_AlignTop_Caption: return "顶部对齐";//Align Tops
                case ReportStringId.RibbonXRDesign_AlignTop_STipContent: return "顶部对齐所选控件";//Align the tops of the selected controls.
                case ReportStringId.RibbonXRDesign_AlignTop_STipTitle: return "顶部对齐";//Align Tops
                case ReportStringId.RibbonXRDesign_AlignVerticalCenters_Caption: return "居中对齐";//Align Centers
                case ReportStringId.RibbonXRDesign_AlignVerticalCenters_STipContent: return "沿垂直方向居中对齐所选控件";//Align the centers of the selected controls vertically.
                case ReportStringId.RibbonXRDesign_AlignVerticalCenters_STipTitle: return "居中对齐";//Align Centers
                case ReportStringId.RibbonXRDesign_BackColor_Caption: return "背景颜色";//Background Color
                case ReportStringId.RibbonXRDesign_BackColor_STipContent: return "改变文字背景颜色.";//Change the text background color.
                case ReportStringId.RibbonXRDesign_BackColor_STipTitle: return "背景颜色";//Background Color
                case ReportStringId.RibbonXRDesign_BringToFront_Caption: return "置于顶部";//Bring to Front
                case ReportStringId.RibbonXRDesign_BringToFront_STipContent: return "将所选控件置于顶部.";//Bring the selected controls to the front.
                case ReportStringId.RibbonXRDesign_BringToFront_STipTitle: return "置于顶部";//Bring to Front
                case ReportStringId.RibbonXRDesign_CenterHorizontally_Caption: return "水平居中";//Center Horizontally
                case ReportStringId.RibbonXRDesign_CenterHorizontally_STipContent: return "水平居中一个带区内所选控件.";//Horizontally center the selected controls within a band.
                case ReportStringId.RibbonXRDesign_CenterHorizontally_STipTitle: return "水平居中";//Center Horizontally
                case ReportStringId.RibbonXRDesign_CenterVertically_Caption: return "垂直居中";//Center Vertically
                case ReportStringId.RibbonXRDesign_CenterVertically_STipContent: return "垂直居中一个带区内所选控件.";//Vertically center the selected controls within a band.
                case ReportStringId.RibbonXRDesign_CenterVertically_STipTitle: return "垂直居中";//Center Vertically
                case ReportStringId.RibbonXRDesign_Close_Caption: return "关闭";//Close
                case ReportStringId.RibbonXRDesign_Close_STipContent: return "关闭当前报表。";//Close the current report.
                case ReportStringId.RibbonXRDesign_Close_STipTitle: return "关闭";//Close
                case ReportStringId.RibbonXRDesign_Copy_Caption: return "复制";//Copy
                case ReportStringId.RibbonXRDesign_Copy_STipContent: return "复制报表中所选控件到剪贴板.";//Copy the selected controls and put them on the Clipboard.
                case ReportStringId.RibbonXRDesign_Copy_STipTitle: return "复制";//Copy
                case ReportStringId.RibbonXRDesign_Cut_Caption: return "剪切";//Cut
                case ReportStringId.RibbonXRDesign_Cut_STipContent: return "剪切报表中所选控件并放到剪贴板.";//Cut the selected controls from the report and put them on the Clipboard.
                case ReportStringId.RibbonXRDesign_Cut_STipTitle: return "剪切";//Cut
                case ReportStringId.RibbonXRDesign_Exit_Caption: return "退出";//Exit
                case ReportStringId.RibbonXRDesign_Exit_STipContent: return "关闭报表设计器。";//Close the report designer.
                case ReportStringId.RibbonXRDesign_Exit_STipTitle: return "退出";//Exit
                case ReportStringId.RibbonXRDesign_FontBold_Caption: return "粗体";//Bold
                case ReportStringId.RibbonXRDesign_FontBold_STipContent: return "使所选文字为粗体.";//Make the selected text bold.
                case ReportStringId.RibbonXRDesign_FontBold_STipTitle: return "粗体";//Bold
                case ReportStringId.RibbonXRDesign_FontItalic_Caption: return "斜体";//Italic
                case ReportStringId.RibbonXRDesign_FontItalic_STipContent: return "使所选文字为斜体.";//Italicize the text.
                case ReportStringId.RibbonXRDesign_FontItalic_STipTitle: return "斜体";//Italic
                case ReportStringId.RibbonXRDesign_FontName_STipContent: return "改变字体样式.";//Change the font face.
                case ReportStringId.RibbonXRDesign_FontName_STipTitle: return "字体";//Font
                case ReportStringId.RibbonXRDesign_FontSize_STipContent: return "改变字体大小.";//Change the font size.
                case ReportStringId.RibbonXRDesign_FontSize_STipTitle: return "字体大小";//Font Size
                case ReportStringId.RibbonXRDesign_FontUnderline_Caption: return "下划线";//Underline
                case ReportStringId.RibbonXRDesign_FontUnderline_STipContent: return "使所选文字加下划线.";//Underline the selected text.
                case ReportStringId.RibbonXRDesign_FontUnderline_STipTitle: return "下划线";//Underline
                case ReportStringId.RibbonXRDesign_ForeColor_Caption: return "前景色";//Foreground Color
                case ReportStringId.RibbonXRDesign_ForeColor_STipContent: return "改变文字前景色.";//Change the text foreground color.
                case ReportStringId.RibbonXRDesign_ForeColor_STipTitle: return "前景色";//Foreground Color
                case ReportStringId.RibbonXRDesign_HorizSpaceConcatenate_Caption: return "删除水平间距";//Remove Horizontal Spacing
                case ReportStringId.RibbonXRDesign_HorizSpaceConcatenate_STipContent: return "删除所选控件之间的水平间距.";//Remove the horizontal spacing between the selected controls.
                case ReportStringId.RibbonXRDesign_HorizSpaceConcatenate_STipTitle: return "删除水平间距";//Remove Horizontal Spacing
                case ReportStringId.RibbonXRDesign_HorizSpaceDecrease_Caption: return "减少水平间距";//Decrease Horizontal Spacing
                case ReportStringId.RibbonXRDesign_HorizSpaceDecrease_STipContent: return "减少所选控件之间的水平间距.";//Decrease the horizontal spacing between the selected controls.
                case ReportStringId.RibbonXRDesign_HorizSpaceDecrease_STipTitle: return "减少水平间距";//Decrease Horizontal Spacing
                case ReportStringId.RibbonXRDesign_HorizSpaceIncrease_Caption: return "增加水平间距";//Increase Horizontal Spacing
                case ReportStringId.RibbonXRDesign_HorizSpaceIncrease_STipContent: return "增加所选控件之间的水平间距.";//Increase the horizontal spacing between the selected controls.
                case ReportStringId.RibbonXRDesign_HorizSpaceIncrease_STipTitle: return "增加水平间距";//Increase Horizontal Spacing
                case ReportStringId.RibbonXRDesign_HorizSpaceMakeEqual_Caption: return "水平间距等距";//Make Horizontal Spacing Equal
                case ReportStringId.RibbonXRDesign_HorizSpaceMakeEqual_STipContent: return "使所选控件水平间距相等.";//Make the horizontal spacing between the selected controls equal.
                case ReportStringId.RibbonXRDesign_HorizSpaceMakeEqual_STipTitle: return "水平间距等距";//Make Horizontal Spacing Equal
                case ReportStringId.RibbonXRDesign_HtmlBackward_Caption: return "返回";//Back
                case ReportStringId.RibbonXRDesign_HtmlBackward_STipContent: return "返回上页.";//Move back to the previous page.
                case ReportStringId.RibbonXRDesign_HtmlBackward_STipTitle: return "返回";//Back
                case ReportStringId.RibbonXRDesign_HtmlFind_Caption: return "查找";//Find
                case ReportStringId.RibbonXRDesign_HtmlFind_STipContent: return "在该页上查找文本.";//Find the text on this page.
                case ReportStringId.RibbonXRDesign_HtmlFind_STipTitle: return "查找";//Find
                case ReportStringId.RibbonXRDesign_HtmlForward_Caption: return "下页";//Forward
                case ReportStringId.RibbonXRDesign_HtmlForward_STipContent: return "移到下一页.";//Move forward to the next page.
                case ReportStringId.RibbonXRDesign_HtmlForward_STipTitle: return "下页";//Forward
                case ReportStringId.RibbonXRDesign_HtmlHome_Caption: return "主页";//Home
                case ReportStringId.RibbonXRDesign_HtmlHome_STipContent: return "显示主页.";//Display the home page.
                case ReportStringId.RibbonXRDesign_HtmlHome_STipTitle: return "主页";//Home
                case ReportStringId.RibbonXRDesign_HtmlPageText: return "HTML视图";//HTML View
                case ReportStringId.RibbonXRDesign_HtmlRefresh_Caption: return "刷新";//Refresh
                case ReportStringId.RibbonXRDesign_HtmlRefresh_STipContent: return "刷新当前页.";//Refresh this page.
                case ReportStringId.RibbonXRDesign_HtmlRefresh_STipTitle: return "刷新";//Refresh
                case ReportStringId.RibbonXRDesign_JustifyCenter_Caption: return "文本居中";//Center Text
                case ReportStringId.RibbonXRDesign_JustifyCenter_STipContent: return "文本居中.";//Center text.
                case ReportStringId.RibbonXRDesign_JustifyCenter_STipTitle: return "文本居中";//Center Text
                case ReportStringId.RibbonXRDesign_JustifyJustify_Caption: return "自适应";//Justify
                case ReportStringId.RibbonXRDesign_JustifyJustify_STipContent: return "根据单词自动排列左右对齐.";//Align text to both the left and right sides, adding extra space between words as necessary.
                case ReportStringId.RibbonXRDesign_JustifyJustify_STipTitle: return "自适应";//Justify
                case ReportStringId.RibbonXRDesign_JustifyLeft_Caption: return "左对齐文本";//Align Text Left
                case ReportStringId.RibbonXRDesign_JustifyLeft_STipContent: return "左对齐文本.";//Align text to the left.
                case ReportStringId.RibbonXRDesign_JustifyLeft_STipTitle: return "左对齐文本";//Align Text Left
                case ReportStringId.RibbonXRDesign_JustifyRight_Caption: return "右对齐文本";//Align Text Right
                case ReportStringId.RibbonXRDesign_JustifyRight_STipContent: return "右对齐文本.";//Align text to the right.
                case ReportStringId.RibbonXRDesign_JustifyRight_STipTitle: return "右对齐文本";//Align Text Right
                case ReportStringId.RibbonXRDesign_NewReport_Caption: return "新建报表";//New Report
                case ReportStringId.RibbonXRDesign_NewReport_STipContent: return "创建一个新的空白报表,你可以插入字段和控件并设计报表.";//Create a new blank report.
                case ReportStringId.RibbonXRDesign_NewReport_STipTitle: return "新建空白报表";//New Blank Report
                case ReportStringId.RibbonXRDesign_NewReportWizard_Caption: return "使用向导新建立报表...";//New Report via Wizard...
                case ReportStringId.RibbonXRDesign_NewReportWizard_STipContent: return "启动报表向导帮助你创建简单的、自定义报表.";//Launch the report wizard to create a new report.
                case ReportStringId.RibbonXRDesign_NewReportWizard_STipTitle: return "使用向导建立新报表";//New Report via Wizard
                case ReportStringId.RibbonXRDesign_OpenFile_Caption: return "打开...";//Open...
                case ReportStringId.RibbonXRDesign_OpenFile_STipContent: return "打开报表.";//Open a report.
                case ReportStringId.RibbonXRDesign_OpenFile_STipTitle: return "打开报表";//Open Report
                case ReportStringId.RibbonXRDesign_PageGroup_Alignment: return "排列";//Alignment
                case ReportStringId.RibbonXRDesign_PageGroup_Edit: return "编辑";//Edit
                case ReportStringId.RibbonXRDesign_PageGroup_Font: return "字体";//Font
                case ReportStringId.RibbonXRDesign_PageGroup_HtmlNavigation: return "导航";//Navigation
                case ReportStringId.RibbonXRDesign_PageGroup_Report: return "报表";//Report
                case ReportStringId.RibbonXRDesign_PageGroup_Scripts: return "脚本";//Scripts
                case ReportStringId.RibbonXRDesign_PageGroup_SizeAndLayout: return "布局";//Layout
                case ReportStringId.RibbonXRDesign_PageGroup_View: return "视图";//View
                case ReportStringId.RibbonXRDesign_PageGroup_Zoom: return "缩放";//Zoom
                case ReportStringId.RibbonXRDesign_PageText: return "报表设计器";//Report Designer
                case ReportStringId.RibbonXRDesign_Paste_Caption: return "粘贴";//Paste
                case ReportStringId.RibbonXRDesign_Paste_STipContent: return "粘贴剪贴板内容.";//Paste the contents of the Clipboard.
                case ReportStringId.RibbonXRDesign_Paste_STipTitle: return "粘贴";//Paste
                case ReportStringId.RibbonXRDesign_Redo_Caption: return "重做";//Redo
                case ReportStringId.RibbonXRDesign_Redo_STipContent: return "重做最后一步操作.";//Redo the last operation.
                case ReportStringId.RibbonXRDesign_Redo_STipTitle: return "重做";//Redo
                case ReportStringId.RibbonXRDesign_SaveAll_Caption: return "全部保存";//Save All
                case ReportStringId.RibbonXRDesign_SaveAll_STipContent: return "保存所有修改的报告。";//Save all modified reports.
                case ReportStringId.RibbonXRDesign_SaveAll_STipTitle: return "保存所有报表";//Save All Reports
                case ReportStringId.RibbonXRDesign_SaveFile_Caption: return "保存";//Save
                case ReportStringId.RibbonXRDesign_SaveFile_STipContent: return "保存报表.";//Save the current report.
                case ReportStringId.RibbonXRDesign_SaveFile_STipTitle: return "保存报表";//Save Report
                case ReportStringId.RibbonXRDesign_SaveFileAs_Caption: return "另存为...";//Save As...
                case ReportStringId.RibbonXRDesign_SaveFileAs_STipContent: return "将报表保存为另外一个文件名.";//Save the current report with a new name.
                case ReportStringId.RibbonXRDesign_SaveFileAs_STipTitle: return "报表另存为";//Save Report As
                case ReportStringId.RibbonXRDesign_Scripts_Caption: return "脚本";//Scripts
                case ReportStringId.RibbonXRDesign_Scripts_STipContent: return "显示或隐藏脚本编辑器中。";//Show or hide the Scripts Editor.
                case ReportStringId.RibbonXRDesign_Scripts_STipTitle: return "显示/隐藏脚本";//Show/Hide Scripts
                case ReportStringId.RibbonXRDesign_SendToBack_Caption: return "置于底部";//Send to Back
                case ReportStringId.RibbonXRDesign_SendToBack_STipContent: return "将所选控件置于底部.";//Move the selected controls to the back.
                case ReportStringId.RibbonXRDesign_SendToBack_STipTitle: return "置于底部";//Send to Back
                case ReportStringId.RibbonXRDesign_SizeToControl_Caption: return "置为相同大小";//Make Same Size
                case ReportStringId.RibbonXRDesign_SizeToControl_STipContent: return "将所选控件置为相同大小.";//Make the selected controls have the same size.
                case ReportStringId.RibbonXRDesign_SizeToControl_STipTitle: return "置为相同大小";//Make Same Size
                case ReportStringId.RibbonXRDesign_SizeToControlHeight_Caption: return "置为相同高度";//Make Same Height
                case ReportStringId.RibbonXRDesign_SizeToControlHeight_STipContent: return "将所选控件置为相同高度.";//Make the selected controls have the same height.
                case ReportStringId.RibbonXRDesign_SizeToControlHeight_STipTitle: return "置为相同高度";//Make Same Height
                case ReportStringId.RibbonXRDesign_SizeToControlWidth_Caption: return "置为相同宽度";//Make Same Width
                case ReportStringId.RibbonXRDesign_SizeToControlWidth_STipContent: return "将所选控件置为相同宽度.";//Make the selected controls have the same width.
                case ReportStringId.RibbonXRDesign_SizeToControlWidth_STipTitle: return "置为相同宽度";//Make Same Width
                case ReportStringId.RibbonXRDesign_SizeToGrid_Caption: return "网格尺寸";//Size to Grid
                case ReportStringId.RibbonXRDesign_SizeToGrid_STipContent: return "所选控件网格尺寸.";//Size the selected controls to the grid.
                case ReportStringId.RibbonXRDesign_SizeToGrid_STipTitle: return "网格尺寸";//Size to Grid
                case ReportStringId.RibbonXRDesign_StatusBar_HtmlDone: return "做";//Done
                case ReportStringId.RibbonXRDesign_StatusBar_HtmlProcessing: return "正在处理...";//Processing...
                case ReportStringId.RibbonXRDesign_Undo_Caption: return "撤消";//Undo
                case ReportStringId.RibbonXRDesign_Undo_STipContent: return "撤消最后一步操作.";//Undo the last operation.
                case ReportStringId.RibbonXRDesign_Undo_STipTitle: return "撤消";//Undo
                case ReportStringId.RibbonXRDesign_VertSpaceConcatenate_Caption: return "删除垂直间距";//Remove Vertical Spacing
                case ReportStringId.RibbonXRDesign_VertSpaceConcatenate_STipContent: return "删除所选控件的垂直间距.";//Remove the vertical spacing between the selected controls.
                case ReportStringId.RibbonXRDesign_VertSpaceConcatenate_STipTitle: return "删除垂直间距";//Remove Vertical Spacing
                case ReportStringId.RibbonXRDesign_VertSpaceDecrease_Caption: return "减少垂直间距";//Decrease Vertical Spacing
                case ReportStringId.RibbonXRDesign_VertSpaceDecrease_STipContent: return "减少所选控件的垂直间距.";//Decrease the vertical spacing between the selected controls.
                case ReportStringId.RibbonXRDesign_VertSpaceDecrease_STipTitle: return "减少垂直间距";//Decrease Vertical Spacing
                case ReportStringId.RibbonXRDesign_VertSpaceIncrease_Caption: return "增加垂直间距";//Increase Vertical Spacing
                case ReportStringId.RibbonXRDesign_VertSpaceIncrease_STipContent: return "增加所选控件的垂直间距.";//Increase the vertical spacing between the selected controls.
                case ReportStringId.RibbonXRDesign_VertSpaceIncrease_STipTitle: return "增加垂直间距";//Increase Vertical Spacing
                case ReportStringId.RibbonXRDesign_VertSpaceMakeEqual_Caption: return "垂直等距";//Make Vertical Spacing Equal
                case ReportStringId.RibbonXRDesign_VertSpaceMakeEqual_STipContent: return "使所选控件垂直等距.";//Make the vertical spacing between the selected controls equal.
                case ReportStringId.RibbonXRDesign_VertSpaceMakeEqual_STipTitle: return "垂直等距";//Make Vertical Spacing Equal
                case ReportStringId.RibbonXRDesign_Windows_Caption: return "窗口";//Windows
                case ReportStringId.RibbonXRDesign_Windows_STipContent: return "显示/隐藏工具栏,报表浏览器,字段列表和属性窗口.";//Show or hide the Tool Box, Report Explorer, Field List and Property Grid windows.
                case ReportStringId.RibbonXRDesign_Windows_STipTitle: return "显示/隐藏窗口";//Show/Hide Windows
                case ReportStringId.RibbonXRDesign_Zoom_Caption: return "缩放";//Zoom
                case ReportStringId.RibbonXRDesign_Zoom_STipContent: return "改变文档设计器的所放率.";//Change the zoom level of the document designer.
                case ReportStringId.RibbonXRDesign_Zoom_STipTitle: return "缩放";//Zoom
                case ReportStringId.RibbonXRDesign_ZoomExact_Caption: return "要求:";//Exact:
                case ReportStringId.RibbonXRDesign_ZoomIn_Caption: return "放大";//Zoom In
                case ReportStringId.RibbonXRDesign_ZoomIn_STipContent: return "放大查看报表局部视图.";//Zoom in to get a close-up view of the report.
                case ReportStringId.RibbonXRDesign_ZoomIn_STipTitle: return "放大";//Zoom In
                case ReportStringId.RibbonXRDesign_ZoomOut_Caption: return "缩小";//Zoom Out
                case ReportStringId.RibbonXRDesign_ZoomOut_STipContent: return "缩小尺寸在查看更多的报表.";//Zoom out to see more of the report at a reduced size.
                case ReportStringId.RibbonXRDesign_ZoomOut_STipTitle: return "缩小";//Zoom Out
                case ReportStringId.ScriptEditor_ClickValidate: return "单击;//验证;//来检查脚本。";//Click "Validate" to check scripts.
                case ReportStringId.ScriptEditor_ErrorColumn: return "列";//Column
                case ReportStringId.ScriptEditor_ErrorDescription: return "说明";//Description
                case ReportStringId.ScriptEditor_ErrorLine: return "线";//Line
                case ReportStringId.ScriptEditor_NewString: return "（新）";//(New)
                case ReportStringId.ScriptEditor_ScriptsAreValid: return "所有脚本都是有效的。";//All scripts are valid.
                case ReportStringId.ScriptEditor_Validate: return "验证";//Validate
                case ReportStringId.SR_Height: return "高度";//Height
                case ReportStringId.SR_Horizontal_Pitch: return "水平倾斜";//Horizontal pitch
                case ReportStringId.SR_Number_Across: return "数字交叉";//Number Across
                case ReportStringId.SR_Number_Down: return "数字下降";//Number  Down
                case ReportStringId.SR_Side_Margins: return "边距";//Side margins
                case ReportStringId.SR_Top_Margin: return "上边距";//Top  margin
                case ReportStringId.SR_Vertical_Pitch: return "垂直倾斜";//Vertical  pitch
                case ReportStringId.SR_Width: return "宽度";//Width
                case ReportStringId.SSForm_Btn_Close: return "关闭";//Close
                case ReportStringId.SSForm_Caption: return "风格编辑器";//Styles Editor
                case ReportStringId.SSForm_Msg_FileFilter: return "报表样式表文件 (*.repss)|*.repss;//所有的文件(*.*)|*.*";//Report StyleSheet files (*.repss)|*.repss;//All files (*.*)|*.*
                case ReportStringId.SSForm_Msg_InvalidFileFormat: return "无效的文件格式";//Invalid file format
                case ReportStringId.SSForm_Msg_MoreThanOneStyle: return "你已经选中了一种和多种风格";//You selected more than one style
                case ReportStringId.SSForm_Msg_NoStyleSelected: return "没有选中风格";//No styles are selected
                case ReportStringId.SSForm_Msg_SelectedStylesText: return " 选中的风格...";// selected styles...
                case ReportStringId.SSForm_Msg_StyleNamePreviewPostfix: return "风格";// style
                case ReportStringId.SSForm_Msg_StyleSheetError: return "风格表单错误";//StyleSheet error
                case ReportStringId.SSForm_TTip_AddStyle: return "添加风格";//Add a style
                case ReportStringId.SSForm_TTip_ClearStyles: return "清除风格";//Clear styles
                case ReportStringId.SSForm_TTip_LoadStyles: return "从文件中导入风格";//Load styles from a file
                case ReportStringId.SSForm_TTip_PurgeStyles: return "删除未使用的风格";//Delete unused styles
                case ReportStringId.SSForm_TTip_RemoveStyle: return "删除风格";//Remove a style
                case ReportStringId.SSForm_TTip_SaveStyles: return "将风格保存到文件";//Save styles to a file
                case ReportStringId.STag_Capt_Format: return "{0} {1}";//{0} {1}
                case ReportStringId.STag_Capt_Tasks: return "任务";//Tasks
                case ReportStringId.STag_Name_Bands: return "带区";//Bands
                case ReportStringId.STag_Name_Checked: return "选中";//Checked
                case ReportStringId.STag_Name_ColumnCount: return "列数";//Column Count
                case ReportStringId.STag_Name_ColumnLayout: return "多列布局";//Multi-Column Layout
                case ReportStringId.STag_Name_ColumnMode: return "列模式";//Multi-Column Mode
                case ReportStringId.STag_Name_ColumnSpacing: return "列间距";//Column Spacing
                case ReportStringId.STag_Name_ColumnWidth: return "列宽";//Column Width
                case ReportStringId.STag_Name_DataBinding: return "数据绑定";//Data Binding
                case ReportStringId.STag_Name_FieldArea: return "新字段区域";//Field Area for a New Field
                case ReportStringId.STag_Name_FormatString: return "格式化字符串";//Format String
                case ReportStringId.STag_Name_Height: return "高度";//Height
                case ReportStringId.STag_Name_PreviewRowCount: return "预览行数";//Preview Row Count
                case ReportStringId.UD_Capt_AlignBottoms: return "底端对齐";//&Bottoms
                case ReportStringId.UD_Capt_AlignCenters: return "居中对齐";//&Centers
                case ReportStringId.UD_Capt_AlignLefts: return "左对齐";//&Lefts
                case ReportStringId.UD_Capt_AlignMiddles: return "中间对齐";//&Middles
                case ReportStringId.UD_Capt_AlignRights: return "右对齐";//&Rights
                case ReportStringId.UD_Capt_AlignToGrid: return "对齐网格";//to &Grid
                case ReportStringId.UD_Capt_AlignTops: return "顶端对齐";//&Tops
                case ReportStringId.UD_Capt_BackGroundColor: return "背景色";//Bac&kground Color
                case ReportStringId.UD_Capt_CenterInFormHorizontally: return "水平方向";//&Horizontally
                case ReportStringId.UD_Capt_CenterInFormVertically: return "垂直方向";//&Vertically
                case ReportStringId.UD_Capt_Close: return "关闭";//&Close
                case ReportStringId.UD_Capt_Copy: return "复制";//&Copy
                case ReportStringId.UD_Capt_Cut: return "剪切";//Cu&t
                case ReportStringId.UD_Capt_Delete: return "删除";//&Delete
                case ReportStringId.UD_Capt_Exit: return "退出";//E&xit
                case ReportStringId.UD_Capt_FontBold: return "加粗";//&Bold
                case ReportStringId.UD_Capt_FontItalic: return "斜线";//&Italic
                case ReportStringId.UD_Capt_FontUnderline: return "下划线";//&Underline
                case ReportStringId.UD_Capt_ForegroundColor: return "前景色";//For&eground Color
                case ReportStringId.UD_Capt_FormattingToolbarName: return "格式化工具栏";//Formatting Toolbar
                case ReportStringId.UD_Capt_JustifyCenter: return "居中对齐";//&Center
                case ReportStringId.UD_Capt_JustifyJustify: return "两边对齐";//&Justify
                case ReportStringId.UD_Capt_JustifyLeft: return "左对齐";//&Left
                case ReportStringId.UD_Capt_JustifyRight: return "右对齐";//&Rights
                case ReportStringId.UD_Capt_LayoutToolbarName: return "布局设计工具栏";//Layout Toolbar
                case ReportStringId.UD_Capt_MainMenuName: return "主菜单";//Main Menu
                case ReportStringId.UD_Capt_MakeSameSizeBoth: return "宽度/高度(&B)";//&Both
                case ReportStringId.UD_Capt_MakeSameSizeHeight: return "高度(&H)";//&Height
                case ReportStringId.UD_Capt_MakeSameSizeSizeToGrid: return "分散排列（&D)";//Size to Gri&d
                case ReportStringId.UD_Capt_MakeSameSizeWidth: return "宽度";//&Width
                case ReportStringId.UD_Capt_MdiCascade: return "级联";//&Cascade
                case ReportStringId.UD_Capt_MdiTileHorizontal: return "水平平铺";//Tile &Horizontal
                case ReportStringId.UD_Capt_MdiTileVertical: return "垂直平铺";//Tile &Vertical
                case ReportStringId.UD_Capt_NewReport: return "创建新报表";//&New
                case ReportStringId.UD_Capt_NewWizardReport: return "报表导航...";//New via &Wizard...
                case ReportStringId.UD_Capt_OpenFile: return "打开文件...";//&Open...
                case ReportStringId.UD_Capt_OrderBringToFront: return "置于顶层";//&Bring to Front
                case ReportStringId.UD_Capt_OrderSendToBack: return "置于底层";//&Send to Back
                case ReportStringId.UD_Capt_Paste: return "粘贴";//&Paste
                case ReportStringId.UD_Capt_Redo: return "重做";//&Redo
                case ReportStringId.UD_Capt_SaveAll: return "保存全部";//Save A&ll
                case ReportStringId.UD_Capt_SaveFile: return "保存";//&Save
                case ReportStringId.UD_Capt_SaveFileAs: return "另存为...";//Save &As...
                case ReportStringId.UD_Capt_SelectAll: return "选择所有";//Select &All
                case ReportStringId.UD_Capt_SpacingDecrease: return "减少间距";//&Decrease
                case ReportStringId.UD_Capt_SpacingIncrease: return "增加间距";//&Increase
                case ReportStringId.UD_Capt_SpacingMakeEqual: return "间距相等";//Make &Equal
                case ReportStringId.UD_Capt_SpacingRemove: return "删除间距";//&Remove
                case ReportStringId.UD_Capt_StatusBarName: return "状态条";//Status Bar
                case ReportStringId.UD_Capt_TabbedInterface: return "选项卡式界面";//&Tabbed Interface
                case ReportStringId.UD_Capt_ToolbarName: return "主工具栏";//Toolbar
                case ReportStringId.UD_Capt_Undo: return "撤销";//&Undo
                case ReportStringId.UD_Capt_Zoom: return "缩放";//Zoom
                case ReportStringId.UD_Capt_ZoomFactor: return "缩放比例: {0}%";//Zoom Factor: {0}%
                case ReportStringId.UD_Capt_ZoomIn: return "放大";//Zoom In
                case ReportStringId.UD_Capt_ZoomOut: return "缩小";//Zoom Out
                case ReportStringId.UD_Capt_ZoomToolbarName: return "缩放工具";//Zoom Toolbar
                case ReportStringId.UD_FormCaption: return "报表设计者";//Report Designer
                case ReportStringId.UD_Group_Align: return "对齐";//&Align
                case ReportStringId.UD_Group_CenterInForm: return "居中";//&Center in Form
                case ReportStringId.UD_Group_DockPanelsList: return "窗口";//&Windows
                case ReportStringId.UD_Group_Edit: return "编辑";//&Edit
                case ReportStringId.UD_Group_File: return "文件";//&File
                case ReportStringId.UD_Group_Font: return "字体";//&Font
                case ReportStringId.UD_Group_Format: return "格式化";//Fo&rmat
                case ReportStringId.UD_Group_HorizontalSpacing: return "水平间距";//&Horizontal Spacing
                case ReportStringId.UD_Group_Justify: return "左右对齐";//&Justify
                case ReportStringId.UD_Group_MakeSameSize: return "尺寸相等";//&Make Same Size
                case ReportStringId.UD_Group_Order: return "序号";//&Order
                case ReportStringId.UD_Group_TabButtonsList: return "选项卡按钮";//Tab Buttons
                case ReportStringId.UD_Group_ToolbarsList: return "工具栏";//&Toolbars
                case ReportStringId.UD_Group_VerticalSpacing: return "垂直间距";//&Vertical Spacing
                case ReportStringId.UD_Group_View: return "视图";//&View
                case ReportStringId.UD_Group_Window: return "窗口";//&Window
                case ReportStringId.UD_Hint_AlignBottoms: return "将选择的控件底端对齐";//Align the bottoms of the selected controls
                case ReportStringId.UD_Hint_AlignCenters: return "将选择的控件垂直居中对齐";//Align the centers of the selected controls vertically
                case ReportStringId.UD_Hint_AlignLefts: return "将选择的控件左对齐";//Left align the selected controls
                case ReportStringId.UD_Hint_AlignMiddles: return "将选择的控件水平居中对齐";//Align the centers of the selected controls horizontally
                case ReportStringId.UD_Hint_AlignRights: return "将选择的控件右对齐";//Right align the selected controls
                case ReportStringId.UD_Hint_AlignToGrid: return "将选择的控件与网格对齐";//Align the positions of the selected controls to the grid
                case ReportStringId.UD_Hint_AlignTops: return "将选择的控件顶端对齐";//Align the tops of the selected controls
                case ReportStringId.UD_Hint_BackGroundColor: return "设置控件的背景色";//Set the background color of the control
                case ReportStringId.UD_Hint_CenterInFormHorizontally: return "在一个带区内使选择的控件水平居中";//Horizontally center the selected controls within a band
                case ReportStringId.UD_Hint_CenterInFormVertically: return "在一个带区内使选择的控件垂直居中";//Vertically center the selected controls within a band
                case ReportStringId.UD_Hint_Close: return "关闭报表";//Close the report
                case ReportStringId.UD_Hint_Copy: return "将控件拷贝到剪贴板";//Copy the control to the clipboard
                case ReportStringId.UD_Hint_Cut: return "删除该控件并将它拷贝到剪贴板";//Delete the control and copy it to the clipboard
                case ReportStringId.UD_Hint_Delete: return "删除控件";//Delete the control
                case ReportStringId.UD_Hint_Exit: return "关闭设计器";//Close the designer
                case ReportStringId.UD_Hint_FontBold: return "使字体变粗";//Make the font bold
                case ReportStringId.UD_Hint_FontItalic: return "使字体变斜";//Make the font italic
                case ReportStringId.UD_Hint_FontUnderline: return "字体加下划线";//Underline the font
                case ReportStringId.UD_Hint_ForegroundColor: return "设置控件的前景色";//Set the foreground color of the control
                case ReportStringId.UD_Hint_JustifyCenter: return "控件内容居中对齐";//Align the control;//s text to the center
                case ReportStringId.UD_Hint_JustifyJustify: return "控件内容两边对齐";//Justify the control;//s text
                case ReportStringId.UD_Hint_JustifyLeft: return "控件内容左对齐";//Align the control;//s text to the left
                case ReportStringId.UD_Hint_JustifyRight: return "控件内容右对齐";//Align the control;//s text to the right
                case ReportStringId.UD_Hint_MakeSameSizeBoth: return "使选择的控件尺寸相等";//Make the selected controls the same size
                case ReportStringId.UD_Hint_MakeSameSizeHeight: return "使选择的控件高度相等";//Make the selected controls have the same height
                case ReportStringId.UD_Hint_MakeSameSizeSizeToGrid: return "调整选择的控件使网格对齐";//Size the selected controls to the grid
                case ReportStringId.UD_Hint_MakeSameSizeWidth: return "使选择的控件宽度相等";//Make the selected controls have the same width
                case ReportStringId.UD_Hint_MdiCascade: return "排列所有打开的文档级联，以便他们彼此重叠";//Arrange all open documents cascaded, so that they overlap each other
                case ReportStringId.UD_Hint_MdiTileHorizontal: return "排列所有打开文档从顶部到底部";//Arrange all open documents from top to bottom
                case ReportStringId.UD_Hint_MdiTileVertical: return "所有打开的文档，从左到右排列";//Arrange all open documents from left to right
                case ReportStringId.UD_Hint_NewReport: return "创建一个新的空报表";//Create a new blank report
                case ReportStringId.UD_Hint_NewWizardReport: return "使用导航功能，创建一个新报表";//Create a new report using the Wizard
                case ReportStringId.UD_Hint_OpenFile: return "打开报表";//Open a report
                case ReportStringId.UD_Hint_OrderBringToFront: return "使选择的控件置于顶层";//Bring the selected controls to the front
                case ReportStringId.UD_Hint_OrderSendToBack: return "使选择的控件置于底层";//Move the selected controls to the back
                case ReportStringId.UD_Hint_Paste: return "从剪贴板上添加一个控件";//Add the control from the clipboard
                case ReportStringId.UD_Hint_Redo: return "重做上一次操作";//Redo the last operation
                case ReportStringId.UD_Hint_SaveAll: return "保存所有报表";//Save all reports
                case ReportStringId.UD_Hint_SaveFile: return "保存报表";//Save the report
                case ReportStringId.UD_Hint_SaveFileAs: return "用一个新名称来保存报表";//Save the report with a new name
                case ReportStringId.UD_Hint_SelectAll: return "选择文档里面的所有控件";//Select all the controls in the document
                case ReportStringId.UD_Hint_SpacingDecrease: return "减少选择的控件间距";//Decrease the spacing between the selected controls
                case ReportStringId.UD_Hint_SpacingIncrease: return "增加选择的控件间距";//Increase the spacing between the selected controls
                case ReportStringId.UD_Hint_SpacingMakeEqual: return "使选择的控件间距相等";//Make the spacing between the selected controls equal
                case ReportStringId.UD_Hint_SpacingRemove: return "删除选择的控件间距";//Remove the spacing between the selected controls
                case ReportStringId.UD_Hint_TabbedInterface: return "交换机之间选项卡式窗口 MDI 布局模式";//Switch between tabbed and window MDI layout modes
                case ReportStringId.UD_Hint_Undo: return "撤销上一次操作";//Undo the last operation
                case ReportStringId.UD_Hint_ViewBars: return "隐藏/显示 {0}";//Hide or show the {0}
                case ReportStringId.UD_Hint_ViewDockPanels: return "隐藏/显示 {0} window";//Hide or show the {0} window
                case ReportStringId.UD_Hint_ViewTabs: return "切换到 {0} tab";//Switch to the {0} tab
                case ReportStringId.UD_Hint_Zoom: return "选择/输入 缩放率";//Select or input the zoom factor
                case ReportStringId.UD_Hint_ZoomIn: return "放大设计界面";//Zoom in the design surface
                case ReportStringId.UD_Hint_ZoomOut: return "缩小设计界面";//Zoom out the design surface
                case ReportStringId.UD_Msg_MdiReportChanged: return "{0} 已被更改。是否要保存更改？";//"{0}" has been changed. Do you want to save changes ?
                case ReportStringId.UD_Msg_ReportChanged: return "报表已经发生修改。想要保存修改后的内容吗？";//Report has been changed. Do you want to save changes ?
                case ReportStringId.UD_PropertyGrid_NotSetText: return "（未设置）";//(Not set)
                case ReportStringId.UD_ReportDesigner: return "报表设计器";//Report Designer
                case ReportStringId.UD_SaveFileDialog_DialogFilter: return "报表文件 (* {0})|* {1} ;//所有文件 (*.*)|*.*";//Report Files (*{0})|*{1};//All Files (*.*)|*.*
                case ReportStringId.UD_Title_ErrorList: return "脚本错误";//Scripts Errors
                case ReportStringId.UD_Title_FieldList: return "字段列表";//Field List
                case ReportStringId.UD_Title_FieldList_AddNewDataSourceText: return "添加新的数据源";//Add New DataSource
                //case ReportStringId.UD_Title_FieldList_NoneNodeText: return "(无)";//(None)
                case ReportStringId.UD_Title_FieldList_NonePickerNodeText: return "无";//None
                case ReportStringId.UD_Title_FieldList_ProjectObjectsText: return "项目对象";//Project Objects
                case ReportStringId.UD_Title_GroupAndSort: return "分组和排序";//Group and Sort
                case ReportStringId.UD_Title_PropertyGrid: return "属性";//Property Grid
                case ReportStringId.UD_Title_ReportExplorer: return "报表导出工具";//Report Explorer
                case ReportStringId.UD_Title_ToolBox: return "工具箱";//Tool Box
                case ReportStringId.UD_TTip_AlignBottom: return "底端对齐";//Align Bottoms
                case ReportStringId.UD_TTip_AlignHorizontalCenters: return "中间对齐";//Align Middles
                case ReportStringId.UD_TTip_AlignLeft: return "左对齐";//Align Lefts
                case ReportStringId.UD_TTip_AlignRight: return "右对齐";//Align Rights
                case ReportStringId.UD_TTip_AlignToGrid: return "使网格对齐";//Align to Grid
                case ReportStringId.UD_TTip_AlignTop: return "顶端对齐";//Align Tops
                case ReportStringId.UD_TTip_AlignVerticalCenters: return "中间对齐";//Align Centers
                case ReportStringId.UD_TTip_BringToFront: return "置于顶层";//Bring to Front
                case ReportStringId.UD_TTip_CenterHorizontally: return "水平居中";//Center Horizontally
                case ReportStringId.UD_TTip_CenterVertically: return "垂直居中";//CenterVertically
                case ReportStringId.UD_TTip_DataMemberDescription: return "数据成员: {0}";//    DataMember: {0}
                case ReportStringId.UD_TTip_EditCopy: return "复制";//Copy
                case ReportStringId.UD_TTip_EditCut: return "剪切";//Cut
                case ReportStringId.UD_TTip_EditPaste: return "粘贴";//Paste
                case ReportStringId.UD_TTip_FileOpen: return "打开文件";//Open File
                case ReportStringId.UD_TTip_FileSave: return "保存文件";//Save File
                case ReportStringId.UD_TTip_FormatAlignLeft: return "左对齐";//Align Left
                case ReportStringId.UD_TTip_FormatAlignRight: return "右对齐";//Align Right
                case ReportStringId.UD_TTip_FormatBackColor: return "背景色";//Background Color
                case ReportStringId.UD_TTip_FormatBold: return "加粗";//Bold
                case ReportStringId.UD_TTip_FormatCenter: return "居中";//Center
                case ReportStringId.UD_TTip_FormatFontName: return "字体名称";//Font Name
                case ReportStringId.UD_TTip_FormatFontSize: return "字体大小";//Font Size
                case ReportStringId.UD_TTip_FormatForeColor: return "前景色";//Foreground Color
                case ReportStringId.UD_TTip_FormatItalic: return "斜体";//Italic
                case ReportStringId.UD_TTip_FormatJustify: return "两边对齐";//Justify
                case ReportStringId.UD_TTip_FormatUnderline: return "下划线";//Underline
                case ReportStringId.UD_TTip_HorizSpaceConcatenate: return "删除垂直间距";//Remove Horizontal Spacing
                case ReportStringId.UD_TTip_HorizSpaceDecrease: return "减少水平间距";//Decrease Horizontal Spacing
                case ReportStringId.UD_TTip_HorizSpaceIncrease: return "增加水平间距";//Increase Horizontal Spacing
                case ReportStringId.UD_TTip_HorizSpaceMakeEqual: return "水平间距相等";//Make Horizontal Spacing Equal
                case ReportStringId.UD_TTip_ItemDescription: return "拖放对象来创建一个绑定控件;或者用鼠标右键或者SHIFT拖拽对象来从弹出菜单中选择一个绑定控件;或者使用上下文菜单来增加一个计算字段或者参数.";//Drag-and-drop this item to create a control bound to it;  - or -  Drag this item with the right mouse button or SHIFT  to select a bound control from the popup menu;  - or -  Use the context menu to add a calculated field or parameter.
                case ReportStringId.UD_TTip_Redo: return "重做";//Redo
                case ReportStringId.UD_TTip_SendToBack: return "置于底层";//Send to Back
                case ReportStringId.UD_TTip_SizeToControl: return "尺寸大小相等";//Make Same size
                case ReportStringId.UD_TTip_SizeToControlHeight: return "高度相同";//Make Same Height
                case ReportStringId.UD_TTip_SizeToControlWidth: return "宽度相等";//Make Same Width
                case ReportStringId.UD_TTip_SizeToGrid: return "均匀排列";//Size to Grid
                case ReportStringId.UD_TTip_TableDescription: return "拖放对象来创建一个表;或者用鼠标右键或者SHIFT拖拽对象来创建一个;//头;//表;或者使用上下文菜单来增加一个计算字段或者参数.";//Drag-and-drop this item to create a table with its items;  - or -  Drag this item with the right mouse button or SHIFT  to create a ;//header;// table with field names;  - or -  Use the context menu to add a calculated field or parameter.
                case ReportStringId.UD_TTip_Undo: return "撤销";//Undo
                case ReportStringId.UD_TTip_VertSpaceConcatenate: return "删除水平间距";//Remove Vertical Spacing
                case ReportStringId.UD_TTip_VertSpaceDecrease: return "减少垂直间距";//Decrease Vertical Spacing
                case ReportStringId.UD_TTip_VertSpaceIncrease: return "增加垂直间距";//Increase Vertical Spacing
                case ReportStringId.UD_TTip_VertSpaceMakeEqual: return "垂直间距相等";//Make Vertical Spacing Equal
                case ReportStringId.UD_XtraReportsPointerItemCaption: return "指示器";//Pointer
                case ReportStringId.UD_XtraReportsToolboxCategoryName: return "标准控件";//Standard Controls
                case ReportStringId.Verb_About: return "关于...";//About
                case ReportStringId.Verb_AddFieldToArea: return "在区域中增加字段";//Add Field to Area
                case ReportStringId.Verb_Bind: return "绑定";//Bind
                case ReportStringId.Verb_Delete: return "删除...";//Delete...
                case ReportStringId.Verb_EditBands: return "编辑带区...";//Edit and Reorder Bands...
                case ReportStringId.Verb_EditGroupFields: return "编辑字段组...";//Edit GroupFields...
                case ReportStringId.Verb_EditText: return "编辑内容";//Edit Text
                case ReportStringId.Verb_FormatString: return "格式化字符串...";//Format String...
                case ReportStringId.Verb_Import: return "导入...";//Open/Import...
                case ReportStringId.Verb_Insert: return "插入...";//Insert...
                //case ReportStringId.Verb_RemoveInvalidBindings: return "删除无效的绑定";//Remove Invalid Bindings
                case ReportStringId.Verb_ReportWizard: return "导航...";//Design in Report Wizard...
                case ReportStringId.Verb_RTFClear: return "清除";//Clear
                case ReportStringId.Verb_RTFLoad: return "载入文件...";//Load File...
                case ReportStringId.Verb_RunDesigner: return "设计器...";//Run Designer...
                case ReportStringId.Verb_Save: return "存储...";//Save...
                case ReportStringId.Verb_SummaryWizard: return "摘要...";//Summary...
                case ReportStringId.Wizard_PageChooseFields_Msg: return "在继续之前，您必须选择报表的字段";//You must select fields for the report before you continue
                case ReportStringId.XRSubreport_NameInfo: return "名称: {0}  ";//Name: {0}
                case ReportStringId.XRSubreport_NullReportSourceInfo: return "(空)";//Null
                case ReportStringId.XRSubreport_ReportSourceInfo: return "报表资源: {0}  ";//Report Source: {0}
                case ReportStringId.XRSubreport_ReportSourceUrlInfo: return "报表来源 Url: {0}";//Report Source Url: {0}
            }
            return string.Empty;
        }
    }
}