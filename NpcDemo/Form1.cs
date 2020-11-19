using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NpcDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 序列化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnS_Click(object sender, EventArgs e)
        {
            try
            {
                //初始化
                NPC npc = new NPC();
                string output = "";
                #region 連動資料
                npc.HP = int.Parse(tbHP.Text);  //string --> int
                npc.MP = int.Parse(tbMP.Text);  //string --> int
                npc.EXP = int.Parse(tbEXP.Text);  //string --> int
                #endregion

                //轉換
                output = JsonConvert.SerializeObject(npc);

                //結果
                rtbOutput.Text = output;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "錯誤訊息");
                //throw;  //不需要再往上拋
            }
        }

        /// <summary>
        /// 反序列化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnD_Click(object sender, EventArgs e)
        {
            try
            {
                //初始化
                NPC output = new NPC();
                string input = "";

                #region 連動資料
                input = rtbOutput.Text;
                #endregion

                //轉換
                output = JsonConvert.DeserializeObject<NPC>(input);


                //結果
                tbHP.Text = output.HP.ToString();
                tbMP.Text = output.MP.ToString();
                tbEXP.Text = output.EXP.ToString();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "錯誤訊息");
                //throw;  //不需要再往上拋
            }
        }
    }
}
