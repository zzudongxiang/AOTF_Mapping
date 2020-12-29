object MainFrm: TMainFrm
  Left = 0
  Top = 0
  Caption = 'Delphi例程'
  ClientHeight = 473
  ClientWidth = 935
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  OnCreate = FormCreate
  OnDestroy = FormDestroy
  PixelsPerInch = 96
  object Label1: TLabel
    Left = 40
    Top = 32
    Width = 24
    Height = 13
    Caption = '串口'
  end
  object Label2: TLabel
    Left = 216
    Top = 32
    Width = 36
    Height = 13
    Caption = '轴序号'
  end
  object lbl_1: TLabel
    Left = 216
    Top = 99
    Width = 24
    Height = 13
    Caption = '速度'
  end
  object lbl_11: TLabel
    Left = 216
    Top = 159
    Width = 36
    Height = 13
    Caption = '加速度'
  end
  object lbl_12: TLabel
    Left = 216
    Top = 232
    Width = 36
    Height = 13
    Caption = '减速度'
  end
  object Label3: TLabel
    Left = 416
    Top = 202
    Width = 48
    Height = 13
    Caption = '当前速度'
  end
  object Label4: TLabel
    Left = 416
    Top = 251
    Width = 48
    Height = 13
    Caption = '当前位置'
  end
  object btn_Open: TButton
    Left = 24
    Top = 84
    Width = 153
    Height = 57
    Caption = '打开串口'
    TabOrder = 0
    OnClick = btn_OpenClick
  end
  object btn_OpenUSB: TButton
    Left = 24
    Top = 210
    Width = 153
    Height = 57
    Caption = '打开USB'
    TabOrder = 1
    OnClick = btn_OpenUSBClick
  end
  object btn_Check: TButton
    Left = 24
    Top = 359
    Width = 153
    Height = 57
    Caption = '检测板卡'
    TabOrder = 2
    OnClick = btn_CheckClick
  end
  object edt_COM: TEdit
    Left = 40
    Top = 56
    Width = 121
    Height = 21
    TabOrder = 3
    Text = 'COM1'
  end
  object edt_Axis: TEdit
    Left = 216
    Top = 56
    Width = 121
    Height = 21
    TabOrder = 4
    Text = '0'
  end
  object edt_V: TEdit
    Left = 216
    Top = 123
    Width = 121
    Height = 21
    TabOrder = 5
    Text = '2000'
  end
  object edt_ACC: TEdit
    Left = 216
    Top = 184
    Width = 121
    Height = 21
    TabOrder = 6
    Text = '2000'
  end
  object edt_Dec: TEdit
    Left = 216
    Top = 256
    Width = 121
    Height = 21
    TabOrder = 7
    Text = '2000'
  end
  object btn_Set: TButton
    Left = 200
    Top = 296
    Width = 153
    Height = 57
    Caption = '设置参数'
    TabOrder = 8
    OnClick = btn_SetClick
  end
  object chk_Read: TCheckBox
    Left = 408
    Top = 32
    Width = 97
    Height = 17
    Caption = '读取状态'
    TabOrder = 9
    OnClick = chk_ReadClick
  end
  object chk_Neg: TCheckBox
    Left = 440
    Top = 99
    Width = 97
    Height = 17
    Caption = '负限位'
    TabOrder = 10
  end
  object chk_Pos: TCheckBox
    Left = 440
    Top = 129
    Width = 97
    Height = 17
    Caption = '正限位'
    TabOrder = 11
  end
  object chk_Zero: TCheckBox
    Left = 440
    Top = 158
    Width = 97
    Height = 17
    Caption = '零位'
    TabOrder = 12
  end
  object chk_Continue: TCheckBox
    Left = 617
    Top = 84
    Width = 97
    Height = 17
    Caption = '连续走停'
    TabOrder = 13
    OnClick = chk_ContinueClick
  end
  object btn_CloseUSB: TButton
    Left = 24
    Top = 273
    Width = 153
    Height = 57
    Caption = '关闭USB'
    TabOrder = 14
    OnClick = btn_CloseUSBClick
  end
  object btn_CloseUART: TButton
    Left = 24
    Top = 147
    Width = 153
    Height = 57
    Caption = '关闭串口'
    TabOrder = 15
    OnClick = btn_CloseUARTClick
  end
  object btn_Move_Abs: TButton
    Left = 480
    Top = 387
    Width = 145
    Height = 57
    Caption = '绝对移动'
    TabOrder = 16
    OnClick = btn_Move_AbsClick
  end
  object edt_Abs: TEdit
    Left = 480
    Top = 348
    Width = 121
    Height = 21
    TabOrder = 17
    Text = '10000'
  end
  object edt_Rel: TEdit
    Left = 688
    Top = 348
    Width = 121
    Height = 21
    TabOrder = 18
    Text = '10000'
  end
  object btn_Move_Rel: TButton
    Left = 688
    Top = 387
    Width = 145
    Height = 57
    Caption = '相对移动'
    TabOrder = 19
    OnClick = btn_Move_RelClick
  end
  object chk_Run: TCheckBox
    Left = 440
    Top = 66
    Width = 97
    Height = 17
    Caption = '运行状态'
    TabOrder = 20
  end
  object edt_V_Now: TEdit
    Left = 416
    Top = 224
    Width = 121
    Height = 21
    TabOrder = 21
  end
  object edt_P_Now: TEdit
    Left = 416
    Top = 273
    Width = 121
    Height = 21
    TabOrder = 22
  end
  object chk_Continue_Line: TCheckBox
    Left = 617
    Top = 158
    Width = 224
    Height = 17
    Caption = '连续直线/圆弧插补'
    TabOrder = 23
    OnClick = chk_Continue_LineClick
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
