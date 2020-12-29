namespace CSharpDemo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_Check = new System.Windows.Forms.Button();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.txt_Acc = new System.Windows.Forms.TextBox();
            this.btn_Acc = new System.Windows.Forms.Button();
            this.txt_Dec = new System.Windows.Forms.TextBox();
            this.btn_Dec = new System.Windows.Forms.Button();
            this.txt_MaxV = new System.Windows.Forms.TextBox();
            this.btn_MaxV = new System.Windows.Forms.Button();
            this.txt_Ref = new System.Windows.Forms.TextBox();
            this.btn_Ref = new System.Windows.Forms.Button();
            this.txt_Abs = new System.Windows.Forms.TextBox();
            this.btn_Abs = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_Halt = new System.Windows.Forms.Button();
            this.btn_Pos = new System.Windows.Forms.Button();
            this.txt_Pos = new System.Windows.Forms.TextBox();
            this.chk_Run = new System.Windows.Forms.CheckBox();
            this.chk_Dir = new System.Windows.Forms.CheckBox();
            this.chk_Neg = new System.Windows.Forms.CheckBox();
            this.chk_Pos = new System.Windows.Forms.CheckBox();
            this.chk_Zero = new System.Windows.Forms.CheckBox();
            this.btn_Status = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_Target1 = new System.Windows.Forms.TextBox();
            this.txt_Target2 = new System.Windows.Forms.TextBox();
            this.txt_Target0 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_X = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Y = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_R = new System.Windows.Forms.TextBox();
            this.btn_Circle = new System.Windows.Forms.Button();
            this.btn_AutoStream = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_USB = new System.Windows.Forms.Button();
            this.txt_Space = new System.Windows.Forms.TextBox();
            this.txt_Count = new System.Windows.Forms.TextBox();
            this.btn_SN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Check
            // 
            this.btn_Check.Location = new System.Drawing.Point(150, 19);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(93, 29);
            this.btn_Check.TabIndex = 0;
            this.btn_Check.Text = "检测板卡";
            this.btn_Check.UseVisualStyleBackColor = true;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // txt_Port
            // 
            this.txt_Port.Location = new System.Drawing.Point(23, 24);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(100, 21);
            this.txt_Port.TabIndex = 1;
            this.txt_Port.Text = "COM1";
            // 
            // txt_Acc
            // 
            this.txt_Acc.Location = new System.Drawing.Point(23, 75);
            this.txt_Acc.Name = "txt_Acc";
            this.txt_Acc.Size = new System.Drawing.Size(100, 21);
            this.txt_Acc.TabIndex = 3;
            this.txt_Acc.Text = "500";
            // 
            // btn_Acc
            // 
            this.btn_Acc.Location = new System.Drawing.Point(150, 70);
            this.btn_Acc.Name = "btn_Acc";
            this.btn_Acc.Size = new System.Drawing.Size(93, 29);
            this.btn_Acc.TabIndex = 2;
            this.btn_Acc.Text = "加速度";
            this.btn_Acc.UseVisualStyleBackColor = true;
            this.btn_Acc.Click += new System.EventHandler(this.btn_Acc_Click);
            // 
            // txt_Dec
            // 
            this.txt_Dec.Location = new System.Drawing.Point(283, 75);
            this.txt_Dec.Name = "txt_Dec";
            this.txt_Dec.Size = new System.Drawing.Size(100, 21);
            this.txt_Dec.TabIndex = 5;
            this.txt_Dec.Text = "500";
            // 
            // btn_Dec
            // 
            this.btn_Dec.Location = new System.Drawing.Point(410, 70);
            this.btn_Dec.Name = "btn_Dec";
            this.btn_Dec.Size = new System.Drawing.Size(93, 29);
            this.btn_Dec.TabIndex = 4;
            this.btn_Dec.Text = "减速度";
            this.btn_Dec.UseVisualStyleBackColor = true;
            this.btn_Dec.Click += new System.EventHandler(this.btn_Dec_Click);
            // 
            // txt_MaxV
            // 
            this.txt_MaxV.Location = new System.Drawing.Point(23, 122);
            this.txt_MaxV.Name = "txt_MaxV";
            this.txt_MaxV.Size = new System.Drawing.Size(100, 21);
            this.txt_MaxV.TabIndex = 7;
            this.txt_MaxV.Text = "5000";
            // 
            // btn_MaxV
            // 
            this.btn_MaxV.Location = new System.Drawing.Point(150, 117);
            this.btn_MaxV.Name = "btn_MaxV";
            this.btn_MaxV.Size = new System.Drawing.Size(146, 29);
            this.btn_MaxV.TabIndex = 6;
            this.btn_MaxV.Text = "位置模式最大速度";
            this.btn_MaxV.UseVisualStyleBackColor = true;
            this.btn_MaxV.Click += new System.EventHandler(this.btn_MaxV_Click);
            // 
            // txt_Ref
            // 
            this.txt_Ref.Location = new System.Drawing.Point(23, 175);
            this.txt_Ref.Name = "txt_Ref";
            this.txt_Ref.Size = new System.Drawing.Size(100, 21);
            this.txt_Ref.TabIndex = 9;
            this.txt_Ref.Text = "10000";
            // 
            // btn_Ref
            // 
            this.btn_Ref.Location = new System.Drawing.Point(150, 170);
            this.btn_Ref.Name = "btn_Ref";
            this.btn_Ref.Size = new System.Drawing.Size(93, 29);
            this.btn_Ref.TabIndex = 8;
            this.btn_Ref.Text = "相对移动";
            this.btn_Ref.UseVisualStyleBackColor = true;
            this.btn_Ref.Click += new System.EventHandler(this.btn_Ref_Click);
            // 
            // txt_Abs
            // 
            this.txt_Abs.Location = new System.Drawing.Point(23, 219);
            this.txt_Abs.Name = "txt_Abs";
            this.txt_Abs.Size = new System.Drawing.Size(100, 21);
            this.txt_Abs.TabIndex = 11;
            this.txt_Abs.Text = "10000";
            // 
            // btn_Abs
            // 
            this.btn_Abs.Location = new System.Drawing.Point(150, 214);
            this.btn_Abs.Name = "btn_Abs";
            this.btn_Abs.Size = new System.Drawing.Size(93, 29);
            this.btn_Abs.TabIndex = 10;
            this.btn_Abs.Text = "绝对移动";
            this.btn_Abs.UseVisualStyleBackColor = true;
            this.btn_Abs.Click += new System.EventHandler(this.btn_Abs_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(23, 262);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(86, 29);
            this.btn_Stop.TabIndex = 12;
            this.btn_Stop.Text = "停止";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_Halt
            // 
            this.btn_Halt.Location = new System.Drawing.Point(23, 297);
            this.btn_Halt.Name = "btn_Halt";
            this.btn_Halt.Size = new System.Drawing.Size(86, 29);
            this.btn_Halt.TabIndex = 13;
            this.btn_Halt.Text = "急停";
            this.btn_Halt.UseVisualStyleBackColor = true;
            this.btn_Halt.Click += new System.EventHandler(this.btn_Halt_Click);
            // 
            // btn_Pos
            // 
            this.btn_Pos.Location = new System.Drawing.Point(356, 202);
            this.btn_Pos.Name = "btn_Pos";
            this.btn_Pos.Size = new System.Drawing.Size(81, 38);
            this.btn_Pos.TabIndex = 14;
            this.btn_Pos.Text = "读当前位置";
            this.btn_Pos.UseVisualStyleBackColor = true;
            // 
            // txt_Pos
            // 
            this.txt_Pos.Location = new System.Drawing.Point(346, 170);
            this.txt_Pos.Name = "txt_Pos";
            this.txt_Pos.Size = new System.Drawing.Size(100, 21);
            this.txt_Pos.TabIndex = 15;
            // 
            // chk_Run
            // 
            this.chk_Run.AutoSize = true;
            this.chk_Run.Location = new System.Drawing.Point(618, 51);
            this.chk_Run.Name = "chk_Run";
            this.chk_Run.Size = new System.Drawing.Size(48, 16);
            this.chk_Run.TabIndex = 16;
            this.chk_Run.Text = "运行";
            this.chk_Run.UseVisualStyleBackColor = true;
            // 
            // chk_Dir
            // 
            this.chk_Dir.AutoSize = true;
            this.chk_Dir.Location = new System.Drawing.Point(618, 83);
            this.chk_Dir.Name = "chk_Dir";
            this.chk_Dir.Size = new System.Drawing.Size(48, 16);
            this.chk_Dir.TabIndex = 17;
            this.chk_Dir.Text = "方向";
            this.chk_Dir.UseVisualStyleBackColor = true;
            // 
            // chk_Neg
            // 
            this.chk_Neg.AutoSize = true;
            this.chk_Neg.Location = new System.Drawing.Point(618, 117);
            this.chk_Neg.Name = "chk_Neg";
            this.chk_Neg.Size = new System.Drawing.Size(60, 16);
            this.chk_Neg.TabIndex = 18;
            this.chk_Neg.Text = "负限位";
            this.chk_Neg.UseVisualStyleBackColor = true;
            // 
            // chk_Pos
            // 
            this.chk_Pos.AutoSize = true;
            this.chk_Pos.Location = new System.Drawing.Point(618, 152);
            this.chk_Pos.Name = "chk_Pos";
            this.chk_Pos.Size = new System.Drawing.Size(60, 16);
            this.chk_Pos.TabIndex = 19;
            this.chk_Pos.Text = "正限位";
            this.chk_Pos.UseVisualStyleBackColor = true;
            // 
            // chk_Zero
            // 
            this.chk_Zero.AutoSize = true;
            this.chk_Zero.Location = new System.Drawing.Point(618, 183);
            this.chk_Zero.Name = "chk_Zero";
            this.chk_Zero.Size = new System.Drawing.Size(48, 16);
            this.chk_Zero.TabIndex = 20;
            this.chk_Zero.Text = "零位";
            this.chk_Zero.UseVisualStyleBackColor = true;
            // 
            // btn_Status
            // 
            this.btn_Status.Location = new System.Drawing.Point(615, 219);
            this.btn_Status.Name = "btn_Status";
            this.btn_Status.Size = new System.Drawing.Size(81, 38);
            this.btn_Status.TabIndex = 21;
            this.btn_Status.Text = "读状态";
            this.btn_Status.UseVisualStyleBackColor = true;
            this.btn_Status.Click += new System.EventHandler(this.btn_Status_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 46);
            this.button1.TabIndex = 22;
            this.button1.Text = "联动插补";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Target1
            // 
            this.txt_Target1.Location = new System.Drawing.Point(217, 324);
            this.txt_Target1.Name = "txt_Target1";
            this.txt_Target1.Size = new System.Drawing.Size(100, 21);
            this.txt_Target1.TabIndex = 23;
            this.txt_Target1.Text = "1000";
            // 
            // txt_Target2
            // 
            this.txt_Target2.Location = new System.Drawing.Point(216, 351);
            this.txt_Target2.Name = "txt_Target2";
            this.txt_Target2.Size = new System.Drawing.Size(101, 21);
            this.txt_Target2.TabIndex = 24;
            this.txt_Target2.Text = "1000";
            // 
            // txt_Target0
            // 
            this.txt_Target0.Location = new System.Drawing.Point(217, 297);
            this.txt_Target0.Name = "txt_Target0";
            this.txt_Target0.Size = new System.Drawing.Size(100, 21);
            this.txt_Target0.TabIndex = 25;
            this.txt_Target0.Text = "1000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 26;
            this.label1.Text = "目标1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 27;
            this.label2.Text = "目标2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 28;
            this.label3.Text = "目标3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 29;
            this.label4.Text = "目标x";
            // 
            // txt_X
            // 
            this.txt_X.Location = new System.Drawing.Point(466, 297);
            this.txt_X.Name = "txt_X";
            this.txt_X.Size = new System.Drawing.Size(123, 21);
            this.txt_X.TabIndex = 30;
            this.txt_X.Text = "1000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(405, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 31;
            this.label5.Text = "目标y";
            // 
            // txt_Y
            // 
            this.txt_Y.Location = new System.Drawing.Point(466, 335);
            this.txt_Y.Name = "txt_Y";
            this.txt_Y.Size = new System.Drawing.Size(123, 21);
            this.txt_Y.TabIndex = 32;
            this.txt_Y.Text = "1000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 33;
            this.label6.Text = "半径";
            // 
            // txt_R
            // 
            this.txt_R.Location = new System.Drawing.Point(466, 372);
            this.txt_R.Name = "txt_R";
            this.txt_R.Size = new System.Drawing.Size(123, 21);
            this.txt_R.TabIndex = 34;
            this.txt_R.Text = "20000";
            // 
            // btn_Circle
            // 
            this.btn_Circle.Location = new System.Drawing.Point(457, 399);
            this.btn_Circle.Name = "btn_Circle";
            this.btn_Circle.Size = new System.Drawing.Size(97, 46);
            this.btn_Circle.TabIndex = 35;
            this.btn_Circle.Text = "圆弧插补";
            this.btn_Circle.UseVisualStyleBackColor = true;
            this.btn_Circle.Click += new System.EventHandler(this.btn_Circle_Click);
            // 
            // btn_AutoStream
            // 
            this.btn_AutoStream.Location = new System.Drawing.Point(640, 375);
            this.btn_AutoStream.Name = "btn_AutoStream";
            this.btn_AutoStream.Size = new System.Drawing.Size(121, 47);
            this.btn_AutoStream.TabIndex = 36;
            this.btn_AutoStream.Text = "自动流模式";
            this.btn_AutoStream.UseVisualStyleBackColor = true;
            this.btn_AutoStream.Click += new System.EventHandler(this.btn_AutoStream_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_USB
            // 
            this.btn_USB.Location = new System.Drawing.Point(273, 19);
            this.btn_USB.Name = "btn_USB";
            this.btn_USB.Size = new System.Drawing.Size(119, 29);
            this.btn_USB.TabIndex = 37;
            this.btn_USB.Text = "USB";
            this.btn_USB.UseVisualStyleBackColor = true;
            this.btn_USB.Click += new System.EventHandler(this.btn_USB_Click);
            // 
            // txt_Space
            // 
            this.txt_Space.Location = new System.Drawing.Point(641, 301);
            this.txt_Space.Name = "txt_Space";
            this.txt_Space.Size = new System.Drawing.Size(100, 21);
            this.txt_Space.TabIndex = 38;
            // 
            // txt_Count
            // 
            this.txt_Count.Location = new System.Drawing.Point(640, 331);
            this.txt_Count.Name = "txt_Count";
            this.txt_Count.Size = new System.Drawing.Size(100, 21);
            this.txt_Count.TabIndex = 39;
            // 
            // btn_SN
            // 
            this.btn_SN.Location = new System.Drawing.Point(420, 19);
            this.btn_SN.Name = "btn_SN";
            this.btn_SN.Size = new System.Drawing.Size(119, 29);
            this.btn_SN.TabIndex = 40;
            this.btn_SN.Text = "读取序列号";
            this.btn_SN.UseVisualStyleBackColor = true;
            this.btn_SN.Click += new System.EventHandler(this.btn_SN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 464);
            this.Controls.Add(this.btn_SN);
            this.Controls.Add(this.txt_Count);
            this.Controls.Add(this.txt_Space);
            this.Controls.Add(this.btn_USB);
            this.Controls.Add(this.btn_AutoStream);
            this.Controls.Add(this.btn_Circle);
            this.Controls.Add(this.txt_R);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Y);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_X);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Target0);
            this.Controls.Add(this.txt_Target2);
            this.Controls.Add(this.txt_Target1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Status);
            this.Controls.Add(this.chk_Zero);
            this.Controls.Add(this.chk_Pos);
            this.Controls.Add(this.chk_Neg);
            this.Controls.Add(this.chk_Dir);
            this.Controls.Add(this.chk_Run);
            this.Controls.Add(this.txt_Pos);
            this.Controls.Add(this.btn_Pos);
            this.Controls.Add(this.btn_Halt);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.txt_Abs);
            this.Controls.Add(this.btn_Abs);
            this.Controls.Add(this.txt_Ref);
            this.Controls.Add(this.btn_Ref);
            this.Controls.Add(this.txt_MaxV);
            this.Controls.Add(this.btn_MaxV);
            this.Controls.Add(this.txt_Dec);
            this.Controls.Add(this.btn_Dec);
            this.Controls.Add(this.txt_Acc);
            this.Controls.Add(this.btn_Acc);
            this.Controls.Add(this.txt_Port);
            this.Controls.Add(this.btn_Check);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.TextBox txt_Acc;
        private System.Windows.Forms.Button btn_Acc;
        private System.Windows.Forms.TextBox txt_Dec;
        private System.Windows.Forms.Button btn_Dec;
        private System.Windows.Forms.TextBox txt_MaxV;
        private System.Windows.Forms.Button btn_MaxV;
        private System.Windows.Forms.TextBox txt_Ref;
        private System.Windows.Forms.Button btn_Ref;
        private System.Windows.Forms.TextBox txt_Abs;
        private System.Windows.Forms.Button btn_Abs;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_Halt;
        private System.Windows.Forms.Button btn_Pos;
        private System.Windows.Forms.TextBox txt_Pos;
        private System.Windows.Forms.CheckBox chk_Run;
        private System.Windows.Forms.CheckBox chk_Dir;
        private System.Windows.Forms.CheckBox chk_Neg;
        private System.Windows.Forms.CheckBox chk_Pos;
        private System.Windows.Forms.CheckBox chk_Zero;
        private System.Windows.Forms.Button btn_Status;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_Target1;
        private System.Windows.Forms.TextBox txt_Target2;
        private System.Windows.Forms.TextBox txt_Target0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_X;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Y;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_R;
        private System.Windows.Forms.Button btn_Circle;
        private System.Windows.Forms.Button btn_AutoStream;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_USB;
        private System.Windows.Forms.TextBox txt_Space;
        private System.Windows.Forms.TextBox txt_Count;
        private System.Windows.Forms.Button btn_SN;
    }
}

