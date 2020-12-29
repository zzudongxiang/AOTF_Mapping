// VCDemoDlg.cpp : implementation file
//

#include "stdafx.h"
#include "VCDemo.h"
#include "VCDemoDlg.h"
#include "MT_API.h"
#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CAboutDlg dialog used for App About

class CAboutDlg : public CDialog
{
public:
	CAboutDlg();

// Dialog Data
	//{{AFX_DATA(CAboutDlg)
	enum { IDD = IDD_ABOUTBOX };
	//}}AFX_DATA

	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CAboutDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:
	//{{AFX_MSG(CAboutDlg)
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

CAboutDlg::CAboutDlg() : CDialog(CAboutDlg::IDD)
{
	//{{AFX_DATA_INIT(CAboutDlg)
	//}}AFX_DATA_INIT
}

void CAboutDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CAboutDlg)
	//}}AFX_DATA_MAP
}

BEGIN_MESSAGE_MAP(CAboutDlg, CDialog)
	//{{AFX_MSG_MAP(CAboutDlg)
		// No message handlers
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CVCDemoDlg dialog

CVCDemoDlg::CVCDemoDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CVCDemoDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CVCDemoDlg)
	//}}AFX_DATA_INIT
	// Note that LoadIcon does not require a subsequent DestroyIcon in Win32
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void CVCDemoDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CVCDemoDlg)
	DDX_Control(pDX, IDC_IN, m_In);
	DDX_Control(pDX, IDC_OUT, m_Out);
	DDX_Control(pDX, IDC_NOW_P, m_P_Now);
	DDX_Control(pDX, IDC_HOME_V, m_Home_V);
	DDX_Control(pDX, IDC_V_ABS, m_V_Abs);
	DDX_Control(pDX, IDC_V_REF, m_V_Ref);
	DDX_Control(pDX, IDC_REF, m_Ref);
	DDX_Control(pDX, IDC_PORT, m_Port);
	DDX_Control(pDX, IDC_MAXV, m_Maxv);
	DDX_Control(pDX, IDC_DEC, m_Dec);
	DDX_Control(pDX, IDC_ACC, m_Acc);
	DDX_Control(pDX, IDC_ABS, m_Abs);
	//}}AFX_DATA_MAP
}

BEGIN_MESSAGE_MAP(CVCDemoDlg, CDialog)
	//{{AFX_MSG_MAP(CVCDemoDlg)
	ON_WM_SYSCOMMAND()
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_BN_CLICKED(IDC_BTN_CHECK, OnButton1)
	ON_BN_CLICKED(IDC_BTN_ACC, OnBtnAcc)
	ON_BN_CLICKED(IDC_BTN_DEC, OnBtnDec)
	ON_BN_CLICKED(IDC_BTN_MAXV, OnBtnMaxv)
	ON_BN_CLICKED(IDC_BTN_REF, OnBtnRef)
	ON_BN_CLICKED(IDC_BTN_ABS, OnBtnAbs)
	ON_BN_CLICKED(IDC_STOP, OnStop)
	ON_BN_CLICKED(IDC_HALT, OnHalt)
	ON_BN_CLICKED(IDC_BTN_POS_MODE, OnBtnPosMode)
	ON_BN_CLICKED(IDC_BTN_V_MODE, OnBtnVMode)
	ON_BN_CLICKED(IDC_BTN_V_REF, OnBtnVRef)
	ON_BN_CLICKED(IDC_BTN_V_ABS, OnBtnVAbs)
	ON_BN_CLICKED(IDC_STOP_V, OnStopV)
	ON_BN_CLICKED(IDC_BTN_Home_MODE, OnBTNHomeMODE)
	ON_BN_CLICKED(IDC_BTN_HOME, OnBtnHome)
	ON_BN_CLICKED(IDC_STOP_HOME, OnStopHome)
	ON_BN_CLICKED(IDC_BTN_NOW_P, OnBtnNowP)
	ON_BN_CLICKED(IDC_BTN_IN, OnBtnIn)
	ON_BN_CLICKED(IDC_BTN_OUT, OnBtnOut)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CVCDemoDlg message handlers

