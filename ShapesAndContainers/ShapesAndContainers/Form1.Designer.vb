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
        Me.BorderStyleComboBox = New System.Windows.Forms.ComboBox()
        Me.BorderNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.ColorButton = New System.Windows.Forms.Button()
        CType(Me.BorderNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BorderStyleComboBox
        '
        Me.BorderStyleComboBox.FormattingEnabled = True
        Me.BorderStyleComboBox.Location = New System.Drawing.Point(12, 255)
        Me.BorderStyleComboBox.Name = "BorderStyleComboBox"
        Me.BorderStyleComboBox.Size = New System.Drawing.Size(121, 21)
        Me.BorderStyleComboBox.TabIndex = 0
        '
        'BorderNumericUpDown
        '
        Me.BorderNumericUpDown.Location = New System.Drawing.Point(150, 256)
        Me.BorderNumericUpDown.Name = "BorderNumericUpDown"
        Me.BorderNumericUpDown.Size = New System.Drawing.Size(84, 20)
        Me.BorderNumericUpDown.TabIndex = 1
        '
        'ColorButton
        '
        Me.ColorButton.Location = New System.Drawing.Point(245, 253)
        Me.ColorButton.Name = "ColorButton"
        Me.ColorButton.Size = New System.Drawing.Size(75, 23)
        Me.ColorButton.TabIndex = 2
        Me.ColorButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 288)
        Me.Controls.Add(Me.ColorButton)
        Me.Controls.Add(Me.BorderNumericUpDown)
        Me.Controls.Add(Me.BorderStyleComboBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.BorderNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BorderStyleComboBox As ComboBox
    Friend WithEvents BorderNumericUpDown As NumericUpDown
    Friend WithEvents ColorButton As Button
End Class
