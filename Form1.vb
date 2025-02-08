Imports WinFormsApp1.Form1

Public Class Form1
    Private cartItems As New List(Of CartItem)
    Private WithEvents pnlAddedCartTimer As New Timer() ' Timer to hide the added to cart panel after a second
    Public Sub New()
        InitializeComponent()
        pnlAddedCartTimer.Interval = 1000 ' Set the timer to 1 second
    End Sub

    ' Event handler for the Timerevent
    Private Sub pnlAddedCartTimer_Tick(sender As Object, e As EventArgs) Handles pnlAddedCartTimer.Tick
        pnlAddedCart.Visible = False
        pnlAddedCartTimer.Stop()
    End Sub

    ' AddToCart method is defined only once and is used consitently on all event handlers 
    Private Sub AddToCart(itemName As String, price As Decimal)
        cartItems.Add(New CartItem(itemName, price)) ' Add the item to the cart
        UpdateCart() ' Method yo refresh cart UI
        pnlAddedCart.Visible = True
        pnlAddedCart.BringToFront()
        pnlAddedCartTimer.Start() ' Start the timer
    End Sub

    ' method updates the cart UI with the current items and total price
    Private Sub UpdateCart()
        Dim totalPrice As Decimal = cartItems.Sum(Function(item) item.Price) ' Calculate total price
        ' Update the cart UI with the items and total price
        lstCart.Items.Clear() ' Clear the current items in the list
        For Each item In cartItems
            lstCart.Items.Add($"{item.ItemName} - ${item.Price}") ' Add each item to the list
        Next

        lblTotalPrice.Text = $"Total: ${totalPrice}" ' Update the total price label
    End Sub

    ' ------------------------Event handlers for navigation buttons-----------------------
    Private Sub btnHomeAbout_Click(sender As Object, e As EventArgs) Handles btnHomeAbout.Click
        pnlGuitar.Visible = False
        pnlHome.Visible = False
        pnlKeyboard.Visible = False
        pnlCart.Visible = False
        pnlDrums.Visible = False

        pnlAbout.Visible = True ' Shows the About panel when the About button is clicked 
        pnlAbout.BringToFront()
    End Sub

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
        pnlAddedCart.Visible = False
    End Sub

    Public Class CartItem ' Declares a class to represent an item in the cart with name and price variables
        Public Property ItemName As String
        Public Property Price As Decimal

        Public Sub New(itemName As String, price As Decimal)
            Me.ItemName = itemName
            Me.Price = price
        End Sub
    End Class

    ' -----------------Event handlers for adding GUITAR items to the cart-----------------------
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddToCart("Fender Standard Stratocaster", 1200) ' Add Fender Standard Stratocaster to the cart
    End Sub

    Private Sub btnBass_Click(sender As Object, e As EventArgs) Handles btnBass.Click
        AddToCart("Fender Player II Bass", 1400) ' Add Fender Player II Bass to the cart
    End Sub

    Private Sub btnGibson_Click(sender As Object, e As EventArgs) Handles btnGibson.Click
        AddToCart("Gibson Les Paul", 2799) ' Add Gibson Les Paul to the cart
    End Sub

    Private Sub btnMartin_Click(sender As Object, e As EventArgs) Handles btnMartin.Click
        AddToCart("Martin D-28", 3199) ' Add Martin D-28 to the cart
    End Sub

    Private Sub btnPRS_Click(sender As Object, e As EventArgs) Handles btnPRS.Click
        AddToCart("PRS Custom 24", 849) ' Add PRS Custom 24 to the cart
    End Sub

    Private Sub btnTaylor_Click(sender As Object, e As EventArgs) Handles btnTaylor.Click
        AddToCart("Taylor GS Mini", 599) ' Add Taylor GS Mini to the cart
    End Sub

    '-------------------Event handlers for adding KEYBOARD items to the cart-----------------------
    Private Sub btnElektron_Click(sender As Object, e As EventArgs) Handles btnElektron.Click
        AddToCart("Elektron Digitone II", 999) ' Add Elektron Digitone II to the cart
    End Sub

    Private Sub btnArturia_Click(sender As Object, e As EventArgs) Handles btnArturia.Click
        AddToCart("Arturia KeyLab 61 mk3", 599) ' Add Arturia KeyLab 61 mk3 to the cart
    End Sub

    Private Sub btnKorg_Click(sender As Object, e As EventArgs) Handles btnKorg.Click
        AddToCart("btnKorg Grandstage X", 2999.99) ' Add Korg Grandstage X to the cart
    End Sub

    Private Sub btnWave_Click(sender As Object, e As EventArgs) Handles btnWave.Click
        AddToCart("Wavetable Synthesizer", 599) ' Add Wavetable Synthesizer to the cart
    End Sub

    Private Sub btnProph_Click(sender As Object, e As EventArgs) Handles btnProph.Click
        AddToCart("Sequential Prophet-10SE", 4999.99) ' Add Sequential Prophet-10SE to the cart
    End Sub

    Private Sub btnASM_Click(sender As Object, e As EventArgs) Handles btnASM.Click
        AddToCart("ASM Hydrasynth", 649) ' Add ASM Hydrasynth to the cart
    End Sub

    '-------------------Event handlers for adding DRUM items to the cart-----------------------
    Private Sub btnAlesis_Click(sender As Object, e As EventArgs) Handles btnAlesis.Click
        AddToCart("Alesis SR16", 159) ' Add Alesis SR16 to the cart
    End Sub

    Private Sub btnRoland_Click(sender As Object, e As EventArgs) Handles btnRoland.Click
        AddToCart("Roland TD-27KV", 3499.99) ' Add Roland TD-27KV to the cart
    End Sub

    Private Sub btnStage_Click(sender As Object, e As EventArgs) Handles btnStage.Click
        AddToCart("Yamaha Stage Custom Birch", 1099.99) ' Add Yamaha Stage Custom Birch to the cart
    End Sub

    Private Sub btnPearl_Click(sender As Object, e As EventArgs) Handles btnPearl.Click
        AddToCart("Pearl Export EXX", 799.99) ' Add Pearl Export EXX to the cart
    End Sub

    Private Sub btnPerc_Click(sender As Object, e As EventArgs) Handles btnPerc.Click
        AddToCart("Meinl Percussion Set", 299.99) ' Add Meinl Percussion Set to the cart
    End Sub

    Private Sub btnAspire_Click(sender As Object, e As EventArgs) Handles btnAspire.Click
        AddToCart("LP Aspire Conga Set", 399.99) ' Add LP Aspire Conga Set to the cart
    End Sub

    ' Handles the checkout process
    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        If cartItems.Count = 0 Then
            MessageBox.Show("Your cart is empty.", "Checkout", MessageBoxButtons.OK, MessageBoxIcon.Information) ' Show message if cart is empty
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Do you want to finalize the purchase?", "Checkout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            ' Finalize the purchase
            MessageBox.Show("Purchase completed successfully!", "Checkout", MessageBoxButtons.OK, MessageBoxIcon.Information) ' Show success message
            cartItems.Clear() ' Clear the cart
            UpdateCart() ' Refresh the cart UI
        End If
    End Sub

    Private Sub btnClearCart_Click(sender As Object, e As EventArgs) Handles btnClearCart.Click
        Dim clicked As DialogResult = MessageBox.Show("Do you want to clear your cart?", "Clear Cart", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If clicked = DialogResult.Yes Then
            cartItems.Clear()
            UpdateCart()
        End If
    End Sub
End Class
