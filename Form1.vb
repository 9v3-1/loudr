Public Class Form1
    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        pnlGuitar.Visible = False
        pnlHome.Visible = False
        pnlKeyboard.Visible = False
        pnlCart.Visible = False

        pnlAbout.Visible = True ' Shows the About panel when the About button is clicked 
        pnlAbout.BringToFront()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        ' Hides other panels when the Home button is clicked
        pnlAbout.Visible = False
        pnlGuitar.Visible = False
        pnlKeyboard.Visible = False
        pnlCart.Visible = False

        ' Shows the Home panel when the Home button is clicked
        pnlHome.Visible = True
        pnlHome.BringToFront()
    End Sub

    Private Sub btnGuitar_Click(sender As Object, e As EventArgs) Handles btnGuitar.Click
        pnlAbout.Visible = False
        pnlHome.Visible = False
        pnlKeyboard.Visible = False
        pnlCart.Visible = False

        pnlGuitar.Visible = True ' Shows the Guitar panel when the Guitar button is clicked
        pnlGuitar.BringToFront()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ensure panels are hidden initially
        pnlAbout.Visible = False
        pnlHome.Visible = True
        pnlGuitar.Visible = False
        pnlKeyboard.Visible = False
        pnlCart.Visible = False
    End Sub

    Private Sub btnKeyboards_Click(sender As Object, e As EventArgs) Handles btnKeyboards.Click
        pnlAbout.Visible = False
        pnlHome.Visible = False
        pnlGuitar.Visible = False
        pnlCart.Visible = False

        pnlKeyboard.Visible = True ' Shows the Keyboard panel when the Keyboard button is clicked
        pnlKeyboard.BringToFront()
    End Sub

    Private Sub btnCart_Click(sender As Object, e As EventArgs) Handles btnCart.Click
        pnlAbout.Visible = False
        pnlHome.Visible = False
        pnlGuitar.Visible = False

        pnlCart.Visible = True ' Shows the Cart panel when the Cart button is clicked
        pnlCart.BringToFront()
    End Sub
End Class

' ON BRO IM GONNA KMS
