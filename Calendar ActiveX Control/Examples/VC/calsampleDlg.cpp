// calsampleDlg.cpp : implementation file
//

#include "stdafx.h"
#include "calsample.h"
#include "calsampleDlg.h"

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
// CCalsampleDlg dialog

CCalsampleDlg::CCalsampleDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CCalsampleDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CCalsampleDlg)
	m_iMonth = 0;
	m_iYear = 0;
	m_ihYear = 0;
	m_ihMonth = 0;
	m_ihDay = 0;
	m_iTextDay = 1;
	m_strDayText = _T("enter your text");
	m_strDayCaption0 = _T("Sunday");
	m_strDayCaption1 = _T("Monday");
	m_strDayCaption2 = _T("Tuesday");
	m_strDayCaption3 = _T("Wednesday");
	m_strDayCaption4 = _T("Thursday");
	m_strDayCaption5 = _T("Friday");
	m_strDayCaption6 = _T("Saturday");
	m_iRangeYear = 0;
	m_iRangeMonth = 0;
	m_iRangeStartDay = 1;
	m_iRangeToDay = 20;
	m_iSetDay = 15;
	//}}AFX_DATA_INIT
	// Note that LoadIcon does not require a subsequent DestroyIcon in Win32
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void CCalsampleDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CCalsampleDlg)
	DDX_Control(pDX, IDC_CBODAYFONTSIZE, m_CboDayFontSize);
	DDX_Control(pDX, IDC_CBOFONTTEXT, m_CboFontText);
	DDX_Control(pDX, IDC_CBOFONTDAY, m_CboFontDay);
	DDX_Control(pDX, IDC_CBOFONTDAYCAP, m_CboFontCap);
	DDX_Control(pDX, IDC_CBOFONTMONTHYEAR, m_CboFont);
	DDX_Control(pDX, IDC_CALENDARCTRL1, m_Calendar);
	DDX_Text(pDX, IDC_EDITMONTH, m_iMonth);
	DDX_Text(pDX, IDC_EDITYEAR, m_iYear);
	DDX_Text(pDX, IDC_EDITHYEAR, m_ihYear);
	DDX_Text(pDX, IDC_EDITHMONTH, m_ihMonth);
	DDX_Text(pDX, IDC_EDITHDAY, m_ihDay);
	DDX_Text(pDX, IDC_EDITTEXTDAY, m_iTextDay);
	DDX_Text(pDX, IDC_EDITDAYTEXT, m_strDayText);
	DDX_Text(pDX, IDC_EDITDAYCAP0, m_strDayCaption0);
	DDX_Text(pDX, IDC_EDITDAYCAP1, m_strDayCaption1);
	DDX_Text(pDX, IDC_EDITDAYCAP2, m_strDayCaption2);
	DDX_Text(pDX, IDC_EDITDAYCAP3, m_strDayCaption3);
	DDX_Text(pDX, IDC_EDITDAYCAP4, m_strDayCaption4);
	DDX_Text(pDX, IDC_EDITDAYCAP5, m_strDayCaption5);
	DDX_Text(pDX, IDC_EDITDAYCAP6, m_strDayCaption6);
	DDX_Text(pDX, IDC_EDITRANGEYEAR, m_iRangeYear);
	DDX_Text(pDX, IDC_EDITRANGEMONTH, m_iRangeMonth);
	DDX_Text(pDX, IDC_EDITRANGESTARTDAY, m_iRangeStartDay);
	DDX_Text(pDX, IDC_EDITRANGETODAY, m_iRangeToDay);
	DDX_Text(pDX, IDC_EDITDAY, m_iSetDay);
	//}}AFX_DATA_MAP
}

