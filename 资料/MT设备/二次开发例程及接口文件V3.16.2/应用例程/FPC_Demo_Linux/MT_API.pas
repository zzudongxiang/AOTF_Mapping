unit MT_API;

{$IFDEF FPC}
  {$MODE Delphi}
{$ENDIF}


//**************************************************//
// Easy tech copyright
//**************************************************//
interface

{$IFDEF WINDOWS}
   const API_NAME='MT_API.dll';
{$ENDIF}

{$IFDEF LINUX}
  const API_NAME='mt_api.so';
{$ENDIF}

//==================================================
//运行环境
//===================================================
//dll版本
//初始化窗口
function MT_Init():Integer;stdcall;external API_NAME ;
//关闭窗口
function MT_DeInit():Integer;stdcall;external API_NAME ;
//获取dll版本号
function MT_Get_Dll_Version(sVer:PPChar):Integer;stdcall;external API_NAME ;



//======================================================
//通信口
//======================================================
//打开 UART
function MT_Open_UART(sCOM:PAnsiChar):Integer;stdcall;external API_NAME ;
//关闭 UART
function MT_Close_UART():Integer;stdcall;external API_NAME ;
//打开USB
function MT_Open_USB:Integer;stdcall;external API_NAME ;
//关闭USB
function MT_Close_USB:Integer;stdcall;external API_NAME ;

//打开网口
function MT_Open_Net(IP0,IP1,IP2,IP3:Byte;IPPort:Word):Integer;stdcall;external API_NAME ;
//关闭网口
function MT_Close_Net():Integer;stdcall;external API_NAME ;

//=====================================================
//板卡检测
//=====================================================
//检测设备
function MT_Check():Integer;stdcall;external API_NAME ;
//读取资源模块
function MT_Get_Product_Resource(pValue:PInteger):Integer;stdcall;external API_NAME ;
//获取ID
function MT_Get_Product_ID(sID:PAnsiChar):Integer;stdcall;external API_NAME ;
//获取SN
function MT_Get_Product_SN(sSN:PAnsiChar):Integer;stdcall;external API_NAME ;
//读取固件版本号
function MT_Get_Product_Version(pMajor:PInteger;pMinor:PInteger):Integer;stdcall;external API_NAME ;
//===================================================================
//板卡温度
//===================================================================
//获取温度
//function MT_Get_Board_Temperature(pValue:PDouble):Integer;stdcall;external API_NAME ;

//===================================================================
//电机相关
//====================================================================
//轴数
function MT_Get_Axis_Num(pValue:PInteger):Integer;stdcall;external API_NAME ;
//读取加速度
function MT_Get_Axis_Acc(AObj:Word;pValue:PInteger):Integer;stdcall;external API_NAME ;
//设置加速度
function MT_Set_Axis_Acc(AObj:Word;Value:Integer):Integer;stdcall;external API_NAME ;
//读取加速度
function MT_Get_Axis_Dec(AObj:Word;pValue:PInteger):Integer;stdcall;external API_NAME ;
//设置加速度
function MT_Set_Axis_Dec(AObj:Word;Value:Integer):Integer;stdcall;external API_NAME ;
//读取工作模式
function MT_Get_Axis_Mode(AObj:Word;pValue:PInteger):Integer;stdcall;external API_NAME ;
//设置速度模式
function MT_Set_Axis_Mode_Velocity(AObj:Word):Integer;stdcall;external API_NAME ;
//设置位置模式
function MT_Set_Axis_Mode_Position(AObj:Word):Integer;stdcall;external API_NAME ;
//读取速度模式目标速度
function MT_Get_Axis_Velocity_V_Target(AObj:Word;pValue:PInteger):Integer;stdcall;external API_NAME ;
//设置速度模式目标速度
function MT_Set_Axis_Velocity_V_Target_Abs(AObj:Word;Value:Integer):Integer;stdcall;external API_NAME ;
//设置速度模式目标速度
function MT_Set_Axis_Velocity_V_Target_Rel(AObj:Word;Value:Integer):Integer;stdcall;external API_NAME ;
//停止速度模式
function MT_Set_Axis_Velocity_Stop(AObj:Word):Integer;stdcall;external API_NAME ;

