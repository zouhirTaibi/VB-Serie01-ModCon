'2TDI -- M19 Prog Client-Serveur
'http://www.ista-ntic.net
'Année Scolaire : 2011-2012

Imports System.Data.SqlClient

Public Class Ex02

    Private Sub Ex02_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim a As Boolean = False
        StgCon.Open()
        StgCmd.CommandText = "Select top 1 idstg,nom,moyenne from stagiaire order by idstg"
        StgDr = StgCmd.ExecuteReader
        Do While StgDr.Read
            Me.TextBox1.Text = StgDr("idstg")
            Me.TextBox2.Text = StgDr("nom")
            Me.TextBox3.Text = StgDr("moyenne")
            a = True
        Loop
        If Not a Then

        End If
        StgDr.Close()
        StgCon.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        StgCon.Open()
        StgCmd.CommandText = "Select top 1 idstg,nom,moyenne from stagiaire order by idstg"
        StgDr = StgCmd.ExecuteReader
        Do While StgDr.Read
            Me.TextBox1.Text = StgDr("idstg").ToString
            Me.TextBox2.Text = StgDr("nom").ToString
            Me.TextBox3.Text = StgDr("moyenne").ToString
        Loop
        StgDr.Close()
        StgCon.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        StgCon.Open()
        StgCmd.CommandText = "Select top 1 idstg,nom,moyenne from stagiaire where idstg <" & Int("0" & Me.TextBox1.Text) & " order by idstg desc"
        StgDr = StgCmd.ExecuteReader
        Do While StgDr.Read
            Me.TextBox1.Text = StgDr("idstg").ToString
            Me.TextBox2.Text = StgDr("nom").ToString
            Me.TextBox3.Text = StgDr("moyenne").ToString
        Loop
        StgDr.Close()
        StgCon.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        StgCon.Open()
        StgCmd.CommandText = "Select top 1 idstg,nom,moyenne from stagiaire where idstg >" & Int("0" & Me.TextBox1.Text) & " order by idstg"
        StgDr = StgCmd.ExecuteReader
        Do While StgDr.Read
            Me.TextBox1.Text = StgDr("idstg").ToString
            Me.TextBox2.Text = StgDr("nom").ToString
            Me.TextBox3.Text = StgDr("moyenne").ToString
        Loop
        StgDr.Close()
        StgCon.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        StgCon.Open()
        StgCmd.CommandText = "Select top 1 idstg,nom,moyenne from stagiaire order by idstg desc"
        StgDr = StgCmd.ExecuteReader
        Do While StgDr.Read
            Me.TextBox1.Text = StgDr("idstg").ToString
            Me.TextBox2.Text = StgDr("nom").ToString
            Me.TextBox3.Text = StgDr("moyenne").ToString
        Loop
        StgDr.Close()
        StgCon.Close()
    End Sub
End Class