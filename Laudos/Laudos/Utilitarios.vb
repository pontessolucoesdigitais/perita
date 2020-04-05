Module Utilitarios
    Sub Ampulheta(b As Boolean, frm As Form)
        If b Then
            frm.Cursor = Cursors.WaitCursor
        Else
            frm.Cursor = Cursors.Default
        End If
    End Sub

End Module