//读取位置模式最大速度
function MT_Get_Axis_Position_V_Max(AObj:Word;pValue:PInteger):Integer;stdcall;external API_NAME ;
//设置位置模式最大速度
function MT_Set_Axis_Position_V_Max(AObj:Word;Value:Integer):Integer;stdcall;external API_NAME ;
//读取位置模式目标
function MT_Get_Axis_Position_P_Target(AObj:Word;pValue:PInteger):Integer;stdcall;external API_NAME ;
//设置位置模式目标
function MT_Set_Axis_Position_P_Target_Abs(AObj:Word;Value:Integer):Integer;stdcall;external API_NAME ;
function MT_Set_Axis_Position_P_Target_Rel(AObj:Word;Value:Integer):Integer;stdcall;external API_NAME ;
//停止位置模式
function MT_Set_Axis_Position_Stop(AObj:Word):Integer;stdcall;external API_NAME ;
//紧急停止
function MT_Set_Axis_Halt(AObj:Word):Integer;stdcall;external API_NAME ;
function MT_Set_Axis_Halt_All():Integer;stdcall;external API_NAME ;

//////////////////////////////////////////////////////////////
///  状态相关
///  //////////////////////////////////////////////////////
//读取当前速度
function MT_Get_Axis_V_Now(AObj:Word;pValue:PInteger):Integer;stdcall;external API_NAME ;
//读取当前软件位置
function MT_Get_Axis_Software_P_Now(AObj:Word;pValue:PInteger):Integer;stdcall;external API_NAME ;
function MT_Set_Axis_Software_P(AObj:Word;Value:Integer):Integer;stdcall;external API_NAME ;
function MT_Get_Axis_Status(AObj:Word;
            pRun:PByte;
            pDir:PByte;
            pNeg:PByte;
            pPos:PByte;
            pZero:PByte;
            pMode:PByte):Integer;stdcall;external API_NAME ;
////////////////////////////////////////////////////////////////////////
//存储器
//读取存储器长度
function MT_Get_Param_Mem_Len(pValue:PInteger):Integer;stdcall;external API_NAME ;
//读取存储器数据
function MT_Get_Param_Mem_Data(AObj:Word;pValue:PByte):Integer;stdcall;external API_NAME ;
//设置存储器数据
function MT_Set_Param_Mem_Data(AObj:Word;Value:Byte):Integer;stdcall;external API_NAME ;
//光隔输入
function MT_Get_Optic_In_Num(pValue:PInteger):Integer;stdcall;external API_NAME ;
function MT_Get_Optic_In_Single(AObj:Word;pValue:PInteger):Integer;stdcall;external API_NAME ;
function MT_Get_Optic_In_All(pValue:PInteger):Integer;stdcall;external API_NAME ;
//光隔输出
function MT_Get_Optic_Out_Num(pValue:PInteger):Integer;stdcall;external API_NAME ;
function MT_Set_Optic_Out_Single(AObj:Word;Value:Integer):Integer;stdcall;external API_NAME ;
function MT_Set_Optic_Out_All(Value:Integer):Integer;stdcall;external API_NAME ;
//OC输出
function MT_Get_OC_Out_Num(pValue:PInteger):Integer;stdcall;external API_NAME ;
function MT_Set_OC_Out_Single(AObj:Word;Value:Integer):Integer;stdcall;external API_NAME ;
function MT_Set_OC_Out_All(Value:Integer):Integer;stdcall;external API_NAME ;
//设置0位模式
function MT_Set_Axis_Mode_Home(AObj:Word):Integer;stdcall;external API_NAME ;
//设置0位模式目标速度
function MT_Set_Axis_Home_V(AObj:Word;Value:Integer):Integer;stdcall;external API_NAME ;
//停止0位模式
function MT_Set_Axis_Home_Stop(AObj:Word):Integer;stdcall;external API_NAME ;


