Imports System.Data.OleDb
Imports System.Windows.Forms

Public Class InteraccionBBDD

    Private _rt As ConectorBBDD
    Private _tipoConexion As String
    Private _ds As DataSet
    Private _query As String

    Public Sub New(ByVal xml As String, ByVal tipo As String)
        _rt = New ConectorBBDD()
        _tipoConexion = ""
        Dim er As Boolean = True
        Try
            _ds = New DataSet
            _ds.ReadXml(xml)
            For i = 0 To _ds.Tables(0).Rows.Count - 1
                If tipo.Equals(_ds.Tables(0).Rows(i).Item("tipo")) Then
                    _tipoConexion = _ds.Tables(0).Rows(i).Item("servidor")
                    er = False
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub

    Public Function EjecutarQuery(ByVal consulta As String) As DataSet
        _query = consulta
        Dim dataSet As DataSet = _rt.ReturnDataSet(_query, _tipoConexion)
        Return dataSet
    End Function

    Private Sub EnviarMail(er As String)
        Dim smtp As New System.Net.Mail.SmtpClient
        Dim correo As New System.Net.Mail.MailMessage

        With smtp
            .Port = 25
            .Host = "smtp.gmail.com"
            .Credentials = New System.Net.NetworkCredential("angelsanchezprat", "Kala123mar")
            .EnableSsl = True
        End With
        With correo
            .From = New System.Net.Mail.MailAddress("error@nocontrolado.net")
            .To.Add("angelsanchezprat@gmail.com")
            .Subject = "¡Error no controlado!"
            .Body = "<strong>" + er + "</strong>"
            .IsBodyHtml = True
            .Priority = System.Net.Mail.MailPriority.Normal
        End With

        Try
            smtp.Send(correo)
            MessageBox.Show("Su mensaje de correo ha sido enviado.", _
                            "Correo enviado", _
                            MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, _
                            "Error al enviar correo", _
                            MessageBoxButtons.OK)
        End Try
    End Sub

    Public Function ComprobarActualizar(ByVal dts As DataSet) As Integer
        Dim errReference As String = "REFERENCE"
        Dim errUnike As String = "UNIQUE KEY"
        Dim r As Integer = -1
        Try
            Dim dta As OleDbDataAdapter
            Dim construct As OleDbCommandBuilder

            dta = New OleDbDataAdapter(_query, _rt._cnx)
            construct = New OleDbCommandBuilder(dta)
            For i = 0 To dts.Tables.Count - 1
                dta.Update(dts.Tables(i))
            Next
        Catch ex As OleDbException
            If ex.Message.IndexOf(errReference) <> -1 Then
                MessageBox.Show("Campos enlazados, imposible realizar la actualización." + vbCr + "Primero elimina los campos enlazados.", _
                "Error!", _
                MessageBoxButtons.OK, _
                MessageBoxIcon.Error, _
                MessageBoxDefaultButton.Button1)
            ElseIf ex.Message.IndexOf(errUnike) <> -1 Then
                MessageBox.Show("Error, no se pueden repetir." + vbCr + "Prueba otro texto.", _
                "Error!", _
                MessageBoxButtons.OK, _
                MessageBoxIcon.Error, _
                MessageBoxDefaultButton.Button1)
            Else
                Dim resultError As DialogResult = MessageBox.Show("¡Error Importante!" + vbCr + vbCr + ex.Message + vbCr + vbCr + "¿Desea informar al administrador del error?", _
                "¡Error Importante!", _
                MessageBoxButtons.YesNo, _
                MessageBoxIcon.Error, _
                MessageBoxDefaultButton.Button1)
                If resultError = Windows.Forms.DialogResult.Yes Then
                    EnviarMail(ex.Message)
                End If
            End If
        End Try
        Return r
    End Function

End Class
