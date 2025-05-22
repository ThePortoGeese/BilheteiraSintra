<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class consultaProxima
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LblNenhuma = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LblRemaining = New System.Windows.Forms.Label()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.lblPara = New System.Windows.Forms.Label()
        Me.TtpProx = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblTempoFactual = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblNenhuma
        '
        Me.LblNenhuma.AutoSize = True
        Me.LblNenhuma.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNenhuma.Location = New System.Drawing.Point(62, 44)
        Me.LblNenhuma.Name = "LblNenhuma"
        Me.LblNenhuma.Size = New System.Drawing.Size(684, 26)
        Me.LblNenhuma.TabIndex = 45
        Me.LblNenhuma.Text = "NENHUMA COMPRA EFETUADA, COMPRE ALGUMA COISA!"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(247, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 26)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "PRÓXIMA RESERVA"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.VouMeSuicidar.My.Resources.Resources.imageas
        Me.PictureBox5.Location = New System.Drawing.Point(19, 9)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(37, 61)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox5.TabIndex = 43
        Me.PictureBox5.TabStop = False
        '
        'Timer1
        '
        '
        'LblRemaining
        '
        Me.LblRemaining.AutoSize = True
        Me.LblRemaining.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRemaining.Location = New System.Drawing.Point(326, 70)
        Me.LblRemaining.Name = "LblRemaining"
        Me.LblRemaining.Size = New System.Drawing.Size(81, 17)
        Me.LblRemaining.TabIndex = 46
        Me.LblRemaining.Text = "RESTAM: "
        Me.LblRemaining.Visible = False
        '
        'txtTime
        '
        Me.txtTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime.Location = New System.Drawing.Point(232, 90)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.ReadOnly = True
        Me.txtTime.Size = New System.Drawing.Size(280, 32)
        Me.txtTime.TabIndex = 47
        Me.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TtpProx.SetToolTip(Me.txtTime, "O tempo que falta até à próxima reserva")
        Me.txtTime.Visible = False
        '
        'lblPara
        '
        Me.lblPara.AutoSize = True
        Me.lblPara.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPara.Location = New System.Drawing.Point(229, 125)
        Me.lblPara.Name = "lblPara"
        Me.lblPara.Size = New System.Drawing.Size(280, 17)
        Me.lblPara.TabIndex = 48
        Me.lblPara.Text = "(DD:HH:MM:SS) - Para nos conhecer!"
        Me.lblPara.Visible = False
        '
        'TtpProx
        '
        Me.TtpProx.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.TtpProx.ToolTipTitle = "Informação"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.VouMeSuicidar.My.Resources.Resources.Captura_de_ecrã_2024_05_31_214229
        Me.PictureBox1.Location = New System.Drawing.Point(-9, 185)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(797, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 49
        Me.PictureBox1.TabStop = False
        '
        'LblTempoFactual
        '
        Me.LblTempoFactual.AutoSize = True
        Me.LblTempoFactual.Location = New System.Drawing.Point(229, 169)
        Me.LblTempoFactual.Name = "LblTempoFactual"
        Me.LblTempoFactual.Size = New System.Drawing.Size(0, 13)
        Me.LblTempoFactual.TabIndex = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(229, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 51
        '
        'consultaProxima
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(779, 247)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblTempoFactual)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblPara)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.LblRemaining)
        Me.Controls.Add(Me.LblNenhuma)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "consultaProxima"
        Me.Text = "Consulta da próxima reserva"
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblNenhuma As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LblRemaining As Label
    Friend WithEvents txtTime As TextBox
    Friend WithEvents lblPara As Label
    Friend WithEvents TtpProx As ToolTip
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LblTempoFactual As Label
    Friend WithEvents Label2 As Label
End Class
