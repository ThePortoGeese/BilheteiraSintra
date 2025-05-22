
'OLÁ, BEM VINDOS AO MEU CÓDIGO
'ESTE É O CÓDIGO DO MENU PRINCIPAL, RESPONSÁVEL PELOS BOTÕES DO MENUSTRIP
'E PELAS VARIÁVEIS QUE SÃO USADAS POR TODO O PROGRAMA

Imports System.ComponentModel

Public Structure bilhetes
    Public dataEHora As Date
    Public area, especific, tipo, ID As String
    Public quant As Integer
    Public preco As Decimal
End Structure

Public Structure atividade
    Public nome As String
    Public tipo() As String
    Public horas() As String
    Public precos() As Decimal
    Public image As Image
End Structure


Public Class FrmMenu
    Dim temtD() As String = {"9:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30"}
    Dim hemhT() As String = {"13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00"}
    Dim tipoDefault() As String = {"Adulto (18-64)", "Jovem (6-17) ", "Sénior (65+) ", "Criança (<6)", "Família (2 Adultos 18-64 + 2 Jovens 6-17)"}

    Function insercaoDados(nome As String, tipo() As String, horas() As String, precos() As Decimal, image As Image) As atividade
        Dim T As atividade
        T.nome = nome
        T.tipo = tipo
        T.horas = horas
        T.precos = precos
        T.image = image
        Return T
    End Function

    Public par(17) As atividade
    Public exp(37) As atividade
    Public prog(9) As atividade

    ' INICIALIZAÇÃO DE VARIÁVEIS NECESSÁRIAS AO FUNCIONAMENTO DESTE PROGRAMA SEM RECURSO A BASE DE DADOS, VARIÁVEIS SÃO GLOBAIS AO PROGRAMA LOGO ESTÃO SITUADAS AQUI----------------------------------------------------------

    'A DATA MÁXIMA QUE SE PODE RESERVAR É DE 2 ANOS A PARTIR DE HOJE, USO ISTO NO CALENDÁRIO POR EXEMPLO

    Public dataMax = DateAdd(DateInterval.Year, 2, Today.Date + Convert.ToDateTime(#23:59#).TimeOfDay)

    Public nCompras As Integer

    'VETOR MAIS IMPORTANTE DO PROGRAMA POIS ESTE GUARDA OS DADOS DOS BILHETES COMPRADOS

    Public bilhetesComprados() As bilhetes
    '----------------------------------------------------------------------------------------------------------------------------------------------------------------
    'BOTÃO DE COMPRAR

    Private Sub COMPRARBILHETESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles COMPRARBILHETESToolStripMenuItem.Click
        comprarBilh.MdiParent = Me
        comprarBilh.Show()
    End Sub

    '----------------------------------------------------------------------------------------------------------------------------------------------------------------
    'BOTÃO DE SAIR

    Private Sub SAIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SAIRToolStripMenuItem.Click
        For i = 0 To Me.MdiChildren.Count
            Me.Close()
        Next
    End Sub

    '----------------------------------------------------------------------------------------------------------------------------------------------------------------
    'BOTÃO DE CARRINHO
    Private Sub CARRINHOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CARRINHOToolStripMenuItem.Click
        cart.MdiParent = Me
        cart.Show()
    End Sub

    '----------------------------------------------------------------------------------------------------------------------------------------------------------------
    'BOTÃO DE CONSULTAR POR ID
    Private Sub CONSULTAPORIDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONSULTAPORIDToolStripMenuItem.Click
        consultarID.MdiParent = Me
        consultarID.Show()
    End Sub
    '----------------------------------------------------------------------------------------------------------------------------------------------------------------
    'BOTÃO DE CONSULTAR POR SUB ÁREA
    Private Sub CONSULTAPORSUBÁREAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONSULTAPORSUBÁREAToolStripMenuItem.Click
        consultaSubArea.MdiParent = Me
        consultaSubArea.Show()
    End Sub

    'BOTÃO DE CONSULTAR PRÓXIMA RESERVA

    Private Sub PRÓXIMOBILHETEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PRÓXIMOBILHETEToolStripMenuItem.Click
        consultaProxima.MdiParent = Me
        consultaProxima.Show()
    End Sub

    'INICIALIZAÇÃO DE TODOS OS VETORES COM NOME DE EXPERIÊNCIAS, IMAGENS, HORAS, TIPOS DE BILHETES E PREÇOS
    '(DEMOROU MUITO A PASSAR OS DADOS PARA AQUI)
    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        prog(0) = insercaoDados("Perico Sambeat - Concerto de apresentação Jazz em Monserrate 2024", {"Participante"}, {"19:30"}, {1}, My.Resources.prog1)
        prog(1) = insercaoDados("Escola de Música Do Colégio Moderno (Ciclo Jovens Músicos)", {"Participante"}, {"17:30"}, {2.5}, My.Resources.prog2)
        prog(2) = insercaoDados("Galas de Arte Equestre", {"Plateia Norte", "Plateia Sul", "Camarote"}, {"20:30", "21:30"}, {22, 17.5, 50}, My.Resources.prog3)
        prog(3) = insercaoDados("Workshop - Arte de Marialva: o ensino Do cavalo – da criação à Alta Escola", {"Bilhete Alta Marialva"}, {"9:00"}, {100}, My.Resources.prog4)
        prog(4) = insercaoDados("Workshop - A Baixa Escola e o trabalho à guia. à mão e à vara", {"Bilhete Cavalão"}, {"9:00"}, {100}, My.Resources.prog5)
        prog(5) = insercaoDados("Workshop - Princípios básicos de biomecânica e treino do cavalo", {"Bilhete Biomecânica e treino do cavalo "}, {"9:00"}, {100}, My.Resources.drop6)
        prog(6) = insercaoDados("Workshop - Criação e seleção do cavalo Lusitano", {"Bilhete Criação do cavalo Lusitano "}, {"9:00"}, {100}, My.Resources.prog7)
        prog(7) = insercaoDados("Gentil - Símbolo da Arte Equestre Portuguesa", {"Bilhete da Arte Equestre Portuguesa "}, {"9:00"}, {100}, My.Resources.prog8)
        prog(8) = insercaoDados("No Paço Real de Sintra com Teresa Vale - Árvores. flores e até frutos: uma leitura iconográfica da ornamentação em prata Do leito de aparato Do Palácio Nacional de Sintra", {"Bilhete de Ouvinte "}, {"9:00"}, {2.5}, My.Resources.prog9)
        prog(9) = insercaoDados("Na Real Quinta de Queluz com Ana Duarte Rodrigues Deuses e deusas, nereides e tritões: como os interpretar", {"Participante (>6 anos)"}, {"19:00"}, {1}, My.Resources.prog9)
        par(0) = insercaoDados("Parque e Palácio Nacional da Pena", tipoDefault, temtD, {17, 15.3, 15.3, 0, 55.25}, My.Resources.parques1)
        par(1) = insercaoDados("Visita Guiada ao Palácio da Pena", {"Participante", "Criança (<6)"}, {"16:30"}, {34.85, 0}, My.Resources.parques2)
        par(2) = insercaoDados("Visita Guiada ao Chalet da Condessa d'Edla", tipoDefault, {"10:00"}, {12.75, 11.9, 11.9, 0, 46.75}, My.Resources.parques3)
        par(3) = insercaoDados("Parque e Palácio de Monserrate", tipoDefault, {"9:00"}, {10.2, 8.5, 8.5, 0, 28.05}, My.Resources.parques4)
        par(4) = insercaoDados("Visita Guiada ao Parque e Palácio de Monserrate", tipoDefault, {"15:00"}, {14.45, 12.75, 12.75, 0, 45.05}, My.Resources.parques5)
        par(5) = insercaoDados("Castelo dos Mouros", tipoDefault, {"9:00"}, {10.2, 8.5, 8.5, 0, 28.05}, My.Resources.parques6)
        par(6) = insercaoDados("Visita Guiada ao Castelo dos Mouros", tipoDefault, {"12:00"}, {14.45, 12.75, 12.75, 0, 45.05}, My.Resources.parques7)
        par(7) = insercaoDados("Palácio Nacional de Sintra", tipoDefault, {"9:00"}, {13, 10, 10, 0, 35}, My.Resources.parques8)
        par(8) = insercaoDados("Visita Guiada ao Palácio Nacional de Sintra", tipoDefault, {"14:30"}, {15.3, 12.75, 12.75, 0, 46.75}, My.Resources.parques9)
        par(9) = insercaoDados("Palácio Nacional e Jardins de Queluz", tipoDefault, {"9:00"}, {11.05, 8.5, 8.5, 0, 29.75}, My.Resources.parques10)
        par(10) = insercaoDados("Visita Guiada ao Palácio Nacional e Jardins de Queluz", tipoDefault, {"10:00"}, {15.35, 12.75, 12.75, 0, 46.75}, My.Resources.parques11)
        par(11) = insercaoDados("Visita Guiada ao Pavilhão D. Maria I", tipoDefault, {"12:00"}, {9.35, 8.08, 8.08, 0, 29.75}, My.Resources.parques12)
        par(12) = insercaoDados("Escola Portuguesa de Arte Equestre", tipoDefault, temtD, {7.6, 5.7, 5.7, 0, 23.75}, My.Resources.parques13)
        par(13) = insercaoDados("Jardins de Queluz", tipoDefault, {"9:00"}, {5.1, 3.83, 3.83, 0, 12.75}, My.Resources.parques14)
        par(14) = insercaoDados("Convento dos Capuchos", tipoDefault, {"9:00"}, {9.35, 7.65, 7.65, 0, 24.65}, My.Resources.parques15)
        par(15) = insercaoDados("Visita Guiada ao Convento dos Capuchos", tipoDefault, {"15:00", "20:30", "20:45", "22:00", "22:15"}, {13.6, 11.9, 11.9, 0, 41.65}, My.Resources.parques16)
        par(16) = insercaoDados("Parque da Pena", tipoDefault, {"9:00"}, {8.5, 7.65, 7.65, 0, 29.65}, My.Resources.parques17)
        par(17) = insercaoDados("Farol do Cabo da Roca", tipoDefault, {"9:00"}, {8.5, 7.65, 7.65, 0, 29.65}, My.Resources.parques18)
        exp(0) = insercaoDados("Passeios de Pónei no Parque da Pena", {"Passeio Pónei (Criança 3-12 anos)"}, {"10:00", "10:30", "11:00", "11:30", "13:00", "13:30"}, {7}, My.Resources.exp1)
        exp(1) = insercaoDados("Caça ao Tesouro em Monserrate", tipoDefault, {"15:00"}, {10, 10, 10, 0, 35.75}, My.Resources.exp2)
        exp(2) = insercaoDados("Caça ao Tesouro no Parque da Pena", tipoDefault, {"15:00"}, {10, 10, 10, 0, 35.75}, My.Resources.exp3)
        exp(3) = insercaoDados("Visita aos Bastidores Da Escola Portuguesa de Arte", tipoDefault, {"15:00"}, {13.75, 11.25, 11.25, 0, 39.75}, My.Resources.exp4)
        exp(4) = insercaoDados("A Floresta dos Frades", tipoDefault, {"15:00"}, {10, 10, 10, 0, 35.75}, My.Resources.exp5)
        exp(5) = insercaoDados("Jogos. arvores. Animais e Outros Que Tais", {"Participante"}, {"10:30"}, {8}, My.Resources.exp6)
        exp(6) = insercaoDados("O Diário da Princesa", {"Participante"}, {"10:30"}, {12}, My.Resources.exp7)
        exp(7) = insercaoDados("O Dia-a-Dia dos Animais", {"Participante"}, {"10:30"}, {8}, My.Resources.exp8)
        exp(8) = insercaoDados("À Conquista do Castelo", tipoDefault, {"10:30"}, {10, 10, 10, 0, 35.75}, My.Resources.exp9)
        exp(9) = insercaoDados("O Tesouro do Rei", tipoDefault, {"10:30"}, {10, 10, 10, 0, 35.75}, My.Resources.exp10)
        exp(10) = insercaoDados("Uma Aventura no Palácio da Pena", tipoDefault, {"18:30"}, {14, 14, 14, 0, 48.75}, My.Resources.exp11)
        exp(11) = insercaoDados("Enigmas do Palácio", {"Adulto", "Criança (3-12)", "Criança (<3)"}, {"10:00"}, {14, 12.5, 0}, My.Resources.exp12)
        exp(12) = insercaoDados("Visita guiada ao Santuário da Peninha", {"Adulto", "Sénior (65+)", "Jovem (6-17)"}, {"15:00"}, {7.5, 7.5, 0}, My.Resources.exp13)
        exp(13) = insercaoDados("Visita guiada ao Centro de Interpretação da Natureza de Monserrate", {"Adulto", "Sénior (65+)", "Jovem (12-17)"}, {"15:30"}, {10, 10, 0}, My.Resources.exp14)
        exp(14) = insercaoDados("Pão. Coentros e Bicharada", {"Adulto", "Jovem (3-17)", "Criança (<3)"}, {"10:30"}, {14, 12.5, 0}, My.Resources.exp15)
        exp(15) = insercaoDados("Jardins de Queluz: espaços e vivências da Casa Real", {"Visita Guiada Adulto", "Visita Guiada Jovem (12-17)", "Visita Guiada Sénior (<3)"}, {"10:30"}, {5, 5, 5}, My.Resources.exp16)
        exp(16) = insercaoDados("Os Ajudantes de Jardim", {"Adulto", "Jovem (4-17)"}, {"10:30"}, {8, 8}, My.Resources.exp17)
        exp(17) = insercaoDados("A Caçada", {"Bilhetes Adulto", "Bilhetes Jovem (4-17)", "Bilhetes Sénior (65+)", "Bilhetes Criança (<4)"}, {"10:30"}, {10, 10, 10, 0}, My.Resources.exp18)
        exp(18) = insercaoDados("O Outro Lado do Palácio Nacional de Sintra: das Vivências Reais aos Espaços de Serviço", tipoDefault, {"15:30"}, {10, 10, 10, 0, 35}, My.Resources.exp19)
        exp(19) = insercaoDados("Visita Guiada ao Jardim Botânico de Queluz", tipoDefault, {"10:30"}, {10, 10, 10, 0, 35}, My.Resources.exp20)
        exp(20) = insercaoDados("Sintra ao Luar", {"Adulto", "Jovem (6-17)"}, {"20:10"}, {12, 10}, My.Resources.exp21)
        exp(21) = insercaoDados("Vamos conhecer… os Anfíbios", {"Adulto", "Jovem (6-17)"}, {"19:30"}, {10, 8}, My.Resources.exp22)
        exp(22) = insercaoDados("Os produtos da colmeia: o mel. o pólen. a cera das abelhas e a própolis", {"Adulto", "Jovem (5-17)"}, {"15:00"}, {15, 13}, My.Resources.exp23)
        exp(23) = insercaoDados("Vamos conhecer os Pirilampos", {"Adulto", "Jovem (7-17)"}, {"20:45"}, {10, 8}, My.Resources.exp24)
        exp(24) = insercaoDados("Ateliê de Tintas Silvestres", {"Adulto", "Jovem (5-17)"}, {"15:00"}, {12, 12}, My.Resources.exp25)
        exp(25) = insercaoDados("Ateliê de Arte Botânica", {"Adulto", "Jovem (5-17)"}, {"15:00"}, {12, 12}, My.Resources.exp26)
        exp(26) = insercaoDados("Visita guiada à Pena – A primavera no Parque", {"Adulto", "Jovem (5-17)"}, {"15:00"}, {12, 12}, My.Resources.exp27)
        exp(27) = insercaoDados("À Noite no Convento dos Capuchos", tipoDefault, {"20:30", "20:45", "22:00", "22:15"}, {13.6, 11.9, 11.9, 0, 41.65}, My.Resources.exp28)
        exp(28) = insercaoDados("Os produtos da colmeia: o que é o mel?", {"Adulto", "Jovem (5-17)"}, {"15:00"}, {20, 15}, My.Resources.exp29)
        exp(29) = insercaoDados("Um Dia Quero Ser Apicultor", {"Adulto", "Jovem (5-17)"}, {"15:00"}, {25, 23}, My.Resources.exp30)
        exp(30) = insercaoDados("À Noite no Jardim", {"Adulto", "Jovem (6-17)"}, {"19:30"}, {12, 10}, My.Resources.exp31)
        exp(31) = insercaoDados("Workshop - Estratégias de gestão de Invasoras lenhosas", {"Adulto", "Jovem (5-17)"}, {"15:30"}, {12, 10}, My.Resources.exp32)
        exp(32) = insercaoDados("A Mata relíquia do Convento dos Capuchos", {"Adulto", "Jovem (5-17)"}, {"15:30"}, {12, 10}, My.Resources.exp33)
        exp(33) = insercaoDados("Rendez vous aux jardins - Despertar os sentidos no Jardim Romântico", {"Adulto", "Jovem (5-17)"}, {"15:30"}, {12, 10}, My.Resources.exp34)
        exp(34) = insercaoDados("Visita técnica: As Pragas dos Jardins de Queluz", {"Adulto", "Jovem (5-17)"}, {"13:30"}, {12, 10}, My.Resources.exp35)
        exp(35) = insercaoDados("Oficina de Verão - Como plantar morangos. abóboras. melões ou meloas", {"Adulto", "Jovem (5-17)"}, {"10:30"}, {15, 13}, My.Resources.exp36)
        exp(36) = insercaoDados("Visita guiada à Pena - O verão no Parque", tipoDefault, {"10:30"}, {10, 10, 10, 0, 35.75}, My.Resources.exp37)
        exp(37) = insercaoDados("Visita guiada a Monserrate - O verão no Jardim", tipoDefault, {"10:30"}, {10, 10, 10, 0, 35.75}, My.Resources.exp37)
    End Sub

End Class
