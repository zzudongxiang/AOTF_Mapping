#ifndef _MT_API_Multi_
#define _MT_API_Multi_
/*
C接口文件
3.16.2
*/
#pragma comment(lib,"MT_API_Multi.lib")
#ifdef __cplusplus
#define MT_API_Multi extern "C" __declspec( dllexport )
#else
#define MT_API_Multi __declspec( dllexport )
#endif

#define R_OK   0
#define RUN_OFF   0
#define RUN_ON   1
#define DIR_NEG   0
#define DIR_POS   1
#define LIMIT_ON   1
#define LIMIT_OFF   0
#define RESOURCE_MOTOR   0x00000001
#define RESOURCE_TTL_IN   0x00000002
#define RESOURCE_TTL_OUT   0x00000004
#define RESOURCE_OPTIC_IN   0x00000008
#define RESOURCE_OPTIC_OUT   0x00000010
#define RESOURCE_AD   0x00000020
#define RESOURCE_OC   0x00000040
#define RESOURCE_LINE   0x00000080
#define RESOURCE_CIRCLE   0x00000100
#define RESOURCE_PLC   0x00000200
#define RESOURCE_STREAM   0x00000400
#define RESOURCE_ENCODER   0x00000800

MT_API_Multi INT32 __stdcall MT_Init(void);

MT_API_Multi INT32 __stdcall MT_DeInit(void);

MT_API_Multi INT32 __stdcall MT_Get_Dll_Version(char** sVer);

MT_API_Multi INT32 __stdcall MT_Set_Thread_Timeout(UINT32 ms);

MT_API_Multi INT32 __stdcall MT_Open_UART(INT32 ADev,char* sCOM);

MT_API_Multi INT32 __stdcall MT_Open_UART_Unicode(INT32 ADev,TCHAR* sCOM);

MT_API_Multi INT32 __stdcall MT_Close_UART(INT32 ADev);

MT_API_Multi INT32 __stdcall MT_Open_USB(INT32 ADev);

MT_API_Multi INT32 __stdcall MT_Close_USB(INT32 ADev);

MT_API_Multi INT32 __stdcall MT_Open_Net(INT32 ADev,BYTE IP0,BYTE IP1,BYTE IP2,BYTE IP3,WORD IPPort);

MT_API_Multi INT32 __stdcall MT_Close_Net(INT32 ADev);

MT_API_Multi INT32 __stdcall MT_Check(INT32 ADev);

