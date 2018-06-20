using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

           public UInt32  Color2Uint32(  Color clr) 
           {
                            // Dim t As Int32
                int t;
                //Dim a() As Byte
                byte[] a  ;
                t = ColorTranslator.ToOle(clr);
                a = BitConverter.GetBytes(t);
                return BitConverter.ToUInt32(a, 0);
           }

           private void button1_Click(object sender, EventArgs e)
           {
               ColorDialog colorDlg = new ColorDialog();

               if (colorDlg.ShowDialog() == DialogResult.OK)
               {
                   axCalendar1.Month = 1;
                   axCalendar1.SetHighLightDay(2016, 1, 1, Color2Uint32(colorDlg.Color));
               }
           }

           private void button2_Click(object sender, EventArgs e)
           {
               ColorDialog colorDlg = new ColorDialog();

               if (colorDlg.ShowDialog() == DialogResult.OK)
               {
                   axCalendar2.Month = 2;
                   axCalendar2.SetHighLightDay(2016, 2, 1, Color2Uint32(colorDlg.Color));
               }
           }

           private void button3_Click(object sender, EventArgs e)
           {
               ColorDialog colorDlg = new ColorDialog();

               if (colorDlg.ShowDialog() == DialogResult.OK)
               {
                   axCalendar3.Month = 3;
                   axCalendar3.SetHighLightDay(2016, 3, 1, Color2Uint32(colorDlg.Color));
               }
           }

           private void button4_Click(object sender, EventArgs e)
           {
               ColorDialog colorDlg = new ColorDialog();

               if (colorDlg.ShowDialog() == DialogResult.OK)
               {
                   axCalendar4.Month = 4;
                   axCalendar4.SetHighLightDay(2016, 4, 1, Color2Uint32(colorDlg.Color));
               }
           }

           private void button5_Click(object sender, EventArgs e)
           {
               ColorDialog colorDlg = new ColorDialog();

               if (colorDlg.ShowDialog() == DialogResult.OK)
               {
                   axCalendar5.Month = 5;
                   axCalendar5.SetHighLightDay(2016, 5, 1, Color2Uint32(colorDlg.Color));
               }
           }

           private void button6_Click(object sender, EventArgs e)
           {
               ColorDialog colorDlg = new ColorDialog();

               if (colorDlg.ShowDialog() == DialogResult.OK)
               {
                   axCalendar6.Month = 6;
                   axCalendar6.SetHighLightDay(2016, 6, 1, Color2Uint32(colorDlg.Color));
               }
           }
  


   
    }
}
