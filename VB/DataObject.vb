Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Data

Namespace RepConcatRtfFields
	Public Class ManualDataSet
		Inherits DataSet
		Public Sub New()
			MyBase.New()
			Dim table As New DataTable("table")

			DataSetName = "ManualDataSet"

			table.Columns.Add("ID", GetType(Int32))
			table.Columns.Add("RtfColumn1", GetType(String))
			table.Columns.Add("RtfColumn2", GetType(String))
			table.Constraints.Add("IDPK", table.Columns("ID"), True)

			Tables.AddRange(New DataTable() { table })
		End Sub

		Public Shared Function CreateData() As ManualDataSet
			Dim ds As New ManualDataSet()
			Dim table As DataTable = ds.Tables("table")

			table.Rows.Add(New Object() { 0, "{\rtf1\deff0{\fonttbl{\f0 Times New Roman;}}{\colortbl\red0\green0\blue0 ;\red0\green0\blue255 ;}{\*\listoverridetable}{\stylesheet {\ql\cf0 Normal;}{\*\cs1\cf0 Default Paragraph Font;}{\*\cs2\sbasedon1\cf0 Line Number;}{\*\cs3\ul\cf1 Hyperlink;}}\sectd\pard\plain\ql{\b\cf1 Test}{\b\cf1  }{\b\cf0 1}}", "{\rtf1\deff0{\fonttbl{\f0 Times New Roman;}}{\colortbl\red0\green0\blue0 ;\red0\green0\blue255 ;\red255\green0\blue0 ;}{\*\listoverridetable}{\stylesheet {\ql\cf0 Normal;}{\*\cs1\cf0 Default Paragraph Font;}{\*\cs2\sbasedon1\cf0 Line Number;}{\*\cs3\ul\cf1 Hyperlink;}}\sectd\pard\plain\ql{\b\cf2 Test}{\b\cf1  }{\b\ul\cf0 2}}" })

			Return ds
		End Function

		#Region "Disable Serialization for Tables and Relations"
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
		Public Shadows ReadOnly Property Tables() As DataTableCollection
			Get
				Return MyBase.Tables
			End Get
		End Property

		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
		Public Shadows ReadOnly Property Relations() As DataRelationCollection
			Get
				Return MyBase.Relations
			End Get
		End Property
		#End Region ' Disable Serialization for Tables and Relations
	End Class
End Namespace
