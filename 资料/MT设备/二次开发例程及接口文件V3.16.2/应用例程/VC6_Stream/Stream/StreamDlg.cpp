// StreamDlg.cpp : implementation file
//

#include "stdafx.h"
#include "Stream.h"
#include "StreamDlg.h"
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
// CStreamDlg dialog

CStreamDlg::CStreamDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CStreamDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CStreamDlg)
	m_COM = _T("");
	//}}AFX_DATA_INIT
	// Note that LoadIcon does not require a subsequent DestroyIcon in Win32
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void CStreamDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CStreamDlg)
	DDX_Text(pDX, IDC_COM, m_COM);
	//}}AFX_DATA_MAP
}

BEGIN_MESSAGE_MAP(CStreamDlg, CDialog)
	//{{AFX_MSG_MAP(CStreamDlg)
	ON_WM_SYSCOMMAND()
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_BN_CLICKED(IDC_OPEN, OnOpen)
	ON_BN_CLICKED(IDC_STREAM, OnStream)
	ON_BN_CLICKED(IDC_RUN, OnRun)
	ON_BN_CLICKED(IDC_PAUSE, OnPause)
	ON_BN_CLICKED(IDC_STOP, OnStop)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CStreamDlg message handlers

BOOL CStreamDlg::OnInitDialog()
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
	
    MT_Init();
	//默认COM1
    m_COM="COM1";
	UpdateData(FALSE);
	return TRUE;  // return TRUE  unless you set the focus to a control
}

void CStreamDlg::OnSysCommand(UINT nID, LPARAM lParam)
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

void CStreamDlg::OnPaint() 
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
HCURSOR CStreamDlg::OnQueryDragIcon()
{
	return (HCURSOR) m_hIcon;
}

BOOL CStreamDlg::DestroyWindow() 
{
	// TODO: Add your specialized code here and/or call the base class
	MT_DeInit();
	return CDialog::DestroyWindow();
}

void CStreamDlg::OnOpen() 
{
	// TODO: Add your control notification handler code here
	UpdateData(TRUE);
	MT_Open_UART(m_COM.GetBuffer(0));
}

void CStreamDlg::OnStream() 
{
	INT32 iSpace;
	// TODO: Add your control notification handler code here
	//启动流模式，输入前后都可以,本例在其它按钮里启动
    //	MT_Set_Stream_Run();

	//以下功能可以放在定时器里，在定时器里根据状态不停的发指令就可以，需要注意要查询缓冲区空间
	//没有空间的时候等待下次定时
	for(int i=0;i<100;i++)
	{
		//判断指令缓冲区空间是否有空余，不同的指令占用的空间不一样
		MT_Get_Stream_Space(&iSpace);
		if(iSpace>20)
		{
			MT_Set_Stream_Optic_Out_Single(0,1);
		}
		MT_Get_Stream_Space(&iSpace);
		if(iSpace>20)
		{
			MT_Set_Stream_Delay(500);
		}
		MT_Get_Stream_Space(&iSpace);
		if(iSpace>20)
		{
			MT_Set_Stream_Optic_Out_Single(0,0);
		}
		MT_Get_Stream_Space(&iSpace);
		if(iSpace>20)
		{
			MT_Set_Stream_Delay(500);
		}
	}
	
}

void CStreamDlg::OnRun() 
{
	// TODO: Add your control notification handler code here
   MT_Set_Stream_Run();	
}

void CStreamDlg::OnPause() 
{
	// TODO: Add your control notification handler code here
	MT_Set_Stream_Pause();
}

void CStreamDlg::OnStop() 
{
	// TODO: Add your control notification handler code here
    MT_Set_Stream_Stop();	
}
