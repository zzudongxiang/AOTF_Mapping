unit main;

{$IFDEF FPC}
  {$MODE Delphi}
{$ENDIF}

interface

uses
{$IFnDEF FPC}
  Windows,
{$ELSE}
  LCLIntf, LCLType, LMessages,
{$ENDIF}
  SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, ExtCtrls;

type
  TMainFrm = class(TForm)
    btn_Open: TButton;
    btn_OpenUSB: TButton;
    btn_Check: TButton;
    edt_COM: TEdit;
    edt_Axis: TEdit;
    Label1: TLabel;
    Label2: TLabel;
    lbl_1: TLabel;
    edt_V: TEdit;
    lbl_11: TLabel;
    edt_ACC: TEdit;
    lbl_12: TLabel;
    edt_Dec: TEdit;
    btn_Set: TButton;
    chk_Read: TCheckBox;
    chk_Neg: TCheckBox;
    chk_Pos: TCheckBox;
    chk_Zero: TCheckBox;
    chk_Continue: TCheckBox;
    tmr_Read: TTimer;
    tmr_Continue: TTimer;
    btn_CloseUSB: TButton;
    btn_CloseUART: TButton;
    btn_Move_Abs: TButton;
    edt_Abs: TEdit;
    edt_Rel: TEdit;
    btn_Move_Rel: TButton;
    chk_Run: TCheckBox;
    edt_V_Now: TEdit;
    edt_P_Now: TEdit;
    Label3: TLabel;
    Label4: TLabel;
    chk_Continue_Line: TCheckBox;
    tmr_LineCircle: TTimer;
    procedure FormCreate(Sender: TObject);
    procedure FormDestroy(Sender: TObject);
    procedure btn_SetClick(Sender: TObject);
    procedure btn_OpenClick(Sender: TObject);
    procedure btn_OpenUSBClick(Sender: TObject);
    procedure btn_CheckClick(Sender: TObject);
    procedure btn_CloseUARTClick(Sender: TObject);
    procedure btn_CloseUSBClick(Sender: TObject);
    procedure chk_ReadClick(Sender: TObject);
    procedure chk_ContinueClick(Sender: TObject);
    procedure tmr_ReadTimer(Sender: TObject);
    procedure tmr_ContinueTimer(Sender: TObject);
    procedure btn_Move_AbsClick(Sender: TObject);
    procedure btn_Move_RelClick(Sender: TObject);
    procedure chk_Continue_LineClick(Sender: TObject);
    procedure tmr_LineCircleTimer(Sender: TObject);
  private
    { Private declarations }
    iStage:Integer;//连续工作当前步骤序号

    iLineCircle:Integer;//连续直线圆弧插补
  public
    { Public declarations }
  end;

var
  MainFrm: TMainFrm;

implementation

uses MT_API;

{$IFnDEF FPC}
  {$R *.dfm}
{$ELSE}
  {$R *.frm}
{$ENDIF}

procedure TMainFrm.btn_CheckClick(Sender: TObject);
var
  iResult:Integer;
begin
//必要的时候可以检测一下板卡是否存在
 iResult:=MT_Check();
 if(iResult=R_OK)then
  begin
    ShowMessage('检测到板卡');
  end
 else
  begin
    ShowMessage('未检测到板卡');
  end; 
end;

procedure TMainFrm.btn_CloseUARTClick(Sender: TObject);
begin
 MT_Close_UART;
end;

procedure TMainFrm.btn_CloseUSBClick(Sender: TObject);
begin
 // MT_Close_USB;
end;

procedure TMainFrm.btn_Move_AbsClick(Sender: TObject);
var
 iNum:Integer;
 ID:Word;
begin
 ID:=StrToInt(edt_Axis.Text);
 iNum:=StrToInt(edt_Abs.Text);
 MT_Set_Axis_Position_P_Target_Abs(ID,iNum);
end;

procedure TMainFrm.btn_Move_RelClick(Sender: TObject);
var
 iNum:Integer;
 ID:Word;
begin
 ID:=StrToInt(edt_Axis.Text);
 iNum:=StrToInt(edt_Abs.Text);
 MT_Set_Axis_Position_P_Target_Rel(ID,iNum);

end;

procedure TMainFrm.btn_OpenClick(Sender: TObject);
begin
//串口和USB根据情况选择
  MT_Open_UART(PChar(edt_COM.Text));
end;

procedure TMainFrm.btn_OpenUSBClick(Sender: TObject);
begin
//串口和USB根据情况选择
//  MT_Open_USB;
end;

