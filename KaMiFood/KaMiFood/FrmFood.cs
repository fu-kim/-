using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using BLL;
using Models;

namespace KaMiFood
{
    public partial class FrmFood : UserControl
    {
        public FrmFood()
        {
            InitializeComponent();
        }
        public string sel = "";
        #region 判断界面是否选中
        public void select(string food)
        {
            if (food == "热菜")
            {
                pbxHotDishes.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\热菜选中.png");
            }
            else
            {
                pbxHotDishes.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\热菜.png");
            }

            if (food == "凉菜")
            {
                pbxColdDishes.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\凉菜选中.png");
            }
            else
            {
                pbxColdDishes.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\凉菜.png");
            }

            if (food == "汤类")
            {
                pbxSoup.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\汤类选中.png");
            }
            else
            {
                pbxSoup.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\汤类.png");
            }

            if (food == "酒水")
            {
                pbxWine.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\酒水选中.png");
            }
            else
            {
                pbxWine.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\酒水.png");
            }
            if (food == "其他")
            {
                pbxOther.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\其他选中.png");
            }
            else
            {
                pbxOther.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\其他.png");
            }
            if (food == "热销")
            {
                pbxHot.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\热销菜品选中.png");
            }
            else
            {
                pbxHot.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\热销菜品.png");
            }
            if (food == "新品")
            {
                pbxNew.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\新品菜品选中.png");
            }
            else
            {
                pbxNew.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\新品菜品.png");
            }
        }
        #endregion

