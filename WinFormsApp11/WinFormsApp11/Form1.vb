Public Class Form1
    Private Sub JToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            MessageBox.Show("Returning To App")
        ElseIf result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Function ValidData() As Boolean
        ' Business rule #1: An inventory item type has been selected from the itemComboBox control.
        If itemComboBox.SelectedItem Is Nothing Then
            MessageBox.Show("Please select an inventory item type.")
            Return False
        End If

        ' Business rule #2: The wholesaleCostTextBox control contains a numeric value greater than zero.
        Dim wholesaleCost As Decimal
        If Not Decimal.TryParse(wholesaleCostTextBox.Text, wholesaleCost) OrElse wholesaleCost <= 0 Then
            MessageBox.Show("Please enter a valid wholesale cost greater than zero.")
            Return False
        End If

        ' Business rule #3: The quantityTextBox control contains a numeric value greater than zero.
        Dim quantity As Integer
        If Not Integer.TryParse(quantityTextBox.Text, quantity) OrElse quantity <= 0 Then
            MessageBox.Show("Please enter a valid quantity greater than zero.")
            Return False
        End If

        ' All business rules passed, data is valid
        Return True

    End Function

    ' Define a module-level variable to store the total inventory value
    Private totalInventoryValue As Decimal = 0

    Private Sub AddToItemListingToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ' Call the ValidData function to validate the input
        If ValidData() Then
            ' Process the data and add it to the item listing
            Dim selectedItem As String = itemComboBox.SelectedItem.ToString()
            Dim wholesaleCost As Decimal = Decimal.Parse(wholesaleCostTextBox.Text)
            Dim quantity As Integer = Integer.Parse(quantityTextBox.Text)

            ' Calculate the item value (quantity times price)
            Dim itemValue As Decimal = wholesaleCost * quantity

            ' Add the item and item value to the itemListBox
            Dim listItem As String = selectedItem & " - " & itemValue.ToString("C")
            itemListBox.Items.Add(listItem)

            ' Accumulate the item value to the total inventory value
            totalInventoryValue += itemValue

            ' Update the display of the running total inventory value
            totalInventoryValueTextBox.Text = totalInventoryValue.ToString("C")

            ' Clear the text property for the input controls
            itemComboBox.SelectedIndex = -1
            itemComboBox.Text = ""
            wholesaleCostTextBox.Clear()
            quantityTextBox.Clear()

            ' Set the focus to the itemComboBox
            itemComboBox.Focus()
        End If
    End Sub

    Private Sub ClearListingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearListingToolStripMenuItem.Click
        ' Display a confirmation message box
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to start a new inventory session? This will clear the item list.", "Clear Item Listing", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If result = DialogResult.Yes Then
            ' Unselect the itemComboBox
            itemComboBox.SelectedIndex = -1

            ' Clear the text property of the itemComboBox and TextBox controls
            itemComboBox.Text = ""
            wholesaleCostTextBox.Clear()
            quantityTextBox.Clear()

            ' Clear the contents of the itemListBox
            itemListBox.Items.Clear()

            ' Reset the total inventory value
            totalInventoryValue = 0

            ' Update the display of the running total inventory value
            totalInventoryValueTextBox.Text = totalInventoryValue.ToString("C")

            ' Set the focus to the itemComboBox
            itemComboBox.Focus()
        End If
    End Sub

    Private Sub CountItemListingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CountItemListingToolStripMenuItem.Click

        Dim itemCount As Integer = itemComboBox.Items.Count

        Dim message As String
        If itemCount = 0 Then
            message = "There are no inventory items available."
        ElseIf itemCount = 1 Then
            message = "There is 1 inventory item available."
        Else
            message = "There are " & itemCount & " inventory items available."
        End If

        MessageBox.Show(message, "Inventory Item Count", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub AddItemToComboBoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddItemToComboBoxToolStripMenuItem.Click
        Dim newItem As String = itemComboBox.Text.Trim()

        ' Check if the new item is blank
        If newItem = "" Then
            MessageBox.Show("Please enter a non-blank item name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Check for duplicates
        If itemComboBox.Items.Cast(Of String)().Any(Function(item) String.Equals(item, newItem, StringComparison.OrdinalIgnoreCase)) Then
            MessageBox.Show("This item already exists in the inventory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Add the new item to the ComboBox and sort the items
        itemComboBox.Items.Add(newItem)
        itemComboBox.Sorted = True

        ' Clear the TextBox portion of the ComboBox
        itemComboBox.Text = ""

        ' Set the focus back to the ComboBox
        itemComboBox.Focus()
    End Sub

    Private Sub DeleteComboBoxItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteComboBoxItemToolStripMenuItem.Click

        ' Check if an item is selected in the ComboBox
        If itemComboBox.SelectedIndex = -1 Then
            MessageBox.Show("Please select an item to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Delete the selected item from the ComboBox
        itemComboBox.Items.RemoveAt(itemComboBox.SelectedIndex)

        ' Clear the Text property of the ComboBox
        itemComboBox.Text = ""

    End Sub

    Private Sub SetBackgroundColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetBackgroundColorToolStripMenuItem.Click
        ' Create a new instance of ColorDialog
        Dim colorDialog As New ColorDialog()

        ' Show the ColorDialog to the user
        Dim result As DialogResult = colorDialog.ShowDialog()

        ' If the user selects a color and clicks OK, change the form's background color
        If result = DialogResult.OK Then
            Me.BackColor = colorDialog.Color
        End If
    End Sub

    Private Sub changeFontButton_Click(sender As Object, e As EventArgs) Handles changeFontButton.Click
        Dim fontDialog As New FontDialog()

        ' Show the FontDialog to the user
        Dim result As DialogResult = fontDialog.ShowDialog()

        ' If the user selects a font and clicks OK, change the font for all controls on the form
        If result = DialogResult.OK Then
            SetFontForControlAndChildren(Me, fontDialog.Font)
        End If
    End Sub

    Private Sub SetFontForControlAndChildren(parentControl As Control, font As Font)
        ' Set the font for the parent control
        parentControl.Font = font

        For Each control As Control In parentControl.Controls
            SetFontForControlAndChildren(control, font)
        Next
    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        If e.Button = MouseButtons.Right Then
            formContextMenu.Show(Me, e.Location)
        End If
    End Sub
    Private Sub ShowNameAndDateTimeButton_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        ' Get the current date and time
        Dim currentDateTime As String = DateTime.Now.ToString()

        Dim message As String = "Your Name: [Your Name]" & vbCrLf & "Current Date/Time: " & currentDateTime

        MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click

        Dim fontDialog As New FontDialog()

        ' Show the FontDialog to the user
        Dim result As DialogResult = fontDialog.ShowDialog()

        ' If the user selects a font and clicks OK, change the font for all controls on the form
        If result = DialogResult.OK Then
            SetFontForControlAndChildren(Me, fontDialog.Font)
        End If

    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