procedure TMainFrm.btn_SetClick(Sender: TObject);
var
 ID:Word;
 V,Acc,Dec:Integer;
begin
  //读取轴序号
  ID:=StrToInt(edt_Axis.Text);
 //读取参数
  V:=StrToInt(edt_V.Text);
  Acc:=StrToInt(edt_ACC.Text);
  Dec:=StrToInt(edt_Dec.Text);
 //设置加速度
  MT_Set_Axis_Acc(ID,Acc);
 //设置减速度
  MT_Set_Axis_Dec(ID,Dec);
 //设置位置模式
 // 每个轴默认为位置模式，需要来回切换模式需要调用
 //不切换模式可以不调用
  MT_Set_Axis_Mode_Position(ID);
  //设置位置模式速度
  MT_Set_Axis_Position_V_Max(ID,V);
  ShowMessage('ok');


end;

procedure TMainFrm.chk_ContinueClick(Sender: TObject);
begin
//控制连续工作模式, 连续工作模式可以根据需要任意实现
 iStage:=0;
 tmr_Continue.Enabled:=chk_Continue.Checked;
end;

procedure TMainFrm.chk_Continue_LineClick(Sender: TObject);
begin
iLineCircle:=0;
tmr_LineCircle.Enabled:=chk_Continue_Line.Checked;
end;

procedure TMainFrm.chk_ReadClick(Sender: TObject);
begin
//控制状态读取寄存器
 tmr_Read.Enabled:=chk_Read.Checked;
end;

procedure TMainFrm.FormCreate(Sender: TObject);
begin
//申请资源,使用任何其它函数前必须执行本函数
 MT_Init;
end;

procedure TMainFrm.FormDestroy(Sender: TObject);
begin
 MT_DeInit;
end;

procedure TMainFrm.tmr_ContinueTimer(Sender: TObject);
var
 iRun,iMode,iDir,iNeg,iPos,iZero:Byte;
begin
//根据不同的步骤，执行不同的动作
  case iStage of
    0://设置参数
    begin
     //第一轴参数
      MT_Set_Axis_Acc(0,2000);
      MT_Set_Axis_Dec(0,2000);
      MT_Set_Axis_Position_V_Max(0,2000);
     //第二轴参数
      MT_Set_Axis_Acc(1,2000);
      MT_Set_Axis_Dec(1,2000);
      MT_Set_Axis_Position_V_Max(1,2000);
      //进入第二步
      iStage:=1;     
    end;
    1:  //启动第一轴
    begin
      MT_Set_Axis_Position_P_Target_Rel(0,10000);
      iStage:=2;
    end;
    2://等待第一轴执行完毕
    begin
     MT_Get_Axis_Status(0,@iRun,@iDir,@iNeg,@iPos,@iZero,@iMode);
     if(iRun=0)then
      begin
        iStage:=3;
      end;
    end;
    3:  //启动第二轴
    begin
      MT_Set_Axis_Position_P_Target_Rel(1,10000);
      iStage:=4;
    end;
    4://等待第二轴执行完毕
    begin
     MT_Get_Axis_Status(1,@iRun,@iDir,@iNeg,@iPos,@iZero,@iMode);
     if(iRun=0)then
      begin
        iStage:=5;
      end;
    end;
    5:  //第一轴返回
    begin
      MT_Set_Axis_Position_P_Target_Rel(0,-10000);
      iStage:=6;
    end;
    6://等待第一轴执行完毕
    begin
     MT_Get_Axis_Status(0,@iRun,@iDir,@iNeg,@iPos,@iZero,@iMode);
     if(iRun=0)then
      begin
        iStage:=7;
      end;
    end;
    7:  //返回第二轴
    begin
      MT_Set_Axis_Position_P_Target_Rel(1,-10000);
      iStage:=8;
    end;
    8://等待第二轴执行完毕
    begin
     MT_Get_Axis_Status(1,@iRun,@iDir,@iNeg,@iPos,@iZero,@iMode);
     if(iRun=0)then
      begin
       //从头开始下一个循环
        iStage:=1;
      end;
    end;
  end;
end;

procedure TMainFrm.tmr_LineCircleTimer(Sender: TObject);
var
 iRun:Integer;
