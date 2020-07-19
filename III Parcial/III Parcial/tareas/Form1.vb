Imports System.Runtime.InteropServices
Public Class Form1
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Application.Exit()

    End Sub

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        btnMaximizar.Visible = False
        btnRestaurar.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        btnRestaurar.Visible = False
        btnMaximizar.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub



    Private Sub TimerOcultarMenu_Tick(sender As Object, e As EventArgs) Handles timerOcultarMenu.Tick

    End Sub

    Private Sub timerMostrarMenu_Tick(sender As Object, e As EventArgs) Handles timerMostrarMenu.Tick

    End Sub

    Private Sub abrirFormulario(ByVal formHijo As Object)
        If PanelCon.Controls.Count > 0 Then
            Me.PanelCon.Controls.RemoveAt(0)
        End If
        Dim frm As Form = TryCast(formHijo, Form)
        frm.TopLevel = False
        frm.Dock = DockStyle.Fill
        Me.PanelCon.Controls.Add(frm)
        Me.PanelCon.Tag = frm
        frm.Show()

    End Sub

    Private Sub BarraTitulo_Paint(sender As Object, e As PaintEventArgs) Handles Barratitulo.Paint
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        abrirFormulario(tareasclase)
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        tmensaje.SetToolTip(Button1, "Dar click para mostrar las opciones de trabajo en clase")
        tmensaje.ToolTipTitle = "Descripcion"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        tmensaje.SetToolTip(Button2, "Dar click para mostrar las opciones de trabajos tareas")
        tmensaje.ToolTipTitle = "Descripcion"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        abrirFormulario(tareas)
    End Sub



    Private Sub PROGRAMACIÓN_Click(sender As Object, e As EventArgs) Handles PROGRAMACIÓN.Click

    End Sub
End Class
