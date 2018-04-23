Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.OleDb
Imports System.Windows
Imports DevExpress.Xpf.PivotGrid
Imports HowToBindToMDB.NwindDataSetTableAdapters
Imports System

Namespace HowToBindToMDB
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Private salesPersonDataTable As New NwindDataSet.SalesPersonDataTable()
		Private salesPersonDataAdapter As New SalesPersonTableAdapter()

		Public Sub New()
			InitializeComponent()
			pivotGridControl1.DataSource = salesPersonDataTable
		End Sub

		Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			salesPersonDataAdapter.Fill(salesPersonDataTable)
			pivotGridControl1.CollapseAllRows()
		End Sub

        Private Sub pivotGridControl1_CustomGroupInterval(ByVal sender As Object, _
                                                          ByVal e As PivotCustomGroupIntervalEventArgs)
            If (Not Object.ReferenceEquals(e.Field, fieldProductGroup)) Then
                Return
            End If
            Dim productName As String = Convert.ToString(e.Value)
            If productName.Chars(0) < "F"c Then
                e.GroupValue = "A-E"
            ElseIf productName.Chars(0) > "E"c AndAlso productName.Chars(0) < "T"c Then
                e.GroupValue = "F-S"
            ElseIf productName.Chars(0) > "S"c Then
                e.GroupValue = "T-Z"
            End If
        End Sub
	End Class
End Namespace
