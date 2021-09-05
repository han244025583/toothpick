
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInitYq = new System.Windows.Forms.Button();
            this.btnWj1 = new System.Windows.Forms.Button();
            this.lbYQs = new System.Windows.Forms.Label();
            this.btnWj2 = new System.Windows.Forms.Button();
            this.lbWjs = new System.Windows.Forms.Label();
            this.btnInitWj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb1Yq = new System.Windows.Forms.Label();
            this.lb2Yq = new System.Windows.Forms.Label();
            this.lbTips = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInitYq
            // 
            this.btnInitYq.Location = new System.Drawing.Point(377, 32);
            this.btnInitYq.Name = "btnInitYq";
            this.btnInitYq.Size = new System.Drawing.Size(90, 23);
            this.btnInitYq.TabIndex = 0;
            this.btnInitYq.Text = "初始化牙签行";
            this.btnInitYq.UseVisualStyleBackColor = true;
            this.btnInitYq.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnWj1
            // 
            this.btnWj1.Location = new System.Drawing.Point(377, 164);
            this.btnWj1.Name = "btnWj1";
            this.btnWj1.Size = new System.Drawing.Size(181, 48);
            this.btnWj1.TabIndex = 1;
            this.btnWj1.Text = "玩家 (1) 获取选中的牙签";
            this.btnWj1.UseVisualStyleBackColor = true;
            this.btnWj1.Click += new System.EventHandler(this.btnWj1_Click);
            // 
            // lbYQs
            // 
            this.lbYQs.AutoSize = true;
            this.lbYQs.Location = new System.Drawing.Point(520, 37);
            this.lbYQs.Name = "lbYQs";
            this.lbYQs.Size = new System.Drawing.Size(53, 12);
            this.lbYQs.TabIndex = 2;
            this.lbYQs.Text = "未初始化";
            // 
            // btnWj2
            // 
            this.btnWj2.Location = new System.Drawing.Point(377, 312);
            this.btnWj2.Name = "btnWj2";
            this.btnWj2.Size = new System.Drawing.Size(181, 66);
            this.btnWj2.TabIndex = 1;
            this.btnWj2.Text = "玩家 (2) 获取选中的牙签";
            this.btnWj2.UseVisualStyleBackColor = true;
            this.btnWj2.Click += new System.EventHandler(this.btnWj2_Click);
            // 
            // lbWjs
            // 
            this.lbWjs.AutoSize = true;
            this.lbWjs.Location = new System.Drawing.Point(188, 37);
            this.lbWjs.Name = "lbWjs";
            this.lbWjs.Size = new System.Drawing.Size(53, 12);
            this.lbWjs.TabIndex = 4;
            this.lbWjs.Text = "未初始化";
            // 
            // btnInitWj
            // 
            this.btnInitWj.Location = new System.Drawing.Point(80, 33);
            this.btnInitWj.Name = "btnInitWj";
            this.btnInitWj.Size = new System.Drawing.Size(75, 23);
            this.btnInitWj.TabIndex = 5;
            this.btnInitWj.Text = "初始化玩家";
            this.btnInitWj.UseVisualStyleBackColor = true;
            this.btnInitWj.Click += new System.EventHandler(this.btnInitWj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "第 1 行";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "第 2 行";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "第 3 行";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 12;
            this.listBox2.Location = new System.Drawing.Point(149, 124);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox2.Size = new System.Drawing.Size(71, 196);
            this.listBox2.TabIndex = 8;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 12;
            this.listBox3.Location = new System.Drawing.Point(233, 124);
            this.listBox3.Name = "listBox3";
            this.listBox3.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox3.Size = new System.Drawing.Size(71, 292);
            this.listBox3.TabIndex = 8;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(65, 124);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(71, 124);
            this.listBox1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "玩家 1 牙签列表:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "玩家 2 牙签列表:";
            // 
            // lb1Yq
            // 
            this.lb1Yq.AutoSize = true;
            this.lb1Yq.Location = new System.Drawing.Point(384, 243);
            this.lb1Yq.Name = "lb1Yq";
            this.lb1Yq.Size = new System.Drawing.Size(17, 12);
            this.lb1Yq.TabIndex = 7;
            this.lb1Yq.Text = "无";
            // 
            // lb2Yq
            // 
            this.lb2Yq.AutoSize = true;
            this.lb2Yq.Location = new System.Drawing.Point(379, 406);
            this.lb2Yq.Name = "lb2Yq";
            this.lb2Yq.Size = new System.Drawing.Size(17, 12);
            this.lb2Yq.TabIndex = 7;
            this.lb2Yq.Text = "无";
            // 
            // lbTips
            // 
            this.lbTips.AutoSize = true;
            this.lbTips.Font = new System.Drawing.Font("宋体", 20F);
            this.lbTips.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbTips.Location = new System.Drawing.Point(381, 91);
            this.lbTips.Name = "lbTips";
            this.lbTips.Size = new System.Drawing.Size(282, 27);
            this.lbTips.TabIndex = 7;
            this.lbTips.Text = "请先初始化玩家和牙签";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb2Yq);
            this.Controls.Add(this.lbTips);
            this.Controls.Add(this.lb1Yq);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInitWj);
            this.Controls.Add(this.lbWjs);
            this.Controls.Add(this.lbYQs);
            this.Controls.Add(this.btnWj2);
            this.Controls.Add(this.btnWj1);
            this.Controls.Add(this.btnInitYq);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInitYq;
        private System.Windows.Forms.Button btnWj1;
        private System.Windows.Forms.Label lbYQs;
        private System.Windows.Forms.Button btnWj2;
        private System.Windows.Forms.Label lbWjs;
        private System.Windows.Forms.Button btnInitWj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb1Yq;
        private System.Windows.Forms.Label lb2Yq;
        private System.Windows.Forms.Label lbTips;
    }
}

