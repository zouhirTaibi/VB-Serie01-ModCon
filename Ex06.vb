'2TDI -- M19 Prog Client-Serveur
'http://www.ista-ntic.net
'Année Scolaire : 2011-2012

Public Class Ex06

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.TextBox1.Text.Trim <> "" Then
            Try
                StgCon.Open()
                StgCmd.CommandText = "Insert into stagiaire (nom) values ('" & Me.TextBox1.Text.Trim.Replace("'", "''") & "')"
                StgCmd.ExecuteNonQuery()
                MessageBox.Show("Les données sont bien enregistrer ")
            Catch ex As Exception
                MessageBox.Show("Erreur : " & ex.Message)
            Finally
                If StgCon.State = ConnectionState.Open Then StgCon.Close()
            End Try
        Else
            MessageBox.Show("on peut pas ajouter un stagiaire avec nom vide !")
        End If
    End Sub
End Class