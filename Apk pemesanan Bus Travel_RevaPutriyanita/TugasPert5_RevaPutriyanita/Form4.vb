Imports CrystalDecisions.CrystalReports.Engine
Public Class Form4
    Dim cryrpt As New ReportDocument
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cryrpt.Load("CrystalReport2.rpt")
        cryrpt.Refresh()
        CrystalReportViewer1.ReportSource = cryrpt
        CrystalReportViewer1.Refresh()
    End Sub
End Class