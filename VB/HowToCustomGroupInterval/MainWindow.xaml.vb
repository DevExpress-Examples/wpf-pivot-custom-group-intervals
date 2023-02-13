Imports System.Windows
Imports DevExpress.Xpf.PivotGrid
Imports HowToBindToMDB.NwindDataSetTableAdapters
Imports System

Namespace HowToBindToMDB

    Public Partial Class MainWindow
        Inherits Window

        Private salesPersonDataTable As NwindDataSet.SalesPersonDataTable = New NwindDataSet.SalesPersonDataTable()

        Private salesPersonDataAdapter As SalesPersonTableAdapter = New SalesPersonTableAdapter()

        Public Sub New()
            Me.InitializeComponent()
            Me.pivotGridControl1.DataSource = salesPersonDataTable
        End Sub

        Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            salesPersonDataAdapter.Fill(salesPersonDataTable)
            Me.pivotGridControl1.CollapseAllRows()
        End Sub

        Private Sub pivotGridControl1_CustomGroupInterval(ByVal sender As Object, ByVal e As PivotCustomGroupIntervalEventArgs)
            If Not Object.ReferenceEquals(e.Field, Me.fieldProductGroup) Then Return
            Dim productName As String = Convert.ToString(e.Value)
            If productName(0) < "F"c Then
                e.GroupValue = "A-E"
            ElseIf productName(0) > "E"c AndAlso productName(0) < "T"c Then
                e.GroupValue = "F-S"
            ElseIf productName(0) > "S"c Then
                e.GroupValue = "T-Z"
            End If
        End Sub
    End Class
End Namespace