BEGIN_MESSAGE_MAP(CCalsampleDlg, CDialog)
	//{{AFX_MSG_MAP(CCalsampleDlg)
	ON_WM_SYSCOMMAND()
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_CBN_SELCHANGE(IDC_CBOFONTMONTHYEAR, OnSelchangeCbofontmonthyear)
	ON_BN_CLICKED(IDC_BUTTON1, OnButton1)
	ON_BN_CLICKED(IDC_BUTTON2, OnButton2)
	ON_BN_CLICKED(IDC_BUTTON3, OnButton3)
	ON_BN_CLICKED(IDC_BUTTON4, OnButton4)
	ON_CBN_SELCHANGE(IDC_CBOFONTDAYCAP, OnSelchangeCbofontdaycap)
	ON_BN_CLICKED(IDC_BUTTON5, OnButton5)
	ON_CBN_SELCHANGE(IDC_CBOFONTDAY, OnSelchangeCbofontday)
	ON_CBN_SELCHANGE(IDC_CBOFONTTEXT, OnSelchangeCbofonttext)
	ON_BN_CLICKED(IDC_BUTTON6, OnButton6)
	ON_BN_CLICKED(IDC_BTNGO, OnBtngo)
	ON_BN_CLICKED(IDC_BTNHighLightSet, OnBTNHighLightSet)
	ON_BN_CLICKED(IDC_BTNSetText, OnBTNSetText)
	ON_BN_CLICKED(IDC_BUTTON7, OnButton7)
	ON_CBN_SELCHANGE(IDC_CBODAYFONTSIZE, OnSelchangeCbodayfontsize)
	ON_BN_CLICKED(IDC_BUTTON8, OnButton8)
	ON_BN_CLICKED(IDC_BUTTON9, OnButton9)
	ON_BN_CLICKED(IDC_BUTTON10, OnButton10)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CCalsampleDlg message handlers

BOOL CCalsampleDlg::OnInitDialog()
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

	m_CboFont.AddString("Arial");
	m_CboFont.AddString("Arial Black");
	m_CboFont.AddString("Courier New");
	m_CboFont.AddString("MS Sans Serif");
	m_CboFont.AddString("Tahoma");
	m_CboFont.AddString("Times New Roman");
	m_CboFont.SetCurSel(0);


	m_CboFontCap.AddString("Arial");
	m_CboFontCap.AddString("Arial Black");
	m_CboFontCap.AddString("Courier New");
	m_CboFontCap.AddString("MS Sans Serif");
	m_CboFontCap.AddString("Tahoma");
	m_CboFontCap.AddString("Times New Roman");
	m_CboFontCap.SetCurSel(0);


	m_CboFontDay.AddString("Arial");
	m_CboFontDay.AddString("Arial Black");
	m_CboFontDay.AddString("Courier New");
	m_CboFontDay.AddString("MS Sans Serif");
	m_CboFontDay.AddString("Tahoma");
	m_CboFontDay.AddString("Times New Roman");
	m_CboFontDay.SetCurSel(0);


	m_CboFontText.AddString("Arial");
	m_CboFontText.AddString("Arial Black");
	m_CboFontText.AddString("Courier New");
	m_CboFontText.AddString("MS Sans Serif");
	m_CboFontText.AddString("Tahoma");
	m_CboFontText.AddString("Times New Roman");
	m_CboFontText.SetCurSel(0);

	m_CboDayFontSize.AddString("8");
	m_CboDayFontSize.AddString("10");
	m_CboDayFontSize.AddString("12");
	m_CboDayFontSize.AddString("14");
	m_CboDayFontSize.AddString("16");
	m_CboDayFontSize.AddString("18");
	m_CboDayFontSize.SetCurSel(0);



	
	m_iMonth=m_Calendar.GetMonth();
	m_iYear = m_Calendar.GetYear();

	m_ihYear = m_Calendar.GetYear();
	m_ihMonth = m_Calendar.GetMonth();
	m_ihDay = 1;

	
	m_iRangeMonth =m_Calendar.GetMonth();
	m_iRangeYear = m_Calendar.GetYear();
	UpdateData(FALSE);
	
	return TRUE;  // return TRUE  unless you set the focus to a control
}

