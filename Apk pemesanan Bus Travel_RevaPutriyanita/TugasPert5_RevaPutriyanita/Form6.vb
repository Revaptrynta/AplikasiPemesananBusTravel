Imports CrystalDecisions.CrystalReports.Engine
Public Class Form6
    Dim cryrpt As New ReportDocument
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cryrpt.Load("CrystalReport3.rpt")
        cryrpt.Refresh()
        CrystalReportViewer1.ReportSource = cryrpt
        CrystalReportViewer1.Refresh()
    End Sub
End Class