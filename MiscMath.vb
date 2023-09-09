Module MiscMath
    Function GetGaussCurve(ByVal curveArrayLength As Integer) As Double()
        Dim Curve(curveArrayLength - 1) As Double

        'peak height > 0
        Dim a As Double = 1

        'peak center position
        Dim b As Double = curveArrayLength / 2 - 0.5

        'bell width > 0
        Dim c As Double = b
        For x As Integer = 0 To Curve.Length - 1
            Curve(x) = Math.Pow(a * Math.E, -(Math.Pow(x - b, 2) / (2 * Math.Pow(c, 2))))
        Next

        Return Curve
    End Function

	Function GetGaussCurveFactor(ByVal curve As Double()) As Double
		Dim CurveTotal As Double
		For i As Integer = 0 To curve.Length - 1
			CurveTotal += curve(i)
		Next
		Return CurveTotal
	End Function
End Module