//软件限位
//设置软件限位值
function MT_Set_Axis_Software_Limit_Neg_Value
   (AObj:Word;Value:Integer):Integer;stdcall; external API_NAME ;
//设置软件限位值
function MT_Set_Axis_Software_Limit_Pos_Value
   (AObj:Word;Value:Integer):Integer;stdcall;external API_NAME ;
//使能软件限位模式
function MT_Set_Axis_Software_Limit_Enable(AObj:Word):Integer;stdcall;external API_NAME ;
//停止软件限位模式
function MT_Set_Axis_Software_Limit_Disable(AObj:Word):Integer;stdcall;external API_NAME ;
//直线插补相关
//设置直线插补主轴及速度
function MT_Set_Axis_Line_Axis(AObj:Word;Axis_ID0,Axis_ID1:Integer):Integer;stdcall;external API_NAME ;
//设置直线插补加速度
function MT_Set_Axis_Line_Acc(AObj:Word;Value:Integer):Integer;stdcall;external API_NAME ;
//设置直线插补减速度
function MT_Set_Axis_Line_Dec(AObj:Word;Value:Integer):Integer;stdcall;external API_NAME ;
//设置直线插补速度
function MT_Set_Axis_Line_V(AObj:Word;Value:Integer):Integer;stdcall;external API_NAME ;
//设置直线插补启动
function MT_Set_Axis_Line_Run(AObj:Word):Integer;stdcall;external API_NAME ;
//设置直线插补停止
function MT_Set_Axis_Line_Stop(AObj:Word):Integer;stdcall;external API_NAME ;
//设置直线插补急停
function MT_Set_Axis_Line_Halt(AObj:Word):Integer;stdcall;external API_NAME ;
//设置直线插补相对移动目标
function MT_Set_Axis_Line_Rel(AObj:Word;
    Axis_Target0,Axis_Target1:Integer):Integer;stdcall;external API_NAME ;
//设置直线插补绝对移动目标
function MT_Set_Axis_Line_Abs(AObj:Word;
    Axis_Target0,Axis_Target1:Integer):Integer;stdcall;external API_NAME ;
//设置直线插补启动
function MT_Set_Axis_Line_Run_Rel(AObj:Word;
    Axis_Target0,Axis_Target1:Integer):Integer;stdcall;external API_NAME ;
function MT_Set_Axis_Line_Run_Abs(AObj:Word;
    Axis_Target0,Axis_Target1:Integer):Integer;stdcall;external API_NAME ;
//读取直线插补模块
function MT_Get_Axis_Line_Num(pValue:PInteger):Integer;stdcall;external API_NAME ;
//插补运动状态
function MT_Get_Axis_Line_Status(AObj:Word;pValue:PInteger):Integer;stdcall;external API_NAME ;
//插补轴
function MT_Get_Axis_Line_Axis(AObj:Word;pID0,pID1:PInteger):Integer;stdcall;external API_NAME ;
//插补加速度
function MT_Get_Axis_Line_Acc(AObj:Word;pValue:PInteger):Integer;stdcall;external API_NAME ;
//插补减速度
function MT_Get_Axis_Line_Dec(AObj:Word;pValue:PInteger):Integer;stdcall;external API_NAME ;
//插补速度
function MT_Get_Axis_Line_V(AObj:Word;pValue:PInteger):Integer;stdcall;external API_NAME ;

//AD输入
function MT_Get_AD_Num(pValue:PInteger):Integer;stdcall;external API_NAME ;
function MT_Get_AD_Data(AObj:Word;pValue:PInteger):Integer;stdcall;external API_NAME ;
function MT_Get_Board_T(pValue:PInteger):Integer;stdcall;external API_NAME ;

