Imports System.Data
Imports System.Linq
Imports System.Data.EntityClient
Imports System.Data.Objects
Imports System.Drawing.Printing
Imports LibData

Public Class Transactions
    Private LibDataContext As LIBDATADataContext
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        LIB_TRANSACTIONBindingSource.EndEdit()
        LibDataContext.SubmitChanges()
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Dialog1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LibDataContext = New LibData.LibDataDataContext("Data Source=.\SQLEXPRESS;Initial Catalog=LibCRData;Integrated Security=True")
        Dim Trans = From t In LibDataContext.LIB_TRANSACTIONs Order By t.LIBPDate Descending

        Me.LIB_TRANSACTIONBindingSource.DataSource = Trans

    End Sub

    Private Sub LIB_TRANSACTIONBindingNavigatorSaveItem_Click_1(sender As System.Object, e As System.EventArgs) Handles LIB_TRANSACTIONBindingNavigatorSaveItem.Click
        LIB_TRANSACTIONBindingSource.EndEdit()
        LibDataContext.SubmitChanges()
    End Sub
End Class
