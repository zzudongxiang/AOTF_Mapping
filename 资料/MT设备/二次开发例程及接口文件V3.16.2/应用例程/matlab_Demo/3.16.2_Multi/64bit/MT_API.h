#ifndef _MT_API_
#define _MT_API_

#ifdef __cplusplus
#define MT_API extern "C" __declspec( dllexport )
#else
#define MT_API __declspec( dllexport )
#endif

MT_API int __stdcall MT_Init(void);

MT_API int __stdcall MT_DeInit(void);

MT_API int __stdcall MT_Open_UART(int ADev,char* sCOM);

MT_API int __stdcall MT_Close_UART(int ADev);

MT_API int __stdcall MT_Open_USB(int ADev);

MT_API int __stdcall MT_Close_USB(int ADev);

MT_API int __stdcall MT_Open_Net(int ADev,unsigned char IP0,unsigned char IP1,unsigned char IP2,unsigned char IP3,unsigned short IPPort);

MT_API int __stdcall MT_Close_Net(int ADev);

MT_API int __stdcall MT_Check(int ADev);

MT_API int __stdcall MT_Get_Product_Resource(int ADev,int* pValue);

MT_API int __stdcall MT_Get_Product_ID(int ADev,char* sID);

MT_API int __stdcall MT_Get_Product_SN(int ADev,char* sSN);

MT_API int __stdcall MT_Get_Product_SN2(int ADev,unsigned char* sSN);

MT_API int __stdcall MT_Get_Product_SN3(int ADev,char* sSN);

MT_API int __stdcall MT_Get_Product_Version(int ADev,int* pMajor,int* pMinor);

MT_API int __stdcall MT_Get_Product_Version2(int ADev,int* pMajor,int* pMinor,int* pRelease,int* pBuild);

MT_API int __stdcall MT_Get_Axis_Num(int ADev,int* pValue);

