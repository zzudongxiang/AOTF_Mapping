
Public Class VBDemo

    Private Sub VBDemo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MT_API.MT_Init()
    End Sub

    Private Sub VBDemo_Closed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        MT_API.MT_DeInit()
    End Sub

    Private Sub btn_Open_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Open.Click

        MT_API.MT_Close_UART()
        '�˴�����Ҫ��WINCE�Ĵ��ں���Ҫ��"��"�ģ���PC�ϲ���Ҫ�������ܹ���
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
        '�����˶�������һ��ֻ��Ҫ����һ��
        Dim iID As UInt16
        Dim iAcc As Int32
        Dim iDec As Int32
        Dim iP_V As Int32
        iID = Convert.ToUInt16(txt_ID.Text)
        iAcc = Convert.ToInt32(txt_Acc.Text)
        iDec = Convert.ToInt32(txt_Dec.Text)
        iP_V = Convert.ToInt32(txt_P_V.Text)
        '���ü��ٶ�
        MT_API.MT_Set_Axis_Acc(iID, iAcc)
        '���ü��ٶ�
        MT_API.MT_Set_Axis_Dec(iID, iDec)
        '����λ��ģʽ����ٶ�
        MT_API.MT_Set_Axis_Position_V_Max(iID, iP_V)

    End Sub

    Private Sub btn_P_Rel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_P_Rel.Click
        'ָ������Ե�ǰλ���ƶ�
        Dim iID As UInt16
        Dim iValue As Int32
        iID = Convert.ToUInt16(txt_ID.Text)
        iValue = Convert.ToInt32(txt_P.Text)
        '����Ϊλ�ù���ģʽ��Ĭ��Ϊλ��ģʽ��һ��ֻ������һ��
        MT_API.MT_Set_Axis_Mode_Position(iID)
        '����ƶ�
        MT_API.MT_Set_Axis_Position_P_Target_Rel(iID, iValue)

        MT_API.MT_Set_Axis_Position_P_Target_Rel(0, 2000)
        MT_API.MT_Set_Axis_Position_P_Target_Rel(1, 5000)
    End Sub

    Private Sub btn_P_Abs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_P_Abs.Click
        'ָ������Ե�ǰλ���ƶ�
        Dim iID As UInt16
        Dim iValue As Int32
        iID = Convert.ToUInt16(txt_ID.Text)
        iValue = Convert.ToInt32(txt_P.Text)
        '����Ϊλ�ù���ģʽ��Ĭ��Ϊλ��ģʽ��һ��ֻ������һ��
        MT_API.MT_Set_Axis_Mode_Position(iID)
        '����ƶ�
        MT_API.MT_Set_Axis_Position_P_Target_Abs(iID, iValue)
    End Sub

    Private Sub btn_Stop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Stop.Click
        'ָ������Ե�ǰλ���ƶ�
        Dim iID As UInt16
        iID = Convert.ToUInt16(txt_ID.Text)
        '����ֹͣ
        MT_API.MT_Set_Axis_Position_Stop(iID)
    End Sub

    Private Sub btn_Halt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Halt.Click
        'ָ������Ե�ǰλ���ƶ�
        Dim iID As UInt16
        iID = Convert.ToUInt16(txt_ID.Text)
        '����ֹͣ
        MT_API.MT_Set_Axis_Halt(iID)
    End Sub

    Private Sub btn_Line_ID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Line_ID.Click
        Dim iID0 As Int32
        Dim iID1 As Int32

        iID0 = Convert.ToInt32(txt_ID0.Text)
        iID1 = Convert.ToInt32(txt_ID1.Text)
        'һ��岹����£�ֱ���õ�0��
        MT_API.MT_Set_Axis_Line_Axis(0, iID0, iID1)



    End Sub

    Private Sub btn_Line_Param_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Line_Param.Click
        '�����˶�������һ��ֻ��Ҫ����һ�� 
        Dim iAcc As Int32
        Dim iDec As Int32
        Dim iP_V As Int32

        iAcc = Convert.ToInt32(txt_Line_Acc.Text)
        iDec = Convert.ToInt32(txt_Line_Dec.Text)
        iP_V = Convert.ToInt32(txt_Line_V.Text)
        '���ü��ٶ�
        MT_API.MT_Set_Axis_Line_Acc(0, iAcc)
        '���ü��ٶ�
        MT_API.MT_Set_Axis_Dec(0, iDec)
        '����λ��ģʽ����ٶ�
        MT_API.MT_Set_Axis_Position_V_Max(0, iP_V)


    End Sub

    Private Sub btn_Lien_Rel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Lien_Rel.Click
        'ָ������Ե�ǰλ���ƶ�
        Dim iValue0, iValue1 As Int32
        iValue0 = Convert.ToInt32(txt_P0.Text)
        iValue1 = Convert.ToInt32(txt_P1.Text)
        '�����ƶ���
        MT_API.MT_Set_Axis_Line_Rel(0, iValue0, iValue1)
        '����
        MT_API.MT_Set_Axis_Line_Run(0)

    End Sub

    Private Sub btn_Line_Abs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Line_Abs.Click
        'ָ������Ե�ǰλ���ƶ�
        Dim iValue0, iValue1 As Int32
        iValue0 = Convert.ToInt32(txt_P0.Text)
        iValue1 = Convert.ToInt32(txt_P1.Text)
        '�����ƶ���
        MT_API.MT_Set_Axis_Line_Abs(0, iValue0, iValue1)
        '����
        MT_API.MT_Set_Axis_Line_Run(0)
    End Sub

    Private Sub btn_Line_Stop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Line_Stop.Click
        'ֹͣ
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

        '��ȡָ������
        iID = Convert.ToUInt16(txt_ID.Text)
        '��״̬
        MT_API.MT_Get_Axis_Status(iID, bRun, bDir, bNeg, bPos, bZero, bMode)
        chk_Run.Checked = bRun > 0
        chk_Neg.Checked = bNeg > 0
        chk_Pos.Checked = bPos > 0
        chk_Zero.Checked = bZero > 0
        '���ٶ�
        MT_API.MT_Get_Axis_V_Now(iID, iV)
        txt_V_Now.Text = iV.ToString()
        '��λ��
        MT_API.MT_Get_Axis_Software_P_Now(iID, iP)
        txt_P_Now.Text = iP.ToString()
        Timer1.Enabled = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'MT_API.MT_Set_Axis_Software_P()
    End Sub
End Class
