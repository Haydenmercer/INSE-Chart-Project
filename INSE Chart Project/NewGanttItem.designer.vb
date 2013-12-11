<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewGanttItem
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.addButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.taskNameBox = New System.Windows.Forms.TextBox()
        Me.startDateBox = New System.Windows.Forms.TextBox()
        Me.opDurationBox = New System.Windows.Forms.TextBox()
        Me.nDurationBox = New System.Windows.Forms.TextBox()
        Me.pDurationBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(12, 227)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(75, 23)
        Me.addButton.TabIndex = 0
        Me.addButton.Text = "Add"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Task Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Start Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Neutral Duration:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Pessimistic Duration:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Optimistic Duration:"
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(93, 227)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(75, 23)
        Me.clearButton.TabIndex = 7
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'taskNameBox
        '
        Me.taskNameBox.Location = New System.Drawing.Point(123, 58)
        Me.taskNameBox.Name = "taskNameBox"
        Me.taskNameBox.Size = New System.Drawing.Size(100, 20)
        Me.taskNameBox.TabIndex = 8
        '
        'startDateBox
        '
        Me.startDateBox.Location = New System.Drawing.Point(123, 91)
        Me.startDateBox.Name = "startDateBox"
        Me.startDateBox.Size = New System.Drawing.Size(100, 20)
        Me.startDateBox.TabIndex = 9
        '
        'opDurationBox
        '
        Me.opDurationBox.Location = New System.Drawing.Point(123, 125)
        Me.opDurationBox.Name = "opDurationBox"
        Me.opDurationBox.Size = New System.Drawing.Size(100, 20)
        Me.opDurationBox.TabIndex = 10
        '
        'nDurationBox
        '
        Me.nDurationBox.Location = New System.Drawing.Point(123, 158)
        Me.nDurationBox.Name = "nDurationBox"
        Me.nDurationBox.Size = New System.Drawing.Size(100, 20)
        Me.nDurationBox.TabIndex = 11
        '
        'pDurationBox
        '
        Me.pDurationBox.Location = New System.Drawing.Point(123, 190)
        Me.pDurationBox.Name = "pDurationBox"
        Me.pDurationBox.Size = New System.Drawing.Size(100, 20)
        Me.pDurationBox.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(162, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Enter Task Details:"
        '
        'NewGanttItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.pDurationBox)
        Me.Controls.Add(Me.nDurationBox)
        Me.Controls.Add(Me.opDurationBox)
        Me.Controls.Add(Me.startDateBox)
        Me.Controls.Add(Me.taskNameBox)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.addButton)
        Me.Location = New System.Drawing.Point(250, 250)
        Me.Name = "NewGanttItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Work Item"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents addButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents taskNameBox As System.Windows.Forms.TextBox
    Friend WithEvents startDateBox As System.Windows.Forms.TextBox
    Friend WithEvents opDurationBox As System.Windows.Forms.TextBox
    Friend WithEvents nDurationBox As System.Windows.Forms.TextBox
    Friend WithEvents pDurationBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
