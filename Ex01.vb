
Imports System.Data.SqlClient

Public Class Ex01

    Private Sub Ex01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim StgCon As New SqlConnection(strCon)
        Dim StgCmd As New SqlCommand("Select * from stagiaire", StgCon)
        Dim StgDr As SqlDataReader
        StgCon.Open()
        'a.ata = 5
        StgDr = StgCmd.ExecuteReader
        Me.ComboBox1.Items.Clear()
        Do While StgDr.Read
            Me.ComboBox1.Items.Add(StgDr("idstg"))
        Loop
        StgDr.Close()
        StgCon.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim ModCon As New SqlConnection(strCon)
        Dim ModCmd As New SqlCommand("Select libelle,Coeff,Note from Matiere inner join note on Matiere.idMat=Note.IdMat where idstg =" & CInt(Me.ComboBox1.SelectedItem), ModCon)
        Dim ModDr As SqlDataReader
        ModCon.Open()
        'Pour un ListView
        Dim ModLsv As ListViewItem
        ModDr = ModCmd.ExecuteReader
        Me.ListView1.Clear()
        Me.ListView1.View = View.Details
        Me.ListView1.Columns.Clear()
        Me.ListView1.Columns.Add("Matiere")
        Me.ListView1.Columns.Add("Coefficient")
        Me.ListView1.Columns.Add("Note")
        Do While ModDr.Read
            ModLsv = New ListViewItem()
            ModLsv.Text = ModDr("libelle").ToString
            ModLsv.SubItems.Add(ModDr("Coeff").ToString)
            ModLsv.SubItems.Add(ModDr("Note").ToString)
            Me.ListView1.Items.Add(ModLsv)
        Loop
        ModDr.Close()
        'Pour un DataGridView
        Dim i As Integer = 0
        ModDr = ModCmd.ExecuteReader
        Me.DataGridView1.Rows.Clear()
        Me.DataGridView1.Columns.Clear()
        Me.DataGridView1.Columns.Add("Matiere", "Matiere")
        Me.DataGridView1.Columns.Add("Coefficient", "Coefficient")
        Me.DataGridView1.Columns.Add("Note", "Note")
        Do While ModDr.Read
            Me.DataGridView1.Rows.Add()
            Me.DataGridView1.Item(0, i).Value = ModDr("libelle").ToString
            Me.DataGridView1.Item(1, i).Value = ModDr("Coeff").ToString
            Me.DataGridView1.Item(2, i).Value = ModDr("Note").ToString
            i += 1
        Loop
        ModDr.Close()
        ModCon.Close()
    End Sub
End Class
