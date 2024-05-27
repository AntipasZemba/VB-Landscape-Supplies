<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lstOrderDisplay = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radDelivery = New System.Windows.Forms.RadioButton()
        Me.radPickUp = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBags = New System.Windows.Forms.TextBox()
        Me.cboProduct = New System.Windows.Forms.ComboBox()
        Me.txtZipCode = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnAddProduct = New System.Windows.Forms.Button()
        Me.btnTotalOrder = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstOrderDisplay
        '
        Me.lstOrderDisplay.FormattingEnabled = True
        Me.lstOrderDisplay.Location = New System.Drawing.Point(348, 28)
        Me.lstOrderDisplay.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.lstOrderDisplay.Name = "lstOrderDisplay"
        Me.lstOrderDisplay.Size = New System.Drawing.Size(313, 303)
        Me.lstOrderDisplay.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radDelivery)
        Me.GroupBox1.Controls.Add(Me.radPickUp)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtBags)
        Me.GroupBox1.Controls.Add(Me.cboProduct)
        Me.GroupBox1.Controls.Add(Me.txtZipCode)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 19)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.GroupBox1.Size = New System.Drawing.Size(310, 303)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Info"
        '
        'radDelivery
        '
        Me.radDelivery.AutoSize = True
        Me.radDelivery.Checked = True
        Me.radDelivery.Location = New System.Drawing.Point(167, 196)
        Me.radDelivery.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.radDelivery.Name = "radDelivery"
        Me.radDelivery.Size = New System.Drawing.Size(70, 20)
        Me.radDelivery.TabIndex = 9
        Me.radDelivery.TabStop = True
        Me.radDelivery.Text = "Delivery"
        Me.radDelivery.UseVisualStyleBackColor = True
        '
        'radPickUp
        '
        Me.radPickUp.AutoSize = True
        Me.radPickUp.Location = New System.Drawing.Point(167, 170)
        Me.radPickUp.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.radPickUp.Name = "radPickUp"
        Me.radPickUp.Size = New System.Drawing.Size(70, 20)
        Me.radPickUp.TabIndex = 8
        Me.radPickUp.TabStop = True
        Me.radPickUp.Text = "Pick Up"
        Me.radPickUp.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 131)
        Me.Label4.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Number of Bags:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 97)
        Me.Label3.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Mulch Type:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 61)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Zip Code:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Name:"
        '
        'txtBags
        '
        Me.txtBags.Location = New System.Drawing.Point(167, 129)
        Me.txtBags.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtBags.Name = "txtBags"
        Me.txtBags.Size = New System.Drawing.Size(34, 20)
        Me.txtBags.TabIndex = 3
        '
        'cboProduct
        '
        Me.cboProduct.FormattingEnabled = True
        Me.cboProduct.Items.AddRange(New Object() {"Black Shredded - $7.90", "Black Chips - $7.00", "Brown Shredded - $7.90", "Brown Chips - $7.00", "Red Shredded - $7.90", "Red Chips - $7.00"})
        Me.cboProduct.Location = New System.Drawing.Point(167, 95)
        Me.cboProduct.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.cboProduct.Name = "cboProduct"
        Me.cboProduct.Size = New System.Drawing.Size(138, 21)
        Me.cboProduct.TabIndex = 2
        '
        'txtZipCode
        '
        Me.txtZipCode.Location = New System.Drawing.Point(167, 59)
        Me.txtZipCode.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.Size = New System.Drawing.Size(67, 20)
        Me.txtZipCode.TabIndex = 1
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(167, 25)
        Me.txtName.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(83, 20)
        Me.txtName.TabIndex = 0
        '
        'btnAddProduct
        '
        Me.btnAddProduct.Location = New System.Drawing.Point(87, 351)
        Me.btnAddProduct.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New System.Drawing.Size(104, 29)
        Me.btnAddProduct.TabIndex = 2
        Me.btnAddProduct.Text = "Add Product"
        Me.btnAddProduct.UseVisualStyleBackColor = True
        '
        'btnTotalOrder
        '
        Me.btnTotalOrder.Location = New System.Drawing.Point(223, 351)
        Me.btnTotalOrder.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnTotalOrder.Name = "btnTotalOrder"
        Me.btnTotalOrder.Size = New System.Drawing.Size(102, 31)
        Me.btnTotalOrder.TabIndex = 3
        Me.btnTotalOrder.Text = "Total Order"
        Me.btnTotalOrder.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(356, 353)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(102, 28)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(489, 353)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(102, 28)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 410)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnTotalOrder)
        Me.Controls.Add(Me.btnAddProduct)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lstOrderDisplay)
        Me.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Name = "Form1"
        Me.Text = "VB Landscape Supplies"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstOrderDisplay As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radDelivery As RadioButton
    Friend WithEvents radPickUp As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBags As TextBox
    Friend WithEvents cboProduct As ComboBox
    Friend WithEvents txtZipCode As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnAddProduct As Button
    Friend WithEvents btnTotalOrder As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
