﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Report_Authorizations
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.dtpick_exdate = New System.Windows.Forms.DateTimePicker()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Dte_from = New System.Windows.Forms.DateTimePicker()
        Me.RptV_Authorizations = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.dtpick_exdate)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.Dte_from)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(689, 134)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 57)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(234, 26)
        Me.TextBox1.TabIndex = 12
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(250, 25)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(171, 24)
        Me.RadioButton2.TabIndex = 15
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "By Date (FROM-TO)"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'dtpick_exdate
        '
        Me.dtpick_exdate.CustomFormat = "dd/mm/yyyy"
        Me.dtpick_exdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dtpick_exdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpick_exdate.Location = New System.Drawing.Point(466, 55)
        Me.dtpick_exdate.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.dtpick_exdate.MinDate = New Date(2018, 5, 4, 0, 0, 0, 0)
        Me.dtpick_exdate.Name = "dtpick_exdate"
        Me.dtpick_exdate.Size = New System.Drawing.Size(204, 26)
        Me.dtpick_exdate.TabIndex = 10
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 25)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(131, 24)
        Me.RadioButton1.TabIndex = 16
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "By Contract ID"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Dte_from
        '
        Me.Dte_from.CustomFormat = "dd/mm/yyyy"
        Me.Dte_from.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Dte_from.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dte_from.Location = New System.Drawing.Point(250, 55)
        Me.Dte_from.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Dte_from.MinDate = New Date(2018, 5, 4, 0, 0, 0, 0)
        Me.Dte_from.Name = "Dte_from"
        Me.Dte_from.Size = New System.Drawing.Size(204, 26)
        Me.Dte_from.TabIndex = 11
        '
        'RptV_Authorizations
        '
        Me.RptV_Authorizations.ActiveViewIndex = -1
        Me.RptV_Authorizations.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RptV_Authorizations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RptV_Authorizations.Cursor = System.Windows.Forms.Cursors.Default
        Me.RptV_Authorizations.Location = New System.Drawing.Point(12, 152)
        Me.RptV_Authorizations.Name = "RptV_Authorizations"
        Me.RptV_Authorizations.Size = New System.Drawing.Size(689, 354)
        Me.RptV_Authorizations.TabIndex = 21
        '
        'Frm_Report_Authorizations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(716, 518)
        Me.Controls.Add(Me.RptV_Authorizations)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Frm_Report_Authorizations"
        Me.Text = "Report Authorizations"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents dtpick_exdate As DateTimePicker
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Dte_from As DateTimePicker
    Friend WithEvents RptV_Authorizations As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
