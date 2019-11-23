'Program Name: PT 's Grill Menu
'Author:       Geterry Sidbury-Crawford
'Date:         December 10th, 2017
'Purpose:      PTs Grille uses a simple form for customers to place their orders. While it easy for
'              customers to place their order, PT now wants a program to speed the process of
'              entering the orders into the computer system.


Public Class frmPTsGrille
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSubmitOrder_Click(sender As Object, e As EventArgs) Handles btnSubmitOrder.Click
        'This event handler calculates the cost of the order, dsiplays the name
        ', and submits the order to the resturant. 

        'Declar and Initialize Variables
        Dim decTotalCost As Decimal = 0D

        'These are the names of the values for each sandwich.
        Dim decOldeFashionedBurger As Decimal = 6.67D
        Dim decPtBurger As Decimal = 4.82D
        Dim decGrilledChicken As Decimal = 6.54D
        Dim decRoastBeef As Decimal = 5.84D
        Dim decGardenBurger As Decimal = 5.65D
        Dim decBlackBean As Decimal = 5.84D
        Dim decPtDog As Decimal = 4.67D
        Dim decTurkeySandwich As Decimal = 5.65D
        Dim decBltSandwich As Decimal = 4.67D
        Dim decGrilledCheese As Decimal = 3.97D

        'These are the names of the values for each topping option
        Dim decTopping As Decimal = 0.05D
        Dim decVeggie As Decimal = 0.1D
        Dim decCheese As Decimal = 0.25D
        Dim decMeatTopping As Decimal = 0.5D

        'These are the names of the values for each drink item
        Dim decFountainDrinks As Decimal = 1.63D
        Dim decLemonade As Decimal = 1.87D
        Dim decWater As Decimal = 0.0D
        Dim decOther As Decimal = 1.83D

        'This is the Process if a Sandwich is selected
        If radOldFashionedBurger.Checked Then
            decTotalCost = decTotalCost + decOldeFashionedBurger
        ElseIf radPtBurger.Checked Then
            decTotalCost = decTotalCost + decPtBurger
        ElseIf radGrilledChicken.Checked Then
            decTotalCost = decTotalCost + decGrilledChicken
        ElseIf radRoastBeef.Checked Then
            decTotalCost = decTotalCost + decRoastBeef
        ElseIf radGardenBurger.Checked Then
            decTotalCost = decTotalCost + decGardenBurger
        ElseIf radBlackBean.Checked Then
            decTotalCost = decTotalCost + decBlackBean
        ElseIf radPtDog.Checked Then
            decTotalCost = decTotalCost + decPtDog
        ElseIf radTurkeySandwich.Checked Then
            decTotalCost = decTotalCost + decTurkeySandwich
        ElseIf radBltSandwich.Checked Then
            decTotalCost = decTotalCost + decBltSandwich
        ElseIf radGrilledCheese.Checked Then
            decTotalCost = decTotalCost + decGrilledCheese
        End If


        'This is the Process if a Bottle topping is selected
        If chkKetchup.Checked Then
            decTotalCost = decTotalCost + decTopping
        End If

        If chkMayo.Checked Then
            decTotalCost = decTotalCost + decTopping
        End If

        If chkMustard.Checked Then
            decTotalCost = decTotalCost + decTopping
        End If

        'This is the process if a Veggie topping is selected
        If chkLettuce.Checked Then
            decTotalCost = decTotalCost + decVeggie
        End If
        If chkOnion.Checked Then
            decTotalCost = decTotalCost + decVeggie
        End If
        If chkPickels.Checked Then
            decTotalCost = decTotalCost + decVeggie
        End If
        If chkTomato.Checked Then
            decTotalCost = decTotalCost + decVeggie
        End If

        'This is the process if a Meat Topping is selected
        If chkChili.Checked Then
            decTotalCost += decMeatTopping
        End If
        If chkBacon.Checked Then
            decTotalCost += decMeatTopping
        End If

        'This is the process if a Cheese type is sleceted
        If radAmerican.Checked Then
            decTotalCost += decCheese
        ElseIf radJack.Checked Then
            decTotalCost += decCheese
        End If
        'This is the Process if a drink is selected
        Select Case cmbDrink.Text.ToUpper()
            Case "PEPSI"
                decTotalCost += decFountainDrinks
            Case "DIET PEPSI"
                decTotalCost += decFountainDrinks
            Case "MT. DEW"
                decTotalCost += decFountainDrinks
            Case "DR. PEPPER"
                decTotalCost += decFountainDrinks
            Case "SIERRA MIST"
                decTotalCost += decFountainDrinks
            Case "ROOTBEER"
                decTotalCost += decFountainDrinks
            Case "TEA (UNSWEET)"
                decTotalCost += decFountainDrinks
            Case "TEA (SWEET)"
                decTotalCost += decFountainDrinks
            Case "LEMONADE"
                decTotalCost += decLemonade
            Case "WATER"
                decTotalCost += decWater
            Case Else
                decTotalCost += decOther

        End Select
        ' This handles the destination of the orders, as well as the creation of the message boxes.
        If radInside.Checked Then
            MsgBox("The total of your order is " & decTotalCost.ToString("C"), , txtName.Text & "'s Inside order")
        ElseIf radTakeOut.Checked Then
            MsgBox("The total of your order is " & decTotalCost.ToString("C"), , txtName.Text & "'s Take-Out order")
        ElseIf radPickUp.Checked Then
            MsgBox("The total of your order is " & decTotalCost.ToString("C"), , txtName.Text & "'s Pick-Up order")
        ElseIf String.IsNullOrEmpty(txtName.Text) Then
            MsgBox("Enter a valid name for your order")
        ElseIf String.IsNullOrEmpty(cmbDrink.Text) Then
            MsgBox("Please select a drink")
        Else
            MsgBox("The total of your order is " & decTotalCost.ToString("C"), , txtName.Text & "'s Inside order")

        End If



        Exit Sub



    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Clear()
        cmbDrink.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
