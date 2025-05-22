Public Class consultarID
    'SE HOUVER BILHETES COMPRADOS, MOSTRAREI A LSTBOX E A LSTVIEW E IREI TIRAR A OUTRA MENSAGEM
    Public Sub consultarID_Load(sender As Object, e As EventArgs) Handles Me.Load
        If (FrmMenu.bilhetesComprados IsNot Nothing) Then
            lblID.Visible = 1
            LblNenhuma.Visible = 0
            lstboxIDs.Visible = 1
            lblClick.Visible = 1
            lstBilhetesComprados.Visible = 1
        End If
    End Sub
    'QUANDO O INDEX DOS IDS MUDA, IREI ADICIONAR À LISTVIEW TODOS OS ITEMS COM ID CORRESPONDENTE
    Private Sub lstboxIDs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstboxIDs.SelectedIndexChanged
        If (lstboxIDs.SelectedIndex <> -1) Then
            lstBilhetesComprados.Items.Clear()
            lstBilhetesComprados.Visible = 1
            For i = 0 To FrmMenu.bilhetesComprados.Count - 1
                If (FrmMenu.bilhetesComprados(i).ID = lstboxIDs.SelectedItem) Then
                    lstBilhetesComprados.Items.Add(FrmMenu.bilhetesComprados(i).quant)
                    lstBilhetesComprados.Items(lstBilhetesComprados.Items.Count - 1).SubItems.Add(FrmMenu.bilhetesComprados(i).area)
                    lstBilhetesComprados.Items(lstBilhetesComprados.Items.Count - 1).SubItems.Add(FrmMenu.bilhetesComprados(i).especific)
                    lstBilhetesComprados.Items(lstBilhetesComprados.Items.Count - 1).SubItems.Add(FrmMenu.bilhetesComprados(i).tipo)
                    lstBilhetesComprados.Items(lstBilhetesComprados.Items.Count - 1).SubItems.Add(FrmMenu.bilhetesComprados(i).dataEHora)
                    lstBilhetesComprados.Items(lstBilhetesComprados.Items.Count - 1).SubItems.Add(FrmMenu.bilhetesComprados(i).preco)
                End If
            Next
        Else
            lstBilhetesComprados.Visible = 1
        End If
    End Sub
    'AO FECHAR, PARA EVITAR PERDA DE DADOS, DOU HIDE DO PROGRAMA EM VEZ DE CLOSE
    Private Sub consulta_Close(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        Me.Hide()
        lstboxIDs.ClearSelected()
        lstBilhetesComprados.Items.Clear()
    End Sub

End Class