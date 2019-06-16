Public Class OP
    'Apertura Horizontal
    Public Property TH As Double    'Angulo theta
    Public Property PH As Double    'Angulo Phi
    'Apertura Vertical
    Public Property TV As Double    'Angulo Theta
    Public Property PV As Double    'Angulo Phi
    Public Property TP As Double    'Angulo Theta prima
    Public Property PP As Double    'Angulo Phi prima
    'Otras variables
    Public Property Dis As Double   'Distancia para posicionar camara
    Public Property Ancho As Double 'Ancho por cálculo de la altura
    Public Property Alto As Double 'Alto por cálculo del ancho
    Public Function Deg2Rad(Deg As Double) As Double
        Dim Radians As Double
        Radians = Deg * Math.PI / 180
        Return Radians
    End Function
    Public Sub CboItems(cb As ComboBox)
        cb.Items.Add("Unitec")
        cb.Items.Add("Genius")
    End Sub
    Public Function CDAncho(vancho As Decimal, CBcam As ComboBox) As Decimal
        Select Case CBcam.Text
            Case "Unitec"
                TH = 15.0475
                PH = 74.9525
            Case "Genius"
                TH = 23.0544
                PH = 66.9456
            Case Else
                TH = 0
                PH = 0
        End Select
        Dim Temp As Decimal
        Temp = vancho / 2
        Return Math.Round(Temp * Math.Tan(Deg2Rad(PH)), 4)
    End Function
    Public Function CDAlto(valto As Decimal, vlente As Decimal, CBcam As ComboBox) As Decimal
        Select Case CBcam.Text
            Case "Unitec"
                TV = 16.399
                PV = 73.601
                TP = 6.967
                PP = 83.033
            Case "Genius"
                TV = 17.8189
                PV = 72.1811
                TP = 16.8868
                PP = 73.1132
            Case Else
                TV = 0
                PV = 0
                TP = 0
                PP = 0
        End Select
        Dim Altmax As Decimal
        Dim DisMax As Decimal
        If vlente = 0 Then
            Dis = Math.Round(valto * Math.Tan(Deg2Rad(PV)), 4)
        Else
            DisMax = Math.Round(vlente * Math.Tan(Deg2Rad(PP)), 4)
            Dim temp As Decimal
            temp = Math.Round(DisMax * Math.Tan(Deg2Rad(TV)), 4)
            Altmax = Math.Round(vlente + temp, 4)
            If Altmax = valto Then
                Dis = DisMax
            ElseIf Altmax < valto Then
                Dis = Math.Round((valto * DisMax) / Altmax, 4)
            Else
                Dim Disrel As Decimal
                Dim AltT As Decimal
                Dim AltRel As Decimal
                Disrel = Math.Round((valto * DisMax) / Altmax, 4)
                AltT = Math.Round(Disrel * Math.Tan(Deg2Rad(TV)) + vlente, 4)
                AltRel = Math.Round(Math.Abs(valto - AltT), 4)
                Dis = (valto + AltRel) * Math.Tan(Deg2Rad(TV))
            End If
        End If
        Return Math.Round(Dis, 4)
    End Function

    Public Function CDdistAlt(Dist As Decimal, vlente As Decimal, CBcam As ComboBox) As Decimal
        Select Case CBcam.Text
            Case "Unitec"
                TV = 16.399
                PV = 73.601
                TP = 6.967
                PP = 83.033
            Case "Genius"
                TV = 17.8189
                PV = 72.1811
                TP = 16.8868
                PP = 73.1132
            Case Else
                TV = 0
                PV = 0
                TP = 0
                PP = 0
        End Select
        Dim DisMax As Decimal
        If vlente = 0 Then
            Alto = Math.Round(Dist * Math.Tan(Deg2Rad(TV)), 4)
        Else
            DisMax = Math.Round(vlente * Math.Tan(Deg2Rad(PP)), 4)
            If Dist <= DisMax Then
                Alto = Math.Round(Dist * Math.Tan(Deg2Rad(TV)) + vlente, 4)
            Else
                Alto = Math.Round((Dist * Math.Tan(Deg2Rad(TV))) + (Dist * Math.Tan(Deg2Rad(TP))), 4)
            End If
        End If
        Return Math.Round(Alto, 4)
    End Function
    Public Function CDdistAn(Dist As Decimal, CBcam As ComboBox) As Decimal
        Select Case CBcam.Text
            Case "Unitec"
                TH = 15.0475
                PH = 74.9525
            Case "Genius"
                TH = 23.0544
                PH = 66.9456
            Case Else
                TH = 0
                PH = 0
        End Select
        Ancho = Math.Round(Dist * Math.Tan(Deg2Rad(TH)), 4)
        Return Math.Round(Ancho * 2, 4)
    End Function
End Class