BOOL CVCDemoDlg::OnInitDialog()
{
	CDialog::OnInitDialog();

	// Add "About..." menu item to system menu.

	// IDM_ABOUTBOX must be in the system command range.
	ASSERT((IDM_ABOUTBOX & 0xFFF0) == IDM_ABOUTBOX);
	ASSERT(IDM_ABOUTBOX < 0xF000);

	CMenu* pSysMenu = GetSystemMenu(FALSE);
	if (pSysMenu != NULL)
	{
		CString strAboutMenu;
		strAboutMenu.LoadString(IDS_ABOUTBOX);
		if (!strAboutMenu.IsEmpty())
		{
			pSysMenu->AppendMenu(MF_SEPARATOR);
			pSysMenu->AppendMenu(MF_STRING, IDM_ABOUTBOX, strAboutMenu);
		}
	}

	// Set the icon for this dialog.  The framework does this automatically
	//  when the application's main window is not a dialog
	SetIcon(m_hIcon, TRUE);			// Set big icon
	SetIcon(m_hIcon, FALSE);		// Set small icon
	
	// TODO: Add extra initialization here
	//��ʼ�����л���
    MT_Init();
    m_Port.SetWindowText(_T("COM1"));
	m_Acc.SetWindowText(_T("500"));
	m_Dec.SetWindowText(_T("500"));
	m_Maxv.SetWindowText(_T("5000"));
	m_Ref.SetWindowText(_T("10000"));
    m_Abs.SetWindowText(_T("10000"));
		
	m_V_Abs.SetWindowText(_T("3200"));
	m_V_Ref.SetWindowText(_T("3200"));
	m_Home_V.SetWindowText(_T("3200"));

	m_Out.SetWindowText(_T("255"));
	return TRUE;  // return TRUE  unless you set the focus to a control
}

void CVCDemoDlg::OnSysCommand(UINT nID, LPARAM lParam)
{
	if ((nID & 0xFFF0) == IDM_ABOUTBOX)
	{
		CAboutDlg dlgAbout;
		dlgAbout.DoModal();
	}
	else
	{
		CDialog::OnSysCommand(nID, lParam);
	}
}

// If you add a minimize button to your dialog, you will need the code below
//  to draw the icon.  For MFC applications using the document/view model,
//  this is automatically done for you by the framework.

