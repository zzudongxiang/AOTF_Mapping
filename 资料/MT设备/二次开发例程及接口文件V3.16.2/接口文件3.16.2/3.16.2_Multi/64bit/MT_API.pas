unit MT_API;
//**************************************************//
// V3.16.0 updated 2017-01-30
//**************************************************//
interface
//==================================================
//运行环境
//===================================================
//dll版本
//初始化窗口
function MT_Init():Integer;stdcall;external 'MT_API.dll'
//关闭窗口
function MT_DeInit():Integer;stdcall;external 'MT_API.dll'
//获取dll版本号
function MT_Get_Dll_Version(sVer:PPChar):Integer;stdcall;external 'MT_API.dll'

function MT_Set_Thread_Timeout(ms:Cardinal):Integer;stdcall;external 'MT_API.dll'

//======================================================
//通信口
//======================================================
//打开 UART
function MT_Open_UART(ADev:Integer;sCOM:PAnsiChar):Integer;stdcall;external 'MT_API.dll'
function MT_Open_UART_Unicode(ADev:Integer;sCOM:PChar):Integer;stdcall;external 'MT_API.dll'
//关闭 UART
function MT_Close_UART(ADev:Integer):Integer;stdcall;external 'MT_API.dll'

//打开USB
function MT_Open_USB(ADev:Integer):Integer;stdcall;external 'MT_API.dll'
//关闭USB
function MT_Close_USB(ADev:Integer):Integer;stdcall;external 'MT_API.dll'

//打开网口
function MT_Open_Net(ADev:Integer;IP0,IP1,IP2,IP3:Byte;IPPort:Word):Integer;stdcall;external 'MT_API.dll'
//关闭网口
function MT_Close_Net(ADev:Integer):Integer;stdcall;external 'MT_API.dll'

