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
   StartUpPosition =   3  '����ȱʡ
   Begin VB.CommandButton Command7 
      Caption         =   "��ָ������2"
      Height          =   495
      Left            =   11760
      TabIndex        =   34
      Top             =   3480
      Width           =   2175
   End
   Begin VB.CommandButton Command5 
      Caption         =   "��ָ��ֹͣ"
      Height          =   735
      Left            =   11640
      TabIndex        =   33
      Top             =   5880
      Width           =   2295
   End
   Begin VB.CommandButton Command4 
      Caption         =   "��ָ����ͣ"
      Height          =   735
      Left            =   11640
      TabIndex        =   32
      Top             =   5040
      Width           =   2295
   End
   Begin VB.CommandButton Command3 
      Caption         =   "��ָ��ִ��"
      Height          =   735
      Left            =   11640
      TabIndex        =   31
      Top             =   4200
      Width           =   2295
   End
   Begin VB.CommandButton Command2 
      Caption         =   "��ָ������"
      Height          =   495
      Left            =   11640
      TabIndex        =   30
      Top             =   2760
      Width           =   2295
   End
   Begin VB.CommandButton Command1 
      Caption         =   "SN"
      Height          =   855
      Left            =   11640
      TabIndex        =   29
      Top             =   1800
      Width           =   2415
   End
   Begin VB.Timer Timer1 
      Enabled         =   0   'False
      Interval        =   100
      Left            =   10440
      Top             =   3720
   End
   Begin VB.CommandButton btn_Stop_Continue 
      Caption         =   "ֹͣ��������"
      Height          =   735
      Left            =   11640
      TabIndex        =   28
      Top             =   1080
      Width           =   2535
   End
   Begin VB.CommandButton btn_Continue 
      Caption         =   "������������"
      Height          =   735
      Left            =   11640
      TabIndex        =   27
      Top             =   240
      Width           =   2535
   End
   Begin VB.CommandButton btn_In_All 
      Caption         =   "��������ͨ��"
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
      Caption         =   "��ͨ���������"
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
      Caption         =   "��λ"
      Height          =   495
      Left            =   8280
      TabIndex        =   21
      Top             =   4680
      Width           =   1815
   End
   Begin VB.CheckBox chk_Pos 
      Caption         =   "����λ"
      Height          =   495
      Left            =   8280
      TabIndex        =   20
      Top             =   4080
      Width           =   1815
   End
   Begin VB.CheckBox chk_Neg 
      Caption         =   "����λ"
      Height          =   495
      Left            =   8280
      TabIndex        =   19
      Top             =   3480
      Width           =   1815
   End
   Begin VB.CheckBox chk_Dir 
      Caption         =   "������"
      Height          =   495
      Left            =   8280
      TabIndex        =   18
      Top             =   3000
      Width           =   1815
   End
   Begin VB.CheckBox chk_Run 
      Caption         =   "������"
      Height          =   495
      Left            =   8280
      TabIndex        =   17
      Top             =   2400
      Width           =   1815
   End
   Begin VB.CommandButton btn_Status 
      Caption         =   "״̬"
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
      Caption         =   "��ȡλ��"
      Height          =   735
      Left            =   8280
      TabIndex        =   14
      Top             =   1320
      Width           =   2415
   End
   Begin VB.CommandButton btn_Halt 
      Caption         =   "��ͣ"
      Height          =   615
      Left            =   2880
      TabIndex        =   13
      Top             =   4680
      Width           =   2055
   End
   Begin VB.CommandButton btn_Stop 
      Caption         =   "ֹͣ"
      Height          =   615
      Left            =   720
      TabIndex        =   12
      Top             =   4680
      Width           =   1815
   End
   Begin VB.CommandButton btn_Abs 
      Caption         =   "�����ƶ�"
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
      Caption         =   "����ƶ�"
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
      Caption         =   "�ٶ�"
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
      Caption         =   "���ٶ�"
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
      Caption         =   "���ٶ�"
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
      Caption         =   "���忨"
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
 'һ��Ҫ����Ϊλ��ģʽ��λ����صĺ����Ż���Ч
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
 '��ʼ������
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
  
    txt_In_Single.Text = "�ߵ�ƽ"
    Else
    txt_In_Single.Text = "�͵�ƽ"
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
 'һ��Ҫ����Ϊλ��ģʽ��λ����صĺ����Ż���Ч
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
    '������ģʽ������ǰ�󶼿���,������������ť������
    '  MT_Set_Stream_Run();
    '�������������Ƴ�100�ε��������ο������Է���stream��ͷ���˶�ָ�һ�������ص��忨���ɰ忨ִ��,ֻҪ�пռ䣬�Ϳ��������·�
    '���¹��ܿ��Է��ڶ�ʱ����ڶ�ʱ�������״̬��ͣ�ķ�ָ��Ϳ��ԣ���Ҫע��Ҫ��ѯ�������ռ�
    'û�пռ��ʱ��ȴ��´ζ�ʱ
    Dim i, iSpace, iR As Long
    For i = 0 To 99
    
        '�ж�ָ������ռ��Ƿ��п��࣬��ͬ��ָ��ռ�õĿռ䲻һ��
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

