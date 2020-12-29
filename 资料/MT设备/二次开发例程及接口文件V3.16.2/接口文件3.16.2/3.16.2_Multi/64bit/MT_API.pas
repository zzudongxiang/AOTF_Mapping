unit MT_API;
//**************************************************//
// V3.16.0 updated 2017-01-30
//**************************************************//
interface
//==================================================
//���л���
//===================================================
//dll�汾
//��ʼ������
function MT_Init():Integer;stdcall;external 'MT_API.dll'
//�رմ���
function MT_DeInit():Integer;stdcall;external 'MT_API.dll'
//��ȡdll�汾��
function MT_Get_Dll_Version(sVer:PPChar):Integer;stdcall;external 'MT_API.dll'

function MT_Set_Thread_Timeout(ms:Cardinal):Integer;stdcall;external 'MT_API.dll'

//======================================================
//ͨ�ſ�
//======================================================
//�� UART
function MT_Open_UART(ADev:Integer;sCOM:PAnsiChar):Integer;stdcall;external 'MT_API.dll'
function MT_Open_UART_Unicode(ADev:Integer;sCOM:PChar):Integer;stdcall;external 'MT_API.dll'
//�ر� UART
function MT_Close_UART(ADev:Integer):Integer;stdcall;external 'MT_API.dll'

//��USB
function MT_Open_USB(ADev:Integer):Integer;stdcall;external 'MT_API.dll'
//�ر�USB
function MT_Close_USB(ADev:Integer):Integer;stdcall;external 'MT_API.dll'

//������
function MT_Open_Net(ADev:Integer;IP0,IP1,IP2,IP3:Byte;IPPort:Word):Integer;stdcall;external 'MT_API.dll'
//�ر�����
function MT_Close_Net(ADev:Integer):Integer;stdcall;external 'MT_API.dll'

