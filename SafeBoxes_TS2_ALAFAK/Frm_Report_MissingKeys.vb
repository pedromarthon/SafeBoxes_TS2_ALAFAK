﻿Public Class Frm_Report_MissingKeys
    Dim RptDbDataSet As New DataSet
    Dim CrysReport As New Rpt_MissingKeys

    Private Sub Frm_Report_MissingKeys_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RptDbDataSet.Reset()
        RptDbDataSet = ReadQueryOut("SELECT MissKeyId, MissKeyDate, RedeliverDate, ContId FROM MissingKeys").Copy()
        CrysReport.Database.Tables(0).SetDataSource(RptDbDataSet.Tables(0))
        RptV_MissingKeys.ReportSource = CrysReport
        RptV_MissingKeys.RefreshReport()
    End Sub

    Private Sub Chk_Delivered_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Delivered.CheckedChanged
        If Chk_Delivered.Checked Then
            RptDbDataSet.Reset()
            RptDbDataSet = ReadQueryOut("SELECT MissKeyId, MissKeyDate, RedeliverDate, ContId FROM MissingKeys WHERE RedeliverDate IS NOT NULL").Copy()
            CrysReport.Database.Tables(0).SetDataSource(RptDbDataSet.Tables(0))
            RptV_MissingKeys.ReportSource = CrysReport
            RptV_MissingKeys.RefreshReport()
        Else
            RptDbDataSet.Reset()
            RptDbDataSet = ReadQueryOut("SELECT MissKeyId, MissKeyDate, RedeliverDate, ContId FROM MissingKeys").Copy()
            CrysReport.Database.Tables(0).SetDataSource(RptDbDataSet.Tables(0))
            RptV_MissingKeys.ReportSource = CrysReport
            RptV_MissingKeys.RefreshReport()
        End If

    End Sub
End Class