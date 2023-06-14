'2TDI -- M19 Prog Client-Serveur
'http://www.ista-ntic.net
'Année Scolaire : 2011-2012

Public Class Ex03

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        StgCon.Open()
        StgCmd.CommandText = "Select idstg,nom,moyenne from stagiaire where nom like '" & Me.TextBox1.Text.Trim.Replace("'", "''") & "%'"
        StgDr = StgCmd.ExecuteReader

        Dim StgLsv As ListViewItem
        Me.ListView1.Clear()
        Me.ListView1.View = View.Details
        Me.ListView1.Columns.Clear()
        Me.ListView1.Columns.Add("ID Stg")
        Me.ListView1.Columns.Add("Nom")
        Me.ListView1.Columns.Add("Moyenne")
        Do While StgDr.Read
            StgLsv = New ListViewItem()
            StgLsv.Text = StgDr("idstg").ToString
            StgLsv.SubItems.Add(StgDr("nom").ToString)
            StgLsv.SubItems.Add(StgDr("moyenne").ToString)
            Me.ListView1.Items.Add(StgLsv)
        Loop
        StgDr.Close()
        StgCon.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.ListView1.Clear()
    End Sub

    Private Sub Ex03_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class