VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   8220
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   14625
   LinkTopic       =   "Form1"
   ScaleHeight     =   8220
   ScaleWidth      =   14625
   StartUpPosition =   3  '窗口缺省
   Begin VB.CommandButton Command6 
      Caption         =   "三轴及以上联动"
      Height          =   735
      Left            =   11400
      TabIndex        =   36
      Top             =   7080
      Width           =   2535
   End
   Begin VB.CommandButton btn_USB 
      Caption         =   "USB检测板卡"
      Height          =   615
      Left            =   4320
      TabIndex        =   35
      Top             =   120
      Width           =   1695
   End
   Begin VB.CommandButton Command7 
      Caption         =   "流指令下载2"
      Height          =   495
      Left            =   11760
      TabIndex        =   34
      Top             =   3480
      Width           =   2175
   End
   Begin VB.CommandButton Command5 
      Caption         =   "流指令停止"
      Height          =   735
      Left            =   11640
      TabIndex        =   33
      Top             =   5880
      Width           =   2295
   End
   Begin VB.CommandButton Command4 
      Caption         =   "流指令暂停"
      Height          =   735
      Left            =   11640
      TabIndex        =   32
      Top             =   5040
      Width           =   2295
   End
   Begin VB.CommandButton Command3 
      Caption         =   "流指令执行"
      Height          =   735
      Left            =   11640
      TabIndex        =   31
      Top             =   4200
      Width           =   2295
   End
   Begin VB.CommandButton Command2 
      Caption         =   "流指令下载"
      Height          =   495
      Left            =   11640
      TabIndex        =   30
      Top             =   2760
      Width           =   2295
   End
   Begin VB.CommandButton Command1 
      Caption         =   "SN"
      Height          =   615
      Left            =   11640
      TabIndex        =   29
      Top             =   2040
      Width           =   2415
   End
   Begin VB.Timer Timer1 
      Enabled         =   0   'False
      Interval        =   100
      Left            =   10440
      Top             =   3720
   End
   Begin VB.CommandButton btn_Stop_Continue 
      Caption         =   "停止连续动作"
      Height          =   735
      Left            =   11640
      TabIndex        =   28
      Top             =   1080
      Width           =   2535
   End
   Begin VB.CommandButton btn_Continue 
      Caption         =   "启动连续动作"
      Height          =   735
      Left            =   11640
      TabIndex        =   27
      Top             =   240
      Width           =   2535
   End
   Begin VB.CommandButton btn_In_All 
      Caption         =   "所有输入通道"
      Height          =   615
      Left            =   5640
      TabIndex        =   26
      Top             =   7440
      Width           =   2055
   End
   Begin VB.TextBox txt_In_All 
      Height          =   495
      Left            =   5520
      TabIndex        =   25
      Top             =   6720
      Width           =   2295
   End
   Begin VB.ComboBox Combo1 
      Height          =   315
      ItemData        =   "VB_Demo.frx":0000
      Left            =   360
      List            =   "VB_Demo.frx":001C
      Style           =   2  'Dropdown List
      TabIndex        =   24
      Top             =   6840
      Width           =   1575
   End
   Begin VB.CommandButton btn_Optic_In 
      Caption         =   "单通道光电输入"
      Height          =   495
      Left            =   2160
      TabIndex        =   23
      Top             =   7440
      Width           =   1695
   End
   Begin VB.TextBox txt_In_Single 
      Height          =   375
      Left            =   2280
      TabIndex        =   22
      Top             =   6840
      Width           =   1695
   End
   Begin VB.CheckBox chk_Zero 
      Caption         =   "零位"
      Height          =   495
      Left            =   8280
      TabIndex        =   21
      Top             =   4680
      Width           =   1815
   End
   Begin VB.CheckBox chk_Pos 
      Caption         =   "正限位"
      Height          =   495
      Left            =   8280
      TabIndex        =   20
      Top             =   4080
      Width           =   1815
   End
   Begin VB.CheckBox chk_Neg 
      Caption         =   "负限位"
      Height          =   495
      Left            =   8280
      TabIndex        =   19
      Top             =   3480
      Width           =   1815
   End
   Begin VB.CheckBox chk_Dir 
      Caption         =   "正方向"
      Height          =   495
      Left            =   8280
      TabIndex        =   18
      Top             =   3000
      Width           =   1815
   End
   Begin VB.CheckBox chk_Run 
      Caption         =   "运行中"
      Height          =   495
      Left            =   8280
      TabIndex        =   17
      Top             =   2400
      Width           =   1815
   End
   Begin VB.CommandButton btn_Status 
      Caption         =   "状态"
      Height          =   735
      Left            =   7920
      TabIndex        =   16
      Top             =   5520
      Width           =   2295
   End
   Begin VB.TextBox txt_Pos 
      Height          =   495
      Left            =   8400
      TabIndex        =   15
      Top             =   600
      Width           =   2295
   End
   Begin VB.CommandButton btn_Get_Pos 
      Caption         =   "读取位置"
      Height          =   735
      Left            =   8280
      TabIndex        =   14
      Top             =   1320
      Width           =   2415
   End
   Begin VB.CommandButton btn_Halt 
      Caption         =   "急停"
      Height          =   615
      Left            =   2880
      TabIndex        =   13
      Top             =   4680
      Width           =   2055
   End
   Begin VB.CommandButton btn_Stop 
      Caption         =   "停止"
      Height          =   615
      Left            =   720
      TabIndex        =   12
      Top             =   4680
      Width           =   1815
   End
   Begin VB.CommandButton btn_Abs 
      Caption         =   "绝对移动"
      Height          =   615
      Left            =   2160
      TabIndex        =   11
      Top             =   3840
      Width           =   1695
   End
   Begin VB.TextBox txt_Abs 
      Height          =   495
      Left            =   480
      TabIndex        =   10
      Text            =   "50000"
      Top             =   3840
      Width           =   1335
   End
   Begin VB.CommandButton btn_Ref 
      Caption         =   "相对移动"
      Height          =   615
      Left            =   2160
      TabIndex        =   9
      Top             =   3000
      Width           =   1695
   End
   Begin VB.TextBox txt_Ref 
      Height          =   495
      Left            =   480
      TabIndex        =   8
      Text            =   "50000"
      Top             =   3000
      Width           =   1335
   End
   Begin VB.CommandButton btn_MaxV 
      Caption         =   "速度"
      Height          =   615
      Left            =   2160
      TabIndex        =   7
      Top             =   1920
      Width           =   1695
   End
   Begin VB.TextBox txt_MaxV 
      Height          =   495
      Left            =   480
      TabIndex        =   6
      Text            =   "5000"
      Top             =   1920
      Width           =   1335
   End
   Begin VB.CommandButton btn_Dec 
      Caption         =   "减速度"
      Height          =   615
      Left            =   5760
      TabIndex        =   5
      Top             =   960
      Width           =   1695
   End
   Begin VB.TextBox txt_Dec 
      Height          =   495
      Left            =   4080
      TabIndex        =   4
      Text            =   "500"
      Top             =   1080
      Width           =   1335
   End
   Begin VB.CommandButton btn_Acc 
      Caption         =   "加速度"
      Height          =   615
      Left            =   2160
      TabIndex        =   3
      Top             =   960
      Width           =   1695
   End
   Begin VB.TextBox txt_Acc 
      Height          =   495
      Left            =   480
      TabIndex        =   2
      Text            =   "500"
      Top             =   1080
      Width           =   1335
   End
   Begin VB.CommandButton btn_Port 
      Caption         =   "检测板卡"
      Height          =   615
      Left            =   2160
      TabIndex        =   1
      Top             =   120
      Width           =   1695
   End
   Begin VB.TextBox txt_Port 
      Height          =   375
      Left            =   480
      TabIndex        =   0
      Text            =   "COM1"
      Top             =   240
      Width           =   1335
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Public iStatus As Long
Private Sub btn_Abs_Click()
 Dim iR As Long
 '一定要设置为位置模式，位置相关的函数才会有效
 iR = MT_Set_Axis_Mode_Position(0)
 iR = MT_Set_Axis_Position_P_Target_Abs(0, CLng(txt_Abs.Text))
 
   If (iR <> 0) Then
  
   MsgBox ("Error")
   Exit Sub
  End
 Else
  
    MsgBox ("ok")
  End If
