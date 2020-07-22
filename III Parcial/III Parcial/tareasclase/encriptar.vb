Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Public Class encriptar

    Public Function Encriptar(ByVal clearText As String, Optional ByVal Clave As String = "MICLAVE123") As String
            Try

                Dim EncryptionKey As String = Clave
                Dim clearBytes As Byte() = Encoding.Unicode.GetBytes(clearText)
                Using encryptor As Aes = Aes.Create()
                    Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D,
                     &H65, &H64, &H76, &H65, &H64, &H65,
                     &H76})
                    encryptor.Key = pdb.GetBytes(32)
                    encryptor.IV = pdb.GetBytes(16)
                    Using ms As New MemoryStream()
                        Using cs As New CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write)
                            cs.Write(clearBytes, 0, clearBytes.Length)
                            cs.Close()
                        End Using
                        clearText = Convert.ToBase64String(ms.ToArray())
                    End Using
                End Using
                Return clearText


            Catch ex As Exception
                Return clearText
            End Try
        End Function

        Public Function Desencriptar(ByVal cipherText As String, Optional ByVal Clave As String = "MICLAVE123") As String
            Try

                Dim EncryptionKey As String = Clave
                Dim cipherBytes As Byte() = Convert.FromBase64String(cipherText)
                Using encryptor As Aes = Aes.Create()
                    Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D,
                     &H65, &H64, &H76, &H65, &H64, &H65,
                     &H76})
                    encryptor.Key = pdb.GetBytes(32)
                    encryptor.IV = pdb.GetBytes(16)
                    Using ms As New MemoryStream()
                        Using cs As New CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write)
                            cs.Write(cipherBytes, 0, cipherBytes.Length)
                            cs.Close()
                        End Using
                        cipherText = Encoding.Unicode.GetString(ms.ToArray())
                    End Using
                End Using
                Return cipherText

            Catch ex As Exception
                Return cipherText
            End Try

        End Function

        Dim conexion As New conexion()
    Private Sub frmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
    End Sub

    'username@midominio.com
    Private Function validarCorreo(ByVal isCorreo As String) As Boolean
        Return Regex.IsMatch(isCorreo, "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$")
    End Function


    Private Sub limpiar()
        txtcodigo.Clear()
        txtnombre.Clear()
        txtapellido.Clear()
        txtusername.Clear()
        txtpsw.Clear()
        txtcorreo.Clear()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If validarCorreo(LCase(txtcorreo.Text)) = False Then
            MessageBox.Show("Correo invalido, *username@midominio.com*", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtcorreo.Focus()
            txtcorreo.SelectAll()
        Else
            insertarUsuaurio()
            MessageBox.Show("Correo valido", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If


    End Sub
    Private Sub insertarUsuaurio()
        Dim idUsuario As Integer
        Dim nombre, apellido, userName, psw, correo, rol, estado As String
        idUsuario = txtcodigo.Text
        nombre = txtnombre.Text
        apellido = txtapellido.Text
        userName = txtusername.Text
        psw = txtpsw.Text
        correo = txtcorreo.Text
        estado = "activo"
        rol = cmbRol.Text
        Try
            If conexion.insertarUsuario(idUsuario, nombre, apellido, userName, psw, rol, estado, correo) Then
                MessageBox.Show("Guardado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error al guardar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub eliminarUsuario()
        Dim idUsuario As Integer
        Dim rol As String
        idUsuario = txtcodigo.Text
        rol = cmbrol.Text
        Try
            If (conexion.eliminarUsuario(idUsuario, rol)) Then
                MsgBox("Dado de baja")
                'conexion.conexion.Close()
            Else
                MsgBox("Error al dar de baja usuario")
                'conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        eliminarUsuario()
    End Sub
    Private Sub modificar()
        Dim id As Integer
        Dim nombre As String
        Dim apellido As String
        Dim usuario As String
        Dim contraseña As String
        Dim correo As String
        Dim rol As Char
        Dim Estado As Char


        id = txtcodigo.Text
        nombre = txtnombre.Text
        apellido = txtapellido.Text
        usuario = txtusername.Text
        contraseña = txtpsw.Text
        correo = txtcorreo.Text
        rol = cmbrol.Text

        Try
            If (conexion.modificar(id, nombre, apellido, usuario, contraseña, correo, rol)) Then
                MsgBox("Modificado correctamente")
                ' conexion.conexion.Close()
            Else
                MsgBox("Error al modificar usuario")
                ' conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Dim id As Integer
        Dim nombre As String
        Dim apellido As String
        Dim usuario As String
        Dim contraseña As String
        Dim correo As String
        Dim rol As Char


        id = txtcodigo.Text
        nombre = txtnombre.Text
        apellido = txtapellido.Text
        usuario = txtusername.Text
        contraseña = txtpsw.Text
        correo = txtcorreo.Text
        rol = cmbrol.Text


        Try
            If conexion.modificar(id, nombre, apellido, usuario, contraseña, correo, rol) Then
                MsgBox("Modificado Correctamente")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtnombre_TextChanged(sender As Object, e As EventArgs) Handles txtnombre.TextChanged
        txtnombre.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtnombre.Text)
        txtnombre.SelectionStart = txtnombre.Text.Length
    End Sub

    Private Sub txtapellido_TextChanged(sender As Object, e As EventArgs) Handles txtapellido.TextChanged
        txtapellido.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtapellido.Text)
        txtapellido.SelectionStart = txtapellido.Text.Length
    End Sub
End Class
