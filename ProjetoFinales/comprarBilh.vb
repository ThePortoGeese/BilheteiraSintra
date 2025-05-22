Public Class comprarBilh
    'DEFINIR OS LIMITES DO CALENDÁRIO
    Private Sub comprarBilh_Load(sender As Object, e As EventArgs) Handles Me.Load
        DtpComprar.MaxDate = FrmMenu.dataMax
        DtpComprar.MinDate = Now
    End Sub
    'AO MUDAR O INDEX DA COMBOBOX, IREI ADICIONAR OS ITEMS CORRESPONDENTES À COMBOBOX DE ATIVIDADE E MOSTRÁ-LA
    Private Sub cboArea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboArea.SelectedIndexChanged
        cboAtividade.SelectedIndex = -1
        cboAtividade.Items.Clear()
        cboTipoBil.SelectedIndex = -1
        Select Case cboArea.SelectedIndex
            Case 0
                For i = 0 To FrmMenu.par.Count - 1
                    cboAtividade.Items.Add(FrmMenu.par(i).nome)
                Next
                cboAtividade.Visible = 1
                lblAtSel.Visible = 1
            Case 1

                For i = 0 To FrmMenu.exp.Count - 1
                    cboAtividade.Items.Add(FrmMenu.exp(i).nome)
                Next
                cboAtividade.Visible = 1
                lblAtSel.Visible = 1
            Case 2
                For i = 0 To FrmMenu.prog.Count - 1
                    cboAtividade.Items.Add(FrmMenu.prog(i).nome)
                Next
                cboAtividade.Visible = 1
                lblAtSel.Visible = 1
            Case Else
                cboAtividade.Visible = 0
                lblAtSel.Visible = 0
        End Select

    End Sub
    'AO SELECIONAR A ATIVIDADE, IREI ADICIONAR AS HORAS CORRESPONDENTES, O TIPO DE BILHETE E FAZER UMA STRING QUE CONTÉM O PREÇÁRIO PARA ATRIBUIR A UMA LABEL
    'TUDO ISTO ESTÁ ARMAZENADO NOS VETORES GLOBAIS QUE FIZ
    Private Sub cboAtividade_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAtividade.SelectedIndexChanged
        If (cboAtividade.SelectedIndex <> -1) Then
            cboTipoBil.SelectedIndex = -1
            cboTipoBil.Items.Clear()
            cboHora.SelectedIndex = -1
            cboHora.Items.Clear()
            txtPreco.Text = ""
            Dim precoStr As String = ""
            Select Case cboArea.SelectedIndex
                Case 0 'CASO EM QUE É PARQUES E MONUMENTOS
                    PictureBox2.Image = FrmMenu.par(cboAtividade.SelectedIndex).image
                    For i = 0 To FrmMenu.par(cboAtividade.SelectedIndex).horas.Count - 1
                        cboHora.Items.Add(FrmMenu.par(cboAtividade.SelectedIndex).horas(i))
                    Next
                    For i = 0 To FrmMenu.par(cboAtividade.SelectedIndex).tipo.Count - 1
                        cboTipoBil.Items.Add(FrmMenu.par(cboAtividade.SelectedIndex).tipo(i))
                        precoStr = precoStr + FrmMenu.par(cboAtividade.SelectedIndex).tipo(i) + " : " + Convert.ToString(FrmMenu.par(cboAtividade.SelectedIndex).precos(i)) + "€" + vbNewLine + vbNewLine
                    Next
                Case 1 'CASO EM QUE É EXPERIÊNCIAS
                    For i = 0 To FrmMenu.exp(cboAtividade.SelectedIndex).horas.Count - 1
                        cboHora.Items.Add(FrmMenu.exp(cboAtividade.SelectedIndex).horas(i))
                    Next
                    For i = 0 To FrmMenu.exp(cboAtividade.SelectedIndex).tipo.Count - 1
                        cboTipoBil.Items.Add(FrmMenu.exp(cboAtividade.SelectedIndex).tipo(i))
                        precoStr = precoStr + FrmMenu.exp(cboAtividade.SelectedIndex).tipo(i) + " : " + Convert.ToString(FrmMenu.exp(cboAtividade.SelectedIndex).precos(i)) + "€" + vbNewLine + vbNewLine
                    Next
                    PictureBox2.Image = FrmMenu.exp(cboAtividade.SelectedIndex).image
                Case 2  'CASO EM QUE É PROGRAMAÇÃO CULTURAL
                    For i = 0 To FrmMenu.prog(cboAtividade.SelectedIndex).horas.Count - 1
                        cboHora.Items.Add(FrmMenu.prog(cboAtividade.SelectedIndex).horas(i))
                    Next
                    For i = 0 To FrmMenu.prog(cboAtividade.SelectedIndex).tipo.Count - 1
                        cboTipoBil.Items.Add(FrmMenu.prog(cboAtividade.SelectedIndex).tipo(i))
                        precoStr = precoStr + FrmMenu.prog(cboAtividade.SelectedIndex).tipo(i) + " : " + Convert.ToString(FrmMenu.prog(cboAtividade.SelectedIndex).precos(i)) + "€" + vbNewLine + vbNewLine
                    Next
                    PictureBox2.Image = FrmMenu.prog(cboAtividade.SelectedIndex).image
            End Select
            txtPreco.Text = precoStr
            'FAZER OUTRAS COISAS VISÍVEIS
            lblTipBil.Visible = 1
            cboTipoBil.Visible = 1
            PictureBox2.Visible = 1
            preco.Visible = 1
        Else
            'FAZER COISAS INVISÍVEIS AO TER INDEX -1
            preco.Visible = 0
            PictureBox2.Visible = 0
            lblTipBil.Visible = 0
            cboTipoBil.Visible = 0
            cboTipoBil.SelectedIndex = -1
        End If
    End Sub

    Private Sub cboTipoBil_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoBil.SelectedIndexChanged
        'MOSTRAR NUMERIC UP AND DOWN QUANDO SELECIONAR O TIPO DE BILHETES
        If (cboTipoBil.SelectedIndex <> -1) Then
            lblNPess.Visible = 1
            nupBil.Visible = 1
        Else
            nupBil.Value = 0
            lblNPess.Visible = 0
            nupBil.Visible = 0
        End If
    End Sub
    'SE O VALOR DA NUMERIC UP AND DOWN FOR MAIOR QUE 0,FAZER A HORA E DATA VISÍVEIS, SENÃO, FAZÊ-LAS INVISÍVEIS E RESETAR AS HORAS PARA NÃO HAVER PROBLEMAS
    Private Sub nupBil_ValueChanged(sender As Object, e As EventArgs) Handles nupBil.ValueChanged
        If (nupBil.Value > 0) Then
            LblDat.Visible = 1
            DtpComprar.Visible = 1
            lblHor.Visible = 1
            cboHora.Visible = 1
            cboHora.SelectedIndex = -1
            DtpComprar.Value = DtpComprar.MinDate
        Else
            cboHora.SelectedIndex = -1
            LblDat.Visible = 0
            DtpComprar.Visible = 0
            lblHor.Visible = 0
            cboHora.Visible = 0
        End If
    End Sub

    Private Sub cboHora_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboHora.SelectedIndexChanged
        'MOSTRAR BOTÃ0 DE ADICIONAR AO CARRINHO QUANDO ESTÁ TUDO SELECIONADO
        If (cboHora.SelectedIndex <> -1) Then
            BtnAdd.Visible = 1
        Else
            BtnAdd.Visible = 0
        End If
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        'VER SE A DATA É VÁLIDA
        If (DtpComprar.Value.Date + Convert.ToDateTime(cboHora.SelectedItem).TimeOfDay < Now()) Then
            MsgBox("Data Inválida.", vbOK + vbExclamation, "ERRO")
        Else
            'ADICIONAR O BILHETE À LISTVIEW DO CARRINHO
            Dim total
            Dim obj As ListViewItem
            Dim dados(5) As String
            dados(0) = nupBil.Value
            dados(1) = cboArea.SelectedItem
            dados(2) = cboAtividade.SelectedItem
            dados(3) = cboTipoBil.SelectedItem
            dados(4) = DtpComprar.Value.Date + Convert.ToDateTime(cboHora.SelectedItem).TimeOfDay
            Select Case cboArea.SelectedIndex
                Case 0
                    dados(5) = FrmMenu.par(cboAtividade.SelectedIndex).precos(cboTipoBil.SelectedIndex) * nupBil.Value
                Case 1
                    dados(5) = FrmMenu.exp(cboAtividade.SelectedIndex).precos(cboTipoBil.SelectedIndex) * nupBil.Value
                Case 2
                    dados(5) = FrmMenu.prog(cboAtividade.SelectedIndex).precos(cboTipoBil.SelectedIndex) * nupBil.Value
            End Select
            total = dados(5)

            obj = New ListViewItem(dados)
            cart.LstCarrinho.Items.Add(obj)
            If (vbNo = MsgBox("Adicionado ao carrinho com sucesso!" + vbNewLine + "Deseja continuar a fazer compras?", vbYesNo + vbInformation, "Sucesso!")) Then
                'SE NÃO PRETENDER CONTINUAR NAS COMPRAS, VAI PARA O CARRINHO
                Me.Close()
                cart.MdiParent = FrmMenu
                cart.Show()
            ElseIf (vbYes = MsgBox("Pretende resetar os dados de compra?", vbYesNo + vbInformation, "Ajuda")) Then
                'RESETA OS DADOS DE COMPRA (ISTO DESENCADEIA UMA CADEIA QUE TORNA TUDO INVISIVEL E RESETA)
                cboArea.SelectedIndex = -1
            End If
            'ADICIONO AO TOTAL DO CARRINHO
            cart.TxtComprarTotal.Text = Val(cart.TxtComprarTotal.Text) + total
        End If
    End Sub


End Class