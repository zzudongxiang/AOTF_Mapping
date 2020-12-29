Public Class Form1

    Public iStatus As Long
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If (MT_API.R_OK = MT_API.MT_Open_UART("COM5")) Then
            '���ڴ򿪳ɹ�
            Button1.BackColor = Color.Green
        Else
            Button1.BackColor = Color.Red
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        '���ָ�������ϵİ忨����״̬
        If (MT_API.R_OK = MT_API.MT_Check()) Then

            Button2.BackColor = Color.Green
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        '���ò���
        '���ٶ�
        MT_API.MT_Set_Axis_Acc(0, 1000)
        '���ٶ�
        MT_API.MT_Set_Axis_Dec(0, 1000)
        '�ٶ�
        MT_API.MT_Set_Axis_Position_V_Max(0, 2000)
        '����ģʽ(���Բ����ã�Ĭ��Ϊ��λģʽ)
        MT_API.MT_Set_Axis_Mode_Position(0)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        '��Ե�ǰλ���ƶ�10000����λ
        MT_API.MT_Set_Axis_Position_P_Target_Rel(0, 10000)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MT_API.MT_Init()
    End Sub

    Private Sub Form1_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        MT_API.MT_DeInit()
    End Sub

    Private Sub btn_Start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Start.Click
        Timer1.Enabled = True

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Timer1.Enabled = False

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim iMode As Byte
        Dim iRun As Byte
        Dim iDir As Byte
        Dim iNeg As Byte
        Dim iPos As Byte
        Dim iZero As Byte

        MT_API.MT_Get_Axis_Status(0, iRun, iDir, iNeg, iPos, iZero, iMode)

        chk_Run.Checked = iRun > 0
        chk_Dir.Checked = iDir > 0
        chk_Neg.Checked = iNeg > 0
        chk_Pos.Checked = iPos > 0
        chk_Zero.Checked = iZero > 0


    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        iStatus = 0
        Timer2.Enabled = True
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Timer2.Enabled = False
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Dim iValue As Int32
        '����ʵ���ظ���һ���ȱ�ֱ��������
        Select Case iStatus
            Case 0
                '����ֱ�߲岹����
                '��һ��ֱ�߲岹��������Ϊ0,1
                MT_API.MT_Set_Axis_Line_Axis(0, 0, 1)
                '�����˶�����
                MT_API.MT_Set_Axis_Line_Acc(0, 10000)
                MT_API.MT_Set_Axis_Line_Dec(0, 10000)
                MT_API.MT_Set_Axis_Line_V(0, 10000)
                iStatus = 1
            Case 1
                '�ߵ�һ��
                MT_API.MT_Set_Axis_Line_Run_Rel(0, 0, 10000)
                iStatus = 2
            Case 2
                '�ж��Ƿ�����
                MT_API.MT_Get_Axis_Line_Status(0, iValue)
                If (iValue = 0) Then
                    iStatus = 3
                End If
            Case 3
                '�ߵ�2��
                MT_API.MT_Set_Axis_Line_Run_Rel(0, 10000, 0)
                iStatus = 4
            Case 4
                '�ж��Ƿ�����
                MT_API.MT_Get_Axis_Line_Status(0, iValue)
                If (iValue = 0) Then
                    iStatus = 5
                End If
            Case 5
                '�ߵ�3��
                MT_API.MT_Set_Axis_Line_Run_Rel(0, -10000, -10000)
                iStatus = 6
            Case 6
                '�ж��Ƿ�����
                MT_API.MT_Get_Axis_Line_Status(0, iValue)
                If (iValue = 0) Then
                    iStatus = 1
                End If

        End Select

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If (MT_API.R_OK = MT_API.MT_Open_USB) Then
            'USB�򿪳ɹ�
            Button8.BackColor = Color.Green
        Else
            Button8.BackColor = Color.Red
        End If
    End Sub
End Class
