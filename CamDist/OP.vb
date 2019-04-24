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
    Public Property DPC As Double   'Distancia para posicionar camara
    Public Function Deg2Rad(Deg As Double) As Double
        Dim Radians As Double
        Radians = Deg * Math.PI / 180
        Return Radians
    End Function
End Class
