#ifndef _MODBUS_H_
#define _MODBUS_H_
/////////////////////////////////////////////////////////////////
// 第一步,请根据不同的应用平台，修改对应的数据类型定义
typedef unsigned char uint8;	
typedef unsigned int  uint16;
typedef unsigned long uint32;
typedef char          int8;
typedef int           int16;
typedef long          int32;
////////////////////////////////////////////////////////////////

//此处类型无需修改
typedef union 
{
 int32 i32;
 uint8  bytes[4];
}int32_byte;

typedef union 
{
 int16 i16;
 uint8  bytes[2];
}int16_byte;

uint8 PLC_Set_Var_Data(uint16 AID,int32 AValue);
uint8 PLC_Get_Var_Data(uint16 AID,int32* pValue);


#endif


