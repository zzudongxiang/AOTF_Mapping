
// VC2010Demo.h : PROJECT_NAME Ӧ�ó������ͷ�ļ�
//

#pragma once

#ifndef __AFXWIN_H__
	#error "�ڰ������ļ�֮ǰ������stdafx.h�������� PCH �ļ�"
#endif

#include "resource.h"		// ������


// CVC2010DemoApp:
// �йش����ʵ�֣������ VC2010Demo.cpp
//

class CVC2010DemoApp : public CWinApp
{
public:
	CVC2010DemoApp();

// ��д
public:
	virtual BOOL InitInstance();

// ʵ��

	DECLARE_MESSAGE_MAP()
};

extern CVC2010DemoApp theApp;