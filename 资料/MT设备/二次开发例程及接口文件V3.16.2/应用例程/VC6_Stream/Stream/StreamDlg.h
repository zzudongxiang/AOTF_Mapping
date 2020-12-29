// StreamDlg.h : header file
//

#if !defined(AFX_STREAMDLG_H__28E98996_3493_43BB_A046_4EE702C6900A__INCLUDED_)
#define AFX_STREAMDLG_H__28E98996_3493_43BB_A046_4EE702C6900A__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

/////////////////////////////////////////////////////////////////////////////
// CStreamDlg dialog

class CStreamDlg : public CDialog
{
// Construction
public:
	CStreamDlg(CWnd* pParent = NULL);	// standard constructor

// Dialog Data
	//{{AFX_DATA(CStreamDlg)
	enum { IDD = IDD_STREAM_DIALOG };
	CString	m_COM;
	//}}AFX_DATA

	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CStreamDlg)
	public:
	virtual BOOL DestroyWindow();
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:
	HICON m_hIcon;

	// Generated message map functions
	//{{AFX_MSG(CStreamDlg)
	virtual BOOL OnInitDialog();
	afx_msg void OnSysCommand(UINT nID, LPARAM lParam);
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	afx_msg void OnOpen();
	afx_msg void OnStream();
	afx_msg void OnRun();
	afx_msg void OnPause();
	afx_msg void OnStop();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_STREAMDLG_H__28E98996_3493_43BB_A046_4EE702C6900A__INCLUDED_)
