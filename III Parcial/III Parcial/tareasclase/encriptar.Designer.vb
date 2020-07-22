<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class encriptar
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.txtpsw = New System.Windows.Forms.TextBox()
        Me.btnencriptar = New System.Windows.Forms.Button()
        Me.btndesencriptar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbrol = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtcorreo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.Código = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 184)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 231)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña"
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(134, 177)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(142, 26)
        Me.txtusername.TabIndex = 2
        '
        'txtpsw
        '
        Me.txtpsw.Location = New System.Drawing.Point(134, 224)
        Me.txtpsw.Name = "txtpsw"
        Me.txtpsw.Size = New System.Drawing.Size(142, 26)
        Me.txtpsw.TabIndex = 3
        '
        'btnencriptar
        '
        Me.btnencriptar.Location = New System.Drawing.Point(435, 249)
        Me.btnencriptar.Name = "btnencriptar"
        Me.btnencriptar.Size = New System.Drawing.Size(140, 40)
        Me.btnencriptar.TabIndex = 4
        Me.btnencriptar.Text = "Encriptar"
        Me.btnencriptar.UseVisualStyleBackColor = True
        '
        'btndesencriptar
        '
        Me.btndesencriptar.Location = New System.Drawing.Point(581, 249)
        Me.btndesencriptar.Name = "btndesencriptar"
        Me.btndesencriptar.Size = New System.Drawing.Size(140, 39)
        Me.btndesencriptar.TabIndex = 5
        Me.btndesencriptar.Text = "Desencriptar"
        Me.btndesencriptar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbrol)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtcorreo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtapellido)
        Me.GroupBox1.Controls.Add(Me.Código)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtcodigo)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtusername)
        Me.GroupBox1.Controls.Add(Me.txtpsw)
        Me.GroupBox1.Location = New System.Drawing.Point(59, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(370, 362)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Usuario"
        '
        'cmbrol
        '
        Me.cmbrol.FormattingEnabled = True
        Me.cmbrol.Items.AddRange(New Object() {"admin ", "cajero"})
        Me.cmbrol.Location = New System.Drawing.Point(134, 263)
        Me.cmbrol.Name = "cmbrol"
        Me.cmbrol.Size = New System.Drawing.Size(142, 28)
        Me.cmbrol.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 271)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Rol"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 303)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Correo"
        '
        'txtcorreo
        '
        Me.txtcorreo.Location = New System.Drawing.Point(134, 303)
        Me.txtcorreo.Name = "txtcorreo"
        Me.txtcorreo.Size = New System.Drawing.Size(142, 26)
        Me.txtcorreo.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Apellido"
        '
        'txtapellido
        '
        Me.txtapellido.Location = New System.Drawing.Point(134, 136)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(142, 26)
        Me.txtapellido.TabIndex = 9
        '
        'Código
        '
        Me.Código.AutoSize = True
        Me.Código.Location = New System.Drawing.Point(25, 46)
        Me.Código.Name = "Código"
        Me.Código.Size = New System.Drawing.Size(59, 20)
        Me.Código.TabIndex = 4
        Me.Código.Text = "Código"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Nombre"
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(134, 46)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(142, 26)
        Me.txtcodigo.TabIndex = 6
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(134, 93)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(142, 26)
        Me.txtnombre.TabIndex = 7
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(59, 400)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(140, 39)
        Me.btnguardar.TabIndex = 7
        Me.btnguardar.Text = "Grabar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(205, 399)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(140, 39)
        Me.btneliminar.TabIndex = 8
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btnmodificar
        '
        Me.btnmodificar.Location = New System.Drawing.Point(351, 399)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(140, 39)
        Me.btnmodificar.TabIndex = 9
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'encriptar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 450)
        Me.Controls.Add(Me.btnmodificar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btndesencriptar)
        Me.Controls.Add(Me.btnencriptar)
        Me.Name = "encriptar"
        Me.Text = "encriptar"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents txtpsw As TextBox
    Friend WithEvents btnencriptar As Button
    Friend WithEvents btndesencriptar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtcorreo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtapellido As TextBox
    Friend WithEvents Código As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents btnguardar As Button
    Friend WithEvents cmbrol As ComboBox
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnmodificar As Button
End Class
