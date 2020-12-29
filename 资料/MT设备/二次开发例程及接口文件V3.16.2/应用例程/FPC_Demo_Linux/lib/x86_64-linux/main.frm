object MainFrm: TMainFrm
  Left = 0
  Height = 473
  Top = 0
  Width = 935
  Caption = 'Delphi例程'
  ClientHeight = 473
  ClientWidth = 935
  Color = clBtnFace
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  OnCreate = FormCreate
  OnDestroy = FormDestroy
  LCLVersion = '6.3'
  object Label1: TLabel
    Left = 40
    Height = 13
    Top = 32
    Width = 22
    Caption = '串口'
    ParentColor = False
  end
  object Label2: TLabel
    Left = 216
    Height = 13
    Top = 32
    Width = 33
    Caption = '轴序号'
    ParentColor = False
  end
  object lbl_1: TLabel
    Left = 216
    Height = 13
    Top = 99
    Width = 22
    Caption = '速度'
    ParentColor = False
  end
  object lbl_11: TLabel
    Left = 216
    Height = 13
    Top = 159
    Width = 33
    Caption = '加速度'
    ParentColor = False
  end
  object lbl_12: TLabel
    Left = 216
    Height = 13
    Top = 232
    Width = 33
    Caption = '减速度'
    ParentColor = False
  end
  object Label3: TLabel
    Left = 416
    Height = 13
    Top = 202
    Width = 44
    Caption = '当前速度'
    ParentColor = False
  end
  object Label4: TLabel
    Left = 416
    Height = 13
    Top = 251
    Width = 44
    Caption = '当前位置'
    ParentColor = False
  end
  object btn_Open: TButton
    Left = 24
    Height = 57
    Top = 84
    Width = 153
    Caption = '打开串口'
    OnClick = btn_OpenClick
    TabOrder = 0
  end
  object btn_OpenUSB: TButton
    Left = 24
    Height = 57
    Top = 210
    Width = 153
    Caption = '打开USB'
    Enabled = False
    OnClick = btn_OpenUSBClick
    TabOrder = 1
    Visible = False
  end
  object btn_Check: TButton
    Left = 24
    Height = 57
    Top = 359
    Width = 153
    Caption = '检测板卡'
    OnClick = btn_CheckClick
    TabOrder = 2
  end
  object edt_COM: TEdit
    Left = 40
    Height = 23
    Top = 56
    Width = 121
    TabOrder = 3
    Text = '/dev/ttyS1'
  end
  object edt_Axis: TEdit
    Left = 216
    Height = 23
    Top = 56
    Width = 121
    TabOrder = 4
    Text = '0'
  end
  object edt_V: TEdit
    Left = 216
    Height = 23
    Top = 123
    Width = 121
    TabOrder = 5
    Text = '2000'
  end
  object edt_ACC: TEdit
    Left = 216
    Height = 23
    Top = 184
    Width = 121
    TabOrder = 6
    Text = '2000'
  end
  object edt_Dec: TEdit
    Left = 216
    Height = 23
    Top = 256
    Width = 121
    TabOrder = 7
    Text = '2000'
  end
  object btn_Set: TButton
    Left = 200
    Height = 57
    Top = 296
    Width = 153
    Caption = '设置参数'
    OnClick = btn_SetClick
    TabOrder = 8
  end
  object chk_Read: TCheckBox
    Left = 408
    Height = 27
    Top = 32
    Width = 86
    Caption = '读取状态'
    OnClick = chk_ReadClick
    TabOrder = 9
  end
  object chk_Neg: TCheckBox
    Left = 440
    Height = 27
    Top = 99
    Width = 71
    Caption = '负限位'
    TabOrder = 10
  end
  object chk_Pos: TCheckBox
    Left = 440
    Height = 27
    Top = 129
    Width = 71
    Caption = '正限位'
    TabOrder = 11
  end
  object chk_Zero: TCheckBox
    Left = 440
    Height = 27
    Top = 158
    Width = 56
    Caption = '零位'
    TabOrder = 12
  end
  object chk_Continue: TCheckBox
    Left = 617
    Height = 27
    Top = 84
    Width = 86
    Caption = '连续走停'
    OnClick = chk_ContinueClick
    TabOrder = 13
  end
  object btn_CloseUSB: TButton
    Left = 24
    Height = 57
    Top = 273
    Width = 153
    Caption = '关闭USB'
    Enabled = False
    OnClick = btn_CloseUSBClick
    TabOrder = 14
    Visible = False
  end
  object btn_CloseUART: TButton
    Left = 24
    Height = 57
    Top = 147
    Width = 153
    Caption = '关闭串口'
    OnClick = btn_CloseUARTClick
    TabOrder = 15
  end
  object btn_Move_Abs: TButton
    Left = 480
    Height = 57
    Top = 387
    Width = 145
    Caption = '绝对移动'
    OnClick = btn_Move_AbsClick
    TabOrder = 16
  end
  object edt_Abs: TEdit
    Left = 480
    Height = 23
    Top = 348
    Width = 121
    TabOrder = 17
    Text = '10000'
  end
  object edt_Rel: TEdit
    Left = 688
    Height = 23
    Top = 348
    Width = 121
    TabOrder = 18
    Text = '10000'
  end
  object btn_Move_Rel: TButton
    Left = 688
    Height = 57
    Top = 387
    Width = 145
    Caption = '相对移动'
    OnClick = btn_Move_RelClick
    TabOrder = 19
  end
  object chk_Run: TCheckBox
    Left = 440
    Height = 27
    Top = 66
    Width = 86
    Caption = '运行状态'
    TabOrder = 20
  end
  object edt_V_Now: TEdit
    Left = 416
    Height = 23
    Top = 224
    Width = 121
    TabOrder = 21
  end
  object edt_P_Now: TEdit
    Left = 416
    Height = 23
    Top = 273
    Width = 121
    TabOrder = 22
  end
  object chk_Continue_Line: TCheckBox
    Left = 617
    Height = 27
    Top = 158
    Width = 152
    Caption = '连续直线/圆弧插补'
    OnClick = chk_Continue_LineClick
    TabOrder = 23
  end
  object tmr_Read: TTimer
    Enabled = False
    Interval = 500
    OnTimer = tmr_ReadTimer
    Left = 368
    Top = 384
  end
  object tmr_Continue: TTimer
    Enabled = False
    Interval = 500
    OnTimer = tmr_ContinueTimer
    Left = 368
    Top = 424
  end
  object tmr_LineCircle: TTimer
    Enabled = False
    Interval = 500
    OnTimer = tmr_LineCircleTimer
    Left = 696
    Top = 248
  end
end