End Sub

Private Sub btn_Acc_Click()
 Dim iR As Long
 iR = MT_Set_Axis_Acc(0, CLng(txt_Acc.Text))
  If (iR <> 0) Then
  
   MsgBox ("Error")
   Exit Sub
  End
 Else
  
    MsgBox ("ok")
  End If
End Sub

Private Sub btn_Continue_Click()
 '初始化动作
 iStatus = 0
 Timer1.Enabled = True
End Sub

Private Sub btn_Dec_Click()
 Dim iR As Long
 iR = MT_Set_Axis_Dec(0, CLng(txt_Dec.Text))
  If (iR <> 0) Then
  
   MsgBox ("Error")
   Exit Sub
  End
 Else
  
    MsgBox ("ok")
  End If
End Sub

Private Sub btn_Get_Pos_Click()
 Dim iPos As Long
 Dim iR As Long
 iR = MT_Get_Axis_Software_P_Now(0, iPos)
 If (iR <> 0) Then
  MsgBox ("Error")
 End
 Else
  'MsgBox ("ok")
  txt_Pos.Text = CStr(iPos)
 End If
 
End Sub

Private Sub btn_Halt_Click()
 Dim iR As Long
 iR = MT_Set_Axis_Halt(0)
   If (iR <> 0) Then
  
   MsgBox ("Error")
   Exit Sub
  End
 Else
  
    MsgBox ("ok")
  End If
