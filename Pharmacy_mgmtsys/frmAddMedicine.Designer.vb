<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddMedicine
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
        Me.btnexporttoexcelmed = New System.Windows.Forms.Button()
        Me.btnclearmed = New System.Windows.Forms.Button()
        Me.btndeletemed = New System.Windows.Forms.Button()
        Me.btneditmed = New System.Windows.Forms.Button()
        Me.btnaddnewmed = New System.Windows.Forms.Button()
        Me.DataGridViewMedicinedata = New System.Windows.Forms.DataGridView()
        Me.GroupBoxMedicine = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePickerexpimed = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickermanufmed = New System.Windows.Forms.DateTimePicker()
        Me.txtboxremarkmed = New System.Windows.Forms.TextBox()
        Me.txtboxpricemed = New System.Windows.Forms.TextBox()
        Me.txtboxbatchmed = New System.Windows.Forms.TextBox()
        Me.txtboxquanmed = New System.Windows.Forms.TextBox()
        Me.txtboximportedidmed = New System.Windows.Forms.TextBox()
        Me.txtboxbnamemed = New System.Windows.Forms.TextBox()
        Me.txtboxgnamemed = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtboxsernomed = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorProviderregmed = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnmedsearch = New System.Windows.Forms.Button()
        Me.txtboxsearchmed = New System.Windows.Forms.TextBox()
        Me.ToolTipvalida = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnrefreshmed = New System.Windows.Forms.Button()
        Me.SaveFileDialogmed = New System.Windows.Forms.SaveFileDialog()
        CType(Me.DataGridViewMedicinedata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxMedicine.SuspendLayout()
        CType(Me.ErrorProviderregmed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnexporttoexcelmed
        '
        Me.btnexporttoexcelmed.Location = New System.Drawing.Point(776, 235)
        Me.btnexporttoexcelmed.Name = "btnexporttoexcelmed"
        Me.btnexporttoexcelmed.Size = New System.Drawing.Size(96, 32)
        Me.btnexporttoexcelmed.TabIndex = 13
        Me.btnexporttoexcelmed.Text = "Export to Excel"
        Me.btnexporttoexcelmed.UseVisualStyleBackColor = True
        '
        'btnclearmed
        '
        Me.btnclearmed.Location = New System.Drawing.Point(652, 235)
        Me.btnclearmed.Name = "btnclearmed"
        Me.btnclearmed.Size = New System.Drawing.Size(54, 32)
        Me.btnclearmed.TabIndex = 12
        Me.btnclearmed.Text = "Clear"
        Me.btnclearmed.UseVisualStyleBackColor = True
        '
        'btndeletemed
        '
        Me.btndeletemed.Location = New System.Drawing.Point(561, 235)
        Me.btndeletemed.Name = "btndeletemed"
        Me.btndeletemed.Size = New System.Drawing.Size(85, 32)
        Me.btndeletemed.TabIndex = 11
        Me.btndeletemed.Text = "Delete Stock"
        Me.btndeletemed.UseVisualStyleBackColor = True
        '
        'btneditmed
        '
        Me.btneditmed.Location = New System.Drawing.Point(480, 235)
        Me.btneditmed.Name = "btneditmed"
        Me.btneditmed.Size = New System.Drawing.Size(75, 32)
        Me.btneditmed.TabIndex = 10
        Me.btneditmed.Text = "Edit Stock"
        Me.btneditmed.UseVisualStyleBackColor = True
        '
        'btnaddnewmed
        '
        Me.btnaddnewmed.Location = New System.Drawing.Point(399, 235)
        Me.btnaddnewmed.Name = "btnaddnewmed"
        Me.btnaddnewmed.Size = New System.Drawing.Size(75, 32)
        Me.btnaddnewmed.TabIndex = 9
        Me.btnaddnewmed.Text = "Add New"
        Me.btnaddnewmed.UseVisualStyleBackColor = True
        '
        'DataGridViewMedicinedata
        '
        Me.DataGridViewMedicinedata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewMedicinedata.Location = New System.Drawing.Point(12, 273)
        Me.DataGridViewMedicinedata.Name = "DataGridViewMedicinedata"
        Me.DataGridViewMedicinedata.Size = New System.Drawing.Size(875, 214)
        Me.DataGridViewMedicinedata.TabIndex = 8
        '
        'GroupBoxMedicine
        '
        Me.GroupBoxMedicine.Controls.Add(Me.GroupBox1)
        Me.GroupBoxMedicine.Controls.Add(Me.DateTimePickerexpimed)
        Me.GroupBoxMedicine.Controls.Add(Me.DateTimePickermanufmed)
        Me.GroupBoxMedicine.Controls.Add(Me.txtboxremarkmed)
        Me.GroupBoxMedicine.Controls.Add(Me.txtboxpricemed)
        Me.GroupBoxMedicine.Controls.Add(Me.txtboxbatchmed)
        Me.GroupBoxMedicine.Controls.Add(Me.txtboxquanmed)
        Me.GroupBoxMedicine.Controls.Add(Me.txtboximportedidmed)
        Me.GroupBoxMedicine.Controls.Add(Me.txtboxbnamemed)
        Me.GroupBoxMedicine.Controls.Add(Me.txtboxgnamemed)
        Me.GroupBoxMedicine.Controls.Add(Me.Label10)
        Me.GroupBoxMedicine.Controls.Add(Me.Label9)
        Me.GroupBoxMedicine.Controls.Add(Me.Label8)
        Me.GroupBoxMedicine.Controls.Add(Me.Label7)
        Me.GroupBoxMedicine.Controls.Add(Me.Label6)
        Me.GroupBoxMedicine.Controls.Add(Me.Label5)
        Me.GroupBoxMedicine.Controls.Add(Me.Label4)
        Me.GroupBoxMedicine.Controls.Add(Me.Label3)
        Me.GroupBoxMedicine.Controls.Add(Me.Label2)
        Me.GroupBoxMedicine.Controls.Add(Me.txtboxsernomed)
        Me.GroupBoxMedicine.Controls.Add(Me.Label1)
        Me.GroupBoxMedicine.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxMedicine.ForeColor = System.Drawing.Color.Blue
        Me.GroupBoxMedicine.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxMedicine.Name = "GroupBoxMedicine"
        Me.GroupBoxMedicine.Size = New System.Drawing.Size(875, 217)
        Me.GroupBoxMedicine.TabIndex = 7
        Me.GroupBoxMedicine.TabStop = False
        Me.GroupBoxMedicine.Text = "Medicine Details"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(6, 223)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(404, 32)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'DateTimePickerexpimed
        '
        Me.DateTimePickerexpimed.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerexpimed.Location = New System.Drawing.Point(584, 53)
        Me.DateTimePickerexpimed.Name = "DateTimePickerexpimed"
        Me.DateTimePickerexpimed.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePickerexpimed.TabIndex = 39
        '
        'DateTimePickermanufmed
        '
        Me.DateTimePickermanufmed.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickermanufmed.Location = New System.Drawing.Point(584, 25)
        Me.DateTimePickermanufmed.Name = "DateTimePickermanufmed"
        Me.DateTimePickermanufmed.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePickermanufmed.TabIndex = 38
        '
        'txtboxremarkmed
        '
        Me.txtboxremarkmed.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxremarkmed.Location = New System.Drawing.Point(584, 81)
        Me.txtboxremarkmed.Multiline = True
        Me.txtboxremarkmed.Name = "txtboxremarkmed"
        Me.txtboxremarkmed.Size = New System.Drawing.Size(200, 115)
        Me.txtboxremarkmed.TabIndex = 37
        '
        'txtboxpricemed
        '
        Me.txtboxpricemed.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxpricemed.Location = New System.Drawing.Point(146, 171)
        Me.txtboxpricemed.Name = "txtboxpricemed"
        Me.txtboxpricemed.Size = New System.Drawing.Size(259, 22)
        Me.txtboxpricemed.TabIndex = 36
        '
        'txtboxbatchmed
        '
        Me.txtboxbatchmed.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxbatchmed.Location = New System.Drawing.Point(146, 147)
        Me.txtboxbatchmed.Name = "txtboxbatchmed"
        Me.txtboxbatchmed.Size = New System.Drawing.Size(259, 22)
        Me.txtboxbatchmed.TabIndex = 35
        '
        'txtboxquanmed
        '
        Me.txtboxquanmed.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxquanmed.Location = New System.Drawing.Point(146, 122)
        Me.txtboxquanmed.Name = "txtboxquanmed"
        Me.txtboxquanmed.Size = New System.Drawing.Size(259, 22)
        Me.txtboxquanmed.TabIndex = 34
        '
        'txtboximportedidmed
        '
        Me.txtboximportedidmed.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboximportedidmed.Location = New System.Drawing.Point(146, 98)
        Me.txtboximportedidmed.Name = "txtboximportedidmed"
        Me.txtboximportedidmed.Size = New System.Drawing.Size(259, 22)
        Me.txtboximportedidmed.TabIndex = 33
        '
        'txtboxbnamemed
        '
        Me.txtboxbnamemed.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxbnamemed.Location = New System.Drawing.Point(146, 74)
        Me.txtboxbnamemed.Name = "txtboxbnamemed"
        Me.txtboxbnamemed.Size = New System.Drawing.Size(259, 22)
        Me.txtboxbnamemed.TabIndex = 32
        '
        'txtboxgnamemed
        '
        Me.txtboxgnamemed.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxgnamemed.Location = New System.Drawing.Point(146, 49)
        Me.txtboxgnamemed.Name = "txtboxgnamemed"
        Me.txtboxgnamemed.Size = New System.Drawing.Size(259, 22)
        Me.txtboxgnamemed.TabIndex = 31
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(438, 81)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 15)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Remark"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(35, 178)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 15)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Price"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(438, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 15)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Expired Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(438, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 15)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Manufactured Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(35, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 15)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Batch No"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(35, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 15)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Quantity"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(35, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 15)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Imported Id"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(35, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 15)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Brand Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(35, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 15)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Generic Name"
        '
        'txtboxsernomed
        '
        Me.txtboxsernomed.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxsernomed.Location = New System.Drawing.Point(146, 24)
        Me.txtboxsernomed.Name = "txtboxsernomed"
        Me.txtboxsernomed.Size = New System.Drawing.Size(259, 22)
        Me.txtboxsernomed.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(35, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 15)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Serial No"
        '
        'ErrorProviderregmed
        '
        Me.ErrorProviderregmed.ContainerControl = Me
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnmedsearch)
        Me.GroupBox2.Controls.Add(Me.txtboxsearchmed)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(12, 235)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(381, 32)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search medicine"
        '
        'btnmedsearch
        '
        Me.btnmedsearch.Location = New System.Drawing.Point(312, 6)
        Me.btnmedsearch.Name = "btnmedsearch"
        Me.btnmedsearch.Size = New System.Drawing.Size(57, 21)
        Me.btnmedsearch.TabIndex = 15
        Me.btnmedsearch.Text = "Search"
        Me.btnmedsearch.UseVisualStyleBackColor = True
        '
        'txtboxsearchmed
        '
        Me.txtboxsearchmed.Location = New System.Drawing.Point(110, 5)
        Me.txtboxsearchmed.Name = "txtboxsearchmed"
        Me.txtboxsearchmed.Size = New System.Drawing.Size(196, 22)
        Me.txtboxsearchmed.TabIndex = 0
        '
        'btnrefreshmed
        '
        Me.btnrefreshmed.Location = New System.Drawing.Point(712, 235)
        Me.btnrefreshmed.Name = "btnrefreshmed"
        Me.btnrefreshmed.Size = New System.Drawing.Size(58, 32)
        Me.btnrefreshmed.TabIndex = 15
        Me.btnrefreshmed.Text = "Refresh"
        Me.btnrefreshmed.UseVisualStyleBackColor = True
        '
        'frmAddMedicine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(899, 499)
        Me.Controls.Add(Me.btnrefreshmed)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnexporttoexcelmed)
        Me.Controls.Add(Me.btnclearmed)
        Me.Controls.Add(Me.btndeletemed)
        Me.Controls.Add(Me.btneditmed)
        Me.Controls.Add(Me.btnaddnewmed)
        Me.Controls.Add(Me.DataGridViewMedicinedata)
        Me.Controls.Add(Me.GroupBoxMedicine)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddMedicine"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Medicine - Pharmacy Management System"
        CType(Me.DataGridViewMedicinedata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxMedicine.ResumeLayout(False)
        Me.GroupBoxMedicine.PerformLayout()
        CType(Me.ErrorProviderregmed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnexporttoexcelmed As Button
    Friend WithEvents btnclearmed As Button
    Friend WithEvents btndeletemed As Button
    Friend WithEvents btneditmed As Button
    Friend WithEvents btnaddnewmed As Button
    Friend WithEvents DataGridViewMedicinedata As DataGridView
    Friend WithEvents GroupBoxMedicine As GroupBox
    Friend WithEvents DateTimePickerexpimed As DateTimePicker
    Friend WithEvents DateTimePickermanufmed As DateTimePicker
    Friend WithEvents txtboxremarkmed As TextBox
    Friend WithEvents txtboxpricemed As TextBox
    Friend WithEvents txtboxbatchmed As TextBox
    Friend WithEvents txtboxquanmed As TextBox
    Friend WithEvents txtboximportedidmed As TextBox
    Friend WithEvents txtboxbnamemed As TextBox
    Friend WithEvents txtboxgnamemed As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtboxsernomed As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ErrorProviderregmed As ErrorProvider
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnmedsearch As Button
    Friend WithEvents txtboxsearchmed As TextBox
    Friend WithEvents ToolTipvalida As ToolTip
    Friend WithEvents btnrefreshmed As Button
    Friend WithEvents SaveFileDialogmed As SaveFileDialog
End Class
