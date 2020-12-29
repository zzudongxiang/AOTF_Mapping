using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSharpDemo
{
    public partial class Form1 : Form
    {
        private Int32 iStatus=0;
        private Int32 iCount = 0;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            MT_API.MT_Close_UART();
            MT_API.MT_Close_USB();
            string s = txt_Port.Text;
            if(0!=MT_API.MT_Open_UART(s))
            {
                MessageBox.Show("串口连接错误");
                return;
            }


            if(0==MT_API.MT_Check())
            {
                MessageBox.Show("ok");
            }
            else
            {
                MessageBox.Show("NO card");
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MT_API.MT_DeInit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MT_API.MT_Init();
        }

        private void btn_Acc_Click(object sender, EventArgs e)
        {
            Int32 iResult;
            iResult=MT_API.MT_Set_Axis_Acc(0, Convert.ToInt32(txt_Acc.Text));
            if(0==iResult)
            {
                MessageBox.Show("ok");
            }
        }

        private void btn_Dec_Click(object sender, EventArgs e)
        {
            Int32 iResult;
            iResult=MT_API.MT_Set_Axis_Dec(0, Convert.ToInt32(txt_Dec.Text));
            if (0 == iResult)
            {
                MessageBox.Show("ok");
            }
        }

        private void btn_MaxV_Click(object sender, EventArgs e)
        {
            Int32 iResult;
            iResult=MT_API.MT_Set_Axis_Position_V_Max(0, Convert.ToInt32(txt_MaxV.Text));
            if (0 == iResult)
            {
                MessageBox.Show("ok");
            }
        }

        private void btn_Ref_Click(object sender, EventArgs e)
        {
            Int32 iResult;
            MT_API.MT_Set_Axis_Mode_Position(0);
            iResult = MT_API.MT_Set_Axis_Position_P_Target_Rel(0, Convert.ToInt32(txt_Ref.Text));
            if (0 == iResult)
            {
                MessageBox.Show("ok");
            }
        }

        private void btn_Abs_Click(object sender, EventArgs e)
        {
            Int32 iResult;
            MT_API.MT_Set_Axis_Mode_Position(0);
            iResult=MT_API.MT_Set_Axis_Position_P_Target_Abs(0, Convert.ToInt32(txt_Abs.Text));
            if (0 == iResult)
            {
                MessageBox.Show("ok");
            }
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            Int32 iResult;
            iResult=MT_API.MT_Set_Axis_Position_Stop(0);
            if (0 == iResult)
            {
                MessageBox.Show("ok");
            }
        }

        private void btn_Halt_Click(object sender, EventArgs e)
        {
            Int32 iResult;
            iResult=MT_API.MT_Set_Axis_Halt(0);
            if (0 == iResult)
            {
                MessageBox.Show("ok");
            }
        }

        private void btn_Status_Click(object sender, EventArgs e)
        {
            Byte bRun,bDir,bNeg,bPos,bZero,bMode;
            Int32 iResult;
            bRun = 0;
            bNeg = 0;
            bDir = 0;
            bPos = 0;
            bZero = 0;
            bMode = 0;
            iResult = MT_API.MT_Get_Axis_Status(0, 
                ref bRun, ref bDir,ref bNeg,ref bPos,ref bZero,ref bMode);
            if(MT_API.R_OK==iResult)
            {
                chk_Dir.Checked = bDir > 0;
                chk_Neg.Checked = bNeg > 0;
                chk_Pos.Checked = bPos > 0;
                chk_Run.Checked=bRun>0;
                chk_Zero.Checked=bZero>0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32[] iAxis=new Int32[3];
            Int32[] iTarget=new Int32[3];
            //Int32 iStatus;
            //加速度
            MT_API.MT_Set_Axis_Line_Acc(0, 1000);
            //减速度
            MT_API.MT_Set_Axis_Line_Dec(0, 1000);
            //最大速度
            MT_API.MT_Set_Axis_Line_V(0, 1000);
            //参与插补的轴 0,2,3可以任意组合
            iAxis[0] = 0;
            iAxis[1] = 2;
            iAxis[2] = 3;
            //插补的距离,和上面的插补轴对应
            iTarget[0] = Convert.ToInt32(txt_Target0.Text);
            iTarget[1] = Convert.ToInt32(txt_Target1.Text);
            iTarget[2] = Convert.ToInt32(txt_Target2.Text);
            //启动插补
            MT_API.MT_Set_Axis_Line_X_Run_Rel(0, 3, ref iAxis[0], ref iTarget[0]);
            //判断插补是否结束，一般放到定时器
            /*
            MT_API.MT_Get_Axis_Line_Status(0, ref iStatus);
            if(iStatus>0)//运行中
            {

            }
            else
            {
                //插补结束
            }*/
        }

        private void btn_Circle_Click(object sender, EventArgs e)
        {
            int iR,iX,iY;
            //任意组合的2轴
            MT_API.MT_Set_Axis_Circle_Axis(0, 0, 1);
             //速度
            MT_API.MT_Set_Axis_Circle_V(0, 5000);
            //加速度
            MT_API.MT_Set_Axis_Circle_Acc(0, 1000);
            //减速度
            MT_API.MT_Set_Axis_Circle_Dec(0, 1000);
            
        
            //启动顺时针劣弧插补，还有顺时针优弧 逆时针劣弧 逆时针优弧
            iR=Convert.ToInt32(txt_R.Text);
            iX=Convert.ToInt32(txt_X.Text);
            iY=Convert.ToInt32(txt_Y.Text);

            //开始圆弧插补
            MT_API.MT_Set_Axis_Circle_R_CW_Run_Rel(0, iR, iX, iY);


            //判断状态用,一般放到控制流程用的定时器里
            //MT_API.MT_Get_Axis_Circle_Status()
        }

        private void btn_USB_Click(object sender, EventArgs e)
        {
            MT_API.MT_Close_UART();
            MT_API.MT_Close_USB();
            string s = txt_Port.Text;
            if (0 != MT_API.MT_Open_USB())
            {
                MessageBox.Show("USB口连接错误");
                return;
            }


            if (0 == MT_API.MT_Check())
            {
                MessageBox.Show("ok");
            }
            else
            {
                MessageBox.Show("NO card");
            }
        }

        private void btn_AutoStream_Click(object sender, EventArgs e)
        {
            //状态
            iStatus= 0;
            //计数器
            iCount = 0;
            timer1.Enabled = !timer1.Enabled;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Int32[] iAxis=new Int32[3];
            Int32[] iTarget=new Int32[3];
            Int32 iSpace=0;
            //参与插补的轴 0,2,3可以任意组合
            iAxis[0] = 0;
            iAxis[1] = 2;
            iAxis[2] = 3;
            //读取一次空间状态
            if (MT_API.R_OK == MT_API.MT_Get_Stream_Space(ref iSpace))
            {
                txt_Space.Text = Convert.ToString(iSpace);
            }
            switch(iStatus)
            {
                case 0://初始化stream
                    {
                        //清空缓冲区
                        MT_API.MT_Set_Stream_Stop();
                        MT_API.MT_Set_Stream_Clear();
                        MT_API.MT_Set_Stream_Run();
                        //设置工作参数,清空后初始缓冲区足够设置一下函数，也可以进行判断空间
                        MT_API.MT_Set_Stream_Line_Acc(0,1000);
                        MT_API.MT_Set_Stream_Line_Dec(0,1000);
                        MT_API.MT_Set_Stream_Line_V_Max(0,1000);
                        MT_API.MT_Set_Stream_Circle_Acc(0, 1000);
                        MT_API.MT_Set_Stream_Circle_Dec(0, 1000);
                        MT_API.MT_Set_Stream_Circle_V_Max(0, 1000);
                        //进入下一步
                        iStatus = 1;
                        break;
                    }
                case 1://启动一次直线插补
                    {
                        if(MT_API.R_OK==MT_API.MT_Get_Stream_Space(ref iSpace))
                        {
                            //一次判断多次指令的空间是否够，也可以每次发送都判断一次
                            if(iSpace>100)
                            {
                                MT_API.MT_Set_Stream_Optic_Out_Single(0, 1);
                                //此处坐标可以从数组或者全局变量或者文件读取
                                iTarget[0]=10000;
                                iTarget[1]=14434;
                                iTarget[2]=23021;
                                MT_API.MT_Set_Stream_Line_X_Run_Rel(0, 3, ref iAxis[0], ref iTarget[0]);
                                MT_API.MT_Set_Stream_Wait_Line(0);
                                MT_API.MT_Set_Stream_Optic_Out_Single(0, 0);
                                iStatus = 2;
                            }
                        }
                        break;    
                    }
                case 2://一次圆弧插补
                    {
                        if (MT_API.R_OK == MT_API.MT_Get_Stream_Space(ref iSpace))
                        {
                            //一次判断多次指令的空间是否够，也可以每次发送都判断一次
                            if (iSpace > 100)
                            {
                                MT_API.MT_Set_Stream_Optic_Out_Single(1, 1);
                                //设置参与圆弧插补的轴
                                MT_API.MT_Set_Stream_Circle_Axis(0, 0, 1);
                                //此处坐标可以从数组或者全局变量或者文件读取
                                MT_API.MT_Set_Stream_Circle_R_CW_Run_Rel(0, 10000, 432, 446);
                                MT_API.MT_Set_Stream_Wait_Circle(0);
                                MT_API.MT_Set_Stream_Optic_Out_Single(1, 0);
                                iStatus = 3;
                            }
                        }
                        break;
                    }
                case 3://回0位
                    {
                        if (MT_API.R_OK == MT_API.MT_Get_Stream_Space(ref iSpace))
                        {
                            //一次判断多次指令的空间是否够，也可以每次发送都判断一次
                            if (iSpace > 100)
                            {
                                MT_API.MT_Set_Stream_Optic_Out_Single(2, 1);
                                iTarget[0] = 0;
                                iTarget[1] = 0;
                                iTarget[2] = 0;
                                MT_API.MT_Set_Stream_Line_X_Run_Abs(0, 2, ref iAxis[0], ref iTarget[0]);
                                MT_API.MT_Set_Stream_Wait_Line(0);
                                MT_API.MT_Set_Stream_Optic_Out_Single(2, 0);
                                iStatus = 4;
                                iCount++;
                            }
                        }
                        break;
                    }
                case 4:
                    {
                        //循环次数，也可以是其它的判据,任务结束 
                        txt_Count.Text = Convert.ToString(iCount);
                        if(iCount>=100)
                        {
                            timer1.Enabled = false;
                        }
                        else
                        {
                            iStatus = 1;
                        }
                        break;
                    }

            }
        }
    }
}