End Sub

Private Sub btn_In_All_Click()
 Dim iR As Long
 Dim Value As Long
 iR = MT_Get_Optic_In_All(Value)
  If (iR <> 0) Then
  
   MsgBox ("Error")
  End
 Else
  txt_In_All.Text = CStr(Value)

  End If
End Sub

Private Sub btn_MaxV_Click()
 Dim iR As Long
 iR = MT_Set_Axis_Position_V_Max(0, CLng(txt_MaxV.Text))
  If (iR <> 0) Then
  
   MsgBox ("Error")
   Exit Sub
  End
 Else
  
    MsgBox ("ok")
  End If
End Sub

Private Sub btn_Optic_In_Click()
 Dim iR As Long
 Dim Value As Long
 iR = MT_Get_Optic_In_Single(Combo1.ListIndex, Value)
  If (iR <> 0) Then
  
   MsgBox ("Error")
  End
 Else
  If (Value > 0) Then
  
    txt_In_Single.Text = "高电平"
    Else
    txt_In_Single.Text = "低电平"
    End If
  End If
 
 
End Sub

Private Sub btn_Port_Click()
 Dim iR As Long
 MT_Close_UART
 MT_Close_USB
 iR = MT_Open_UART(txt_Port.Text)
 If (iR <> 0) Then
   MsgBox ("Error")
   Exit Sub
  End If
 iR = MT_Check
 If (iR <> 0) Then
  
   MsgBox ("Error")
   Exit Sub
  End
 Else
  
    MsgBox ("ok")
  End If
 
End Sub

Private Sub btn_Ref_Click()
 Dim iR As Long
 '一定要设置为位置模式，位置相关的函数才会有效
 iR = MT_Set_Axis_Mode_Position(0)
 iR = MT_Set_Axis_Position_P_Target_Rel(0, CLng(txt_Ref.Text))
 
  If (iR <> 0) Then
  
   MsgBox ("Error")
   Exit Sub
  End
 Else
  
    MsgBox ("ok")
  End If
End Sub

Private Sub btn_Status_Click()
 Dim iR As Long
 Dim bRun, bDir, bNeg, bPos, bZero As Byte
 Dim iMode As Byte
 iR = MT_Get_Axis_Status(0, bRun, bDir, bNeg, bPos, bZero, iMode)
 
   If (iR <> 0) Then
  
   MsgBox ("Error")
   Exit Sub
  End
 Else
  chk_Run.Value = bRun
  chk_Dir.Value = bDir
  chk_Neg.Value = bNeg
  chk_Pos.Value = bPos
  chk_Zero.Value = bZero
  End If
