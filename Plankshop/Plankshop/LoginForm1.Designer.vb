<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")>
Partial Class LoginForm1
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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents txtPW As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm1))
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.txtPW = New System.Windows.Forms.TextBox()
        Me.OK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.txtCVC = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.txtCardNumb1 = New System.Windows.Forms.TextBox()
        Me.txtCardNumb2 = New System.Windows.Forms.TextBox()
        Me.txtCardNumb3 = New System.Windows.Forms.TextBox()
        Me.txtCardNumb4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(401, 192)
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(172, 24)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "&Kortnummer"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(172, 109)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(57, 23)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "&PIN-kod"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPW
        '
        Me.txtPW.Location = New System.Drawing.Point(174, 129)
        Me.txtPW.Multiline = True
        Me.txtPW.Name = "txtPW"
        Me.txtPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPW.Size = New System.Drawing.Size(55, 20)
        Me.txtPW.TabIndex = 6
        '
        'OK
        '
        Me.OK.Location = New System.Drawing.Point(197, 161)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(94, 23)
        Me.OK.TabIndex = 8
        Me.OK.Text = "&OK"
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(300, 161)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(94, 23)
        Me.Cancel.TabIndex = 9
        Me.Cancel.Text = "&Cancel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Total pris:"
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.AutoSize = True
        Me.lblTotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPrice.Location = New System.Drawing.Point(61, 166)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(14, 15)
        Me.lblTotalPrice.TabIndex = 7
        Me.lblTotalPrice.Text = "0"
        '
        'txtCVC
        '
        Me.txtCVC.Location = New System.Drawing.Point(237, 129)
        Me.txtCVC.Multiline = True
        Me.txtCVC.Name = "txtCVC"
        Me.txtCVC.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCVC.Size = New System.Drawing.Size(35, 20)
        Me.txtCVC.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(235, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 18)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "&CVC"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(172, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Fullständigt namn"
        '
        'txtFullName
        '
        Me.txtFullName.Location = New System.Drawing.Point(174, 86)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(220, 20)
        Me.txtFullName.TabIndex = 5
        '
        'txtCardNumb1
        '
        Me.txtCardNumb1.BackColor = System.Drawing.Color.White
        Me.txtCardNumb1.Location = New System.Drawing.Point(175, 47)
        Me.txtCardNumb1.Name = "txtCardNumb1"
        Me.txtCardNumb1.Size = New System.Drawing.Size(34, 20)
        Me.txtCardNumb1.TabIndex = 1
        '
        'txtCardNumb2
        '
        Me.txtCardNumb2.BackColor = System.Drawing.Color.White
        Me.txtCardNumb2.Location = New System.Drawing.Point(215, 47)
        Me.txtCardNumb2.Name = "txtCardNumb2"
        Me.txtCardNumb2.Size = New System.Drawing.Size(34, 20)
        Me.txtCardNumb2.TabIndex = 2
        '
        'txtCardNumb3
        '
        Me.txtCardNumb3.BackColor = System.Drawing.Color.White
        Me.txtCardNumb3.Location = New System.Drawing.Point(255, 47)
        Me.txtCardNumb3.Name = "txtCardNumb3"
        Me.txtCardNumb3.Size = New System.Drawing.Size(34, 20)
        Me.txtCardNumb3.TabIndex = 3
        '
        'txtCardNumb4
        '
        Me.txtCardNumb4.BackColor = System.Drawing.Color.White
        Me.txtCardNumb4.Location = New System.Drawing.Point(295, 47)
        Me.txtCardNumb4.Name = "txtCardNumb4"
        Me.txtCardNumb4.Size = New System.Drawing.Size(34, 20)
        Me.txtCardNumb4.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label4.Location = New System.Drawing.Point(51, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 15)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "AKA LA's Brädgård"
        '
        'LoginForm1
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(401, 192)
        Me.Controls.Add(Me.txtCardNumb4)
        Me.Controls.Add(Me.txtCardNumb3)
        Me.Controls.Add(Me.txtCardNumb2)
        Me.Controls.Add(Me.txtCardNumb1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCVC)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTotalPrice)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.txtPW)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginForm1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Betalning"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotalPrice As Label
    Friend WithEvents txtCVC As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents txtCardNumb1 As TextBox
    Friend WithEvents txtCardNumb2 As TextBox
    Friend WithEvents txtCardNumb3 As TextBox
    Friend WithEvents txtCardNumb4 As TextBox
    Friend WithEvents Label4 As Label
End Class