MT_API_Multi INT32 __stdcall MT_Get_Product_Resource(INT32 ADev,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Get_Product_ID(INT32 ADev,char* sID);

MT_API_Multi INT32 __stdcall MT_Get_Product_SN(INT32 ADev,char* sSN);

MT_API_Multi INT32 __stdcall MT_Get_Product_SN2(INT32 ADev,BYTE* sSN);

MT_API_Multi INT32 __stdcall MT_Get_Product_SN3(INT32 ADev,char* sSN);

MT_API_Multi INT32 __stdcall MT_Get_Product_Version(INT32 ADev,INT32* pMajor,INT32* pMinor);

MT_API_Multi INT32 __stdcall MT_Get_Product_Version2(INT32 ADev,INT32* pMajor,INT32* pMinor,INT32* pRelease,INT32* pBuild);

MT_API_Multi INT32 __stdcall MT_Get_Axis_Num(INT32 ADev,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Get_Axis_Acc(INT32 ADev,WORD AObj,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Acc(INT32 ADev,WORD AObj,INT32 Value);

MT_API_Multi INT32 __stdcall MT_Get_Axis_Dec(INT32 ADev,WORD AObj,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Dec(INT32 ADev,WORD AObj,INT32 Value);

MT_API_Multi INT32 __stdcall MT_Get_Axis_Mode(INT32 ADev,WORD AObj,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Mode_Velocity(INT32 ADev,WORD AObj);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Mode_Position(INT32 ADev,WORD AObj);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Mode_Position_Open(INT32 ADev,WORD AObj);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Mode_Position_Close(INT32 ADev,WORD AObj);

MT_API_Multi INT32 __stdcall MT_Get_Axis_Velocity_V_Target(INT32 ADev,WORD AObj,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Velocity_V_Target_Abs(INT32 ADev,WORD AObj,INT32 Value);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Velocity_V_Target_Rel(INT32 ADev,WORD AObj,INT32 Value);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Velocity_Stop(INT32 ADev,WORD AObj);

MT_API_Multi INT32 __stdcall MT_Get_Axis_Position_V_Max(INT32 ADev,WORD AObj,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Position_V_Max(INT32 ADev,WORD AObj,INT32 Value);

MT_API_Multi INT32 __stdcall MT_Get_Axis_Position_P_Target(INT32 ADev,WORD AObj,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Position_P_Target_Abs(INT32 ADev,WORD AObj,INT32 Value);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Position_P_Target_Rel(INT32 ADev,WORD AObj,INT32 Value);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Position_Stop(INT32 ADev,WORD AObj);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Position_Close_Dec_Factor(INT32 ADev,WORD AObj,float AFactor);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Halt(INT32 ADev,WORD AObj);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Halt_All(INT32 ADev);

MT_API_Multi INT32 __stdcall MT_Get_Axis_V_Now(INT32 ADev,WORD AObj,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Get_Axis_Software_P_Now(INT32 ADev,WORD AObj,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Software_P(INT32 ADev,WORD AObj,INT32 Value);

MT_API_Multi INT32 __stdcall MT_Get_Axis_Status(INT32 ADev,WORD AObj,BYTE* pRun,BYTE* pDir,BYTE* pNeg,BYTE* pPos,BYTE* pZero,BYTE* pMode);

MT_API_Multi INT32 __stdcall MT_Get_Axis_Status2(INT32 ADev,WORD AObj,INT32* pRun,INT32* pDir,INT32* pNeg,INT32* pPos,INT32* pZero,INT32* pMode);

MT_API_Multi INT32 __stdcall MT_Get_Axis_Status_Run(INT32 ADev,WORD AObj,INT32* pRun);

MT_API_Multi INT32 __stdcall MT_Get_Axis_Status_Dir(INT32 ADev,WORD AObj,INT32* pDir);

MT_API_Multi INT32 __stdcall MT_Get_Axis_Status_Neg(INT32 ADev,WORD AObj,INT32* pNeg);

MT_API_Multi INT32 __stdcall MT_Get_Axis_Status_Pos(INT32 ADev,WORD AObj,INT32* pPos);

MT_API_Multi INT32 __stdcall MT_Get_Axis_Status_Zero(INT32 ADev,WORD AObj,INT32* pZero);

MT_API_Multi INT32 __stdcall MT_Get_Axis_Status_Mode(INT32 ADev,WORD AObj,INT32* pMode);

MT_API_Multi INT32 __stdcall MT_Get_Param_Mem_Len(INT32 ADev,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Get_Param_Mem_Data(INT32 ADev,WORD AObj,BYTE* pValue);

MT_API_Multi INT32 __stdcall MT_Set_Param_Mem_Data(INT32 ADev,WORD AObj,BYTE Value);

MT_API_Multi INT32 __stdcall MT_Get_System_Mem_Len(INT32 ADev,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Get_System_Mem_Data(INT32 ADev,WORD AObj,BYTE* pValue);

MT_API_Multi INT32 __stdcall MT_Set_System_Mem_Data(INT32 ADev,WORD AObj,BYTE Value);

MT_API_Multi INT32 __stdcall MT_Get_Optic_In_Num(INT32 ADev,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Get_Optic_In_Basic_Num(INT32 ADev,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Get_Optic_In_Single(INT32 ADev,WORD AObj,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Get_Optic_In_All(INT32 ADev,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Get_Optic_Out_Num(INT32 ADev,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Set_Optic_Out_Single(INT32 ADev,WORD AObj,INT32 Value);

MT_API_Multi INT32 __stdcall MT_Set_Optic_Out_All(INT32 ADev,INT32 Value);

MT_API_Multi INT32 __stdcall MT_Get_Optic_Out_Single(INT32 ADev,WORD AObj,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Get_Optic_Out_All(INT32 ADev,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Get_OC_Out_Num(INT32 ADev,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Set_OC_Out_Single(INT32 ADev,WORD AObj,INT32 Value);

MT_API_Multi INT32 __stdcall MT_Set_OC_Out_All(INT32 ADev,INT32 Value);

MT_API_Multi INT32 __stdcall MT_Get_OC_Out_Single(INT32 ADev,WORD AObj,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Get_OC_Out_All(INT32 ADev,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Mode_Home(INT32 ADev,WORD AObj);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Mode_Home_Home_Switch(INT32 ADev,WORD AObj);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Mode_Home_Encoder_Index(INT32 ADev,WORD AObj);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Mode_Home_Encoder_Home_Switch(INT32 ADev,WORD AObj);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Mode_Home_Home_Zero(INT32 ADev,WORD AObj);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Home_V(INT32 ADev,WORD AObj,INT32 Value);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Home_Stop(INT32 ADev,WORD AObj);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Software_Limit_Neg_Value(INT32 ADev,WORD AObj,INT32 Value);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Software_Limit_Pos_Value(INT32 ADev,WORD AObj,INT32 Value);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Software_Limit_Enable(INT32 ADev,WORD AObj);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Software_Limit_Disable(INT32 ADev,WORD AObj);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Line_Axis(INT32 ADev,WORD AObj,INT32 Axis_ID0,INT32 Axis_ID1);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Line_Acc(INT32 ADev,WORD AObj,INT32 Value);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Line_Dec(INT32 ADev,WORD AObj,INT32 Value);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Line_V(INT32 ADev,WORD AObj,INT32 Value);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Line_Run(INT32 ADev,WORD AObj);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Line_Stop(INT32 ADev,WORD AObj);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Line_Halt(INT32 ADev,WORD AObj);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Line_Rel(INT32 ADev,WORD AObj,INT32 Axis_Target0,INT32 Axis_Target1);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Line_Abs(INT32 ADev,WORD AObj,INT32 Axis_Target0,INT32 Axis_Target1);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Line_Run_Rel(INT32 ADev,WORD AObj,INT32 Axis_Target0,INT32 Axis_Target1);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Line_Run_Abs(INT32 ADev,WORD AObj,INT32 Axis_Target0,INT32 Axis_Target1);

MT_API_Multi INT32 __stdcall MT_Get_Axis_Line_Num(INT32 ADev,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Get_Axis_Line_Status(INT32 ADev,WORD AObj,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Get_Axis_Line_Axis(INT32 ADev,WORD AObj,INT32* pID0,INT32* pID1);

MT_API_Multi INT32 __stdcall MT_Get_Axis_Line_Acc(INT32 ADev,WORD AObj,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Get_Axis_Line_Dec(INT32 ADev,WORD AObj,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Get_Axis_Line_V(INT32 ADev,WORD AObj,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Get_AD_Num(INT32 ADev,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Get_AD_Data(INT32 ADev,WORD AObj,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Get_Board_T(INT32 ADev,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Circle_Axis(INT32 ADev,WORD AObj,INT32 Axis_ID0,INT32 Axis_ID1);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Circle_Acc(INT32 ADev,WORD AObj,INT32 Value);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Circle_Dec(INT32 ADev,WORD AObj,INT32 Value);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Circle_V(INT32 ADev,WORD AObj,INT32 Value);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Circle_R_CW_Run_Rel(INT32 ADev,WORD AObj,INT32 AR,INT32 Axis_Target0,INT32 Axis_Target1);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Circle_R_CW_Run_Abs(INT32 ADev,WORD AObj,INT32 AR,INT32 Axis_Target0,INT32 Axis_Target1);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Circle_R_CCW_Run_Rel(INT32 ADev,WORD AObj,INT32 AR,INT32 Axis_Target0,INT32 Axis_Target1);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Circle_R_CCW_Run_Abs(INT32 ADev,WORD AObj,INT32 AR,INT32 Axis_Target0,INT32 Axis_Target1);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Circle_Stop(INT32 ADev,WORD AObj);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Circle_Halt(INT32 ADev,WORD AObj);

MT_API_Multi INT32 __stdcall MT_Get_Axis_Circle_Num(INT32 ADev,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Get_Axis_Circle_Status(INT32 ADev,WORD AObj,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Get_Axis_Circle_Axis(INT32 ADev,WORD AObj,INT32* pID0,INT32* pID1);

MT_API_Multi INT32 __stdcall MT_Get_Axis_Circle_Acc(INT32 ADev,WORD AObj,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Get_Axis_Circle_Dec(INT32 ADev,WORD AObj,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Get_Axis_Circle_V(INT32 ADev,WORD AObj,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Get_PLC_Var_Num(INT32 ADev,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Get_PLC_Var_Data(INT32 ADev,WORD AObj,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Set_PLC_Var_Data(INT32 ADev,WORD AObj,INT32 Value);

MT_API_Multi INT32 __stdcall MT_Set_PLC_Pause(INT32 ADev);

MT_API_Multi INT32 __stdcall MT_Set_PLC_Stop(INT32 ADev);

MT_API_Multi INT32 __stdcall MT_Set_PLC_Run(INT32 ADev);

MT_API_Multi INT32 __stdcall MT_Set_PLC_Data(INT32 ADev,WORD AObj,BYTE Value);

MT_API_Multi INT32 __stdcall MT_Get_PLC_Code_Size(INT32 ADev,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Get_PLC_Task_Count(INT32 ADev,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Get_PLC_Task_Status(INT32 ADev,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Get_PLC_Var_Seg(INT32 ADev,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Get_PLC_Var_Used(INT32 ADev,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Get_PLC_Status(INT32 ADev,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Get_PLC_Tasks_Status(INT32 ADev,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Get_PLC_Axis_Ratio(INT32 ADev,float* pValue);

MT_API_Multi INT32 __stdcall MT_Get_PLC_Encoder_Ratio(INT32 ADev,float* pValue);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Home_V_Start(INT32 ADev,WORD AObj,INT32 Value);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Home_Acc(INT32 ADev,WORD AObj,INT32 Value);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Home_Dec(INT32 ADev,WORD AObj,INT32 Value);

MT_API_Multi INT32 __stdcall MT_Get_Axis_Home_Acc(INT32 ADev,WORD AObj,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Get_Axis_Home_Dec(INT32 ADev,WORD AObj,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Velocity_V_Start(INT32 ADev,WORD AObj,INT32 Value);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Velocity_Acc(INT32 ADev,WORD AObj,INT32 Value);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Velocity_Dec(INT32 ADev,WORD AObj,INT32 Value);

MT_API_Multi INT32 __stdcall MT_Get_Axis_Velocity_Acc(INT32 ADev,WORD AObj,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Get_Axis_Velocity_Dec(INT32 ADev,WORD AObj,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Position_V_Start(INT32 ADev,WORD AObj,INT32 Value);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Position_Acc(INT32 ADev,WORD AObj,INT32 Value);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Position_Dec(INT32 ADev,WORD AObj,INT32 Value);

MT_API_Multi INT32 __stdcall MT_Get_Axis_Position_Acc(INT32 ADev,WORD AObj,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Get_Axis_Position_Dec(INT32 ADev,WORD AObj,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Line_V_Start(INT32 ADev,WORD AObj,INT32 Value);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Circle_V_Start(INT32 ADev,WORD AObj,INT32 Value);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Line_X_Run_Rel(INT32 ADev,WORD AObj,INT32 AAxis_Num,INT32* pAxis,INT32* pTarget);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Line_X_Run_Abs(INT32 ADev,WORD AObj,INT32 AAxis_Num,INT32* pAxis,INT32* pTarget);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Line_X_Target_Rel(INT32 ADev,WORD AObj,INT32 AAxisID,INT32 ATarget);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Line_X_Target_Abs(INT32 ADev,WORD AObj,INT32 AAxisID,INT32 ATarget);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Line_X_Count(INT32 ADev,WORD AObj,INT32 ANum);

MT_API_Multi INT32 __stdcall MT_Set_Axis_Line_X_Axis(INT32 ADev,WORD AObj,INT32 AAxisID,INT32 AAxis);

MT_API_Multi INT32 __stdcall MT_Set_Stream_Run(INT32 ADev);

MT_API_Multi INT32 __stdcall MT_Set_Stream_Stop(INT32 ADev);

MT_API_Multi INT32 __stdcall MT_Set_Stream_Pause(INT32 ADev);

MT_API_Multi INT32 __stdcall MT_Set_Stream_Clear(INT32 ADev);

MT_API_Multi INT32 __stdcall MT_Get_Stream_Space(INT32 ADev,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Get_Stream_Total(INT32 ADev,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Get_Stream_Count(INT32 ADev,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Set_Stream_Delay(INT32 ADev,INT32 Value);

MT_API_Multi INT32 __stdcall MT_Set_Stream_Line_Acc(INT32 ADev,WORD AObj,INT32 Value);

MT_API_Multi INT32 __stdcall MT_Set_Stream_Line_Dec(INT32 ADev,WORD AObj,INT32 Value);

MT_API_Multi INT32 __stdcall MT_Set_Stream_Line_V_Max(INT32 ADev,WORD AObj,INT32 Value);

MT_API_Multi INT32 __stdcall MT_Set_Stream_Line_V_Start(INT32 ADev,WORD AObj,INT32 Value);

MT_API_Multi INT32 __stdcall MT_Set_Stream_Line_Stop(INT32 ADev,WORD AObj);

MT_API_Multi INT32 __stdcall MT_Set_Stream_Line_Halt(INT32 ADev,WORD AObj);

MT_API_Multi INT32 __stdcall MT_Set_Stream_Line_X_Run_Rel(INT32 ADev,WORD AObj,INT32 AAxis_Num,INT32* pAxis,INT32* pTarget);

MT_API_Multi INT32 __stdcall MT_Set_Stream_Line_X_Run_Abs(INT32 ADev,WORD AObj,INT32 AAxis_Num,INT32* pAxis,INT32* pTarget);

MT_API_Multi INT32 __stdcall MT_Set_Stream_Circle_Axis(INT32 ADev,WORD AObj,INT32 Axis_ID0,INT32 Axis_ID1);

MT_API_Multi INT32 __stdcall MT_Set_Stream_Circle_Acc(INT32 ADev,WORD AObj,INT32 Value);

MT_API_Multi INT32 __stdcall MT_Set_Stream_Circle_Dec(INT32 ADev,WORD AObj,INT32 Value);

MT_API_Multi INT32 __stdcall MT_Set_Stream_Circle_V_Max(INT32 ADev,WORD AObj,INT32 Value);

MT_API_Multi INT32 __stdcall MT_Set_Stream_Circle_V_Start(INT32 ADev,WORD AObj,INT32 Value);

MT_API_Multi INT32 __stdcall MT_Set_Stream_Circle_R_CW_Run_Rel(INT32 ADev,WORD AObj,INT32 AR,INT32 Axis_Target0,INT32 Axis_Target1);

MT_API_Multi INT32 __stdcall MT_Set_Stream_Circle_R_CW_Run_Abs(INT32 ADev,WORD AObj,INT32 AR,INT32 Axis_Target0,INT32 Axis_Target1);

MT_API_Multi INT32 __stdcall MT_Set_Stream_Circle_R_CCW_Run_Rel(INT32 ADev,WORD AObj,INT32 AR,INT32 Axis_Target0,INT32 Axis_Target1);

MT_API_Multi INT32 __stdcall MT_Set_Stream_Circle_R_CCW_Run_Abs(INT32 ADev,WORD AObj,INT32 AR,INT32 Axis_Target0,INT32 Axis_Target1);

MT_API_Multi INT32 __stdcall MT_Set_Stream_Circle_Stop(INT32 ADev,WORD AObj);

MT_API_Multi INT32 __stdcall MT_Set_Stream_Circle_Halt(INT32 ADev,WORD AObj);

MT_API_Multi INT32 __stdcall MT_Set_Stream_Wait_Line(INT32 ADev,WORD AObj);

MT_API_Multi INT32 __stdcall MT_Set_Stream_Wait_Circle(INT32 ADev,WORD AObj);

MT_API_Multi INT32 __stdcall MT_Set_Stream_OC_Out_Single(INT32 ADev,WORD AObj,INT32 Value);

MT_API_Multi INT32 __stdcall MT_Set_Stream_OC_Out_All(INT32 ADev,INT32 Value);

MT_API_Multi INT32 __stdcall MT_Set_Stream_Optic_Out_Single(INT32 ADev,WORD AObj,INT32 Value);

MT_API_Multi INT32 __stdcall MT_Set_Stream_Optic_Out_All(INT32 ADev,INT32 Value);

MT_API_Multi INT32 __stdcall MT_Set_Stream_Wait_Optic_In(INT32 ADev,WORD AObj,INT32 Value);

MT_API_Multi INT32 __stdcall MT_Set_Stream_Run_Check(INT32 ADev);

MT_API_Multi INT32 __stdcall MT_Set_Stream_Dec_Enable(INT32 ADev);

MT_API_Multi INT32 __stdcall MT_Set_Stream_Dec_Disable(INT32 ADev);

MT_API_Multi INT32 __stdcall MT_Get_Encoder_Num(INT32 ADev,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Get_Encoder_Pos(INT32 ADev,WORD AObj,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Set_Encoder_Pos(INT32 ADev,WORD AObj,INT32 Value);

MT_API_Multi INT32 __stdcall MT_Set_Encoder_Z_Polarity(INT32 ADev,WORD AObj,INT32 Value);

MT_API_Multi INT32 __stdcall MT_Set_Encoder_Dir_Polarity(INT32 ADev,WORD AObj,INT32 Value);

MT_API_Multi INT32 __stdcall MT_Get_Encoder_Index_Line_Count(INT32 ADev,WORD AObj,INT32* pValue);

MT_API_Multi INT32 __stdcall MT_Set_Encoder_Over_Enable(INT32 ADev,WORD AObj,INT32 Value);

MT_API_Multi INT32 __stdcall MT_Set_Encoder_Over_Max(INT32 ADev,WORD AObj,INT32 Value);

MT_API_Multi INT32 __stdcall MT_Set_Encoder_Over_Stable(INT32 ADev,WORD AObj,INT32 Value);

MT_API_Multi INT32 __stdcall MT_Help_Step_Line_Real_To_Steps(double AStepAngle,INT32 ADiv,double APitch,double ALineRatio,double AValue);

MT_API_Multi INT32 __stdcall MT_Help_Step_Circle_Real_To_Steps(double AStepAngle,INT32 ADiv,double ACircleRatio,double AValue);

MT_API_Multi double __stdcall MT_Help_Step_Line_Steps_To_Real(double AStepAngle,INT32 ADiv,double APitch,double ALineRatio,INT32 AValue);

MT_API_Multi double __stdcall MT_Help_Step_Circle_Steps_To_Real(INT32 ADev,double AStepAngle,INT32 ADiv,double ACircleRatio,INT32 AValue);

MT_API_Multi INT32 __stdcall MT_Help_Encoder_Line_Real_To_Steps(double APitch,double ALineRatio,INT32 ALineCount,double AValue);

MT_API_Multi INT32 __stdcall MT_Help_Encoder_Circle_Real_To_Steps(double ACircleRatio,INT32 ALineCount,double AValue);

MT_API_Multi double __stdcall MT_Help_Encoder_Line_Steps_To_Real(double APitch,double ALineRatio,INT32 ALineCount,INT32 AValue);

MT_API_Multi double __stdcall MT_Help_Encoder_Circle_Steps_To_Real(double ACircleRatio,INT32 ALineCount,INT32 AValue);

MT_API_Multi INT32 __stdcall MT_Help_Grating_Line_Real_To_Steps(double AUnit_um,double AValue);

MT_API_Multi INT32 __stdcall MT_Help_Grating_Circle_Real_To_Steps(INT32 ALineCount,double AValue);

MT_API_Multi double __stdcall MT_Help_Grating_Line_Steps_To_Real(double AUnit_um,INT32 AValue);

MT_API_Multi double __stdcall MT_Help_Grating_Circle_Steps_To_Real(INT32 ALineCount,INT32 AValue);

MT_API_Multi float __stdcall MT_Help_Encoder_Factor(double AStepAngle,INT32 ADiv,INT32 ALineCount);

MT_API_Multi float __stdcall MT_Help_Grating_Line_Factor(double AStepAngle,INT32 ADiv,double APitch,double ALineRatio,double AUnit_um);

MT_API_Multi float __stdcall MT_Help_Grating_Circle_Factor(double AStepAngle,INT32 ADiv,double ACircleRatio,INT32 ALineCount);

#endif

