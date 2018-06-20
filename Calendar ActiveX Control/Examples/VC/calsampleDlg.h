// calsampleDlg.h : header file
//
//{{AFX_INCLUDES()
#include "calendar.h"
//}}AFX_INCLUDES

#if !defined(AFX_CALSAMPLEDLG_H__E5CB2D9F_5952_4863_8AD4_001A11F8D4DB__INCLUDED_)
#define AFX_CALSAMPLEDLG_H__E5CB2D9F_5952_4863_8AD4_001A11F8D4DB__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

/////////////////////////////////////////////////////////////////////////////
// CCalsampleDlg dialog

class CCalsampleDlg : public CDialog
{
// Construction
public:
	CCalsampleDlg(CWnd* pParent = NULL);	// standard constructor

// Dialog Data
	//{{AFX_DATA(CCalsampleDlg)
	enum { IDD = IDD_CALSAMPLE_DIALOG };
	CComboBox	m_CboDayFontSize;
	CComboBox	m_CboFontText;
	CComboBox	m_CboFontDay;
	CComboBox	m_CboFontCap;
	CComboBox	m_CboFont;
	CCalendar	m_Calendar;
	int		m_iMonth;
	int		m_iYear;
	int		m_ihYear;
	int		m_ihMonth;
	int		m_ihDay;
	int		m_iTextDay;
	CString	m_strDayText;
	CString	m_strDayCaption0;
	CString	m_strDayCaption1;
	CString	m_strDayCaption2;
	CString	m_strDayCaption3;
	CString	m_strDayCaption4;
	CString	m_strDayCaption5;
	CString	m_strDayCaption6;
	int		m_iRangeYear;
	int		m_iRangeMonth;
	int		m_iRangeStartDay;
	int		m_iRangeToDay;
	int		m_iSetDay;
	//}}AFX_DATA

	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CCalsampleDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:
	HICON m_hIcon;

	// Generated message map functions
	//{{AFX_MSG(CCalsampleDlg)
	virtual BOOL OnInitDialog();
	afx_msg void OnSysCommand(UINT nID, LPARAM lParam);
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	afx_msg void OnSelchangeCbofontmonthyear();
	afx_msg void OnButton1();
	afx_msg void OnButton2();
	afx_msg void OnButton3();
	afx_msg void OnButton4();
	afx_msg void OnSelchangeCbofontdaycap();
	afx_msg void OnButton5();
	afx_msg void OnSelchangeCbofontday();
	afx_msg void OnSelchangeCbofonttext();
	afx_msg void OnButton6();
	afx_msg void OnBtngo();
	afx_msg void OnBTNHighLightSet();
	afx_msg void OnBTNSetText();
	afx_msg void OnOnDayClickCalendarctrl1(short iYear, short iMonth, short iDay, LPCTSTR strText);
	afx_msg void OnButton7();
	afx_msg void OnSelchangeCbodayfontsize();
	afx_msg void OnButton8();
	afx_msg void OnButton9();
	afx_msg void OnButton10();
	DECLARE_EVENTSINK_MAP()
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_CALSAMPLEDLG_H__E5CB2D9F_5952_4863_8AD4_001A11F8D4DB__INCLUDED_)