void CCalsampleDlg::OnSysCommand(UINT nID, LPARAM lParam)
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

void CCalsampleDlg::OnPaint() 
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
HCURSOR CCalsampleDlg::OnQueryDragIcon()
{
	return (HCURSOR) m_hIcon;
}

void CCalsampleDlg::OnSelchangeCbofontmonthyear() 
{
	// TODO: Add your control notification handler code here
	
	CString strFont;

	m_CboFont.GetLBText(m_CboFont.GetCurSel(),strFont);

	m_Calendar.SetMonthYearFont(strFont);

	
}

void CCalsampleDlg::OnButton1() 
{
	// TODO: Add your control notification handler code here

	CColorDialog dlg;
	if(dlg.DoModal()==IDOK)
	{
		m_Calendar.SetMonthYearBackColor(dlg.GetColor());
	}

	m_Calendar.SetFocus();
}

void CCalsampleDlg::OnButton2() 
{
	// TODO: Add your control notification handler code here
	CColorDialog dlg;
	if(dlg.DoModal()==IDOK)
	{
		m_Calendar.SetMonthYearForeColor(dlg.GetColor());
	}
	
	m_Calendar.SetFocus();
}

void CCalsampleDlg::OnButton3() 
{
	// TODO: Add your control notification handler code here
	CColorDialog dlg;
	if(dlg.DoModal()==IDOK)
	{
		m_Calendar.SetDayCaptionBackColor(dlg.GetColor());
	}
	m_Calendar.SetFocus();
}

void CCalsampleDlg::OnButton4() 
{
	// TODO: Add your control notification handler code here
	CColorDialog dlg;
	if(dlg.DoModal()==IDOK)
	{
		m_Calendar.SetDayCaptionForeColor(dlg.GetColor());
	}
	
	m_Calendar.SetFocus();
}

void CCalsampleDlg::OnSelchangeCbofontdaycap() 
{
	// TODO: Add your control notification handler code here

	CString strFont;
	
	m_CboFontCap.GetLBText(m_CboFontCap.GetCurSel(),strFont);

	m_Calendar.SetDayCaptionFont(strFont);
	
}

void CCalsampleDlg::OnButton5() 
{
	// TODO: Add your control notification handler code here
	CColorDialog dlg;
	if(dlg.DoModal()==IDOK)
	{
		m_Calendar.SetDayColor(dlg.GetColor());
	}
	
	m_Calendar.SetFocus();
}

void CCalsampleDlg::OnSelchangeCbofontday() 
{
	// TODO: Add your control notification handler code here
	CString strFont;
	
	m_CboFontDay.GetLBText(m_CboFontDay.GetCurSel(),strFont);

	m_Calendar.SetDayFont(strFont);
	
}

void CCalsampleDlg::OnSelchangeCbofonttext() 
{
	// TODO: Add your control notification handler code here
	CString strFont;
	
	m_CboFontText.GetLBText(m_CboFontText.GetCurSel(),strFont);

	m_Calendar.SetDayTextFont(strFont);
	
}

void CCalsampleDlg::OnButton6() 
{
	// TODO: Add your control notification handler code here
	CColorDialog dlg;
	if(dlg.DoModal()==IDOK)
	{
		m_Calendar.SetDayTextColor(dlg.GetColor());
	}
	
	m_Calendar.SetFocus();
}

void CCalsampleDlg::OnBtngo() 
{
	// TODO: Add your control notification handler code here
	UpdateData(TRUE);

	m_Calendar.SetMonth(m_iMonth);
	m_Calendar.SetYear(m_iYear);

	m_Calendar.SetFocus();

}

