using DevExpress.XtraPrinting.Localization;

namespace SAO.DevHelper.DevCN
{
    /// <summary>
    /// 打印预览控件汉化类
    ///
    /// 20101215 add by Andy
    /// 20140327 mod by lrm 增加了导出及输出图片的描述
    /// </summary>
    public class XtraPrintingCN : PreviewLocalizer
    {
        public override string Language
        {
            get
            {
                return "简体中文";
            }
        }

        public override string GetLocalizedString(PreviewStringId id)
        {
            switch (id)
            {
                case PreviewStringId.BarText_MainMenu: return "主菜单";//'Main Menu
                case PreviewStringId.BarText_StatusBar: return "状态条";//'Status Bar
                case PreviewStringId.BarText_Toolbar: return "工具条";//'Toolbar
                case PreviewStringId.Button_Apply: return "应用";//'Apply
                case PreviewStringId.Button_Cancel: return "取消";//'Cancel
                case PreviewStringId.Button_Help: return "帮助";//'Help
                case PreviewStringId.Button_Ok: return "确定";//'OK
                case PreviewStringId.EMail_From: return "来自";//'From
                case PreviewStringId.ExportOption_ConfirmationDoesNotMatchForm_Msg: return "确认密码不匹配。请从头开始，并再次输入密码。";//'Confirmation password does not match. Please start over and enter the password again.
                case PreviewStringId.ExportOption_ConfirmOpenPasswordForm_Caption: return "确认文档打开密码";//'Confirm Document Open Password
                case PreviewStringId.ExportOption_ConfirmOpenPasswordForm_Name: return "文档打开密码";//'Document Open Pa&ssword:
                case PreviewStringId.ExportOption_ConfirmOpenPasswordForm_Note: return "请确认文档打开密码。请务必记下密码。需要它打开该文档。";//'Please confirm the Document Open Password. Be sure to make a note of the password. It will be required to open the document.
                case PreviewStringId.ExportOption_ConfirmPermissionsPasswordForm_Caption: return "确认密码权限";//'Confirm Permissions Password
                case PreviewStringId.ExportOption_ConfirmPermissionsPasswordForm_Name: return "(&P) 权限密码：";//'&Permissions Password:
                case PreviewStringId.ExportOption_ConfirmPermissionsPasswordForm_Note: return "请确认许可密码。请务必记下密码。你会需要它在将来更改这些设置。";//'Please confirm the Permissions Password. Be sure to make a note of the password. You will need it to change these settings in the future.
                case PreviewStringId.ExportOption_HtmlCharacterSet: return "个性化设置：";//'Character set:
                case PreviewStringId.ExportOption_HtmlEmbedImagesInHTML: return "在 HTML 中嵌入图像";//'Embed images in HTML
                case PreviewStringId.ExportOption_HtmlExportMode: return "输出模式：";//'Export mode:
                case PreviewStringId.ExportOption_HtmlExportMode_DifferentFiles: return "不同的文件";//'Different files
                case PreviewStringId.ExportOption_HtmlExportMode_SingleFile: return "排成一列";//'Single file
                case PreviewStringId.ExportOption_HtmlExportMode_SingleFilePageByPage: return "逐页排成一列";//'Single file page-by-page
                case PreviewStringId.ExportOption_HtmlPageBorderColor: return "页面边界颜色：";//'Page border color:
                case PreviewStringId.ExportOption_HtmlPageBorderWidth: return "页面边界宽度：";//'Page border width:
                case PreviewStringId.ExportOption_HtmlPageRange: return "页面范围：";//'Page range:
                case PreviewStringId.ExportOption_HtmlRemoveSecondarySymbols: return "删除回车";//'Remove carriage returns
                case PreviewStringId.ExportOption_HtmlTitle: return "标题：";//'Title:
                case PreviewStringId.ExportOption_ImageExportMode: return "导出模式：";//'Export mode:
                case PreviewStringId.ExportOption_ImageExportMode_DifferentFiles: return "不同的文件";//'Different files
                case PreviewStringId.ExportOption_ImageExportMode_SingleFile: return "单个文件";//'Single file
                case PreviewStringId.ExportOption_ImageExportMode_SingleFilePageByPage: return "单文件页的页";//'Single file page-by-page
                case PreviewStringId.ExportOption_ImageFormat: return "图象格式：";//'Image format:
                case PreviewStringId.ExportOption_ImagePageBorderColor: return "页面边框颜色：";//'Page border color:
                case PreviewStringId.ExportOption_ImagePageBorderWidth: return "页面边框宽度：";//'Page border width:
                case PreviewStringId.ExportOption_ImagePageRange: return "页面范围：";//'Page range:
                case PreviewStringId.ExportOption_ImageResolution: return "分辨率 （dpi）：";//'Resolution (dpi):
                case PreviewStringId.ExportOption_NativeFormatCompressed: return "压缩格式";//'Compressed
                case PreviewStringId.ExportOption_PdfChangingPermissions_AnyExceptExtractingPages: return "除了提取页面";//'Any except extracting pages
                case PreviewStringId.ExportOption_PdfChangingPermissions_CommentingFillingSigning: return "注释、 填写表单域，和签名的现有签名域";//'Commenting, filling in form fields, and signing existing signature fields
                case PreviewStringId.ExportOption_PdfChangingPermissions_FillingSigning: return "在表单域中填写及签署的现有签名域";//'Filling in form fields and signing existing signature fields
                case PreviewStringId.ExportOption_PdfChangingPermissions_InsertingDeletingRotating: return "插入、 删除和旋转页面";//'Inserting, deleting and rotating pages
                case PreviewStringId.ExportOption_PdfChangingPermissions_None: return "无";//'None
                case PreviewStringId.ExportOption_PdfCompressed: return "压缩格式";//'Compressed
                case PreviewStringId.ExportOption_PdfConvertImagesToJpeg: return "将图像转换为 Jpeg";//'Convert Images to Jpeg
                case PreviewStringId.ExportOption_PdfDocumentApplication: return "应用软件：";//'Application:
                case PreviewStringId.ExportOption_PdfDocumentAuthor: return "作者：";//'Author:
                case PreviewStringId.ExportOption_PdfDocumentKeywords: return "关键字：";//'Keywords:
                case PreviewStringId.ExportOption_PdfDocumentSubject: return "主题：";//'Subject:
                case PreviewStringId.ExportOption_PdfDocumentTitle: return "标题：";//'Title:
                case PreviewStringId.ExportOption_PdfImageQuality: return "图象质量：";//'Images quality:
                case PreviewStringId.ExportOption_PdfImageQuality_High: return "高";//'High
                case PreviewStringId.ExportOption_PdfImageQuality_Highest: return "最高";//'Highest
                case PreviewStringId.ExportOption_PdfImageQuality_Low: return "低";//'Low
                case PreviewStringId.ExportOption_PdfImageQuality_Lowest: return "最低";//'Lowest
                case PreviewStringId.ExportOption_PdfImageQuality_Medium: return "中等";//'Medium
                case PreviewStringId.ExportOption_PdfNeverEmbeddedFonts: return "不插入这些字体：";//'Don;//'t embed these fonts:
                case PreviewStringId.ExportOption_PdfPageRange: return "页面范围：";//'Page range:
                case PreviewStringId.ExportOption_PdfPasswordSecurityOptions: return "安全密码：";//'Password Security:
                case PreviewStringId.ExportOption_PdfPasswordSecurityOptions_DocumentOpenPassword: return "文档打开口令";//'Document Open Password
                case PreviewStringId.ExportOption_PdfPasswordSecurityOptions_None: return "(无)";//'(none)
                case PreviewStringId.ExportOption_PdfPasswordSecurityOptions_Permissions: return "权限";//'Permissions
                case PreviewStringId.ExportOption_PdfPrintingPermissions_HighResolution: return "高分辨率";//'High Resolution
                case PreviewStringId.ExportOption_PdfPrintingPermissions_LowResolution: return "低分辨率 (150 dpi)";//'Low Resolution (150 dpi)
                case PreviewStringId.ExportOption_PdfPrintingPermissions_None: return "无";//'None
                case PreviewStringId.ExportOption_PdfShowPrintDialogOnOpen: return "打开显示打印对话框";//'Show print dialog on open
                case PreviewStringId.ExportOption_RtfExportMode: return "导出模式：";//'Export mode:
                case PreviewStringId.ExportOption_RtfExportMode_SingleFile: return "单个文件";//'Single file
                case PreviewStringId.ExportOption_RtfExportMode_SingleFilePageByPage: return "单文件页的页";//'Single file page-by-page
                case PreviewStringId.ExportOption_RtfExportWatermarks: return "出口水印";//'Export watermarks
                case PreviewStringId.ExportOption_RtfPageRange: return "页面范围：";//'Page range:
                case PreviewStringId.ExportOption_TextEncoding: return "编码：";//'Encoding:
                case PreviewStringId.ExportOption_TextExportMode: return "文本导出模式：";//'Text export mode:
                case PreviewStringId.ExportOption_TextExportMode_Text: return "文本";//'Text
                case PreviewStringId.ExportOption_TextExportMode_Value: return "价值";//'Value
                case PreviewStringId.ExportOption_TextQuoteStringsWithSeparators: return "引号字符串分隔符";//'Quote strings with separators
                case PreviewStringId.ExportOption_TextSeparator: return "文本分隔器：";//'Text separator:
                case PreviewStringId.ExportOption_TextSeparator_TabAlias: return "TAB";//'TAB
                case PreviewStringId.ExportOption_XlsExportHyperlinks: return "出口超链接";//'Export hyperlinks
                case PreviewStringId.ExportOption_XlsExportMode: return "导出模式：";//'Export mode:
                case PreviewStringId.ExportOption_XlsExportMode_DifferentFiles: return "不同的文件";//'Different files
                case PreviewStringId.ExportOption_XlsExportMode_SingleFile: return "单个文件";//'Single file
                case PreviewStringId.ExportOption_XlsPageRange: return "页面范围：";//'Page range:
                case PreviewStringId.ExportOption_XlsSheetName: return "工作表的名称：";//'Sheet name:
                case PreviewStringId.ExportOption_XlsShowGridLines: return "显示栅格线";//'Show grid lines
                case PreviewStringId.ExportOption_XlsUseNativeFormat: return "以相应格式输出值";//'Export values using their format
                case PreviewStringId.ExportOption_XlsxExportMode: return "导出模式：";//'Export mode:
                case PreviewStringId.ExportOption_XlsxExportMode_DifferentFiles: return "不同的文件";//'Different files
                case PreviewStringId.ExportOption_XlsxExportMode_SingleFile: return "单个文件";//'Single file
                case PreviewStringId.ExportOption_XlsxExportMode_SingleFilePageByPage: return "单文件页的页";//'Single file page-by-page
                case PreviewStringId.ExportOption_XlsxPageRange: return "页面范围：";//'Page range:
                case PreviewStringId.ExportOption_XpsCompression: return "压缩：";//'Compression:
                case PreviewStringId.ExportOption_XpsCompression_Fast: return "快速";//'Fast
                case PreviewStringId.ExportOption_XpsCompression_Maximum: return "最大值";//'Maximum
                case PreviewStringId.ExportOption_XpsCompression_Normal: return "正常";//'Normal
                case PreviewStringId.ExportOption_XpsCompression_NotCompressed: return "不压缩";//'Not compressed
                case PreviewStringId.ExportOption_XpsCompression_SuperFast: return "超级快";//'Super fast
                case PreviewStringId.ExportOption_XpsDocumentCategory: return "类别：";//'Category:
                case PreviewStringId.ExportOption_XpsDocumentCreator: return "创建者:";//'Creator:
                case PreviewStringId.ExportOption_XpsDocumentDescription: return "说明：";//'Description:
                case PreviewStringId.ExportOption_XpsDocumentKeywords: return "关键字：";//'Keywords:
                case PreviewStringId.ExportOption_XpsDocumentSubject: return "主题：";//'Subject:
                case PreviewStringId.ExportOption_XpsDocumentTitle: return "标题:";//'Title:
                case PreviewStringId.ExportOption_XpsDocumentVersion: return "版本：";//'Version:
                case PreviewStringId.ExportOption_XpsPageRange: return "页面范围：";//'Page range:
                case PreviewStringId.ExportOptionsForm_CaptionCsv: return "Csv输出选项";//'CSV Export Options
                case PreviewStringId.ExportOptionsForm_CaptionHtml: return "Html输出选项";//'HTML Export Options
                case PreviewStringId.ExportOptionsForm_CaptionImage: return "图象输出选项";//'Image Export Options
                case PreviewStringId.ExportOptionsForm_CaptionMht: return "Mht输出选项";//'MHT Export Options
                case PreviewStringId.ExportOptionsForm_CaptionNativeOptions: return "原有格式选项";//'Native Format Options
                case PreviewStringId.ExportOptionsForm_CaptionPdf: return "Pdf输出选项";//'PDF Export Options
                case PreviewStringId.ExportOptionsForm_CaptionRtf: return "Rtf输出选项";//'RTF Export Options
                case PreviewStringId.ExportOptionsForm_CaptionTxt: return "文本输出选项";//'Text Export Options
                case PreviewStringId.ExportOptionsForm_CaptionXls: return "Xls输出选项";//'XLS Export Options
                case PreviewStringId.ExportOptionsForm_CaptionXlsx: return "XLSX 导出选项";//'XLSX Export Options
                case PreviewStringId.ExportOptionsForm_CaptionXps: return "XPS 导出选项";//'XPS Export Options
                case PreviewStringId.FolderBrowseDlg_ExportDirectory: return "选择一个文件夹保存输出文档：";//'Select a folder to save the exported document to:
                case PreviewStringId.Margin_BottomMargin: return "下页边距";//'Bottom Margin
                case PreviewStringId.Margin_Inch: return "英寸";//'Inch
                case PreviewStringId.Margin_LeftMargin: return "左页边距";//'Left Margin
                case PreviewStringId.Margin_Millimeter: return "毫米";//'mm
                case PreviewStringId.Margin_RightMargin: return "右页边距";//'Right Margin
                case PreviewStringId.Margin_TopMargin: return "上页边距";//'Top Margin
                case PreviewStringId.MenuItem_BackgrColor: return "颜色...";//'&Color...
                case PreviewStringId.MenuItem_Background: return "背景...";//'&Background
                case PreviewStringId.MenuItem_CsvDocument: return "CSV文件";//'CSV File
                case PreviewStringId.MenuItem_Exit: return "退出";//'E&xit
                case PreviewStringId.MenuItem_Export: return "输出到";//'&Export To
                case PreviewStringId.MenuItem_File: return "文件";//'&File
                case PreviewStringId.MenuItem_GraphicDocument: return "图象文件";//'Image File
                case PreviewStringId.MenuItem_HtmDocument: return "HTML文件";//'HTML File
                case PreviewStringId.MenuItem_MhtDocument: return "MHT文件";//'MHT File
                case PreviewStringId.MenuItem_PageLayout: return "页面布局";//'&Page Layout
                case PreviewStringId.MenuItem_PageSetup: return "页面调整";//'Page Set&up...
                case PreviewStringId.MenuItem_PdfDocument: return "PDF文件";//'PDF File
                case PreviewStringId.MenuItem_Print: return "打印...";//'&Print...
                case PreviewStringId.MenuItem_PrintDirect: return "打印";//'P&rint
                case PreviewStringId.MenuItem_RtfDocument: return "RTF文件";//'RTF File
                case PreviewStringId.MenuItem_Send: return "以...格式发送";//'Sen&d As
                case PreviewStringId.MenuItem_TxtDocument: return "文本文件";//'Text File
                case PreviewStringId.MenuItem_View: return "视图";//'&View
                case PreviewStringId.MenuItem_ViewContinuous: return "继续";//'&Continuous
                case PreviewStringId.MenuItem_ViewFacing: return "朝向";//'&Facing
                case PreviewStringId.MenuItem_ViewStatusbar: return "状态条";//'&Statusbar
                case PreviewStringId.MenuItem_ViewToolbar: return "工具条";//'&Toolbar
                case PreviewStringId.MenuItem_Watermark: return "水印...";//'&Watermark...
                case PreviewStringId.MenuItem_XlsDocument: return "Excel文件";//'XLS File
                case PreviewStringId.MenuItem_XlsxDocument: return "XLSX 文件";//'XLSX File
                case PreviewStringId.MenuItem_ZoomPageWidth: return "页面宽度";//'Page Width
                case PreviewStringId.MenuItem_ZoomTextWidth: return "文本宽度";//'Text Width
                case PreviewStringId.MenuItem_ZoomTwoPages: return "两页";//'Two Pages
                case PreviewStringId.MenuItem_ZoomWholePage: return "整个页面";//'Whole Page
                case PreviewStringId.MPForm_Lbl_Pages: return "页面";//'Pages
                case PreviewStringId.Msg_BigBitmapToCreate: return "输出文件过大。请尝试减少图像分辨率，或选择另一个出口模式。";//'The output file is too big. Please try to reduce the image resolution,  or choose another export mode.
                case PreviewStringId.Msg_BigFileToCreate: return "输出文件过大。尽量减少它的页数，或将它拆分成多个文档。";//'The output file is too big. Try to reduce the number of its pages, or split it into several documents.
                case PreviewStringId.Msg_BigFileToCreateJPEG: return "输出文件是创建一个 JPEG 文件太大。请选择另一个图像格式或另一个出口模式。";//'The output file is too big to create a JPEG file. Please choose another image format or another export mode.
                case PreviewStringId.Msg_CannotAccessFile: return "这个进程无法读取文件;//'{0};//'，因为它正在被另一个进程使用。";//'The process cannot access the file "{0}" because it is being used by another process.
                case PreviewStringId.Msg_CannotLoadDocument: return "无法加载指定的文件，因为它不包含有效的 XML 数据或者超过了允许的大小。";//'The specified file cannot be loaded, because it either does not contain valid XML data or exceeds the allowed size.
                case PreviewStringId.Msg_CantFitBarcodeToControlBounds: return "控件太小无法显示条码。";//'Control;//'s boundaries are too small for the barcode
                case PreviewStringId.Msg_Caption: return "打印";//'Printing
                case PreviewStringId.Msg_CreatingDocument: return "建立文档...";//'Creating the document...
                case PreviewStringId.Msg_CustomDrawWarning: return "警告！";//'Warning!
                case PreviewStringId.Msg_EmptyDocument: return "该文档不包含任何页。";//'The document does not contain any pages.
                case PreviewStringId.Msg_FileDoesNotContainValidXml: return "指定的文件不包含有效的 XML 数据中的 PRNX 格式。停止加载。";//'The specified file doesn;//'t contain valid XML data in the PRNX format. Loading is stopped.
                case PreviewStringId.Msg_FileDoesNotHavePrnxExtention: return "指定的文件没有扩展名为 PRNX。继续做下去吗？";//'The specified file doesn;//'t have a PRNX extension. Proceed anyway?
                case PreviewStringId.Msg_FileReadOnly: return "文件;//'{0};//'被设置为只读，再试一次使用不同的文件名。";//'File "{0}" is set to read-only, try again with a different file name.
                case PreviewStringId.Msg_FontInvalidNumber: return "字体大小不能设置为0或者负数。";//'The font size cannot be set to zero or a negative number
                case PreviewStringId.Msg_GoToNonExistentPage: return "没有编号 {0} 本文档中的页。";//'There is no page numbered {0} in this document.
                case PreviewStringId.Msg_IncorrectPageRange: return "这不是有效的页面范围";//'This is not a valid page range
                case PreviewStringId.Msg_IncorrectZoomFactor: return "数字大小必须界于{0}，{1}之间。";//'The number must be between {0} and {1}.
                case PreviewStringId.Msg_InvalidBarcodeData: return "不能超过 1033 个字节的二进制数据。";//'Binary data can;//'t be longer than 1033 bytes.
                case PreviewStringId.Msg_InvalidBarcodeText: return "文本中有无效字符。";//'There are invalid characters in the text
                case PreviewStringId.Msg_InvalidBarcodeTextFormat: return "无效的文本格式";//'Invalid text format
                case PreviewStringId.Msg_InvalidMeasurement: return "这不是一个有效的度量值。";//'This is not a valid measurement.
                case PreviewStringId.Msg_NeedPrinter: return "没有安装打印机。";//'No printers installed.
                case PreviewStringId.Msg_NoDifferentFilesInStream: return "文档无法导出到流中的 DifferentFiles 模式。而是使用 SingleFile 或 SingleFilePageByPage 模式。";//'A document can;//'t be exported to a stream in the DifferentFiles mode. Use the SingleFile or SingleFilePageByPage mode instead.
                case PreviewStringId.Msg_NoParameters: return "不存在指定的参数： {0}。";//'The specified parameters does not exist: {0}.
                case PreviewStringId.Msg_NotSupportedFont: return "尚不支持该字体";//'This font is not yet supported
                case PreviewStringId.Msg_OpenFileQuestion: return "你想打开该文件吗？";//'Do you want to open this file?
                case PreviewStringId.Msg_OpenFileQuestionCaption: return "输出";//'Export
                case PreviewStringId.Msg_PageMarginsWarning: return "一个或多个页边距被设置到也可打印的页面范围之外，是否要继续？";//'One or more margins are set outside the printable area of the page. Continue?
                case PreviewStringId.Msg_PathTooLong: return "路径过长。尝试较短的名称。";//'The path is too long.  Try a shorter name.
                case PreviewStringId.Msg_SearchDialogFinishedSearching: return "完成对整个文档的搜索";//'Finished searching through the document
                case PreviewStringId.Msg_SearchDialogReady: return "准备就绪";//'Ready
                case PreviewStringId.Msg_SearchDialogTotalFound: return "总共发现：";//'Total found:
                case PreviewStringId.Msg_UnavailableNetPrinter: return "网络打印机无法使用。";//'The net printer is unavailable.
                case PreviewStringId.Msg_WrongPageSettings: return "当前打印机不支持所选择页面大小。一定要继续吗？";//'The current printer doesn;//'t support the selected paper size.  Proceed with printing anyway?
                case PreviewStringId.Msg_WrongPrinter: return "打印机的名字是无效的。请检查打印机的设置。";//'The printer name is invalid. Please check the printer settings.
                case PreviewStringId.Msg_WrongPrinting: return "在打印文档时出错。";//'An error occurred during printing a document.
                case PreviewStringId.Msg_XlsMoreThanMaxColumns: return "创建的 XLS 文件是 XLS 格式，太大的因为它包含超过 256 列。请尝试使用中兑换 XLSX 格式，来代替。";//'The created XLS file is too big for the XLS format, because it contains more than 256 columns.  Please try to use the XLSX format, instead.
                case PreviewStringId.Msg_XlsMoreThanMaxRows: return "创建的 XLS 文件是 XLS 格式，太大的因为它包含超过 65536 行。请尝试使用中兑换 XLSX 格式，来代替。";//'The created XLS file is too big for the XLS format, because it contains more than 65,536 rows.  Please try to use the XLSX format, instead.
                case PreviewStringId.Msg_XlsxMoreThanMaxColumns: return "创建中兑换 XLSX 文件是中兑换 XLSX 格式，太大的因为它包含多个 16384 列。请尝试减少您的报表中的列的数量，并再次将报表导出到中兑换 XLSX。";//'The created XLSX file is too big for the XLSX format, because it contains more than 16,384 columns.  Please try to reduce the amount of columns in your report and export the report to XLSX again.
                case PreviewStringId.Msg_XlsxMoreThanMaxRows: return "创建中兑换 XLSX 文件是 XLSX 格式，太大的因为它包含多个 1048576 行。请尝试减少您的报表中的行并再次将报表导出到 XLSX。";//'The created XLSX file is too big for the XLSX format, because it contains more than 1,048,576 rows.  Please try to reduce the amount of rows in your report and export the report to XLSX again.
                case PreviewStringId.OpenFileDialog_Filter: return "预览文档文件 （* {0})|* {0} 所有文件 (*.*） ;//' *.*";//'Preview Document Files (*{0})|*{0};//'All Files (*.*)|*.*
                case PreviewStringId.OpenFileDialog_Title: return "打开";//'Open
                case PreviewStringId.PageInfo_PageDate: return "[已打印数据]";//'[Date Printed]
                case PreviewStringId.PageInfo_PageNumber: return "[第 # 页]";//'[Page #]
                case PreviewStringId.PageInfo_PageNumberOfTotal: return "[第 # 页，共 # 页]";//'[Page # of Pages #]
                case PreviewStringId.PageInfo_PageTime: return "[打印耗时]";//'[Time Printed]
                case PreviewStringId.PageInfo_PageUserName: return "[用户名]";//'[User Name]
                case PreviewStringId.ParametersRequest_Caption: return "参数";//'Parameters
                case PreviewStringId.ParametersRequest_Reset: return "重置";//'Reset
                case PreviewStringId.ParametersRequest_Submit: return "提交";//'Submit
                case PreviewStringId.PreviewForm_Caption: return "预览";//'Preview
                case PreviewStringId.RibbonPreview_ClosePreview_Caption: return "关闭打印预览";//'Close Print Preview
                case PreviewStringId.RibbonPreview_ClosePreview_STipContent: return "关闭该文档的打印预览";//'Close Print Preview of the document.
                case PreviewStringId.RibbonPreview_ClosePreview_STipTitle: return "关闭打印预览";//'Close Print Preview
                case PreviewStringId.RibbonPreview_Customize_Caption: return "选项";//'Options
                case PreviewStringId.RibbonPreview_Customize_STipContent: return "打开可打印的组件编辑器对话框，并可以改变打印选项。";//'Open the Print Options dialog, in which you can change printing options.
                case PreviewStringId.RibbonPreview_Customize_STipTitle: return "选项";//'Options
                case PreviewStringId.RibbonPreview_DocumentMap_Caption: return "书签";//'Bookmarks
                case PreviewStringId.RibbonPreview_DocumentMap_STipContent: return "打开文档结构图为你导航文档的结构。";//'Open the Document Map, which allows you to navigate through a structural view of the document.
                case PreviewStringId.RibbonPreview_DocumentMap_STipTitle: return "文档结构图";//'Document Map
                case PreviewStringId.RibbonPreview_EditPageHF_Caption: return "页眉/页脚";//'Header/Footer
                case PreviewStringId.RibbonPreview_EditPageHF_STipContent: return "编辑该文档的页眉和页脚";//'Edit the header and footer of the document.
                case PreviewStringId.RibbonPreview_EditPageHF_STipTitle: return "页眉和页脚";//'Header and Footer
                case PreviewStringId.RibbonPreview_ExportCsv_Caption: return "CSV文件";//'CSV File
                case PreviewStringId.RibbonPreview_ExportCsv_Description: return "逗号分隔值文本";//'Comma-Separated Values Text
                case PreviewStringId.RibbonPreview_ExportCsv_STipContent: return "将该文档以CSV格式输出并保存到磁盘文件上。";//'Export the document to CSV and save it to the file on a disk.
                case PreviewStringId.RibbonPreview_ExportCsv_STipTitle: return "以CSV格式输出";//'Export to CSV
                case PreviewStringId.RibbonPreview_ExportFile_Caption: return "输出";//'Export To
                case PreviewStringId.RibbonPreview_ExportFile_STipContent: return "将当前文档以一个可用的格式输出，并将其保存到磁盘文件上。";//'Export the current document in one of the available formats, and save it to the file on a disk.
                case PreviewStringId.RibbonPreview_ExportFile_STipTitle: return "输出...";//'Export To...
                case PreviewStringId.RibbonPreview_ExportGraphic_Caption: return "图象文件";//'Image File
                case PreviewStringId.RibbonPreview_ExportGraphic_Description: return "BMP, GIF, JPEG, PNG, TIFF, EMF, WMF";//'BMP, GIF, JPEG, PNG, TIFF, EMF, WMF
                case PreviewStringId.RibbonPreview_ExportGraphic_STipContent: return "将该文档以图象格式输出并保存到磁盘文件上。";//'Export the document to Image and save it to the file on a disk.
                case PreviewStringId.RibbonPreview_ExportGraphic_STipTitle: return "以图象格式输出";//'Export to Image
                case PreviewStringId.RibbonPreview_ExportHtm_Caption: return "HTML文件";//'HTML File
                case PreviewStringId.RibbonPreview_ExportHtm_Description: return "Web页面";//'Web Page
                case PreviewStringId.RibbonPreview_ExportHtm_STipContent: return "将该文档以HTML格式输出并保存到磁盘文件上。";//'Export the document to HTML and save it to the file on a disk.
                case PreviewStringId.RibbonPreview_ExportHtm_STipTitle: return "以HTML格式输出";//'Export to HTML
                case PreviewStringId.RibbonPreview_ExportMht_Caption: return "MHT文件";//'MHT File
                case PreviewStringId.RibbonPreview_ExportMht_Description: return "单一文件的Web页";//'Single File Web Page
                case PreviewStringId.RibbonPreview_ExportMht_STipContent: return "将该文档以MHT格式输出并保存到磁盘文件上。";//'Export the document to MHT and save it to the file on a disk.
                case PreviewStringId.RibbonPreview_ExportMht_STipTitle: return "以MHT格式输出";//'Export to MHT
                case PreviewStringId.RibbonPreview_ExportPdf_Caption: return "PDF文件";//'PDF File
                case PreviewStringId.RibbonPreview_ExportPdf_Description: return "Adobe便携式文档格式";//'Adobe Portable Document Format
                case PreviewStringId.RibbonPreview_ExportPdf_STipContent: return "将该文档以PDF格式输出并保存到磁盘文件上。";//'Export the document to PDF and save it to the file on a disk.
                case PreviewStringId.RibbonPreview_ExportPdf_STipTitle: return "以PDF格式输出";//'Export to PDF
                case PreviewStringId.RibbonPreview_ExportRtf_Caption: return "RTF文件";//'RTF File
                case PreviewStringId.RibbonPreview_ExportRtf_Description: return "多本文格式";//'Rich Text Format
                case PreviewStringId.RibbonPreview_ExportRtf_STipContent: return "将该文档以RTF格式输出并保存到磁盘文件上。";//'Export the document to RTF and save it to the file on a disk.
                case PreviewStringId.RibbonPreview_ExportRtf_STipTitle: return "以RTF格式输出";//'Export to RTF
                case PreviewStringId.RibbonPreview_ExportTxt_Caption: return "文本文件";//'Text File
                case PreviewStringId.RibbonPreview_ExportTxt_Description: return "纯文本";//'Plain Text
                case PreviewStringId.RibbonPreview_ExportTxt_STipContent: return "将该文档以文本格式输出并保存到磁盘文件上。";//'Export the document to Text and save it to the file on a disk.
                case PreviewStringId.RibbonPreview_ExportTxt_STipTitle: return "以文本格式输出";//'Export to Text
                case PreviewStringId.RibbonPreview_ExportXls_Caption: return "Excel文件";//'XLS File
                case PreviewStringId.RibbonPreview_ExportXls_Description: return "Microsoft Excel工作薄";//'Microsoft Excel 2000-2003 Workbook
                case PreviewStringId.RibbonPreview_ExportXls_STipContent: return "将该文档以XLS格式输出并保存到磁盘文件上。";//'Export the document to XLS and save it to the file on a disk.
                case PreviewStringId.RibbonPreview_ExportXls_STipTitle: return "以XLS格式输出";//'Export to XLS
                case PreviewStringId.RibbonPreview_ExportXlsx_Caption: return "XLSX 文件";//'XLSX File
                case PreviewStringId.RibbonPreview_ExportXlsx_Description: return "Microsoft Excel 2007 工作簿";//'Microsoft Excel 2007 Workbook
                case PreviewStringId.RibbonPreview_ExportXlsx_STipContent: return "将文档导出到XLSX，并将其保存到磁盘上的文件。";//'Export the document to XLSX and save it to the file on a disk.
                case PreviewStringId.RibbonPreview_ExportXlsx_STipTitle: return "导出到XLSX";//'Export to XLSX
                case PreviewStringId.RibbonPreview_ExportXps_Caption: return "XPS 文件";//'XPS File
                case PreviewStringId.RibbonPreview_ExportXps_Description: return "XPS";//'XPS
                case PreviewStringId.RibbonPreview_FillBackground_Caption: return "页面颜色";//'Page Color
                case PreviewStringId.RibbonPreview_FillBackground_STipContent: return "为文档页面背景选择颜色。";//'Choose a color for the background of the document pages.
                case PreviewStringId.RibbonPreview_FillBackground_STipTitle: return "背景颜色";//'Background Color
                case PreviewStringId.RibbonPreview_Find_Caption: return "查找";//'Find
                case PreviewStringId.RibbonPreview_Find_STipContent: return "显示查找对话框，查找文档中的文本。";//'Show the Find dialog to find text in the document.
                case PreviewStringId.RibbonPreview_Find_STipTitle: return "查找";//'Find
                case PreviewStringId.RibbonPreview_GalleryItem_PageMargins_Description: return "上:  {0}  下:  {1}  左:   {2}  右:     {3}";//'Top:  {0}  Bottom:  {1}  Left:   {2}  Right:     {3}
                case PreviewStringId.RibbonPreview_GalleryItem_PageMarginsModerate_Caption: return "中等";//'Moderate
                case PreviewStringId.RibbonPreview_GalleryItem_PageMarginsModerate_Description: return "中等";//'Moderate
                case PreviewStringId.RibbonPreview_GalleryItem_PageMarginsNarrow_Caption: return "窄";//'Narrow
                case PreviewStringId.RibbonPreview_GalleryItem_PageMarginsNarrow_Description: return "窄";//'Narrow
                case PreviewStringId.RibbonPreview_GalleryItem_PageMarginsNormal_Caption: return "正常";//'Normal
                case PreviewStringId.RibbonPreview_GalleryItem_PageMarginsNormal_Description: return "正常";//'Normal
                case PreviewStringId.RibbonPreview_GalleryItem_PageMarginsWide_Caption: return "宽";//'Wide
                case PreviewStringId.RibbonPreview_GalleryItem_PageMarginsWide_Description: return "宽";//'Wide
                case PreviewStringId.RibbonPreview_GalleryItem_PageOrientationLandscape_Caption: return "横向";//'Landscape
                case PreviewStringId.RibbonPreview_GalleryItem_PageOrientationLandscape_Description: return "";//'
                case PreviewStringId.RibbonPreview_GalleryItem_PageOrientationPortrait_Caption: return "纵向";//'Portrait
                case PreviewStringId.RibbonPreview_GalleryItem_PageOrientationPortrait_Description: return "";//'
                case PreviewStringId.RibbonPreview_GalleryItem_PaperSize_Description: return "{0} x {1}";//'{0} x {1}
                case PreviewStringId.RibbonPreview_HandTool_Caption: return "抓取工具";//'Hand Tool
                case PreviewStringId.RibbonPreview_HandTool_STipContent: return "调用抓取工具手动拖拽查看页面。";//'Invoke the Hand tool to manually scroll through pages.
                case PreviewStringId.RibbonPreview_HandTool_STipTitle: return "抓取工具";//'Hand Tool
                case PreviewStringId.RibbonPreview_Magnifier_Caption: return "放大";//'Magnifier
                case PreviewStringId.RibbonPreview_Magnifier_STipContent: return "调用放大镜工具";//'Invoke the Magnifier tool.    Clicking once on a document zooms it so that a single page becomes entirely visible, while clicking another time zooms it to 100% of the normal size.
                case PreviewStringId.RibbonPreview_Magnifier_STipTitle: return "放大镜";//'Magnifier
                case PreviewStringId.RibbonPreview_MultiplePages_Caption: return "多页";//'Many Pages
                case PreviewStringId.RibbonPreview_MultiplePages_STipContent: return "选择页面布局以便在预览中排放文档页面。";//'Choose the page layout to arrange the document pages in preview.
                case PreviewStringId.RibbonPreview_MultiplePages_STipTitle: return "多页查看";//'View Many Pages
                case PreviewStringId.RibbonPreview_Open_Caption: return "打开";//'Open
                case PreviewStringId.RibbonPreview_Open_STipContent: return "打开文档。";//'Open a document.
                case PreviewStringId.RibbonPreview_Open_STipTitle: return "打开 (Ctrl + O)";//'Open (Ctrl + O)
                case PreviewStringId.RibbonPreview_PageGroup_Background: return "页面背景";//'Page Background
                case PreviewStringId.RibbonPreview_PageGroup_Document: return "文档";//'Document
                case PreviewStringId.RibbonPreview_PageGroup_Export: return "输出";//'Export
                case PreviewStringId.RibbonPreview_PageGroup_Navigation: return "导航";//'Navigation
                case PreviewStringId.RibbonPreview_PageGroup_PageSetup: return "页面调整";//'Page Setup
                case PreviewStringId.RibbonPreview_PageGroup_PageSetup_STipContent: return "显示页面调整对话框。";//'Show the Page Setup dialog.
                case PreviewStringId.RibbonPreview_PageGroup_PageSetup_STipTitle: return "页面调整";//'Page Setup
                case PreviewStringId.RibbonPreview_PageGroup_Print: return "打印";//'Print
                case PreviewStringId.RibbonPreview_PageGroup_Zoom: return "缩放";//'Zoom
                case PreviewStringId.RibbonPreview_PageMargins_Caption: return "页边距";//'Margins
                case PreviewStringId.RibbonPreview_PageMargins_STipContent: return "为整个文档选择页边距大小。点击定制页边距为文档应用指定的页边距大小。";//'Select the margin sizes for the entire document.    To apply specific margin sizes to the document, click Custom Margins.
                case PreviewStringId.RibbonPreview_PageMargins_STipTitle: return "页边距";//'Page Margins
                case PreviewStringId.RibbonPreview_PageOrientation_Caption: return "方位";//'Orientation
                case PreviewStringId.RibbonPreview_PageOrientation_STipContent: return "在纵向和横向布局之间转换页面。";//'Switch the pages between portrait and landscape layouts.
                case PreviewStringId.RibbonPreview_PageOrientation_STipTitle: return "页面方向";//'Page Orientation
                case PreviewStringId.RibbonPreview_PageSetup_Caption: return "定制页边距...";//'Custom Margins...
                case PreviewStringId.RibbonPreview_PageSetup_STipContent: return "显示页面调整对话框。";//'Show the Page Setup dialog.
                case PreviewStringId.RibbonPreview_PageSetup_STipTitle: return "页面调整";//'Page Setup
                case PreviewStringId.RibbonPreview_PageText: return "打印预览";//'Print Preview
                case PreviewStringId.RibbonPreview_PaperSize_Caption: return "大小";//'Size
                case PreviewStringId.RibbonPreview_PaperSize_STipContent: return "选择文档的页面大小。";//'Choose the paper size of the document.
                case PreviewStringId.RibbonPreview_PaperSize_STipTitle: return "页面大小";//'Page Size
                case PreviewStringId.RibbonPreview_Parameters_Caption: return "参数";//'Parameters
                case PreviewStringId.RibbonPreview_Parameters_STipContent: return "打开参数窗格中，允许您为报表参数输入值。";//'Open the Parameters pane, which allows you to enter values for report parameters.
                case PreviewStringId.RibbonPreview_Parameters_STipTitle: return "参数";//'Parameters
                case PreviewStringId.RibbonPreview_Pointer_Caption: return "指针";//'Pointer
                case PreviewStringId.RibbonPreview_Pointer_STipContent: return "显示鼠标指针。";//'Show the mouse pointer.
                case PreviewStringId.RibbonPreview_Pointer_STipTitle: return "鼠标指针";//'Mouse Pointer
                case PreviewStringId.RibbonPreview_Print_Caption: return "打印";//'Print
                case PreviewStringId.RibbonPreview_Print_STipContent: return "在打印前选择打印机，打印份数以及其他打印选项。";//'Select a printer, number of copies and other printing options before printing.
                case PreviewStringId.RibbonPreview_Print_STipTitle: return "打印(Ctrl+P)";//'Print (Ctrl+P)
                case PreviewStringId.RibbonPreview_PrintDirect_Caption: return "快速打印";//'Quick Print
                case PreviewStringId.RibbonPreview_PrintDirect_STipContent: return "将文档不作任何修改直接送往默认打印机。";//'Send the document directly to the default printer without making changes.
                case PreviewStringId.RibbonPreview_PrintDirect_STipTitle: return "快速打印";//'Quick Print
                case PreviewStringId.RibbonPreview_Save_Caption: return "保存";//'Save
                case PreviewStringId.RibbonPreview_Save_STipContent: return "保存该文档。";//'Save the document.
                case PreviewStringId.RibbonPreview_Save_STipTitle: return "保存 (Ctrl + S)";//'Save (Ctrl + S)
                case PreviewStringId.RibbonPreview_Scale_Caption: return "比例";//'Scale
                case PreviewStringId.RibbonPreview_Scale_STipContent: return "按实际大小的百分比伸展或收缩打印输出。";//'Stretch or shrink the printed output to a percentage of its actual size.
                case PreviewStringId.RibbonPreview_Scale_STipTitle: return "比例";//'Scale
                case PreviewStringId.RibbonPreview_SendCsv_Caption: return "CSV文件";//'CSV File
                case PreviewStringId.RibbonPreview_SendCsv_Description: return "逗号分隔值文本";//'Comma-Separated Values Text
                case PreviewStringId.RibbonPreview_SendCsv_STipContent: return "以CSV格式输出文档，并且将其附到电子邮件中。";//'Export the document to CSV and attach it to the e-mail.
                case PreviewStringId.RibbonPreview_SendCsv_STipTitle: return "在电子邮件中以CSV格式发送";//'E-Mail As CSV
                case PreviewStringId.RibbonPreview_SendFile_Caption: return "在电子邮件中以...格式发送";//'E-Mail As
                case PreviewStringId.RibbonPreview_SendFile_STipContent: return "以一种可用格式输出当前文档，并且将其附到电子邮件中。";//'Export the current document in one of the available formats, and attach it to the e-mail.
                case PreviewStringId.RibbonPreview_SendFile_STipTitle: return "在电子邮件中以...格式发送";//'E-Mail As...
                case PreviewStringId.RibbonPreview_SendGraphic_Caption: return "图象文件";//'Image File
                case PreviewStringId.RibbonPreview_SendGraphic_Description: return "BMP, GIF, JPEG, PNG, TIFF, EMF, WMF";//'BMP, GIF, JPEG, PNG, TIFF, EMF, WMF
                case PreviewStringId.RibbonPreview_SendGraphic_STipContent: return "以图象格式输出文档，并且将其附到电子邮件中。";//'Export the document to Image and attach it to the e-mail.
                case PreviewStringId.RibbonPreview_SendGraphic_STipTitle: return "在电子邮件中以图象格式发送";//'E-Mail As Image
                case PreviewStringId.RibbonPreview_SendMht_Caption: return "MHT文件";//'MHT File
                case PreviewStringId.RibbonPreview_SendMht_Description: return "单文件网页";//'Single File Web Page
                case PreviewStringId.RibbonPreview_SendMht_STipContent: return "以MHT格式输出文档，并且将其附到电子邮件中。";//'Export the document to MHT and attach it to the e-mail.
                case PreviewStringId.RibbonPreview_SendMht_STipTitle: return "在电子邮件中以MHT格式发送";//'E-Mail As MHT
                case PreviewStringId.RibbonPreview_SendPdf_Caption: return "PDF文件";//'PDF File
                case PreviewStringId.RibbonPreview_SendPdf_Description: return "Adobe便携式文档格式";//'Adobe Portable Document Format
                case PreviewStringId.RibbonPreview_SendPdf_STipContent: return "以PDF格式输出文档，并且将其附到电子邮件中。";//'Export the document to PDF and attach it to the e-mail.
                case PreviewStringId.RibbonPreview_SendPdf_STipTitle: return "在电子邮件中以PDF格式发送";//'E-Mail As PDF
                case PreviewStringId.RibbonPreview_SendRtf_Caption: return "RTF文件";//'RTF File
                case PreviewStringId.RibbonPreview_SendRtf_Description: return "多文本格式";//'Rich Text Format
                case PreviewStringId.RibbonPreview_SendRtf_STipContent: return "以RTF格式输出文档，并且将其附到电子邮件中。";//'Export the document to RTF and attach it to the e-mail.
                case PreviewStringId.RibbonPreview_SendRtf_STipTitle: return "在电子邮件中以RTF格式发送";//'E-Mail As RTF
                case PreviewStringId.RibbonPreview_SendTxt_Caption: return "文本文件";//'Text File
                case PreviewStringId.RibbonPreview_SendTxt_Description: return "纯文本";//'Plain Text
                case PreviewStringId.RibbonPreview_SendTxt_STipContent: return "以文本格式输出文档，并且将其附到电子邮件中。";//'Export the document to Text and attach it to the e-mail.
                case PreviewStringId.RibbonPreview_SendTxt_STipTitle: return "在电子邮件中以文本格式发送";//'E-Mail As Text
                case PreviewStringId.RibbonPreview_SendXls_Caption: return "Excel文件";//'XLS File
                case PreviewStringId.RibbonPreview_SendXls_Description: return "Microsoft Excel工作薄";//'Microsoft Excel 2000-2003 Workbook
                case PreviewStringId.RibbonPreview_SendXls_STipContent: return "以XLS格式输出文档，并且将其附到电子邮件中。";//'Export the document to XLS and attach it to the e-mail.
                case PreviewStringId.RibbonPreview_SendXls_STipTitle: return "在电子邮件中以XLS格式发送";//'E-Mail As XLS
                case PreviewStringId.RibbonPreview_SendXlsx_Caption: return "XLSX 文件";//'XLSX File
                case PreviewStringId.RibbonPreview_SendXlsx_Description: return "Microsoft Excel 2007 工作簿";//'Microsoft Excel 2007 Workbook
                case PreviewStringId.RibbonPreview_SendXlsx_STipContent: return "将文档导出到 XLSX，并将其附加到电子邮件。";//'Export the document to XLSX and attach it to the e-mail.
                case PreviewStringId.RibbonPreview_SendXlsx_STipTitle: return "电子邮件作为 XLSX";//'E-Mail As XLSX
                case PreviewStringId.RibbonPreview_SendXps_Caption: return "XPS 文件";//'XPS File
                case PreviewStringId.RibbonPreview_SendXps_Description: return "XPS";//'XPS
                case PreviewStringId.RibbonPreview_ShowFirstPage_Caption: return "第一页";//'First Page
                case PreviewStringId.RibbonPreview_ShowFirstPage_STipContent: return "查看文档第一页。";//'Navigate to the first page of the document.
                case PreviewStringId.RibbonPreview_ShowFirstPage_STipTitle: return "第一页(Ctrl+Home)";//'First Page (Ctrl+Home)
                case PreviewStringId.RibbonPreview_ShowLastPage_Caption: return "最后一页";//'Last  Page
                case PreviewStringId.RibbonPreview_ShowLastPage_STipContent: return "查看文档最后一页。";//'Navigate to the last page of the document.
                case PreviewStringId.RibbonPreview_ShowLastPage_STipTitle: return "最后一页(Ctrl+End)";//'Last Page (Ctrl+End)
                case PreviewStringId.RibbonPreview_ShowNextPage_Caption: return "下一页";//'Next  Page
                case PreviewStringId.RibbonPreview_ShowNextPage_STipContent: return "查看文档下一页。";//'Navigate to the next page of the document.
                case PreviewStringId.RibbonPreview_ShowNextPage_STipTitle: return "下一页(PageDown)";//'Next Page (PageDown)
                case PreviewStringId.RibbonPreview_ShowPrevPage_Caption: return "上一页";//'Previous Page
                case PreviewStringId.RibbonPreview_ShowPrevPage_STipContent: return "查看文档上一页。";//'Navigate to the previous page of the document.
                case PreviewStringId.RibbonPreview_ShowPrevPage_STipTitle: return "上一页(PageUp)";//'Previous Page (PageUp)
                case PreviewStringId.RibbonPreview_Watermark_Caption: return "水印";//'Watermark
                case PreviewStringId.RibbonPreview_Watermark_STipContent: return "在页面的目录后插入文本或者图象的镜象。这通常用于指示一个文档被特殊处理过。";//'Insert ghosted text or image behind the content of a page.    This is often used to indicate that a document is to be treated specially.
                case PreviewStringId.RibbonPreview_Watermark_STipTitle: return "水印";//'Watermark
                case PreviewStringId.RibbonPreview_Zoom_Caption: return "缩放";//'Zoom
                case PreviewStringId.RibbonPreview_Zoom_STipContent: return "改变文档预览的缩放等级。";//'Change the zoom level of the document preview.
                case PreviewStringId.RibbonPreview_Zoom_STipTitle: return "缩放";//'Zoom
                case PreviewStringId.RibbonPreview_ZoomExact_Caption: return "精确度：";//'Exact:
                case PreviewStringId.RibbonPreview_ZoomIn_Caption: return "放大";//'Zoom In
                case PreviewStringId.RibbonPreview_ZoomIn_STipContent: return "放大以便得到文档的近视图。";//'Zoom in to get a close-up view of the document.
                case PreviewStringId.RibbonPreview_ZoomIn_STipTitle: return "放大";//'Zoom In
                case PreviewStringId.RibbonPreview_ZoomOut_Caption: return "缩小";//'Zoom Out
                case PreviewStringId.RibbonPreview_ZoomOut_STipContent: return "缩小以便在一个减小的尺寸上看到页面的更多部分。";//'Zoom out to see more of the page at a reduced size.
                case PreviewStringId.RibbonPreview_ZoomOut_STipTitle: return "缩小";//'Zoom Out
                case PreviewStringId.SaveDlg_FilterBmp: return "BMP比特图格式";//'BMP Bitmap Format
                case PreviewStringId.SaveDlg_FilterCsv: return "CSV文档";//'CSV Document
                case PreviewStringId.SaveDlg_FilterEmf: return "EMF 增强的视窗图元元件";//'EMF Enhanced Windows Metafile
                case PreviewStringId.SaveDlg_FilterGif: return "GIF图形交换格式";//'GIF Graphics Interchange Format
                case PreviewStringId.SaveDlg_FilterHtm: return "HTML文档";//'HTML Document
                case PreviewStringId.SaveDlg_FilterJpeg: return "JPEG可交换文件格式";//'JPEG File Interchange Format
                case PreviewStringId.SaveDlg_FilterMht: return "MHT文档";//'MHT Document
                case PreviewStringId.SaveDlg_FilterNativeFormat: return "原有格式";//'Native Format
                case PreviewStringId.SaveDlg_FilterPdf: return "PDF文档";//'PDF Document
                case PreviewStringId.SaveDlg_FilterPng: return "PNG流式网络图形格式";//'PNG Portable Network Graphics Format
                case PreviewStringId.SaveDlg_FilterRtf: return "多文本文档";//'Rich Text Document
                case PreviewStringId.SaveDlg_FilterTiff: return "TIFF标签图像文件格式";//'TIFF Tag Image File Format
                case PreviewStringId.SaveDlg_FilterTxt: return "文本文档";//'Text Document
                case PreviewStringId.SaveDlg_FilterWmf: return "WMF 视窗图元文件";//'WMF Windows Metafile
                case PreviewStringId.SaveDlg_FilterXls: return "Excel文档";//'XLS Document
                case PreviewStringId.SaveDlg_FilterXlsx: return "XLSX 文档";//'XLSX Document
                case PreviewStringId.SaveDlg_FilterXps: return "XPS 文档";//'XPS Document
                case PreviewStringId.SaveDlg_Title: return "存储为";//'Save As
                case PreviewStringId.SB_PageInfo: return "{0}在 {1}之中";//'{0} of {1}
                case PreviewStringId.SB_PageNone: return "空";//'Nothing
                case PreviewStringId.SB_PageOfPages: return "第 {0} 页 共 {1} 页";//'Page {0} of {1}
                case PreviewStringId.SB_TTip_Stop: return "停止";//'Stop
                case PreviewStringId.SB_ZoomFactor: return "缩放比例：";//'Zoom Factor:
                case PreviewStringId.ScalePopup_AdjustTo: return "调整至：";//'Adjust to:
                case PreviewStringId.ScalePopup_FitTo: return "调整到";//'Fit to
                case PreviewStringId.ScalePopup_GroupText: return "缩放比例";//'Scaling
                case PreviewStringId.ScalePopup_NormalSize: return "%正常大小";//'% normal size
                case PreviewStringId.ScalePopup_PagesWide: return "页面范围";//'pages wide
                case PreviewStringId.ScrollingInfo_Page: return "页面";//'Page
                case PreviewStringId.Shapes_Arrow: return "箭头";//'Arrow
                case PreviewStringId.Shapes_BackslantLine: return "回归倾斜线";//'Backslant Line
                case PreviewStringId.Shapes_BottomArrow: return "向下箭头";//'Bottom Arrow
                case PreviewStringId.Shapes_Brace: return "大括号";//'Brace
                case PreviewStringId.Shapes_Bracket: return "括号";//'Bracket
                case PreviewStringId.Shapes_Cross: return "交叉";//'Cross
                case PreviewStringId.Shapes_EightPointStar: return "8 点星形";//'8-Point Star
                case PreviewStringId.Shapes_Ellipse: return "椭圆形";//'Ellipse
                case PreviewStringId.Shapes_FivePointStar: return "5 点星形";//'5-Point Star
                case PreviewStringId.Shapes_FourPointStar: return "4 点星形";//'4-Point Star
                case PreviewStringId.Shapes_Hexagon: return "六角形";//'Hexagon
                case PreviewStringId.Shapes_HorizontalLine: return "水平线";//'Horizontal Line
                case PreviewStringId.Shapes_LeftArrow: return "向左箭头";//'Left Arrow
                case PreviewStringId.Shapes_Line: return "线条";//'Line
                case PreviewStringId.Shapes_Octagon: return "八角形";//'Octagon
                case PreviewStringId.Shapes_Pentagon: return "五角形";//'Pentagon
                case PreviewStringId.Shapes_Polygon: return "多边形";//'Polygon
                case PreviewStringId.Shapes_Rectangle: return "长方形";//'Rectangle
                case PreviewStringId.Shapes_RightArrow: return "向右箭头";//'Right Arrow
                case PreviewStringId.Shapes_SixPointStar: return "6 点星形";//'6-Point Star
                case PreviewStringId.Shapes_SlantLine: return "斜线";//'Slant Line
                case PreviewStringId.Shapes_Square: return "正方形";//'Square
                case PreviewStringId.Shapes_Star: return "星形";//'Star
                case PreviewStringId.Shapes_ThreePointStar: return "3 点星形";//'3-Point Star
                case PreviewStringId.Shapes_TopArrow: return "向上箭头";//'Top Arrow
                case PreviewStringId.Shapes_Triangle: return "三角形";//'Triangle
                case PreviewStringId.Shapes_VerticalLine: return "垂直线";//'Vertical Line
                case PreviewStringId.TB_TTip_Backgr: return "背景";//'Background
                case PreviewStringId.TB_TTip_Close: return "关闭预览";//'Close Preview
                case PreviewStringId.TB_TTip_Customize: return "定制";//'Customize
                case PreviewStringId.TB_TTip_EditPageHF: return "页眉和页脚";//'Header And Footer
                case PreviewStringId.TB_TTip_Export: return "输出文档...";//'Export Document...
                case PreviewStringId.TB_TTip_FirstPage: return "第一页";//'First Page
                case PreviewStringId.TB_TTip_HandTool: return "抓取工具";//'Hand Tool
                case PreviewStringId.TB_TTip_LastPage: return "最后一页";//'Last Page
                case PreviewStringId.TB_TTip_Magnifier: return "放大镜";//'Magnifier
                case PreviewStringId.TB_TTip_Map: return "文档结构图";//'Document Map
                case PreviewStringId.TB_TTip_MultiplePages: return "显示多页";//'Multiple Pages
                case PreviewStringId.TB_TTip_NextPage: return "下一页";//'Next Page
                case PreviewStringId.TB_TTip_Open: return "打开文档";//'Open a document
                case PreviewStringId.TB_TTip_PageSetup: return "页面调整";//'Page Setup
                case PreviewStringId.TB_TTip_Parameters: return "参数";//'Parameters
                case PreviewStringId.TB_TTip_PreviousPage: return "上一页";//'Previous Page
                case PreviewStringId.TB_TTip_Print: return "打印";//'Print
                case PreviewStringId.TB_TTip_PrintDirect: return "快速打印";//'Quick Print
                case PreviewStringId.TB_TTip_Save: return "保存文档";//'Save the document
                case PreviewStringId.TB_TTip_Scale: return "比例";//'Scale
                case PreviewStringId.TB_TTip_Search: return "搜索";//'Search
                case PreviewStringId.TB_TTip_Send: return "通过电子邮件发送...";//'Send via E-Mail...
                case PreviewStringId.TB_TTip_Watermark: return "水印";//'Watermark
                case PreviewStringId.TB_TTip_Zoom: return "缩放";//'Zoom
                case PreviewStringId.TB_TTip_ZoomIn: return "放大";//'Zoom In
                case PreviewStringId.TB_TTip_ZoomOut: return "缩小";//'Zoom Out
                case PreviewStringId.WMForm_Direction_BackwardDiagonal: return "后向倾斜";//'Backward Diagonal
                case PreviewStringId.WMForm_Direction_ForwardDiagonal: return "前向倾斜";//'Forward Diagonal
                case PreviewStringId.WMForm_Direction_Horizontal: return "水平的";//'Horizontal
                case PreviewStringId.WMForm_Direction_Vertical: return "垂直的";//'Vertical
                case PreviewStringId.WMForm_HorzAlign_Center: return "居中";//'Center
                case PreviewStringId.WMForm_HorzAlign_Left: return "左";//'Left
                case PreviewStringId.WMForm_HorzAlign_Right: return "右";//'Right
                case PreviewStringId.WMForm_ImageClip: return "裁剪";//'Clip
                case PreviewStringId.WMForm_ImageStretch: return "拉伸";//'Stretch
                case PreviewStringId.WMForm_ImageZoom: return "缩放";//'Zoom
                case PreviewStringId.WMForm_PageRangeRgrItem_All: return "全部";//'&All
                case PreviewStringId.WMForm_PageRangeRgrItem_Pages: return "页面";//'&Pages:
                case PreviewStringId.WMForm_PictureDlg_Title: return "选择图片";//'Select Picture
                case PreviewStringId.WMForm_VertAlign_Bottom: return "底部";//'Bottom
                case PreviewStringId.WMForm_VertAlign_Middle: return "中间";//'Middle
                case PreviewStringId.WMForm_VertAlign_Top: return "上部";//'Top
                case PreviewStringId.WMForm_Watermark_Asap: return "尽快";//'ASAP
                case PreviewStringId.WMForm_Watermark_Confidential: return "机密";//'CONFIDENTIAL
                case PreviewStringId.WMForm_Watermark_Copy: return "复制";//'COPY
                case PreviewStringId.WMForm_Watermark_DoNotCopy: return "不复制";//'DO NOT COPY
                case PreviewStringId.WMForm_Watermark_Draft: return "草图";//'DRAFT
                case PreviewStringId.WMForm_Watermark_Evaluation: return "评价";//'EVALUATION
                case PreviewStringId.WMForm_Watermark_Original: return "创新";//'ORIGINAL
                case PreviewStringId.WMForm_Watermark_Personal: return "个人";//'PERSONAL
                case PreviewStringId.WMForm_Watermark_Sample: return "示例";//'SAMPLE
                case PreviewStringId.WMForm_Watermark_TopSecret: return "最高机密";//'TOP SECRET
                case PreviewStringId.WMForm_Watermark_Urgent: return "紧迫";//'URGENT
                case PreviewStringId.WMForm_ZOrderRgrItem_Behind: return "后方";//'&Behind
                case PreviewStringId.WMForm_ZOrderRgrItem_InFront: return "前方";//'In &front
                default:
                    return id.ToString();
            }
        }
    }
}