begin
//根据不同的步骤，执行不同的动作
//走直线正方形，走一个三角形，再走一个圆
  case iLineCircle of
    0://设置参数
    begin
      //直线插补轴
      MT_Set_Axis_Line_Axis(0,0,1);
     //直线插补参数
      MT_Set_Axis_Line_Acc(0,2000);
      MT_Set_Axis_Line_Dec(0,2000);
      MT_Set_Axis_Line_V(0,2000);    
      //进入第二步
      iLineCircle:=1;     
    end;
    1:  //正方形第1边
    begin
      MT_Set_Axis_Line_Run_Rel(0,10000,0);
      iLineCircle:=2;
    end;
    2://等待执行完毕
    begin
     MT_Get_Axis_Line_Status(0,@iRun);
     if(iRun=0)then
      begin
        iLineCircle:=3;
      end;
    end;
    3:  //正方形第2边
    begin
      MT_Set_Axis_Line_Run_Rel(0,0,10000);
      iLineCircle:=4;
    end;
    4://等待执行完毕
    begin
     MT_Get_Axis_Line_Status(0,@iRun);
     if(iRun=0)then
      begin
        iLineCircle:=5;
      end;
    end;
    5:  //正方形第3边
    begin
      MT_Set_Axis_Line_Run_Rel(0,-10000,0);
      iLineCircle:=6;
    end;
    6://等待执行完毕
    begin
     MT_Get_Axis_Line_Status(0,@iRun);
     if(iRun=0)then
      begin
        iLineCircle:=7;
      end;
    end;
    7:  //正方形第4边
    begin
      MT_Set_Axis_Line_Run_Rel(0,0,-10000);
      iLineCircle:=8;
    end;
    8://等待执行完毕
    begin
     MT_Get_Axis_Line_Status(0,@iRun);
     if(iRun=0)then
      begin
        iLineCircle:=9;
      end;
    end;
    9:  //三形第1边
    begin
      MT_Set_Axis_Line_Run_Rel(0,10000,0);
      iLineCircle:=10;
    end;
    10://等待执行完毕
    begin
     MT_Get_Axis_Line_Status(0,@iRun);
     if(iRun=0)then
      begin
        iLineCircle:=11;
      end;
    end;
    11:  //三角形第2边
    begin
      MT_Set_Axis_Line_Run_Rel(0,0,10000);
      iLineCircle:=12;
    end;
    12://等待执行完毕
    begin
     MT_Get_Axis_Line_Status(0,@iRun);
     if(iRun=0)then
      begin
        iLineCircle:=13;
      end;
    end;
    13:  //三角形第3边
    begin
      MT_Set_Axis_Line_Run_Rel(0,-10000,-10000);
      iLineCircle:=14;
    end;
    14://等待执行完毕
    begin
     MT_Get_Axis_Line_Status(0,@iRun);
     if(iRun=0)then
      begin
        iLineCircle:=15;
      end;
    end;
    15://设置参数
    begin
      //圆弧插补轴
      MT_Set_Axis_Circle_Axis(0,0,1);
     //圆弧插补参数
      MT_Set_Axis_Circle_Acc(0,2000);
      MT_Set_Axis_Circle_Dec(0,2000);
      MT_Set_Axis_Circle_V(0,2000);    
      //进入第二步
      iLineCircle:=16;     
    end;
    16:  //启动顺时针圆 半径为20000
    begin
      MT_Set_Axis_Circle_R_CW_Run_Rel(0,20000,0,0);
      iLineCircle:=17;
    end;
    17://等待执行完毕
    begin
     MT_Get_Axis_Circle_Status(0,@iRun);
     if(iRun=0)then
      begin
        iLineCircle:=0;
      end;
    end; 
  end;

end;

procedure TMainFrm.tmr_ReadTimer(Sender: TObject);
var
 iRun,iDir,iMode,iNeg,iPos,iZero:Byte;
 ID:Word;
 iV,iP:Integer;
begin
 //读取当前状态
 ID:=StrToInt(edt_Axis.Text);
 MT_Get_Axis_Status(ID,@iRun,@iDir,@iNeg,@iPos,@iZero,@iMode);
 //运行状态
 chk_Run.Checked:=iRun>0;
 //负限位
 chk_Neg.Checked:=iNeg>0;
 //正限位
 chk_Pos.Checked:=iPos>0;
 //零位
 chk_Zero.Checked:=iZero>0;

 //读取当前速度
 MT_Get_Axis_V_Now(ID,@iV);
 edt_V_Now.Text:=IntToStr(iV);
 //读取当前位置
 MT_Get_Axis_Software_P_Now(ID,@iP);
 edt_P_Now.Text:=IntToStr(iP);
 
end;

end.
