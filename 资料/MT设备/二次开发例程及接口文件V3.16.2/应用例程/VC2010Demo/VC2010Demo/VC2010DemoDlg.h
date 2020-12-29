
// VC2010DemoDlg.h : ͷ�ļ�
//

#pragma once
#include "afxwin.h"


// CVC2010DemoDlg �Ի���
class CVC2010DemoDlg : public CDialogEx
{
// ����
public:
	CVC2010DemoDlg(CWnd* pParent = NULL);	// ��׼���캯��

// �Ի�������
	enum { IDD = IDD_VC2010DEMO_DIALOG };

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV ֧��


// ʵ��
protected:
	HICON m_hIcon;

	// ���ɵ���Ϣӳ�亯��
	virtual BOOL OnInitDialog();
	afx_msg void OnSysCommand(UINT nID, LPARAM lParam);
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	DECLARE_MESSAGE_MAP()
public:
	afx_msg void OnBnClickedButton1();
	CEdit m_Port;
	virtual BOOL DestroyWindow();
	afx_msg void OnBnClickedButton8();
	int m_P_Abs;
	int m_P_Rel;
	int m_P_Set;
	int m_V_Abs;
	int m_V_Rel;
	int m_V_Now;
	int m_P_Now;
	afx_msg void OnBnClickedBtnPAbs();
	afx_msg void OnBnClickedBtnPRel();
	afx_msg void OnBnClickedBtnP();
	afx_msg void OnBnClickedBtnVAbs();
	afx_msg void OnBnClickedBtnVRel();
	afx_msg void OnBnClickedBtnRead();
};