//================================================================
//圆弧插补
//================================================================
//设置圆弧插补主轴及速度
function MT_Set_Axis_Circle_Axis(AObj:Word;Axis_ID0,Axis_ID1:Integer):Integer;stdcall;external API_NAME ;
//设置圆弧插补加速度
function MT_Set_Axis_Circle_Acc(AObj:Word;Value:Integer):Integer;stdcall;external API_NAME ;
//设置圆弧插补减速度
function MT_Set_Axis_Circle_Dec(AObj:Word;Value:Integer):Integer;stdcall;external API_NAME ;
//设置圆弧插补速度
function MT_Set_Axis_Circle_V(AObj:Word;Value:Integer):Integer;stdcall;external API_NAME ;

//设置圆弧插补启动 顺时钟  圆心坐标模式
function MT_Set_Axis_Circle_R_CW_Run_Rel(AObj:Word;AR:Integer;
                  Axis_Target0,Axis_Target1:Integer):Integer;stdcall;external API_NAME ;
function MT_Set_Axis_Circle_R_CW_Run_Abs(AObj:Word;AR:Integer;
                  Axis_Target0,Axis_Target1:Integer):Integer;stdcall;external API_NAME ;
//设置圆弧插补启动 逆时钟   圆心坐标
function MT_Set_Axis_Circle_R_CCW_Run_Rel(AObj:Word;AR:Integer;
                  Axis_Target0,Axis_Target1:Integer):Integer;stdcall;external API_NAME ;
function MT_Set_Axis_Circle_R_CCW_Run_Abs(AObj:Word;AR:Integer;
                  Axis_Target0,Axis_Target1:Integer):Integer;stdcall;external API_NAME ;
//设置圆弧插补停止
function MT_Set_Axis_Circle_Stop(AObj:Word):Integer;stdcall;external API_NAME ;
//设置圆弧插补急停
function MT_Set_Axis_Circle_Halt(AObj:Word):Integer;stdcall;external API_NAME ;

//读取圆弧插补模块
function MT_Get_Axis_Circle_Num(pValue:PInteger):Integer;stdcall;external API_NAME ;
//插补运动状态
function MT_Get_Axis_Circle_Status(AObj:Word;pValue:PInteger):Integer;stdcall;external API_NAME ;
//插补轴
function MT_Get_Axis_Circle_Axis(AObj:Word;pID0,pID1:PInteger):Integer;stdcall;external API_NAME ;
//插补加速度
function MT_Get_Axis_Circle_Acc(AObj:Word;pValue:PInteger):Integer;stdcall;external API_NAME ;
//插补减速度
function MT_Get_Axis_Circle_Dec(AObj:Word;pValue:PInteger):Integer;stdcall;external API_NAME ;
//插补速度
function MT_Get_Axis_Circle_V(AObj:Word;pValue:PInteger):Integer;stdcall;external API_NAME ;



  const R_OK =0;
  const R_Error=-1;
  const RUN_OFF=0;
  const RUN_ON=1;
  const DIR_NEG=0;
  const DIR_POS=1;
  const LIMIT_ON=1;
  const LIMIT_OFF=0;

//定义内部资源类型
const RESOURCE_MOTOR        =$00000001;   //电机
const RESOURCE_TTL_IN       =$00000002;   //TTL输入
const RESOURCE_TTL_OUT      =$00000004;   //TTL输出
const RESOURCE_OPTIC_IN     =$00000008;   //光隔输入
const RESOURCE_OPTIC_OUT    =$00000010;   //光隔输出
const RESOURCE_AD           =$00000020;   //AD输入
const RESOURCE_OC           =$00000040;   //OC输出
const RESOURCE_LINE         =$00000080;   //直线插补
const RESOURCE_CIRCLE       =$00000100;   //圆弧插补

implementation

end.
