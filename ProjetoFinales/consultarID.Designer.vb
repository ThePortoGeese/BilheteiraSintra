<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class consultarID
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
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblNenhuma = New System.Windows.Forms.Label()
        Me.lstboxIDs = New System.Windows.Forms.ListBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblClick = New System.Windows.Forms.Label()
        Me.lstBilhetesComprados = New System.Windows.Forms.ListView()
        Me.Quantidade = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.VouMeSuicidar.My.Resources.Resources.imageas
        Me.PictureBox5.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(37, 61)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox5.TabIndex = 33
        Me.PictureBox5.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(299, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 26)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "CONSULTAS POR ID"
        '
        'LblNenhuma
        '
        Me.LblNenhuma.AutoSize = True
        Me.LblNenhuma.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNenhuma.Location = New System.Drawing.Point(81, 57)
        Me.LblNenhuma.Name = "LblNenhuma"
        Me.LblNenhuma.Size = New System.Drawing.Size(684, 26)
        Me.LblNenhuma.TabIndex = 35
        Me.LblNenhuma.Text = "NENHUMA COMPRA EFETUADA, COMPRE ALGUMA COISA!"
        '
        'lstboxIDs
        '
        Me.lstboxIDs.FormattingEnabled = True
        Me.lstboxIDs.Location = New System.Drawing.Point(78, 127)
        Me.lstboxIDs.Name = "lstboxIDs"
        Me.lstboxIDs.Size = New System.Drawing.Size(115, 277)
        Me.lstboxIDs.TabIndex = 36
        Me.ToolTip1.SetToolTip(Me.lstboxIDs, "IDs de Compras já efetuadas")
        Me.lstboxIDs.Visible = False
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(78, 108)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(85, 13)
        Me.lblID.TabIndex = 37
        Me.lblID.Text = "IDs de Compras:"
        Me.lblID.Visible = False
        '
        'lblClick
        '
        Me.lblClick.AutoSize = True
        Me.lblClick.Location = New System.Drawing.Point(78, 407)
        Me.lblClick.Name = "lblClick"
        Me.lblClick.Size = New System.Drawing.Size(260, 13)
        Me.lblClick.TabIndex = 38
        Me.lblClick.Text = "Clique num ID para ver as compras associadas a este"
        Me.lblClick.Visible = False
        '
        'lstBilhetesComprados
        '
        Me.lstBilhetesComprados.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Quantidade, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lstBilhetesComprados.HideSelection = False
        Me.lstBilhetesComprados.Location = New System.Drawing.Point(192, 108)
        Me.lstBilhetesComprados.Name = "lstBilhetesComprados"
        Me.lstBilhetesComprados.Size = New System.Drawing.Size(583, 296)
        Me.lstBilhetesComprados.TabIndex = 39
        Me.ToolTip1.SetToolTip(Me.lstBilhetesComprados, "As compras associadas ao ID selecionado")
        Me.lstBilhetesComprados.UseCompatibleStateImageBehavior = False
        Me.lstBilhetesComprados.View = System.Windows.Forms.View.Details
        Me.lstBilhetesComprados.Visible = False
        '
        'Quantidade
        '
        Me.Quantidade.Text = "Quantidade"
        Me.Quantidade.Width = 85
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Área"
        Me.ColumnHeader1.Width = 95
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Atividade"
        Me.ColumnHeader2.Width = 179
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Tipo"
        Me.ColumnHeader3.Width = 68
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Data e Hora"
        Me.ColumnHeader4.Width = 104
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Preço"
        Me.ColumnHeader5.Width = 46
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.VouMeSuicidar.My.Resources.Resources.Captura_de_ecrã_2024_05_31_214229
        Me.PictureBox1.Location = New System.Drawing.Point(-3, 449)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(879, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
        '
        'consultarID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(839, 498)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lstBilhetesComprados)
        Me.Controls.Add(Me.lblClick)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lstboxIDs)
        Me.Controls.Add(Me.LblNenhuma)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "consultarID"
        Me.Text = "Consulta Por ID"
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LblNenhuma As Label
    Friend WithEvents lstboxIDs As ListBox
    Friend WithEvents lblID As Label
    Friend WithEvents lblClick As Label
    Friend WithEvents lstBilhetesComprados As ListView
    Friend WithEvents Quantidade As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
