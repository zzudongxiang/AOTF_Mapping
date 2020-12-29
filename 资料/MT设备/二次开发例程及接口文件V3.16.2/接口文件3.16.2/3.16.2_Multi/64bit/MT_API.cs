/*
C#接口文件
3.16.2
*/
using System;
using System.Text;
using System.Runtime.InteropServices;
public class MT_API_Multi
{

public const Int32  R_OK =0;
public const Int32  RUN_OFF =0;
public const Int32  RUN_ON =1;
public const Int32  DIR_NEG =0;
public const Int32  DIR_POS =1;
public const Int32  LIMIT_ON =1;
public const Int32  LIMIT_OFF =0;
public const Int32  RESOURCE_MOTOR =0x00000001;
public const Int32  RESOURCE_TTL_IN =0x00000002;
public const Int32  RESOURCE_TTL_OUT =0x00000004;
public const Int32  RESOURCE_OPTIC_IN =0x00000008;
public const Int32  RESOURCE_OPTIC_OUT =0x00000010;
public const Int32  RESOURCE_AD =0x00000020;
public const Int32  RESOURCE_OC =0x00000040;
public const Int32  RESOURCE_LINE =0x00000080;
public const Int32  RESOURCE_CIRCLE =0x00000100;
public const Int32  RESOURCE_PLC =0x00000200;
public const Int32  RESOURCE_STREAM =0x00000400;
public const Int32  RESOURCE_ENCODER =0x00000800;

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Init();

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_DeInit();

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Dll_Version(ref String sVer);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Thread_Timeout(UInt32 ms);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Open_UART(Int32 ADev,String sCOM);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Open_UART_Unicode(Int32 ADev,String sCOM);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Close_UART(Int32 ADev);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Open_USB(Int32 ADev);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Close_USB(Int32 ADev);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Open_Net(Int32 ADev,Byte IP0,Byte IP1,Byte IP2,Byte IP3,UInt16 IPPort);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Close_Net(Int32 ADev);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Check(Int32 ADev);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Product_Resource(Int32 ADev,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Product_ID(Int32 ADev,String sID);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Product_SN(Int32 ADev,String sSN);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Product_SN2(Int32 ADev,ref Byte sSN);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Product_SN3(Int32 ADev,String sSN);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Product_Version(Int32 ADev,ref Int32 pMajor,ref Int32 pMinor);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Product_Version2(Int32 ADev,ref Int32 pMajor,ref Int32 pMinor,ref Int32 pRelease,ref Int32 pBuild);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Num(Int32 ADev,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Acc(Int32 ADev,UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Acc(Int32 ADev,UInt16 AObj,Int32 Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Dec(Int32 ADev,UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Dec(Int32 ADev,UInt16 AObj,Int32 Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Mode(Int32 ADev,UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Mode_Velocity(Int32 ADev,UInt16 AObj);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Mode_Position(Int32 ADev,UInt16 AObj);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Mode_Position_Open(Int32 ADev,UInt16 AObj);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Mode_Position_Close(Int32 ADev,UInt16 AObj);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Velocity_V_Target(Int32 ADev,UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Velocity_V_Target_Abs(Int32 ADev,UInt16 AObj,Int32 Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Velocity_V_Target_Rel(Int32 ADev,UInt16 AObj,Int32 Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Velocity_Stop(Int32 ADev,UInt16 AObj);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Position_V_Max(Int32 ADev,UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Position_V_Max(Int32 ADev,UInt16 AObj,Int32 Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Position_P_Target(Int32 ADev,UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Position_P_Target_Abs(Int32 ADev,UInt16 AObj,Int32 Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Position_P_Target_Rel(Int32 ADev,UInt16 AObj,Int32 Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Position_Stop(Int32 ADev,UInt16 AObj);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Position_Close_Dec_Factor(Int32 ADev,UInt16 AObj,Single AFactor);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Halt(Int32 ADev,UInt16 AObj);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Halt_All(Int32 ADev);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_V_Now(Int32 ADev,UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Software_P_Now(Int32 ADev,UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Software_P(Int32 ADev,UInt16 AObj,Int32 Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Status(Int32 ADev,UInt16 AObj,ref Byte pRun,ref Byte pDir,ref Byte pNeg,ref Byte pPos,ref Byte pZero,ref Byte pMode);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Status2(Int32 ADev,UInt16 AObj,ref Int32 pRun,ref Int32 pDir,ref Int32 pNeg,ref Int32 pPos,ref Int32 pZero,ref Int32 pMode);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Status_Run(Int32 ADev,UInt16 AObj,ref Int32 pRun);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Status_Dir(Int32 ADev,UInt16 AObj,ref Int32 pDir);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Status_Neg(Int32 ADev,UInt16 AObj,ref Int32 pNeg);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Status_Pos(Int32 ADev,UInt16 AObj,ref Int32 pPos);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Status_Zero(Int32 ADev,UInt16 AObj,ref Int32 pZero);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Status_Mode(Int32 ADev,UInt16 AObj,ref Int32 pMode);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Param_Mem_Len(Int32 ADev,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Param_Mem_Data(Int32 ADev,UInt16 AObj,ref Byte pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Param_Mem_Data(Int32 ADev,UInt16 AObj,Byte Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_System_Mem_Len(Int32 ADev,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_System_Mem_Data(Int32 ADev,UInt16 AObj,ref Byte pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_System_Mem_Data(Int32 ADev,UInt16 AObj,Byte Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Optic_In_Num(Int32 ADev,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Optic_In_Basic_Num(Int32 ADev,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Optic_In_Single(Int32 ADev,UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Optic_In_All(Int32 ADev,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Optic_Out_Num(Int32 ADev,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Optic_Out_Single(Int32 ADev,UInt16 AObj,Int32 Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Optic_Out_All(Int32 ADev,Int32 Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Optic_Out_Single(Int32 ADev,UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Optic_Out_All(Int32 ADev,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_OC_Out_Num(Int32 ADev,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_OC_Out_Single(Int32 ADev,UInt16 AObj,Int32 Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_OC_Out_All(Int32 ADev,Int32 Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_OC_Out_Single(Int32 ADev,UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_OC_Out_All(Int32 ADev,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Mode_Home(Int32 ADev,UInt16 AObj);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Mode_Home_Home_Switch(Int32 ADev,UInt16 AObj);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Mode_Home_Encoder_Index(Int32 ADev,UInt16 AObj);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Mode_Home_Encoder_Home_Switch(Int32 ADev,UInt16 AObj);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Mode_Home_Home_Zero(Int32 ADev,UInt16 AObj);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Home_V(Int32 ADev,UInt16 AObj,Int32 Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Home_Stop(Int32 ADev,UInt16 AObj);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Software_Limit_Neg_Value(Int32 ADev,UInt16 AObj,Int32 Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Software_Limit_Pos_Value(Int32 ADev,UInt16 AObj,Int32 Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Software_Limit_Enable(Int32 ADev,UInt16 AObj);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Software_Limit_Disable(Int32 ADev,UInt16 AObj);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Line_Axis(Int32 ADev,UInt16 AObj,Int32 Axis_ID0,Int32 Axis_ID1);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Line_Acc(Int32 ADev,UInt16 AObj,Int32 Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Line_Dec(Int32 ADev,UInt16 AObj,Int32 Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Line_V(Int32 ADev,UInt16 AObj,Int32 Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Line_Run(Int32 ADev,UInt16 AObj);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Line_Stop(Int32 ADev,UInt16 AObj);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Line_Halt(Int32 ADev,UInt16 AObj);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Line_Rel(Int32 ADev,UInt16 AObj,Int32 Axis_Target0,Int32 Axis_Target1);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Line_Abs(Int32 ADev,UInt16 AObj,Int32 Axis_Target0,Int32 Axis_Target1);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Line_Run_Rel(Int32 ADev,UInt16 AObj,Int32 Axis_Target0,Int32 Axis_Target1);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Line_Run_Abs(Int32 ADev,UInt16 AObj,Int32 Axis_Target0,Int32 Axis_Target1);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Line_Num(Int32 ADev,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Line_Status(Int32 ADev,UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Line_Axis(Int32 ADev,UInt16 AObj,ref Int32 pID0,ref Int32 pID1);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Line_Acc(Int32 ADev,UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Line_Dec(Int32 ADev,UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Line_V(Int32 ADev,UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_AD_Num(Int32 ADev,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_AD_Data(Int32 ADev,UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Board_T(Int32 ADev,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Circle_Axis(Int32 ADev,UInt16 AObj,Int32 Axis_ID0,Int32 Axis_ID1);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Circle_Acc(Int32 ADev,UInt16 AObj,Int32 Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Circle_Dec(Int32 ADev,UInt16 AObj,Int32 Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Circle_V(Int32 ADev,UInt16 AObj,Int32 Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Circle_R_CW_Run_Rel(Int32 ADev,UInt16 AObj,Int32 AR,Int32 Axis_Target0,Int32 Axis_Target1);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Circle_R_CW_Run_Abs(Int32 ADev,UInt16 AObj,Int32 AR,Int32 Axis_Target0,Int32 Axis_Target1);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Circle_R_CCW_Run_Rel(Int32 ADev,UInt16 AObj,Int32 AR,Int32 Axis_Target0,Int32 Axis_Target1);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Circle_R_CCW_Run_Abs(Int32 ADev,UInt16 AObj,Int32 AR,Int32 Axis_Target0,Int32 Axis_Target1);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Circle_Stop(Int32 ADev,UInt16 AObj);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Circle_Halt(Int32 ADev,UInt16 AObj);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Circle_Num(Int32 ADev,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Circle_Status(Int32 ADev,UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Circle_Axis(Int32 ADev,UInt16 AObj,ref Int32 pID0,ref Int32 pID1);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Circle_Acc(Int32 ADev,UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Circle_Dec(Int32 ADev,UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Circle_V(Int32 ADev,UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_PLC_Var_Num(Int32 ADev,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_PLC_Var_Data(Int32 ADev,UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_PLC_Var_Data(Int32 ADev,UInt16 AObj,Int32 Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_PLC_Pause(Int32 ADev);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_PLC_Stop(Int32 ADev);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_PLC_Run(Int32 ADev);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_PLC_Data(Int32 ADev,UInt16 AObj,Byte Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_PLC_Code_Size(Int32 ADev,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_PLC_Task_Count(Int32 ADev,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_PLC_Task_Status(Int32 ADev,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_PLC_Var_Seg(Int32 ADev,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_PLC_Var_Used(Int32 ADev,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_PLC_Status(Int32 ADev,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_PLC_Tasks_Status(Int32 ADev,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_PLC_Axis_Ratio(Int32 ADev,ref Single pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_PLC_Encoder_Ratio(Int32 ADev,ref Single pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Home_V_Start(Int32 ADev,UInt16 AObj,Int32 Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Home_Acc(Int32 ADev,UInt16 AObj,Int32 Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Home_Dec(Int32 ADev,UInt16 AObj,Int32 Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Home_Acc(Int32 ADev,UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Home_Dec(Int32 ADev,UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Velocity_V_Start(Int32 ADev,UInt16 AObj,Int32 Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Velocity_Acc(Int32 ADev,UInt16 AObj,Int32 Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Velocity_Dec(Int32 ADev,UInt16 AObj,Int32 Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Velocity_Acc(Int32 ADev,UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Velocity_Dec(Int32 ADev,UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Position_V_Start(Int32 ADev,UInt16 AObj,Int32 Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Position_Acc(Int32 ADev,UInt16 AObj,Int32 Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Position_Dec(Int32 ADev,UInt16 AObj,Int32 Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Position_Acc(Int32 ADev,UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Axis_Position_Dec(Int32 ADev,UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Line_V_Start(Int32 ADev,UInt16 AObj,Int32 Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Circle_V_Start(Int32 ADev,UInt16 AObj,Int32 Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Line_X_Run_Rel(Int32 ADev,UInt16 AObj,Int32 AAxis_Num,ref Int32 pAxis,ref Int32 pTarget);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Line_X_Run_Abs(Int32 ADev,UInt16 AObj,Int32 AAxis_Num,ref Int32 pAxis,ref Int32 pTarget);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Line_X_Target_Rel(Int32 ADev,UInt16 AObj,Int32 AAxisID,Int32 ATarget);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Line_X_Target_Abs(Int32 ADev,UInt16 AObj,Int32 AAxisID,Int32 ATarget);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Line_X_Count(Int32 ADev,UInt16 AObj,Int32 ANum);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Axis_Line_X_Axis(Int32 ADev,UInt16 AObj,Int32 AAxisID,Int32 AAxis);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Run(Int32 ADev);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Stop(Int32 ADev);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Pause(Int32 ADev);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Clear(Int32 ADev);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Stream_Space(Int32 ADev,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Stream_Total(Int32 ADev,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Stream_Count(Int32 ADev,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Delay(Int32 ADev,Int32 Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Line_Acc(Int32 ADev,UInt16 AObj,Int32 Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Line_Dec(Int32 ADev,UInt16 AObj,Int32 Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Line_V_Max(Int32 ADev,UInt16 AObj,Int32 Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Line_V_Start(Int32 ADev,UInt16 AObj,Int32 Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Line_Stop(Int32 ADev,UInt16 AObj);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Line_Halt(Int32 ADev,UInt16 AObj);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Line_X_Run_Rel(Int32 ADev,UInt16 AObj,Int32 AAxis_Num,ref Int32 pAxis,ref Int32 pTarget);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Line_X_Run_Abs(Int32 ADev,UInt16 AObj,Int32 AAxis_Num,ref Int32 pAxis,ref Int32 pTarget);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Circle_Axis(Int32 ADev,UInt16 AObj,Int32 Axis_ID0,Int32 Axis_ID1);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Circle_Acc(Int32 ADev,UInt16 AObj,Int32 Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Circle_Dec(Int32 ADev,UInt16 AObj,Int32 Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Circle_V_Max(Int32 ADev,UInt16 AObj,Int32 Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Circle_V_Start(Int32 ADev,UInt16 AObj,Int32 Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Circle_R_CW_Run_Rel(Int32 ADev,UInt16 AObj,Int32 AR,Int32 Axis_Target0,Int32 Axis_Target1);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Circle_R_CW_Run_Abs(Int32 ADev,UInt16 AObj,Int32 AR,Int32 Axis_Target0,Int32 Axis_Target1);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Circle_R_CCW_Run_Rel(Int32 ADev,UInt16 AObj,Int32 AR,Int32 Axis_Target0,Int32 Axis_Target1);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Circle_R_CCW_Run_Abs(Int32 ADev,UInt16 AObj,Int32 AR,Int32 Axis_Target0,Int32 Axis_Target1);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Circle_Stop(Int32 ADev,UInt16 AObj);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Circle_Halt(Int32 ADev,UInt16 AObj);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Wait_Line(Int32 ADev,UInt16 AObj);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Wait_Circle(Int32 ADev,UInt16 AObj);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_OC_Out_Single(Int32 ADev,UInt16 AObj,Int32 Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_OC_Out_All(Int32 ADev,Int32 Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Optic_Out_Single(Int32 ADev,UInt16 AObj,Int32 Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Optic_Out_All(Int32 ADev,Int32 Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Wait_Optic_In(Int32 ADev,UInt16 AObj,Int32 Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Run_Check(Int32 ADev);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Dec_Enable(Int32 ADev);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Stream_Dec_Disable(Int32 ADev);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Encoder_Num(Int32 ADev,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Encoder_Pos(Int32 ADev,UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Encoder_Pos(Int32 ADev,UInt16 AObj,Int32 Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Encoder_Z_Polarity(Int32 ADev,UInt16 AObj,Int32 Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Encoder_Dir_Polarity(Int32 ADev,UInt16 AObj,Int32 Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Get_Encoder_Index_Line_Count(Int32 ADev,UInt16 AObj,ref Int32 pValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Encoder_Over_Enable(Int32 ADev,UInt16 AObj,Int32 Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Encoder_Over_Max(Int32 ADev,UInt16 AObj,Int32 Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Set_Encoder_Over_Stable(Int32 ADev,UInt16 AObj,Int32 Value);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Help_Step_Line_Real_To_Steps(Double AStepAngle,Int32 ADiv,Double APitch,Double ALineRatio,Double AValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Help_Step_Circle_Real_To_Steps(Double AStepAngle,Int32 ADiv,Double ACircleRatio,Double AValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Double MT_Help_Step_Line_Steps_To_Real(Double AStepAngle,Int32 ADiv,Double APitch,Double ALineRatio,Int32 AValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Double MT_Help_Step_Circle_Steps_To_Real(Int32 ADev,Double AStepAngle,Int32 ADiv,Double ACircleRatio,Int32 AValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Help_Encoder_Line_Real_To_Steps(Double APitch,Double ALineRatio,Int32 ALineCount,Double AValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Help_Encoder_Circle_Real_To_Steps(Double ACircleRatio,Int32 ALineCount,Double AValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Double MT_Help_Encoder_Line_Steps_To_Real(Double APitch,Double ALineRatio,Int32 ALineCount,Int32 AValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Double MT_Help_Encoder_Circle_Steps_To_Real(Double ACircleRatio,Int32 ALineCount,Int32 AValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Help_Grating_Line_Real_To_Steps(Double AUnit_um,Double AValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Int32 MT_Help_Grating_Circle_Real_To_Steps(Int32 ALineCount,Double AValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Double MT_Help_Grating_Line_Steps_To_Real(Double AUnit_um,Int32 AValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Double MT_Help_Grating_Circle_Steps_To_Real(Int32 ALineCount,Int32 AValue);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Single MT_Help_Encoder_Factor(Double AStepAngle,Int32 ADiv,Int32 ALineCount);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Single MT_Help_Grating_Line_Factor(Double AStepAngle,Int32 ADiv,Double APitch,Double ALineRatio,Double AUnit_um);

[DllImport("MT_API_Multi.dll",CharSet=CharSet.Ansi,CallingConvention=CallingConvention.StdCall)]
public static extern Single MT_Help_Grating_Circle_Factor(Double AStepAngle,Int32 ADiv,Double ACircleRatio,Int32 ALineCount);

}

