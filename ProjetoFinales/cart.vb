Public Class cart
    'VER SE ESTÃO SELECIONADOS MAIS QUE UM , UM OU 0 ITEMS PARA OS BOTÕES CORRESPONDENTES
    '(SÓ SE PODE ATUALIZAR A QUANTIDADE DE UMA LINHA)
    Private Sub LstCarrinho_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstCarrinho.SelectedIndexChanged
        If (LstCarrinho.SelectedItems.Count > 0) Then
            btnRemCompra.Enabled = 1
            If (LstCarrinho.SelectedItems.Count < 2) Then
                btnAtQuant.Enabled = 1
            Else
                btnAtQuant.Enabled = 0
            End If
        Else
            btnAtQuant.Enabled = 0
            btnRemCompra.Enabled = 0
        End If
    End Sub
    'REMOVER A COMPRA DA LSTVIEW
    Private Sub btnRemCompra_Click(sender As Object, e As EventArgs) Handles btnRemCompra.Click
        While (LstCarrinho.SelectedItems.Count > 0)
            TxtComprarTotal.Text = Val(TxtComprarTotal.Text) - Val(LstCarrinho.Items(LstCarrinho.SelectedIndices(0)).SubItems(5).Text)
            LstCarrinho.Items.RemoveAt(LstCarrinho.SelectedIndices(0))
        End While
    End Sub
    'ABRIR O FORM DE ATUALIZAR COMPRA E POR LÁ OS DADOS
    Private Sub btnAtQuant_Click(sender As Object, e As EventArgs) Handles btnAtQuant.Click
        Dim I As Integer = LstCarrinho.SelectedIndices(0)
        AtQuat.TxtArea.Text = LstCarrinho.Items(I).SubItems(1).Text
        AtQuat.TxtAtividade.Text = LstCarrinho.Items(I).SubItems(2).Text
        AtQuat.txtTipo.Text = LstCarrinho.Items(I).SubItems(3).Text
        AtQuat.NupQuant.Value = LstCarrinho.Items(I).SubItems(0).Text
        AtQuat.lbl4.Text = I
        AtQuat.Show()
    End Sub
    'BOTÃO CANCELAR, FECHA E RESTA O FORMS
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        If (LstCarrinho.Items.Count = 0) Then
            MsgBox("Não têm items no carrinho, este botão não terá efeito.", vbOKOnly + vbInformation, "Ajuda")
        Else
            Me.Hide()
            LstCarrinho.Items.Clear()
            TxtComprarTotal.Text = 0
        End If
    End Sub
    'ADICIONA BILHETES AO VETOR DE ESTRUTURA CASO HAJA ITEMS NO CARRINHO AO FINALIZAR COMPRAS
    Private Sub BtnFinish_Click(sender As Object, e As EventArgs) Handles BtnFinish.Click
        If (LstCarrinho.Items.Count < 1) Then
            MsgBox("Não há itens no carrinho", vbOK, "ERRO")
        Else
            Dim startIndex As Integer
            If (FrmMenu.bilhetesComprados Is Nothing) Then
                startIndex = 0
            Else
                startIndex = FrmMenu.bilhetesComprados.Count
            End If
            ReDim Preserve FrmMenu.bilhetesComprados(startIndex + (LstCarrinho.Items.Count) - 1)
            FrmMenu.nCompras += 1
            For i = 0 To LstCarrinho.Items.Count - 1
                FrmMenu.bilhetesComprados(startIndex + i).quant = Val(LstCarrinho.Items(i).SubItems(0).Text)
                FrmMenu.bilhetesComprados(startIndex + i).area = LstCarrinho.Items(i).SubItems(1).Text
                FrmMenu.bilhetesComprados(startIndex + i).especific = LstCarrinho.Items(i).SubItems(2).Text
                FrmMenu.bilhetesComprados(startIndex + i).tipo = LstCarrinho.Items(i).SubItems(3).Text
                FrmMenu.bilhetesComprados(startIndex + i).dataEHora = Convert.ToDateTime(LstCarrinho.Items(i).SubItems(4).Text)
                FrmMenu.bilhetesComprados(startIndex + i).preco = LstCarrinho.Items(i).SubItems(5).Text
                FrmMenu.bilhetesComprados(startIndex + i).ID = "ZY0-Z" + Convert.ToString(FrmMenu.nCompras)
            Next

            TxtComprarTotal.Text = 0
            LstCarrinho.Items.Clear()
            btnAtQuant.Enabled = 0
            btnRemCompra.Enabled = 0
            MsgBox("Compra efetuada com sucesso!" + vbNewLine + "ID de referência: " + "ZY0-Z" + Convert.ToString(FrmMenu.nCompras), vbInformation + vbOKOnly, "Sucesso!")
            'RESETAR AS CONSULTAS (IRÁ VERIFICAR DE NOVO SE HÁ OU NÃO BILHETES COMPRADOS)
            consultarID.consultarID_Load("", e)
            consultaSubArea.consultaSubArea_Load("", e)
            consultaProxima.consultaProxima_Load("", e)
            consultarID.lstboxIDs.Items.Add("ZY0-Z" + Convert.ToString(FrmMenu.nCompras))
        End If
    End Sub
    'CANCELAR O "FECHAR" PARA NÃO HAVER PERDA DE DADOS
    Private Sub cart_Close(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        Me.Hide()
    End Sub

End Class