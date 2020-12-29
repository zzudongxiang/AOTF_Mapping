#include <stdio.h>
#include <stdlib.h>
#include <stdint-gcc.h>
#include "MT_API.h"
#include <unistd.h>

int main()
{
    int32_t iR;
    int32_t iRun;
    int32_t iPos;
    printf("Hello MT_API!\n");
    printf("Initialize everything!\n");
    MT_Init();
    printf("Open /dev/ttyS1 change this when needed!\n");
    MT_Open_UART("/dev/ttyS1");
    iR=MT_Check();
    if(0==iR)
    {
      printf("Check Success!\n");
      //find zero
      printf("Find Zero!\n");
      MT_Set_Axis_Mode_Home(0);
      MT_Set_Axis_Home_V(0,-2000);
      while(1)
      {
          MT_Get_Axis_Status_Run(0,&iRun);
          if(0==iRun)
          {
              break;
          }
          MT_Get_Axis_Software_P_Now(0,&iPos);
          printf("POS=%d\n",iPos);
          sleep(1);
      }
      printf("Zero found!\n");
      MT_Get_Axis_Software_P_Now(0,&iPos);
      printf("POS=%d\n",iPos);

      printf("Start relative positon move!\n");
      MT_Set_Axis_Mode_Position(0);
      MT_Set_Axis_Position_P_Target_Rel(0,10000);
      while(1)
      {
          MT_Get_Axis_Status_Run(0,&iRun);
          if(0==iRun)
          {
              break;
          }
          MT_Get_Axis_Software_P_Now(0,&iPos);
          printf("POS=%d\n",iPos);
          sleep(1);
      }
      printf("another relative positon move!\n");
      MT_Set_Axis_Position_P_Target_Rel(0,20000);
      while(1)
      {
          MT_Get_Axis_Status_Run(0,&iRun);
          if(0==iRun)
          {
              break;
          }
          MT_Get_Axis_Software_P_Now(0,&iPos);
          printf("POS=%d\n",iPos);
          sleep(1);
      }
      printf("Start absolute positon move!\n");
      MT_Set_Axis_Position_P_Target_Abs(0,500);
      while(1)
      {
          MT_Get_Axis_Status_Run(0,&iRun);
          if(0==iRun)
          {
              break;
          }
          MT_Get_Axis_Software_P_Now(0,&iPos);
          printf("POS=%d\n",iPos);
          sleep(1);
      }
      printf("Set current position as logical zero!\n");
      MT_Set_Axis_Software_P(0,0);
    }
    else
    {
      printf("Check Failed!\n");
    }
    printf("Demo done!\n");
    getchar();
    MT_DeInit();
    return 0;
}