End Sub

Private Sub btn_Stop_Click()
 Dim iR As Long
 iR = MT_Set_Axis_Position_Stop(0)
 
   If (iR <> 0) Then
  
   MsgBox ("Error")
   Exit Sub
  End
 Else
  
    MsgBox ("ok")
  End If
End Sub

Private Sub btn_USB_Click()
 Dim iR As Long
 MT_Close_UART
 MT_Close_USB
 iR = MT_Open_USB
 If (iR <> 0) Then
   MsgBox ("Error")
   Exit Sub
  End If
 iR = MT_Check
 If (iR <> 0) Then
  
   MsgBox ("Error")
   Exit Sub
  End
 Else
  
    MsgBox ("ok")
  End If
End Sub

Private Sub Command1_Click()
   Dim Sn As String
   Sn = String(12, Chr(0))
   MT_Get_Product_SN (Sn)
   MsgBox (Sn)
End Sub

Private Sub btn_Stop_Continue_Click()
 Timer1.Enabled = False
End Sub

Private Sub Command2_Click()
    '启动流模式，输入前后都可以,本例在其它按钮里启动
    '  MT_Set_Stream_Run();
    '本例发送输闪灯出100次的例子做参考，可以发送stream打头的运动指令，一次性下载到板卡，由板卡执行,只要有空间，就可以连续下发
    '以下功能可以放在定时器里，在定时器里根据状态不停的发指令就可以，需要注意要查询缓冲区空间
    '没有空间的时候等待下次定时
    Dim i, iSpace, iR As Long
    For i = 0 To 99
    
        '判断指令缓冲区空间是否有空余，不同的指令占用的空间不一样
        iR = MT_Get_Stream_Space(iSpace)
        If iSpace > 20 Then
        
           iR = MT_Set_Stream_Optic_Out_Single(0, 1)
        End If
        iR = MT_Get_Stream_Space(iSpace)
        If iSpace > 20 Then
        
            iR = MT_Set_Stream_Delay(500)
        End If
        iR = MT_Get_Stream_Space(iSpace)
        If iSpace > 20 Then
        
           iR = MT_Set_Stream_Optic_Out_Single(0, 0)
        End If
        iR = MT_Get_Stream_Space(iSpace)
        If iSpace > 20 Then
        
           iR = MT_Set_Stream_Delay(500)
        End If
    Next i
End Sub

Private Sub Command3_Click()
 Dim iR As Long
 iR = MT_Set_Stream_Run()
End Sub

Private Sub Command4_Click()
 Dim iR As Long
 iR = MT_Set_Stream_Pause()
End Sub

Private Sub Command5_Click()
 Dim iR As Long
 iR = MT_Set_Stream_Stop()
End Sub

Private Sub Command6_Click()
        Dim iR As Long
        Dim iAxis(8) As Long
        Dim iTarget(8) As Long
        '轴序号 此处为三轴，多轴请增加对应的轴序号
        iAxis(0) = 0
        iAxis(1) = 1
        iAxis(2) = 2
        '目标值 此处为三轴，多轴请修改对应的目标位置
        iTarget(0) = 10000
        iTarget(1) = 1000
        iTarget(2) = 2030
        
        '设置插补参数，速度为最快轴的速度，一般情况下可以在初始化中设置一次即可,本例为每次设置
        
        iR = MT_Set_Axis_Line_Acc(0, 5000)
        
        iR = MT_Set_Axis_Line_Dec(0, 5000)
        
        iR = MT_Set_Axis_Line_V(0, 5000)
    
        '发送移动指令,此处为三轴，多轴请修改数字
        iR = MT_Set_Axis_Line_X_Run_Rel(0, 3, VarPtr(iAxis(0)), VarPtr(iTarget(0)))
        
  
End Sub

