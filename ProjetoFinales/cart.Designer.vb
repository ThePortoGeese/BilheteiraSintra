<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cart
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
        Me.PnlCarrinho = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.btnAtQuant = New System.Windows.Forms.Button()
        Me.btnRemCompra = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnFinish = New System.Windows.Forms.Button()
        Me.LstCarrinho = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtComprarTotal = New System.Windows.Forms.TextBox()
        Me.TtpCart = New System.Windows.Forms.ToolTip(Me.components)
        Me.PnlCarrinho.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlCarrinho
        '
        Me.PnlCarrinho.BackColor = System.Drawing.Color.White
        Me.PnlCarrinho.Controls.Add(Me.PictureBox5)
        Me.PnlCarrinho.Controls.Add(Me.Label17)
        Me.PnlCarrinho.Controls.Add(Me.PictureBox4)
        Me.PnlCarrinho.Controls.Add(Me.btnAtQuant)
        Me.PnlCarrinho.Controls.Add(Me.btnRemCompra)
        Me.PnlCarrinho.Controls.Add(Me.Label7)
        Me.PnlCarrinho.Controls.Add(Me.Label6)
        Me.PnlCarrinho.Controls.Add(Me.BtnCancel)
        Me.PnlCarrinho.Controls.Add(Me.BtnFinish)
        Me.PnlCarrinho.Controls.Add(Me.LstCarrinho)
        Me.PnlCarrinho.Controls.Add(Me.Label13)
        Me.PnlCarrinho.Controls.Add(Me.Label3)
        Me.PnlCarrinho.Controls.Add(Me.TxtComprarTotal)
        Me.PnlCarrinho.Location = New System.Drawing.Point(15, 4)
        Me.PnlCarrinho.Name = "PnlCarrinho"
        Me.PnlCarrinho.Size = New System.Drawing.Size(859, 689)
        Me.PnlCarrinho.TabIndex = 11
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.VouMeSuicidar.My.Resources.Resources.imageas
        Me.PictureBox5.Location = New System.Drawing.Point(3, 5)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(37, 61)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox5.TabIndex = 33
        Me.PictureBox5.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(286, 9)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(323, 63)
        Me.Label17.TabIndex = 32
        Me.Label17.Text = "CARRINHO"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.VouMeSuicidar.My.Resources.Resources.image_removebg_preview__25_
        Me.PictureBox4.Location = New System.Drawing.Point(722, 9)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(112, 101)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 31
        Me.PictureBox4.TabStop = False
        '
        'btnAtQuant
        '
        Me.btnAtQuant.BackColor = System.Drawing.Color.Goldenrod
        Me.btnAtQuant.Enabled = False
        Me.btnAtQuant.FlatAppearance.BorderSize = 0
        Me.btnAtQuant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtQuant.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtQuant.ForeColor = System.Drawing.Color.White
        Me.btnAtQuant.Location = New System.Drawing.Point(24, 401)
        Me.btnAtQuant.Name = "btnAtQuant"
        Me.btnAtQuant.Size = New System.Drawing.Size(175, 47)
        Me.btnAtQuant.TabIndex = 30
        Me.btnAtQuant.Text = "ATUALIZAR QUANTIDADE"
        Me.TtpCart.SetToolTip(Me.btnAtQuant, "Atualiza a quantidade e o preço de um pedido, conforme a indicação do utilizador")
        Me.btnAtQuant.UseVisualStyleBackColor = False
        '
        'btnRemCompra
        '
        Me.btnRemCompra.BackColor = System.Drawing.Color.Crimson
        Me.btnRemCompra.Enabled = False
        Me.btnRemCompra.FlatAppearance.BorderSize = 0
        Me.btnRemCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemCompra.ForeColor = System.Drawing.Color.White
        Me.btnRemCompra.Location = New System.Drawing.Point(205, 401)
        Me.btnRemCompra.Name = "btnRemCompra"
        Me.btnRemCompra.Size = New System.Drawing.Size(175, 47)
        Me.btnRemCompra.TabIndex = 29
        Me.btnRemCompra.Text = "REMOVER COMPRA"
        Me.TtpCart.SetToolTip(Me.btnRemCompra, "Remove a(s) compra(s) selecionada(s)")
        Me.btnRemCompra.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 114)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(195, 17)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "BILHETES NO CARRINHO"
        Me.TtpCart.SetToolTip(Me.Label7, "Estão aqui apresentados os bilhetes previamente adicionados ao carrinho")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(825, 421)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 20)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "€"
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.Crimson
        Me.BtnCancel.FlatAppearance.BorderSize = 0
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.Location = New System.Drawing.Point(624, 484)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(220, 70)
        Me.BtnCancel.TabIndex = 4
        Me.BtnCancel.Text = "CANCELAR"
        Me.TtpCart.SetToolTip(Me.BtnCancel, "Cancela a compra e reseta o carinho ao estado original.")
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'BtnFinish
        '
        Me.BtnFinish.BackColor = System.Drawing.Color.DarkGreen
        Me.BtnFinish.FlatAppearance.BorderSize = 0
        Me.BtnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFinish.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFinish.ForeColor = System.Drawing.Color.White
        Me.BtnFinish.Location = New System.Drawing.Point(398, 484)
        Me.BtnFinish.Name = "BtnFinish"
        Me.BtnFinish.Size = New System.Drawing.Size(220, 70)
        Me.BtnFinish.TabIndex = 3
        Me.BtnFinish.Text = "FINALIZAR COMPRA"
        Me.TtpCart.SetToolTip(Me.BtnFinish, "Finaliza a compra, permitindo estes bilhetes serem consultados através das consul" &
        "tas")
        Me.BtnFinish.UseVisualStyleBackColor = False
        '
        'LstCarrinho
        '
        Me.LstCarrinho.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader6, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.LstCarrinho.FullRowSelect = True
        Me.LstCarrinho.HideSelection = False
        Me.LstCarrinho.Location = New System.Drawing.Point(24, 134)
        Me.LstCarrinho.Name = "LstCarrinho"
        Me.LstCarrinho.Size = New System.Drawing.Size(810, 260)
        Me.LstCarrinho.TabIndex = 5
        Me.LstCarrinho.UseCompatibleStateImageBehavior = False
        Me.LstCarrinho.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "QUANTIDADE"
        Me.ColumnHeader1.Width = 83
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "ÁREA"
        Me.ColumnHeader2.Width = 166
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "ATIVIDADE"
        Me.ColumnHeader3.Width = 183
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "TIPO"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "DATA E HORA"
        Me.ColumnHeader4.Width = 206
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "PREÇO"
        Me.ColumnHeader5.Width = 108
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(647, 420)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 20)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "TOTAL:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(-168, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "BILHETES NO CARRINHO"
        '
        'TxtComprarTotal
        '
        Me.TxtComprarTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtComprarTotal.Location = New System.Drawing.Point(722, 420)
        Me.TxtComprarTotal.Name = "TxtComprarTotal"
        Me.TxtComprarTotal.ReadOnly = True
        Me.TxtComprarTotal.Size = New System.Drawing.Size(101, 23)
        Me.TxtComprarTotal.TabIndex = 24
        Me.TxtComprarTotal.Text = "0"
        Me.TxtComprarTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TtpCart.SetToolTip(Me.TxtComprarTotal, "Montante total a pagar, em euros")
        '
        'TtpCart
        '
        Me.TtpCart.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.TtpCart.ToolTipTitle = "Informação"
        '
        'cart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(890, 715)
        Me.Controls.Add(Me.PnlCarrinho)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "cart"
        Me.Text = "Carrinho"
        Me.PnlCarrinho.ResumeLayout(False)
        Me.PnlCarrinho.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlCarrinho As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label17 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents btnAtQuant As Button
    Friend WithEvents btnRemCompra As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnFinish As Button
    Friend WithEvents LstCarrinho As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents Label13 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtComprarTotal As TextBox
    Friend WithEvents TtpCart As ToolTip
End Class
