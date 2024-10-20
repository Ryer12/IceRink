Public Class frmItems
    Private LIBDatacontext As LibData.LIBDATADataContext

    Private Sub frmItems_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LIBDatacontext = New LibData.LibDataDataContext("Data Source=.\SQLEXPRESS;Initial Catalog=LibCRData;Integrated Security=True")

        Me.LIB_PRICE_LISTBindingSource.DataSource = LIBDatacontext.LIB_PRICE_LISTs

    End Sub

    Private Sub LIB_PRICE_LISTBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles LIB_PRICE_LISTBindingNavigatorSaveItem.Click
        LIB_PRICE_LISTBindingSource.EndEdit()
        LIBDatacontext.SubmitChanges()
    End Sub
End Class