﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_main
    Inherits Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MaterialRaisedButton1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btn_newclient = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialRaisedButton2 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialRaisedButton3 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.CrystalReport11 = New SafeBoxes_TS2_ALAFAK.CrystalReport1()
        Me.SuspendLayout()
        '
        'MaterialRaisedButton1
        '
        Me.MaterialRaisedButton1.AutoSize = True
        Me.MaterialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialRaisedButton1.Depth = 0
        Me.MaterialRaisedButton1.Icon = Nothing
        Me.MaterialRaisedButton1.Location = New System.Drawing.Point(13, 73)
        Me.MaterialRaisedButton1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaterialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton1.Name = "MaterialRaisedButton1"
        Me.MaterialRaisedButton1.Primary = True
        Me.MaterialRaisedButton1.Size = New System.Drawing.Size(126, 36)
        Me.MaterialRaisedButton1.TabIndex = 0
        Me.MaterialRaisedButton1.Text = "New Contract"
        Me.MaterialRaisedButton1.UseVisualStyleBackColor = True
        '
        'btn_newclient
        '
        Me.btn_newclient.AutoSize = True
        Me.btn_newclient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_newclient.Depth = 0
        Me.btn_newclient.Icon = Nothing
        Me.btn_newclient.Location = New System.Drawing.Point(211, 73)
        Me.btn_newclient.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_newclient.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_newclient.Name = "btn_newclient"
        Me.btn_newclient.Primary = True
        Me.btn_newclient.Size = New System.Drawing.Size(100, 36)
        Me.btn_newclient.TabIndex = 2
        Me.btn_newclient.Text = "New Client"
        Me.btn_newclient.UseVisualStyleBackColor = True
        '
        'MaterialRaisedButton2
        '
        Me.MaterialRaisedButton2.AutoSize = True
        Me.MaterialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialRaisedButton2.Depth = 0
        Me.MaterialRaisedButton2.Icon = Nothing
        Me.MaterialRaisedButton2.Location = New System.Drawing.Point(370, 73)
        Me.MaterialRaisedButton2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaterialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton2.Name = "MaterialRaisedButton2"
        Me.MaterialRaisedButton2.Primary = True
        Me.MaterialRaisedButton2.Size = New System.Drawing.Size(120, 36)
        Me.MaterialRaisedButton2.TabIndex = 3
        Me.MaterialRaisedButton2.Text = "New Company"
        Me.MaterialRaisedButton2.UseVisualStyleBackColor = True
        '
        'MaterialRaisedButton3
        '
        Me.MaterialRaisedButton3.AutoSize = True
        Me.MaterialRaisedButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialRaisedButton3.Depth = 0
        Me.MaterialRaisedButton3.Icon = Nothing
        Me.MaterialRaisedButton3.Location = New System.Drawing.Point(559, 73)
        Me.MaterialRaisedButton3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaterialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton3.Name = "MaterialRaisedButton3"
        Me.MaterialRaisedButton3.Primary = True
        Me.MaterialRaisedButton3.Size = New System.Drawing.Size(134, 36)
        Me.MaterialRaisedButton3.TabIndex = 4
        Me.MaterialRaisedButton3.Text = "New Info Vouch"
        Me.MaterialRaisedButton3.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(13, 117)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.CrystalReport11
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(790, 372)
        Me.CrystalReportViewer1.TabIndex = 56
        '
        'Frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 501)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.MaterialRaisedButton3)
        Me.Controls.Add(Me.MaterialRaisedButton2)
        Me.Controls.Add(Me.btn_newclient)
        Me.Controls.Add(Me.MaterialRaisedButton1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Frm_main"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialRaisedButton1 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btn_newclient As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialRaisedButton2 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialRaisedButton3 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CrystalReport11 As CrystalReport1
End Class
