<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRestaurarContrasenia
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRestaurarContrasenia))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rtxHtml = New System.Windows.Forms.RichTextBox()
        Me.btnEnviarCorreo = New System.Windows.Forms.Button()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtPswMostra = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(954, 118)
        Me.Label3.TabIndex = 622
        Me.Label3.Text = "Recuperar contraseña"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rtxHtml
        '
        Me.rtxHtml.Location = New System.Drawing.Point(523, 282)
        Me.rtxHtml.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rtxHtml.Name = "rtxHtml"
        Me.rtxHtml.Size = New System.Drawing.Size(186, 159)
        Me.rtxHtml.TabIndex = 621
        Me.rtxHtml.Text = resources.GetString("rtxHtml.Text")
        '
        'btnEnviarCorreo
        '
        Me.btnEnviarCorreo.BackColor = System.Drawing.Color.SteelBlue
        Me.btnEnviarCorreo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEnviarCorreo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnviarCorreo.FlatAppearance.BorderSize = 0
        Me.btnEnviarCorreo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnEnviarCorreo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnEnviarCorreo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnviarCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnEnviarCorreo.ForeColor = System.Drawing.Color.White
        Me.btnEnviarCorreo.Location = New System.Drawing.Point(123, 348)
        Me.btnEnviarCorreo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEnviarCorreo.Name = "btnEnviarCorreo"
        Me.btnEnviarCorreo.Size = New System.Drawing.Size(378, 80)
        Me.btnEnviarCorreo.TabIndex = 620
        Me.btnEnviarCorreo.Text = "Recuperar"
        Me.btnEnviarCorreo.UseVisualStyleBackColor = False
        '
        'txtCorreo
        '
        Me.txtCorreo.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCorreo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.txtCorreo.ForeColor = System.Drawing.Color.White
        Me.txtCorreo.Location = New System.Drawing.Point(215, 179)
        Me.txtCorreo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(406, 46)
        Me.txtCorreo.TabIndex = 625
        Me.txtCorreo.Tag = "Ingresar contraseña"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(87, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 38)
        Me.Label2.TabIndex = 624
        Me.Label2.Text = "Correo"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(139, 230)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(465, 1)
        Me.Panel4.TabIndex = 623
        '
        'txtPswMostra
        '
        Me.txtPswMostra.AutoSize = True
        Me.txtPswMostra.BackColor = System.Drawing.Color.White
        Me.txtPswMostra.Location = New System.Drawing.Point(397, 381)
        Me.txtPswMostra.Name = "txtPswMostra"
        Me.txtPswMostra.Size = New System.Drawing.Size(57, 20)
        Me.txtPswMostra.TabIndex = 626
        Me.txtPswMostra.Text = "Label2"
        '
        'frmRestaurarContrasenia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(954, 514)
        Me.Controls.Add(Me.txtPswMostra)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rtxHtml)
        Me.Controls.Add(Me.btnEnviarCorreo)
        Me.Name = "frmRestaurarContrasenia"
        Me.Text = "frmRestaurarContrasenia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents rtxHtml As RichTextBox
    Friend WithEvents btnEnviarCorreo As Button
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtPswMostra As Label
End Class
