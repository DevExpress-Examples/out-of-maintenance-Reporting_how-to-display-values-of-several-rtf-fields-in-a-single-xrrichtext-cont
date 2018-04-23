Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraRichEdit

Namespace RepConcatRtfFields
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport
		Private richEditDocumentServer As RichEditDocumentServer

		Public Sub New()
			InitializeComponent()

			richEditDocumentServer = New RichEditDocumentServer()
		End Sub

		Private Sub XtraReport1_DataSourceDemanded(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.DataSourceDemanded
			Me.DataSource = ManualDataSet.CreateData()
		End Sub

		Private Sub xrRichText1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrRichText1.BeforePrint
			Dim rtfColumn1 As String = GetCurrentColumnValue("RtfColumn1").ToString()
			Dim rtfColumn2 As String = GetCurrentColumnValue("RtfColumn2").ToString()

			richEditDocumentServer.RtfText = rtfColumn1
			richEditDocumentServer.Document.AppendText(" ")
			richEditDocumentServer.Document.AppendRtfText(rtfColumn2)

			xrRichText1.Rtf = richEditDocumentServer.RtfText
		End Sub
	End Class
End Namespace