MT_API int __stdcall MT_Get_Axis_Acc(int ADev,unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Set_Axis_Acc(int ADev,unsigned short AObj,int Value);

MT_API int __stdcall MT_Get_Axis_Dec(int ADev,unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Set_Axis_Dec(int ADev,unsigned short AObj,int Value);

MT_API int __stdcall MT_Get_Axis_Mode(int ADev,unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Set_Axis_Mode_Velocity(int ADev,unsigned short AObj);

MT_API int __stdcall MT_Set_Axis_Mode_Position(int ADev,unsigned short AObj);

MT_API int __stdcall MT_Set_Axis_Mode_Position_Open(int ADev,unsigned short AObj);

MT_API int __stdcall MT_Set_Axis_Mode_Position_Close(int ADev,unsigned short AObj);

MT_API int __stdcall MT_Get_Axis_Velocity_V_Target(int ADev,unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Set_Axis_Velocity_V_Target_Abs(int ADev,unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Axis_Velocity_V_Target_Rel(int ADev,unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Axis_Velocity_Stop(int ADev,unsigned short AObj);

MT_API int __stdcall MT_Get_Axis_Position_V_Max(int ADev,unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Set_Axis_Position_V_Max(int ADev,unsigned short AObj,int Value);

MT_API int __stdcall MT_Get_Axis_Position_P_Target(int ADev,unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Set_Axis_Position_P_Target_Abs(int ADev,unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Axis_Position_P_Target_Rel(int ADev,unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Axis_Position_Stop(int ADev,unsigned short AObj);

MT_API int __stdcall MT_Set_Axis_Position_Close_Dec_Factor(int ADev,unsigned short AObj,float AFactor);

MT_API int __stdcall MT_Set_Axis_Halt(int ADev,unsigned short AObj);

MT_API int __stdcall MT_Set_Axis_Halt_All(int ADev);

MT_API int __stdcall MT_Get_Axis_V_Now(int ADev,unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Get_Axis_Software_P_Now(int ADev,unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Set_Axis_Software_P(int ADev,unsigned short AObj,int Value);

MT_API int __stdcall MT_Get_Axis_Status(int ADev,unsigned short AObj,unsigned char* pRun,unsigned char* pDir,unsigned char* pNeg,unsigned char* pPos,unsigned char* pZero,unsigned char* pMode);

MT_API int __stdcall MT_Get_Axis_Status2(int ADev,unsigned short AObj,int* pRun,int* pDir,int* pNeg,int* pPos,int* pZero,int* pMode);

MT_API int __stdcall MT_Get_Axis_Status_Run(int ADev,unsigned short AObj,int* pRun);

MT_API int __stdcall MT_Get_Axis_Status_Dir(int ADev,unsigned short AObj,int* pDir);

MT_API int __stdcall MT_Get_Axis_Status_Neg(int ADev,unsigned short AObj,int* pNeg);

MT_API int __stdcall MT_Get_Axis_Status_Pos(int ADev,unsigned short AObj,int* pPos);

MT_API int __stdcall MT_Get_Axis_Status_Zero(int ADev,unsigned short AObj,int* pZero);

MT_API int __stdcall MT_Get_Axis_Status_Mode(int ADev,unsigned short AObj,int* pMode);

MT_API int __stdcall MT_Get_Param_Mem_Len(int ADev,int* pValue);

MT_API int __stdcall MT_Get_Param_Mem_Data(int ADev,unsigned short AObj,unsigned char* pValue);

MT_API int __stdcall MT_Set_Param_Mem_Data(int ADev,unsigned short AObj,unsigned char Value);

MT_API int __stdcall MT_Get_System_Mem_Len(int ADev,int* pValue);

MT_API int __stdcall MT_Get_System_Mem_Data(int ADev,unsigned short AObj,unsigned char* pValue);

MT_API int __stdcall MT_Set_System_Mem_Data(int ADev,unsigned short AObj,unsigned char Value);

MT_API int __stdcall MT_Get_Optic_In_Num(int ADev,int* pValue);

MT_API int __stdcall MT_Get_Optic_In_Basic_Num(int ADev,int* pValue);

MT_API int __stdcall MT_Get_Optic_In_Single(int ADev,unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Get_Optic_In_All(int ADev,int* pValue);

MT_API int __stdcall MT_Get_Optic_Out_Num(int ADev,int* pValue);

MT_API int __stdcall MT_Set_Optic_Out_Single(int ADev,unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Optic_Out_All(int ADev,int Value);

MT_API int __stdcall MT_Get_Optic_Out_Single(int ADev,unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Get_Optic_Out_All(int ADev,int* pValue);

MT_API int __stdcall MT_Get_OC_Out_Num(int ADev,int* pValue);

MT_API int __stdcall MT_Set_OC_Out_Single(int ADev,unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_OC_Out_All(int ADev,int Value);

MT_API int __stdcall MT_Get_OC_Out_Single(int ADev,unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Get_OC_Out_All(int ADev,int* pValue);

MT_API int __stdcall MT_Set_Axis_Mode_Home(int ADev,unsigned short AObj);

MT_API int __stdcall MT_Set_Axis_Mode_Home_Home_Switch(int ADev,unsigned short AObj);

MT_API int __stdcall MT_Set_Axis_Mode_Home_Encoder_Index(int ADev,unsigned short AObj);

MT_API int __stdcall MT_Set_Axis_Mode_Home_Encoder_Home_Switch(int ADev,unsigned short AObj);

MT_API int __stdcall MT_Set_Axis_Mode_Home_Home_Zero(int ADev,unsigned short AObj);

MT_API int __stdcall MT_Set_Axis_Home_V(int ADev,unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Axis_Home_Stop(int ADev,unsigned short AObj);

MT_API int __stdcall MT_Set_Axis_Software_Limit_Neg_Value(int ADev,unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Axis_Software_Limit_Pos_Value(int ADev,unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Axis_Software_Limit_Enable(int ADev,unsigned short AObj);

MT_API int __stdcall MT_Set_Axis_Software_Limit_Disable(int ADev,unsigned short AObj);

MT_API int __stdcall MT_Set_Axis_Line_Axis(int ADev,unsigned short AObj,int Axis_ID0,int Axis_ID1);

MT_API int __stdcall MT_Set_Axis_Line_Acc(int ADev,unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Axis_Line_Dec(int ADev,unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Axis_Line_V(int ADev,unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Axis_Line_Run(int ADev,unsigned short AObj);

MT_API int __stdcall MT_Set_Axis_Line_Stop(int ADev,unsigned short AObj);

MT_API int __stdcall MT_Set_Axis_Line_Halt(int ADev,unsigned short AObj);

MT_API int __stdcall MT_Set_Axis_Line_Rel(int ADev,unsigned short AObj,int Axis_Target0,int Axis_Target1);

MT_API int __stdcall MT_Set_Axis_Line_Abs(int ADev,unsigned short AObj,int Axis_Target0,int Axis_Target1);

MT_API int __stdcall MT_Set_Axis_Line_Run_Rel(int ADev,unsigned short AObj,int Axis_Target0,int Axis_Target1);

MT_API int __stdcall MT_Set_Axis_Line_Run_Abs(int ADev,unsigned short AObj,int Axis_Target0,int Axis_Target1);

MT_API int __stdcall MT_Get_Axis_Line_Num(int ADev,int* pValue);

MT_API int __stdcall MT_Get_Axis_Line_Status(int ADev,unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Get_Axis_Line_Axis(int ADev,unsigned short AObj,int* pID0,int* pID1);

MT_API int __stdcall MT_Get_Axis_Line_Acc(int ADev,unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Get_Axis_Line_Dec(int ADev,unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Get_Axis_Line_V(int ADev,unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Get_AD_Num(int ADev,int* pValue);

MT_API int __stdcall MT_Get_AD_Data(int ADev,unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Get_Board_T(int ADev,int* pValue);

MT_API int __stdcall MT_Set_Axis_Circle_Axis(int ADev,unsigned short AObj,int Axis_ID0,int Axis_ID1);

MT_API int __stdcall MT_Set_Axis_Circle_Acc(int ADev,unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Axis_Circle_Dec(int ADev,unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Axis_Circle_V(int ADev,unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Axis_Circle_R_CW_Run_Rel(int ADev,unsigned short AObj,int AR,int Axis_Target0,int Axis_Target1);

MT_API int __stdcall MT_Set_Axis_Circle_R_CW_Run_Abs(int ADev,unsigned short AObj,int AR,int Axis_Target0,int Axis_Target1);

MT_API int __stdcall MT_Set_Axis_Circle_R_CCW_Run_Rel(int ADev,unsigned short AObj,int AR,int Axis_Target0,int Axis_Target1);

MT_API int __stdcall MT_Set_Axis_Circle_R_CCW_Run_Abs(int ADev,unsigned short AObj,int AR,int Axis_Target0,int Axis_Target1);

MT_API int __stdcall MT_Set_Axis_Circle_Stop(int ADev,unsigned short AObj);

MT_API int __stdcall MT_Set_Axis_Circle_Halt(int ADev,unsigned short AObj);

MT_API int __stdcall MT_Get_Axis_Circle_Num(int ADev,int* pValue);

MT_API int __stdcall MT_Get_Axis_Circle_Status(int ADev,unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Get_Axis_Circle_Axis(int ADev,unsigned short AObj,int* pID0,int* pID1);

MT_API int __stdcall MT_Get_Axis_Circle_Acc(int ADev,unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Get_Axis_Circle_Dec(int ADev,unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Get_Axis_Circle_V(int ADev,unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Get_PLC_Var_Num(int ADev,int* pValue);

MT_API int __stdcall MT_Get_PLC_Var_Data(int ADev,unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Set_PLC_Var_Data(int ADev,unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_PLC_Pause(int ADev);

MT_API int __stdcall MT_Set_PLC_Stop(int ADev);

MT_API int __stdcall MT_Set_PLC_Run(int ADev);

MT_API int __stdcall MT_Set_PLC_Data(int ADev,unsigned short AObj,unsigned char Value);

MT_API int __stdcall MT_Get_PLC_Code_Size(int ADev,int* pValue);

MT_API int __stdcall MT_Get_PLC_Task_Count(int ADev,int* pValue);

MT_API int __stdcall MT_Get_PLC_Task_Status(int ADev,int* pValue);

MT_API int __stdcall MT_Get_PLC_Var_Seg(int ADev,int* pValue);

MT_API int __stdcall MT_Get_PLC_Var_Used(int ADev,int* pValue);

MT_API int __stdcall MT_Get_PLC_Status(int ADev,int* pValue);

MT_API int __stdcall MT_Get_PLC_Tasks_Status(int ADev,int* pValue);

MT_API int __stdcall MT_Get_PLC_Axis_Ratio(int ADev,float* pValue);

MT_API int __stdcall MT_Get_PLC_Encoder_Ratio(int ADev,float* pValue);

MT_API int __stdcall MT_Set_Axis_Home_V_Start(int ADev,unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Axis_Home_Acc(int ADev,unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Axis_Home_Dec(int ADev,unsigned short AObj,int Value);

MT_API int __stdcall MT_Get_Axis_Home_Acc(int ADev,unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Get_Axis_Home_Dec(int ADev,unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Set_Axis_Velocity_V_Start(int ADev,unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Axis_Velocity_Acc(int ADev,unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Axis_Velocity_Dec(int ADev,unsigned short AObj,int Value);

MT_API int __stdcall MT_Get_Axis_Velocity_Acc(int ADev,unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Get_Axis_Velocity_Dec(int ADev,unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Set_Axis_Position_V_Start(int ADev,unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Axis_Position_Acc(int ADev,unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Axis_Position_Dec(int ADev,unsigned short AObj,int Value);

MT_API int __stdcall MT_Get_Axis_Position_Acc(int ADev,unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Get_Axis_Position_Dec(int ADev,unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Set_Axis_Line_V_Start(int ADev,unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Axis_Circle_V_Start(int ADev,unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Axis_Line_X_Run_Rel(int ADev,unsigned short AObj,int AAxis_Num,int* pAxis,int* pTarget);

MT_API int __stdcall MT_Set_Axis_Line_X_Run_Abs(int ADev,unsigned short AObj,int AAxis_Num,int* pAxis,int* pTarget);

MT_API int __stdcall MT_Set_Axis_Line_X_Target_Rel(int ADev,unsigned short AObj,int AAxisID,int ATarget);

MT_API int __stdcall MT_Set_Axis_Line_X_Target_Abs(int ADev,unsigned short AObj,int AAxisID,int ATarget);

MT_API int __stdcall MT_Set_Axis_Line_X_Count(int ADev,unsigned short AObj,int ANum);

MT_API int __stdcall MT_Set_Axis_Line_X_Axis(int ADev,unsigned short AObj,int AAxisID,int AAxis);

MT_API int __stdcall MT_Set_Stream_Run(int ADev);

MT_API int __stdcall MT_Set_Stream_Stop(int ADev);

MT_API int __stdcall MT_Set_Stream_Pause(int ADev);

MT_API int __stdcall MT_Set_Stream_Clear(int ADev);

MT_API int __stdcall MT_Get_Stream_Space(int ADev,int* pValue);

MT_API int __stdcall MT_Get_Stream_Total(int ADev,int* pValue);

MT_API int __stdcall MT_Get_Stream_Count(int ADev,int* pValue);

MT_API int __stdcall MT_Set_Stream_Delay(int ADev,int Value);

MT_API int __stdcall MT_Set_Stream_Line_Acc(int ADev,unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Stream_Line_Dec(int ADev,unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Stream_Line_V_Max(int ADev,unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Stream_Line_V_Start(int ADev,unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Stream_Line_Stop(int ADev,unsigned short AObj);

MT_API int __stdcall MT_Set_Stream_Line_Halt(int ADev,unsigned short AObj);

MT_API int __stdcall MT_Set_Stream_Line_X_Run_Rel(int ADev,unsigned short AObj,int AAxis_Num,int* pAxis,int* pTarget);

MT_API int __stdcall MT_Set_Stream_Line_X_Run_Abs(int ADev,unsigned short AObj,int AAxis_Num,int* pAxis,int* pTarget);

MT_API int __stdcall MT_Set_Stream_Circle_Axis(int ADev,unsigned short AObj,int Axis_ID0,int Axis_ID1);

MT_API int __stdcall MT_Set_Stream_Circle_Acc(int ADev,unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Stream_Circle_Dec(int ADev,unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Stream_Circle_V_Max(int ADev,unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Stream_Circle_V_Start(int ADev,unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Stream_Circle_R_CW_Run_Rel(int ADev,unsigned short AObj,int AR,int Axis_Target0,int Axis_Target1);

MT_API int __stdcall MT_Set_Stream_Circle_R_CW_Run_Abs(int ADev,unsigned short AObj,int AR,int Axis_Target0,int Axis_Target1);

MT_API int __stdcall MT_Set_Stream_Circle_R_CCW_Run_Rel(int ADev,unsigned short AObj,int AR,int Axis_Target0,int Axis_Target1);

MT_API int __stdcall MT_Set_Stream_Circle_R_CCW_Run_Abs(int ADev,unsigned short AObj,int AR,int Axis_Target0,int Axis_Target1);

MT_API int __stdcall MT_Set_Stream_Circle_Stop(int ADev,unsigned short AObj);

MT_API int __stdcall MT_Set_Stream_Circle_Halt(int ADev,unsigned short AObj);

MT_API int __stdcall MT_Set_Stream_Wait_Line(int ADev,unsigned short AObj);

MT_API int __stdcall MT_Set_Stream_Wait_Circle(int ADev,unsigned short AObj);

MT_API int __stdcall MT_Set_Stream_OC_Out_Single(int ADev,unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Stream_OC_Out_All(int ADev,int Value);

MT_API int __stdcall MT_Set_Stream_Optic_Out_Single(int ADev,unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Stream_Optic_Out_All(int ADev,int Value);

MT_API int __stdcall MT_Set_Stream_Wait_Optic_In(int ADev,unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Stream_Run_Check(int ADev);

MT_API int __stdcall MT_Set_Stream_Dec_Enable(int ADev);

MT_API int __stdcall MT_Set_Stream_Dec_Disable(int ADev);

MT_API int __stdcall MT_Get_Encoder_Num(int ADev,int* pValue);

MT_API int __stdcall MT_Get_Encoder_Pos(int ADev,unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Set_Encoder_Pos(int ADev,unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Encoder_Z_Polarity(int ADev,unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Encoder_Dir_Polarity(int ADev,unsigned short AObj,int Value);

MT_API int __stdcall MT_Get_Encoder_Index_Line_Count(int ADev,unsigned short AObj,int* pValue);

MT_API int __stdcall MT_Set_Encoder_Over_Enable(int ADev,unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Encoder_Over_Max(int ADev,unsigned short AObj,int Value);

MT_API int __stdcall MT_Set_Encoder_Over_Stable(int ADev,unsigned short AObj,int Value);

MT_API int __stdcall MT_Help_Step_Line_Real_To_Steps(double AStepAngle,int ADiv,double APitch,double ALineRatio,double AValue);

MT_API int __stdcall MT_Help_Step_Circle_Real_To_Steps(double AStepAngle,int ADiv,double ACircleRatio,double AValue);

MT_API double __stdcall MT_Help_Step_Line_Steps_To_Real(double AStepAngle,int ADiv,double APitch,double ALineRatio,int AValue);

MT_API double __stdcall MT_Help_Step_Circle_Steps_To_Real(int ADev,double AStepAngle,int ADiv,double ACircleRatio,int AValue);

MT_API int __stdcall MT_Help_Encoder_Line_Real_To_Steps(double APitch,double ALineRatio,int ALineCount,double AValue);

MT_API int __stdcall MT_Help_Encoder_Circle_Real_To_Steps(double ACircleRatio,int ALineCount,double AValue);

MT_API double __stdcall MT_Help_Encoder_Line_Steps_To_Real(double APitch,double ALineRatio,int ALineCount,int AValue);

MT_API double __stdcall MT_Help_Encoder_Circle_Steps_To_Real(double ACircleRatio,int ALineCount,int AValue);

MT_API int __stdcall MT_Help_Grating_Line_Real_To_Steps(double AUnit_um,double AValue);

MT_API int __stdcall MT_Help_Grating_Circle_Real_To_Steps(int ALineCount,double AValue);

MT_API double __stdcall MT_Help_Grating_Line_Steps_To_Real(double AUnit_um,int AValue);

MT_API double __stdcall MT_Help_Grating_Circle_Steps_To_Real(int ALineCount,int AValue);

MT_API float __stdcall MT_Help_Encoder_Factor(double AStepAngle,int ADiv,int ALineCount);

MT_API float __stdcall MT_Help_Grating_Line_Factor(double AStepAngle,int ADiv,double APitch,double ALineRatio,double AUnit_um);

MT_API float __stdcall MT_Help_Grating_Circle_Factor(double AStepAngle,int ADiv,double ACircleRatio,int ALineCount);

#endif

