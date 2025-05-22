<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.COMPRARBILHETESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CARRINHOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTARBILHETESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTAPORIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTAPORSUBÁREAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PRÓXIMOBILHETEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SAIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ttp = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Orange
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.COMPRARBILHETESToolStripMenuItem, Me.CARRINHOToolStripMenuItem, Me.CONSULTARBILHETESToolStripMenuItem, Me.SAIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1444, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'COMPRARBILHETESToolStripMenuItem
        '
        Me.COMPRARBILHETESToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.COMPRARBILHETESToolStripMenuItem.Name = "COMPRARBILHETESToolStripMenuItem"
        Me.COMPRARBILHETESToolStripMenuItem.Size = New System.Drawing.Size(131, 20)
        Me.COMPRARBILHETESToolStripMenuItem.Text = "COMPRAR BILHETES "
        '
        'CARRINHOToolStripMenuItem
        '
        Me.CARRINHOToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CARRINHOToolStripMenuItem.Name = "CARRINHOToolStripMenuItem"
        Me.CARRINHOToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.CARRINHOToolStripMenuItem.Text = "CARRINHO 🛒"
        '
        'CONSULTARBILHETESToolStripMenuItem
        '
        Me.CONSULTARBILHETESToolStripMenuItem.AutoToolTip = True
        Me.CONSULTARBILHETESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CONSULTAPORIDToolStripMenuItem, Me.CONSULTAPORSUBÁREAToolStripMenuItem, Me.PRÓXIMOBILHETEToolStripMenuItem})
        Me.CONSULTARBILHETESToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CONSULTARBILHETESToolStripMenuItem.Name = "CONSULTARBILHETESToolStripMenuItem"
        Me.CONSULTARBILHETESToolStripMenuItem.Size = New System.Drawing.Size(136, 20)
        Me.CONSULTARBILHETESToolStripMenuItem.Text = "CONSULTAR BILHETES"
        '
        'CONSULTAPORIDToolStripMenuItem
        '
        Me.CONSULTAPORIDToolStripMenuItem.Name = "CONSULTAPORIDToolStripMenuItem"
        Me.CONSULTAPORIDToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.CONSULTAPORIDToolStripMenuItem.Text = "CONSULTA POR ID"
        '
        'CONSULTAPORSUBÁREAToolStripMenuItem
        '
        Me.CONSULTAPORSUBÁREAToolStripMenuItem.Name = "CONSULTAPORSUBÁREAToolStripMenuItem"
        Me.CONSULTAPORSUBÁREAToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.CONSULTAPORSUBÁREAToolStripMenuItem.Text = "CONSULTA POR ATIVIDADE"
        '
        'PRÓXIMOBILHETEToolStripMenuItem
        '
        Me.PRÓXIMOBILHETEToolStripMenuItem.Name = "PRÓXIMOBILHETEToolStripMenuItem"
        Me.PRÓXIMOBILHETEToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.PRÓXIMOBILHETEToolStripMenuItem.Text = "PRÓXIMA RESERVA"
        '
        'SAIRToolStripMenuItem
        '
        Me.SAIRToolStripMenuItem.ForeColor = System.Drawing.Color.Brown
        Me.SAIRToolStripMenuItem.Name = "SAIRToolStripMenuItem"
        Me.SAIRToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.SAIRToolStripMenuItem.Text = "SAIR"
        '
        'Ttp
        '
        Me.Ttp.IsBalloon = True
        Me.Ttp.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.Ttp.ToolTipTitle = "Informação"
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1444, 881)
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Location = New System.Drawing.Point(418, 50)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximumSize = New System.Drawing.Size(2500, 1000)
        Me.Name = "FrmMenu"
        Me.Text = "PARQUES DE SINTRA"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents COMPRARBILHETESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CONSULTARBILHETESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SAIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Ttp As ToolTip
    Friend WithEvents CARRINHOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CONSULTAPORIDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CONSULTAPORSUBÁREAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PRÓXIMOBILHETEToolStripMenuItem As ToolStripMenuItem
End Class