void CVCDemoDlg::OnPaint() 
{
	if (IsIconic())
	{
		CPaintDC dc(this); // device context for painting

		SendMessage(WM_ICONERASEBKGND, (WPARAM) dc.GetSafeHdc(), 0);

		// Center icon in client rectangle
		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		GetClientRect(&rect);
		int x = (rect.Width() - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;

		// Draw the icon
		dc.DrawIcon(x, y, m_hIcon);
	}
	else
	{
		CDialog::OnPaint();
	}
}

// The system calls this to obtain the cursor to display while the user drags
//  the minimized window.
HCURSOR CVCDemoDlg::OnQueryDragIcon()
{
	return (HCURSOR) m_hIcon;
}

BOOL CVCDemoDlg::DestroyWindow() 
{
	// TODO: Add your specialized code here and/or call the base class
    //�ͷ���Դ	
    MT_DeInit();

	return CDialog::DestroyWindow();
}

void CVCDemoDlg::OnButton1() 
{
	// TODO: Add your control notification handler code here
	CString sCOM;
	INT32 iResult;
	MT_Close_USB();
	MT_Close_UART();
	//�򿪴���
    m_Port.GetWindowText(sCOM);

    char *p = (LPSTR)(LPCTSTR)sCOM;

	iResult=MT_Open_UART(p);
	if(iResult!=R_OK)
	{
		MessageBox("Port Error");
		return;
	}
	//���忨
	iResult=MT_Check();
	if(R_OK!=iResult)
	{
		MessageBox("NO Card");
		return;
	}
	//���忨�ɹ�
	MessageBox("OK");
}

void CVCDemoDlg::OnBtnAcc() 
{
	// TODO: Add your control notification handler code here
	//���ü��ٶ�
	CString sValue;
	m_Acc.GetWindowText(sValue);
	int iAcc;
	iAcc=atoi(sValue);
	INT32 iResult;
	iResult=MT_Set_Axis_Acc(0,iAcc);
	if(R_OK==iResult)
	{
         MessageBox("OK");
	}

}

void CVCDemoDlg::OnBtnDec() 
{
	// TODO: Add your control notification handler code here
	//���ü��ٶ�
	CString sValue;
	m_Dec.GetWindowText(sValue);
	int iDec;
	iDec=atoi(sValue);
	INT32 iResult;
	iResult=MT_Set_Axis_Dec(0,iDec);
	if(R_OK==iResult)
	{
		MessageBox("OK");
	}	
}

void CVCDemoDlg::OnBtnMaxv() 
{
	// TODO: Add your control notification handler code here
	//����λ��ģʽ����ٶ�
	CString sValue;
	m_Maxv.GetWindowText(sValue);
	int iMaxv;
	iMaxv=atoi(sValue);
	INT32 iResult;
	iResult=MT_Set_Axis_Position_V_Max(0,iMaxv);
	if(R_OK==iResult)
	{
		MessageBox("OK");
	}	
}

void CVCDemoDlg::OnBtnRef() 
{
	// TODO: Add your control notification handler code here
	//������Է�ʽ�ƶ���֧������ֵ
	CString sValue;

	m_Ref.GetWindowText(sValue);
	int iRef;
	iRef=atoi(sValue);
	INT32 iResult;
	iResult=MT_Set_Axis_Position_P_Target_Rel(0,iRef);
	if(R_OK==iResult)
	{
		MessageBox("OK");
	}	
}

void CVCDemoDlg::OnBtnAbs() 
{
	// TODO: Add your control notification handler code here
	//���þ��Է�ʽ�ƶ���֧������ֵ
	CString sValue;
	//����λ��ģʽ��ֻ��Ҫ����һ��
	MT_Set_Axis_Mode_Position(0);

	m_Abs.GetWindowText(sValue);
	int iAbs;
	iAbs=atoi(sValue);
	INT32 iResult;
	iResult=MT_Set_Axis_Position_P_Target_Abs(0,iAbs);
	if(R_OK==iResult)
	{
		MessageBox("OK");
	}		
}

void CVCDemoDlg::OnStop() 
{
	// TODO: Add your control notification handler code here
	//��ָ���ļ��ٶ�ֹͣ
    INT32 iResult;
	iResult=MT_Set_Axis_Position_Stop(0);
	if(R_OK==iResult)
	{
		MessageBox("OK");
	}	
}

void CVCDemoDlg::OnHalt() 
{
	// TODO: Add your control notification handler code here
	//����ֹͣ
    INT32 iResult;
	iResult=MT_Set_Axis_Halt(0);
	if(R_OK==iResult)
	{
		MessageBox("OK");
	}		
}

void CVCDemoDlg::OnBtnPosMode() 
{
	// TODO: Add your control notification handler code here
	//����λ��ģʽ��ֻ��Ҫ����һ��
	INT32 iResult;
	iResult=MT_Set_Axis_Mode_Position(0);
	if(R_OK==iResult)
	{
		MessageBox("OK");
	}
}

void CVCDemoDlg::OnBtnVMode() 
{
	// TODO: Add your control notification handler code here
	//�����ٶ�ģʽ��ֻ��Ҫ����һ��
    INT32 iResult;
	iResult=MT_Set_Axis_Mode_Velocity(0);
	if(R_OK==iResult)
	{
		MessageBox("OK");
	}
}

void CVCDemoDlg::OnBtnVRef() 
{
	//������Է�ʽ���٣�֧������ֵ
	CString sValue;
	
	m_V_Ref.GetWindowText(sValue);
	int iRef;
	iRef=atoi(sValue);
	INT32 iResult;
	iResult=MT_Set_Axis_Velocity_V_Target_Rel(0,iRef);
	if(R_OK==iResult)
	{
		MessageBox("OK");
	}	
}

void CVCDemoDlg::OnBtnVAbs() 
{
	// TODO: Add your control notification handler code here
	//���þ��Է�ʽ���٣�֧������ֵ
	CString sValue;
	
	m_V_Abs.GetWindowText(sValue);
	int iRef;
	iRef=atoi(sValue);
	INT32 iResult;
	iResult=MT_Set_Axis_Velocity_V_Target_Abs(0,iRef);
	if(R_OK==iResult)
	{
		MessageBox("OK");
	}		
}

void CVCDemoDlg::OnStopV() 
{
	//��ָ���ļ��ٶ�ֹͣ
    INT32 iResult;
	iResult=MT_Set_Axis_Velocity_Stop(0);
	if(R_OK==iResult)
	{
		MessageBox("OK");
	}	
}

void CVCDemoDlg::OnBTNHomeMODE() 
{
	// TODO: Add your control notification handler code here
	//������λģʽ��ֻ��Ҫ����һ��
	INT32 iResult;
	iResult=MT_Set_Axis_Mode_Home(0);
	if(R_OK==iResult)
	{
		MessageBox("OK");
	}
}

void CVCDemoDlg::OnBtnHome() 
{
	//����ָ���ٶ�����λ��֧������ֵ�����ٻᾫȷһЩ
	CString sValue;
	
	m_Home_V.GetWindowText(sValue);
	int iRef;
	iRef=atoi(sValue);
	INT32 iResult;
	iResult=MT_Set_Axis_Home_V(0,iRef);
	if(R_OK==iResult)
	{
		MessageBox("OK");
	}	
}

void CVCDemoDlg::OnStopHome() 
{
	// TODO: Add your control notification handler code here
	//��ָ���ļ��ٶ�ֹͣ
    INT32 iResult;
	iResult=MT_Set_Axis_Home_Stop(0);
	if(R_OK==iResult)
	{
		MessageBox("OK");
	}	
}

void CVCDemoDlg::OnBtnNowP() 
{
	// TODO: Add your control notification handler code here
	//��ȡ����λ��
	CString sValue;
	int iAbs;
    INT32 iResult;
    iResult=MT_Get_Axis_Software_P_Now(0,&iAbs);
	if(R_OK==iResult)
	{
		MessageBox("OK");
		sValue.Format("%d",iAbs);
	    m_P_Now.SetWindowText(sValue);	
	}			
}

void CVCDemoDlg::OnBtnIn() 
{
	// TODO: Add your control notification handler code here
	//��ȡ����λ��
	CString sValue;
	int iValue;
    INT32 iResult;
    iResult=MT_Get_Optic_In_All(&iValue);
	if(R_OK==iResult)
	{
		MessageBox("OK");
		sValue.Format("%d",iValue);
		m_In.SetWindowText(sValue);	
	}	// TODO: Add your control notification handler code here
	
}

void CVCDemoDlg::OnBtnOut() 
{
	//����ָ���ٶ�����λ��֧������ֵ�����ٻᾫȷһЩ
	CString sValue;
	
	m_Out.GetWindowText(sValue);
	int iValue;
	iValue=atoi(sValue);
	INT32 iResult;
	iResult=MT_Set_Optic_Out_All(iValue);
	if(R_OK==iResult)
	{
		MessageBox("OK");
	}	
}
