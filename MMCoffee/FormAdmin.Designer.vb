<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAdmin
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAdmin))
        Me.pnlAdmin = New System.Windows.Forms.Panel()
        Me.Label_Waktu = New System.Windows.Forms.Label()
        Me.Label_Tanggal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnStock = New System.Windows.Forms.Button()
        Me.btnProduct = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlAdmin.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlAdmin
        '
        Me.pnlAdmin.BackColor = System.Drawing.Color.Transparent
        Me.pnlAdmin.Controls.Add(Me.Label_Waktu)
        Me.pnlAdmin.Controls.Add(Me.Label_Tanggal)
        Me.pnlAdmin.Controls.Add(Me.Label5)
        Me.pnlAdmin.Controls.Add(Me.Label4)
        Me.pnlAdmin.Controls.Add(Me.Label1)
        Me.pnlAdmin.Controls.Add(Me.btnLogout)
        Me.pnlAdmin.Controls.Add(Me.Label3)
        Me.pnlAdmin.Controls.Add(Me.btnStock)
        Me.pnlAdmin.Controls.Add(Me.btnProduct)
        Me.pnlAdmin.Controls.Add(Me.btnReport)
        Me.pnlAdmin.Controls.Add(Me.Label2)
        Me.pnlAdmin.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlAdmin.Location = New System.Drawing.Point(1, 3)
        Me.pnlAdmin.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlAdmin.Name = "pnlAdmin"
        Me.pnlAdmin.Size = New System.Drawing.Size(1896, 1009)
        Me.pnlAdmin.TabIndex = 2
        '
        'Label_Waktu
        '
        Me.Label_Waktu.AutoSize = True
        Me.Label_Waktu.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Waktu.Location = New System.Drawing.Point(980, 384)
        Me.Label_Waktu.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label_Waktu.Name = "Label_Waktu"
        Me.Label_Waktu.Size = New System.Drawing.Size(118, 26)
        Me.Label_Waktu.TabIndex = 5
        Me.Label_Waktu.Text = "12:00:00 AM"
        '
        'Label_Tanggal
        '
        Me.Label_Tanggal.AutoSize = True
        Me.Label_Tanggal.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Tanggal.Location = New System.Drawing.Point(920, 344)
        Me.Label_Tanggal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label_Tanggal.Name = "Label_Tanggal"
        Me.Label_Tanggal.Size = New System.Drawing.Size(221, 26)
        Me.Label_Tanggal.TabIndex = 4
        Me.Label_Tanggal.Text = "Wednesday, 1 May 2019"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 22.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(974, 280)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 49)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "ADMIN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1307, 612)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 23)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Logout"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(696, 612)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Update Stock"
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.Location = New System.Drawing.Point(1249, 455)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(177, 145)
        Me.btnLogout.TabIndex = 0
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1117, 612)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 23)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Report"
        '
        'btnStock
        '
        Me.btnStock.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStock.FlatAppearance.BorderSize = 0
        Me.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStock.Image = Global.MMCoffee.My.Resources.Resources.inventory__2_
        Me.btnStock.Location = New System.Drawing.Point(660, 455)
        Me.btnStock.Margin = New System.Windows.Forms.Padding(2)
        Me.btnStock.Name = "btnStock"
        Me.btnStock.Size = New System.Drawing.Size(177, 145)
        Me.btnStock.TabIndex = 0
        Me.btnStock.UseVisualStyleBackColor = False
        '
        'btnProduct
        '
        Me.btnProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnProduct.FlatAppearance.BorderSize = 0
        Me.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProduct.Image = CType(resources.GetObject("btnProduct.Image"), System.Drawing.Image)
        Me.btnProduct.Location = New System.Drawing.Point(858, 455)
        Me.btnProduct.Margin = New System.Windows.Forms.Padding(2)
        Me.btnProduct.Name = "btnProduct"
        Me.btnProduct.Size = New System.Drawing.Size(177, 145)
        Me.btnProduct.TabIndex = 0
        Me.btnProduct.UseVisualStyleBackColor = False
        '
        'btnReport
        '
        Me.btnReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReport.FlatAppearance.BorderSize = 0
        Me.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReport.Image = CType(resources.GetObject("btnReport.Image"), System.Drawing.Image)
        Me.btnReport.Location = New System.Drawing.Point(1054, 455)
        Me.btnReport.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(177, 145)
        Me.btnReport.TabIndex = 0
        Me.btnReport.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(886, 612)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Update Product"
        '
        'Timer1
        '
        '
        'FormAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1894, 1009)
        Me.Controls.Add(Me.pnlAdmin)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormAdmin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlAdmin.ResumeLayout(False)
        Me.pnlAdmin.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlAdmin As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnStock As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnProduct As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnReport As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label_Waktu As Label
    Friend WithEvents Label_Tanggal As Label
    Friend WithEvents Timer1 As Timer
End Class