//=====================================================
//�忨���
//=====================================================
//����豸
function MT_Check(ADev:Integer):Integer;stdcall;external 'MT_API.dll'
//��ȡ��Դģ��
function MT_Get_Product_Resource(ADev:Integer;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//��ȡID
function MT_Get_Product_ID(ADev:Integer;sID:PAnsiChar):Integer;stdcall;external 'MT_API.dll'
//��ȡSN
function MT_Get_Product_SN(ADev:Integer;sSN:PAnsiChar):Integer;stdcall;external 'MT_API.dll'
function MT_Get_Product_SN2(ADev:Integer;sSN:PByte):Integer;stdcall;external 'MT_API.dll'
function MT_Get_Product_SN3(ADev:Integer;sSN:PAnsiChar):Integer;stdcall;external 'MT_API.dll'
//��ȡ�̼��汾��
function MT_Get_Product_Version(ADev:Integer;pMajor:PInteger;pMinor:PInteger):Integer;stdcall;external 'MT_API.dll'
function MT_Get_Product_Version2(ADev:Integer;pMajor:PInteger;pMinor:PInteger;
   pRelease:PInteger;pBuild:PInteger):Integer;stdcall;external 'MT_API.dll'
//===================================================================
//�忨�¶�
//===================================================================
//��ȡ�¶�
//function MT_Get_Board_Temperature(pValue:PDouble):Integer;stdcall;external 'MT_API.dll'

//===================================================================
//������
//====================================================================
//����
function MT_Get_Axis_Num(ADev:Integer;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//��ȡ���ٶ�
function MT_Get_Axis_Acc(ADev:Integer;AObj:Word;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//���ü��ٶ�
function MT_Set_Axis_Acc(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//��ȡ���ٶ�
function MT_Get_Axis_Dec(ADev:Integer;AObj:Word;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//���ü��ٶ�
function MT_Set_Axis_Dec(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//��ȡ����ģʽ
function MT_Get_Axis_Mode(ADev:Integer;AObj:Word;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//�����ٶ�ģʽ
function MT_Set_Axis_Mode_Velocity(ADev:Integer;AObj:Word):Integer;stdcall;external 'MT_API.dll'
//����λ��ģʽ
function MT_Set_Axis_Mode_Position(ADev:Integer;AObj:Word):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Axis_Mode_Position_Open(ADev:Integer;AObj:Word):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Axis_Mode_Position_Close(ADev:Integer;AObj:Word):Integer;stdcall;external 'MT_API.dll'
//��ȡ�ٶ�ģʽĿ���ٶ�
function MT_Get_Axis_Velocity_V_Target(ADev:Integer;AObj:Word;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//�����ٶ�ģʽĿ���ٶ�
function MT_Set_Axis_Velocity_V_Target_Abs(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//�����ٶ�ģʽĿ���ٶ�
function MT_Set_Axis_Velocity_V_Target_Rel(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//ֹͣ�ٶ�ģʽ
function MT_Set_Axis_Velocity_Stop(ADev:Integer;AObj:Word):Integer;stdcall;external 'MT_API.dll'

//��ȡλ��ģʽ����ٶ�
function MT_Get_Axis_Position_V_Max(ADev:Integer;AObj:Word;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//����λ��ģʽ����ٶ�
function MT_Set_Axis_Position_V_Max(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//��ȡλ��ģʽĿ��
function MT_Get_Axis_Position_P_Target(ADev:Integer;AObj:Word;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//����λ��ģʽĿ��
function MT_Set_Axis_Position_P_Target_Abs(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Axis_Position_P_Target_Rel(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//ֹͣλ��ģʽ
function MT_Set_Axis_Position_Stop(ADev:Integer;AObj:Word):Integer;stdcall;external 'MT_API.dll'
//���ñ���������,���ڼ����ж���
function MT_Set_Axis_Position_Close_Dec_Factor(ADev:Integer;AObj:Word;AFactor:Single):Integer;stdcall;external 'MT_API.dll'

//����ֹͣ
function MT_Set_Axis_Halt(ADev:Integer;AObj:Word):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Axis_Halt_All(ADev:Integer):Integer;stdcall;external 'MT_API.dll'

//////////////////////////////////////////////////////////////
///  ״̬���
///  //////////////////////////////////////////////////////
//��ȡ��ǰ�ٶ�
function MT_Get_Axis_V_Now(ADev:Integer;AObj:Word;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//��ȡ��ǰ���λ��
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
//�洢��
//��ȡ�洢������
function MT_Get_Param_Mem_Len(ADev:Integer;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//��ȡ�洢������
function MT_Get_Param_Mem_Data(ADev:Integer;AObj:Word;pValue:PByte):Integer;stdcall;external 'MT_API.dll'
//���ô洢������
function MT_Set_Param_Mem_Data(ADev:Integer;AObj:Word;Value:Byte):Integer;stdcall;external 'MT_API.dll'
////////////////////////////////////////////////////////////////////////
//ϵͳ�洢��
//��ȡ�洢������
function MT_Get_System_Mem_Len(ADev:Integer;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//��ȡ�洢������
function MT_Get_System_Mem_Data(ADev:Integer;AObj:Word;pValue:PByte):Integer;stdcall;external 'MT_API.dll'
//���ô洢������
function MT_Set_System_Mem_Data(ADev:Integer;AObj:Word;Value:Byte):Integer;stdcall;external 'MT_API.dll'
//�������
function MT_Get_Optic_In_Num(ADev:Integer;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
function MT_Get_Optic_In_Basic_Num(ADev:Integer;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
function MT_Get_Optic_In_Single(ADev:Integer;AObj:Word;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
function MT_Get_Optic_In_All(ADev:Integer;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//������
function MT_Get_Optic_Out_Num(ADev:Integer;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Optic_Out_Single(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Optic_Out_All(ADev:Integer;Value:Integer):Integer;stdcall;external 'MT_API.dll'
function MT_Get_Optic_Out_Single(ADev:Integer;AObj:Word;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
function MT_Get_Optic_Out_All(ADev:Integer;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//OC���
function MT_Get_OC_Out_Num(ADev:Integer;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
function MT_Set_OC_Out_Single(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
function MT_Set_OC_Out_All(ADev:Integer;Value:Integer):Integer;stdcall;external 'MT_API.dll'
function MT_Get_OC_Out_Single(ADev:Integer;AObj:Word;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
function MT_Get_OC_Out_All(ADev:Integer;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//����0λģʽ
function MT_Set_Axis_Mode_Home(ADev:Integer;AObj:Word):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Axis_Mode_Home_Home_Switch(ADev:Integer;AObj:Word):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Axis_Mode_Home_Encoder_Index(ADev:Integer;AObj:Word):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Axis_Mode_Home_Encoder_Home_Switch(ADev:Integer;AObj:Word):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Axis_Mode_Home_Home_Zero(ADev:Integer;AObj:Word):Integer;stdcall;external 'MT_API.dll'
//����0λģʽĿ���ٶ�
function MT_Set_Axis_Home_V(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//ֹͣ0λģʽ
function MT_Set_Axis_Home_Stop(ADev:Integer;AObj:Word):Integer;stdcall;external 'MT_API.dll'


//�����λ
//���������λֵ
function MT_Set_Axis_Software_Limit_Neg_Value
   (ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall; external 'MT_API.dll'
//���������λֵ
function MT_Set_Axis_Software_Limit_Pos_Value
   (ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//ʹ�������λģʽ
function MT_Set_Axis_Software_Limit_Enable(ADev:Integer;AObj:Word):Integer;stdcall;external 'MT_API.dll'
//ֹͣ�����λģʽ
function MT_Set_Axis_Software_Limit_Disable(ADev:Integer;AObj:Word):Integer;stdcall;external 'MT_API.dll'
//ֱ�߲岹���
//����ֱ�߲岹���ἰ�ٶ�
function MT_Set_Axis_Line_Axis(ADev:Integer;AObj:Word;Axis_ID0,Axis_ID1:Integer):Integer;stdcall;external 'MT_API.dll'
//����ֱ�߲岹���ٶ�
function MT_Set_Axis_Line_Acc(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//����ֱ�߲岹���ٶ�
function MT_Set_Axis_Line_Dec(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//����ֱ�߲岹�ٶ�
function MT_Set_Axis_Line_V(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//����ֱ�߲岹����
function MT_Set_Axis_Line_Run(ADev:Integer;AObj:Word):Integer;stdcall;external 'MT_API.dll'
//����ֱ�߲岹ֹͣ
function MT_Set_Axis_Line_Stop(ADev:Integer;AObj:Word):Integer;stdcall;external 'MT_API.dll'
//����ֱ�߲岹��ͣ
function MT_Set_Axis_Line_Halt(ADev:Integer;AObj:Word):Integer;stdcall;external 'MT_API.dll'
//����ֱ�߲岹����ƶ�Ŀ��
function MT_Set_Axis_Line_Rel(ADev:Integer;AObj:Word;
    Axis_Target0,Axis_Target1:Integer):Integer;stdcall;external 'MT_API.dll'
//����ֱ�߲岹�����ƶ�Ŀ��
function MT_Set_Axis_Line_Abs(ADev:Integer;AObj:Word;
    Axis_Target0,Axis_Target1:Integer):Integer;stdcall;external 'MT_API.dll'
//����ֱ�߲岹����
function MT_Set_Axis_Line_Run_Rel(ADev:Integer;AObj:Word;
    Axis_Target0,Axis_Target1:Integer):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Axis_Line_Run_Abs(ADev:Integer;AObj:Word;
    Axis_Target0,Axis_Target1:Integer):Integer;stdcall;external 'MT_API.dll'
//��ȡֱ�߲岹ģ��
function MT_Get_Axis_Line_Num(ADev:Integer;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//�岹�˶�״̬
function MT_Get_Axis_Line_Status(ADev:Integer;AObj:Word;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//�岹��
function MT_Get_Axis_Line_Axis(ADev:Integer;AObj:Word;pID0,pID1:PInteger):Integer;stdcall;external 'MT_API.dll'
//�岹���ٶ�
function MT_Get_Axis_Line_Acc(ADev:Integer;AObj:Word;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//�岹���ٶ�
function MT_Get_Axis_Line_Dec(ADev:Integer;AObj:Word;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//�岹�ٶ�
function MT_Get_Axis_Line_V(ADev:Integer;AObj:Word;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'

//AD����
function MT_Get_AD_Num(ADev:Integer;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
function MT_Get_AD_Data(ADev:Integer;AObj:Word;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
function MT_Get_Board_T(ADev:Integer;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'

//================================================================
//Բ���岹
//================================================================
//����Բ���岹���ἰ�ٶ�
function MT_Set_Axis_Circle_Axis(ADev:Integer;AObj:Word;Axis_ID0,Axis_ID1:Integer):Integer;stdcall;external 'MT_API.dll'
//����Բ���岹���ٶ�
function MT_Set_Axis_Circle_Acc(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//����Բ���岹���ٶ�
function MT_Set_Axis_Circle_Dec(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//����Բ���岹�ٶ�
function MT_Set_Axis_Circle_V(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'

//����Բ���岹���� ˳ʱ��  Բ������ģʽ
function MT_Set_Axis_Circle_R_CW_Run_Rel(ADev:Integer;AObj:Word;AR:Integer;
                  Axis_Target0,Axis_Target1:Integer):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Axis_Circle_R_CW_Run_Abs(ADev:Integer;AObj:Word;AR:Integer;
                  Axis_Target0,Axis_Target1:Integer):Integer;stdcall;external 'MT_API.dll'
//����Բ���岹���� ��ʱ��   Բ������
function MT_Set_Axis_Circle_R_CCW_Run_Rel(ADev:Integer;AObj:Word;AR:Integer;
                  Axis_Target0,Axis_Target1:Integer):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Axis_Circle_R_CCW_Run_Abs(ADev:Integer;AObj:Word;AR:Integer;
                  Axis_Target0,Axis_Target1:Integer):Integer;stdcall;external 'MT_API.dll'
//����Բ���岹ֹͣ
function MT_Set_Axis_Circle_Stop(ADev:Integer;AObj:Word):Integer;stdcall;external 'MT_API.dll'
//����Բ���岹��ͣ
function MT_Set_Axis_Circle_Halt(ADev:Integer;AObj:Word):Integer;stdcall;external 'MT_API.dll'

//��ȡԲ���岹ģ��
function MT_Get_Axis_Circle_Num(ADev:Integer;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//�岹�˶�״̬
function MT_Get_Axis_Circle_Status(ADev:Integer;AObj:Word;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//�岹��
function MT_Get_Axis_Circle_Axis(ADev:Integer;AObj:Word;pID0,pID1:PInteger):Integer;stdcall;external 'MT_API.dll'
//�岹���ٶ�
function MT_Get_Axis_Circle_Acc(ADev:Integer;AObj:Word;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//�岹���ٶ�
function MT_Get_Axis_Circle_Dec(ADev:Integer;AObj:Word;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//�岹�ٶ�
function MT_Get_Axis_Circle_V(ADev:Integer;AObj:Word;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'

//PLC��صĺ���
//PLC��ص�ָ����
//�������洢����С
function MT_Get_PLC_Var_Num(ADev:Integer;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//������
function MT_Get_PLC_Var_Data(ADev:Integer;AObj:Word;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//д����
function MT_Set_PLC_Var_Data(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//��ͣPLC
function MT_Set_PLC_Pause(ADev:Integer):Integer;stdcall;external 'MT_API.dll'
//ֹͣPLC
function MT_Set_PLC_Stop(ADev:Integer):Integer;stdcall;external 'MT_API.dll'
//����PLC����
function MT_Set_PLC_Run(ADev:Integer):Integer;stdcall;external 'MT_API.dll'
//����PLC�������
function MT_Set_PLC_Data(ADev:Integer;AObj:Word;Value:Byte):Integer;stdcall;external 'MT_API.dll'
//��ȡPLC��������С
function MT_Get_PLC_Code_Size(ADev:Integer;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'

//2017 01 30 PLC V6 Add
//��ȡ�������
//PLC������
function MT_Get_PLC_Task_Count(
  ADev:Integer;
  pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//PLC����״̬
function MT_Get_PLC_Task_Status(
  ADev:Integer;
  pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//�����ָ�
function MT_Get_PLC_Var_Seg(
  ADev:Integer;
  pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//��������
function MT_Get_PLC_Var_Used(
  ADev:Integer;
  pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//PLC״̬
function MT_Get_PLC_Status(
  ADev:Integer;
  pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//ȫ��״̬
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
//2014 04 09���䶨�� ������ʼ�ٶ��޸� ���Ӷ�������ֱ�߲岹
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
//��ָ��ģʽ
//����Stream
function MT_Set_Stream_Run(ADev:Integer):Integer;stdcall;external 'MT_API.dll'
//ֹͣStream
function MT_Set_Stream_Stop(ADev:Integer):Integer;stdcall;external 'MT_API.dll'
//��ͣStream
function MT_Set_Stream_Pause(ADev:Integer):Integer;stdcall;external 'MT_API.dll'
//���Stream
function MT_Set_Stream_Clear(ADev:Integer):Integer;stdcall;external 'MT_API.dll'
//��ȡʣ��ռ�
function MT_Get_Stream_Space(ADev:Integer;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//��ȡ�ܿռ�
function MT_Get_Stream_Total(ADev:Integer;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
//��ȡռ�ÿռ�
function MT_Get_Stream_Count(ADev:Integer;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'

function MT_Set_Stream_Delay(ADev:Integer;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//ֱ�߲岹�˶�
//����ֱ�߲岹���ٶ�
function MT_Set_Stream_Line_Acc(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//����ֱ�߲岹���ٶ�
function MT_Set_Stream_Line_Dec(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//����ֱ�߲岹�ٶ�
function MT_Set_Stream_Line_V_Max(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//����ֱ�߲岹�����ٶ�
function MT_Set_Stream_Line_V_Start(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//����ֱ�߲岹ֹͣ
function MT_Set_Stream_Line_Stop(ADev:Integer;AObj:Word):Integer;stdcall;external 'MT_API.dll'
//����ֱ�߲岹��ͣ
function MT_Set_Stream_Line_Halt(ADev:Integer;AObj:Word):Integer;stdcall;external 'MT_API.dll'
//����ֱ�߲岹
function MT_Set_Stream_Line_X_Run_Rel(ADev:Integer;AObj:Word;
  AAxis_Num:Integer;
  pAxis:PInteger;
  pTarget:PInteger):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Stream_Line_X_Run_Abs(ADev:Integer;AObj:Word;
  AAxis_Num:Integer;
  pAxis:PInteger;
  pTarget:PInteger):Integer;stdcall;external 'MT_API.dll'


//����Բ���岹���ἰ�ٶ�
function MT_Set_Stream_Circle_Axis(ADev:Integer;AObj:Word;Axis_ID0,Axis_ID1:Integer):Integer;stdcall;external 'MT_API.dll'
//����Բ���岹���ٶ�
function MT_Set_Stream_Circle_Acc(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//����Բ���岹���ٶ�
function MT_Set_Stream_Circle_Dec(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//����Բ���岹�ٶ�
function MT_Set_Stream_Circle_V_Max(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//����Բ���岹�����ٶ�
function MT_Set_Stream_Circle_V_Start(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//����Բ���岹���� ˳ʱ��  Բ������ģʽ
function MT_Set_Stream_Circle_R_CW_Run_Rel(ADev:Integer;AObj:Word;AR:Integer;
                  Axis_Target0,Axis_Target1:Integer):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Stream_Circle_R_CW_Run_Abs(ADev:Integer;AObj:Word;AR:Integer;
                  Axis_Target0,Axis_Target1:Integer):Integer;stdcall;external 'MT_API.dll'
//����Բ���岹���� ��ʱ��   Բ������
function MT_Set_Stream_Circle_R_CCW_Run_Rel(ADev:Integer;AObj:Word;AR:Integer;
                  Axis_Target0,Axis_Target1:Integer):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Stream_Circle_R_CCW_Run_Abs(ADev:Integer;AObj:Word;AR:Integer;
                  Axis_Target0,Axis_Target1:Integer):Integer;stdcall;external 'MT_API.dll'
//����Բ���岹ֹͣ
function MT_Set_Stream_Circle_Stop(ADev:Integer;AObj:Word):Integer;stdcall;external 'MT_API.dll'
//����Բ���岹��ͣ
function MT_Set_Stream_Circle_Halt(ADev:Integer;AObj:Word):Integer;stdcall;external 'MT_API.dll'


function MT_Set_Stream_Wait_Line(ADev:Integer;AObj:Word):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Stream_Wait_Circle(ADev:Integer;AObj:Word):Integer;stdcall;external 'MT_API.dll'

//���õ�ͨ��ֵ
function MT_Set_Stream_OC_Out_Single(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//��������ͨ��ֵ
function MT_Set_Stream_OC_Out_All(ADev:Integer;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//���õ�ͨ��ֵ
function MT_Set_Stream_Optic_Out_Single(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//��������ͨ��ֵ
function MT_Set_Stream_Optic_Out_All(ADev:Integer;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//�ȴ�Optic_In״̬
function MT_Set_Stream_Wait_Optic_In(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//����Stream
function MT_Set_Stream_Run_Check(ADev:Integer):Integer;stdcall;external 'MT_API.dll'
//���ٹ���
function MT_Set_Stream_Dec_Enable(ADev:Integer):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Stream_Dec_Disable(ADev:Integer):Integer;stdcall;external 'MT_API.dll'
//����������
function MT_Get_Encoder_Num(ADev:Integer;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
function MT_Get_Encoder_Pos(ADev:Integer;AObj:Word;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Encoder_Pos(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Encoder_Z_Polarity(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Encoder_Dir_Polarity(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
function MT_Get_Encoder_Index_Line_Count(ADev:Integer;AObj:Word;pValue:PInteger):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Encoder_Over_Enable(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Encoder_Over_Max(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
function MT_Set_Encoder_Over_Stable(ADev:Integer;AObj:Word;Value:Integer):Integer;stdcall;external 'MT_API.dll'
//�������㹫ʽ
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
//����������λ����
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
//����������λ����
function MT_Help_Grating_Line_Real_To_Steps(AUnit_um:Double;AValue:Double):Integer;stdcall;external 'MT_API.dll'
function MT_Help_Grating_Circle_Real_To_Steps(ALineCount:Integer;AValue:Double):Integer;stdcall;external 'MT_API.dll'

//pluse to mm
function MT_Help_Grating_Line_Steps_To_Real(AUnit_um:Double;AValue:Integer):Double;stdcall;external 'MT_API.dll'
function MT_Help_Grating_Circle_Steps_To_Real(ALineCount:Integer;AValue:Integer):Double;stdcall;external 'MT_API.dll'

function MT_Help_Encoder_Factor(AStepAngle:Double;ADiv:Integer;
   ALineCount:Integer):Single;stdcall;external 'MT_API.dll'

//��դ�߰�װ�ڻ�е�ϣ������ת����һ�£���Ҫ���ǻ�е��Ӱ��
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

//�����ڲ���Դ����

const RESOURCE_MOTOR        =$00000001;   //���
const RESOURCE_TTL_IN       =$00000002;   //TTL����
const RESOURCE_TTL_OUT      =$00000004;   //TTL���
const RESOURCE_OPTIC_IN     =$00000008;   //�������
const RESOURCE_OPTIC_OUT    =$00000010;   //������
const RESOURCE_AD           =$00000020;   //AD����
const RESOURCE_OC           =$00000040;   //OC���
const RESOURCE_LINE         =$00000080;   //ֱ�߲岹
const RESOURCE_CIRCLE       =$00000100;   //Բ���岹
const RESOURCE_PLC          =$00000200;   //PLC����
const RESOURCE_STREAM       =$00000400;   //Stream����
const RESOURCE_ENCODER      =$00000800;   //Encoder����

implementation

end.
