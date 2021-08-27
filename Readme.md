<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128600371/11.1.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3416)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [DataObject.cs](./CS/DataObject.cs) (VB: [DataObject.vb](./VB/DataObject.vb))
* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
* [XtraReport1.cs](./CS/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/XtraReport1.vb))
<!-- default file list end -->
# How to display values of several RTF fields in a single XRRichText control


<p><strong>Problem:</strong><br />
I am creating a data-aware report. The source data table has several columns containing RTF text. I need to concatenate the contents of these columns and display it in a single XRRichText.</p><p><strong>Solution:<br />
</strong>As you probably know, RTF strings cannot be concatenated directly (strResult = strSource1 + strSource2) because it will result in invalid RTF content. Instead, utilize special RTF-aware API to accomplish this task. Our XtraRichEdit Suite provides you with this API. In v2011 vol 1 we have implemented the non-visual <a href="http://search.devexpress.com/?q=RichEditDocumentServer&p=T0|P0|0&d=2943"><u>RichEditDocumentServer</u></a> component (in previous versions use the <a href="http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraRichEditRichEditControltopic"><u>RichEditControl Class</u></a> instead). You can use its <strong>RtfText</strong> property and <strong>Document.AppendRtfText()</strong> method (see the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraRichEditAPINativeSubDocument_AppendRtfTexttopic"><u>SubDocument.AppendRtfText Method</u></a>). Thus, handle the <strong>XRRichText.BeforePrint </strong>event, obtain current RTF field values via the <a href="http://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUIXtraReportBase_GetCurrentColumnValuetopic"><u>XtraReportBase.GetCurrentColumnValue Method</u></a>, concatenate them by using the aforementioned API and assign the resulting RTF to the <a href="http://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUIXRRichText_Rtftopic"><u>XRRichText.Rtf Property</u></a>.</p>

<br/>


