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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmbItems = New System.Windows.Forms.ComboBox()
        Me.txtRec = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtQuan = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PropertyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(198, 501)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'cmbItems
        '
        Me.cmbItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbItems.FormattingEnabled = True
        Me.cmbItems.Items.AddRange(New Object() {"2x2", "4x4", "6x6", "8x6", "8x8", "10x6", "10x8"})
        Me.cmbItems.Location = New System.Drawing.Point(9, 180)
        Me.cmbItems.MaxDropDownItems = 15
        Me.cmbItems.Name = "cmbItems"
        Me.cmbItems.Size = New System.Drawing.Size(175, 21)
        Me.cmbItems.TabIndex = 2
        '
        'txtRec
        '
        Me.txtRec.BackColor = System.Drawing.Color.White
        Me.txtRec.Enabled = False
        Me.txtRec.ForeColor = System.Drawing.Color.Black
        Me.txtRec.Location = New System.Drawing.Point(11, 265)
        Me.txtRec.Multiline = True
        Me.txtRec.Name = "txtRec"
        Me.txtRec.ReadOnly = True
        Me.txtRec.Size = New System.Drawing.Size(173, 219)
        Me.txtRec.TabIndex = 5
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(9, 207)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(175, 23)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Lägg till"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnPay
        '
        Me.btnPay.Location = New System.Drawing.Point(9, 490)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(175, 23)
        Me.btnPay.TabIndex = 6
        Me.btnPay.Text = "Betala"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(9, 236)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(175, 23)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Rensa"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtQuan
        '
        Me.txtQuan.Location = New System.Drawing.Point(9, 154)
        Me.txtQuan.Name = "txtQuan"
        Me.txtQuan.Size = New System.Drawing.Size(175, 20)
        Me.txtQuan.TabIndex = 1
        Me.txtQuan.Text = "Antal meter"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenyToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(198, 24)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenyToolStripMenuItem
        '
        Me.MenyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.PropertyToolStripMenuItem})
        Me.MenyToolStripMenuItem.Name = "MenyToolStripMenuItem"
        Me.MenyToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.MenyToolStripMenuItem.Text = "Meny"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'PropertyToolStripMenuItem
        '
        Me.PropertyToolStripMenuItem.Name = "PropertyToolStripMenuItem"
        Me.PropertyToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PropertyToolStripMenuItem.Text = "Properties"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(198, 525)
        Me.Controls.Add(Me.txtQuan)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtRec)
        Me.Controls.Add(Me.cmbItems)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cmbItems As ComboBox
    Friend WithEvents txtRec As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnPay As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtQuan As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PropertyToolStripMenuItem As ToolStripMenuItem
End Class
