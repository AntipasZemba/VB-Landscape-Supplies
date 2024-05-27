Public Class Form1
    Dim strZipCode As String
    Dim dblOrderSubTotal As Double
    Dim blnFirstProduct As Boolean = True

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        blnFirstProduct = True
        txtName.Enabled = True
        txtZipCode.Enabled = True
        radDelivery.Enabled = True
        radPickUp.Enabled = True
        cboProduct.Enabled = True
        txtBags.Enabled = True
        btnAddProduct.Enabled = True

        txtName.Clear()
        txtZipCode.Clear()
        radDelivery.Checked = True

        lstOrderDisplay.Items.Clear()

        dblOrderSubTotal = 0
        txtName.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub

    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click

        Dim intBags As Integer
        Dim strProduct As String
        Dim dblProductTotal As Double

        Dim blnValidated As Boolean = True

        GetandValidate_Input(intBags, strProduct, blnValidated)

        If blnValidated Then
            dblProductTotal = Calculate_Product_SubTotal(intBags, strProduct)
            Accumulate_Order_Total(dblProductTotal)
            Display_Product(strProduct, intBags, dblProductTotal)
        End If

    End Sub

    Private Sub GetandValidate_Input(ByRef intBags As Short, ByRef strProduct As String, ByRef blnValidated As Boolean)

        ValidateName(blnValidated)
        If blnValidated Then
            ValidateZipCode(blnValidated)
            If blnValidated Then
                ValidateProduct(strProduct, blnValidated)
                If blnValidated Then
                    ValidateBags(intBags, blnValidated)
                End If
            End If
        End If

    End Sub
    Private Sub ValidateName(ByRef blnValidated As Boolean)

        If txtName.Text = "" Then
            MessageBox.Show("Name is Required")
            txtName.Focus()
            blnValidated = False
        End If

    End Sub

    Private Sub ValidateZipCode(ByRef blnValidated As Boolean)
        If txtZipCode.Text = "" Then
            MessageBox.Show("Zip Code is Required")
            txtZipCode.Focus()
            blnValidated = False
        Else
            strZipCode = txtZipCode.Text
            If radDelivery.Checked Then
                If (strZipCode = "41042") Or (strZipCode = "41022") Or (strZipCode = "41091 ") Then
                Else
                    MessageBox.Show("VB Landscape only delivers to 41042, 41022, or 41091 Zip Codes")
                    txtZipCode.Focus()
                    blnValidated = False
                End If
            End If
        End If

    End Sub

    Private Sub ValidateBags(ByRef intBags As Short, ByRef blnValidated As Boolean)
        If Short.TryParse(txtBags.Text, intBags) Then
            If (intBags > 0) And (intBags < 51) Then
            Else
                MessageBox.Show("Number of Bags Must be between 1 and 50")
                txtZipCode.Focus()
                blnValidated = False
            End If
        Else
            MessageBox.Show("Number of Bags is Required and Must be Numeric")
            txtBags.Focus()
            blnValidated = False
        End If
    End Sub

    Private Sub ValidateProduct(ByRef strProduct As String, ByRef blnValidated As Boolean)
        If cboProduct.Text = "" Then
            MessageBox.Show("Product Must be Selected")
            cboProduct.Focus()
            blnValidated = False
        Else
            If cboProduct.Text = "Black Shredded - $7.90" Then
                strProduct = "Black Shredded"
            Else
                If cboProduct.Text = "Black Chips - $7.00" Then
                    strProduct = "Black Chips"
                Else
                    If cboProduct.Text = "Brown Shredded - $7.90" Then
                        strProduct = "Brown Shredded"
                    Else
                        If cboProduct.Text = "Brown Chips - $7.00" Then
                            strProduct = "Brown Chips"
                        Else
                            If cboProduct.Text = "Red Shredded - $7.90" Then
                                strProduct = "Red Shredded"
                            Else
                                If cboProduct.Text = "Red Chips - $7.00" Then
                                    strProduct = "Red Chips"
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Function Calculate_Product_SubTotal(ByVal intBags As Short, ByVal strProduct As String) As Double
        Dim dblProductCost As Double

        If (strProduct = "Black Chips") Or (strProduct = "Brown Chips") Or (strProduct = "Red Chips") Then
            dblProductCost = 7.0
        Else
            dblProductCost = 7.9
        End If

        Return dblProductCost * intBags

    End Function

    Private Sub Accumulate_Order_Total(ByVal dblProductTotal As Double)
        dblOrderSubTotal += dblProductTotal
    End Sub

    Private Sub Display_Product(ByVal strProduct As String, ByVal intBags As String, ByVal dblProductTotal As Double)
        If blnFirstProduct Then
            lstOrderDisplay.Items.Add("Mulch Type" & vbTab & "Bags" & vbTab & "Total")
            lstOrderDisplay.Items.Add(" ")

            blnFirstProduct = False
            txtName.Enabled = False
            txtZipCode.Enabled = False
            radDelivery.Enabled = False
            radPickUp.Enabled = False
        End If

        lstOrderDisplay.Items.Add(strProduct & vbTab & intBags & vbTab & dblProductTotal.ToString("c"))
        cboProduct.ResetText()


        txtBags.Clear()


    End Sub

    Private Sub btnTotalOrder_Click(sender As Object, e As EventArgs) Handles btnTotalOrder.Click
        Dim dblTax As Double
        Dim dblDeliveryCost As Double
        Dim dblTotalOrderCost As Double

        dblTax = Calculate_Tax()
        dblDeliveryCost = Calculate_Delivery()
        dblTotalOrderCost = Calculate_TotalOrderCost(dblTax, dblDeliveryCost)

        Display_OrderTotals(dblTax, dblDeliveryCost, dblTotalOrderCost)

    End Sub

    Private Function Calculate_Tax() As Double

        Return dblOrderSubTotal * 0.07

    End Function


    Private Function Calculate_Delivery() As Double
        Dim dblDeliveryCost As Double

        If strZipCode = "41042" Then
            dblDeliveryCost = 10
        Else
            If strZipCode = "41022" Then
                dblDeliveryCost = 12
            Else
                dblDeliveryCost = 15
            End If
        End If
        Return dblDeliveryCost

    End Function

    Private Function Calculate_TotalOrderCost(ByVal dblTax As Double, ByVal dblDeliveryCost As Double) As Double

        Return dblOrderSubTotal + dblTax + dblDeliveryCost

    End Function

    Private Sub Display_OrderTotals(ByVal dblTax As Double, ByVal dblDeliveryCost As Double, ByVal dblTotalOrderCost As Double)

        lstOrderDisplay.Items.Add("================================================")
        lstOrderDisplay.Items.Add("Total for all bags:" & vbTab & dblOrderSubTotal.ToString("c"))
        lstOrderDisplay.Items.Add("Tax:" & vbTab & vbTab & dblTax.ToString("c"))
        lstOrderDisplay.Items.Add("Delivery:" & vbTab & vbTab & dblDeliveryCost.ToString("c"))
        lstOrderDisplay.Items.Add(" ")
        lstOrderDisplay.Items.Add("Order Total:" & vbTab & dblTotalOrderCost.ToString("c"))

        cboProduct.Enabled = False
        txtBags.Enabled = False
        btnAddProduct.Enabled = False

    End Sub

End Class
