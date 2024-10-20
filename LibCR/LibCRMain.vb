Imports LibData
Imports System.Data
Imports System.Linq
Imports System.Data.EntityClient
Imports System.Data.Objects
Imports System.Drawing.Printing



Public Class LibCRMain
    Dim arraysize As Integer
    Dim columsize As Integer = 3
    Dim MyItemButton() As Button
    Dim MyLabel() As Label
    Dim MyTextbox() As TextBox
    Dim PLID() As Integer
    Dim MyNoticeLabel As Label
    Dim MyTimerTextBox As TextBox
    Dim MyButton As Button
    Dim MyTimer As Timer
    Dim i1 As Int32
    Dim SumTotal As Double
    Private LibDataContext As LibDataDataContext
    Private Sub LibCRMain_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        'MsgBox("did it")
        Dim ktp = From btn As Button In Me.Controls.OfType(Of Button)() _
                  Where btn.Text.ToLower = Char.ToLower(e.KeyChar) _
                  Select btn

        If ktp.Count > 0 Then ktp.First.PerformClick()
    End Sub
    

    Private Sub LibCRMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        SumTotal = 0
        'LibDataContext = New LibDataDataContext("Data Source=MIS-SUPPORT\SQLEXPRESS;Initial Catalog=LibCRData;Integrated Security=True")'database on remote computer
        LibDataContext = New LibDataDataContext("Data Source=.\SQLEXPRESS;Initial Catalog=LibCRData;Integrated Security=True") 'Database on self
        If LibDataContext.DatabaseExists Then
            'MsgBox("tables exsist")
        Else
            LibDataContext.CreateDatabase()

        End If
        Me.Text = My.Resources.SiteName
        Me.Icon = My.Resources.favicon
        DynamicArrayOfControls()
        ConfigureForm()
        RefreshData()


        'DynamicControls()

    End Sub

    Private Sub RefreshData()
        Try
            Dim query = Aggregate lib_Transaction In LibDataContext.LIB_TRANSACTIONs _
                        Where lib_Transaction.EOD = False And lib_Transaction.ORAUpdate = False And lib_Transaction.LibLocation = My.Resources.SiteName _
                        Into Daytotal = Sum(lib_Transaction.LIBCash), Daycount = Count()
            lblDailyTotal.Text = String.Format(FormatCurrency(query.Daytotal, 2))
        Catch ex As Exception
            lblDailyTotal.Text = "$0.00"
        End Try

    End Sub

    Sub ConfigureForm()
        'arraysize = 3
        With Me
            .Width = 970
            .Height = 960
            .Text = My.Resources.SiteName
            .Icon = My.Resources.favicon
        End With
    End Sub

    Sub DynamicArrayOfControls()

        Dim PLs = From LIB_PRICE_LIST In LibDataContext.LIB_PRICE_LISTs
        'Dim countList = (From LIB_PRICE_LIST In LibDataContext.LIB_PRICE_LISTs).Count
        Dim i As Integer = 0
        arraysize = PLs.Count

        ReDim MyLabel(arraysize)
        ReDim MyTextbox(arraysize)
        ReDim MyItemButton(arraysize)
        ReDim PLID(arraysize)
        Dim x, y As Integer
        x = 1
        y = 1

        For Each LIB_PRICE_LIST In PLs
            'one button, textbox, id variable and label  for each item in the list
            i += 1
            PLID(i) = LIB_PRICE_LIST.LIBPLID
            MyItemButton(i) = New Button()
            With MyItemButton(i)
                .Name = "btn" + i.ToString
                .Top = -100 + (160 * y)
                .Left = -100 + (170 * x)
                .Font = New Font(.Font.FontFamily, 14, FontStyle.Bold)
                .Size = New Size(160, 130)
                If LIB_PRICE_LIST.PriceNotSet Then
                    .BackColor = Color.Teal
                    AddHandler .Click, AddressOf MyVarButton_Click
                Else
                    .BackColor = Color.Gainsboro
                    AddHandler .Click, AddressOf MyButton_Click
                End If
                '.BackColor = Color.Gainsboro
                .Text = LIB_PRICE_LIST.PLItemName
                'AddHandler .Click, AddressOf MyButton_Click
            End With
            Me.Controls.Add(MyItemButton(i))

            MyLabel(i) = New Label()
            With MyLabel(i)
                .Name = "lbl" + i.ToString
                .Text = LIB_PRICE_LIST.PLPrice
                .Visible = True
                .Top = 5 + (160 * y)
                .Left = -98 + (170 * x)
                .Width = 155
                .TextAlign = ContentAlignment.MiddleCenter
                .Parent = MyItemButton(i)
                .BackColor = Color.Gainsboro
            End With
            Me.Controls.Add(MyLabel(i))
            MyLabel(i).BringToFront()

            MyTextbox(i) = New TextBox()
            With MyTextbox(i)
                .Name = "Textbox" + i.ToString
                .Top = -100 + (160 * y)
                .Left = -100 + (170 * x)
                .Text = 0
                .Width = 155
                .TextAlign = HorizontalAlignment.Center
                
                'AddHandler .Click, AddressOf mymessage
            End With
            Me.Controls.Add(MyTextbox(i))
            MyTextbox(i).BringToFront()


            ' set grid layout

            If x < 3 Then
                x += 1
            Else
                x = 1
                If y < 6 Then
                    y += 1
                Else
                    y = 1

                End If

            End If
        Next
        'move and make the existing buttons look the same as the array
        With cmdNoSale
            .Top = -140 + (160 * y)
            .Left = 760
            .Font = New Font(.Font.FontFamily, 10, FontStyle.Bold)
            .Size = New Size(120, 30)
            .BackColor = Color.Gainsboro
        End With
        x += 1
        With cmdStartOver
            .Top = -100 + (160 * y)
            .Left = -100 + 760
            .Font = New Font(.Font.FontFamily, 14, FontStyle.Bold)
            .Size = New Size(100, 60)
            .BackColor = Color.Gainsboro
        End With
        
        With cmdCommit
            .Top = -40 + (160 * y)
            .Left = -100 + 760
            .Font = New Font(.Font.FontFamily, 14, FontStyle.Bold)
            .Size = New Size(100, 60)
            .BackColor = Color.Gainsboro
        End With
        With cmdCheck
            .Top = -40 + (160 * y)
            .Left = 760
            .Font = New Font(.Font.FontFamily, 10, FontStyle.Bold)
            .Size = New Size(60, 60)
            .BackColor = Color.Gainsboro
        End With

        With cmdCredit
            .Top = -100 + (160 * y)
            .Left = 760
            .Font = New Font(.Font.FontFamily, 10, FontStyle.Bold)
            .Size = New Size(60, 60)
            .BackColor = Color.Gainsboro
        End With


        y += 1
        With lblTotal
            .Top = -100 + (160 * y)
            .Left = 20 + 760


        End With
        With Label3
            .Top = -100 + (160 * y)
            .Left = -100 + 760
            .TextAlign = ContentAlignment.TopRight
            .Size = New Size(110, 24)
        End With


        With lblDailyTotal
            .Top = -70 + (160 * y)
            .Left = 20 + 760

        End With
        With Label1
            .Top = -70 + (160 * y)
            .Left = -100 + 60
            .TextAlign = ContentAlignment.TopRight
            .Size = New Size(110, 24)
        End With
    End Sub
    Sub mymessage(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim MyName As String = sender.name
        Dim MyHeight As String = sender.height.ToString
        Dim MyWidth As String = sender.Width.ToString
        Dim MyType As String = sender.GetType.ToString
        MyType = Mid(MyType, InStrRev(MyType, ".") + 1, Len(MyType))
        MsgBox("Hi" + vbNewLine + _
               "My Name is " + MyName + " and I am a " + MyType + vbNewLine + _
               "I am " + MyHeight + " Pixels tall and " + MyWidth + " Pixels wide.")


    End Sub


    Private Sub MyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim MyName As String = sender.name
        Dim trimbtn As Char() = "btn"
        Dim MyID As String = MyName.Trim(trimbtn)
        MyTextbox(MyID).Text += 1
        FindTotal()


    End Sub
    Private Sub MyVarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim MyName As String = sender.name
        Dim trimbtn As Char() = "btn"
        Dim MyID As String = MyName.Trim(trimbtn)
        MyTextbox(MyID).Text = 1
        If dlgCalc.ShowDialog = Windows.Forms.DialogResult.OK Then
            MyLabel(MyID).Text = dlgCalc.textbostext
        Else
            MyLabel(MyID).Text = 0
        End If

        FindTotal()
    End Sub
    Sub FindTotal()
        SumTotal = 0
        Dim Vallbl, valtxt As Double
        For i = 1 To arraysize
            Vallbl = MyLabel(i).Text
            valtxt = MyTextbox(i).Text
            SumTotal += (Vallbl * valtxt)
            lblTotal.Text = String.Format(FormatCurrency(SumTotal, 2))
        Next
    End Sub

    Private Sub cmdStartOver_Click(sender As System.Object, e As System.EventArgs) Handles cmdStartOver.Click
        For i = 1 To arraysize
            MyTextbox(i).Text = 0
            lblTotal.Text = "$0.00"
        Next
    End Sub

    Private Sub cmdCommit_Click(sender As System.Object, e As System.EventArgs) Handles cmdCommit.Click
        For i = 1 To arraysize
            If MyTextbox(i).Text > 0 Then
                Try
                    Dim PL = LibDataContext.LIB_PRICE_LISTs.Single(Function(id) id.LIBPLID = PLID(i))
                    Dim newtrans = New LIB_TRANSACTION _
                                   With {.LIBPLID = PLID(i), .LIBLine = PL.PLLine, .LIBItems = MyTextbox(i).Text, _
                                         .LIBPDate = Today.ToShortDateString, .LIBPTime = Now.TimeOfDay, .ORAUpdate = False, _
                                         .LibLocation = My.Resources.SiteName, .EOD = False, .LIBChk = 0, .LIBCash = (MyLabel(i).Text * MyTextbox(i).Text)}
                    PL.LIB_TRANSACTIONs.Add(newtrans)
                Catch ex As Exception
                    MsgBox("Update failed")
                End Try
            End If
        Next
        If lblTotal.Text > 0 Then
            Dim mydoc As New Printing.PrintDocument
            Dim myprinter As New PrintDialog
            myprinter.Document = mydoc
            AddHandler mydoc.PrintPage, AddressOf Me.PrintPage
            mydoc.Print()
        End If

        LibDataContext.SubmitChanges()
        cmdStartOver.PerformClick()
        RefreshData()

    End Sub

    Private Sub MenuItem2_Click(sender As System.Object, e As System.EventArgs)
        frmItems.Show()
    End Sub

    Private Sub MenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles MenuItem3.Click
        Me.Close()
    End Sub

    Private Sub PrintPage(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Dim LinesPerPage As Single = 0
        Dim Start As Single = 0
        Dim LineNumber As Short = 2
        Dim total As Double = 0
        Dim i As Integer = 0
        Dim s As String = Nothing
        Dim drawFont As New Font("Arial", 9, FontStyle.Regular)
        Dim totalFont As New Font("Arial", 10, FontStyle.Bold)
        Dim titleFont As New Font("Arial", 11, FontStyle.Underline)
        Dim bigFont As New Font("Arial", 13, FontStyle.Bold)
        Dim colOne As Integer = 100
        Dim colTwo As Integer = 65
        Dim colThree As Integer = 90
        Start = ev.PageBounds.Top + drawFont.GetHeight(ev.Graphics) * LineNumber
        ev.Graphics.DrawString(My.Resources.SiteName, bigFont, Brushes.Black, ev.MarginBounds.Left - colOne, Start)
        LineNumber += 2
        Start = ev.PageBounds.Top + drawFont.GetHeight(ev.Graphics) * LineNumber
        ev.Graphics.DrawString("Amt", titleFont, Brushes.Black, ev.MarginBounds.Left - colOne, Start)
        ev.Graphics.DrawString("Description", titleFont, Brushes.Black, ev.MarginBounds.Left - 65, Start)
        ev.Graphics.DrawString("Price", titleFont, Brushes.Black, ev.MarginBounds.Left + 90, Start)
        LineNumber += 1
        For i = 1 To arraysize
            If MyTextbox(i).Text > 0 Then
                Try
                    Dim PL = LibDataContext.LIB_PRICE_LISTs.Single(Function(id) id.LIBPLID = PLID(i))
                    Start = ev.PageBounds.Top + drawFont.GetHeight(ev.Graphics) * LineNumber
                    ev.Graphics.DrawString(MyTextbox(i).Text, totalFont, Brushes.Black, ev.MarginBounds.Left - colOne, Start)
                    If MyItemButton(i).Text.Length > 22 Then
                        ev.Graphics.DrawString(MyItemButton(i).Text.Substring(0, 22), totalFont, Brushes.Black, ev.MarginBounds.Left - 65, Start)
                    Else
                        ev.Graphics.DrawString(MyItemButton(i).Text, totalFont, Brushes.Black, ev.MarginBounds.Left - 65, Start)
                    End If
                    ev.Graphics.DrawString(CStr(Format((MyTextbox(i).Text * MyLabel(i).Text), "$###0.00")), totalFont, Brushes.Black, ev.MarginBounds.Left + 90, Start)
                    LineNumber += 1
                    total += (MyTextbox(i).Text * MyLabel(i).Text)
                Catch ex As Exception
                    MsgBox("Print failed for " & MyItemButton(i).Text)
            End Try
            End If
        Next

        LineNumber += 2
        Start = ev.PageBounds.Top + drawFont.GetHeight(ev.Graphics) * LineNumber
        ev.Graphics.DrawString("Total............." + CStr(Format(total, "$###0.00")), totalFont, Brushes.Black, ev.MarginBounds.Left - 65, Start)
        LineNumber += 1
        Start = ev.PageBounds.Top + drawFont.GetHeight(ev.Graphics) * LineNumber
        ev.Graphics.DrawString("Time:  " + CStr(Now), drawFont, Brushes.Black, ev.MarginBounds.Left - 65, Start)
        ' printed at the pot of next receipt
        LineNumber += 4
        Start = ev.PageBounds.Top + drawFont.GetHeight(ev.Graphics) * LineNumber
        ev.Graphics.DrawString("------------------------------", drawFont, Brushes.Black, ev.MarginBounds.Left - 40, Start)
        'Start = ev.PageBounds.Top + drawFont.GetHeight(ev.Graphics) * LineNumber
        ev.Graphics.DrawString(" ", drawFont, Brushes.Black, ev.MarginBounds.Right - 350, Start * LineNumber)
        'TabControl1.SelectedTab = TabPage1
    End Sub
    Private Sub EndOfDay()
        Dim mydoc As New Printing.PrintDocument
        Dim myprinter As New PrintDialog
        myprinter.Document = mydoc
        AddHandler mydoc.PrintPage, AddressOf Me.EndOfDayPrint
        mydoc.Print()
    End Sub
    Private Sub EndOfDayPrint(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Dim LinesPerPage As Single = 0
        Dim Start As Single = 0
        Dim LineNumber As Short = 2
        Dim totalCA As Double = 0
        Dim totalCK As Double = 0
        Dim i As Integer = 0
        Dim s As String = Nothing
        Dim drawFont As New Font("Arial", 10)
        Dim totalFont As New Font("Arial", 10, FontStyle.Bold)
        Dim titleFont As New Font("Arial", 11, FontStyle.Underline)
        Dim bigFont As New Font("Arial", 12, FontStyle.Italic)
        Dim colOne As Integer = 100
        Dim colTwo As Integer = 65
        Dim colThree As Integer = 90
        Start = ev.PageBounds.Top + drawFont.GetHeight(ev.Graphics) * LineNumber
        ev.Graphics.DrawString("End of day report for " & My.Resources.SiteName, bigFont, Brushes.Black, ev.MarginBounds.Left - 90, Start)
        LineNumber += 2
        Start = ev.PageBounds.Top + drawFont.GetHeight(ev.Graphics) * LineNumber
        ev.Graphics.DrawString("#", titleFont, Brushes.Black, ev.MarginBounds.Left - colOne, Start)
        ev.Graphics.DrawString("Description", titleFont, Brushes.Black, ev.MarginBounds.Left - 65, Start)
        ev.Graphics.DrawString("line total", titleFont, Brushes.Black, ev.MarginBounds.Left + 90, Start)
        LineNumber += 1
        Dim Trans = From LT In LibDataContext.LIB_TRANSACTIONs _
                    Where LT.LibLocation = My.Resources.SiteName _
                    And LT.ORAUpdate = False _
                    And LT.EOD = False _
                    Group By Item = LT.LIB_PRICE_LIST.PLItemName _
                    Into ItemTotal = Sum(LT.LIBCash), ItemCount = Sum(LT.LIBItems), chkTotal = Sum(LT.LIBChk) _
                    Order By Item

        For Each LT In Trans
            'Dim PL = LibDataContext.LIB_PRICE_LISTs.Single(Function(id) id.LIBPLID = PLID(i))
            Start = ev.PageBounds.Top + drawFont.GetHeight(ev.Graphics) * LineNumber
            ev.Graphics.DrawString(LT.ItemCount, drawFont, Brushes.Black, ev.MarginBounds.Left - colOne, Start)
            If LT.Item.Length > 22 Then
                ev.Graphics.DrawString(LT.Item.Substring(0, 22), drawFont, Brushes.Black, ev.MarginBounds.Left - 65, Start)
            Else
                ev.Graphics.DrawString(LT.Item, drawFont, Brushes.Black, ev.MarginBounds.Left - 65, Start)
            End If
            ev.Graphics.DrawString(CStr(Format(LT.ItemTotal, "$###0.00") + "C"), drawFont, Brushes.Black, ev.MarginBounds.Left + 90, Start)
            LineNumber += 1
            Start = ev.PageBounds.Top + drawFont.GetHeight(ev.Graphics) * LineNumber
            ev.Graphics.DrawString(CStr(Format(LT.chkTotal, "$###0.00") + "CK"), drawFont, Brushes.Black, ev.MarginBounds.Left + 90, Start)
            LineNumber += 1
            totalCA += LT.ItemTotal
            totalCK += LT.chkTotal

            'MsgBox(LIB_TRANSACTION.Item & "    " & Format(LIB_TRANSACTION.ItemTotal.Value, "##.00"))
        Next
        LineNumber += 2
        Start = ev.PageBounds.Top + drawFont.GetHeight(ev.Graphics) * LineNumber
        ev.Graphics.DrawString("Total Cash........" + CStr(Format(totalCA, "$###0.00")), totalFont, Brushes.Black, ev.MarginBounds.Left - 65, Start)
        LineNumber += 1
        Start = ev.PageBounds.Top + drawFont.GetHeight(ev.Graphics) * LineNumber
        ev.Graphics.DrawString("Total Check......." + CStr(Format(totalCK, "$###0.00")), totalFont, Brushes.Black, ev.MarginBounds.Left - 65, Start)
        LineNumber += 1
        Start = ev.PageBounds.Top + drawFont.GetHeight(ev.Graphics) * LineNumber
        ev.Graphics.DrawString("Total for Day......" + CStr(Format((totalCK + totalCA), "$###0.00")), totalFont, Brushes.Black, ev.MarginBounds.Left - 65, Start)
        LineNumber += 1
        Start = ev.PageBounds.Top + drawFont.GetHeight(ev.Graphics) * LineNumber
        ev.Graphics.DrawString("Time:  " + CStr(Now), drawFont, Brushes.Black, ev.MarginBounds.Left - 65, Start)
        ' printed at the pot of next receipt
        LineNumber += 4
        Start = ev.PageBounds.Top + drawFont.GetHeight(ev.Graphics) * LineNumber
        ev.Graphics.DrawString("------------------------------", drawFont, Brushes.Black, ev.MarginBounds.Left - 40, Start)
        'Start = ev.PageBounds.Top + drawFont.GetHeight(ev.Graphics) * LineNumber
        ev.Graphics.DrawString(" ", drawFont, Brushes.Black, ev.MarginBounds.Right - 350, Start * LineNumber)
        'TabControl1.SelectedTab = TabPage1

        'Dim q = From p In LibDataContext.LIB_TRANSACTIONs _
        '        Where p.ORAUpdate = False And p.EOD = False And p.LibLocation = My.Resources.SiteName
        '        Select p
        'Dim LDC As LibDataDataContext = New LibDataDataContext("Data Source=MIS-SUPPORT\SQLEXPRESS;Initial Catalog=LibCRData;Integrated Security=True")
        Dim LDC As LibDataDataContext = New LibDataDataContext("Data Source=.\SQLEXPRESS;Initial Catalog=LibCRData;Integrated Security=True")

        Dim q = From p In LDC.LIB_TRANSACTIONs _
                Where p.ORAUpdate = False And p.EOD = False And p.LibLocation = My.Resources.SiteName
        '       Select p

        For Each p In q
            p.EOD = True
        Next
        LDC.SubmitChanges()
        cmdStartOver.PerformClick()
        'RefreshData()
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        If InputBox("Enter password", "End of day") = My.Resources.EODPassword Then
            EndOfDay()
        End If
        Me.Close()
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmItems.Show()

    End Sub

    Private Function DBNull() As Object
        Throw New NotImplementedException
    End Function

    Private Sub cmdCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCheck.Click
        For i = 1 To arraysize
            If MyTextbox(i).Text > 0 Then
                Try
                    Dim PL = LibDataContext.LIB_PRICE_LISTs.Single(Function(id) id.LIBPLID = PLID(i))
                    Dim newtrans = New LIB_TRANSACTION _
                                   With {.LIBPLID = PLID(i), .LIBLine = PL.PLLine, .LIBItems = MyTextbox(i).Text, _
                                         .LIBPDate = Today.ToShortDateString, .LIBPTime = Now.TimeOfDay, .ORAUpdate = False, _
                                         .LibLocation = My.Resources.SiteName, .EOD = False, .LIBCash = 0, .LIBChk = (MyLabel(i).Text * MyTextbox(i).Text)}
                    PL.LIB_TRANSACTIONs.Add(newtrans)
                Catch ex As Exception
                    MsgBox("Update failed")
                End Try
            End If
        Next
        If lblTotal.Text > 0 Then
            Dim mydoc As New Printing.PrintDocument
            Dim myprinter As New PrintDialog
            myprinter.Document = mydoc
            AddHandler mydoc.PrintPage, AddressOf Me.PrintPage
            mydoc.Print()
        End If

        LibDataContext.SubmitChanges()
        cmdStartOver.PerformClick()
        RefreshData()
    End Sub

    Private Sub cmdNoSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNoSale.Click

        Dim mydoc As New Printing.PrintDocument
        Dim myprinter As New PrintDialog
        myprinter.Document = mydoc
        AddHandler mydoc.PrintPage, AddressOf Me.NoSalePrint
        mydoc.Print()

    End Sub
    Private Sub NoSalePrint(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Dim LinesPerPage As Single = 0
        Dim Start As Single = 0
        Dim LineNumber As Short = 0
        Dim totalCA As Double = 0
        Dim totalCK As Double = 0
        Dim i As Integer = 0
        Dim s As String = Nothing
        Dim drawFont As New Font("Arial", 10)
        Dim totalFont As New Font("Arial", 10, FontStyle.Bold)
        Dim titleFont As New Font("Arial", 11, FontStyle.Underline)
        Dim bigFont As New Font("Arial", 25, FontStyle.Italic)
        Dim colOne As Integer = 100
        Dim colTwo As Integer = 65
        Dim colThree As Integer = 90
        Start = ev.PageBounds.Top + drawFont.GetHeight(ev.Graphics) * LineNumber
        ev.Graphics.DrawString("No Sale ", bigFont, Brushes.Black, ev.MarginBounds.Left - 90, Start)
        LineNumber += 3
        Start = ev.PageBounds.Top + drawFont.GetHeight(ev.Graphics) * LineNumber
        ev.Graphics.DrawString("Time:  " + CStr(Now), drawFont, Brushes.Black, ev.MarginBounds.Left - 65, Start)
        ' printed at the pot of next receipt
        LineNumber += 2
        Start = ev.PageBounds.Top + drawFont.GetHeight(ev.Graphics) * LineNumber
        ev.Graphics.DrawString("------------------------------", drawFont, Brushes.Black, ev.MarginBounds.Left - 40, Start)
        'Start = ev.PageBounds.Top + drawFont.GetHeight(ev.Graphics) * LineNumber
        ev.Graphics.DrawString(" ", drawFont, Brushes.Black, ev.MarginBounds.Right - 350, Start * LineNumber)
        'TabControl1.SelectedTab = TabPage1

        'Dim q = From p In LibDataContext.LIB_TRANSACTIONs _
        '        Where p.ORAUpdate = False And p.EOD = False And p.LibLocation = My.Resources.SiteName
        '        Select p
        'Dim LDC As LibDataDataContext = New LibDataDataContext("Data Source=MIS-SUPPORT\SQLEXPRESS;Initial Catalog=LibCRData;Integrated Security=True")
       
    End Sub

    Private Sub MenuItem5_Click_1(sender As System.Object, e As System.EventArgs) Handles MenuItem5.Click
        frmItems.Show()

    End Sub

    Private Sub MenuItem6_Click(sender As System.Object, e As System.EventArgs) Handles MenuItem6.Click

        If InputBox("enter password") <> "//chargers" Then
            'Dim libdatacontext2 As New LibDataDataContext("Data Source=.\SQLEXPRESS;Integrated Security=True")
            'Checks if database exists and creates if not.
            If LibDataContext.DatabaseExists Then
                'MsgBox("tables exsist")
            Else
                LibDataContext.CreateDatabase()

            End If

        End If
    End Sub

    Private Sub MenuItem6_Click()
        Throw New NotImplementedException
    End Sub

    Private Sub MenuItem7_Click(sender As System.Object, e As System.EventArgs) Handles MenuItem7.Click
        If InputBox("Enter password", "End of day") = My.Resources.EODPassword Then
            Transactions.Show()
            ' Me.Close()
        End If

    End Sub
End Class
