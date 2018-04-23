Imports Microsoft.VisualBasic
Imports System
Namespace RepConcatRtfFields
	Partial Public Class XtraReport1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(XtraReport1))
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrRichText1 = New DevExpress.XtraReports.UI.XRRichText()
			Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.manualDataSet1 = New RepConcatRtfFields.ManualDataSet()
			CType(Me.xrRichText1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.manualDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrRichText1})
			Me.Detail.HeightF = 48.41665F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrRichText1
			' 
			Me.xrRichText1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 10.00001F)
			Me.xrRichText1.Name = "xrRichText1"
			Me.xrRichText1.SerializableRtfString = resources.GetString("xrRichText1.SerializableRtfString")
			Me.xrRichText1.SizeF = New System.Drawing.SizeF(344.7917F, 23F)
'			Me.xrRichText1.BeforePrint += New System.Drawing.Printing.PrintEventHandler(Me.xrRichText1_BeforePrint);
			' 
			' ReportHeader
			' 
			Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
			Me.ReportHeader.HeightF = 42F
			Me.ReportHeader.Name = "ReportHeader"
			' 
			' xrLabel1
			' 
			Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 25F)
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(275F, 0F)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(100F, 42F)
			Me.xrLabel1.StylePriority.UseFont = False
			Me.xrLabel1.Text = "Report"
			' 
			' topMarginBand1
			' 
			Me.topMarginBand1.Name = "topMarginBand1"
			' 
			' bottomMarginBand1
			' 
			Me.bottomMarginBand1.Name = "bottomMarginBand1"
			' 
			' manualDataSet1
			' 
			Me.manualDataSet1.DataSetName = "ManualDataSet"
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.ReportHeader, Me.topMarginBand1, Me.bottomMarginBand1})
			Me.DataMember = "table"
			Me.DataSource = Me.manualDataSet1
			Me.Version = "11.1"
'			Me.DataSourceDemanded += New System.EventHandler(Of System.EventArgs)(Me.XtraReport1_DataSourceDemanded);
			CType(Me.xrRichText1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.manualDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
		Private bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
		Private manualDataSet1 As ManualDataSet
		Private WithEvents xrRichText1 As DevExpress.XtraReports.UI.XRRichText
	End Class
End Namespace
