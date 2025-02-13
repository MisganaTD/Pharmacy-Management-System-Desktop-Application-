Imports System.Data.SqlClient
Imports System.Linq
Imports System.Data.OleDb
Imports Microsoft.Office.Core
Imports Excel = Microsoft.Office.Interop.Excel
Imports ExcelautoFormat = Microsoft.Office.Interop.Excel.XlRangeAutoFormat
Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Xml.XPath
Imports System.Data
Imports System.Xml
Public Class frmAddMedicine
    Dim index As Integer
    Dim conn As New SqlConnection("Server = DESKTOP-QKNE475; Database = PharmacySys; Integrated Security = true")
    Private Function vld(ByVal ParamArray ctl() As Object) As Boolean
        'function for validation that check empty
        For i As Integer = 0 To UBound(ctl)
            If ctl(i).text = "" Then
                'ErrorProviderregmed.SetError(ctl(i), ctl(i).Tag)
                Return False
                Exit Function
            End If
        Next
        Return True
    End Function
#Region "FORM LOAD medicine detatil"
    Private Sub frmAddMedicine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FilterData("")
    End Sub
#End Region
#Region "VIEW AND EDIT MEDICINE DETAIL"
    Public Sub FilterData(valToSearch As String)
        Try
            Dim SearchQery As String = "select * from medicinestocktbl where CONCAT(medicineid,genericname,brandname) like '%" & valToSearch & "%' and status = 1"
            Dim coand As New SqlCommand(SearchQery, cn)
            Dim dat As New SqlDataAdapter(coand)
            Dim tble As New DataTable()
            dat.Fill(tble)
            DataGridViewMedicinedata.DataSource = tble
        Catch ex As Exception
            MsgBox("Please enter the keyword to search", MsgBoxStyle.Information)
        End Try
    End Sub
    Private Sub txtboxsearchmed_KeyDown(sender As Object, e As KeyEventArgs) Handles txtboxsearchmed.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnmedsearch_Click(sender, e)
        End If
    End Sub

    Private Sub btnmedsearch_Click(sender As Object, e As EventArgs) Handles btnmedsearch.Click
        FilterData(txtboxsearchmed.Text)
    End Sub
    Private Sub txtboxsearchmed_TextChanged(sender As Object, e As EventArgs) Handles txtboxsearchmed.TextChanged
        FilterData(txtboxsearchmed.Text)
    End Sub
