Public Class consultaProxima
    'COMO CONSULTA, DECIDI ADICIONAR ALGO QUE PERMITE A VISUALIZAÇÃO DO TEMPO ATÉ A PRÓXIMA VISITA


    'DECLARAÇÃO DE VARIÁVEIS NECESSÁRIAS
    Dim nom As String
    Dim menorData As Date
    Dim dataACont As TimeSpan
    Dim countdownWatch As Stopwatch 'VARIÁVEL DE TIPO STOPWATCH PARA CRONOMETRAR O TEMPO PASSADO
    Public Sub consultaProxima_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'SEMPRE QUE ESTA FUNÇÃO É CHAMADA, IRÁ CALCULAR A DATA MENOR SE HOUVER BILHETES COMPRADOS

        'USAMOS A VARIÁVEL GLOBAL DE DATA MÁXIMA PREVIAMENTE DECLARADA PARA DEFINIR A DATA MÁXIMA POSSÍVEL

        menorData = FrmMenu.dataMax
        If (FrmMenu.bilhetesComprados IsNot Nothing) Then

            'MOSTRAR A INTERFACE
            lblPara.Visible = 1
            LblNenhuma.Visible = 0
            txtTime.Visible = 1
            LblRemaining.Visible = 1

            'ENCONTRAR A MENOR DATA QUE SEJA MAIOR QUE AGORA

            For i = 0 To FrmMenu.bilhetesComprados.Count - 1
                If (FrmMenu.bilhetesComprados(i).dataEHora < menorData And menorData > Now) Then
                    menorData = FrmMenu.bilhetesComprados(i).dataEHora
                    nom = FrmMenu.bilhetesComprados(i).especific
                End If
            Next

            'FAZER A DIFERENÇA ENTRE A DATA CALCULADA E AGORA

            dataACont = menorData - Now

            'ESTA DATA É FACTUAL LOGO, NÃO MUDA, POSSO SÓ ATRIBUIR AGORA

            LblTempoFactual.Text = menorData
            Label2.Text = nom
            'NO PRIMEIRO SEGUNDO, O STOPWATCH NÃO TERÁ SIDO ATIVADO LOGO
            'PARA O TEXTO NÃO SER "", ATRIBUO UM VALOR ORIGINAL
            txtTime.Text = dataACont.ToString("dd\:hh\:mm\:ss")
            'ATIVAR O TIMER E O STOPWATCH
            Timer1.Start()
            countdownWatch = Stopwatch.StartNew()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'ISTO EXECUTA A CADA SEGUNDO E CALCULA O TEMPO RESTANTE

        Dim timeRemaining = dataACont - countdownWatch.Elapsed

        'SE O TEMPO FOR NEGATIVO (ACABOU O TEMPO DO CRONÓMETRO), RESETO TUDO AO DAR "LOAD"
        If (timeRemaining.TotalMilliseconds < 0) Then
            Timer1.Stop()
            consultaProxima_Load("", e)
        End If
        'MOSTRAR O TEMPO RESTANTE
        txtTime.Text = timeRemaining.ToString("dd\:hh\:mm\:ss")

    End Sub

End Class