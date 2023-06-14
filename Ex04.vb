'2TDI -- M19 Prog Client-Serveur
'http://www.ista-ntic.net
'Année Scolaire : 2011-2012

Public Class Ex04

    Private Sub Ex04_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        StgCon.Open()
        StgCmd.CommandText = "Select idstg from stagiaire"
        StgDr = StgCmd.ExecuteReader
        Me.ComboBox1.Items.Clear()
        Do While StgDr.Read
            Me.ComboBox1.Items.Add(StgDr("idstg"))
        Loop
        StgDr.Close()
        StgCon.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            StgCon.Open()
            StgCmd.CommandText = "Select nom,moyenne from stagiaire where idstg=" & Int("0" & Me.ComboBox1.SelectedItem)
            StgDr = StgCmd.ExecuteReader
            Do While StgDr.Read
                Me.TextBox1.Text = StgDr("nom").ToString
                Me.TextBox2.Text = StgDr("moyenne").ToString
            Loop
        Catch ex As Exception
            MessageBox.Show("Erreur : " & ex.Message)
        Finally
            StgDr.Close()
            If StgCon.State = ConnectionState.Open Then StgCon.Close()
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MessageBox.Show("voullez vous modifier ce stagiaire", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes And Me.TextBox1.Text.Trim <> "" Then
            Try
                StgCon.Open()
                StgCmd.CommandText = "Update stagiaire set nom ='" & Me.TextBox1.Text.Replace("'", "''") & "' where idstg=" & Int("0" & Me.ComboBox1.SelectedItem)
                StgCmd.ExecuteNonQuery()
                MessageBox.Show("Les données sont bien enregistré ")
            Catch ex As Exception
                MessageBox.Show("Erreur : " & ex.Message)
            Finally
                If StgCon.State = ConnectionState.Open Then StgCon.Close()
            End Try
        End If
    End Sub
End Class