<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class comprarBilh
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
        Me.pnlComprar = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.preco = New System.Windows.Forms.GroupBox()
        Me.txtPreco = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.nupBil = New System.Windows.Forms.NumericUpDown()
        Me.cboHora = New System.Windows.Forms.ComboBox()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.lblNPess = New System.Windows.Forms.Label()
        Me.cboTipoBil = New System.Windows.Forms.ComboBox()
        Me.lblTipBil = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblAtSel = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblHor = New System.Windows.Forms.Label()
        Me.LblDat = New System.Windows.Forms.Label()
        Me.DtpComprar = New System.Windows.Forms.DateTimePicker()
        Me.cboAtividade = New System.Windows.Forms.ComboBox()
        Me.cboArea = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TtpCompra = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlComprar.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.preco.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupBil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlComprar
        '
        Me.pnlComprar.BackColor = System.Drawing.Color.White
        Me.pnlComprar.Controls.Add(Me.PictureBox3)
        Me.pnlComprar.Controls.Add(Me.preco)
        Me.pnlComprar.Controls.Add(Me.PictureBox2)
        Me.pnlComprar.Controls.Add(Me.PictureBox1)
        Me.pnlComprar.Controls.Add(Me.nupBil)
        Me.pnlComprar.Controls.Add(Me.cboHora)
        Me.pnlComprar.Controls.Add(Me.BtnAdd)
        Me.pnlComprar.Controls.Add(Me.lblNPess)
        Me.pnlComprar.Controls.Add(Me.cboTipoBil)
        Me.pnlComprar.Controls.Add(Me.lblTipBil)
        Me.pnlComprar.Controls.Add(Me.Label11)
        Me.pnlComprar.Controls.Add(Me.lblAtSel)
        Me.pnlComprar.Controls.Add(Me.Label9)
        Me.pnlComprar.Controls.Add(Me.lblHor)
        Me.pnlComprar.Controls.Add(Me.LblDat)
        Me.pnlComprar.Controls.Add(Me.DtpComprar)
        Me.pnlComprar.Controls.Add(Me.cboAtividade)
        Me.pnlComprar.Controls.Add(Me.cboArea)
        Me.pnlComprar.Controls.Add(Me.Label4)
        Me.pnlComprar.Location = New System.Drawing.Point(-1, 1)
        Me.pnlComprar.Name = "pnlComprar"
        Me.pnlComprar.Size = New System.Drawing.Size(837, 858)
        Me.pnlComprar.TabIndex = 2
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.VouMeSuicidar.My.Resources.Resources._1200px_Sintra___Palacio_da_Pena__20332995770___cropped2_
        Me.PictureBox3.Location = New System.Drawing.Point(0, 473)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(837, 386)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 32
        Me.PictureBox3.TabStop = False
        '
        'preco
        '
        Me.preco.Controls.Add(Me.txtPreco)
        Me.preco.Location = New System.Drawing.Point(443, 266)
        Me.preco.Name = "preco"
        Me.preco.Size = New System.Drawing.Size(360, 160)
        Me.preco.TabIndex = 31
        Me.preco.TabStop = False
        Me.preco.Text = "Preçário"
        Me.preco.Visible = False
        '
        'txtPreco
        '
        Me.txtPreco.AutoSize = True
        Me.txtPreco.Location = New System.Drawing.Point(21, 20)
        Me.txtPreco.Name = "txtPreco"
        Me.txtPreco.Size = New System.Drawing.Size(0, 13)
        Me.txtPreco.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(443, 73)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(360, 185)
        Me.PictureBox2.TabIndex = 30
        Me.PictureBox2.TabStop = False
        Me.TtpCompra.SetToolTip(Me.PictureBox2, "Imagem correspondente à atividade")
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.VouMeSuicidar.My.Resources.Resources.imageas
        Me.PictureBox1.Location = New System.Drawing.Point(797, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 61)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'nupBil
        '
        Me.nupBil.BackColor = System.Drawing.Color.White
        Me.nupBil.Location = New System.Drawing.Point(28, 238)
        Me.nupBil.Name = "nupBil"
        Me.nupBil.Size = New System.Drawing.Size(208, 20)
        Me.nupBil.TabIndex = 28
        Me.TtpCompra.SetToolTip(Me.nupBil, "O número de bilhetes pretendidos")
        Me.nupBil.Visible = False
        '
        'cboHora
        '
        Me.cboHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHora.FormattingEnabled = True
        Me.cboHora.Location = New System.Drawing.Point(27, 337)
        Me.cboHora.Name = "cboHora"
        Me.cboHora.Size = New System.Drawing.Size(209, 21)
        Me.cboHora.TabIndex = 27
        Me.TtpCompra.SetToolTip(Me.cboHora, "A hora para realizar a atividade")
        Me.cboHora.Visible = False
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.DarkGreen
        Me.BtnAdd.FlatAppearance.BorderSize = 0
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.Color.White
        Me.BtnAdd.Location = New System.Drawing.Point(27, 380)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(220, 70)
        Me.BtnAdd.TabIndex = 26
        Me.BtnAdd.Text = "ADICIONAR AO CARRINHO"
        Me.TtpCompra.SetToolTip(Me.BtnAdd, "Este botão adiciona o(s) bilhete(s) com as características selecionadas ao carrin" &
        "ho")
        Me.BtnAdd.UseVisualStyleBackColor = False
        Me.BtnAdd.Visible = False
        '
        'lblNPess
        '
        Me.lblNPess.AutoSize = True
        Me.lblNPess.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNPess.Location = New System.Drawing.Point(25, 212)
        Me.lblNPess.Name = "lblNPess"
        Me.lblNPess.Size = New System.Drawing.Size(288, 17)
        Me.lblNPess.TabIndex = 22
        Me.lblNPess.Text = "SELECIONE O NÚMERO DE BILHETES"
        Me.lblNPess.Visible = False
        '
        'cboTipoBil
        '
        Me.cboTipoBil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoBil.FormattingEnabled = True
        Me.cboTipoBil.Location = New System.Drawing.Point(28, 179)
        Me.cboTipoBil.Name = "cboTipoBil"
        Me.cboTipoBil.Size = New System.Drawing.Size(389, 21)
        Me.cboTipoBil.TabIndex = 21
        Me.TtpCompra.SetToolTip(Me.cboTipoBil, "O tipo de bilhetes pretendidos")
        Me.cboTipoBil.Visible = False
        '
        'lblTipBil
        '
        Me.lblTipBil.AutoSize = True
        Me.lblTipBil.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipBil.Location = New System.Drawing.Point(25, 160)
        Me.lblTipBil.Name = "lblTipBil"
        Me.lblTipBil.Size = New System.Drawing.Size(257, 17)
        Me.lblTipBil.TabIndex = 20
        Me.lblTipBil.Text = "SELECIONE O TIPO DE BILHETES"
        Me.lblTipBil.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 222)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 13)
        Me.Label11.TabIndex = 17
        '
        'lblAtSel
        '
        Me.lblAtSel.AutoSize = True
        Me.lblAtSel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAtSel.Location = New System.Drawing.Point(25, 107)
        Me.lblAtSel.Name = "lblAtSel"
        Me.lblAtSel.Size = New System.Drawing.Size(217, 17)
        Me.lblAtSel.TabIndex = 16
        Me.lblAtSel.Text = "SELECIONE UMA ATIVIDADE"
        Me.lblAtSel.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(24, 49)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(178, 17)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "SELECIONE UMA ÁREA"
        '
        'lblHor
        '
        Me.lblHor.AutoSize = True
        Me.lblHor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHor.Location = New System.Drawing.Point(25, 317)
        Me.lblHor.Name = "lblHor"
        Me.lblHor.Size = New System.Drawing.Size(181, 17)
        Me.lblHor.TabIndex = 14
        Me.lblHor.Text = "SELECIONE UMA HORA"
        Me.lblHor.Visible = False
        '
        'LblDat
        '
        Me.LblDat.AutoSize = True
        Me.LblDat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDat.Location = New System.Drawing.Point(27, 261)
        Me.LblDat.Name = "LblDat"
        Me.LblDat.Size = New System.Drawing.Size(178, 17)
        Me.LblDat.TabIndex = 12
        Me.LblDat.Text = "SELECIONE UMA DATA"
        Me.LblDat.Visible = False
        '
        'DtpComprar
        '
        Me.DtpComprar.CalendarMonthBackground = System.Drawing.Color.Gainsboro
        Me.DtpComprar.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpComprar.Location = New System.Drawing.Point(27, 282)
        Me.DtpComprar.MaxDate = New Date(2025, 12, 31, 0, 0, 0, 0)
        Me.DtpComprar.MinDate = New Date(2024, 1, 1, 0, 0, 0, 0)
        Me.DtpComprar.Name = "DtpComprar"
        Me.DtpComprar.Size = New System.Drawing.Size(209, 20)
        Me.DtpComprar.TabIndex = 11
        Me.DtpComprar.TabStop = False
        Me.TtpCompra.SetToolTip(Me.DtpComprar, "O dia pretendido")
        Me.DtpComprar.Value = New Date(2024, 5, 30, 16, 33, 49, 0)
        Me.DtpComprar.Visible = False
        '
        'cboAtividade
        '
        Me.cboAtividade.BackColor = System.Drawing.Color.White
        Me.cboAtividade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAtividade.FormattingEnabled = True
        Me.cboAtividade.Items.AddRange(New Object() {"Parque e Palácio  Nacional da Pena", "Visita Guiada ao Palácio da Pena", "Visita Guiada ao Chalet da Condessa d'Edla", "Parque e Palácio de Monserrate", "Visita Guiada ao Parque e Palácio de Monserrate", "Castelo dos Mouros", "Visita Guiada ao Castelo dos Mouros", "Palácio Nacional de Sintra", "Visita Guiada ao Palácio Nacional de Sintra", "Palácio Nacional e Jardins de Queluz", "Visita Guiada ao Palácio Nacional e Jardins de Queluz", "Visita Guiada ao Pavilhão D. Maria I", "Escola Portuguesa de Arte Equestre", "Jardins de Queluz", "Convento dos Capuchos", "Visita Guiada ao Convento dos Capuchos", "Parque da Pena", "Farol do Cabo da Roca"})
        Me.cboAtividade.Location = New System.Drawing.Point(27, 127)
        Me.cboAtividade.Name = "cboAtividade"
        Me.cboAtividade.Size = New System.Drawing.Size(390, 21)
        Me.cboAtividade.TabIndex = 10
        Me.TtpCompra.SetToolTip(Me.cboAtividade, "A atividade pretendida")
        Me.cboAtividade.Visible = False
        '
        'cboArea
        '
        Me.cboArea.BackColor = System.Drawing.Color.White
        Me.cboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboArea.FormattingEnabled = True
        Me.cboArea.Items.AddRange(New Object() {"PARQUES E MONUMENTOS", "EXPERIÊNCIAS", "PROGRAMAÇÃO CULTURAL"})
        Me.cboArea.Location = New System.Drawing.Point(27, 73)
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Size = New System.Drawing.Size(390, 21)
        Me.cboArea.TabIndex = 9
        Me.TtpCompra.SetToolTip(Me.cboArea, "Área pretendida")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(189, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "COMPRAR BILHETES"
        '
        'TtpCompra
        '
        Me.TtpCompra.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.TtpCompra.ToolTipTitle = "Informação"
        '
        'comprarBilh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 821)
        Me.Controls.Add(Me.pnlComprar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "comprarBilh"
        Me.Text = "Comprar Bilhetes"
        Me.pnlComprar.ResumeLayout(False)
        Me.pnlComprar.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.preco.ResumeLayout(False)
        Me.preco.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupBil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlComprar As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents preco As GroupBox
    Friend WithEvents txtPreco As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents nupBil As NumericUpDown
    Friend WithEvents cboHora As ComboBox
    Friend WithEvents BtnAdd As Button
    Friend WithEvents lblNPess As Label
    Friend WithEvents cboTipoBil As ComboBox
    Friend WithEvents lblTipBil As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblAtSel As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblHor As Label
    Friend WithEvents LblDat As Label
    Friend WithEvents DtpComprar As DateTimePicker
    Friend WithEvents cboAtividade As ComboBox
    Friend WithEvents cboArea As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TtpCompra As ToolTip
End Class
