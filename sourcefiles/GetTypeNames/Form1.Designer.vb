﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Get File Name"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(162, 29)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(610, 23)
        Me.TextBox1.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 88)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(109, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Get File contents"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(172, 104)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox2.Size = New System.Drawing.Size(382, 308)
        Me.TextBox2.TabIndex = 3
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 143)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Strip"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(609, 88)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox3.Size = New System.Drawing.Size(332, 383)
        Me.TextBox3.TabIndex = 5
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(172, 458)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(276, 23)
        Me.TextBox4.TabIndex = 6
        Me.TextBox4.Text = "Number of types = ?"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(974, 31)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox5.Size = New System.Drawing.Size(355, 440)
        Me.TextBox5.TabIndex = 7
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(27, 265)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "save"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1386, 530)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
