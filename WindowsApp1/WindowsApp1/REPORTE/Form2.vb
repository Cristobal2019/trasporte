﻿Public Class Form2
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Dim OBJEREP As New CrystalReport1
        CrystalReportViewer1.ReportSource = OBJEREP
    End Sub
End Class