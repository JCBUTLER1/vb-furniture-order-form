Public Class Furniture_Order_Form
    'Declare Constants
    Const dblCHAIR_PRICE As Double = 350
    Const dblSOFA_PRICE As Double = 925
    Const dblSALE_TAX As Double = 0.05

    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        'Declare variables that will hold the values that are put in the textboxes by the user.
        Dim strCustName As String = txtName.Text
        Dim strStreet As String = txtAddress.Text
        Dim strCity As String = txtCity.Text
        Dim intChairs As Integer
        Dim intSofas As Integer

        'Declare variables to calculate the total.
        Dim dblTotalDue As Double
        Dim dblTotalTax As Double
        Dim dblOrderPrice As Double

        'Validate the input into the textboxes.
        If ValidateInput(strCustName, strStreet, strCity) Then

        End If
    End Sub


    ''''''''''''''''''''''''''''''''FUNCTIONS'''''''''''''''''''''''''''''''''''''

    Function ValidateInput(strCustName As String, strStreet As String, strCity As String) As Boolean
        If Not strCustName.Contains(",") Or strCustName.Length < 4 Then
            MessageBox.Show("Invalid Name. Make sure the Last Name and First Name are separated by a comma", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf strStreet = "" Or strCity = "" Then
            MessageBox.Show("Invalid City info", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf Not IsNumeric(txtChairs.Text) Or Not IsNumeric(txtSofas.Text) Then
            MessageBox.Show("Invalid number of chairs or sofas. Please enter numeric values", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Else
            Return True
        End If
    End Function
End Class
