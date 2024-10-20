Imports LibData
Imports System.Data
Imports System.Linq
Imports System.Data.EntityClient
Imports System.Data.Objects
Imports System.Drawing.Printing
Public Class Create_DB

    Private Sub Create_DB_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim libdatacontext2 As New LibDataDataContext("Data Source=.\SQLEXPRESS;Integrated Security=True")
        'Checks if database exists and creates if not.
        If libdatacontext2.DatabaseExists Then
            MsgBox("tables exsist")
        Else
            libdatacontext2.CreateDatabase()

        End If


    End Sub
End Class