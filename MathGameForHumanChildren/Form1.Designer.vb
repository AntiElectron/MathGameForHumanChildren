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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_launch = New System.Windows.Forms.TextBox()
        Me.Lbl_Launch = New System.Windows.Forms.Label()
        Me.Btn_Launch = New System.Windows.Forms.Button()
        Me.Pnl_Launch = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Pnl_Launch.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SpringGreen
        Me.Label1.Location = New System.Drawing.Point(136, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(416, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "The Battle of Mathy Ridge"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Corbel", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(252, 399)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(196, 59)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Begin"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txt_launch
        '
        Me.txt_launch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_launch.Location = New System.Drawing.Point(48, 35)
        Me.txt_launch.Name = "txt_launch"
        Me.txt_launch.Size = New System.Drawing.Size(100, 20)
        Me.txt_launch.TabIndex = 1
        Me.txt_launch.Text = "Player"
        '
        'Lbl_Launch
        '
        Me.Lbl_Launch.AutoSize = True
        Me.Lbl_Launch.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Launch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Launch.Location = New System.Drawing.Point(45, 10)
        Me.Lbl_Launch.Name = "Lbl_Launch"
        Me.Lbl_Launch.Size = New System.Drawing.Size(116, 18)
        Me.Lbl_Launch.TabIndex = 2
        Me.Lbl_Launch.Text = "Enter Username"
        '
        'Btn_Launch
        '
        Me.Btn_Launch.Location = New System.Drawing.Point(13, 61)
        Me.Btn_Launch.Name = "Btn_Launch"
        Me.Btn_Launch.Size = New System.Drawing.Size(164, 23)
        Me.Btn_Launch.TabIndex = 3
        Me.Btn_Launch.Text = "Enter"
        Me.Btn_Launch.UseVisualStyleBackColor = True
        '
        'Pnl_Launch
        '
        Me.Pnl_Launch.BackColor = System.Drawing.Color.LemonChiffon
        Me.Pnl_Launch.BackgroundImage = CType(resources.GetObject("Pnl_Launch.BackgroundImage"), System.Drawing.Image)
        Me.Pnl_Launch.Controls.Add(Me.Btn_Launch)
        Me.Pnl_Launch.Controls.Add(Me.Lbl_Launch)
        Me.Pnl_Launch.Controls.Add(Me.txt_launch)
        Me.Pnl_Launch.Location = New System.Drawing.Point(-1, -1)
        Me.Pnl_Launch.Name = "Pnl_Launch"
        Me.Pnl_Launch.Size = New System.Drawing.Size(205, 120)
        Me.Pnl_Launch.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(230, 211)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 37)
        Me.Label2.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(198, 115)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Pnl_Launch)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Battle of Mathy Ridge"
        Me.Pnl_Launch.ResumeLayout(False)
        Me.Pnl_Launch.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_launch As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Launch As System.Windows.Forms.Label
    Friend WithEvents Btn_Launch As System.Windows.Forms.Button
    Friend WithEvents Pnl_Launch As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
