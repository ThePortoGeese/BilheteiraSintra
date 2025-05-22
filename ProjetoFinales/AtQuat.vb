Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class AtQuat
    'ATUALIZAR AS QUANTIDADES E OS PREÇOS ATRAVÉS DE OPERAÇÕES MATEMÁTICAS
    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles BtnConfirmar.Click

        Dim dif As Integer = NupQuant.Value - cart.LstCarrinho.Items(CInt(lbl4.Text)).SubItems(0).Text
        cart.TxtComprarTotal.Text = Convert.ToDouble(cart.TxtComprarTotal.Text) + dif * (Convert.ToDouble(cart.LstCarrinho.Items(CInt(lbl4.Text)).SubItems(5).Text) / Convert.ToDouble(cart.LstCarrinho.Items(CInt(lbl4.Text)).SubItems(0).Text))
        cart.LstCarrinho.Items(CInt(lbl4.Text)).SubItems(5).Text = Convert.ToDouble(cart.LstCarrinho.Items(CInt(lbl4.Text)).SubItems(5).Text) + dif * (Convert.ToDouble(cart.LstCarrinho.Items(CInt(lbl4.Text)).SubItems(5).Text) / Convert.ToDouble(cart.LstCarrinho.Items(CInt(lbl4.Text)).SubItems(0).Text))
        cart.LstCarrinho.Items(CInt(lbl4.Text)).SubItems(0).Text = NupQuant.Value
        If (NupQuant.Value = 0) Then
            cart.LstCarrinho.Items.RemoveAt(CInt(lbl4.Text))
        End If
        Me.Close()
    End Sub
    'BOTÃO CANCELAR
    Private Sub BtnCancel_Click_1(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class