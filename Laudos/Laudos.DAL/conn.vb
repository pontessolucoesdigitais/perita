
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Configuration

Public Class conn

    Public Shared connString As String = "Persist Security Info=False;server=mysql22.redehost.com.br;port=41890;database=perita;uid=perita;pwd=G12qwaszx!@#"
    Public Shared Erro As String = ""
    Private Shared connLic As New MySqlConnection(connString)
    Private Shared conn As New MySqlConnection(connString)
    Private Shared connSqlCon As New MySqlConnection(connString)

    Public Shared Function AbrirConexao(Lic As Boolean, Optional bSqlConn As Boolean = False) As Boolean
        Dim strConn As String = ""
        Try


            If bSqlConn AndAlso connSqlCon.State <> ConnectionState.Open Then
                'strConn = UTL.Criptografia.Desencriptar(ConfigurationManager.AppSettings("strConn"))
                'strConn = strConn.Replace("Provider=SQLMySql.1;", "").Replace("Provider=MSMySqlSQL.1;", "")
                'strConn = connString
                'connSqlCon.ConnectionString = strConn
                connSqlCon.Open()

            ElseIf (Not Lic) AndAlso conn.State <> ConnectionState.Open Then
                'strConn = UTL.Criptografia.Desencriptar(ConfigurationManager.AppSettings("strConn"))
                'strConn = connString
                'conn.ConnectionString = strConn
                conn.Open()

            ElseIf (Lic) AndAlso connLic.State <> ConnectionState.Open Then
                'strConn = UTL.Criptografia.Desencriptar(ConfigurationManager.AppSettings("strConnLic"))
                'strConn = connString
                'connLic.ConnectionString = strConn
                connLic.Open()

            End If
            Return True
        Catch ex As Exception
            Erro = ex.Message
            GravaLog(ex.Message, strConn)
            Return False
        End Try
    End Function

    Public Shared Sub FecharConexao(Optional Lic As Boolean = False)
        If (Not Lic) AndAlso conn.State <> ConnectionState.Open Then
            connLic.Close()
            connLic.Dispose()
        ElseIf Lic AndAlso connLic.State <> ConnectionState.Open Then
            conn.Close()
            conn.Dispose()
        End If

    End Sub

    Public Shared Function Selecionar(sSql As String, Optional Lic As Boolean = False) As DataTable
        Try
            Dim ret As New DataTable
            AbrirConexao(Lic)
            Dim auxConn As MySqlConnection = DirectCast(IIf(Lic, connLic, conn), MySqlConnection)
            Dim da As New MySqlDataAdapter(sSql, auxConn)
            Dim dt As New DataTable()
            da.Fill(dt)
            da.Dispose()
            da = Nothing
            Return dt
        Catch ex As Exception
            GravaLog(ex.Message, sSql)
            Return Nothing
        Finally
            Try
                FecharConexao(Lic)
            Catch ex As Exception
            End Try
        End Try

    End Function

    Public Shared Function SelecionarNumero(sSql As String, Optional Lic As Boolean = False) As Integer
        Try
            Dim ret As New DataTable
            AbrirConexao(Lic)
            Dim auxConn As MySqlConnection = IIf(Lic, connLic, conn)
            Dim da As New MySqlDataAdapter(sSql, auxConn)
            Dim dt As New DataTable()
            da.Fill(dt)
            da = Nothing

            If dt.Rows.Count = 1 Then
                Return Convert.ToInt32(dt.Rows(0)(0).ToString())
            Else
                Return 0
            End If
        Catch ex As Exception
            GravaLog(ex.Message, sSql)
            Return 0
        Finally
            Try
                FecharConexao(Lic)
            Catch ex As Exception
            End Try
        End Try

    End Function

    Public Shared Function SelecionarObjeto(sSql As String, Optional Lic As Boolean = False) As Object
        Try
            Dim ret As New DataTable
            AbrirConexao(Lic)
            Dim auxConn As MySqlConnection = IIf(Lic, connLic, conn)
            Dim da As New MySqlDataAdapter(sSql, auxConn)
            Dim dt As New DataTable()
            da.Fill(dt)
            da = Nothing

            If dt.Rows.Count = 1 Then
                Return dt.Rows(0)(0)
            Else
                Return 0
            End If
        Catch ex As Exception
            GravaLog(ex.Message, sSql)
            Return 0
        Finally
            Try
                FecharConexao(Lic)
            Catch ex As Exception
            End Try
        End Try

    End Function

    Public Shared Function ExecutarCommand(cmd As MySqlCommand, Optional Lic As Boolean = False) As Boolean
        cmd.CommandType = CommandType.Text
        Try
            AbrirConexao(Lic)
            Dim auxConn As MySqlConnection = IIf(Lic, connLic, conn)
            cmd.Connection = auxConn
            cmd.ExecuteNonQuery()
            Return True


        Catch ex As Exception
            GravaLog(ex.Message, cmd.CommandText)
            Return False
        Finally
            Try
                FecharConexao(Lic)
            Catch ex As Exception
            End Try
        End Try
    End Function

    Public Shared Function ExecutarSqlCommand(cmd As MySqlCommand, Optional Lic As Boolean = False) As Boolean
        cmd.CommandType = CommandType.Text
        Try
            AbrirConexao(False, True)
            cmd.Connection = connSqlCon
            cmd.ExecuteNonQuery()
            connSqlCon.Close()
            Return True

        Catch ex As Exception
            GravaLog(ex.Message, cmd.CommandText)
            Return False
        Finally
            Try
                FecharConexao(Lic)
            Catch ex As Exception
            End Try
        End Try
    End Function

    Public Shared Function ReturnScalarSqlCommand(cmd As MySqlCommand, Optional Lic As Boolean = False) As Object
        Dim auxRet As Object

        cmd.CommandType = CommandType.Text
        Try
            AbrirConexao(False, True)
            cmd.Connection = connSqlCon
            auxRet = cmd.ExecuteScalar
            connSqlCon.Close()

            Return auxRet
        Catch ex As Exception
            GravaLog(ex.Message, cmd.CommandText)
            Return False
        Finally
            Try
                FecharConexao(Lic)
            Catch ex As Exception
            End Try
        End Try
    End Function

    Public Shared Function Executar(sSql As String, Optional Lic As Boolean = False) As Boolean
        Try
            Dim cmd As New MySqlCommand()
            AbrirConexao(Lic)
            Dim auxConn As MySqlConnection = IIf(Lic, connLic, conn)
            cmd.Connection = auxConn
            cmd.CommandText = sSql
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            GravaLog(ex.Message, sSql)
            Return False
        Finally
            Try
                FecharConexao(Lic)
            Catch ex As Exception
            End Try
        End Try
    End Function

    Public Shared Function BackupDatabase() As Boolean

        Dim strArq As String = ConfigurationManager.AppSettings("localBackupBD") & "\" & Now.ToString("yyyy_MM_dd HH-mm-ss") & "_" & Environment.MachineName.ToUpper & ".bak"
        Dim strSql As String
        Try
            Dim arq As New FileInfo(strArq)
            If Not arq.Directory.Exists Then
                arq.Directory.Create()
            End If

            Dim strNomeCatalogo As String = ConfigurationManager.AppSettings("nomeCatalogo")
            strSql = "BACKUP DATABASE [" & strNomeCatalogo & "] TO DISK = '" & strArq & "'"
            'Dim strConnAux = UTL.Criptografia.Desencriptar(ConfigurationManager.AppSettings("strConn"))
            Dim strConnAux = connString
            Dim cn As New MySqlConnection(strConnAux.Replace(strNomeCatalogo, "MASTER"))
            Dim cmdBackup As New MySqlCommand(strSql, cn)

            cn.Open()

            cmdBackup.ExecuteNonQuery()
            cn.Close()
            Return True

        Catch ex As Exception
            GravaLog(ex.Message, strSql)
            Return False
        Finally
        End Try
    End Function
    Public Shared Function RestauraDatabase(ByVal backupFile As String) As Boolean
        Dim strNomeCatalogo As String = ConfigurationManager.AppSettings("nomeCatalogo")
        Dim strSql As String = "RESTORE DATABASE [" & strNomeCatalogo & "] FROM DISK = '" & backupFile & "'"
        Try
            'Dim strConnAux As String = UTL.Criptografia.Desencriptar(ConfigurationManager.AppSettings("strConn"))
            Dim strConnAux = connString

            Dim cn As New MySqlConnection(strConnAux.Replace(strNomeCatalogo, "MASTER"))
            Dim cmdBackup As New MySqlCommand(strSql, cn)

            cn.Open()

            cmdBackup.ExecuteNonQuery()
            cn.Close()
            Return True

        Catch ex As Exception
            GravaLog(ex.Message, strSql)
            Return False
        End Try
    End Function

    Private Shared Sub GravaLog(descricao As String, sql As String)
        'Dim sqlLog As String = String.Format("INSERT INTO tblLog (descricao, instrucaoSQL ) values('{0}','{1}');", Mid(descricao.Replace("'", ""), 1, 255), Mid(sql.Replace("'", ""), 1, 255))
        'Executar(sqlLog)
        'UTL.Geral.GravaLog("SGE", descricao, sql)

    End Sub

    Public Shared Function TestarConexao(ByRef strMsg As String) As Boolean
        strMsg = "Validando acesso ao banco de dados"
        If Not AbrirConexao(True) Then
            strMsg = "Erro ao acessar dados da licença"
            Return False
        End If

        If Not AbrirConexao(False) Then
            If strMsg <> "" Then
                strMsg &= ";"
            End If
            strMsg &= "Erro ao acessar dados da sistema"
            Return False
        End If
        strMsg = ""
        Return True

    End Function

End Class
