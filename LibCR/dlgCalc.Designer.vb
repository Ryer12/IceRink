<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgCalc
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn11 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnEquals = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnOperator4 = New System.Windows.Forms.Button()
        Me.btnOperator3 = New System.Windows.Forms.Button()
        Me.btnOperator2 = New System.Windows.Forms.Button()
        Me.btnOperator1 = New System.Windows.Forms.Button()
        Me.btn10 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(49, 171)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(9, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 13)
        Me.Label1.TabIndex = 79
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn11
        '
        Me.btn11.Location = New System.Drawing.Point(79, 142)
        Me.btn11.Name = "btn11"
        Me.btn11.Size = New System.Drawing.Size(29, 24)
        Me.btn11.TabIndex = 78
        Me.btn11.Text = "."
        Me.btn11.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(9, 23)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(169, 15)
        Me.TextBox1.TabIndex = 77
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnEquals
        '
        Me.btnEquals.Location = New System.Drawing.Point(149, 85)
        Me.btnEquals.Name = "btnEquals"
        Me.btnEquals.Size = New System.Drawing.Size(29, 81)
        Me.btnEquals.TabIndex = 76
        Me.btnEquals.Text = "="
        Me.btnEquals.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(149, 55)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(29, 24)
        Me.btnClear.TabIndex = 75
        Me.btnClear.Text = "C"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnOperator4
        '
        Me.btnOperator4.Location = New System.Drawing.Point(114, 142)
        Me.btnOperator4.Name = "btnOperator4"
        Me.btnOperator4.Size = New System.Drawing.Size(29, 24)
        Me.btnOperator4.TabIndex = 74
        Me.btnOperator4.Text = "/"
        Me.btnOperator4.UseVisualStyleBackColor = True
        '
        'btnOperator3
        '
        Me.btnOperator3.Location = New System.Drawing.Point(114, 113)
        Me.btnOperator3.Name = "btnOperator3"
        Me.btnOperator3.Size = New System.Drawing.Size(29, 24)
        Me.btnOperator3.TabIndex = 73
        Me.btnOperator3.Text = "*"
        Me.btnOperator3.UseVisualStyleBackColor = True
        '
        'btnOperator2
        '
        Me.btnOperator2.Location = New System.Drawing.Point(114, 84)
        Me.btnOperator2.Name = "btnOperator2"
        Me.btnOperator2.Size = New System.Drawing.Size(29, 24)
        Me.btnOperator2.TabIndex = 72
        Me.btnOperator2.Text = "-"
        Me.btnOperator2.UseVisualStyleBackColor = True
        '
        'btnOperator1
        '
        Me.btnOperator1.Location = New System.Drawing.Point(114, 55)
        Me.btnOperator1.Name = "btnOperator1"
        Me.btnOperator1.Size = New System.Drawing.Size(29, 24)
        Me.btnOperator1.TabIndex = 71
        Me.btnOperator1.Text = "+"
        Me.btnOperator1.UseVisualStyleBackColor = True
        '
        'btn10
        '
        Me.btn10.Location = New System.Drawing.Point(9, 142)
        Me.btn10.Name = "btn10"
        Me.btn10.Size = New System.Drawing.Size(64, 24)
        Me.btn10.TabIndex = 70
        Me.btn10.Text = "0"
        Me.btn10.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Location = New System.Drawing.Point(79, 113)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(29, 24)
        Me.btn9.TabIndex = 69
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Location = New System.Drawing.Point(44, 113)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(29, 24)
        Me.btn8.TabIndex = 68
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Location = New System.Drawing.Point(9, 113)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(29, 24)
        Me.btn7.TabIndex = 67
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Location = New System.Drawing.Point(79, 84)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(29, 24)
        Me.btn6.TabIndex = 66
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Location = New System.Drawing.Point(44, 84)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(29, 24)
        Me.btn5.TabIndex = 65
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(9, 84)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(29, 24)
        Me.btn4.TabIndex = 64
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(79, 55)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(29, 24)
        Me.btn3.TabIndex = 63
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(44, 55)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(29, 24)
        Me.btn2.TabIndex = 62
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(9, 55)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(29, 24)
        Me.btn1.TabIndex = 61
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'dlgCalc
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(198, 207)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn11)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnEquals)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnOperator4)
        Me.Controls.Add(Me.btnOperator3)
        Me.Controls.Add(Me.btnOperator2)
        Me.Controls.Add(Me.btnOperator1)
        Me.Controls.Add(Me.btn10)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCalc"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "dlgCalc"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn11 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnEquals As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnOperator4 As System.Windows.Forms.Button
    Friend WithEvents btnOperator3 As System.Windows.Forms.Button
    Friend WithEvents btnOperator2 As System.Windows.Forms.Button
    Friend WithEvents btnOperator1 As System.Windows.Forms.Button
    Friend WithEvents btn10 As System.Windows.Forms.Button
    Friend WithEvents btn9 As System.Windows.Forms.Button
    Friend WithEvents btn8 As System.Windows.Forms.Button
    Friend WithEvents btn7 As System.Windows.Forms.Button
    Friend WithEvents btn6 As System.Windows.Forms.Button
    Friend WithEvents btn5 As System.Windows.Forms.Button
    Friend WithEvents btn4 As System.Windows.Forms.Button
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents btn1 As System.Windows.Forms.Button

End Class
