
Public Class VBDemo

    Private Sub VBDemo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MT_API.MT_Init()
    End Sub

    Private Sub VBDemo_Closed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        MT_API.MT_DeInit()
    End Sub

    Private Sub btn_Open_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Open.Click

        MT_API.MT_Close_UART()
        '此处很重要，WINCE的串口号是要带"："的，在PC上不需要，否则不能工作
        If (MT_API.R_OK = MT_API.MT_Open_UART("COM2:")) Then

            btn_Open.BackColor = Color.Green


        Else
            btn_Open.BackColor = Color.Red

        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MT_API.MT_Close_UART()
    End Sub

    Private Sub btn_Check_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Check.Click
        If (MT_API.R_OK = MT_API.MT_Check()) Then
            btn_Check.BackColor = Color.Green
        Else
            btn_Check.BackColor = Color.Red
        End If
    End Sub

    Private Sub btn_Param_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Param.Click
        '设置运动参数，一般只需要设置一次
        Dim iID As UInt16
        Dim iAcc As Int32
        Dim iDec As Int32
        Dim iP_V As Int32
        iID = Convert.ToUInt16(txt_ID.Text)
        iAcc = Convert.ToInt32(txt_Acc.Text)
        iDec = Convert.ToInt32(txt_Dec.Text)
        iP_V = Convert.ToInt32(txt_P_V.Text)
        '设置加速度
        MT_API.MT_Set_Axis_Acc(iID, iAcc)
        '设置减速度
        MT_API.MT_Set_Axis_Dec(iID, iDec)
        '设置位置模式最大速度
        MT_API.MT_Set_Axis_Position_V_Max(iID, iP_V)

    End Sub

    Private Sub btn_P_Rel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_P_Rel.Click
        '指定轴相对当前位置移动
        Dim iID As UInt16
        Dim iValue As Int32
        iID = Convert.ToUInt16(txt_ID.Text)
        iValue = Convert.ToInt32(txt_P.Text)
        '设置为位置工作模式，默认为位置模式，一般只需设置一次
        MT_API.MT_Set_Axis_Mode_Position(iID)
        '相对移动
        MT_API.MT_Set_Axis_Position_P_Target_Rel(iID, iValue)

        MT_API.MT_Set_Axis_Position_P_Target_Rel(0, 2000)
        MT_API.MT_Set_Axis_Position_P_Target_Rel(1, 5000)
    End Sub

    Private Sub btn_P_Abs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_P_Abs.Click
        '指定轴相对当前位置移动
        Dim iID As UInt16
        Dim iValue As Int32
        iID = Convert.ToUInt16(txt_ID.Text)
        iValue = Convert.ToInt32(txt_P.Text)
        '设置为位置工作模式，默认为位置模式，一般只需设置一次
        MT_API.MT_Set_Axis_Mode_Position(iID)
        '相对移动
        MT_API.MT_Set_Axis_Position_P_Target_Abs(iID, iValue)
    End Sub

    Private Sub btn_Stop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Stop.Click
        '指定轴相对当前位置移动
        Dim iID As UInt16
        iID = Convert.ToUInt16(txt_ID.Text)
        '减速停止
        MT_API.MT_Set_Axis_Position_Stop(iID)
    End Sub

    Private Sub btn_Halt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Halt.Click
        '指定轴相对当前位置移动
        Dim iID As UInt16
        iID = Convert.ToUInt16(txt_ID.Text)
        '减速停止
        MT_API.MT_Set_Axis_Halt(iID)
    End Sub

    Private Sub btn_Line_ID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Line_ID.Click
        Dim iID0 As Int32
        Dim iID1 As Int32

        iID0 = Convert.ToInt32(txt_ID0.Text)
        iID1 = Convert.ToInt32(txt_ID1.Text)
        '一组插补情况下，直接用第0组
        MT_API.MT_Set_Axis_Line_Axis(0, iID0, iID1)



    End Sub

    Private Sub btn_Line_Param_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Line_Param.Click
        '设置运动参数，一般只需要设置一次 
        Dim iAcc As Int32
        Dim iDec As Int32
        Dim iP_V As Int32

        iAcc = Convert.ToInt32(txt_Line_Acc.Text)
        iDec = Convert.ToInt32(txt_Line_Dec.Text)
        iP_V = Convert.ToInt32(txt_Line_V.Text)
        '设置加速度
        MT_API.MT_Set_Axis_Line_Acc(0, iAcc)
        '设置减速度
        MT_API.MT_Set_Axis_Dec(0, iDec)
        '设置位置模式最大速度
        MT_API.MT_Set_Axis_Position_V_Max(0, iP_V)


    End Sub

    Private Sub btn_Lien_Rel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Lien_Rel.Click
        '指定轴相对当前位置移动
        Dim iValue0, iValue1 As Int32
        iValue0 = Convert.ToInt32(txt_P0.Text)
        iValue1 = Convert.ToInt32(txt_P1.Text)
        '设置移动量
        MT_API.MT_Set_Axis_Line_Rel(0, iValue0, iValue1)
        '启动
        MT_API.MT_Set_Axis_Line_Run(0)

    End Sub

    Private Sub btn_Line_Abs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Line_Abs.Click
        '指定轴相对当前位置移动
        Dim iValue0, iValue1 As Int32
        iValue0 = Convert.ToInt32(txt_P0.Text)
        iValue1 = Convert.ToInt32(txt_P1.Text)
        '设置移动量
        MT_API.MT_Set_Axis_Line_Abs(0, iValue0, iValue1)
        '启动
        MT_API.MT_Set_Axis_Line_Run(0)
    End Sub

    Private Sub btn_Line_Stop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Line_Stop.Click
        '停止
        MT_API.MT_Set_Axis_Line_Stop(0)
    End Sub

    Private Sub btn_Line_Halt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Line_Halt.Click
        MT_API.MT_Set_Axis_Line_Halt(0)
    End Sub

    Private Sub chk_Get_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Get.Click
        Timer1.Enabled = chk_Get.Checked
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim bRun, bDir, bNeg, bPos, bZero, bMode As Byte
        Dim iV, iP As Integer
        Dim iID As UInt16

        Timer1.Enabled = False

        '读取指定的轴
        iID = Convert.ToUInt16(txt_ID.Text)
        '读状态
        MT_API.MT_Get_Axis_Status(iID, bRun, bDir, bNeg, bPos, bZero, bMode)
        chk_Run.Checked = bRun > 0
        chk_Neg.Checked = bNeg > 0
        chk_Pos.Checked = bPos > 0
        chk_Zero.Checked = bZero > 0
        '读速度
        MT_API.MT_Get_Axis_V_Now(iID, iV)
        txt_V_Now.Text = iV.ToString()
        '读位置
        MT_API.MT_Get_Axis_Software_P_Now(iID, iP)
        txt_P_Now.Text = iP.ToString()
        Timer1.Enabled = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'MT_API.MT_Set_Axis_Software_P()
    End Sub
End Class
