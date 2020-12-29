// Stream.h : main header file for the STREAM application
//

#if !defined(AFX_STREAM_H__49B614DC_6AD5_4F2E_A2AD_D18C5FFBCA67__INCLUDED_)
#define AFX_STREAM_H__49B614DC_6AD5_4F2E_A2AD_D18C5FFBCA67__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#ifndef __AFXWIN_H__
	#error include 'stdafx.h' before including this file for PCH
#endif

#include "resource.h"		// main symbols

/////////////////////////////////////////////////////////////////////////////
// CStreamApp:
// See Stream.cpp for the implementation of this class
//

class CStreamApp : public CWinApp
{
public:
	CStreamApp();

// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CStreamApp)
	public:
	virtual BOOL InitInstance();
	//}}AFX_VIRTUAL

// Implementation

	//{{AFX_MSG(CStreamApp)
		// NOTE - the ClassWizard will add and remove member functions here.
		//    DO NOT EDIT what you see in these blocks of generated code !
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};


/////////////////////////////////////////////////////////////////////////////

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_STREAM_H__49B614DC_6AD5_4F2E_A2AD_D18C5FFBCA67__INCLUDED_)
