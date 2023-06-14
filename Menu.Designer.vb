<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Ex01ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ex02ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ex03ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ex04ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ex05ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ex06ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ex07ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Ex01ToolStripMenuItem, Me.Ex02ToolStripMenuItem, Me.Ex03ToolStripMenuItem, Me.Ex04ToolStripMenuItem, Me.Ex05ToolStripMenuItem, Me.Ex06ToolStripMenuItem, Me.Ex07ToolStripMenuItem, Me.QuitterToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(517, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Ex01ToolStripMenuItem
        '
        Me.Ex01ToolStripMenuItem.Name = "Ex01ToolStripMenuItem"
        Me.Ex01ToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.Ex01ToolStripMenuItem.Text = "Ex01"
        '
        'Ex02ToolStripMenuItem
        '
        Me.Ex02ToolStripMenuItem.Name = "Ex02ToolStripMenuItem"
        Me.Ex02ToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.Ex02ToolStripMenuItem.Text = "Ex02"
        '
        'Ex03ToolStripMenuItem
        '
        Me.Ex03ToolStripMenuItem.Name = "Ex03ToolStripMenuItem"
        Me.Ex03ToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.Ex03ToolStripMenuItem.Text = "Ex03"
        '
        'Ex04ToolStripMenuItem
        '
        Me.Ex04ToolStripMenuItem.Name = "Ex04ToolStripMenuItem"
        Me.Ex04ToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.Ex04ToolStripMenuItem.Text = "Ex04"
        '
        'Ex05ToolStripMenuItem
        '
        Me.Ex05ToolStripMenuItem.Name = "Ex05ToolStripMenuItem"
        Me.Ex05ToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.Ex05ToolStripMenuItem.Text = "Ex05"
        '
        'Ex06ToolStripMenuItem
        '
        Me.Ex06ToolStripMenuItem.Name = "Ex06ToolStripMenuItem"
        Me.Ex06ToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.Ex06ToolStripMenuItem.Text = "Ex06"
        '
        'Ex07ToolStripMenuItem
        '
        Me.Ex07ToolStripMenuItem.Name = "Ex07ToolStripMenuItem"
        Me.Ex07ToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.Ex07ToolStripMenuItem.Text = "Ex07"
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 266)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Ex01ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Ex02ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Ex03ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Ex04ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Ex05ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Ex06ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Ex07ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