//=====================================================
//板卡检测
//=====================================================
//检测设备
function MT_Check(ADev:Integer):Integer;stdcall;external 'MT_API.dll'
//读取资源模块
function MT_Get_Product_Resource(ADev:Integer;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//获取ID
function MT_Get_Product_ID(ADev:Integer;sID:PAnsiChar):Integer;stdcall;external 'MT_API.dll'
//获取SN
function MT_Get_Product_SN(ADev:Integer;sSN:PAnsiChar):Integer;stdcall;external 'MT_API.dll'
function MT_Get_Product_SN2(ADev:Integer;sSN:PByte):Integer;stdcall;external 'MT_API.dll'
function MT_Get_Product_SN3(ADev:Integer;sSN:PAnsiChar):Integer;stdcall;external 'MT_API.dll'
//读取固件版本号
function MT_Get_Product_Version(ADev:Integer;pMajor:PInteger;pMinor:PInteger):Integer;stdcall;external 'MT_API.dll'
function MT_Get_Product_Version2(ADev:Integer;pMajor:PInteger;pMinor:PInteger;
   pRelease:PInteger;pBuild:PInteger):Integer;stdcall;external 'MT_API.dll'
//===================================================================
//板卡温度
//===================================================================
//获取温度
//function MT_Get_Board_Temperature(pValue:PDouble):Integer;stdcall;external 'MT_API.dll'

//===================================================================
//电机相关
//====================================================================
//轴数
function MT_Get_Axis_Num(ADev:Integer;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//读取加速度
function MT_Get_Axis_Acc(ADev:Integer;AObj:Word;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//设置加速度
function MT_Set_Axis_Acc(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//读取加速度
function MT_Get_Axis_Dec(ADev:Integer;AObj:Word;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//设置加速度
function MT_Set_Axis_Dec(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//读取工作模式
function MT_Get_Axis_Mode(ADev:Integer;AObj:Word;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//设置速度模式
function MT_Set_Axis_Mode_Velocity(ADev:Integer;AObj:Word):Integer;stdcall;external 'MT_API.dll'
//设置位置模式
function MT_Set_Axis_Mode_Position(ADev:Integer;AObj:Word):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Axis_Mode_Position_Open(ADev:Integer;AObj:Word):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Axis_Mode_Position_Close(ADev:Integer;AObj:Word):Integer;stdcall;external 'MT_API.dll'
//读取速度模式目标速度
function MT_Get_Axis_Velocity_V_Target(ADev:Integer;AObj:Word;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//设置速度模式目标速度
function MT_Set_Axis_Velocity_V_Target_Abs(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//设置速度模式目标速度
function MT_Set_Axis_Velocity_V_Target_Rel(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//停止速度模式
function MT_Set_Axis_Velocity_Stop(ADev:Integer;AObj:Word):Integer;stdcall;external 'MT_API.dll'

//读取位置模式最大速度
function MT_Get_Axis_Position_V_Max(ADev:Integer;AObj:Word;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//设置位置模式最大速度
function MT_Set_Axis_Position_V_Max(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//读取位置模式目标
function MT_Get_Axis_Position_P_Target(ADev:Integer;AObj:Word;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//设置位置模式目标
function MT_Set_Axis_Position_P_Target_Abs(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Axis_Position_P_Target_Rel(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//停止位置模式
function MT_Set_Axis_Position_Stop(ADev:Integer;AObj:Word):Integer;stdcall;external 'MT_API.dll'
//设置编码器比例,用在减速判断上
function MT_Set_Axis_Position_Close_Dec_Factor(ADev:Integer;AObj:Word;AFactor:Single):Integer;stdcall;external 'MT_API.dll'

//紧急停止
function MT_Set_Axis_Halt(ADev:Integer;AObj:Word):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Axis_Halt_All(ADev:Integer):Integer;stdcall;external 'MT_API.dll'

//////////////////////////////////////////////////////////////
///  状态相关
///  //////////////////////////////////////////////////////
//读取当前速度
function MT_Get_Axis_V_Now(ADev:Integer;AObj:Word;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//读取当前软件位置
function MT_Get_Axis_Software_P_Now(ADev:Integer;AObj:Word;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Axis_Software_P(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
function MT_Get_Axis_Status(ADev:Integer;AObj:Word;
            pRun:PByte;
            pDir:PByte;
            pNeg:PByte;
            pPos:PByte;
            pZero:PByte;
            pMode:PByte):Integer;stdcall;external 'MT_API.dll'
function MT_Get_Axis_Status2(ADev:Integer;AObj:Word;
            pRun:PInteger;
            pDir:PInteger;
            pNeg:PInteger;
            pPos:PInteger;
            pZero:PInteger;
            pMode:PInteger):Integer;stdcall;external 'MT_API.dll'
function MT_Get_Axis_Status_Run(ADev:Integer;AObj:Word;
            pRun:PInteger):Integer;stdcall;external 'MT_API.dll'
function MT_Get_Axis_Status_Dir(ADev:Integer;AObj:Word;
            pDir:PInteger):Integer;stdcall;external 'MT_API.dll'
function MT_Get_Axis_Status_Neg(ADev:Integer;AObj:Word;
            pNeg:PInteger):Integer;stdcall;external 'MT_API.dll'
function MT_Get_Axis_Status_Pos(ADev:Integer;AObj:Word;
            pPos:PInteger):Integer;stdcall;external 'MT_API.dll'
function MT_Get_Axis_Status_Zero(ADev:Integer;AObj:Word;
            pZero:PInteger):Integer;stdcall;external 'MT_API.dll'
function MT_Get_Axis_Status_Mode(ADev:Integer;AObj:Word;
            pMode:PInteger):Integer;stdcall;external 'MT_API.dll'
////////////////////////////////////////////////////////////////////////
//存储器
//读取存储器长度
function MT_Get_Param_Mem_Len(ADev:Integer;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//读取存储器数据
function MT_Get_Param_Mem_Data(ADev:Integer;AObj:Word;pValue:PByte):Integer;stdcall;external 'MT_API.dll'
//设置存储器数据
function MT_Set_Param_Mem_Data(ADev:Integer;AObj:Word;Value:Byte):Integer;stdcall;external 'MT_API.dll'
////////////////////////////////////////////////////////////////////////
//系统存储器
//读取存储器长度
function MT_Get_System_Mem_Len(ADev:Integer;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//读取存储器数据
function MT_Get_System_Mem_Data(ADev:Integer;AObj:Word;pValue:PByte):Integer;stdcall;external 'MT_API.dll'
//设置存储器数据
function MT_Set_System_Mem_Data(ADev:Integer;AObj:Word;Value:Byte):Integer;stdcall;external 'MT_API.dll'
//光隔输入
function MT_Get_Optic_In_Num(ADev:Integer;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
function MT_Get_Optic_In_Basic_Num(ADev:Integer;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
function MT_Get_Optic_In_Single(ADev:Integer;AObj:Word;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
function MT_Get_Optic_In_All(ADev:Integer;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//光隔输出
function MT_Get_Optic_Out_Num(ADev:Integer;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Optic_Out_Single(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Optic_Out_All(ADev:Integer;Value:Integer):Integer;stdcall;external 'MT_API.dll'
function MT_Get_Optic_Out_Single(ADev:Integer;AObj:Word;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
function MT_Get_Optic_Out_All(ADev:Integer;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//OC输出
function MT_Get_OC_Out_Num(ADev:Integer;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
function MT_Set_OC_Out_Single(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
function MT_Set_OC_Out_All(ADev:Integer;Value:Integer):Integer;stdcall;external 'MT_API.dll'
function MT_Get_OC_Out_Single(ADev:Integer;AObj:Word;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
function MT_Get_OC_Out_All(ADev:Integer;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//设置0位模式
function MT_Set_Axis_Mode_Home(ADev:Integer;AObj:Word):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Axis_Mode_Home_Home_Switch(ADev:Integer;AObj:Word):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Axis_Mode_Home_Encoder_Index(ADev:Integer;AObj:Word):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Axis_Mode_Home_Encoder_Home_Switch(ADev:Integer;AObj:Word):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Axis_Mode_Home_Home_Zero(ADev:Integer;AObj:Word):Integer;stdcall;external 'MT_API.dll'
//设置0位模式目标速度
function MT_Set_Axis_Home_V(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//停止0位模式
function MT_Set_Axis_Home_Stop(ADev:Integer;AObj:Word):Integer;stdcall;external 'MT_API.dll'


//软件限位
//设置软件限位值
function MT_Set_Axis_Software_Limit_Neg_Value
   (ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall; external 'MT_API.dll'
//设置软件限位值
function MT_Set_Axis_Software_Limit_Pos_Value
   (ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//使能软件限位模式
function MT_Set_Axis_Software_Limit_Enable(ADev:Integer;AObj:Word):Integer;stdcall;external 'MT_API.dll'
//停止软件限位模式
function MT_Set_Axis_Software_Limit_Disable(ADev:Integer;AObj:Word):Integer;stdcall;external 'MT_API.dll'
//直线插补相关
//设置直线插补主轴及速度
function MT_Set_Axis_Line_Axis(ADev:Integer;AObj:Word;Axis_ID0,Axis_ID1:Integer):Integer;stdcall;external 'MT_API.dll'
//设置直线插补加速度
function MT_Set_Axis_Line_Acc(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//设置直线插补减速度
function MT_Set_Axis_Line_Dec(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//设置直线插补速度
function MT_Set_Axis_Line_V(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//设置直线插补启动
function MT_Set_Axis_Line_Run(ADev:Integer;AObj:Word):Integer;stdcall;external 'MT_API.dll'
//设置直线插补停止
function MT_Set_Axis_Line_Stop(ADev:Integer;AObj:Word):Integer;stdcall;external 'MT_API.dll'
//设置直线插补急停
function MT_Set_Axis_Line_Halt(ADev:Integer;AObj:Word):Integer;stdcall;external 'MT_API.dll'
//设置直线插补相对移动目标
function MT_Set_Axis_Line_Rel(ADev:Integer;AObj:Word;
    Axis_Target0,Axis_Target1:Integer):Integer;stdcall;external 'MT_API.dll'
//设置直线插补绝对移动目标
function MT_Set_Axis_Line_Abs(ADev:Integer;AObj:Word;
    Axis_Target0,Axis_Target1:Integer):Integer;stdcall;external 'MT_API.dll'
//设置直线插补启动
function MT_Set_Axis_Line_Run_Rel(ADev:Integer;AObj:Word;
    Axis_Target0,Axis_Target1:Integer):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Axis_Line_Run_Abs(ADev:Integer;AObj:Word;
    Axis_Target0,Axis_Target1:Integer):Integer;stdcall;external 'MT_API.dll'
//读取直线插补模块
function MT_Get_Axis_Line_Num(ADev:Integer;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//插补运动状态
function MT_Get_Axis_Line_Status(ADev:Integer;AObj:Word;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//插补轴
function MT_Get_Axis_Line_Axis(ADev:Integer;AObj:Word;pID0,pID1:PInteger):Integer;stdcall;external 'MT_API.dll'
//插补加速度
function MT_Get_Axis_Line_Acc(ADev:Integer;AObj:Word;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//插补减速度
function MT_Get_Axis_Line_Dec(ADev:Integer;AObj:Word;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//插补速度
function MT_Get_Axis_Line_V(ADev:Integer;AObj:Word;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'

//AD输入
function MT_Get_AD_Num(ADev:Integer;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
function MT_Get_AD_Data(ADev:Integer;AObj:Word;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
function MT_Get_Board_T(ADev:Integer;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'

//================================================================
//圆弧插补
//================================================================
//设置圆弧插补主轴及速度
function MT_Set_Axis_Circle_Axis(ADev:Integer;AObj:Word;Axis_ID0,Axis_ID1:Integer):Integer;stdcall;external 'MT_API.dll'
//设置圆弧插补加速度
function MT_Set_Axis_Circle_Acc(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//设置圆弧插补减速度
function MT_Set_Axis_Circle_Dec(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//设置圆弧插补速度
function MT_Set_Axis_Circle_V(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'

//设置圆弧插补启动 顺时钟  圆心坐标模式
function MT_Set_Axis_Circle_R_CW_Run_Rel(ADev:Integer;AObj:Word;AR:Integer;
                  Axis_Target0,Axis_Target1:Integer):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Axis_Circle_R_CW_Run_Abs(ADev:Integer;AObj:Word;AR:Integer;
                  Axis_Target0,Axis_Target1:Integer):Integer;stdcall;external 'MT_API.dll'
//设置圆弧插补启动 逆时钟   圆心坐标
function MT_Set_Axis_Circle_R_CCW_Run_Rel(ADev:Integer;AObj:Word;AR:Integer;
                  Axis_Target0,Axis_Target1:Integer):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Axis_Circle_R_CCW_Run_Abs(ADev:Integer;AObj:Word;AR:Integer;
                  Axis_Target0,Axis_Target1:Integer):Integer;stdcall;external 'MT_API.dll'
//设置圆弧插补停止
function MT_Set_Axis_Circle_Stop(ADev:Integer;AObj:Word):Integer;stdcall;external 'MT_API.dll'
//设置圆弧插补急停
function MT_Set_Axis_Circle_Halt(ADev:Integer;AObj:Word):Integer;stdcall;external 'MT_API.dll'

//读取圆弧插补模块
function MT_Get_Axis_Circle_Num(ADev:Integer;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//插补运动状态
function MT_Get_Axis_Circle_Status(ADev:Integer;AObj:Word;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//插补轴
function MT_Get_Axis_Circle_Axis(ADev:Integer;AObj:Word;pID0,pID1:PInteger):Integer;stdcall;external 'MT_API.dll'
//插补加速度
function MT_Get_Axis_Circle_Acc(ADev:Integer;AObj:Word;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//插补减速度
function MT_Get_Axis_Circle_Dec(ADev:Integer;AObj:Word;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//插补速度
function MT_Get_Axis_Circle_V(ADev:Integer;AObj:Word;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'

//PLC相关的函数
//PLC相关的指令码
//读变量存储器大小
function MT_Get_PLC_Var_Num(ADev:Integer;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//读变量
function MT_Get_PLC_Var_Data(ADev:Integer;AObj:Word;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//写变量
function MT_Set_PLC_Var_Data(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//暂停PLC
function MT_Set_PLC_Pause(ADev:Integer):Integer;stdcall;external 'MT_API.dll'
//停止PLC
function MT_Set_PLC_Stop(ADev:Integer):Integer;stdcall;external 'MT_API.dll'
//启动PLC程序
function MT_Set_PLC_Run(ADev:Integer):Integer;stdcall;external 'MT_API.dll'
//设置PLC程序代码
function MT_Set_PLC_Data(ADev:Integer;AObj:Word;Value:Byte):Integer;stdcall;external 'MT_API.dll'
//读取PLC程序代码大小
function MT_Get_PLC_Code_Size(ADev:Integer;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'

//2017 01 30 PLC V6 Add
//读取任务个数
//PLC任务数
function MT_Get_PLC_Task_Count(
  ADev:Integer;
  pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//PLC任务状态
function MT_Get_PLC_Task_Status(
  ADev:Integer;
  pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//变量分割
function MT_Get_PLC_Var_Seg(
  ADev:Integer;
  pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//变量个数
function MT_Get_PLC_Var_Used(
  ADev:Integer;
  pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//PLC状态
function MT_Get_PLC_Status(
  ADev:Integer;
  pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//全局状态
function MT_Get_PLC_Tasks_Status(
  ADev:Integer;
  pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//Axis Ratio
function MT_Get_PLC_Axis_Ratio(
  ADev:Integer;
  pValue:PSingle):Integer;stdcall;external 'MT_API.dll'
function MT_Get_PLC_Encoder_Ratio(
  ADev:Integer;
  pValue:PSingle):Integer;stdcall;external 'MT_API.dll'
//2014 04 09补充定义 增加起始速度修改 增加多轴联动直线插补
function MT_Set_Axis_Home_V_Start(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Axis_Home_Acc(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Axis_Home_Dec(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
function MT_Get_Axis_Home_Acc(ADev:Integer;AObj:Word;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
function MT_Get_Axis_Home_Dec(ADev:Integer;AObj:Word;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'

function MT_Set_Axis_Velocity_V_Start(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Axis_Velocity_Acc(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Axis_Velocity_Dec(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
function MT_Get_Axis_Velocity_Acc(ADev:Integer;AObj:Word;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
function MT_Get_Axis_Velocity_Dec(ADev:Integer;AObj:Word;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'

function MT_Set_Axis_Position_V_Start(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Axis_Position_Acc(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Axis_Position_Dec(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
function MT_Get_Axis_Position_Acc(ADev:Integer;AObj:Word;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
function MT_Get_Axis_Position_Dec(ADev:Integer;AObj:Word;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'

function MT_Set_Axis_Line_V_Start(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Axis_Circle_V_Start(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'

function MT_Set_Axis_Line_X_Run_Rel(ADev:Integer;AObj:Word;
  AAxis_Num:Integer;
  pAxis:PInteger;
  pTarget:PInteger):Integer;stdcall;external 'MT_API.dll'

function MT_Set_Axis_Line_X_Run_Abs(ADev:Integer;AObj:Word;
  AAxis_Num:Integer;
  pAxis:PInteger;
  pTarget:PInteger):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Axis_Line_X_Target_Rel(ADev:Integer;AObj:Word;
  AAxisID:Integer;
  ATarget:Integer):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Axis_Line_X_Target_Abs(ADev:Integer;AObj:Word;
  AAxisID:Integer;
  ATarget:Integer):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Axis_Line_X_Count(ADev:Integer;AObj:Word;
  ANum:Integer):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Axis_Line_X_Axis(ADev:Integer;AObj:Word;
  AAxisID:Integer;
  AAxis:Integer):Integer;stdcall;external 'MT_API.dll'
//流指令模式
//启动Stream
function MT_Set_Stream_Run(ADev:Integer):Integer;stdcall;external 'MT_API.dll'
//停止Stream
function MT_Set_Stream_Stop(ADev:Integer):Integer;stdcall;external 'MT_API.dll'
//暂停Stream
function MT_Set_Stream_Pause(ADev:Integer):Integer;stdcall;external 'MT_API.dll'
//清除Stream
function MT_Set_Stream_Clear(ADev:Integer):Integer;stdcall;external 'MT_API.dll'
//读取剩余空间
function MT_Get_Stream_Space(ADev:Integer;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//读取总空间
function MT_Get_Stream_Total(ADev:Integer;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//读取占用空间
function MT_Get_Stream_Count(ADev:Integer;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'

function MT_Set_Stream_Delay(ADev:Integer;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//直线插补运动
//设置直线插补加速度
function MT_Set_Stream_Line_Acc(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//设置直线插补减速度
function MT_Set_Stream_Line_Dec(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//设置直线插补速度
function MT_Set_Stream_Line_V_Max(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//设置直线插补启动速度
function MT_Set_Stream_Line_V_Start(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//设置直线插补停止
function MT_Set_Stream_Line_Stop(ADev:Integer;AObj:Word):Integer;stdcall;external 'MT_API.dll'
//设置直线插补急停
function MT_Set_Stream_Line_Halt(ADev:Integer;AObj:Word):Integer;stdcall;external 'MT_API.dll'
//启动直线插补
function MT_Set_Stream_Line_X_Run_Rel(ADev:Integer;AObj:Word;
  AAxis_Num:Integer;
  pAxis:PInteger;
  pTarget:PInteger):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Stream_Line_X_Run_Abs(ADev:Integer;AObj:Word;
  AAxis_Num:Integer;
  pAxis:PInteger;
  pTarget:PInteger):Integer;stdcall;external 'MT_API.dll'


//设置圆弧插补主轴及速度
function MT_Set_Stream_Circle_Axis(ADev:Integer;AObj:Word;Axis_ID0,Axis_ID1:Integer):Integer;stdcall;external 'MT_API.dll'
//设置圆弧插补加速度
function MT_Set_Stream_Circle_Acc(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//设置圆弧插补减速度
function MT_Set_Stream_Circle_Dec(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//设置圆弧插补速度
function MT_Set_Stream_Circle_V_Max(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//设置圆弧插补启动速度
function MT_Set_Stream_Circle_V_Start(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//设置圆弧插补启动 顺时钟  圆心坐标模式
function MT_Set_Stream_Circle_R_CW_Run_Rel(ADev:Integer;AObj:Word;AR:Integer;
                  Axis_Target0,Axis_Target1:Integer):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Stream_Circle_R_CW_Run_Abs(ADev:Integer;AObj:Word;AR:Integer;
                  Axis_Target0,Axis_Target1:Integer):Integer;stdcall;external 'MT_API.dll'
//设置圆弧插补启动 逆时钟   圆心坐标
function MT_Set_Stream_Circle_R_CCW_Run_Rel(ADev:Integer;AObj:Word;AR:Integer;
                  Axis_Target0,Axis_Target1:Integer):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Stream_Circle_R_CCW_Run_Abs(ADev:Integer;AObj:Word;AR:Integer;
                  Axis_Target0,Axis_Target1:Integer):Integer;stdcall;external 'MT_API.dll'
//设置圆弧插补停止
function MT_Set_Stream_Circle_Stop(ADev:Integer;AObj:Word):Integer;stdcall;external 'MT_API.dll'
//设置圆弧插补急停
function MT_Set_Stream_Circle_Halt(ADev:Integer;AObj:Word):Integer;stdcall;external 'MT_API.dll'


function MT_Set_Stream_Wait_Line(ADev:Integer;AObj:Word):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Stream_Wait_Circle(ADev:Integer;AObj:Word):Integer;stdcall;external 'MT_API.dll'

//设置单通道值
function MT_Set_Stream_OC_Out_Single(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//设置所有通道值
function MT_Set_Stream_OC_Out_All(ADev:Integer;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//设置单通道值
function MT_Set_Stream_Optic_Out_Single(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//设置所有通道值
function MT_Set_Stream_Optic_Out_All(ADev:Integer;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//等待Optic_In状态
function MT_Set_Stream_Wait_Optic_In(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//启动Stream
function MT_Set_Stream_Run_Check(ADev:Integer):Integer;stdcall;external 'MT_API.dll'
//减速功能
function MT_Set_Stream_Dec_Enable(ADev:Integer):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Stream_Dec_Disable(ADev:Integer):Integer;stdcall;external 'MT_API.dll'
//编码器功能
function MT_Get_Encoder_Num(ADev:Integer;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
function MT_Get_Encoder_Pos(ADev:Integer;AObj:Word;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Encoder_Pos(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Encoder_Z_Polarity(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Encoder_Dir_Polarity(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
function MT_Get_Encoder_Index_Line_Count(ADev:Integer;AObj:Word;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Encoder_Over_Enable(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Encoder_Over_Max(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Encoder_Over_Stable(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//辅助计算公式
//mm to pluse
function MT_Help_Step_Line_Real_To_Steps(AStepAngle:Double;ADiv:Integer;
   APitch:Double;ALineRatio:Double;AValue:Double):Integer;stdcall;external 'MT_API.dll'
function MT_Help_Step_Circle_Real_To_Steps(AStepAngle:Double;ADiv:Integer;
   ACircleRatio:Double;AValue:Double):Integer;stdcall;external 'MT_API.dll'

//pluse to mm
function MT_Help_Step_Line_Steps_To_Real(AStepAngle:Double;ADiv:Integer;
   APitch:Double;ALineRatio:Double;AValue:Integer):Double;stdcall;external 'MT_API.dll'
function MT_Help_Step_Circle_Steps_To_Real(ADev:Integer;AStepAngle:Double;ADiv:Integer;
   ACircleRatio:Double;AValue:Integer):Double;stdcall;external 'MT_API.dll'

//Encoder
//物理量到单位脉冲
function MT_Help_Encoder_Line_Real_To_Steps(
   APitch:Double;ALineRatio:Double;ALineCount:Integer;AValue:Double):Integer;stdcall;external 'MT_API.dll'
function MT_Help_Encoder_Circle_Real_To_Steps(
   ACircleRatio:Double;ALineCount:Integer;AValue:Double):Integer;stdcall;external 'MT_API.dll'

//pluse to mm
function MT_Help_Encoder_Line_Steps_To_Real(
   APitch:Double;ALineRatio:Double;ALineCount:Integer;AValue:Integer):Double;stdcall;external 'MT_API.dll'
function MT_Help_Encoder_Circle_Steps_To_Real(
   ACircleRatio:Double;ALineCount:Integer;AValue:Integer):Double;stdcall;external 'MT_API.dll'
//Grating
//物理量到单位脉冲
function MT_Help_Grating_Line_Real_To_Steps(AUnit_um:Double;AValue:Double):Integer;stdcall;external 'MT_API.dll'
function MT_Help_Grating_Circle_Real_To_Steps(ALineCount:Integer;AValue:Double):Integer;stdcall;external 'MT_API.dll'

//pluse to mm
function MT_Help_Grating_Line_Steps_To_Real(AUnit_um:Double;AValue:Integer):Double;stdcall;external 'MT_API.dll'
function MT_Help_Grating_Circle_Steps_To_Real(ALineCount:Integer;AValue:Integer):Double;stdcall;external 'MT_API.dll'

function MT_Help_Encoder_Factor(AStepAngle:Double;ADiv:Integer;
   ALineCount:Integer):Single;stdcall;external 'MT_API.dll'

//光栅尺安装在机械上，电机旋转并不一致，需要考虑机械的影响
function MT_Help_Grating_Line_Factor(AStepAngle:Double;ADiv:Integer;
   APitch:Double;ALineRatio:Double;AUnit_um:Double):Single;stdcall;external 'MT_API.dll'

function MT_Help_Grating_Circle_Factor(AStepAngle:Double;ADiv:Integer;
   ACircleRatio:Double;ALineCount:Integer):Single;stdcall;external 'MT_API.dll'

  const R_OK =0;
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
const RESOURCE_PLC          =$00000200;   //PLC功能
const RESOURCE_STREAM       =$00000400;   //Stream功能
const RESOURCE_ENCODER      =$00000800;   //Encoder功能

implementation

end.
