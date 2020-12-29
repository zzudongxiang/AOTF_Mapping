#Attribute VB_Name = "MoTech"
"VB.net接口文件
"3.16.2

Imports System
Imports System.Text
Imports System.Runtime.InteropServices
Public Class MT_API_Multi

Public Const R_OK =0
Public Const RUN_OFF =0
Public Const RUN_ON =1
Public Const DIR_NEG =0
Public Const DIR_POS =1
Public Const LIMIT_ON =1
Public Const LIMIT_OFF =0
Public Const RESOURCE_MOTOR =&H00000001
Public Const RESOURCE_TTL_IN =&H00000002
Public Const RESOURCE_TTL_OUT =&H00000004
Public Const RESOURCE_OPTIC_IN =&H00000008
Public Const RESOURCE_OPTIC_OUT =&H00000010
Public Const RESOURCE_AD =&H00000020
Public Const RESOURCE_OC =&H00000040
Public Const RESOURCE_LINE =&H00000080
Public Const RESOURCE_CIRCLE =&H00000100
Public Const RESOURCE_PLC =&H00000200
Public Const RESOURCE_STREAM =&H00000400
Public Const RESOURCE_ENCODER =&H00000800

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Init() As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_DeInit() As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Dll_Version(ByRef sVer As String) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Thread_Timeout(ByVal ms As UInt32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Open_UART(ByVal ADev As Int32,ByVal sCOM As String) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Open_UART_Unicode(ByVal ADev As Int32,ByVal sCOM As String) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Close_UART(ByVal ADev As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Open_USB(ByVal ADev As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Close_USB(ByVal ADev As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Open_Net(ByVal ADev As Int32,ByVal IP0 As Byte,ByVal IP1 As Byte,ByVal IP2 As Byte,ByVal IP3 As Byte,ByVal IPPort As UInt16) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Close_Net(ByVal ADev As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Check(ByVal ADev As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Product_Resource(ByVal ADev As Int32,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Product_ID(ByVal ADev As Int32,ByVal sID As String) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Product_SN(ByVal ADev As Int32,ByVal sSN As String) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Product_SN2(ByVal ADev As Int32,ByRef sSN As Byte) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Product_SN3(ByVal ADev As Int32,ByVal sSN As String) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Product_Version(ByVal ADev As Int32,ByRef pMajor As Int32,ByRef pMinor As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Product_Version2(ByVal ADev As Int32,ByRef pMajor As Int32,ByRef pMinor As Int32,ByRef pRelease As Int32,ByRef pBuild As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Num(ByVal ADev As Int32,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Acc(ByVal ADev As Int32,ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Acc(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Dec(ByVal ADev As Int32,ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Dec(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Mode(ByVal ADev As Int32,ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Mode_Velocity(ByVal ADev As Int32,ByVal AObj As UInt16) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Mode_Position(ByVal ADev As Int32,ByVal AObj As UInt16) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Mode_Position_Open(ByVal ADev As Int32,ByVal AObj As UInt16) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Mode_Position_Close(ByVal ADev As Int32,ByVal AObj As UInt16) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Velocity_V_Target(ByVal ADev As Int32,ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Velocity_V_Target_Abs(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Velocity_V_Target_Rel(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Velocity_Stop(ByVal ADev As Int32,ByVal AObj As UInt16) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Position_V_Max(ByVal ADev As Int32,ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Position_V_Max(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Position_P_Target(ByVal ADev As Int32,ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Position_P_Target_Abs(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Position_P_Target_Rel(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Position_Stop(ByVal ADev As Int32,ByVal AObj As UInt16) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Position_Close_Dec_Factor(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal AFactor As Single) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Halt(ByVal ADev As Int32,ByVal AObj As UInt16) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Halt_All(ByVal ADev As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_V_Now(ByVal ADev As Int32,ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Software_P_Now(ByVal ADev As Int32,ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Software_P(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Status(ByVal ADev As Int32,ByVal AObj As UInt16,ByRef pRun As Byte,ByRef pDir As Byte,ByRef pNeg As Byte,ByRef pPos As Byte,ByRef pZero As Byte,ByRef pMode As Byte) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Status2(ByVal ADev As Int32,ByVal AObj As UInt16,ByRef pRun As Int32,ByRef pDir As Int32,ByRef pNeg As Int32,ByRef pPos As Int32,ByRef pZero As Int32,ByRef pMode As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Status_Run(ByVal ADev As Int32,ByVal AObj As UInt16,ByRef pRun As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Status_Dir(ByVal ADev As Int32,ByVal AObj As UInt16,ByRef pDir As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Status_Neg(ByVal ADev As Int32,ByVal AObj As UInt16,ByRef pNeg As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Status_Pos(ByVal ADev As Int32,ByVal AObj As UInt16,ByRef pPos As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Status_Zero(ByVal ADev As Int32,ByVal AObj As UInt16,ByRef pZero As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Status_Mode(ByVal ADev As Int32,ByVal AObj As UInt16,ByRef pMode As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Param_Mem_Len(ByVal ADev As Int32,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Param_Mem_Data(ByVal ADev As Int32,ByVal AObj As UInt16,ByRef pValue As Byte) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Param_Mem_Data(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Value As Byte) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_System_Mem_Len(ByVal ADev As Int32,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_System_Mem_Data(ByVal ADev As Int32,ByVal AObj As UInt16,ByRef pValue As Byte) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_System_Mem_Data(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Value As Byte) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Optic_In_Num(ByVal ADev As Int32,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Optic_In_Basic_Num(ByVal ADev As Int32,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Optic_In_Single(ByVal ADev As Int32,ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Optic_In_All(ByVal ADev As Int32,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Optic_Out_Num(ByVal ADev As Int32,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Optic_Out_Single(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Optic_Out_All(ByVal ADev As Int32,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Optic_Out_Single(ByVal ADev As Int32,ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Optic_Out_All(ByVal ADev As Int32,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_OC_Out_Num(ByVal ADev As Int32,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_OC_Out_Single(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_OC_Out_All(ByVal ADev As Int32,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_OC_Out_Single(ByVal ADev As Int32,ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_OC_Out_All(ByVal ADev As Int32,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Mode_Home(ByVal ADev As Int32,ByVal AObj As UInt16) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Mode_Home_Home_Switch(ByVal ADev As Int32,ByVal AObj As UInt16) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Mode_Home_Encoder_Index(ByVal ADev As Int32,ByVal AObj As UInt16) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Mode_Home_Encoder_Home_Switch(ByVal ADev As Int32,ByVal AObj As UInt16) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Mode_Home_Home_Zero(ByVal ADev As Int32,ByVal AObj As UInt16) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Home_V(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Home_Stop(ByVal ADev As Int32,ByVal AObj As UInt16) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Software_Limit_Neg_Value(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Software_Limit_Pos_Value(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Software_Limit_Enable(ByVal ADev As Int32,ByVal AObj As UInt16) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Software_Limit_Disable(ByVal ADev As Int32,ByVal AObj As UInt16) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Line_Axis(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Axis_ID0 As Int32,ByVal Axis_ID1 As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Line_Acc(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Line_Dec(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Line_V(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Line_Run(ByVal ADev As Int32,ByVal AObj As UInt16) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Line_Stop(ByVal ADev As Int32,ByVal AObj As UInt16) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Line_Halt(ByVal ADev As Int32,ByVal AObj As UInt16) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Line_Rel(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Axis_Target0 As Int32,ByVal Axis_Target1 As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Line_Abs(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Axis_Target0 As Int32,ByVal Axis_Target1 As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Line_Run_Rel(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Axis_Target0 As Int32,ByVal Axis_Target1 As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Line_Run_Abs(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Axis_Target0 As Int32,ByVal Axis_Target1 As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Line_Num(ByVal ADev As Int32,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Line_Status(ByVal ADev As Int32,ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Line_Axis(ByVal ADev As Int32,ByVal AObj As UInt16,ByRef pID0 As Int32,ByRef pID1 As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Line_Acc(ByVal ADev As Int32,ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Line_Dec(ByVal ADev As Int32,ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Line_V(ByVal ADev As Int32,ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_AD_Num(ByVal ADev As Int32,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_AD_Data(ByVal ADev As Int32,ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Board_T(ByVal ADev As Int32,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Circle_Axis(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Axis_ID0 As Int32,ByVal Axis_ID1 As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Circle_Acc(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Circle_Dec(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Circle_V(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Circle_R_CW_Run_Rel(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal AR As Int32,ByVal Axis_Target0 As Int32,ByVal Axis_Target1 As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Circle_R_CW_Run_Abs(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal AR As Int32,ByVal Axis_Target0 As Int32,ByVal Axis_Target1 As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Circle_R_CCW_Run_Rel(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal AR As Int32,ByVal Axis_Target0 As Int32,ByVal Axis_Target1 As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Circle_R_CCW_Run_Abs(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal AR As Int32,ByVal Axis_Target0 As Int32,ByVal Axis_Target1 As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Circle_Stop(ByVal ADev As Int32,ByVal AObj As UInt16) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Circle_Halt(ByVal ADev As Int32,ByVal AObj As UInt16) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Circle_Num(ByVal ADev As Int32,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Circle_Status(ByVal ADev As Int32,ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Circle_Axis(ByVal ADev As Int32,ByVal AObj As UInt16,ByRef pID0 As Int32,ByRef pID1 As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Circle_Acc(ByVal ADev As Int32,ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Circle_Dec(ByVal ADev As Int32,ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Circle_V(ByVal ADev As Int32,ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_PLC_Var_Num(ByVal ADev As Int32,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_PLC_Var_Data(ByVal ADev As Int32,ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_PLC_Var_Data(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_PLC_Pause(ByVal ADev As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_PLC_Stop(ByVal ADev As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_PLC_Run(ByVal ADev As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_PLC_Data(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Value As Byte) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_PLC_Code_Size(ByVal ADev As Int32,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_PLC_Task_Count(ByVal ADev As Int32,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_PLC_Task_Status(ByVal ADev As Int32,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_PLC_Var_Seg(ByVal ADev As Int32,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_PLC_Var_Used(ByVal ADev As Int32,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_PLC_Status(ByVal ADev As Int32,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_PLC_Tasks_Status(ByVal ADev As Int32,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_PLC_Axis_Ratio(ByVal ADev As Int32,ByRef pValue As Single) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_PLC_Encoder_Ratio(ByVal ADev As Int32,ByRef pValue As Single) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Home_V_Start(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Home_Acc(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Home_Dec(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Home_Acc(ByVal ADev As Int32,ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Home_Dec(ByVal ADev As Int32,ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Velocity_V_Start(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Velocity_Acc(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Velocity_Dec(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Velocity_Acc(ByVal ADev As Int32,ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Velocity_Dec(ByVal ADev As Int32,ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Position_V_Start(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Position_Acc(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Position_Dec(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Position_Acc(ByVal ADev As Int32,ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Axis_Position_Dec(ByVal ADev As Int32,ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Line_V_Start(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Circle_V_Start(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Line_X_Run_Rel(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal AAxis_Num As Int32,ByRef pAxis As Int32,ByRef pTarget As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Line_X_Run_Abs(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal AAxis_Num As Int32,ByRef pAxis As Int32,ByRef pTarget As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Line_X_Target_Rel(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal AAxisID As Int32,ByVal ATarget As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Line_X_Target_Abs(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal AAxisID As Int32,ByVal ATarget As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Line_X_Count(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal ANum As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Axis_Line_X_Axis(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal AAxisID As Int32,ByVal AAxis As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Run(ByVal ADev As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Stop(ByVal ADev As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Pause(ByVal ADev As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Clear(ByVal ADev As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Stream_Space(ByVal ADev As Int32,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Stream_Total(ByVal ADev As Int32,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Stream_Count(ByVal ADev As Int32,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Delay(ByVal ADev As Int32,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Line_Acc(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Line_Dec(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Line_V_Max(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Line_V_Start(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Line_Stop(ByVal ADev As Int32,ByVal AObj As UInt16) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Line_Halt(ByVal ADev As Int32,ByVal AObj As UInt16) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Line_X_Run_Rel(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal AAxis_Num As Int32,ByRef pAxis As Int32,ByRef pTarget As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Line_X_Run_Abs(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal AAxis_Num As Int32,ByRef pAxis As Int32,ByRef pTarget As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Circle_Axis(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Axis_ID0 As Int32,ByVal Axis_ID1 As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Circle_Acc(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Circle_Dec(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Circle_V_Max(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Circle_V_Start(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Circle_R_CW_Run_Rel(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal AR As Int32,ByVal Axis_Target0 As Int32,ByVal Axis_Target1 As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Circle_R_CW_Run_Abs(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal AR As Int32,ByVal Axis_Target0 As Int32,ByVal Axis_Target1 As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Circle_R_CCW_Run_Rel(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal AR As Int32,ByVal Axis_Target0 As Int32,ByVal Axis_Target1 As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Circle_R_CCW_Run_Abs(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal AR As Int32,ByVal Axis_Target0 As Int32,ByVal Axis_Target1 As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Circle_Stop(ByVal ADev As Int32,ByVal AObj As UInt16) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Circle_Halt(ByVal ADev As Int32,ByVal AObj As UInt16) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Wait_Line(ByVal ADev As Int32,ByVal AObj As UInt16) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Wait_Circle(ByVal ADev As Int32,ByVal AObj As UInt16) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_OC_Out_Single(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_OC_Out_All(ByVal ADev As Int32,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Optic_Out_Single(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Optic_Out_All(ByVal ADev As Int32,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Wait_Optic_In(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Run_Check(ByVal ADev As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Dec_Enable(ByVal ADev As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Stream_Dec_Disable(ByVal ADev As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Encoder_Num(ByVal ADev As Int32,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Encoder_Pos(ByVal ADev As Int32,ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Encoder_Pos(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Encoder_Z_Polarity(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Encoder_Dir_Polarity(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Get_Encoder_Index_Line_Count(ByVal ADev As Int32,ByVal AObj As UInt16,ByRef pValue As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Encoder_Over_Enable(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Encoder_Over_Max(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Set_Encoder_Over_Stable(ByVal ADev As Int32,ByVal AObj As UInt16,ByVal Value As Int32) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Help_Step_Line_Real_To_Steps(ByVal AStepAngle As Double,ByVal ADiv As Int32,ByVal APitch As Double,ByVal ALineRatio As Double,ByVal AValue As Double) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Help_Step_Circle_Real_To_Steps(ByVal AStepAngle As Double,ByVal ADiv As Int32,ByVal ACircleRatio As Double,ByVal AValue As Double) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Help_Step_Line_Steps_To_Real(ByVal AStepAngle As Double,ByVal ADiv As Int32,ByVal APitch As Double,ByVal ALineRatio As Double,ByVal AValue As Int32) As Double
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Help_Step_Circle_Steps_To_Real(ByVal ADev As Int32,ByVal AStepAngle As Double,ByVal ADiv As Int32,ByVal ACircleRatio As Double,ByVal AValue As Int32) As Double
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Help_Encoder_Line_Real_To_Steps(ByVal APitch As Double,ByVal ALineRatio As Double,ByVal ALineCount As Int32,ByVal AValue As Double) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Help_Encoder_Circle_Real_To_Steps(ByVal ACircleRatio As Double,ByVal ALineCount As Int32,ByVal AValue As Double) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Help_Encoder_Line_Steps_To_Real(ByVal APitch As Double,ByVal ALineRatio As Double,ByVal ALineCount As Int32,ByVal AValue As Int32) As Double
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Help_Encoder_Circle_Steps_To_Real(ByVal ACircleRatio As Double,ByVal ALineCount As Int32,ByVal AValue As Int32) As Double
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Help_Grating_Line_Real_To_Steps(ByVal AUnit_um As Double,ByVal AValue As Double) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Help_Grating_Circle_Real_To_Steps(ByVal ALineCount As Int32,ByVal AValue As Double) As Integer
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Help_Grating_Line_Steps_To_Real(ByVal AUnit_um As Double,ByVal AValue As Int32) As Double
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Help_Grating_Circle_Steps_To_Real(ByVal ALineCount As Int32,ByVal AValue As Int32) As Double
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Help_Encoder_Factor(ByVal AStepAngle As Double,ByVal ADiv As Int32,ByVal ALineCount As Int32) As Single
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Help_Grating_Line_Factor(ByVal AStepAngle As Double,ByVal ADiv As Int32,ByVal APitch As Double,ByVal ALineRatio As Double,ByVal AUnit_um As Double) As Single
End Function

<DllImport("MT_API_Multi.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Winapi)> Public Shared Function MT_Help_Grating_Circle_Factor(ByVal AStepAngle As Double,ByVal ADiv As Int32,ByVal ACircleRatio As Double,ByVal ALineCount As Int32) As Single
End Function

End Class

