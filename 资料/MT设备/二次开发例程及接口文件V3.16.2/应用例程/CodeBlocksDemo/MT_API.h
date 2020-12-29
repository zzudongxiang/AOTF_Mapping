#ifndef _MT_API_
#define _MT_API_

#include <stdint-gcc.h>


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

 int32_t __attribute__((__stdcall__)) MT_Init(void);

 int32_t __attribute__((__stdcall__)) MT_DeInit(void);

 int32_t __attribute__((__stdcall__)) MT_Get_Dll_Version(char** sVer);

 int32_t __attribute__((__stdcall__)) MT_Open_UART(char* sCOM);

 int32_t __attribute__((__stdcall__)) MT_Open_UART_Unicode(wchar_t* sCOM);

 int32_t __attribute__((__stdcall__)) MT_Close_UART(void);

 int32_t __attribute__((__stdcall__)) MT_Open_USB(void);

 int32_t __attribute__((__stdcall__)) MT_Close_USB(void);

 int32_t __attribute__((__stdcall__)) MT_Open_Net(uint8_t IP0,uint8_t IP1,uint8_t IP2,uint8_t IP3,uint16_t IPPort);

 int32_t __attribute__((__stdcall__)) MT_Close_Net(void);

 int32_t __attribute__((__stdcall__)) MT_Check(void);

 int32_t __attribute__((__stdcall__)) MT_Get_Product_Resource(int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Get_Product_ID(char* sID);

 int32_t __attribute__((__stdcall__)) MT_Get_Product_SN(char* sSN);

 int32_t __attribute__((__stdcall__)) MT_Get_Product_SN2(uint8_t* sSN);

 int32_t __attribute__((__stdcall__)) MT_Get_Product_SN3(char* sSN);

 int32_t __attribute__((__stdcall__)) MT_Get_Product_Version(int32_t* pMajor,int32_t* pMinor);

 int32_t __attribute__((__stdcall__)) MT_Get_Product_Version2(int32_t* pMajor,int32_t* pMinor,int32_t* pRelease,int32_t* pBuild);

 int32_t __attribute__((__stdcall__)) MT_Get_Axis_Num(int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Get_Axis_Acc(uint16_t AObj,int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Acc(uint16_t AObj,int32_t Value);

 int32_t __attribute__((__stdcall__)) MT_Get_Axis_Dec(uint16_t AObj,int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Dec(uint16_t AObj,int32_t Value);

 int32_t __attribute__((__stdcall__)) MT_Get_Axis_Mode(uint16_t AObj,int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Mode_Velocity(uint16_t AObj);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Mode_Position(uint16_t AObj);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Mode_Position_Open(uint16_t AObj);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Mode_Position_Close(uint16_t AObj);

 int32_t __attribute__((__stdcall__)) MT_Get_Axis_Velocity_V_Target(uint16_t AObj,int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Velocity_V_Target_Abs(uint16_t AObj,int32_t Value);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Velocity_V_Target_Rel(uint16_t AObj,int32_t Value);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Velocity_Stop(uint16_t AObj);

 int32_t __attribute__((__stdcall__)) MT_Get_Axis_Position_V_Max(uint16_t AObj,int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Position_V_Max(uint16_t AObj,int32_t Value);

 int32_t __attribute__((__stdcall__)) MT_Get_Axis_Position_P_Target(uint16_t AObj,int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Position_P_Target_Abs(uint16_t AObj,int32_t Value);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Position_P_Target_Rel(uint16_t AObj,int32_t Value);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Position_Stop(uint16_t AObj);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Position_Close_Dec_Factor(uint16_t AObj,float AFactor);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Halt(uint16_t AObj);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Halt_All(void);

 int32_t __attribute__((__stdcall__)) MT_Get_Axis_V_Now(uint16_t AObj,int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Get_Axis_Software_P_Now(uint16_t AObj,int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Software_P(uint16_t AObj,int32_t Value);

 int32_t __attribute__((__stdcall__)) MT_Get_Axis_Status(uint16_t AObj,uint8_t* pRun,uint8_t* pDir,uint8_t* pNeg,uint8_t* pPos,uint8_t* pZero,uint8_t* pMode);

 int32_t __attribute__((__stdcall__)) MT_Get_Axis_Status2(uint16_t AObj,int32_t* pRun,int32_t* pDir,int32_t* pNeg,int32_t* pPos,int32_t* pZero,int32_t* pMode);

 int32_t __attribute__((__stdcall__)) MT_Get_Axis_Status_Run(uint16_t AObj,int32_t* pRun);

 int32_t __attribute__((__stdcall__)) MT_Get_Axis_Status_Dir(uint16_t AObj,int32_t* pDir);

 int32_t __attribute__((__stdcall__)) MT_Get_Axis_Status_Neg(uint16_t AObj,int32_t* pNeg);

 int32_t __attribute__((__stdcall__)) MT_Get_Axis_Status_Pos(uint16_t AObj,int32_t* pPos);

 int32_t __attribute__((__stdcall__)) MT_Get_Axis_Status_Zero(uint16_t AObj,int32_t* pZero);

 int32_t __attribute__((__stdcall__)) MT_Get_Axis_Status_Mode(uint16_t AObj,int32_t* pMode);

 int32_t __attribute__((__stdcall__)) MT_Get_Param_Mem_Len(int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Get_Param_Mem_Data(uint16_t AObj,uint8_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Set_Param_Mem_Data(uint16_t AObj,uint8_t Value);

 int32_t __attribute__((__stdcall__)) MT_Get_System_Mem_Len(int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Get_System_Mem_Data(uint16_t AObj,uint8_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Set_System_Mem_Data(uint16_t AObj,uint8_t Value);

 int32_t __attribute__((__stdcall__)) MT_Get_Optic_In_Num(int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Get_Optic_In_Basic_Num(int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Get_Optic_In_Single(uint16_t AObj,int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Get_Optic_In_All(int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Get_Optic_Out_Num(int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Set_Optic_Out_Single(uint16_t AObj,int32_t Value);

 int32_t __attribute__((__stdcall__)) MT_Set_Optic_Out_All(int32_t Value);

 int32_t __attribute__((__stdcall__)) MT_Get_Optic_Out_Single(uint16_t AObj,int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Get_Optic_Out_All(int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Get_OC_Out_Num(int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Set_OC_Out_Single(uint16_t AObj,int32_t Value);

 int32_t __attribute__((__stdcall__)) MT_Set_OC_Out_All(int32_t Value);

 int32_t __attribute__((__stdcall__)) MT_Get_OC_Out_Single(uint16_t AObj,int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Get_OC_Out_All(int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Mode_Home(uint16_t AObj);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Mode_Home_Home_Switch(uint16_t AObj);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Mode_Home_Encoder_Index(uint16_t AObj);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Mode_Home_Encoder_Home_Switch(uint16_t AObj);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Mode_Home_Home_Zero(uint16_t AObj);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Home_V(uint16_t AObj,int32_t Value);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Home_Stop(uint16_t AObj);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Software_Limit_Neg_Value(uint16_t AObj,int32_t Value);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Software_Limit_Pos_Value(uint16_t AObj,int32_t Value);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Software_Limit_Enable(uint16_t AObj);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Software_Limit_Disable(uint16_t AObj);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Line_Axis(uint16_t AObj,int32_t Axis_ID0,int32_t Axis_ID1);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Line_Acc(uint16_t AObj,int32_t Value);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Line_Dec(uint16_t AObj,int32_t Value);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Line_V(uint16_t AObj,int32_t Value);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Line_Run(uint16_t AObj);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Line_Stop(uint16_t AObj);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Line_Halt(uint16_t AObj);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Line_Rel(uint16_t AObj,int32_t Axis_Target0,int32_t Axis_Target1);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Line_Abs(uint16_t AObj,int32_t Axis_Target0,int32_t Axis_Target1);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Line_Run_Rel(uint16_t AObj,int32_t Axis_Target0,int32_t Axis_Target1);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Line_Run_Abs(uint16_t AObj,int32_t Axis_Target0,int32_t Axis_Target1);

 int32_t __attribute__((__stdcall__)) MT_Get_Axis_Line_Num(int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Get_Axis_Line_Status(uint16_t AObj,int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Get_Axis_Line_Axis(uint16_t AObj,int32_t* pID0,int32_t* pID1);

 int32_t __attribute__((__stdcall__)) MT_Get_Axis_Line_Acc(uint16_t AObj,int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Get_Axis_Line_Dec(uint16_t AObj,int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Get_Axis_Line_V(uint16_t AObj,int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Get_AD_Num(int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Get_AD_Data(uint16_t AObj,int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Get_Board_T(int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Circle_Axis(uint16_t AObj,int32_t Axis_ID0,int32_t Axis_ID1);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Circle_Acc(uint16_t AObj,int32_t Value);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Circle_Dec(uint16_t AObj,int32_t Value);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Circle_V(uint16_t AObj,int32_t Value);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Circle_R_CW_Run_Rel(uint16_t AObj,int32_t AR,int32_t Axis_Target0,int32_t Axis_Target1);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Circle_R_CW_Run_Abs(uint16_t AObj,int32_t AR,int32_t Axis_Target0,int32_t Axis_Target1);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Circle_R_CCW_Run_Rel(uint16_t AObj,int32_t AR,int32_t Axis_Target0,int32_t Axis_Target1);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Circle_R_CCW_Run_Abs(uint16_t AObj,int32_t AR,int32_t Axis_Target0,int32_t Axis_Target1);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Circle_Stop(uint16_t AObj);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Circle_Halt(uint16_t AObj);

 int32_t __attribute__((__stdcall__)) MT_Get_Axis_Circle_Num(int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Get_Axis_Circle_Status(uint16_t AObj,int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Get_Axis_Circle_Axis(uint16_t AObj,int32_t* pID0,int32_t* pID1);

 int32_t __attribute__((__stdcall__)) MT_Get_Axis_Circle_Acc(uint16_t AObj,int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Get_Axis_Circle_Dec(uint16_t AObj,int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Get_Axis_Circle_V(uint16_t AObj,int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Get_PLC_Var_Num(int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Get_PLC_Var_Data(uint16_t AObj,int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Set_PLC_Var_Data(uint16_t AObj,int32_t Value);

 int32_t __attribute__((__stdcall__)) MT_Set_PLC_Pause(void);

 int32_t __attribute__((__stdcall__)) MT_Set_PLC_Stop(void);

 int32_t __attribute__((__stdcall__)) MT_Set_PLC_Run(void);

 int32_t __attribute__((__stdcall__)) MT_Set_PLC_Data(uint16_t AObj,uint8_t Value);

 int32_t __attribute__((__stdcall__)) MT_Get_PLC_Code_Size(int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Get_PLC_Task_Count(int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Get_PLC_Task_Status(uint16_t AObj,int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Get_PLC_Var_Seg(int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Get_PLC_Var_Used(int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Get_PLC_Status(int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Get_PLC_Tasks_Status(int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Get_PLC_Axis_Ratio(uint16_t AObj,float* pValue);

 int32_t __attribute__((__stdcall__)) MT_Get_PLC_Encoder_Ratio(uint16_t AObj,float* pValue);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Home_V_Start(uint16_t AObj,int32_t Value);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Home_Acc(uint16_t AObj,int32_t Value);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Home_Dec(uint16_t AObj,int32_t Value);

 int32_t __attribute__((__stdcall__)) MT_Get_Axis_Home_Acc(uint16_t AObj,int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Get_Axis_Home_Dec(uint16_t AObj,int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Velocity_V_Start(uint16_t AObj,int32_t Value);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Velocity_Acc(uint16_t AObj,int32_t Value);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Velocity_Dec(uint16_t AObj,int32_t Value);

 int32_t __attribute__((__stdcall__)) MT_Get_Axis_Velocity_Acc(uint16_t AObj,int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Get_Axis_Velocity_Dec(uint16_t AObj,int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Position_V_Start(uint16_t AObj,int32_t Value);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Position_Acc(uint16_t AObj,int32_t Value);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Position_Dec(uint16_t AObj,int32_t Value);

 int32_t __attribute__((__stdcall__)) MT_Get_Axis_Position_Acc(uint16_t AObj,int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Get_Axis_Position_Dec(uint16_t AObj,int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Line_V_Start(uint16_t AObj,int32_t Value);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Circle_V_Start(uint16_t AObj,int32_t Value);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Line_X_Run_Rel(uint16_t AObj,int32_t AAxis_Num,int32_t* pAxis,int32_t* pTarget);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Line_X_Run_Abs(uint16_t AObj,int32_t AAxis_Num,int32_t* pAxis,int32_t* pTarget);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Line_X_Target_Rel(uint16_t AObj,int32_t AAxisID,int32_t ATarget);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Line_X_Target_Abs(uint16_t AObj,int32_t AAxisID,int32_t ATarget);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Line_X_Count(uint16_t AObj,int32_t ANum);

 int32_t __attribute__((__stdcall__)) MT_Set_Axis_Line_X_Axis(uint16_t AObj,int32_t AAxisID,int32_t AAxis);

 int32_t __attribute__((__stdcall__)) MT_Set_Stream_Run(void);

 int32_t __attribute__((__stdcall__)) MT_Set_Stream_Stop(void);

 int32_t __attribute__((__stdcall__)) MT_Set_Stream_Pause(void);

 int32_t __attribute__((__stdcall__)) MT_Set_Stream_Clear(void);

 int32_t __attribute__((__stdcall__)) MT_Get_Stream_Space(int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Get_Stream_Total(int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Get_Stream_Count(int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Set_Stream_Delay(int32_t Value);

 int32_t __attribute__((__stdcall__)) MT_Set_Stream_Line_Acc(uint16_t AObj,int32_t Value);

 int32_t __attribute__((__stdcall__)) MT_Set_Stream_Line_Dec(uint16_t AObj,int32_t Value);

 int32_t __attribute__((__stdcall__)) MT_Set_Stream_Line_V_Max(uint16_t AObj,int32_t Value);

 int32_t __attribute__((__stdcall__)) MT_Set_Stream_Line_V_Start(uint16_t AObj,int32_t Value);

 int32_t __attribute__((__stdcall__)) MT_Set_Stream_Line_Stop(uint16_t AObj);

 int32_t __attribute__((__stdcall__)) MT_Set_Stream_Line_Halt(uint16_t AObj);

 int32_t __attribute__((__stdcall__)) MT_Set_Stream_Line_X_Run_Rel(uint16_t AObj,int32_t AAxis_Num,int32_t* pAxis,int32_t* pTarget);

 int32_t __attribute__((__stdcall__)) MT_Set_Stream_Line_X_Run_Abs(uint16_t AObj,int32_t AAxis_Num,int32_t* pAxis,int32_t* pTarget);

 int32_t __attribute__((__stdcall__)) MT_Set_Stream_Circle_Axis(uint16_t AObj,int32_t Axis_ID0,int32_t Axis_ID1);

 int32_t __attribute__((__stdcall__)) MT_Set_Stream_Circle_Acc(uint16_t AObj,int32_t Value);

 int32_t __attribute__((__stdcall__)) MT_Set_Stream_Circle_Dec(uint16_t AObj,int32_t Value);

 int32_t __attribute__((__stdcall__)) MT_Set_Stream_Circle_V_Max(uint16_t AObj,int32_t Value);

 int32_t __attribute__((__stdcall__)) MT_Set_Stream_Circle_V_Start(uint16_t AObj,int32_t Value);

 int32_t __attribute__((__stdcall__)) MT_Set_Stream_Circle_R_CW_Run_Rel(uint16_t AObj,int32_t AR,int32_t Axis_Target0,int32_t Axis_Target1);

 int32_t __attribute__((__stdcall__)) MT_Set_Stream_Circle_R_CW_Run_Abs(uint16_t AObj,int32_t AR,int32_t Axis_Target0,int32_t Axis_Target1);

 int32_t __attribute__((__stdcall__)) MT_Set_Stream_Circle_R_CCW_Run_Rel(uint16_t AObj,int32_t AR,int32_t Axis_Target0,int32_t Axis_Target1);

 int32_t __attribute__((__stdcall__)) MT_Set_Stream_Circle_R_CCW_Run_Abs(uint16_t AObj,int32_t AR,int32_t Axis_Target0,int32_t Axis_Target1);

 int32_t __attribute__((__stdcall__)) MT_Set_Stream_Circle_Stop(uint16_t AObj);

 int32_t __attribute__((__stdcall__)) MT_Set_Stream_Circle_Halt(uint16_t AObj);

 int32_t __attribute__((__stdcall__)) MT_Set_Stream_Wait_Line(uint16_t AObj);

 int32_t __attribute__((__stdcall__)) MT_Set_Stream_Wait_Circle(uint16_t AObj);

 int32_t __attribute__((__stdcall__)) MT_Set_Stream_OC_Out_Single(uint16_t AObj,int32_t Value);

 int32_t __attribute__((__stdcall__)) MT_Set_Stream_OC_Out_All(int32_t Value);

 int32_t __attribute__((__stdcall__)) MT_Set_Stream_Optic_Out_Single(uint16_t AObj,int32_t Value);

 int32_t __attribute__((__stdcall__)) MT_Set_Stream_Optic_Out_All(int32_t Value);

 int32_t __attribute__((__stdcall__)) MT_Set_Stream_Wait_Optic_In(uint16_t AObj,int32_t Value);

 int32_t __attribute__((__stdcall__)) MT_Set_Stream_Run_Check(void);

 int32_t __attribute__((__stdcall__)) MT_Set_Stream_Dec_Enable(void);

 int32_t __attribute__((__stdcall__)) MT_Set_Stream_Dec_Disable(void);

 int32_t __attribute__((__stdcall__)) MT_Get_Encoder_Num(int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Get_Encoder_Pos(uint16_t AObj,int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Set_Encoder_Pos(uint16_t AObj,int32_t Value);

 int32_t __attribute__((__stdcall__)) MT_Set_Encoder_Z_Polarity(uint16_t AObj,int32_t Value);

 int32_t __attribute__((__stdcall__)) MT_Set_Encoder_Dir_Polarity(uint16_t AObj,int32_t Value);

 int32_t __attribute__((__stdcall__)) MT_Get_Encoder_Index_Line_Count(uint16_t AObj,int32_t* pValue);

 int32_t __attribute__((__stdcall__)) MT_Set_Encoder_Over_Enable(uint16_t AObj,int32_t Value);

 int32_t __attribute__((__stdcall__)) MT_Set_Encoder_Over_Max(uint16_t AObj,int32_t Value);

 int32_t __attribute__((__stdcall__)) MT_Set_Encoder_Over_Stable(uint16_t AObj,int32_t Value);

 int32_t __attribute__((__stdcall__)) MT_Help_Step_Line_Real_To_Steps(double AStepAngle,int32_t ADiv,double APitch,double ALineRatio,double AValue);

 int32_t __attribute__((__stdcall__)) MT_Help_Step_Circle_Real_To_Steps(double AStepAngle,int32_t ADiv,double ACircleRatio,double AValue);

 double __attribute__((__stdcall__)) MT_Help_Step_Line_Steps_To_Real(double AStepAngle,int32_t ADiv,double APitch,double ALineRatio,int32_t AValue);

 double __attribute__((__stdcall__)) MT_Help_Step_Circle_Steps_To_Real(double AStepAngle,int32_t ADiv,double ACircleRatio,int32_t AValue);

 int32_t __attribute__((__stdcall__)) MT_Help_Encoder_Line_Real_To_Steps(double APitch,double ALineRatio,int32_t ALineCount,double AValue);

 int32_t __attribute__((__stdcall__)) MT_Help_Encoder_Circle_Real_To_Steps(double ACircleRatio,int32_t ALineCount,double AValue);

 double __attribute__((__stdcall__)) MT_Help_Encoder_Line_Steps_To_Real(double APitch,double ALineRatio,int32_t ALineCount,int32_t AValue);

 double __attribute__((__stdcall__)) MT_Help_Encoder_Circle_Steps_To_Real(double ACircleRatio,int32_t ALineCount,int32_t AValue);

 int32_t __attribute__((__stdcall__)) MT_Help_Grating_Line_Real_To_Steps(double AUnit_um,double AValue);

 int32_t __attribute__((__stdcall__)) MT_Help_Grating_Circle_Real_To_Steps(int32_t ALineCount,double AValue);

 double __attribute__((__stdcall__)) MT_Help_Grating_Line_Steps_To_Real(double AUnit_um,int32_t AValue);

 double __attribute__((__stdcall__)) MT_Help_Grating_Circle_Steps_To_Real(int32_t ALineCount,int32_t AValue);

 float __attribute__((__stdcall__)) MT_Help_Encoder_Factor(double AStepAngle,int32_t ADiv,int32_t ALineCount);

 float __attribute__((__stdcall__)) MT_Help_Grating_Line_Factor(double AStepAngle,int32_t ADiv,double APitch,double ALineRatio,double AUnit_um);

 float __attribute__((__stdcall__)) MT_Help_Grating_Circle_Factor(double AStepAngle,int32_t ADiv,double ACircleRatio,int32_t ALineCount);

#endif

