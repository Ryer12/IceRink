<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transactions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transactions))
        Dim EODLabel As System.Windows.Forms.Label
        Dim LIBCashLabel As System.Windows.Forms.Label
        Dim LIBChkLabel As System.Windows.Forms.Label
        Dim LIBItemsLabel As System.Windows.Forms.Label
        Dim LIBLineLabel As System.Windows.Forms.Label
        Dim LIBPDateLabel As System.Windows.Forms.Label
        Dim LIBPTimeLabel As System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.LIB_TRANSACTIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LIB_TRANSACTIONBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.LIB_TRANSACTIONBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.EODCheckBox = New System.Windows.Forms.CheckBox()
        Me.LIBCashTextBox = New System.Windows.Forms.TextBox()
        Me.LIBChkTextBox = New System.Windows.Forms.TextBox()
        Me.LIBItemsTextBox = New System.Windows.Forms.TextBox()
        Me.LIBLineTextBox = New System.Windows.Forms.TextBox()
        Me.LIBPDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.LIBPTimeTextBox = New System.Windows.Forms.TextBox()
        EODLabel = New System.Windows.Forms.Label()
        LIBCashLabel = New System.Windows.Forms.Label()
        LIBChkLabel = New System.Windows.Forms.Label()
        LIBItemsLabel = New System.Windows.Forms.Label()
        LIBLineLabel = New System.Windows.Forms.Label()
        LIBPDateLabel = New System.Windows.Forms.Label()
        LIBPTimeLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.LIB_TRANSACTIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIB_TRANSACTIONBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LIB_TRANSACTIONBindingNavigator.SuspendLayout()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(237, 255)
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
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "OK"
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(76, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(67, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Cancel"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Button1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Button2, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(630, 615)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel2.TabIndex = 33
        '
        'LIB_TRANSACTIONBindingSource
        '
        Me.LIB_TRANSACTIONBindingSource.DataSource = GetType(LibData.LIB_TRANSACTION)
        '
        'LIB_TRANSACTIONBindingNavigator
        '
        Me.LIB_TRANSACTIONBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.LIB_TRANSACTIONBindingNavigator.BindingSource = Me.LIB_TRANSACTIONBindingSource
        Me.LIB_TRANSACTIONBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.LIB_TRANSACTIONBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.LIB_TRANSACTIONBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.LIB_TRANSACTIONBindingNavigatorSaveItem})
        Me.LIB_TRANSACTIONBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.LIB_TRANSACTIONBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.LIB_TRANSACTIONBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.LIB_TRANSACTIONBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.LIB_TRANSACTIONBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.LIB_TRANSACTIONBindingNavigator.Name = "LIB_TRANSACTIONBindingNavigator"
        Me.LIB_TRANSACTIONBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.LIB_TRANSACTIONBindingNavigator.Size = New System.Drawing.Size(395, 25)
        Me.LIB_TRANSACTIONBindingNavigator.TabIndex = 34
        Me.LIB_TRANSACTIONBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'LIB_TRANSACTIONBindingNavigatorSaveItem
        '
        Me.LIB_TRANSACTIONBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LIB_TRANSACTIONBindingNavigatorSaveItem.Image = CType(resources.GetObject("LIB_TRANSACTIONBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.LIB_TRANSACTIONBindingNavigatorSaveItem.Name = "LIB_TRANSACTIONBindingNavigatorSaveItem"
        Me.LIB_TRANSACTIONBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.LIB_TRANSACTIONBindingNavigatorSaveItem.Text = "Save Data"
        '
        'EODLabel
        '
        EODLabel.AutoSize = True
        EODLabel.Location = New System.Drawing.Point(65, 62)
        EODLabel.Name = "EODLabel"
        EODLabel.Size = New System.Drawing.Size(33, 13)
        EODLabel.TabIndex = 34
        EODLabel.Text = "EOD:"
        '
        'EODCheckBox
        '
        Me.EODCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LIB_TRANSACTIONBindingSource, "EOD", True))
        Me.EODCheckBox.Location = New System.Drawing.Point(104, 57)
        Me.EODCheckBox.Name = "EODCheckBox"
        Me.EODCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.EODCheckBox.TabIndex = 35
        Me.EODCheckBox.Text = "CheckBox1"
        Me.EODCheckBox.UseVisualStyleBackColor = True
        '
        'LIBCashLabel
        '
        LIBCashLabel.AutoSize = True
        LIBCashLabel.Location = New System.Drawing.Point(48, 90)
        LIBCashLabel.Name = "LIBCashLabel"
        LIBCashLabel.Size = New System.Drawing.Size(34, 13)
        LIBCashLabel.TabIndex = 36
        LIBCashLabel.Text = "Cash:"
        '
        'LIBCashTextBox
        '
        Me.LIBCashTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LIB_TRANSACTIONBindingSource, "LIBCash", True))
        Me.LIBCashTextBox.Location = New System.Drawing.Point(104, 87)
        Me.LIBCashTextBox.Name = "LIBCashTextBox"
        Me.LIBCashTextBox.Size = New System.Drawing.Size(200, 20)
        Me.LIBCashTextBox.TabIndex = 37
        '
        'LIBChkLabel
        '
        LIBChkLabel.AutoSize = True
        LIBChkLabel.Location = New System.Drawing.Point(53, 116)
        LIBChkLabel.Name = "LIBChkLabel"
        LIBChkLabel.Size = New System.Drawing.Size(41, 13)
        LIBChkLabel.TabIndex = 38
        LIBChkLabel.Text = "Check:"
        '
        'LIBChkTextBox
        '
        Me.LIBChkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LIB_TRANSACTIONBindingSource, "LIBChk", True))
        Me.LIBChkTextBox.Location = New System.Drawing.Point(104, 113)
        Me.LIBChkTextBox.Name = "LIBChkTextBox"
        Me.LIBChkTextBox.Size = New System.Drawing.Size(200, 20)
        Me.LIBChkTextBox.TabIndex = 39
        '
        'LIBItemsLabel
        '
        LIBItemsLabel.AutoSize = True
        LIBItemsLabel.Location = New System.Drawing.Point(47, 142)
        LIBItemsLabel.Name = "LIBItemsLabel"
        LIBItemsLabel.Size = New System.Drawing.Size(42, 13)
        LIBItemsLabel.TabIndex = 40
        LIBItemsLabel.Text = "# Items"
        '
        'LIBItemsTextBox
        '
        Me.LIBItemsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LIB_TRANSACTIONBindingSource, "LIBItems", True))
        Me.LIBItemsTextBox.Location = New System.Drawing.Point(104, 139)
        Me.LIBItemsTextBox.Name = "LIBItemsTextBox"
        Me.LIBItemsTextBox.Size = New System.Drawing.Size(60, 20)
        Me.LIBItemsTextBox.TabIndex = 41
        '
        'LIBLineLabel
        '
        LIBLineLabel.AutoSize = True
        LIBLineLabel.Location = New System.Drawing.Point(52, 168)
        LIBLineLabel.Name = "LIBLineLabel"
        LIBLineLabel.Size = New System.Drawing.Size(30, 13)
        LIBLineLabel.TabIndex = 42
        LIBLineLabel.Text = "Line:"
        '
        'LIBLineTextBox
        '
        Me.LIBLineTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LIB_TRANSACTIONBindingSource, "LIBLine", True))
        Me.LIBLineTextBox.Location = New System.Drawing.Point(104, 165)
        Me.LIBLineTextBox.Name = "LIBLineTextBox"
        Me.LIBLineTextBox.Size = New System.Drawing.Size(60, 20)
        Me.LIBLineTextBox.TabIndex = 43
        '
        'LIBPDateLabel
        '
        LIBPDateLabel.AutoSize = True
        LIBPDateLabel.Location = New System.Drawing.Point(65, 195)
        LIBPDateLabel.Name = "LIBPDateLabel"
        LIBPDateLabel.Size = New System.Drawing.Size(33, 13)
        LIBPDateLabel.TabIndex = 48
        LIBPDateLabel.Text = "Date:"
        '
        'LIBPDateDateTimePicker
        '
        Me.LIBPDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.LIB_TRANSACTIONBindingSource, "LIBPDate", True))
        Me.LIBPDateDateTimePicker.Location = New System.Drawing.Point(104, 191)
        Me.LIBPDateDateTimePicker.Name = "LIBPDateDateTimePicker"
        Me.LIBPDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.LIBPDateDateTimePicker.TabIndex = 49
        '
        'LIBPTimeLabel
        '
        LIBPTimeLabel.AutoSize = True
        LIBPTimeLabel.Location = New System.Drawing.Point(65, 220)
        LIBPTimeLabel.Name = "LIBPTimeLabel"
        LIBPTimeLabel.Size = New System.Drawing.Size(33, 13)
        LIBPTimeLabel.TabIndex = 52
        LIBPTimeLabel.Text = "Time:"
        '
        'LIBPTimeTextBox
        '
        Me.LIBPTimeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LIB_TRANSACTIONBindingSource, "LIBPTime", True))
        Me.LIBPTimeTextBox.Location = New System.Drawing.Point(104, 217)
        Me.LIBPTimeTextBox.Name = "LIBPTimeTextBox"
        Me.LIBPTimeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.LIBPTimeTextBox.TabIndex = 53
        '
        'Transactions
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(395, 296)
        Me.Controls.Add(EODLabel)
        Me.Controls.Add(Me.EODCheckBox)
        Me.Controls.Add(LIBCashLabel)
        Me.Controls.Add(Me.LIBCashTextBox)
        Me.Controls.Add(LIBChkLabel)
        Me.Controls.Add(Me.LIBChkTextBox)
        Me.Controls.Add(LIBItemsLabel)
        Me.Controls.Add(Me.LIBItemsTextBox)
        Me.Controls.Add(LIBLineLabel)
        Me.Controls.Add(Me.LIBLineTextBox)
        Me.Controls.Add(LIBPDateLabel)
        Me.Controls.Add(Me.LIBPDateDateTimePicker)
        Me.Controls.Add(LIBPTimeLabel)
        Me.Controls.Add(Me.LIBPTimeTextBox)
        Me.Controls.Add(Me.LIB_TRANSACTIONBindingNavigator)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Transactions"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Transactions"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.LIB_TRANSACTIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIB_TRANSACTIONBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LIB_TRANSACTIONBindingNavigator.ResumeLayout(False)
        Me.LIB_TRANSACTIONBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LIB_TRANSACTIONBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LIB_TRANSACTIONBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LIB_TRANSACTIONBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents EODCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents LIBCashTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LIBChkTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LIBItemsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LIBLineTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LIBPDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents LIBPTimeTextBox As System.Windows.Forms.TextBox

End Class