End Sub

Private Sub Command7_Click()
        Dim iR As Long
        Dim iAxis(3) As Long
        Dim iTarget(3) As Long
        '�����
        iAxis(0) = 0
        iAxis(1) = 1
        iAxis(2) = 3
        'Ŀ��ֵ
        iTarget(0) = 10000
        iTarget(1) = 100
        iTarget(2) = 2030
        
        '�ж�ָ������ռ��Ƿ��п��࣬��ͬ��ָ��ռ�õĿռ䲻һ��,������û�д���ռ䲻����������´μ������ͣ���������
        '��ʱ����  ��ʽʹ��Ҫ����else�жϣ��ȴ�ָ��ռ��п�
        '�����ƶ�ָ��
        iR = MT_Get_Stream_Space(iSpace)
        If iSpace > 20 Then
        
           iR = MT_Set_Stream_Line_X_Run_Rel(0, 3, VarPtr(iAxis(0)), VarPtr(iTarget(0)))
        End If
        
        iR = MT_Get_Stream_Space(iSpace)
        If iSpace > 20 Then
        
            '�ȴ��ƶ�ָ�����
           iR = MT_Set_Stream_Wait_Line(0)
        End If
        
        '�����
        iTarget(0) = 0
        iTarget(1) = 0
        iTarget(2) = 0
        iR = MT_Get_Stream_Space(iSpace)
        If iSpace > 20 Then
        
           iR = MT_Set_Stream_Line_X_Run_Abs(0, 3, VarPtr(iAxis(0)), VarPtr(iTarget(0)))
        End If
        '������Ҫ�������Ƿ��ͱ�ָ��
        If iSpace > 20 Then
          '��������������������������м��ٹ��̣�ֱ�Ӵ���һ�ε��ٶ�����
           iR = MT_Set_Stream_Dec_Disable()
           
        End If
        
        '�ȴ��ƶ�ָ�����
           iR = MT_Set_Stream_Wait_Line(0)
        '���1
        iR = MT_Get_Stream_Space(iSpace)
        If iSpace > 20 Then
        
           iR = MT_Set_Stream_Optic_Out_Single(0, 1)
        End If
        '�����µ��ƶ�ָ��
        iTarget(0) = 1000
        iTarget(1) = 1000
        iTarget(2) = 2000
        iR = MT_Get_Stream_Space(iSpace)
        If iSpace > 20 Then
        iR = MT_Set_Stream_Line_X_Run_Abs(0, 3, VarPtr(iAxis(0)), VarPtr(iTarget(0)))
        End If
        '�ȴ����
        iR = MT_Get_Stream_Space(iSpace)
        If iSpace > 20 Then
        iR = MT_Set_Stream_Wait_Line(0)
        End If
        
        '���0
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
        '����ʵ���ظ���һ���ȱ�ֱ��������
        Select Case iStatus
            Case 0
                '����ֱ�߲岹����
                '��һ��ֱ�߲岹��������Ϊ0,1
                iR = MT_Set_Axis_Line_Axis(0, 0, 1)
                '�����˶�����
                iR = MT_Set_Axis_Line_Acc(0, 2000)
                iR = MT_Set_Axis_Line_Dec(0, 2000)
                iR = MT_Set_Axis_Line_V(0, 10000)
                iStatus = 1
            Case 1
                '�ߵ�һ��
                iR = MT_Set_Axis_Line_Run_Rel(0, 0, 1000)
                iStatus = 2
            Case 2
                '�ж��Ƿ�����
                iR = MT_Get_Axis_Line_Status(0, iValue)
                If (iValue = 0) Then
                    iStatus = 3
                End If
            Case 3
                '�ߵ�2��
                iR = MT_Set_Axis_Line_Run_Rel(0, 1000, 0)
                iStatus = 4
            Case 4
                '�ж��Ƿ�����
                iR = MT_Get_Axis_Line_Status(0, iValue)
                If (iValue = 0) Then
                    iStatus = 5
                End If
            Case 5
                '�ߵ�3��
                iR = MT_Set_Axis_Line_Run_Rel(0, -1000, -1000)
                iStatus = 6
            Case 6
                '�ж��Ƿ�����
                iR = MT_Get_Axis_Line_Status(0, iValue)
                If (iValue = 0) Then
                    iStatus = 1
                End If

        End Select

End Sub
