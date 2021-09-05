using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<List<YaQian>> yqRowList = new List<List<YaQian>>();
        /// <summary>
        /// 初始化牙签
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            int rowLength = 3;//总行数
            int yaQianLength = 3;//牙签一行的元素数量，会随着行数增加每次递增2
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= rowLength; i++)//添加行
            {
                List<YaQian> yqList = new List<YaQian>();
                for (int j = 1; j <= yaQianLength; j++)//添加牙签
                {
                    YaQian yq = new YaQian();
                    yq.YqId = $"{i}_{j}";//1_1,1_2，2_1,2_2以此类推
                    yq.YqName = $"{i}_{j}";//1_1,1_2，2_1,2_2以此类推
                    yq.RowId = i;//牙签所在行id
                    yqList.Add(yq);//添加牙签
                }
                yqRowList.Add(yqList);//缓存所有行
                sb.Append($"{string.Join(",", yqList.Select(c => c.YqName))}\r\n");//组合每行元素并换行
                yaQianLength += 2;//牙签一行的元素数量，递增2
            }
            listBox1.DisplayMember = "YqName";
            listBox1.Items.AddRange(yqRowList[0].ToArray());
            listBox2.DisplayMember = "YqName";
            listBox2.Items.AddRange(yqRowList[1].ToArray());
            listBox3.DisplayMember = "YqName";
            listBox3.Items.AddRange(yqRowList[2].ToArray());

            lbYQs.Text = sb.ToString();//显示在界面上
            if (wanJiaList.Count > 0)
            {
                lbTips.Text = "请选择一个玩家出手";
            }
            else
            {
                lbTips.Text = "请初始化玩家";
            }
            btnInitYq.Enabled = false;
        }
        List<WanJia> wanJiaList = new List<WanJia>();//玩家列表
        /// <summary>
        /// 初始化玩家
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInitWj_Click(object sender, EventArgs e)
        {
            int wanJiaLenght = 2;//两个玩家
            for (int i = 1; i <= wanJiaLenght; i++)
            {
                WanJia wj = new WanJia();
                wj.WjId = $"wanJia_{i}";//wanJia_1
                wj.WjName = $"玩家_{i}";//玩家_1
                wj.YaQians = new List<YaQian>();//元素列表
                wanJiaList.Add(wj);//添加玩家
            }
            lbWjs.Text = string.Join(",", wanJiaList.Select(c=>c.WjName));//显示在界面上
            if (listBox1.Items.Count > 0)
            {
                lbTips.Text = "请选择一个玩家出手";
            }
            else
            {
                lbTips.Text = "请初始化牙签";
            }
            btnInitWj.Enabled = false;
        }
        List<YaQian> wj1YqList = new List<YaQian>();
        List<YaQian> wj2YqList = new List<YaQian>();
        WanJia oldWj = new WanJia();
        /// <summary>
        /// 玩家一选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWj1_Click(object sender, EventArgs e)
        {
            if (wanJiaList.Count <= 0)
            {
                MessageBox.Show("请先初始化玩家");
                return;
            }
            bool isExecute = GetYaQian(wj1YqList,lb1Yq,wanJiaList[0]);//玩家1
            if (isExecute)
            {
                btnWj1.Enabled = false;
                btnWj2.Enabled = true;
                lbTips.Text = "该玩家 (2) 出手了";
            }
        }
        /// <summary>
        /// 玩家2选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWj2_Click(object sender, EventArgs e)
        {
            if (wanJiaList.Count <= 0)
            {
                MessageBox.Show("请先初始化玩家");
                return;
            }
            bool isExecute = GetYaQian(wj2YqList, lb2Yq, wanJiaList[1]);//玩家2
            if (isExecute)
            {
                btnWj1.Enabled = true;
                btnWj2.Enabled = false;
                lbTips.Text = "该玩家 (1) 出手了";
            }
        }
        /// <summary>
        /// 拿取牙签
        /// </summary>
        /// <param name="wjYqList">当前玩家的牙签列表</param>
        /// <param name="lbYq">当前玩家牙签列表要显示结果的文本框</param>
        /// <param name="wj">当前玩家</param>
        /// <returns></returns>
        public bool GetYaQian(List<YaQian> wjYqList,Label lbYq,WanJia wj)
        {
            int rowI = 0;
            var row1Yqs = listBox1.SelectedItems;
            var row2Yqs = listBox2.SelectedItems;
            var row3Yqs = listBox3.SelectedItems;
            if (row1Yqs.Count > 0) rowI++;
            if (row2Yqs.Count > 0) rowI++;
            if (row3Yqs.Count > 0) rowI++;
            if (rowI == 0)
            {
                MessageBox.Show("您没有拿取牙签");
                return false;
            }
            if (rowI > 1)
            {
                MessageBox.Show("不能跨行，只能拿取同一行的牙签");
                return false;
            }
            foreach (YaQian item in row1Yqs) 
                wjYqList.Add(item);
            for (int i = row1Yqs.Count - 1; i >= 0; i--) 
                listBox1.Items.Remove(row1Yqs[i]);
            foreach (YaQian item in row2Yqs) 
                wjYqList.Add(item);
            for (int i = row2Yqs.Count - 1; i >= 0; i--) 
                listBox2.Items.Remove(row2Yqs[i]);
            foreach (YaQian item in row3Yqs) 
                wjYqList.Add(item);
            for (int i = row3Yqs.Count - 1; i >= 0; i--) 
                listBox3.Items.Remove(row3Yqs[i]);
            string result = string.Join(",", wjYqList.Select(c => c.YqName));
            lbYq.Text = result;
            if (listBox1.Items.Count == 0 && listBox2.Items.Count == 0 && listBox3.Items.Count == 0)
            { 
                wj.IsLoser = true; 
                MessageBox.Show($"{wj.WjName} 输了，游戏结束"); 
                lbTips.Text=$"{wj.WjName} 输了，游戏结束";
                btnWj1.Enabled = false;
                btnWj2.Enabled = false;
                return false;
            }
            return true;//执行完成，后续需要改变按钮状态
        }
    }
}
