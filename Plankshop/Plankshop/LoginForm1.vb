Public Class LoginForm1


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        txtPW.MaxLength = 4
        txtCVC.MaxLength = 3
        txtCardNumb1.MaxLength = 4
        txtCardNumb2.MaxLength = 4
        txtCardNumb3.MaxLength = 4
        txtCardNumb4.MaxLength = 4
        ' Add any initialization after the InitializeComponent() call.
        main()


    End Sub

    Sub main()
        PwVal()


    End Sub

    Private Function PwVal() As Boolean
        If IsNothing(txtPW) Then
            Return True
        End If

    End Function

    Public Sub setMoney(ByVal moneyIn As Double)
        lblTotalPrice.Text = moneyIn.ToString

    End Sub

#Region "txtBoxes"
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub txtCardNumb1_TextChanged(sender As Object, e As EventArgs) Handles txtCardNumb1.TextChanged
        If Not IsNumeric(txtCardNumb1.Text) Then
            txtCardNumb1.Text = ""
        End If
    End Sub


    Private Sub txtPW_TextChanged_1(sender As Object, e As EventArgs) Handles txtPW.TextChanged
        If Not IsNumeric(txtPW.Text) Then
            txtPW.Text = ""
        End If
    End Sub

    Private Sub txtCVC_TextChanged(sender As Object, e As EventArgs) Handles txtCVC.TextChanged
        If Not IsNumeric(txtCVC.Text) Then
            txtCVC.Text = ""
        End If
    End Sub

    Private Sub txtFullName_TextChanged(sender As Object, e As EventArgs) Handles txtFullName.TextChanged
        If IsNumeric(txtFullName.Text) Then
            txtFullName.Text = ""
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtCardNumb2.TextChanged
        If Not IsNumeric(txtCardNumb2.Text) Then
            txtCardNumb2.Text = ""
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtCardNumb4.TextChanged
        If Not IsNumeric(txtCardNumb4.Text) Then
            txtCardNumb4.Text = ""
        End If
    End Sub

    Private Sub txtCardNumb3_TextChanged(sender As Object, e As EventArgs) Handles txtCardNumb3.TextChanged
        If Not IsNumeric(txtCardNumb3.Text) Then
            txtCardNumb3.Text = ""
        End If
    End Sub

#End Region

End Class