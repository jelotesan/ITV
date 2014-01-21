Imports System.Data.OleDb

Public Class ConectorBBDD
    Public _cnx As OleDbConnection
    Private _dts As DataSet

    Public Sub New()
        _cnx = New OleDbConnection
    End Sub

    Public Function ReturnDataSet(ByVal query As String, ByVal cnxCadena As String) As DataSet

        Dim dta As OleDbDataAdapter
        Dim Construct As OleDbCommandBuilder

        Conexion(cnxCadena)
        dta = New OleDbDataAdapter(query, _cnx)
        Construct = New OleDbCommandBuilder(dta)
        _dts = New DataSet

        dta.FillSchema(_dts, SchemaType.Source)
        dta.Fill(_dts)
        Return _dts

    End Function

    Private Sub Conexion(ByVal ConexionString As String)

        _cnx = New OleDbConnection(ConexionString)
        _cnx.Open()

    End Sub
End Class
