<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.NumericUpDownValveMax = New System.Windows.Forms.NumericUpDown()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.NumericUpDownDelay = New System.Windows.Forms.NumericUpDown()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TrackBarValve = New System.Windows.Forms.TrackBar()
        Me.LabelValve = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LabelTankTargetPercen = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LabelTankTarget = New System.Windows.Forms.Label()
        Me.TrackBarTarget = New System.Windows.Forms.TrackBar()
        Me.NumericUpDownTankSize = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumericUpDownInflow = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.NumericUpDownOutflow = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumericUpDownOutflowError = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CsShape5 = New csShape.csShape()
        Me.CsShape4 = New csShape.csShape()
        Me.CsShape3 = New csShape.csShape()
        Me.CsShape2 = New csShape.csShape()
        Me.CsShape1 = New csShape.csShape()
        Me.bitmapButtonTank = New XLControls.LiquidContainerControl()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.PanelOscilloscope = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ButtonNumericUpDownSimulationSwitch = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.NumericUpDownSimulationDelay = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LabelD = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.LabelI = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.LabelP = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.NumericUpDownKd = New System.Windows.Forms.NumericUpDown()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.NumericUpDownKi = New System.Windows.Forms.NumericUpDown()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.NumericUpDownKp = New System.Windows.Forms.NumericUpDown()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CheckBoxPIDSwitch = New System.Windows.Forms.CheckBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Labele = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.NumericUpDownValveMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownDelay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBarValve, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBarTarget, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownTankSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownInflow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownOutflow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownOutflowError, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.NumericUpDownSimulationDelay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.NumericUpDownKd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownKi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownKp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.NumericUpDownValveMax)
        Me.Panel1.Controls.Add(Me.Label25)
        Me.Panel1.Controls.Add(Me.Label26)
        Me.Panel1.Controls.Add(Me.NumericUpDownDelay)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.TrackBarValve)
        Me.Panel1.Controls.Add(Me.LabelValve)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.LabelTankTargetPercen)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.LabelTankTarget)
        Me.Panel1.Controls.Add(Me.TrackBarTarget)
        Me.Panel1.Controls.Add(Me.NumericUpDownTankSize)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.NumericUpDownInflow)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.NumericUpDownOutflow)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.NumericUpDownOutflowError)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.CsShape5)
        Me.Panel1.Controls.Add(Me.CsShape4)
        Me.Panel1.Controls.Add(Me.CsShape3)
        Me.Panel1.Controls.Add(Me.CsShape2)
        Me.Panel1.Controls.Add(Me.CsShape1)
        Me.Panel1.Controls.Add(Me.bitmapButtonTank)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(18, 17)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(517, 477)
        Me.Panel1.TabIndex = 0
        '
        'NumericUpDownValveMax
        '
        Me.NumericUpDownValveMax.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDownValveMax.Location = New System.Drawing.Point(355, 6)
        Me.NumericUpDownValveMax.Name = "NumericUpDownValveMax"
        Me.NumericUpDownValveMax.Size = New System.Drawing.Size(64, 27)
        Me.NumericUpDownValveMax.TabIndex = 53
        Me.NumericUpDownValveMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDownValveMax.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(422, 12)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(20, 16)
        Me.Label25.TabIndex = 52
        Me.Label25.Text = "%"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(278, 12)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(71, 16)
        Me.Label26.TabIndex = 51
        Me.Label26.Text = "最大開度"
        '
        'NumericUpDownDelay
        '
        Me.NumericUpDownDelay.Increment = New Decimal(New Integer() {50, 0, 0, 0})
        Me.NumericUpDownDelay.Location = New System.Drawing.Point(355, 37)
        Me.NumericUpDownDelay.Maximum = New Decimal(New Integer() {6000, 0, 0, 0})
        Me.NumericUpDownDelay.Name = "NumericUpDownDelay"
        Me.NumericUpDownDelay.Size = New System.Drawing.Size(64, 27)
        Me.NumericUpDownDelay.TabIndex = 50
        Me.NumericUpDownDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(422, 43)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(39, 16)
        Me.Label20.TabIndex = 49
        Me.Label20.Text = "毫秒"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(313, 43)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(39, 16)
        Me.Label23.TabIndex = 48
        Me.Label23.Text = "延遲"
        '
        'TrackBarValve
        '
        Me.TrackBarValve.Location = New System.Drawing.Point(293, 100)
        Me.TrackBarValve.Maximum = 100
        Me.TrackBarValve.Name = "TrackBarValve"
        Me.TrackBarValve.Size = New System.Drawing.Size(156, 45)
        Me.TrackBarValve.TabIndex = 45
        Me.TrackBarValve.TickFrequency = 5
        Me.TrackBarValve.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.TrackBarValve.Value = 35
        '
        'LabelValve
        '
        Me.LabelValve.Location = New System.Drawing.Point(439, 112)
        Me.LabelValve.Name = "LabelValve"
        Me.LabelValve.Size = New System.Drawing.Size(56, 16)
        Me.LabelValve.TabIndex = 47
        Me.LabelValve.Text = "35%"
        Me.LabelValve.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(290, 80)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 16)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "關閉"
        '
        'LabelTankTargetPercen
        '
        Me.LabelTankTargetPercen.Location = New System.Drawing.Point(422, 363)
        Me.LabelTankTargetPercen.Name = "LabelTankTargetPercen"
        Me.LabelTankTargetPercen.Size = New System.Drawing.Size(43, 20)
        Me.LabelTankTargetPercen.TabIndex = 44
        Me.LabelTankTargetPercen.Text = "100"
        Me.LabelTankTargetPercen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(471, 365)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(23, 16)
        Me.Label15.TabIndex = 43
        Me.Label15.Text = "％"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(472, 184)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 16)
        Me.Label14.TabIndex = 42
        Me.Label14.Text = "公升"
        '
        'LabelTankTarget
        '
        Me.LabelTankTarget.Location = New System.Drawing.Point(423, 184)
        Me.LabelTankTarget.Name = "LabelTankTarget"
        Me.LabelTankTarget.Size = New System.Drawing.Size(43, 20)
        Me.LabelTankTarget.TabIndex = 40
        Me.LabelTankTarget.Text = "1000"
        Me.LabelTankTarget.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TrackBarTarget
        '
        Me.TrackBarTarget.Location = New System.Drawing.Point(420, 213)
        Me.TrackBarTarget.Maximum = 100
        Me.TrackBarTarget.Name = "TrackBarTarget"
        Me.TrackBarTarget.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackBarTarget.Size = New System.Drawing.Size(45, 150)
        Me.TrackBarTarget.TabIndex = 39
        Me.TrackBarTarget.TickFrequency = 10
        Me.TrackBarTarget.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        '
        'NumericUpDownTankSize
        '
        Me.NumericUpDownTankSize.Location = New System.Drawing.Point(68, 276)
        Me.NumericUpDownTankSize.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.NumericUpDownTankSize.Name = "NumericUpDownTankSize"
        Me.NumericUpDownTankSize.Size = New System.Drawing.Size(71, 27)
        Me.NumericUpDownTankSize.TabIndex = 38
        Me.NumericUpDownTankSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDownTankSize.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(145, 278)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 16)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "公升"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 278)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 16)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "儲存槽"
        '
        'NumericUpDownInflow
        '
        Me.NumericUpDownInflow.Location = New System.Drawing.Point(73, 173)
        Me.NumericUpDownInflow.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.NumericUpDownInflow.Name = "NumericUpDownInflow"
        Me.NumericUpDownInflow.Size = New System.Drawing.Size(71, 27)
        Me.NumericUpDownInflow.TabIndex = 34
        Me.NumericUpDownInflow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDownInflow.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(151, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 16)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "公升/秒"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 16)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "進水量"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(463, 435)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(23, 16)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "％"
        '
        'NumericUpDownOutflow
        '
        Me.NumericUpDownOutflow.Location = New System.Drawing.Point(240, 433)
        Me.NumericUpDownOutflow.Maximum = New Decimal(New Integer() {65, 0, 0, 0})
        Me.NumericUpDownOutflow.Name = "NumericUpDownOutflow"
        Me.NumericUpDownOutflow.Size = New System.Drawing.Size(71, 27)
        Me.NumericUpDownOutflow.TabIndex = 27
        Me.NumericUpDownOutflow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDownOutflow.Value = New Decimal(New Integer() {13, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(317, 435)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 16)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "公升/秒 ±"
        '
        'NumericUpDownOutflowError
        '
        Me.NumericUpDownOutflowError.Location = New System.Drawing.Point(397, 433)
        Me.NumericUpDownOutflowError.Name = "NumericUpDownOutflowError"
        Me.NumericUpDownOutflowError.Size = New System.Drawing.Size(60, 27)
        Me.NumericUpDownOutflowError.TabIndex = 28
        Me.NumericUpDownOutflowError.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDownOutflowError.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(178, 435)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 16)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "出水量"
        '
        'CsShape5
        '
        Me.CsShape5.AlternateColor = System.Drawing.Color.LightGray
        Me.CsShape5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CsShape5.CornerRadius = 0.1R
        Me.CsShape5.Direction = csShapeDir.Top
        Me.CsShape5.DrawWidth = 1
        Me.CsShape5.FillColor = System.Drawing.Color.AliceBlue
        Me.CsShape5.GradientPositions = New Single() {0!, 1.0!}
        Me.CsShape5.Gradients = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer)), System.Drawing.Color.Empty}
        Me.CsShape5.HatchFill = False
        Me.CsShape5.HatchFillStyle = System.Drawing.Drawing2D.HatchStyle.DashedHorizontal
        Me.CsShape5.LineStyle = System.Drawing.Drawing2D.DashStyle.Solid
        Me.CsShape5.Location = New System.Drawing.Point(302, 408)
        Me.CsShape5.Name = "CsShape5"
        Me.CsShape5.OutLine = True
        Me.CsShape5.OutLineColor = System.Drawing.Color.Gray
        Me.CsShape5.Shape = csShapes.Rectangle
        Me.CsShape5.ShapeGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.CsShape5.ShapeQuality = grfxQuality.HighQuality
        Me.CsShape5.ShapeShading = csShape3D.Shaded3D
        Me.CsShape5.Size = New System.Drawing.Size(209, 13)
        Me.CsShape5.TabIndex = 23
        Me.CsShape5.TransParentBG = True
        Me.CsShape5.zObject = False
        '
        'CsShape4
        '
        Me.CsShape4.AlternateColor = System.Drawing.Color.LightGray
        Me.CsShape4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CsShape4.CornerRadius = 0.1R
        Me.CsShape4.Direction = csShapeDir.Top
        Me.CsShape4.DrawWidth = 1
        Me.CsShape4.FillColor = System.Drawing.Color.AliceBlue
        Me.CsShape4.GradientPositions = New Single() {0!, 1.0!}
        Me.CsShape4.Gradients = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer)), System.Drawing.Color.Empty}
        Me.CsShape4.HatchFill = False
        Me.CsShape4.HatchFillStyle = System.Drawing.Drawing2D.HatchStyle.DashedHorizontal
        Me.CsShape4.LineStyle = System.Drawing.Drawing2D.DashStyle.Solid
        Me.CsShape4.Location = New System.Drawing.Point(302, 372)
        Me.CsShape4.Name = "CsShape4"
        Me.CsShape4.OutLine = True
        Me.CsShape4.OutLineColor = System.Drawing.Color.Gray
        Me.CsShape4.Shape = csShapes.Rectangle
        Me.CsShape4.ShapeGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.CsShape4.ShapeQuality = grfxQuality.HighQuality
        Me.CsShape4.ShapeShading = csShape3D.Shaded3D
        Me.CsShape4.Size = New System.Drawing.Size(12, 49)
        Me.CsShape4.TabIndex = 22
        Me.CsShape4.TransParentBG = True
        Me.CsShape4.zObject = False
        '
        'CsShape3
        '
        Me.CsShape3.AlternateColor = System.Drawing.Color.LightGray
        Me.CsShape3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CsShape3.CornerRadius = 0.1R
        Me.CsShape3.Direction = csShapeDir.Top
        Me.CsShape3.DrawWidth = 1
        Me.CsShape3.FillColor = System.Drawing.Color.AliceBlue
        Me.CsShape3.GradientPositions = New Single() {0!, 1.0!}
        Me.CsShape3.Gradients = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer)), System.Drawing.Color.Empty}
        Me.CsShape3.HatchFill = False
        Me.CsShape3.HatchFillStyle = System.Drawing.Drawing2D.HatchStyle.DashedHorizontal
        Me.CsShape3.LineStyle = System.Drawing.Drawing2D.DashStyle.Solid
        Me.CsShape3.Location = New System.Drawing.Point(303, 147)
        Me.CsShape3.Name = "CsShape3"
        Me.CsShape3.OutLine = True
        Me.CsShape3.OutLineColor = System.Drawing.Color.Gray
        Me.CsShape3.Shape = csShapes.Rectangle
        Me.CsShape3.ShapeGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.CsShape3.ShapeQuality = grfxQuality.HighQuality
        Me.CsShape3.ShapeShading = csShape3D.Shaded3D
        Me.CsShape3.Size = New System.Drawing.Size(12, 56)
        Me.CsShape3.TabIndex = 21
        Me.CsShape3.TransParentBG = True
        Me.CsShape3.zObject = False
        '
        'CsShape2
        '
        Me.CsShape2.AlternateColor = System.Drawing.Color.LightGray
        Me.CsShape2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CsShape2.CornerRadius = 0.1R
        Me.CsShape2.Direction = csShapeDir.Top
        Me.CsShape2.DrawWidth = 1
        Me.CsShape2.FillColor = System.Drawing.Color.AliceBlue
        Me.CsShape2.GradientPositions = New Single() {0!, 1.0!}
        Me.CsShape2.Gradients = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer)), System.Drawing.Color.Empty}
        Me.CsShape2.HatchFill = False
        Me.CsShape2.HatchFillStyle = System.Drawing.Drawing2D.HatchStyle.DashedHorizontal
        Me.CsShape2.LineStyle = System.Drawing.Drawing2D.DashStyle.Solid
        Me.CsShape2.Location = New System.Drawing.Point(225, 147)
        Me.CsShape2.Name = "CsShape2"
        Me.CsShape2.OutLine = True
        Me.CsShape2.OutLineColor = System.Drawing.Color.Gray
        Me.CsShape2.Shape = csShapes.Rectangle
        Me.CsShape2.ShapeGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.CsShape2.ShapeQuality = grfxQuality.HighQuality
        Me.CsShape2.ShapeShading = csShape3D.Shaded3D
        Me.CsShape2.Size = New System.Drawing.Size(90, 14)
        Me.CsShape2.TabIndex = 20
        Me.CsShape2.TransParentBG = True
        Me.CsShape2.zObject = False
        '
        'CsShape1
        '
        Me.CsShape1.AlternateColor = System.Drawing.Color.LightGray
        Me.CsShape1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CsShape1.CornerRadius = 0.1R
        Me.CsShape1.Direction = csShapeDir.Top
        Me.CsShape1.DrawWidth = 1
        Me.CsShape1.FillColor = System.Drawing.Color.AliceBlue
        Me.CsShape1.GradientPositions = New Single() {0!, 1.0!}
        Me.CsShape1.Gradients = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer)), System.Drawing.Color.Empty}
        Me.CsShape1.HatchFill = False
        Me.CsShape1.HatchFillStyle = System.Drawing.Drawing2D.HatchStyle.DashedHorizontal
        Me.CsShape1.LineStyle = System.Drawing.Drawing2D.DashStyle.Solid
        Me.CsShape1.Location = New System.Drawing.Point(7, 147)
        Me.CsShape1.Name = "CsShape1"
        Me.CsShape1.OutLine = True
        Me.CsShape1.OutLineColor = System.Drawing.Color.Gray
        Me.CsShape1.Shape = csShapes.Rectangle
        Me.CsShape1.ShapeGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.CsShape1.ShapeQuality = grfxQuality.HighQuality
        Me.CsShape1.ShapeShading = csShape3D.Shaded3D
        Me.CsShape1.Size = New System.Drawing.Size(177, 14)
        Me.CsShape1.TabIndex = 19
        Me.CsShape1.TransParentBG = True
        Me.CsShape1.zObject = False
        '
        'bitmapButtonTank
        '
        Me.bitmapButtonTank.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bitmapButtonTank.ConstantText = "液位"
        Me.bitmapButtonTank.CriticalLevelColor = System.Drawing.Color.Red
        Me.bitmapButtonTank.CriticalLevelColor2 = System.Drawing.Color.MistyRose
        Me.bitmapButtonTank.CriticalLevelValue = 15
        Me.bitmapButtonTank.DisplayConstantText = False
        Me.bitmapButtonTank.DisplayValueAsPercentage = False
        Me.bitmapButtonTank.DisplayValueText = False
        Me.bitmapButtonTank.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bitmapButtonTank.Image = Nothing
        Me.bitmapButtonTank.ImageFocused = Nothing
        Me.bitmapButtonTank.ImageIdle = CType(resources.GetObject("bitmapButtonTank.ImageIdle"), System.Drawing.Image)
        Me.bitmapButtonTank.ImageInactive = Nothing
        Me.bitmapButtonTank.ImageMouseOver = Nothing
        Me.bitmapButtonTank.ImagePressed = Nothing
        Me.bitmapButtonTank.InactiveColor = System.Drawing.Color.Silver
        Me.bitmapButtonTank.Location = New System.Drawing.Point(204, 202)
        Me.bitmapButtonTank.Name = "bitmapButtonTank"
        Me.bitmapButtonTank.NormalLevelColor = System.Drawing.Color.DodgerBlue
        Me.bitmapButtonTank.NormalLevelColor2 = System.Drawing.Color.LightCyan
        Me.bitmapButtonTank.OffsetPressedContent = True
        Me.bitmapButtonTank.Size = New System.Drawing.Size(208, 170)
        Me.bitmapButtonTank.StretchImage = True
        Me.bitmapButtonTank.TabIndex = 18
        Me.bitmapButtonTank.TargetValue = 50.0R
        Me.bitmapButtonTank.TextDropShadow = True
        Me.bitmapButtonTank.UseVisualStyleBackColor = False
        Me.bitmapButtonTank.Value = 50.0R
        Me.bitmapButtonTank.WarningLevelColor = System.Drawing.Color.Orange
        Me.bitmapButtonTank.WarningLevelColor2 = System.Drawing.Color.OldLace
        Me.bitmapButtonTank.WarningLevelValue = 30
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(422, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 16)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "開啟"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(246, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 16)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "開度"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(156, 80)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(82, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Timer
        '
        '
        'PanelOscilloscope
        '
        Me.PanelOscilloscope.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelOscilloscope.Location = New System.Drawing.Point(542, 17)
        Me.PanelOscilloscope.Name = "PanelOscilloscope"
        Me.PanelOscilloscope.Size = New System.Drawing.Size(394, 393)
        Me.PanelOscilloscope.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.ButtonNumericUpDownSimulationSwitch)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.NumericUpDownSimulationDelay)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Location = New System.Drawing.Point(18, 513)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(202, 123)
        Me.Panel2.TabIndex = 3
        '
        'ButtonNumericUpDownSimulationSwitch
        '
        Me.ButtonNumericUpDownSimulationSwitch.Location = New System.Drawing.Point(12, 59)
        Me.ButtonNumericUpDownSimulationSwitch.Name = "ButtonNumericUpDownSimulationSwitch"
        Me.ButtonNumericUpDownSimulationSwitch.Size = New System.Drawing.Size(176, 53)
        Me.ButtonNumericUpDownSimulationSwitch.TabIndex = 16
        Me.ButtonNumericUpDownSimulationSwitch.Text = "開始"
        Me.ButtonNumericUpDownSimulationSwitch.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(154, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 16)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "毫秒"
        '
        'NumericUpDownSimulationDelay
        '
        Me.NumericUpDownSimulationDelay.Location = New System.Drawing.Point(85, 19)
        Me.NumericUpDownSimulationDelay.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NumericUpDownSimulationDelay.Name = "NumericUpDownSimulationDelay"
        Me.NumericUpDownSimulationDelay.Size = New System.Drawing.Size(64, 27)
        Me.NumericUpDownSimulationDelay.TabIndex = 14
        Me.NumericUpDownSimulationDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDownSimulationDelay.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "掃描時間"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.LightBlue
        Me.Label13.Location = New System.Drawing.Point(31, 501)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(176, 23)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "系統參數"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.LabelD)
        Me.Panel3.Controls.Add(Me.Label24)
        Me.Panel3.Controls.Add(Me.LabelI)
        Me.Panel3.Controls.Add(Me.Label22)
        Me.Panel3.Controls.Add(Me.LabelP)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.NumericUpDownKd)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.NumericUpDownKi)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.NumericUpDownKp)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Location = New System.Drawing.Point(230, 513)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(305, 123)
        Me.Panel3.TabIndex = 17
        '
        'LabelD
        '
        Me.LabelD.BackColor = System.Drawing.Color.LightGreen
        Me.LabelD.Location = New System.Drawing.Point(197, 83)
        Me.LabelD.Name = "LabelD"
        Me.LabelD.Size = New System.Drawing.Size(87, 25)
        Me.LabelD.TabIndex = 26
        Me.LabelD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(168, 82)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(27, 26)
        Me.Label24.TabIndex = 25
        Me.Label24.Text = "D="
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelI
        '
        Me.LabelI.BackColor = System.Drawing.Color.LightGreen
        Me.LabelI.Location = New System.Drawing.Point(197, 51)
        Me.LabelI.Name = "LabelI"
        Me.LabelI.Size = New System.Drawing.Size(87, 25)
        Me.LabelI.TabIndex = 24
        Me.LabelI.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(168, 50)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(27, 26)
        Me.Label22.TabIndex = 23
        Me.Label22.Text = "I="
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelP
        '
        Me.LabelP.BackColor = System.Drawing.Color.LightGreen
        Me.LabelP.Location = New System.Drawing.Point(197, 20)
        Me.LabelP.Name = "LabelP"
        Me.LabelP.Size = New System.Drawing.Size(87, 25)
        Me.LabelP.TabIndex = 22
        Me.LabelP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(168, 19)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(27, 26)
        Me.Label19.TabIndex = 21
        Me.Label19.Text = "P="
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NumericUpDownKd
        '
        Me.NumericUpDownKd.DecimalPlaces = 3
        Me.NumericUpDownKd.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDownKd.Location = New System.Drawing.Point(36, 85)
        Me.NumericUpDownKd.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NumericUpDownKd.Minimum = New Decimal(New Integer() {100000, 0, 0, -2147483648})
        Me.NumericUpDownKd.Name = "NumericUpDownKd"
        Me.NumericUpDownKd.Size = New System.Drawing.Size(104, 27)
        Me.NumericUpDownKd.TabIndex = 20
        Me.NumericUpDownKd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDownKd.Value = New Decimal(New Integer() {3, 0, 0, 65536})
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(9, 88)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(26, 16)
        Me.Label18.TabIndex = 19
        Me.Label18.Text = "Kd"
        '
        'NumericUpDownKi
        '
        Me.NumericUpDownKi.DecimalPlaces = 3
        Me.NumericUpDownKi.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDownKi.Location = New System.Drawing.Point(36, 52)
        Me.NumericUpDownKi.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NumericUpDownKi.Minimum = New Decimal(New Integer() {100000, 0, 0, -2147483648})
        Me.NumericUpDownKi.Name = "NumericUpDownKi"
        Me.NumericUpDownKi.Size = New System.Drawing.Size(104, 27)
        Me.NumericUpDownKi.TabIndex = 18
        Me.NumericUpDownKi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDownKi.Value = New Decimal(New Integer() {6, 0, 0, 0})
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(9, 55)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(22, 16)
        Me.Label17.TabIndex = 17
        Me.Label17.Text = "Ki"
        '
        'NumericUpDownKp
        '
        Me.NumericUpDownKp.DecimalPlaces = 3
        Me.NumericUpDownKp.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDownKp.Location = New System.Drawing.Point(37, 19)
        Me.NumericUpDownKp.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NumericUpDownKp.Minimum = New Decimal(New Integer() {100000, 0, 0, -2147483648})
        Me.NumericUpDownKp.Name = "NumericUpDownKp"
        Me.NumericUpDownKp.Size = New System.Drawing.Size(104, 27)
        Me.NumericUpDownKp.TabIndex = 16
        Me.NumericUpDownKp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDownKp.Value = New Decimal(New Integer() {19, 0, 0, 0})
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(9, 21)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(26, 16)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Kp"
        '
        'CheckBoxPIDSwitch
        '
        Me.CheckBoxPIDSwitch.BackColor = System.Drawing.Color.SandyBrown
        Me.CheckBoxPIDSwitch.Location = New System.Drawing.Point(245, 502)
        Me.CheckBoxPIDSwitch.Name = "CheckBoxPIDSwitch"
        Me.CheckBoxPIDSwitch.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.CheckBoxPIDSwitch.Size = New System.Drawing.Size(270, 23)
        Me.CheckBoxPIDSwitch.TabIndex = 22
        Me.CheckBoxPIDSwitch.Text = "PID 控制參數"
        Me.CheckBoxPIDSwitch.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(549, 450)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(388, 138)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 24
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(598, 593)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(305, 44)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 25
        Me.PictureBox3.TabStop = False
        '
        'Labele
        '
        Me.Labele.BackColor = System.Drawing.Color.LightGreen
        Me.Labele.Location = New System.Drawing.Point(585, 419)
        Me.Labele.Name = "Labele"
        Me.Labele.Size = New System.Drawing.Size(87, 25)
        Me.Labele.TabIndex = 28
        Me.Labele.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(546, 418)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(43, 26)
        Me.Label21.TabIndex = 27
        Me.Label21.Text = "e(t)="
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 649)
        Me.Controls.Add(Me.Labele)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.CheckBoxPIDSwitch)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PanelOscilloscope)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PID 控制模擬器 Ver 2.0.0831 By 通霄發電廠 陳建璋"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.NumericUpDownValveMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownDelay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBarValve, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBarTarget, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownTankSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownInflow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownOutflow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownOutflowError, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.NumericUpDownSimulationDelay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.NumericUpDownKd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownKi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownKp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer As Timer
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents CsShape3 As csShape.csShape
    Friend WithEvents CsShape2 As csShape.csShape
    Friend WithEvents CsShape1 As csShape.csShape
    Private WithEvents bitmapButtonTank As XLControls.LiquidContainerControl
    Friend WithEvents CsShape5 As csShape.csShape
    Friend WithEvents CsShape4 As csShape.csShape
    Friend WithEvents NumericUpDownInflow As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents NumericUpDownOutflow As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents NumericUpDownOutflowError As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents NumericUpDownTankSize As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TrackBarTarget As TrackBar
    Friend WithEvents LabelTankTarget As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents LabelTankTargetPercen As Label
    Friend WithEvents TrackBarValve As TrackBar
    Friend WithEvents LabelValve As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents PanelOscilloscope As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ButtonNumericUpDownSimulationSwitch As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents NumericUpDownSimulationDelay As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents CheckBoxPIDSwitch As CheckBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents NumericUpDownKd As NumericUpDown
    Friend WithEvents Label18 As Label
    Friend WithEvents NumericUpDownKi As NumericUpDown
    Friend WithEvents Label17 As Label
    Friend WithEvents NumericUpDownKp As NumericUpDown
    Friend WithEvents Label16 As Label
    Friend WithEvents LabelD As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents LabelI As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents LabelP As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Labele As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents NumericUpDownDelay As NumericUpDown
    Friend WithEvents NumericUpDownValveMax As NumericUpDown
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
End Class