Private Sub Command7_Click()
        Dim iR As Long
        Dim iAxis(3) As Long
        Dim iTarget(3) As Long
        '轴序号
        iAxis(0) = 0
        iAxis(1) = 1
        iAxis(2) = 3
        '目标值
        iTarget(0) = 10000
        iTarget(1) = 100
        iTarget(2) = 2030
        
        '判断指令缓冲区空间是否有空余，不同的指令占用的空间不一样,本例中没有处理空间不够的情况下下次继续发送，可以做到
        '定时器里  正式使用要增加else判断，等待指令空间有空
        '发送移动指令
        iR = MT_Get_Stream_Space(iSpace)
        If iSpace > 20 Then
        
           iR = MT_Set_Stream_Line_X_Run_Rel(0, 3, VarPtr(iAxis(0)), VarPtr(iTarget(0)))
        End If
        
        iR = MT_Get_Stream_Space(iSpace)
        If iSpace > 20 Then
        
            '等待移动指令完成
           iR = MT_Set_Stream_Wait_Line(0)
        End If
        
        '回零点
        iTarget(0) = 0
        iTarget(1) = 0
        iTarget(2) = 0
        iR = MT_Get_Stream_Space(iSpace)
        If iSpace > 20 Then
        
           iR = MT_Set_Stream_Line_X_Run_Abs(0, 3, VarPtr(iAxis(0)), VarPtr(iTarget(0)))
        End If
        '根据需要，决定是否发送本指令
        If iSpace > 20 Then
          '后续如果有连续动作，不允许有减速过程，直接从上一段的速度启动
           iR = MT_Set_Stream_Dec_Disable()
           
        End If
        
        '等待移动指令完成
           iR = MT_Set_Stream_Wait_Line(0)
        '输出1
        iR = MT_Get_Stream_Space(iSpace)
        If iSpace > 20 Then
        
           iR = MT_Set_Stream_Optic_Out_Single(0, 1)
        End If
        '发送新的移动指令
        iTarget(0) = 1000
        iTarget(1) = 1000
        iTarget(2) = 2000
        iR = MT_Get_Stream_Space(iSpace)
        If iSpace > 20 Then
        iR = MT_Set_Stream_Line_X_Run_Abs(0, 3, VarPtr(iAxis(0)), VarPtr(iTarget(0)))
        End If
        '等待完成
        iR = MT_Get_Stream_Space(iSpace)
        If iSpace > 20 Then
        iR = MT_Set_Stream_Wait_Line(0)
        End If
        
        '输出0
        iR = MT_Get_Stream_Space(iSpace)
        If iSpace > 20 Then
        
           iR = MT_Set_Stream_Optic_Out_Single(0, 0)
        End If
        
End Sub

Private Sub Form_Load()
 MT_Init
 
 Combo1.ListIndex = 0
End Sub

Private Sub Form_Unload(Cancel As Integer)
 MT_DeInit
End Sub

Private Sub Timer1_Timer()
        Dim iValue As Long
        Dim iR As Long
        '以下实现重复走一个等边直角三角形
        Select Case iStatus
            Case 0
                '设置直线插补参数
                '第一组直线插补，参与轴为0,1
                iR = MT_Set_Axis_Line_Axis(0, 0, 1)
                '设置运动参数
                iR = MT_Set_Axis_Line_Acc(0, 2000)
                iR = MT_Set_Axis_Line_Dec(0, 2000)
                iR = MT_Set_Axis_Line_V(0, 10000)
                iStatus = 1
            Case 1
                '走第一段
                iR = MT_Set_Axis_Line_Run_Rel(0, 0, 1000)
                iStatus = 2
            Case 2
                '判断是否走完
                iR = MT_Get_Axis_Line_Status(0, iValue)
                If (iValue = 0) Then
                    iStatus = 3
                End If
            Case 3
                '走第2段
                iR = MT_Set_Axis_Line_Run_Rel(0, 1000, 0)
                iStatus = 4
            Case 4
                '判断是否走完
                iR = MT_Get_Axis_Line_Status(0, iValue)
                If (iValue = 0) Then
                    iStatus = 5
                End If
            Case 5
                '走第3段
                iR = MT_Set_Axis_Line_Run_Rel(0, -1000, -1000)
                iStatus = 6
            Case 6
                '判断是否走完
                iR = MT_Get_Axis_Line_Status(0, iValue)
                If (iValue = 0) Then
                    iStatus = 1
                End If

        End Select

End Sub
