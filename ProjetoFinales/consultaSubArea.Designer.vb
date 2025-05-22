<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class consultaSubArea
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
        Me.cboSubArea = New System.Windows.Forms.ComboBox()
        Me.LblAtividade = New System.Windows.Forms.Label()
        Me.lstBilhetesComprados = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboArea = New System.Windows.Forms.ComboBox()
        Me.btnVerify = New System.Windows.Forms.Button()
        Me.dtpMax = New System.Windows.Forms.DateTimePicker()
        Me.dtpMin = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNotFound = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblNenhuma
        '
        Me.LblNenhuma.AutoSize = True
        Me.LblNenhuma.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNenhuma.Location = New System.Drawing.Point(67, 47)
        Me.LblNenhuma.Name = "LblNenhuma"
        Me.LblNenhuma.Size = New System.Drawing.Size(684, 26)
        Me.LblNenhuma.TabIndex = 42
        Me.LblNenhuma.Text = "NENHUMA COMPRA EFETUADA, COMPRE ALGUMA COISA!"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(236, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(345, 26)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "CONSULTAS POR ATIVIDADE"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.VouMeSuicidar.My.Resources.Resources.imageas
        Me.PictureBox5.Location = New System.Drawing.Point(8, 12)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(37, 61)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox5.TabIndex = 40
        Me.PictureBox5.TabStop = False
        '
        'cboSubArea
        '
        Me.cboSubArea.Enabled = False
        Me.cboSubArea.FormattingEnabled = True
        Me.cboSubArea.Location = New System.Drawing.Point(221, 45)
        Me.cboSubArea.Name = "cboSubArea"
        Me.cboSubArea.Size = New System.Drawing.Size(446, 21)
        Me.cboSubArea.TabIndex = 43
        Me.ToolTip1.SetToolTip(Me.cboSubArea, "A subárea a selecionar")
        '
        'LblAtividade
        '
        Me.LblAtividade.AutoSize = True
        Me.LblAtividade.Location = New System.Drawing.Point(218, 29)
        Me.LblAtividade.Name = "LblAtividade"
        Me.LblAtividade.Size = New System.Drawing.Size(126, 13)
        Me.LblAtividade.TabIndex = 44
        Me.LblAtividade.Text = "Selecione Uma Atividade"
        '
        'lstBilhetesComprados
        '
        Me.lstBilhetesComprados.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lstBilhetesComprados.HideSelection = False
        Me.lstBilhetesComprados.Location = New System.Drawing.Point(72, 275)
        Me.lstBilhetesComprados.Name = "lstBilhetesComprados"
        Me.lstBilhetesComprados.Size = New System.Drawing.Size(679, 217)
        Me.lstBilhetesComprados.TabIndex = 45
        Me.ToolTip1.SetToolTip(Me.lstBilhetesComprados, "Compras que condizem com as condições selecionadas pelo utilizador")
        Me.lstBilhetesComprados.UseCompatibleStateImageBehavior = False
        Me.lstBilhetesComprados.View = System.Windows.Forms.View.Details
        Me.lstBilhetesComprados.Visible = False
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "ID"
        Me.ColumnHeader3.Width = 86
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Quantia"
        Me.ColumnHeader1.Width = 92
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Tipo"
        Me.ColumnHeader2.Width = 133
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Data e Hora"
        Me.ColumnHeader4.Width = 260
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Preço"
        Me.ColumnHeader5.Width = 95
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cboArea)
        Me.GroupBox1.Controls.Add(Me.btnVerify)
        Me.GroupBox1.Controls.Add(Me.dtpMax)
        Me.GroupBox1.Controls.Add(Me.dtpMin)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.LblAtividade)
        Me.GroupBox1.Controls.Add(Me.cboSubArea)
        Me.GroupBox1.Location = New System.Drawing.Point(72, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(679, 183)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleção"
        Me.GroupBox1.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 13)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Selecione uma Área"
        '
        'cboArea
        '
        Me.cboArea.FormattingEnabled = True
        Me.cboArea.Items.AddRange(New Object() {"Parques E Monumentos", "Experiências", "Programação Cultural"})
        Me.cboArea.Location = New System.Drawing.Point(15, 45)
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Size = New System.Drawing.Size(200, 21)
        Me.cboArea.TabIndex = 51
        Me.ToolTip1.SetToolTip(Me.cboArea, "A área a selecionar")
        '
        'btnVerify
        '
        Me.btnVerify.BackColor = System.Drawing.Color.ForestGreen
        Me.btnVerify.FlatAppearance.BorderSize = 0
        Me.btnVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerify.ForeColor = System.Drawing.Color.White
        Me.btnVerify.Location = New System.Drawing.Point(261, 137)
        Me.btnVerify.Name = "btnVerify"
        Me.btnVerify.Size = New System.Drawing.Size(108, 40)
        Me.btnVerify.TabIndex = 50
        Me.btnVerify.Text = "VERIFICAR"
        Me.ToolTip1.SetToolTip(Me.btnVerify, "Quando selecionado uma atividade, clique para efetuar pesquisa dos bilhetes na no" &
        "ssa base de dados")
        Me.btnVerify.UseVisualStyleBackColor = False
        '
        'dtpMax
        '
        Me.dtpMax.Location = New System.Drawing.Point(467, 95)
        Me.dtpMax.Name = "dtpMax"
        Me.dtpMax.Size = New System.Drawing.Size(200, 20)
        Me.dtpMax.TabIndex = 49
        Me.ToolTip1.SetToolTip(Me.dtpMax, "A data máxima a selecionar")
        Me.dtpMax.Value = New Date(2026, 1, 1, 0, 0, 0, 0)
        '
        'dtpMin
        '
        Me.dtpMin.Location = New System.Drawing.Point(15, 95)
        Me.dtpMin.Name = "dtpMin"
        Me.dtpMin.Size = New System.Drawing.Size(200, 20)
        Me.dtpMin.TabIndex = 48
        Me.ToolTip1.SetToolTip(Me.dtpMin, "A data miníma a selecionar (Não pode ser maior que a data máxima)")
        Me.dtpMin.Value = New Date(2024, 1, 1, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(548, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 13)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Data máxima (Opcional)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Data miníma (Opcional)"
        '
        'lblNotFound
        '
        Me.lblNotFound.AutoSize = True
        Me.lblNotFound.Location = New System.Drawing.Point(75, 305)
        Me.lblNotFound.Name = "lblNotFound"
        Me.lblNotFound.Size = New System.Drawing.Size(169, 13)
        Me.lblNotFound.TabIndex = 47
        Me.lblNotFound.Text = "Não foram encontrados resultados"
        Me.lblNotFound.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.VouMeSuicidar.My.Resources.Resources.Captura_de_ecrã_2024_05_31_214229
        Me.PictureBox1.Location = New System.Drawing.Point(-9, 516)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(873, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 50
        Me.PictureBox1.TabStop = False
        '
        'consultaSubArea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(832, 585)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblNotFound)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lstBilhetesComprados)
        Me.Controls.Add(Me.LblNenhuma)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "consultaSubArea"
        Me.Text = "Consulta por Atividade"
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblNenhuma As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents cboSubArea As ComboBox
    Friend WithEvents LblAtividade As Label
    Friend WithEvents lstBilhetesComprados As ListView
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnVerify As Button
    Friend WithEvents dtpMax As DateTimePicker
    Friend WithEvents dtpMin As DateTimePicker
    Friend WithEvents lblNotFound As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cboArea As ComboBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
