<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.name_tb = New System.Windows.Forms.TextBox()
        Me.age_tb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.add = New System.Windows.Forms.Button()
        Me.delete_bt = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(83, 251)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(329, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Table"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(83, 80)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(329, 165)
        Me.DataGridView1.TabIndex = 3
        '
        'name_tb
        '
        Me.name_tb.Location = New System.Drawing.Point(481, 111)
        Me.name_tb.Name = "name_tb"
        Me.name_tb.Size = New System.Drawing.Size(181, 20)
        Me.name_tb.TabIndex = 4
        '
        'age_tb
        '
        Me.age_tb.Location = New System.Drawing.Point(481, 166)
        Me.age_tb.Name = "age_tb"
        Me.age_tb.Size = New System.Drawing.Size(181, 20)
        Me.age_tb.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(481, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(481, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Age"
        '
        'add
        '
        Me.add.Location = New System.Drawing.Point(683, 108)
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(104, 23)
        Me.add.TabIndex = 8
        Me.add.Text = "Add"
        Me.add.UseVisualStyleBackColor = True
        '
        'delete_bt
        '
        Me.delete_bt.Location = New System.Drawing.Point(683, 138)
        Me.delete_bt.Name = "delete_bt"
        Me.delete_bt.Size = New System.Drawing.Size(104, 23)
        Me.delete_bt.TabIndex = 9
        Me.delete_bt.Text = "delete"
        Me.delete_bt.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1112, 295)
        Me.Controls.Add(Me.delete_bt)
        Me.Controls.Add(Me.add)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.age_tb)
        Me.Controls.Add(Me.name_tb)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents name_tb As TextBox
    Friend WithEvents age_tb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents add As Button
    Friend WithEvents delete_bt As Button
End Class
