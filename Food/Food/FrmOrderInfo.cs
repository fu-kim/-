using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddFood
{
    public partial class FrmOrderInfo : Form
    {
        public FrmOrderInfo()
        {
            InitializeComponent();
        }

        private void tsmiClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiDaoChu_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmOrderInfo_Load(object sender, EventArgs e)
        {
            
        }
        [System.Runtime.InteropServices.DllImportAttribute("gdi32.dll")]//应用API函数
        private static extern bool BitBlt(
  IntPtr hdcDest, // 目标设备的句柄  
        int nXDest, // 目标对象的左上角的X坐标  
        int nYDest, // 目标对象的左上角的X坐标  
        int nWidth, // 目标对象的矩形的宽度  
        int nHeight, // 目标对象的矩形的长度  
        IntPtr hdcSrc, // 源设备的句柄  
        int nXSrc, // 源对象的左上角的X坐标  
        int nYSrc, // 源对象的左上角的X坐标  
        System.Int32 dwRop // 光栅的操作值  
        );
        Image memoryImage; //统计报表画图

        private void tsmiDaYin_Click(object sender, EventArgs e)
        {
            this.pageSetupDialog1.ShowDialog();
            Graphics graphic = panel1.CreateGraphics();
            Size s = panel1.Size;
            Bitmap memImage = new Bitmap(s.Width, s.Height, graphic);
            Graphics memGraphic = Graphics.FromImage(memImage);
            IntPtr dc1 = graphic.GetHdc();
            IntPtr dc2 = memGraphic.GetHdc();
            BitBlt(dc2, 0, 0, panel1.ClientRectangle.Width, panel1.ClientRectangle.Height,
            dc1, 0, 0, 13369376);

            //Clone the bitmap so we can dispose it. 
            memoryImage = (Bitmap)memImage.Clone();
            graphic.ReleaseHdc(dc1);
            memGraphic.ReleaseHdc(dc2);
            graphic.Dispose();
            memGraphic.Dispose();
            memImage.Dispose();


            PrintPreviewDialog dlg = new PrintPreviewDialog();
            //dlg.Width = 1800;
            //dlg.Height = 1600;
            //dlg.Document = printDocument1;
            //if (dlg.ShowDialog() == DialogResult.OK)
            printDocument1.Print();



        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, -10, 100);
        }
    }
}
