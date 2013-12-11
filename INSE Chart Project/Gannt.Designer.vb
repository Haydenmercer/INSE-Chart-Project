<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gannt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gannt))
        Me.ganntTitle = New System.Windows.Forms.Label()
        Me.newWorkItem = New System.Windows.Forms.Button()
        Me.openWorkItem = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ganntTitle
        '
        Me.ganntTitle.AutoSize = True
        Me.ganntTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ganntTitle.Location = New System.Drawing.Point(12, 9)
        Me.ganntTitle.Name = "ganntTitle"
        Me.ganntTitle.Size = New System.Drawing.Size(173, 33)
        Me.ganntTitle.TabIndex = 0
        Me.ganntTitle.Text = "Gannt Chart"
        '
        'newWorkItem
        '
        Me.newWorkItem.Location = New System.Drawing.Point(18, 55)
        Me.newWorkItem.Name = "newWorkItem"
        Me.newWorkItem.Size = New System.Drawing.Size(143, 23)
        Me.newWorkItem.TabIndex = 1
        Me.newWorkItem.Text = "New Work Item"
        Me.newWorkItem.UseVisualStyleBackColor = True
        '
        'openWorkItem
        '
        Me.openWorkItem.Location = New System.Drawing.Point(18, 84)
        Me.openWorkItem.Name = "openWorkItem"
        Me.openWorkItem.Size = New System.Drawing.Size(143, 23)
        Me.openWorkItem.TabIndex = 2
        Me.openWorkItem.Text = "Remove Work Item"
        Me.openWorkItem.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(191, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 33)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'Gannt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 446)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.openWorkItem)
        Me.Controls.Add(Me.newWorkItem)
        Me.Controls.Add(Me.ganntTitle)
        Me.Name = "Gannt"
        Me.Text = "Gannt Chart"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ganntTitle As System.Windows.Forms.Label
    Friend WithEvents newWorkItem As System.Windows.Forms.Button
    Friend WithEvents openWorkItem As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