void CCalsampleDlg::OnBTNHighLightSet() 
{
	// TODO: Add your control notification handler code here

	UpdateData(TRUE);

	CColorDialog dlg;
	if(dlg.DoModal()==IDOK)
		m_Calendar.SetHighLightDay(m_ihYear,m_ihMonth,m_ihDay,dlg.GetColor());

	m_Calendar.SetFocus();
}

void CCalsampleDlg::OnBTNSetText() 
{
	// TODO: Add your control notification handler code here
	UpdateData(TRUE);
	m_Calendar.SetText(m_iTextDay,m_strDayText);

	m_Calendar.SetFocus();

}

BEGIN_EVENTSINK_MAP(CCalsampleDlg, CDialog)
    //{{AFX_EVENTSINK_MAP(CCalsampleDlg)
	ON_EVENT(CCalsampleDlg, IDC_CALENDARCTRL1, 1 /* OnDayClick */, OnOnDayClickCalendarctrl1, VTS_I2 VTS_I2 VTS_I2 VTS_BSTR)
	//}}AFX_EVENTSINK_MAP
END_EVENTSINK_MAP()

void CCalsampleDlg::OnOnDayClickCalendarctrl1(short iYear, short iMonth, short iDay, LPCTSTR strText) 
{
	// TODO: Add your control notification handler code here

	CString strDay;
	strDay.Format("%d",iDay);

	GetDlgItem(IDC_EDITCURDAY)->SetWindowText(strDay);
	GetDlgItem(IDC_EDITCURTEXT)->SetWindowText(strText);
	
}

void CCalsampleDlg::OnButton7() 
{
	// TODO: Add your control notification handler code here
	UpdateData(TRUE);
	m_Calendar.SetDayCaptions(0,m_strDayCaption0);
	m_Calendar.SetDayCaptions(1,m_strDayCaption1);
	m_Calendar.SetDayCaptions(2,m_strDayCaption2);
	m_Calendar.SetDayCaptions(3,m_strDayCaption3);
	m_Calendar.SetDayCaptions(4,m_strDayCaption4);
	m_Calendar.SetDayCaptions(5,m_strDayCaption5);
	m_Calendar.SetDayCaptions(6,m_strDayCaption6);


}

void CCalsampleDlg::OnSelchangeCbodayfontsize() 
{
	// TODO: Add your control notification handler code here
	 
	 CString str;
	 m_CboDayFontSize.GetLBText(m_CboDayFontSize.GetCurSel(),str);
	 m_Calendar.SetDayTextFontSize(atoi(str));
	 
}

void CCalsampleDlg::OnButton8() 
{
	// TODO: Add your control notification handler code here
	
	UpdateData(TRUE);
	m_Calendar.SetMonth(this->m_iRangeMonth);
	m_Calendar.SetYear(this->m_iRangeYear);

	CString str;
	for(int i=m_iRangeStartDay ; i <=m_iRangeToDay;i++)
	{
		str.Format("%d",i);
		m_Calendar.SetText(i,str);
		m_Calendar.SetHighLightDay(m_Calendar.GetYear(),m_Calendar.GetMonth(),i,RGB(255,128,255));

	}

	m_Calendar.Redraw();
}

void CCalsampleDlg::OnButton9() 
{
	// TODO: Add your control notification handler code here
	UpdateData(TRUE);
	m_Calendar.SetMonth(this->m_iRangeMonth);
	m_Calendar.SetYear(this->m_iRangeYear);

	for(int i=m_iRangeStartDay ; i <=m_iRangeToDay;i++)
	{
		m_Calendar.SetText(i,"");
		m_Calendar.SetHighLightDay(m_Calendar.GetYear(),m_Calendar.GetMonth(),i,RGB(255,255,255));
	}

	m_Calendar.Redraw();

}

void CCalsampleDlg::OnButton10() 
{
	// TODO: Add your control notification handler code here
		UpdateData(TRUE);

	m_Calendar.SetDay(m_iSetDay);

	m_Calendar.SetFocus();
}