#End Region
#Region "ADD medicine detatil"
    Private Sub btnaddnewmed_Click(sender As Object, e As EventArgs) Handles btnaddnewmed.Click
        If vld(txtboxsernomed, txtboxgnamemed, txtboxbnamemed, txtboximportedidmed, txtboxbatchmed, txtboxquanmed, txtboxpricemed, txtboxremarkmed) = False Then
            'Exit Sub
            'DateTimePickermanufmed
            'DateTimePickerexpimed
            MsgBox("Please complete the form first ", MsgBoxStyle.Critical)
        Else
            conn.Open()
            Dim cmdep As SqlCommand = New SqlCommand("select medicineid from medicinestocktbl where medicineid=@uid", conn)
            cmdep.Parameters.AddWithValue("@uid", txtboxsernomed.Text)
            Dim rdrp As SqlDataReader = cmdep.ExecuteReader()
            If rdrp.HasRows Then
                MsgBox("Medicine serial number already exist please try again!", MsgBoxStyle.Critical)
            Else
                Dim regby As String = Main_Form.lblusername.Text 'userName.ToString()
                Dim statmed As Integer = 1
                'medicineid used as serialno
                Dim insertQery As String = "insert into medicinestocktbl(medicineid, genericname,brandname,importedid,quantity, batchno, price ,manufactureddate,expireddate,remark,stockregisteredby,status) values('" & txtboxsernomed.Text & "','" & txtboxgnamemed.Text & "','" & txtboxbnamemed.Text & "', '" & txtboximportedidmed.Text & "','" & txtboxquanmed.Text & "','" & txtboxbatchmed.Text & "','" & txtboxpricemed.Text & "','" & DateTimePickermanufmed.Value.ToShortDateString() & "','" & DateTimePickerexpimed.Value.ToShortDateString() & "','" & txtboxremarkmed.Text & "','" & regby & "', '" & statmed & "')"
                InsertUpdateDelete(insertQery)
                MessageBox.Show("Data successfully added", "Data Added - Pharmacy Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtboxsernomed.Clear()
                txtboxgnamemed.Clear()
                txtboxbnamemed.Clear()
                txtboximportedidmed.Clear()
                txtboxbatchmed.Clear()
                txtboxquanmed.Clear()
                txtboxpricemed.Clear()
                'DateTimePickermanufmed
                'DateTimePickerexpimed
                txtboxremarkmed.Clear()
                txtboxsernomed.Focus()
            End If
        End If
        conn.Close()
    End Sub
#End Region
#Region "EDIT medicine detatil"
    Private Sub btneditmed_Click(sender As Object, e As EventArgs) Handles btneditmed.Click
        If vld(txtboxsernomed, txtboxgnamemed, txtboxbnamemed, txtboximportedidmed, txtboxbatchmed, txtboxquanmed, txtboxpricemed, txtboxremarkmed) = False Then
            'Exit Sub
            MsgBox("Please complete the form first ", MsgBoxStyle.Critical)
        Else
            conn.Open()
            Dim cmdep As SqlCommand = New SqlCommand("select medicineid from medicinestocktbl where medicineid=@mid", conn)
            cmdep.Parameters.AddWithValue("@mid", txtboxsernomed.Text)
            Dim rdrp As SqlDataReader = cmdep.ExecuteReader()
            If rdrp.HasRows Then
                Dim updtequery As String = "update medicinestocktbl set genericname='" & txtboxgnamemed.Text & "', brandname='" & txtboxbnamemed.Text & "',importedid='" & txtboximportedidmed.Text & "', quantity='" & txtboxquanmed.Text & "', batchno='" & txtboxbatchmed.Text & "', price='" & txtboxpricemed.Text & "', manufactureddate='" & DateTimePickermanufmed.Value.ToShortDateString() & "', expireddate='" & DateTimePickerexpimed.Value.ToShortDateString() & "', remark='" & txtboxremarkmed.Text & "' where medicineid='" & txtboxsernomed.Text & "'"
                InsertUpdateDelete(updtequery)
                MessageBox.Show("Successfully edited !", "Data updated - Pharmacy Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'MessageBox.Show("Successfully updated!")
                txtboxsernomed.Clear()
                txtboxgnamemed.Clear()
                txtboxbnamemed.Clear()
                txtboximportedidmed.Clear()
                txtboxbatchmed.Clear()
                txtboxquanmed.Clear()
                txtboxpricemed.Clear()
                'DateTimePickermanufmed
                'DateTimePickerexpimed
                txtboxremarkmed.Clear()
                txtboxsernomed.Focus()
            Else
                MsgBox("No such medicine serial number exist please try again!", MsgBoxStyle.Critical)
            End If
        End If
        conn.Close()
    End Sub
    Private Sub DataGridViewMedicinedata_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewMedicinedata.CellContentClick
        Try
            Index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridViewMedicinedata.Rows(index)
            txtboxsernomed.Text = selectedRow.Cells(0).Value.ToString
            txtboxgnamemed.Text = selectedRow.Cells(1).Value.ToString
            txtboxbnamemed.Text = selectedRow.Cells(2).Value.ToString
            txtboximportedidmed.Text = selectedRow.Cells(3).Value.ToString
            txtboxquanmed.Text = selectedRow.Cells(4).Value.ToString
            txtboxbatchmed.Text = selectedRow.Cells(5).Value.ToString
            txtboxpricemed.Text = selectedRow.Cells(6).Value.ToString
            DateTimePickermanufmed.Text = selectedRow.Cells(7).Value.ToString
            DateTimePickerexpimed.Text = selectedRow.Cells(8).Value.ToString
            txtboxremarkmed.Text = selectedRow.Cells(9).Value.ToString
        Catch ex As Exception
            MsgBox("Ctrl + C to copy medicine details from database", MsgBoxStyle.Information)
        End Try
    End Sub
#End Region
#Region "DELETE medicine detatil"
    Private Sub btndeletemed_Click(sender As Object, e As EventArgs) Handles btndeletemed.Click
        If vld(txtboxsernomed) = False Then
            'Exit Sub
            MsgBox("Please select medicine form the datagriview below to delete", MsgBoxStyle.Critical)
        ElseIf IsConfirm("Do you want to delete this medicine from database?") Then
            Dim dletequery As String = "delete from medicinestocktbl where medicineid='" & txtboxsernomed.Text & "'"
            If InsertUpdateDelete(dletequery) Then
                MessageBox.Show("Successfully deleted !", "Data deleted - Pharmacy Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'MessageBox.Show("Successfully updated!")
                txtboxsernomed.Clear()
                txtboxgnamemed.Clear()
                txtboxbnamemed.Clear()
                txtboximportedidmed.Clear()
                txtboxbatchmed.Clear()
                txtboxquanmed.Clear()
                txtboxpricemed.Clear()
                'DateTimePickermanufmed
                'DateTimePickerexpimed
                txtboxremarkmed.Clear()
                txtboxsernomed.Focus()
            End If
        End If
    End Sub
#End Region
#Region "Clear frm med"
    Private Sub btnclearmed_Click(sender As Object, e As EventArgs) Handles btnclearmed.Click
        txtboxsernomed.Clear()
        txtboxgnamemed.Clear()
        txtboxbnamemed.Clear()
        txtboximportedidmed.Clear()
        txtboxbatchmed.Clear()
        txtboxquanmed.Clear()
        txtboxpricemed.Clear()
        'DateTimePickermanufmed
        'DateTimePickerexpimed
        txtboxremarkmed.Clear()
        txtboxsernomed.Focus()
    End Sub
#End Region
#Region "Export medicine detatil to ms-excel"
    Private Sub btnexporttoexcelmed_Click(sender As Object, e As EventArgs) Handles btnexporttoexcelmed.Click
        Try
            btnexporttoexcelmed.Text = "Please wait..."
            btnexporttoexcelmed.Enabled = False
            SaveFileDialogmed.Filter = "Excel Docoment (*.xlsx)|*.xlsx"
            If SaveFileDialogmed.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Dim xlapp As Microsoft.Office.Interop.Excel.Application
                Dim xlworkbook As Microsoft.Office.Interop.Excel.Workbook
                Dim xlworksheet As Microsoft.Office.Interop.Excel.Worksheet
                Dim misval As Object = System.Reflection.Missing.Value
                Dim x As Integer
                Dim y As Integer
                xlapp = New Microsoft.Office.Interop.Excel.Application
                xlworkbook = xlapp.Workbooks.Add(misval)
                xlworksheet = xlworkbook.Sheets("Sheet1")

                For x = 0 To DataGridViewMedicinedata.RowCount - 2
                    For y = 0 To DataGridViewMedicinedata.ColumnCount - 1
                        For z As Integer = 1 To DataGridViewMedicinedata.Columns.Count
                            xlworksheet.Cells(1, z) = DataGridViewMedicinedata.Columns(z - 1).HeaderText
                            xlworksheet.Cells(x + 2, y + 1) = DataGridViewMedicinedata(y, x).Value.ToString()
                        Next
                    Next
                Next
                xlworksheet.SaveAs(SaveFileDialogmed.FileName)
                xlworkbook.Close()
                xlapp.Quit()
                releaseObjectmed(xlapp)
                releaseObjectmed(xlworkbook)
                releaseObjectmed(xlworksheet)
                MsgBox("Successfully saved" & vbCrLf & "File saved at:" & SaveFileDialogmed.FileName, MsgBoxStyle.Information, "Information")
                btnexporttoexcelmed.Text = "Export to Excel"
                btnexporttoexcelmed.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show("Failed to save", "Error Message - Pharmacy Management System", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
    End Sub
    Private Sub releaseObjectmed(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
        Finally
            GC.Collect()
        End Try
    End Sub
    Private Sub txtboxquanmed_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtboxquanmed.KeyPress
        'If Not IsNumeric(e.KeyChar) Then
        'ToolTipvalida.Show("Only numeric input required", sender, 5000)
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9")) Then ' Or e.KeyChar = vbBack Or e.KeyChar = "+") Then
            MessageBox.Show("Invalid input numbers only allowed", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'e.KeyChar = Nothing
            e.Handled = True
        End If
    End Sub

    Private Sub btnrefreshmed_Click(sender As Object, e As EventArgs) Handles btnrefreshmed.Click
        Me.Controls.Clear()
        InitializeComponent()
        frmAddMedicine_Load(e, e)
        Refresh()
    End Sub
#End Region
End Class