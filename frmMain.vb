Imports AWG
Public Class frmMain
    Dim Data As New List(Of Single)()
    Dim P As Integer
    Dim Box As Rectangle
    Dim dx As Single
    Dim dy As Single
    Dim datay As Single
    Dim OscilloscopeBuffer As Bitmap
    Dim OscilloscopeGraphics As Graphics
    Dim PID As PIDControl
    Dim DelayBuffer() As Double

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer

        '預設不延遲
        ReDim DelayBuffer(0)
        Randomize()
        PID = New PIDControl(TrackBarValve.Minimum, TrackBarValve.Maximum)
        PID.Kp = NumericUpDownKp.Value
        PID.Ki = NumericUpDownKi.Value
        PID.Kd = NumericUpDownKd.Value
        PID.dt = NumericUpDownSimulationDelay.Value / 1000.0

        TrackBarTarget.Value = 50
        For i = 0 To PanelOscilloscope.ClientRectangle.Width - 1
            Data.Add(0)
        Next i
        Box = PanelOscilloscope.ClientRectangle
        OscilloscopeBuffer = New Bitmap(Box.Width, Box.Height, Imaging.PixelFormat.Format32bppArgb)
        OscilloscopeGraphics = Graphics.FromImage(OscilloscopeBuffer)
        dx = Box.Width / 10.0
        dy = Box.Height / 10.0
        datay = Box.Height / 100.0
        ResetGraph()
    End Sub

    Private Sub NumericUpDownSimulationDelay_Scroll(sender As Object, e As ScrollEventArgs) Handles NumericUpDownSimulationDelay.Scroll
        Timer.Interval = NumericUpDownSimulationDelay.Value
        If PID IsNot Nothing Then
            PID.dt = NumericUpDownSimulationDelay.Value / 1000.0
        End If
    End Sub

    Private Sub NumericUpDownSimulationDelay_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownSimulationDelay.ValueChanged
        Timer.Interval = NumericUpDownSimulationDelay.Value
        If PID IsNot Nothing Then
            PID.dt = NumericUpDownSimulationDelay.Value / 1000.0
        End If
    End Sub

    Private Sub ButtonNumericUpDownSimulationSwitch_Click(sender As Object, e As EventArgs) Handles ButtonNumericUpDownSimulationSwitch.Click
        If ButtonNumericUpDownSimulationSwitch.Text = "開始" Then
            ButtonNumericUpDownSimulationSwitch.Text = "暫停"
            Timer.Enabled = True
        Else
            ButtonNumericUpDownSimulationSwitch.Text = "開始"
            Timer.Enabled = False
        End If
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Dim Inflow As Double
        Dim Outflow As Double
        Dim TankWater As Double
        Dim randomValue As Double
        Dim L As Integer
        Dim i As Integer

        L = DelayBuffer.Length
        'PID 處理
        If CheckBoxPIDSwitch.Checked = True Then
            '閥開度 = PID( 目標值，實際液位)
            DelayBuffer(L - 1) = PID.Calculate(TrackBarTarget.Value, bitmapButtonTank.Value)
            '實際閥開度限制
            If DelayBuffer(0) > NumericUpDownValveMax.Value Then
                TrackBarValve.Value = NumericUpDownValveMax.Value
            Else
                TrackBarValve.Value = DelayBuffer(0)
            End If
            '緩衝區移位
            If L > 1 Then
                For i = 0 To L - 2
                    DelayBuffer(i) = DelayBuffer(i + 1)
                Next i
            End If
            LabelP.Text = PID.P.ToString("0.000")
            LabelI.Text = PID.I.ToString("0.000")
            LabelD.Text = PID.D.ToString("0.000")
            Labele.Text = PID.e.ToString("0.000")
        End If
        '進水量依據模擬延遲換算當時流量
        Inflow = ((NumericUpDownInflow.Value / 1000.0) * Timer.Interval * TrackBarValve.Value) / 100.0
        '出水量依據模擬延遲換算當時流量
        randomValue = Math.Floor((NumericUpDownOutflowError.Value + 1) * Rnd())
        If Rnd() > 0.5 Then
            Outflow = ((NumericUpDownOutflow.Value * (1 + (randomValue / 100.0))) / 1000.0) * Timer.Interval
        Else
            Outflow = ((NumericUpDownOutflow.Value * (1 - (randomValue / 100.0))) / 1000.0) * Timer.Interval
        End If
        '目前儲存槽的水量
        TankWater = NumericUpDownTankSize.Value * (bitmapButtonTank.Value / 100.0)
        '變化後的水量
        TankWater = TankWater + Inflow - Outflow
        bitmapButtonTank.Value = (TankWater / NumericUpDownTankSize.Value) * 100.0
        If P > Data.Count - 1 Then
            ResetGraph()
        End If
        Data(P) = bitmapButtonTank.Value
        DrawGraph()
        P = P + 1
    End Sub



    Private Sub TrackBarTarget_Scroll(sender As Object, e As EventArgs) Handles TrackBarTarget.Scroll
        LabelTankTarget.Text = NumericUpDownTankSize.Value * TrackBarTarget.Value / 100.0
        LabelTankTargetPercen.Text = TrackBarTarget.Value
        bitmapButtonTank.TargetValue = TrackBarTarget.Value
        ResetGraph()
    End Sub

    Private Sub TrackBarTarget_ValueChanged(sender As Object, e As EventArgs) Handles TrackBarTarget.ValueChanged
        LabelTankTarget.Text = NumericUpDownTankSize.Value * TrackBarTarget.Value / 100.0
        LabelTankTargetPercen.Text = TrackBarTarget.Value
        bitmapButtonTank.TargetValue = TrackBarTarget.Value
        ResetGraph()
    End Sub

    Private Sub TrackBarValve_Scroll(sender As Object, e As EventArgs) Handles TrackBarValve.Scroll
        LabelValve.Text = TrackBarValve.Value.ToString + "%"
    End Sub

    Private Sub TrackBarValve_ValueChanged(sender As Object, e As EventArgs) Handles TrackBarValve.ValueChanged
        LabelValve.Text = TrackBarValve.Value.ToString + "%"
    End Sub
    Private Sub DrawGraph()
        Dim DrawColor As Drawing.Color
        Dim CustomBrush As Brush
        Dim PenColor As Pen

        '顯示曲線
        If P > 0 Then
            OscilloscopeGraphics.DrawLine(Pens.Blue, P - 1, datay * (100 - Data(P - 1)), P, datay * (100 - Data(P)))
            '顯示誤差值
            If CheckBoxPIDSwitch.Checked = True Then
                If PID IsNot Nothing Then
                    If PID.e < 0 Then
                        DrawColor = Color.FromArgb(255, 255, 200 - Math.Abs(PID.e * 2), 200 - Math.Abs(PID.e * 2))
                    Else
                        DrawColor = Color.FromArgb(255, 200 - Math.Abs(PID.e * 2), 255, 200 - Math.Abs(PID.e * 2))
                    End If
                    CustomBrush = New System.Drawing.SolidBrush(DrawColor)
                    PenColor = New Pen(CustomBrush)
                    OscilloscopeGraphics.DrawLine(PenColor, P, Box.Height, P, CType(Box.Height - Math.Abs(datay * PID.e / 1.25), Single))
                End If
            End If
        End If
        PanelOscilloscope.BackgroundImage = OscilloscopeBuffer
        PanelOscilloscope.Refresh()
    End Sub
    Private Sub ResetGraph()
        'Dim i As Integer
        'Dim C As Integer

        If OscilloscopeGraphics IsNot Nothing Then
            OscilloscopeGraphics.Clear(SystemColors.Control)
            ''水平刻度
            'C = 0
            'For i = 0 To Box.Width - 1
            '    '每秒顯示一刻度
            '    If (Timer.Interval * i - C) >= 5000 Then
            '        OscilloscopeGraphics.DrawLine(Pens.Gray, i, Box.Height - 18, i, Box.Height - 28)
            '        OscilloscopeGraphics.DrawString(((Timer.Interval * i) \ 1000).ToString, New Font("Arial", 12), New SolidBrush(Color.Black), i - 12, Box.Height - 18)
            '        C = ((Timer.Interval * i) \ 1000) * 1000
            '    End If
            '    OscilloscopeGraphics.DrawLine(Pens.Gray, 0, Box.Height - 18, Box.Width, Box.Height - 18)
            '    OscilloscopeGraphics.DrawString("秒", New Font("標楷體", 12), New SolidBrush(Color.Black), Box.Width - 22, Box.Height - 18)
            'Next i
            '目標值
            OscilloscopeGraphics.DrawLine(Pens.Red, 0, datay * (100 - TrackBarTarget.Value), Box.Width, datay * (100 - TrackBarTarget.Value))
            '重畫曲線
            PanelOscilloscope.BackgroundImage = OscilloscopeBuffer
            PanelOscilloscope.Refresh()
            P = 0
        End If
    End Sub

    Private Sub NumericUpDownKp_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownKp.ValueChanged
        If PID IsNot Nothing Then
            PID.Kp = NumericUpDownKp.Value
        End If
    End Sub

    Private Sub NumericUpDownKp_Scroll(sender As Object, e As ScrollEventArgs) Handles NumericUpDownKp.Scroll
        If PID IsNot Nothing Then
            PID.Kp = NumericUpDownKp.Value
        End If
    End Sub

    Private Sub NumericUpDownKi_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownKi.ValueChanged
        If PID IsNot Nothing Then
            PID.Ki = NumericUpDownKi.Value
        End If
    End Sub

    Private Sub NumericUpDownKi_Scroll(sender As Object, e As ScrollEventArgs) Handles NumericUpDownKi.Scroll
        If PID IsNot Nothing Then
            PID.Ki = NumericUpDownKi.Value
        End If
    End Sub

    Private Sub NumericUpDownKd_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownKd.ValueChanged
        If PID IsNot Nothing Then
            PID.Kd = NumericUpDownKd.Value
        End If
    End Sub

    Private Sub NumericUpDownKd_Scroll(sender As Object, e As ScrollEventArgs) Handles NumericUpDownKd.Scroll
        If PID IsNot Nothing Then
            PID.Kd = NumericUpDownKd.Value
        End If
    End Sub

    Private Sub NumericUpDownTankSize_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownTankSize.ValueChanged
        NumericUpDownInflow.Maximum = NumericUpDownTankSize.Value
        NumericUpDownOutflow.Maximum = NumericUpDownTankSize.Value
    End Sub

    Private Sub NumericUpDownTankSize_Scroll(sender As Object, e As ScrollEventArgs) Handles NumericUpDownTankSize.Scroll
        NumericUpDownInflow.Maximum = NumericUpDownTankSize.Value
        NumericUpDownOutflow.Maximum = NumericUpDownTankSize.Value
    End Sub

    Private Sub NumericUpDownDelay_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownDelay.ValueChanged
        Dim n As Integer

        Timer.Stop()
        If NumericUpDownDelay.Value >= NumericUpDownSimulationDelay.Value Then
            n = (NumericUpDownDelay.Value / NumericUpDownSimulationDelay.Value) + 1
        Else
            n = 1
        End If
        ReDim Preserve DelayBuffer(n - 1)
        Timer.Start()
    End Sub
End Class