        #region 窗体加载事件
        private void FrmFood_Load(object sender, EventArgs e)
        {
            ProcessMain.Visible = true;
            flpMain.Controls.Clear();
            List<Food> fd = FoodManager.SelectFoodAll();

            for (int i = 0; i < fd.Count; i++)
            {
                FrmFoodInfo t = new FrmFoodInfo();
                t.pbxImage.Image = Image.FromFile(Application.StartupPath + @"\Images\食物\"+fd[i].FoodImage+".jpg");
                t.lbFoodName.Text = fd[i].FoodName;
                t.lbRMB.Text = fd[i].Price.ToString().Substring(0, 4);
                double VipPrice =Convert.ToDouble( t.lbRMB.Text);
                t.lbVipPrice.Text = (VipPrice * 0.8).ToString();
                flpMain.Controls.Add(t);
            }
            tmrProcess.Enabled = true;
        } 
        #endregion

        #region 鼠标移动效果
        #region 热菜鼠标移动效果
        private void pbxHotDishes_MouseMove(object sender, MouseEventArgs e)
        {
            pbxHotDishes.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\热菜选中.png");
        }

        private void pbxHotDishes_MouseLeave(object sender, EventArgs e)
        {
            select(sel);
        }

        #endregion
        #region 凉菜鼠标移动效果
        private void pbxColdDishes_MouseMove(object sender, MouseEventArgs e)
        {
            pbxColdDishes.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\凉菜选中.png");
        }

        private void pbxColdDishes_MouseLeave(object sender, EventArgs e)
        {
            select(sel);
        }

        #endregion
        #region 汤类鼠标移动效果
        private void pbxSoup_MouseMove(object sender, MouseEventArgs e)
        {
            pbxSoup.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\汤类选中.png");
        }

        private void pbxSoup_MouseLeave(object sender, EventArgs e)
        {
            select(sel);
        }

        #endregion
        #region 酒水鼠标移动效果
        private void pbxWine_MouseMove(object sender, MouseEventArgs e)
        {
            pbxWine.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\酒水选中.png");
        }

        private void pbxWine_MouseLeave(object sender, EventArgs e)
        {
            select(sel);
        }

        #endregion
        #region 其他鼠标移动效果
        private void pbxOther_MouseMove(object sender, MouseEventArgs e)
        {
            pbxOther.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\其他选中.png");
        }

        private void pbxOther_MouseLeave(object sender, EventArgs e)
        {
            select(sel);
        }
        #endregion
        #region 新品菜品鼠标移动效果
        private void pbxNew_MouseMove(object sender, MouseEventArgs e)
        {
            pbxNew.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\新品菜品选中.png");
        }

        private void pbxNew_MouseLeave(object sender, EventArgs e)
        {
            select(sel);
        }
        #endregion
        #region 热销菜品鼠标移动效果
        private void pbxHot_MouseMove(object sender, MouseEventArgs e)
        {
            pbxHot.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\热销菜品选中.png");
        }

        private void pbxHot_MouseLeave(object sender, EventArgs e)
        {
            select(sel);
        } 
        #endregion

        #endregion

        #region 加载菜品类型
        /// <summary>
        /// 加载菜品类型
        /// </summary>
        /// <param name="type">类型</param>
        public void FoodType(string type)
        {
            flpMain.Controls.Clear();
            List<Food> fd = FoodManager.SelectFoodbyType(type);
            for (int i = 0; i < fd.Count; i++)
            {
                FrmFoodInfo t = new FrmFoodInfo();
                Food fds = new Food();
                t.pbxImage.Image = Image.FromFile(Application.StartupPath + @"\Images\食物\"+fd[i].FoodImage+".jpg");
                t.lbFoodName.Text = fd[i].FoodName;
                t.lbRMB.Text = fd[i].Price.ToString().Substring(0, 4);
                double VipPrice = Convert.ToDouble(t.lbRMB.Text);
                t.lbVipPrice.Text = (VipPrice * 0.8).ToString();
                this.flpMain.Controls.Add(t);
            }

        }
        #endregion

        #region 类型点击事件
        #region 新品点击事件
        private void pbxNew_Click(object sender, EventArgs e)
        {
            FoodType("7");
            pbxNew.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\新品菜品选中.png");
            pbxHot.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\热销菜品.png");
            pbxHotDishes.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\热菜.png");
            pbxColdDishes.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\凉菜.png");
            pbxSoup.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\汤类.png");
            pbxWine.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\酒水.png");
            pbxOther.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\其他.png");
            sel = "新品";
        }

        #endregion
        #region 热销点击事件
        private void pbxHot_Click(object sender, EventArgs e)
        {
            FoodType("6");
            pbxNew.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\新品菜品.png");
            pbxHot.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\热销菜品选中.png");
            pbxHotDishes.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\热菜.png");
            pbxColdDishes.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\凉菜.png");
            pbxSoup.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\汤类.png");
            pbxWine.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\酒水.png");
            pbxOther.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\其他.png");
            sel = "热销";
        } 
        #endregion
        #region 热菜点击事件
        private void pbxHotDishes_Click(object sender, EventArgs e)
        {
            FoodType("1");
            pbxNew.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\新品菜品.png");
            pbxHot.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\热销菜品.png");
            pbxHotDishes.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\热菜选中.png");
            pbxColdDishes.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\凉菜.png");
            pbxSoup.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\汤类.png");
            pbxWine.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\酒水.png");
            pbxOther.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\其他.png");
            sel = "热菜";
        }

        #endregion
        #region 凉菜点击事件
        private void pbxColdDishes_Click(object sender, EventArgs e)
        {
            FoodType("2");
            pbxNew.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\新品菜品.png");
            pbxHot.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\热销菜品.png");
            pbxHotDishes.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\热菜.png");
            pbxColdDishes.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\凉菜选中.png");
            pbxSoup.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\汤类.png");
            pbxWine.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\酒水.png");
            pbxOther.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\其他.png");
            sel = "凉菜";
        }

        #endregion
        #region 汤类点击事件
        private void pbxSoup_Click(object sender, EventArgs e)
        {
            FoodType("3");
            pbxNew.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\新品菜品.png");
            pbxHot.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\热销菜品.png");
            pbxHotDishes.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\热菜.png");
            pbxColdDishes.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\凉菜.png");
            pbxSoup.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\汤类选中.png");
            pbxWine.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\酒水.png");
            pbxOther.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\其他.png");
            sel = "汤类";
        }

        #endregion
        #region 酒水点击事件
        private void pbxWine_Click(object sender, EventArgs e)
        {
            FoodType("4");
            pbxNew.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\新品菜品.png");
            pbxHot.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\热销菜品.png");
            pbxHotDishes.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\热菜.png");
            pbxColdDishes.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\凉菜.png");
            pbxSoup.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\汤类.png");
            pbxWine.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\酒水选中.png");
            pbxOther.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\其他.png");
            sel = "酒水";
        }

        #endregion
        #region 其他点击事件
        private void pbxOther_Click(object sender, EventArgs e)
        {
            FoodType("5");
            pbxNew.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\新品菜品.png");
            pbxHot.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\热销菜品.png");
            pbxHotDishes.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\热菜.png");
            pbxColdDishes.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\凉菜.png");
            pbxSoup.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\汤类.png");
            pbxWine.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\酒水.png");
            pbxOther.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\其他选中.png");
            sel = "其他";
        }
        #endregion

        #endregion

        #region 小键盘按键
        private void QIN_Click(object sender, EventArgs e)
        {
            txtFind.Text = "";
        }
        private void AA_Click(object sender, EventArgs e)
        {
            txtFind.Text += "A";
        }

        private void BB_Click(object sender, EventArgs e)
        {
            txtFind.Text += "B";
        }

        private void CC_Click(object sender, EventArgs e)
        {
            txtFind.Text += "C";
        }

        private void DD_Click(object sender, EventArgs e)
        {
            txtFind.Text += "D";
        }

        private void FF_Click(object sender, EventArgs e)
        {
            txtFind.Text += "F";
        }

        private void GG_Click(object sender, EventArgs e)
        {
            txtFind.Text += "G";
        }

        private void NN_Click(object sender, EventArgs e)
        {
            txtFind.Text += "N";
        }

        private void UU_Click(object sender, EventArgs e)
        {
            txtFind.Text += "U";
        }

        private void TT_Click(object sender, EventArgs e)
        {
            txtFind.Text += "T";
        }

        private void MM_Click(object sender, EventArgs e)
        {
            txtFind.Text += "M";
        }

        private void LL_Click(object sender, EventArgs e)
        {
            txtFind.Text += "L";
        }

        private void SS_Click(object sender, EventArgs e)
        {
            txtFind.Text += "S";
        }

        private void RR_Click(object sender, EventArgs e)
        {
            txtFind.Text += "R";
        }

        private void KK_Click(object sender, EventArgs e)
        {
            txtFind.Text += "K";
        }

        private void JJ_Click(object sender, EventArgs e)
        {
            txtFind.Text += "J";
        }

        private void QQ_Click(object sender, EventArgs e)
        {
            txtFind.Text += "Q";
        }

        private void PP_Click(object sender, EventArgs e)
        {
            txtFind.Text += "P";
        }

        private void II_Click(object sender, EventArgs e)
        {
            txtFind.Text += "I";
        }

        private void HH_Click(object sender, EventArgs e)
        {
            txtFind.Text += "H";
        }

        private void OO_Click(object sender, EventArgs e)
        {
            txtFind.Text += "O";
        }

        private void VV_Click(object sender, EventArgs e)
        {
            txtFind.Text += "V";
        }

        private void WW_Click(object sender, EventArgs e)
        {
            txtFind.Text += "W";
        }

        private void XX_Click(object sender, EventArgs e)
        {
            txtFind.Text += "X";
        }

        private void ZZ_Click(object sender, EventArgs e)
        {
            txtFind.Text += "Z";
        }

        private void YY_Click(object sender, EventArgs e)
        {
            txtFind.Text += "Y";
        }

        private void EE_Click(object sender, EventArgs e)
        {
            txtFind.Text += "E";
        }
        #endregion

        #region 查找获取焦点
        private void txtFind_Enter(object sender, EventArgs e)
        {
            plKey.Visible = true;
        }

        private void txtFind_Leave(object sender, EventArgs e)
        {
            plKey.Visible = false;
        }
        #endregion

        #region 在指定的字符串列表CnStr中检索符合拼音索引字符串

        /// <summary>

        /// 在指定的字符串列表CnStr中检索符合拼音索引字符串

        /// </summary>

        /// <param name="CnStr">汉字字符串</param>

        /// <returns>相对应的汉语拼音首字母串</returns>

        public static string GetSpellCode(string CnStr)
        {

            string strTemp = "";

            int iLen = CnStr.Length;

            int i = 0;
            //strTemp = GetCharSpellCode(CnStr.Substring(0, 1));
            for (i = 0; i <= iLen - 1; i++)
            {

                strTemp += GetCharSpellCode(CnStr.Substring(i, 1));

            }

            return strTemp;

        } 
        #endregion

        #region 得到一个汉字的拼音第一个字母，如果是一个英文字母则直接返回大写字母
        /// <summary>

        /// 得到一个汉字的拼音第一个字母，如果是一个英文字母则直接返回大写字母

        /// </summary>

        /// <param name="CnChar">单个汉字</param>

        /// <returns>单个大写字母</returns>

        private static string GetCharSpellCode(string CnChar)
        {

            long iCnChar;

            byte[] ZW = System.Text.Encoding.Default.GetBytes(CnChar);

            //如果是字母，则直接返回

            if (ZW.Length == 1)
            {

                return CnChar.ToUpper();

            }

            else
            {

                // get the array of byte from the single char

                int i1 = (short)(ZW[0]);

                int i2 = (short)(ZW[1]);

                iCnChar = i1 * 256 + i2;

            }

            // iCnChar match the constant

            if ((iCnChar >= 45217) && (iCnChar <= 45252))
            {

                return "A";

            }

            else if ((iCnChar >= 45253) && (iCnChar <= 45760))
            {

                return "B";

            }
            else if ((iCnChar >= 45761) && (iCnChar <= 46317))
            {

                return "C";

            }
            else if ((iCnChar >= 46318) && (iCnChar <= 46825))
            {

                return "D";

            }
            else if ((iCnChar >= 46826) && (iCnChar <= 47009))
            {

                return "E";

            }
            else if ((iCnChar >= 47010) && (iCnChar <= 47296))
            {

                return "F";

            }
            else if ((iCnChar >= 47297) && (iCnChar <= 47613))
            {

                return "G";

            }
            else if ((iCnChar >= 47614) && (iCnChar <= 48118))
            {

                return "H";

            }
            else if ((iCnChar >= 48119) && (iCnChar <= 49061))
            {

                return "J";

            }
            else if ((iCnChar >= 49062) && (iCnChar <= 49323))
            {

                return "K";

            }
            else if ((iCnChar >= 49324) && (iCnChar <= 49895))
            {

                return "L";

            }
            else if ((iCnChar >= 49896) && (iCnChar <= 50370))
            {

                return "M";

            }
            else if ((iCnChar >= 50371) && (iCnChar <= 50613))
            {

                return "N";

            }
            else if ((iCnChar >= 50614) && (iCnChar <= 50621))
            {

                return "O";

            }
            else if ((iCnChar >= 50622) && (iCnChar <= 50905))
            {

                return "P";

            }
            else if ((iCnChar >= 50906) && (iCnChar <= 51386))
            {

                return "Q";

            }
            else if ((iCnChar >= 51387) && (iCnChar <= 51445))
            {

                return "R";

            }
            else if ((iCnChar >= 51446) && (iCnChar <= 52217))
            {

                return "S";

            }
            else if ((iCnChar >= 52218) && (iCnChar <= 52697))
            {

                return "T";

            }
            else if ((iCnChar >= 52698) && (iCnChar <= 52979))
            {

                return "W";

            }
            else if ((iCnChar >= 52980) && (iCnChar <= 53640))
            {

                return "X";

            }
            else if ((iCnChar >= 53689) && (iCnChar <= 54480))
            {

                return "Y";

            }
            else if ((iCnChar >= 54481) && (iCnChar <= 55289))
            {

                return "Z";

            }
            else

                return ("?");

        }

        #endregion

        #region 查找事件
        List<string> fd = FoodManager.SelectFoodName();
        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            pbxNew.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\新品菜品.png");
            pbxHot.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\热销菜品.png");
            pbxHotDishes.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\热菜.png");
            pbxColdDishes.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\凉菜.png");
            pbxSoup.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\汤类.png");
            pbxWine.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\酒水.png");
            pbxOther.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\其他.png");
            string text1 = GetSpellCode(txtFind.Text);
            if (text1 == "")
            {
                flpMain.Controls.Clear();
                List<Food> fd = FoodManager.SelectFoodAll();

                for (int i = 0; i < fd.Count; i++)
                {
                    FrmFoodInfo t = new FrmFoodInfo();
                    t.pbxImage.Image = Image.FromFile(Application.StartupPath + @"\Images\食物\" + fd[i].FoodImage + ".jpg");
                    t.lbFoodName.Text = fd[i].FoodName;
                    t.lbRMB.Text = fd[i].Price.ToString().Substring(0, 4);
                    double VipPrice = Convert.ToDouble(t.lbRMB.Text);
                    t.lbVipPrice.Text = (VipPrice * 0.8).ToString();
                    flpMain.Controls.Add(t);
                }
            }
            else
            {
                List<string> list = new List<string>();
                for (int i = 0; i < fd.Count; i++)
                {
                    if (GetSpellCode(fd[i].ToString()).IndexOf(text1) == 0)
                    {
                        list.Add(fd[i]);
                        flpMain.Controls.Clear();
                    }
                }
                for (int i = 0; i < list.Count; i++)
                {
                    List<Food> fd = FoodManager.SelectFoodbyFoodName(list[i]);
                    for (int j = 0; j < fd.Count; j++)
                    {
                        FrmFoodInfo t = new FrmFoodInfo();
                        t.pbxImage.Image = Image.FromFile(Application.StartupPath + @"\Images\食物\" + fd[j].FoodImage + ".jpg");
                        t.lbFoodName.Text = fd[j].FoodName;
                        t.lbRMB.Text = fd[j].Price.ToString().Substring(0, 4);
                        double VipPrice = Convert.ToDouble(t.lbRMB.Text);
                        t.lbVipPrice.Text = (VipPrice * 0.8).ToString();
                        flpMain.Controls.Add(t);
                    }
                }

            }
        }

        #endregion

        int timer = 0;
        private void tmrProcess_Tick(object sender, EventArgs e)
        {
            timer += 10;
            Process.Value = timer;
            lcMain.Active = true;
            lbPercent.Text = timer + "%";
            if (timer >= 100)
            {
                tmrProcess.Enabled = false;
                tmrProcess2.Enabled = true;
                //ProcessMain.Visible = false;
            }
        }

        private void tmrProcess2_Tick(object sender, EventArgs e)
        {
            timer += 5;
            if (timer >= 120)
            {
                ProcessMain.Visible = false;
                tmrProcess2.Enabled = false;
            }
        }


    }
}
