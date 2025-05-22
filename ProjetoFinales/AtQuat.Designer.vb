<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AtQuat
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
        Me.TxtArea = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtAtividade = New System.Windows.Forms.TextBox()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NupQuant = New System.Windows.Forms.NumericUpDown()
        Me.BtnConfirmar = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.TtpAtQuant = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.NupQuant, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtArea
        '
        Me.TxtArea.Location = New System.Drawing.Point(220, 48)
        Me.TxtArea.Name = "TxtArea"
        Me.TxtArea.ReadOnly = True
        Me.TxtArea.Size = New System.Drawing.Size(438, 20)
        Me.TxtArea.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(340, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ATUALIZAR QUANTIDADE DO BILHETE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(152, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ÁREA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(113, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "ATIVIDADE"
        '
        'TxtAtividade
        '
        Me.TxtAtividade.Location = New System.Drawing.Point(220, 93)
        Me.TxtAtividade.Name = "TxtAtividade"
        Me.TxtAtividade.ReadOnly = True
        Me.TxtAtividade.Size = New System.Drawing.Size(438, 20)
        Me.TxtAtividade.TabIndex = 4
        '
        'txtTipo
        '
        Me.txtTipo.Location = New System.Drawing.Point(220, 144)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.ReadOnly = True
        Me.txtTipo.Size = New System.Drawing.Size(438, 20)
        Me.txtTipo.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(157, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "TIPO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(178, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "NOVA QUANTIDADE:"
        '
        'NupQuant
        '
        Me.NupQuant.Location = New System.Drawing.Point(345, 212)
        Me.NupQuant.Name = "NupQuant"
        Me.NupQuant.Size = New System.Drawing.Size(95, 20)
        Me.NupQuant.TabIndex = 8
        '
        'BtnConfirmar
        '
        Me.BtnConfirmar.BackColor = System.Drawing.Color.Goldenrod
        Me.BtnConfirmar.FlatAppearance.BorderSize = 0
        Me.BtnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfirmar.ForeColor = System.Drawing.Color.White
        Me.BtnConfirmar.Location = New System.Drawing.Point(455, 263)
        Me.BtnConfirmar.Name = "BtnConfirmar"
        Me.BtnConfirmar.Size = New System.Drawing.Size(220, 70)
        Me.BtnConfirmar.TabIndex = 9
        Me.BtnConfirmar.Text = "CONFIRMAR"
        Me.TtpAtQuant.SetToolTip(Me.BtnConfirmar, "Confirmar a nova quantidade pretendida" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Caso esta seja 0, irá ser removida do pro" &
        "grama original" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.BtnConfirmar.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.Crimson
        Me.BtnCancel.FlatAppearance.BorderSize = 0
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.Location = New System.Drawing.Point(12, 263)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(220, 70)
        Me.BtnCancel.TabIndex = 10
        Me.BtnCancel.Text = "CANCELAR"
        Me.TtpAtQuant.SetToolTip(Me.BtnCancel, "Cancela a operação e retorna ao carrinho")
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.VouMeSuicidar.My.Resources.Resources.Captura_de_ecrã_2024_05_31_214229
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 353)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(699, 142)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.VouMeSuicidar.My.Resources.Resources.image
        Me.PictureBox2.Location = New System.Drawing.Point(242, 359)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(198, 67)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Location = New System.Drawing.Point(594, 397)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(13, 13)
        Me.lbl4.TabIndex = 13
        Me.lbl4.Text = "0"
        Me.lbl4.Visible = False
        '
        'TtpAtQuant
        '
        Me.TtpAtQuant.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.TtpAtQuant.ToolTipTitle = "Informação"
        '
        'AtQuat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(687, 438)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnConfirmar)
        Me.Controls.Add(Me.NupQuant)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTipo)
        Me.Controls.Add(Me.TxtAtividade)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtArea)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AtQuat"
        Me.Text = "Atualizar Quantia"
        CType(Me.NupQuant, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtArea As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtAtividade As TextBox
    Friend WithEvents txtTipo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents NupQuant As NumericUpDown
    Friend WithEvents BtnConfirmar As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lbl4 As Label
    Friend WithEvents TtpAtQuant As ToolTip
End Class
