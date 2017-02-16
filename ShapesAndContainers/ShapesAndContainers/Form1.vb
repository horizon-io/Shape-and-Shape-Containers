Imports Microsoft.VisualBasic.PowerPacks
Imports System.Drawing.Drawing2D
Public Class Form1
    ' Declaring the Container of the shape
    Private container As New ShapeContainer()

    Private shape As New RectangleShape(container)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        container.Parent = Me ' Form1

        'shppe properties

        shape.Size = New Size(30, 80)

        shape.Location = New Point(70, 30)


        ' BorderCombo properties

        BorderStyleComboBox.Items.AddRange(GetType(DashStyle).GetEnumNames())
    End Sub

    Private Sub BorderStyleComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BorderStyleComboBox.SelectedIndexChanged
        shape.BorderStyle = BorderStyleComboBox.SelectedIndex

    End Sub

    Private Sub ColorButton_Click(sender As Object, e As EventArgs) Handles ColorButton.Click

        Dim colorDialog As New ColorDialog
        colorDialog.ShowDialog()

        ColorButton.ForeColor = colorDialog.Color
        ColorButton.BackColor = colorDialog.Color

        shape.BorderColor = colorDialog.Color

    End Sub

    Private Sub BorderNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles BorderNumericUpDown.ValueChanged
        shape.BorderWidth = BorderNumericUpDown.Value
    End Sub
End Class
