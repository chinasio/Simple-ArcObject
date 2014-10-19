using DevExpress.XtraGrid.Localization;

namespace SAO.DevHelper.DevCN
{
    /// <summary>
    /// GridControl控件汉化类
    ///
    /// add by andy 20120521
    /// 20140327 mod by lrm
    /// </summary>
    public class GridControlCN : GridLocalizer
    {
        public override string GetLocalizedString(GridStringId id)
        {
            switch (id)
            {
                case GridStringId.CardViewCaptionFormat: return "记录 N {0}";//'Record N {0}
                case GridStringId.CardViewNewCard: return "新建卡";//'New Card
                case GridStringId.CardViewQuickCustomizationButton: return "自定义";//'Customize
                case GridStringId.CardViewQuickCustomizationButtonFilter: return "过滤器 ";//'Filter
                case GridStringId.CardViewQuickCustomizationButtonSort: return "排序方式:";//'Sort:
                case GridStringId.ColumnViewExceptionMessage: return " 要修正当前值吗?";//' Do you want to correct the value ?
                case GridStringId.CustomFilterDialog2FieldCheck: return "字段";//'Field
                case GridStringId.CustomFilterDialogCancelButton: return "取消(&C)";//'&Cancel
                case GridStringId.CustomFilterDialogCaption: return "显示符合下列条件的行:";//'Show rows where:
                case GridStringId.CustomFilterDialogClearFilter: return "清除过滤器(&L)";//'C&lear Filter
                case GridStringId.CustomFilterDialogEmptyOperator: return "(选择一个操作)";//'(Select an operator)
                case GridStringId.CustomFilterDialogEmptyValue: return "(输入一个值)";//'(Enter a value)
                case GridStringId.CustomFilterDialogFormCaption: return "用户自定义自动过滤器";//'Custom AutoFilter
                case GridStringId.CustomFilterDialogHint: return "用 _ 替代一个单字符#用 % 替代其他任何类型的字符";//'Use _ to represent any single character#Use % to represent any series of characters
                case GridStringId.CustomFilterDialogOkButton: return "确定(&O)";//'&OK
                case GridStringId.CustomFilterDialogRadioAnd: return "与(&A)";//'&And
                case GridStringId.CustomFilterDialogRadioOr: return "或(&O)";//'O&r
                case GridStringId.CustomizationBands: return "带区";//'Bands
                case GridStringId.CustomizationCaption: return "自定义";//'Customization
                case GridStringId.CustomizationColumns: return "列";//'Columns
                case GridStringId.CustomizationFormBandHint: return "在此拖拉条来定制布局";//'Drag and drop bands here to customize layout
                case GridStringId.CustomizationFormColumnHint: return "在此拖拉列来定制布局";//'Drag and drop columns here to customize layout
                case GridStringId.FileIsNotFoundError: return "文件{0}找不到";//'File {0} is not found
                case GridStringId.FilterBuilderApplyButton: return "应用(&A)";//'&Apply
                case GridStringId.FilterBuilderCancelButton: return "取消(&C)";//'&Cancel
                case GridStringId.FilterBuilderCaption: return "数据筛选条件设定：";//'Filter Editor
                case GridStringId.FilterBuilderOkButton: return "确定(&O)";//'&OK
                case GridStringId.FilterPanelCustomizeButton: return "自定义";//'Edit Filter
                case GridStringId.FindControlClearButton: return "关闭";//'Close
                case GridStringId.FindControlFindButton: return "查找";//'Find
                case GridStringId.GridGroupPanelText: return "拖动列标题至此,根据该列分组";//'Drag a column header here to group by that column
                case GridStringId.GridNewRowText: return "在此处添加一行";//'Click here to add a new row
                case GridStringId.GridOutlookIntervals: return "更早;上个月;本月初;三周之前;两周之前;上周;;;;;;;;昨天;今天;明天;;;;;;;;下周;两周后;三周后;本月底;下个月;一个月之后;";//'Older;Last Month;Earlier this Month;Three Weeks Ago;Two Weeks Ago;Last Week;;;;;;;;Yesterday;Today;Tomorrow;;;;;;;;Next Week;Two Weeks Away;Three Weeks Away;Later this Month;Next Month;Beyond Next Month;
                case GridStringId.GroupSummaryEditorFormCancelButton: return "取消";//'Cancel
                case GridStringId.GroupSummaryEditorFormCaption: return "组摘要编辑器";//'Group Summary Editor
                case GridStringId.GroupSummaryEditorFormItemsTabCaption: return "项目";//'Items
                case GridStringId.GroupSummaryEditorFormOkButton: return "确定";//'OK
                case GridStringId.GroupSummaryEditorFormOrderTabCaption: return "订单";//'Order
                case GridStringId.GroupSummaryEditorSummaryAverage: return "平均水平";//'Average
                case GridStringId.GroupSummaryEditorSummaryCount: return "计数";//'Count
                case GridStringId.GroupSummaryEditorSummaryMax: return "最大值";//'Max
                case GridStringId.GroupSummaryEditorSummaryMin: return "最小值";//'Min
                case GridStringId.GroupSummaryEditorSummarySum: return "总和";//'Sum
                case GridStringId.LayoutModifiedWarning: return "布局已被更改，确定要保存更改吗？";//'The layout has been modified.\r\nDo you want to save the changes?
                case GridStringId.LayoutViewButtonApply: return "应用(&A)";//'&Apply
                case GridStringId.LayoutViewButtonCancel: return "取消(&C)";//'Cancel
                case GridStringId.LayoutViewButtonCustomizeHide: return "隐藏自定义(&z)";//'Hide Customi&zation
                case GridStringId.LayoutViewButtonCustomizeShow: return "显示自定义(&S)";//'&Show Customization
                case GridStringId.LayoutViewButtonLoadLayout: return "加载面板(&L)...";//'&Load Layout...
                case GridStringId.LayoutViewButtonOk: return "确定(&O)";//'Ok
                case GridStringId.LayoutViewButtonPreview: return "显示更多卡(&M)";//'Show &More Cards
                case GridStringId.LayoutViewButtonReset: return "重置卡模板(&R)";//'&Reset Template Card
                case GridStringId.LayoutViewButtonSaveLayout: return "保存版面...(&v)";//'Sa&ve Layout...
                case GridStringId.LayoutViewButtonShrinkToMinimum: return "收缩卡模板(&S)";//'&Shrink Template Card
                case GridStringId.LayoutViewCardCaptionFormat: return "记录[{0} / {1}]";//'Record [{0} of {1}]
                case GridStringId.LayoutViewCarouselModeBtnHint: return "旋转模式";//'Carousel Mode
                case GridStringId.LayoutViewCloseZoomBtnHintClose: return "还原视图";//'Restore View
                case GridStringId.LayoutViewCloseZoomBtnHintZoom: return "最大化详细信息";//'Maximize Detail
                case GridStringId.LayoutViewColumnModeBtnHint: return "一个栏位";//'One Column
                case GridStringId.LayoutViewCustomizationFormCaption: return "自定义查看面板";//'LayoutView Customization
                case GridStringId.LayoutViewCustomizationFormDescription: return "通过拖放自定义卡面板和菜单，并且可在查看面板中预览数据.";//'Customize the card layout using drag-and-drop and customization menu, and preview data in the View Layout page.
                case GridStringId.LayoutViewCustomizeBtnHint: return "自定义";//'Customization
                case GridStringId.LayoutViewFieldCaptionFormat: return "{0}:";//'{0}:
                case GridStringId.LayoutViewGroupCaptions: return "主题";//'Captions
                case GridStringId.LayoutViewGroupCards: return "卡";//'Cards
                case GridStringId.LayoutViewGroupCustomization: return "自定义";//'Customization
                case GridStringId.LayoutViewGroupFields: return "区域";//'Fields
                case GridStringId.LayoutViewGroupHiddenItems: return "隐藏项";//'Hidden Items
                case GridStringId.LayoutViewGroupIndents: return "缩进";//'Indents
                case GridStringId.LayoutViewGroupIntervals: return "间隔";//'Intervals
                case GridStringId.LayoutViewGroupLayout: return "布局";//'Layout
                case GridStringId.LayoutViewGroupPropertyGrid: return "属性栅格";//'Property Grid
                case GridStringId.LayoutViewGroupTreeStructure: return "树形布局查看";//'Layout Tree View
                case GridStringId.LayoutViewGroupView: return "查看";//'View
                case GridStringId.LayoutViewLabelAllowFieldHotTracking: return "允许热跟踪";//'Allow Hot-Tracking
                case GridStringId.LayoutViewLabelCaptionLocation: return "区域主题位置";//'Field Caption Location:
                case GridStringId.LayoutViewLabelCardArrangeRule: return "排列规则:";//'Arrange Rule:
                case GridStringId.LayoutViewLabelCardEdgeAlignment: return "卡边缘对齐方式:";//'Card Edge Alignment:
                case GridStringId.LayoutViewLabelGroupCaptionLocation: return "组标题位置:";//'Group Caption Location:
                case GridStringId.LayoutViewLabelHorizontal: return "水平间隔";//'Horizontal Interval
                case GridStringId.LayoutViewLabelPadding: return "填充";//'Padding
                case GridStringId.LayoutViewLabelScrollVisibility: return "滚动条可见:";//'Scroll Visibility:
                case GridStringId.LayoutViewLabelShowCardBorder: return "显示边界";//'Show Border
                case GridStringId.LayoutViewLabelShowCardCaption: return "显示标题";//'Show Caption
                case GridStringId.LayoutViewLabelShowCardExpandButton: return "显示展开按钮";//'Show Expand Button
                case GridStringId.LayoutViewLabelShowFieldBorder: return "显示边界";//'Show Border
                case GridStringId.LayoutViewLabelShowFieldHint: return "显示提示";//'Show Hint
                case GridStringId.LayoutViewLabelShowFilterPanel: return "显示过滤面板";//'Show Filter Panel:
                case GridStringId.LayoutViewLabelShowHeaderPanel: return "显示表头面板";//'Show Header Panel
                case GridStringId.LayoutViewLabelShowLines: return "显示线条";//'Show Lines
                case GridStringId.LayoutViewLabelSpacing: return "间距";//'Spacing
                case GridStringId.LayoutViewLabelTextAlignment: return "文本对其方式:";//'Field Caption Text Alignment:
                case GridStringId.LayoutViewLabelTextIndent: return "文本缩进";//'Text Indents
                case GridStringId.LayoutViewLabelVertical: return "垂直间隔";//'Vertical Interval
                case GridStringId.LayoutViewLabelViewMode: return "查看模式";//'View Mode:
                case GridStringId.LayoutViewMultiColumnModeBtnHint: return "多列";//'Multiple Columns
                case GridStringId.LayoutViewMultiRowModeBtnHint: return "多行";//'Multiple Rowss
                case GridStringId.LayoutViewPageTemplateCard: return "模板卡";//'Template Card
                case GridStringId.LayoutViewPageViewLayout: return "查看版面";//'View Layout
                case GridStringId.LayoutViewPanBtnHint: return "面板";//'Panning
                case GridStringId.LayoutViewRowModeBtnHint: return "单行";//'One Row
                case GridStringId.LayoutViewSingleModeBtnHint: return "单卡";//'One card
                case GridStringId.MenuColumnAutoFilterRowHide: return "隐藏自动筛选器行";//'Hide Auto Filter Row
                case GridStringId.MenuColumnAutoFilterRowShow: return "显示自动筛选器行";//'Show Auto Filter Row
                case GridStringId.MenuColumnAverageSummaryTypeDescription: return "平均水平";//'Average
                case GridStringId.MenuColumnBandCustomization: return "列/带选择器";//'Column/Band Chooser
                case GridStringId.MenuColumnBestFit: return "最佳匹配";//'Best Fit
                case GridStringId.MenuColumnBestFitAllColumns: return "最佳匹配(所有列)";//'Best Fit (all columns)
                case GridStringId.MenuColumnClearFilter: return "清除过滤器";//'Clear Filter
                case GridStringId.MenuColumnClearSorting: return "清除排序设置";//'Clear Sorting
                case GridStringId.MenuColumnColumnCustomization: return "列选择";//'Column Chooser
                case GridStringId.MenuColumnCountSummaryTypeDescription: return "计数";//'Count
                case GridStringId.MenuColumnCustomSummaryTypeDescription: return "自定义";//'Custom
                case GridStringId.MenuColumnExpressionEditor: return "表达式编辑器...";//'Expression Editor...
                case GridStringId.MenuColumnFilter: return "允许筛选数据";//'Can Filter
                case GridStringId.MenuColumnFilterEditor: return "设定数据筛选条件";//'Filter Editor...
                case GridStringId.MenuColumnFilterMode: return "筛选模式";//'Filter Mode
                case GridStringId.MenuColumnFilterModeDisplayText: return "显示文本";//'Display Text
                case GridStringId.MenuColumnFilterModeValue: return "价值";//'Value
                case GridStringId.MenuColumnFindFilterHide: return "隐藏查找面板";//'Hide Find Panel
                case GridStringId.MenuColumnFindFilterShow: return "显示查找面板";//'Show Find Panel
                case GridStringId.MenuColumnGroup: return "根据此列分组";//'Group By This Column
                case GridStringId.MenuColumnGroupBox: return "分组依据框";//'Group By Box
                case GridStringId.MenuColumnGroupIntervalDay: return "一天";//'Day
                case GridStringId.MenuColumnGroupIntervalMenu: return "组间隔";//'Group Interval
                case GridStringId.MenuColumnGroupIntervalMonth: return "个月";//'Month
                case GridStringId.MenuColumnGroupIntervalNone: return "无";//'None
                case GridStringId.MenuColumnGroupIntervalSmart: return "智能";//'Smart
                case GridStringId.MenuColumnGroupIntervalYear: return "一年";//'Year
                case GridStringId.MenuColumnGroupSummaryEditor: return "组摘要编辑器...";//'Group Summary Editor...
                case GridStringId.MenuColumnGroupSummarySortFormat: return "{1} 依照 - ;//'{0};//' - {2}";//'{1} by ;//'{0};//' - {2}
                case GridStringId.MenuColumnMaxSummaryTypeDescription: return "最大值";//'Max
                case GridStringId.MenuColumnMinSummaryTypeDescription: return "最小值";//'Min
                case GridStringId.MenuColumnRemoveColumn: return "移除列";//'Remove This Column
                case GridStringId.MenuColumnResetGroupSummarySort: return "清除摘要排序";//'Clear Summary Sorting
                case GridStringId.MenuColumnShowColumn: return "显示列";//'Show This Column
                case GridStringId.MenuColumnSortAscending: return "升序排列";//'Sort Ascending
                case GridStringId.MenuColumnSortDescending: return "降序排列";//'Sort Descending
                case GridStringId.MenuColumnSortGroupBySummaryMenu: return "按摘要排序";//'Sort by Summary
                case GridStringId.MenuColumnSumSummaryTypeDescription: return "总和";//'Sum
                case GridStringId.MenuColumnUnGroup: return "不分组";//'UnGroup
                case GridStringId.MenuFooterAddSummaryItem: return "添加新的汇总";//'Add New Summary
                case GridStringId.MenuFooterAverage: return "平均值";//'Average
                case GridStringId.MenuFooterAverageFormat: return "平均={0:#.##}";//'AVG={0:0.##}
                case GridStringId.MenuFooterClearSummaryItems: return "清除汇总的项目";//'Clear Summary Items
                case GridStringId.MenuFooterCount: return "计数";//'Count
                case GridStringId.MenuFooterCountFormat: return "{0}";//'{0}
                case GridStringId.MenuFooterCountGroupFormat: return "计数={0}";//'Count={0}
                case GridStringId.MenuFooterCustomFormat: return "统计值={0}";//'Custom={0}
                case GridStringId.MenuFooterMax: return "最大值";//'Max
                case GridStringId.MenuFooterMaxFormat: return "最大值={0}";//'MAX={0}
                case GridStringId.MenuFooterMin: return "最小值";//'Min
                case GridStringId.MenuFooterMinFormat: return "最小值={0}";//'MIN={0}
                case GridStringId.MenuFooterNone: return "无";//'None
                case GridStringId.MenuFooterSum: return "和";//'Sum
                case GridStringId.MenuFooterSumFormat: return "和={0:#.##}";//'SUM={0:0.##}
                case GridStringId.MenuGroupPanelClearGrouping: return "清除分组";//'Clear Grouping
                case GridStringId.MenuGroupPanelFullCollapse: return "全部收合";//'Full Collapse
                case GridStringId.MenuGroupPanelFullExpand: return "全部展开";//'Full Expand
                case GridStringId.MenuGroupPanelHide: return "隐藏组框";//'Hide Group By Box
                case GridStringId.MenuGroupPanelShow: return "框显示组";//'Show Group By Box
                case GridStringId.MenuHideSplitItem: return "删除拆分";//'Remove Split
                case GridStringId.MenuShowSplitItem: return "拆分";//'Split
                case GridStringId.PopupFilterAll: return "(全部)";//'(All)
                case GridStringId.PopupFilterBlanks: return "(空白)";//'(Blanks)
                case GridStringId.PopupFilterCustom: return "(自定义)";//'(Custom)
                case GridStringId.PopupFilterNonBlanks: return "(无空白)";//'(Non blanks)
                case GridStringId.PrintDesignerBandedView: return "打印设置 (Banded View)";//'Print Settings (Banded View)
                case GridStringId.PrintDesignerBandHeader: return "起始带宽";//'Band Header
                case GridStringId.PrintDesignerCardView: return "打印设置(卡视图)";//'Print Settings (Card View)
                case GridStringId.PrintDesignerDescription: return "为当前视图设置不同的打印选项";//'Set up various printing options for the current view.
                case GridStringId.PrintDesignerGridView: return "打印设置(网格视图)";//'Print Settings (Grid View)
                case GridStringId.PrintDesignerLayoutView: return "打印设置(版面视图)";//'Print Settings (Layout View)
                case GridStringId.SearchLookUpAddNewButton: return "添加新的";//'Add New
                case GridStringId.SearchLookUpMissingRows: return "";//'
                case GridStringId.ServerRequestError: return "处理服务器的请求 ({0} … …） 的过程中出错";//'Error occurred during processing server request ({0}...)
                case GridStringId.WindowErrorCaption: return "错误";//'Error
                default: return id.ToString();
            }
        }
    }
}