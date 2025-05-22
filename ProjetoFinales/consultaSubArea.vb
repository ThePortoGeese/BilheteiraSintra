Public Class consultaSubArea
    'SE HOUVER BILHETES COMPRADOS, MOSTRO A LSTVIEW E A GROUPBOX COM TODOS OS ITEMS
    Public Sub consultaSubArea_Load(sender As Object, e As EventArgs) Handles Me.Load
        If (FrmMenu.bilhetesComprados IsNot Nothing) Then
            GroupBox1.Visible = 1
            lstBilhetesComprados.Visible = 1
            LblNenhuma.Visible = 0
            dtpMax.MaxDate = FrmMenu.dataMax
            dtpMax.Value = FrmMenu.dataMax
            dtpMin.MinDate = Today
        End If
    End Sub
    'CONFORME A ÁREA, MUDO A SUBÁREA DE ACORDO COM AS VARIÁVEIS GLOBAIS
    Private Sub cboArea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboArea.SelectedIndexChanged
        cboSubArea.Items.Clear()
        If (cboArea.SelectedIndex = -1) Then
            cboSubArea.Enabled = 0
            cboSubArea.SelectedIndex = -1
        Else
            cboSubArea.Enabled = 1
            Select Case cboArea.SelectedIndex
                Case 0
                    For i = 0 To FrmMenu.par.Count - 1
                        cboSubArea.Items.Add(FrmMenu.par(i).nome)
                    Next
                Case 1
                    For i = 0 To FrmMenu.exp.Count - 1
                        cboSubArea.Items.Add(FrmMenu.exp(i).nome)
                    Next
                Case 2
                    For i = 0 To FrmMenu.prog.Count - 1
                        cboSubArea.Items.Add(FrmMenu.prog(i).nome)
                    Next
            End Select
        End If
    End Sub

    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click
        If (cboSubArea.SelectedIndex <> -1) Then
            lstBilhetesComprados.Items.Clear()
            If (dtpMax.Value = dtpMin.Value) Then
                MsgBox("As datas não podem ser iguais", vbOK, "Erro")
            ElseIf (dtpMax.Value < dtpMin.Value) Then           'VERIFICAR SE AS DATAS SÃO VÁLIDAS
                MsgBox("A data máxima não pode ser menor que a miníma", vbOK, "Erro")
            Else
                '
                lstBilhetesComprados.Visible = 1
                lstBilhetesComprados.Items.Clear()
                lblNotFound.Visible = 0
                'ADICIONAR À LISTVIEW OS BILHETES DA ATIVIDADE NO INTERVALO DE DIAS SELECIONADO
                For i = 0 To FrmMenu.bilhetesComprados.Count - 1
                    If (FrmMenu.bilhetesComprados(i).especific = cboSubArea.SelectedItem And FrmMenu.bilhetesComprados(i).dataEHora > dtpMin.Value And FrmMenu.bilhetesComprados(i).dataEHora < dtpMax.Value) Then
                        lstBilhetesComprados.Items.Add(FrmMenu.bilhetesComprados(i).ID)
                        lstBilhetesComprados.Items(lstBilhetesComprados.Items.Count - 1).SubItems.Add(FrmMenu.bilhetesComprados(i).quant)
                        lstBilhetesComprados.Items(lstBilhetesComprados.Items.Count - 1).SubItems.Add(FrmMenu.bilhetesComprados(i).tipo)
                        lstBilhetesComprados.Items(lstBilhetesComprados.Items.Count - 1).SubItems.Add(FrmMenu.bilhetesComprados(i).dataEHora)
                        lstBilhetesComprados.Items(lstBilhetesComprados.Items.Count - 1).SubItems.Add(FrmMenu.bilhetesComprados(i).preco)
                    End If
                Next
                'SE, APÓS ACABAR O LOOP, NÃO HOUVER ITEMS, APARECERÁ UMA MENSAGEM NOT FOUND
                If (lstBilhetesComprados.Items.Count < 1) Then
                    lblNotFound.Visible = 1
                End If
                'Resetar os campos de dados
                dtpMin.Value = Today
                dtpMax.Value = FrmMenu.dataMax
                cboSubArea.SelectedIndex = -1
                cboArea.SelectedIndex = -1
            End If
        Else
            MsgBox("Nenhuma atividade selecionada.", vbOK, "ERRO")
        End If
    End Sub
End Class