<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class VBDemo
    Inherits System.Windows.Forms.Form

    '窗体重写释放，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_Open = New System.Windows.Forms.Button
        Me.btn_Check = New System.Windows.Forms.Button
        Me.btn_Param = New System.Windows.Forms.Button
        Me.txt_Acc = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_Dec = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_P_V = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_ID = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_P = New System.Windows.Forms.TextBox
        Me.btn_P_Rel = New System.Windows.Forms.Button
        Me.btn_P_Abs = New System.Windows.Forms.Button
        Me.btn_Stop = New System.Windows.Forms.Button
        Me.btn_Halt = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.txt_Line_V = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt_Line_Dec = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txt_Line_Acc = New System.Windows.Forms.TextBox
        Me.btn_Line_ID = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.txt_ID1 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txt_ID0 = New System.Windows.Forms.TextBox
        Me.btn_Line_Param = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.txt_P1 = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txt_P0 = New System.Windows.Forms.TextBox
        Me.btn_Line_Halt = New System.Windows.Forms.Button
        Me.btn_Line_Stop = New System.Windows.Forms.Button
        Me.btn_Line_Abs = New System.Windows.Forms.Button
        Me.btn_Lien_Rel = New System.Windows.Forms.Button
        Me.chk_Pos = New System.Windows.Forms.CheckBox
        Me.chk_Neg = New System.Windows.Forms.CheckBox
        Me.chk_Run = New System.Windows.Forms.CheckBox
        Me.txt_P_Now = New System.Windows.Forms.TextBox
        Me.txt_V_Now = New System.Windows.Forms.TextBox
        Me.chk_Zero = New System.Windows.Forms.CheckBox
        Me.chk_Get = New System.Windows.Forms.CheckBox
        Me.Timer1 = New System.Windows.Forms.Timer
        Me.Button2 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btn_Open
        '
        Me.btn_Open.Location = New System.Drawing.Point(27, 14)
        Me.btn_Open.Name = "btn_Open"
        Me.btn_Open.Size = New System.Drawing.Size(127, 48)
        Me.btn_Open.TabIndex = 0
        Me.btn_Open.Text = "打开串口"
        '
        'btn_Check
        '
        Me.btn_Check.Location = New System.Drawing.Point(27, 68)
        Me.btn_Check.Name = "btn_Check"
        Me.btn_Check.Size = New System.Drawing.Size(127, 48)
        Me.btn_Check.TabIndex = 1
        Me.btn_Check.Text = "检测板卡"
        '
        'btn_Param
        '
        Me.btn_Param.Location = New System.Drawing.Point(49, 241)
        Me.btn_Param.Name = "btn_Param"
        Me.btn_Param.Size = New System.Drawing.Size(127, 48)
        Me.btn_Param.TabIndex = 2
        Me.btn_Param.Text = "参数设置"
        '
        'txt_Acc
        '
        Me.txt_Acc.Location = New System.Drawing.Point(133, 154)
        Me.txt_Acc.Name = "txt_Acc"
        Me.txt_Acc.Size = New System.Drawing.Size(100, 23)
        Me.txt_Acc.TabIndex = 3
        Me.txt_Acc.Text = "1000"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(27, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.Text = "加速度"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(27, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.Text = "减速度"
        '
        'txt_Dec
        '
        Me.txt_Dec.Location = New System.Drawing.Point(133, 183)
        Me.txt_Dec.Name = "txt_Dec"
        Me.txt_Dec.Size = New System.Drawing.Size(100, 23)
        Me.txt_Dec.TabIndex = 6
        Me.txt_Dec.Text = "1000"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(27, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.Text = "速度"
        '
        'txt_P_V
        '
        Me.txt_P_V.Location = New System.Drawing.Point(133, 212)
        Me.txt_P_V.Name = "txt_P_V"
        Me.txt_P_V.Size = New System.Drawing.Size(100, 23)
        Me.txt_P_V.TabIndex = 9
        Me.txt_P_V.Text = "2000"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(27, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 20)
        Me.Label4.Text = "轴序号"
        '
        'txt_ID
        '
        Me.txt_ID.Location = New System.Drawing.Point(133, 121)
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.Size = New System.Drawing.Size(100, 23)
        Me.txt_ID.TabIndex = 12
        Me.txt_ID.Text = "0"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(27, 315)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 20)
        Me.Label5.Text = "移动量"
        '
        'txt_P
        '
        Me.txt_P.Location = New System.Drawing.Point(133, 312)
        Me.txt_P.Name = "txt_P"
        Me.txt_P.Size = New System.Drawing.Size(100, 23)
        Me.txt_P.TabIndex = 15
        Me.txt_P.Text = "5000"
        '
        'btn_P_Rel
        '
        Me.btn_P_Rel.Location = New System.Drawing.Point(27, 341)
        Me.btn_P_Rel.Name = "btn_P_Rel"
        Me.btn_P_Rel.Size = New System.Drawing.Size(127, 48)
        Me.btn_P_Rel.TabIndex = 17
        Me.btn_P_Rel.Text = "相对方式"
        '
        'btn_P_Abs
        '
        Me.btn_P_Abs.Location = New System.Drawing.Point(27, 395)
        Me.btn_P_Abs.Name = "btn_P_Abs"
        Me.btn_P_Abs.Size = New System.Drawing.Size(127, 48)
        Me.btn_P_Abs.TabIndex = 18
        Me.btn_P_Abs.Text = "绝对方式"
        '
        'btn_Stop
        '
        Me.btn_Stop.Location = New System.Drawing.Point(182, 341)
        Me.btn_Stop.Name = "btn_Stop"
        Me.btn_Stop.Size = New System.Drawing.Size(127, 48)
        Me.btn_Stop.TabIndex = 19
        Me.btn_Stop.Text = "停止"
        '
        'btn_Halt
        '
        Me.btn_Halt.Location = New System.Drawing.Point(182, 395)
        Me.btn_Halt.Name = "btn_Halt"
        Me.btn_Halt.Size = New System.Drawing.Size(127, 48)
        Me.btn_Halt.TabIndex = 20
        Me.btn_Halt.Text = "急停"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(182, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 48)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "关闭串口"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(450, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 20)
        Me.Label6.Text = "速度"
        '
        'txt_Line_V
        '
        Me.txt_Line_V.Location = New System.Drawing.Point(556, 163)
        Me.txt_Line_V.Name = "txt_Line_V"
        Me.txt_Line_V.Size = New System.Drawing.Size(100, 23)
        Me.txt_Line_V.TabIndex = 27
        Me.txt_Line_V.Text = "2000"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(450, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 20)
        Me.Label7.Text = "减速度"
        '
        'txt_Line_Dec
        '
        Me.txt_Line_Dec.Location = New System.Drawing.Point(556, 134)
        Me.txt_Line_Dec.Name = "txt_Line_Dec"
        Me.txt_Line_Dec.Size = New System.Drawing.Size(100, 23)
        Me.txt_Line_Dec.TabIndex = 26
        Me.txt_Line_Dec.Text = "1000"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(450, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 20)
        Me.Label8.Text = "加速度"
        '
        'txt_Line_Acc
        '
        Me.txt_Line_Acc.Location = New System.Drawing.Point(556, 105)
        Me.txt_Line_Acc.Name = "txt_Line_Acc"
        Me.txt_Line_Acc.Size = New System.Drawing.Size(100, 23)
        Me.txt_Line_Acc.TabIndex = 25
        Me.txt_Line_Acc.Text = "1000"
        '
        'btn_Line_ID
        '
        Me.btn_Line_ID.Location = New System.Drawing.Point(662, 32)
        Me.btn_Line_ID.Name = "btn_Line_ID"
        Me.btn_Line_ID.Size = New System.Drawing.Size(127, 48)
        Me.btn_Line_ID.TabIndex = 35
        Me.btn_Line_ID.Text = "设置插补轴"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(450, 71)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 20)
        Me.Label9.Text = "插补轴1"
        '
        'txt_ID1
        '
        Me.txt_ID1.Location = New System.Drawing.Point(556, 68)
        Me.txt_ID1.Name = "txt_ID1"
        Me.txt_ID1.Size = New System.Drawing.Size(100, 23)
        Me.txt_ID1.TabIndex = 34
        Me.txt_ID1.Text = "6"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(450, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 20)
        Me.Label10.Text = "插补轴0"
        '
        'txt_ID0
        '
        Me.txt_ID0.Location = New System.Drawing.Point(556, 29)
        Me.txt_ID0.Name = "txt_ID0"
        Me.txt_ID0.Size = New System.Drawing.Size(100, 23)
        Me.txt_ID0.TabIndex = 33
        Me.txt_ID0.Text = "5"
        '
        'btn_Line_Param
        '
        Me.btn_Line_Param.Location = New System.Drawing.Point(495, 192)
        Me.btn_Line_Param.Name = "btn_Line_Param"
        Me.btn_Line_Param.Size = New System.Drawing.Size(127, 48)
        Me.btn_Line_Param.TabIndex = 38
        Me.btn_Line_Param.Text = "参数设置"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(477, 304)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 20)
        Me.Label11.Text = "轴1移动量"
        '
        'txt_P1
        '
        Me.txt_P1.Location = New System.Drawing.Point(583, 301)
        Me.txt_P1.Name = "txt_P1"
        Me.txt_P1.Size = New System.Drawing.Size(100, 23)
        Me.txt_P1.TabIndex = 42
        Me.txt_P1.Text = "5000"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(477, 265)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 20)
        Me.Label12.Text = "轴0移动量"
        '
        'txt_P0
        '
        Me.txt_P0.Location = New System.Drawing.Point(583, 262)
        Me.txt_P0.Name = "txt_P0"
        Me.txt_P0.Size = New System.Drawing.Size(100, 23)
        Me.txt_P0.TabIndex = 41
        Me.txt_P0.Text = "5000"
        '
        'btn_Line_Halt
        '
        Me.btn_Line_Halt.Location = New System.Drawing.Point(606, 395)
        Me.btn_Line_Halt.Name = "btn_Line_Halt"
        Me.btn_Line_Halt.Size = New System.Drawing.Size(127, 48)
        Me.btn_Line_Halt.TabIndex = 48
        Me.btn_Line_Halt.Text = "急停"
        '
        'btn_Line_Stop
        '
        Me.btn_Line_Stop.Location = New System.Drawing.Point(606, 330)
        Me.btn_Line_Stop.Name = "btn_Line_Stop"
        Me.btn_Line_Stop.Size = New System.Drawing.Size(127, 48)
        Me.btn_Line_Stop.TabIndex = 47
        Me.btn_Line_Stop.Text = "停止"
        '
        'btn_Line_Abs
        '
        Me.btn_Line_Abs.Location = New System.Drawing.Point(451, 395)
        Me.btn_Line_Abs.Name = "btn_Line_Abs"
        Me.btn_Line_Abs.Size = New System.Drawing.Size(127, 48)
        Me.btn_Line_Abs.TabIndex = 46
        Me.btn_Line_Abs.Text = "绝对方式插补"
        '
        'btn_Lien_Rel
        '
        Me.btn_Lien_Rel.Location = New System.Drawing.Point(451, 330)
        Me.btn_Lien_Rel.Name = "btn_Lien_Rel"
        Me.btn_Lien_Rel.Size = New System.Drawing.Size(127, 48)
        Me.btn_Lien_Rel.TabIndex = 45
        Me.btn_Lien_Rel.Text = "相对方式插补"
        '
        'chk_Pos
        '
        Me.chk_Pos.Location = New System.Drawing.Point(290, 138)
        Me.chk_Pos.Name = "chk_Pos"
        Me.chk_Pos.Size = New System.Drawing.Size(100, 20)
        Me.chk_Pos.TabIndex = 70
        Me.chk_Pos.Text = "正限位"
        '
        'chk_Neg
        '
        Me.chk_Neg.Location = New System.Drawing.Point(290, 112)
        Me.chk_Neg.Name = "chk_Neg"
        Me.chk_Neg.Size = New System.Drawing.Size(100, 20)
        Me.chk_Neg.TabIndex = 69
        Me.chk_Neg.Text = "负限位"
        '
        'chk_Run
        '
        Me.chk_Run.Location = New System.Drawing.Point(290, 86)
        Me.chk_Run.Name = "chk_Run"
        Me.chk_Run.Size = New System.Drawing.Size(100, 20)
        Me.chk_Run.TabIndex = 68
        Me.chk_Run.Text = "运行"
        '
        'txt_P_Now
        '
        Me.txt_P_Now.Location = New System.Drawing.Point(290, 221)
        Me.txt_P_Now.Name = "txt_P_Now"
        Me.txt_P_Now.Size = New System.Drawing.Size(100, 23)
        Me.txt_P_Now.TabIndex = 67
        Me.txt_P_Now.Text = "0"
        '
        'txt_V_Now
        '
        Me.txt_V_Now.Location = New System.Drawing.Point(290, 192)
        Me.txt_V_Now.Name = "txt_V_Now"
        Me.txt_V_Now.Size = New System.Drawing.Size(100, 23)
        Me.txt_V_Now.TabIndex = 66
        Me.txt_V_Now.Text = "0"
        '
        'chk_Zero
        '
        Me.chk_Zero.Location = New System.Drawing.Point(290, 166)
        Me.chk_Zero.Name = "chk_Zero"
        Me.chk_Zero.Size = New System.Drawing.Size(100, 20)
        Me.chk_Zero.TabIndex = 71
        Me.chk_Zero.Text = "零位"
        '
        'chk_Get
        '
        Me.chk_Get.Location = New System.Drawing.Point(290, 262)
        Me.chk_Get.Name = "chk_Get"
        Me.chk_Get.Size = New System.Drawing.Size(92, 19)
        Me.chk_Get.TabIndex = 72
        Me.chk_Get.Text = "读状态"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(319, 301)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 52)
        Me.Button2.TabIndex = 85
        Me.Button2.Text = "Button2"
        '
        'VBDemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(798, 455)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.chk_Get)
        Me.Controls.Add(Me.chk_Zero)
        Me.Controls.Add(Me.chk_Pos)
        Me.Controls.Add(Me.chk_Neg)
        Me.Controls.Add(Me.chk_Run)
        Me.Controls.Add(Me.txt_P_Now)
        Me.Controls.Add(Me.txt_V_Now)
        Me.Controls.Add(Me.btn_Line_Halt)
        Me.Controls.Add(Me.btn_Line_Stop)
        Me.Controls.Add(Me.btn_Line_Abs)
        Me.Controls.Add(Me.btn_Lien_Rel)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_P1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txt_P0)
        Me.Controls.Add(Me.btn_Line_Param)
        Me.Controls.Add(Me.btn_Line_ID)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_ID1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_ID0)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_Line_V)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_Line_Dec)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_Line_Acc)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_Halt)
        Me.Controls.Add(Me.btn_Stop)
        Me.Controls.Add(Me.btn_P_Abs)
        Me.Controls.Add(Me.btn_P_Rel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_P)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_ID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_P_V)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_Dec)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_Acc)
        Me.Controls.Add(Me.btn_Param)
        Me.Controls.Add(Me.btn_Check)
        Me.Controls.Add(Me.btn_Open)
        Me.Name = "VBDemo"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_Open As System.Windows.Forms.Button
    Friend WithEvents btn_Check As System.Windows.Forms.Button
    Friend WithEvents btn_Param As System.Windows.Forms.Button
    Friend WithEvents txt_Acc As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_Dec As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_P_V As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_P As System.Windows.Forms.TextBox
    Friend WithEvents btn_P_Rel As System.Windows.Forms.Button
    Friend WithEvents btn_P_Abs As System.Windows.Forms.Button
    Friend WithEvents btn_Stop As System.Windows.Forms.Button
    Friend WithEvents btn_Halt As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_Line_V As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_Line_Dec As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_Line_Acc As System.Windows.Forms.TextBox
    Friend WithEvents btn_Line_ID As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_ID1 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_ID0 As System.Windows.Forms.TextBox
    Friend WithEvents btn_Line_Param As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_P1 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_P0 As System.Windows.Forms.TextBox
    Friend WithEvents btn_Line_Halt As System.Windows.Forms.Button
    Friend WithEvents btn_Line_Stop As System.Windows.Forms.Button
    Friend WithEvents btn_Line_Abs As System.Windows.Forms.Button
    Friend WithEvents btn_Lien_Rel As System.Windows.Forms.Button
    Friend WithEvents chk_Pos As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Neg As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Run As System.Windows.Forms.CheckBox
    Friend WithEvents txt_P_Now As System.Windows.Forms.TextBox
    Friend WithEvents txt_V_Now As System.Windows.Forms.TextBox
    Friend WithEvents chk_Zero As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Get As System.Windows.Forms.CheckBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
