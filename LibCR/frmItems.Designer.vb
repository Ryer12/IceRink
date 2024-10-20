<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItems
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
        Dim PLItemNameLabel As System.Windows.Forms.Label
        Dim PLLineLabel As System.Windows.Forms.Label
        Dim PLPriceLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmItems))
        Dim PriceNotSetLabel As System.Windows.Forms.Label
        Me.LIB_PRICE_LISTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LIB_PRICE_LISTBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.LIB_PRICE_LISTBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PLItemNameTextBox = New System.Windows.Forms.TextBox()
        Me.PLLineTextBox = New System.Windows.Forms.TextBox()
        Me.PLPriceTextBox = New System.Windows.Forms.TextBox()
        Me.PriceNotSetCheckBox = New System.Windows.Forms.CheckBox()
        PLItemNameLabel = New System.Windows.Forms.Label()
        PLLineLabel = New System.Windows.Forms.Label()
        PLPriceLabel = New System.Windows.Forms.Label()
        PriceNotSetLabel = New System.Windows.Forms.Label()
        CType(Me.LIB_PRICE_LISTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIB_PRICE_LISTBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LIB_PRICE_LISTBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'PLItemNameLabel
        '
        PLItemNameLabel.AutoSize = True
        PLItemNameLabel.Location = New System.Drawing.Point(37, 57)
        PLItemNameLabel.Name = "PLItemNameLabel"
        PLItemNameLabel.Size = New System.Drawing.Size(61, 13)
        PLItemNameLabel.TabIndex = 3
        PLItemNameLabel.Text = "Item Name:"
        '
        'PLLineLabel
        '
        PLLineLabel.AutoSize = True
        PLLineLabel.Location = New System.Drawing.Point(37, 83)
        PLLineLabel.Name = "PLLineLabel"
        PLLineLabel.Size = New System.Drawing.Size(40, 13)
        PLLineLabel.TabIndex = 5
        PLLineLabel.Text = "Line #:"
        '
        'PLPriceLabel
        '
        PLPriceLabel.AutoSize = True
        PLPriceLabel.Location = New System.Drawing.Point(37, 109)
        PLPriceLabel.Name = "PLPriceLabel"
        PLPriceLabel.Size = New System.Drawing.Size(34, 13)
        PLPriceLabel.TabIndex = 7
        PLPriceLabel.Text = "Price:"
        '
        'LIB_PRICE_LISTBindingSource
        '
        Me.LIB_PRICE_LISTBindingSource.DataSource = GetType(LibData.LIB_PRICE_LIST)
        '
        'LIB_PRICE_LISTBindingNavigator
        '
        Me.LIB_PRICE_LISTBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.LIB_PRICE_LISTBindingNavigator.BindingSource = Me.LIB_PRICE_LISTBindingSource
        Me.LIB_PRICE_LISTBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.LIB_PRICE_LISTBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.LIB_PRICE_LISTBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.LIB_PRICE_LISTBindingNavigatorSaveItem})
        Me.LIB_PRICE_LISTBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.LIB_PRICE_LISTBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.LIB_PRICE_LISTBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.LIB_PRICE_LISTBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.LIB_PRICE_LISTBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.LIB_PRICE_LISTBindingNavigator.Name = "LIB_PRICE_LISTBindingNavigator"
        Me.LIB_PRICE_LISTBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.LIB_PRICE_LISTBindingNavigator.Size = New System.Drawing.Size(356, 25)
        Me.LIB_PRICE_LISTBindingNavigator.TabIndex = 0
        Me.LIB_PRICE_LISTBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'LIB_PRICE_LISTBindingNavigatorSaveItem
        '
        Me.LIB_PRICE_LISTBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LIB_PRICE_LISTBindingNavigatorSaveItem.Image = CType(resources.GetObject("LIB_PRICE_LISTBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.LIB_PRICE_LISTBindingNavigatorSaveItem.Name = "LIB_PRICE_LISTBindingNavigatorSaveItem"
        Me.LIB_PRICE_LISTBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.LIB_PRICE_LISTBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PLItemNameTextBox
        '
        Me.PLItemNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LIB_PRICE_LISTBindingSource, "PLItemName", True))
        Me.PLItemNameTextBox.Location = New System.Drawing.Point(117, 54)
        Me.PLItemNameTextBox.Name = "PLItemNameTextBox"
        Me.PLItemNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PLItemNameTextBox.TabIndex = 4
        '
        'PLLineTextBox
        '
        Me.PLLineTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LIB_PRICE_LISTBindingSource, "PLLine", True))
        Me.PLLineTextBox.Location = New System.Drawing.Point(117, 80)
        Me.PLLineTextBox.Name = "PLLineTextBox"
        Me.PLLineTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PLLineTextBox.TabIndex = 6
        '
        'PLPriceTextBox
        '
        Me.PLPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LIB_PRICE_LISTBindingSource, "PLPrice", True))
        Me.PLPriceTextBox.Location = New System.Drawing.Point(117, 106)
        Me.PLPriceTextBox.Name = "PLPriceTextBox"
        Me.PLPriceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PLPriceTextBox.TabIndex = 8
        '
        'PriceNotSetLabel
        '
        PriceNotSetLabel.AutoSize = True
        PriceNotSetLabel.Location = New System.Drawing.Point(38, 137)
        PriceNotSetLabel.Name = "PriceNotSetLabel"
        PriceNotSetLabel.Size = New System.Drawing.Size(73, 13)
        PriceNotSetLabel.TabIndex = 8
        PriceNotSetLabel.Text = "Price Not Set:"
        '
        'PriceNotSetCheckBox
        '
        Me.PriceNotSetCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LIB_PRICE_LISTBindingSource, "PriceNotSet", True))
        Me.PriceNotSetCheckBox.Location = New System.Drawing.Point(117, 132)
        Me.PriceNotSetCheckBox.Name = "PriceNotSetCheckBox"
        Me.PriceNotSetCheckBox.Size = New System.Drawing.Size(124, 41)
        Me.PriceNotSetCheckBox.TabIndex = 9
        Me.PriceNotSetCheckBox.Text = " Checked if price varies"
        Me.PriceNotSetCheckBox.UseVisualStyleBackColor = True
        '
        'frmItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 185)
        Me.Controls.Add(PriceNotSetLabel)
        Me.Controls.Add(Me.PriceNotSetCheckBox)
        Me.Controls.Add(PLItemNameLabel)
        Me.Controls.Add(Me.PLItemNameTextBox)
        Me.Controls.Add(PLLineLabel)
        Me.Controls.Add(Me.PLLineTextBox)
        Me.Controls.Add(PLPriceLabel)
        Me.Controls.Add(Me.PLPriceTextBox)
        Me.Controls.Add(Me.LIB_PRICE_LISTBindingNavigator)
        Me.Name = "frmItems"
        Me.Text = "frmItems"
        CType(Me.LIB_PRICE_LISTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIB_PRICE_LISTBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LIB_PRICE_LISTBindingNavigator.ResumeLayout(False)
        Me.LIB_PRICE_LISTBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LIB_PRICE_LISTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LIB_PRICE_LISTBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents LIB_PRICE_LISTBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PLItemNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PLLineTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PLPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PriceNotSetCheckBox As System.Windows.Forms.CheckBox
End Class
