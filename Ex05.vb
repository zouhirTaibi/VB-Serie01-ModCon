'2TDI -- M19 Prog Client-Serveur
'http://www.ista-ntic.net
'Année Scolaire : 2011-2012

Public Class Ex05

    Private Sub Ex05_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            StgCon.Open()
            StgCmd.CommandText = "Select idstg from stagiaire"
            StgDr = StgCmd.ExecuteReader
            Me.ComboBox1.Items.Clear()
            Do While StgDr.Read
                Me.ComboBox1.Items.Add(StgDr("idstg"))
            Loop
        Catch ex As Exception
            MessageBox.Show("Erreur : " & ex.Message)
        Finally
            StgDr.Close()
            If StgCon.State = ConnectionState.Open Then StgCon.Close()
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MessageBox.Show("Voullez vous supprimer ces donnée ?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Try
                StgCon.Open()
                StgCmd.CommandText = "Delete From stagiaire where idstg=" & Int("0" & Me.ComboBox1.SelectedItem)
                StgCmd.ExecuteNonQuery()
                MessageBox.Show("Les données sont bien supprimer ")
            Catch ex As Exception
                MessageBox.Show("Erreur : " & ex.Message)
            Finally
                If StgCon.State = ConnectionState.Open Then StgCon.Close()
            End Try
            Me.OnLoad(e)
        End If
    End Sub
End Class