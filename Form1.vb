Imports WinFormsApp1.Form1

Public Class Form1
    Private cartItems As New List(Of CartItem)

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        pnlGuitar.Visible = False
        pnlHome.Visible = False
        pnlKeyboard.Visible = False
        pnlCart.Visible = False
        pnlDrums.Visible = False

        pnlAbout.Visible = True ' Shows the About panel when the About button is clicked 
        pnlAbout.BringToFront()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        ' Hides other panels when the Home button is clicked
        pnlAbout.Visible = False
        pnlGuitar.Visible = False
        pnlKeyboard.Visible = False
        pnlCart.Visible = False
        pnlDrums.Visible = False

        ' Shows the Home panel when the Home button is clicked
        pnlHome.Visible = True
        pnlHome.BringToFront()
    End Sub

    Private Sub btnGuitar_Click(sender As Object, e As EventArgs) Handles btnGuitar.Click
        pnlAbout.Visible = False
        pnlHome.Visible = False
        pnlKeyboard.Visible = False
        pnlCart.Visible = False
        pnlDrums.Visible = False

        pnlGuitar.Visible = True ' Shows the Guitar panel when the Guitar button is clicked
        pnlGuitar.BringToFront()
    End Sub

    Private Sub btnKeyboards_Click(sender As Object, e As EventArgs) Handles btnKeyboards.Click
        pnlAbout.Visible = False
        pnlHome.Visible = False
        pnlGuitar.Visible = False
        pnlCart.Visible = False
        pnlDrums.Visible = False

        pnlKeyboard.Visible = True ' Shows the Keyboard panel when the Keyboard button is clicked
        pnlKeyboard.BringToFront()
    End Sub

    Private Sub btnCart_Click(sender As Object, e As EventArgs) Handles btnCart.Click
        pnlAbout.Visible = False
        pnlHome.Visible = False
        pnlGuitar.Visible = False
        pnlDrums.Visible = False

        pnlCart.Visible = True ' Shows the Cart panel when the Cart button is clicked
        pnlCart.BringToFront()
    End Sub

    Private Sub btnDrums_Click(sender As Object, e As EventArgs) Handles btnDrums.Click
        pnlAbout.Visible = False
        pnlHome.Visible = False
        pnlGuitar.Visible = False
        pnlCart.Visible = False

        pnlDrums.Visible = True ' Shows the Drums panel when the Drums button is clicked
        pnlDrums.BringToFront()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ensure panels are hidden initially
        pnlAbout.Visible = False
        pnlHome.Visible = True
        pnlGuitar.Visible = False
        pnlKeyboard.Visible = False
        pnlCart.Visible = False
        pnlDrums.Visible = False
    End Sub

    Public Class CartItem
        Public Property ItemName As String
        Public Property Price As Decimal

        Public Sub New(itemName As String, price As Decimal)
            Me.ItemName = itemName
            Me.Price = price
        End Sub
    End Class

    Private Sub AddToCart(itemName As String, price As Decimal)
        cartItems.Add(New CartItem(itemName, price))
        UpdateCart()
    End Sub

    Private Sub UpdateCart()
        Dim totalPrice As Decimal = cartItems.Sum(Function(item) item.Price)
        ' Update the cart UI with the items and total price
        ' For example, you can update a ListBox and a Label
        lstCart.Items.Clear()
        For Each item In cartItems
            lstCart.Items.Add($"{item.ItemName} - ${item.Price}")
        Next

        lblTotalPrice.Text = $"Total: ${totalPrice}"
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddToCart("Fender Standard Stratocaster", 1200)
    End Sub

    ' Add similar event handlers for other items... YES DO IT LATER NASIR

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        If cartItems.Count = 0 Then
            MessageBox.Show("Your cart is empty.", "Checkout", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Do you want to finalize the purchase?", "Checkout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            ' Finalize the purchase
            MessageBox.Show("Purchase completed successfully!", "Checkout", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cartItems.Clear()
            UpdateCart()
        End If
    End Sub
End Class
