<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LibCRMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LibCRMain))
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.lblDailyTotal = New System.Windows.Forms.Label()
        Me.cmdStartOver = New System.Windows.Forms.Button()
        Me.cmdCommit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdCheck = New System.Windows.Forms.Button()
        Me.cmdNoSale = New System.Windows.Forms.Button()
        Me.cmdCredit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(480, 529)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(112, 24)
        Me.lblTotal.TabIndex = 42
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(352, 529)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 24)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Amout Due  "
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem3})
        Me.MenuItem1.Text = "&File"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 0
        Me.MenuItem3.Text = "E&Xit"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem4, Me.MenuItem5, Me.MenuItem6, Me.MenuItem7})
        Me.MenuItem2.Text = "System"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 0
        Me.MenuItem4.Text = "End of day printout"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 1
        Me.MenuItem5.Text = "Edit Items"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 2
        Me.MenuItem6.Text = "create tables"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 3
        Me.MenuItem7.Text = "Transactions"
        '
        'lblDailyTotal
        '
        Me.lblDailyTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDailyTotal.Location = New System.Drawing.Point(480, 561)
        Me.lblDailyTotal.Name = "lblDailyTotal"
        Me.lblDailyTotal.Size = New System.Drawing.Size(112, 24)
        Me.lblDailyTotal.TabIndex = 34
        Me.lblDailyTotal.Visible = False
        '
        'cmdStartOver
        '
        Me.cmdStartOver.BackColor = System.Drawing.SystemColors.Control
        Me.cmdStartOver.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdStartOver.Location = New System.Drawing.Point(224, 409)
        Me.cmdStartOver.Name = "cmdStartOver"
        Me.cmdStartOver.Size = New System.Drawing.Size(168, 96)
        Me.cmdStartOver.TabIndex = 36
        Me.cmdStartOver.Text = "Start Over"
        Me.cmdStartOver.UseVisualStyleBackColor = False
        '
        'cmdCommit
        '
        Me.cmdCommit.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCommit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCommit.Location = New System.Drawing.Point(424, 409)
        Me.cmdCommit.Name = "cmdCommit"
        Me.cmdCommit.Size = New System.Drawing.Size(168, 96)
        Me.cmdCommit.TabIndex = 35
        Me.cmdCommit.Text = "Cash Sale"
        Me.cmdCommit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(360, 561)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 24)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Daily Total "
        Me.Label1.Visible = False
        '
        'cmdCheck
        '
        Me.cmdCheck.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCheck.Location = New System.Drawing.Point(598, 409)
        Me.cmdCheck.Name = "cmdCheck"
        Me.cmdCheck.Size = New System.Drawing.Size(87, 96)
        Me.cmdCheck.TabIndex = 43
        Me.cmdCheck.Text = "Check Sale"
        Me.cmdCheck.UseVisualStyleBackColor = False
        '
        'cmdNoSale
        '
        Me.cmdNoSale.BackColor = System.Drawing.SystemColors.Control
        Me.cmdNoSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNoSale.Location = New System.Drawing.Point(588, 524)
        Me.cmdNoSale.Name = "cmdNoSale"
        Me.cmdNoSale.Size = New System.Drawing.Size(87, 96)
        Me.cmdNoSale.TabIndex = 44
        Me.cmdNoSale.Text = "No Sale"
        Me.cmdNoSale.UseVisualStyleBackColor = False
        '
        'cmdCredit
        '
        Me.cmdCredit.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCredit.Location = New System.Drawing.Point(76, 524)
        Me.cmdCredit.Name = "cmdCredit"
        Me.cmdCredit.Size = New System.Drawing.Size(87, 96)
        Me.cmdCredit.TabIndex = 46
        Me.cmdCredit.Text = "Credit"
        Me.cmdCredit.UseVisualStyleBackColor = False
        '
        'LibCRMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1113, 815)
        Me.Controls.Add(Me.cmdCredit)
        Me.Controls.Add(Me.cmdNoSale)
        Me.Controls.Add(Me.cmdCheck)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblDailyTotal)
        Me.Controls.Add(Me.cmdStartOver)
        Me.Controls.Add(Me.cmdCommit)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Menu = Me.MainMenu1
        Me.Name = "LibCRMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stuff"
        Me.TransparencyKey = System.Drawing.Color.OrangeRed
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents lblDailyTotal As System.Windows.Forms.Label
    Friend WithEvents cmdStartOver As System.Windows.Forms.Button
    Friend WithEvents cmdCommit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents cmdCheck As System.Windows.Forms.Button
    Friend WithEvents cmdNoSale As System.Windows.Forms.Button
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents cmdCredit As System.Windows.Forms.Button

End Class
