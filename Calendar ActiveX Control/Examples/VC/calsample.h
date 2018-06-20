// calsample.h : main header file for the CALSAMPLE application
//

#if !defined(AFX_CALSAMPLE_H__B3989D48_58BB_4819_B4E7_C97C9CD3DD02__INCLUDED_)
#define AFX_CALSAMPLE_H__B3989D48_58BB_4819_B4E7_C97C9CD3DD02__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#ifndef __AFXWIN_H__
	#error include 'stdafx.h' before including this file for PCH
#endif

#include "resource.h"		// main symbols

/////////////////////////////////////////////////////////////////////////////
// CCalsampleApp:
// See calsample.cpp for the implementation of this class
//

class CCalsampleApp : public CWinApp
{
public:
	CCalsampleApp();

// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CCalsampleApp)
	public:
	virtual BOOL InitInstance();
	//}}AFX_VIRTUAL

// Implementation

	//{{AFX_MSG(CCalsampleApp)
		// NOTE - the ClassWizard will add and remove member functions here.
		//    DO NOT EDIT what you see in these blocks of generated code !
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};


/////////////////////////////////////////////////////////////////////////////

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_CALSAMPLE_H__B3989D48_58BB_4819_B4E7_C97C9CD3DD02__INCLUDED_)
