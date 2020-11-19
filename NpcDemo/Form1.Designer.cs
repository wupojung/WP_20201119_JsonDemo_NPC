namespace NpcDemo
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tbHP = new System.Windows.Forms.TextBox();
            this.tbMP = new System.Windows.Forms.TextBox();
            this.tbEXP = new System.Windows.Forms.TextBox();
            this.btnS = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tbHP
            // 
            this.tbHP.Location = new System.Drawing.Point(45, 60);
            this.tbHP.Name = "tbHP";
            this.tbHP.Size = new System.Drawing.Size(100, 22);
            this.tbHP.TabIndex = 0;
            // 
            // tbMP
            // 
            this.tbMP.Location = new System.Drawing.Point(45, 89);
            this.tbMP.Name = "tbMP";
            this.tbMP.Size = new System.Drawing.Size(100, 22);
            this.tbMP.TabIndex = 1;
            // 
            // tbEXP
            // 
            this.tbEXP.Location = new System.Drawing.Point(45, 131);
            this.tbEXP.Name = "tbEXP";
            this.tbEXP.Size = new System.Drawing.Size(100, 22);
            this.tbEXP.TabIndex = 2;
            // 
            // btnS
            // 
            this.btnS.Location = new System.Drawing.Point(269, 68);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(75, 23);
            this.btnS.TabIndex = 3;
            this.btnS.Text = "--->";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(269, 131);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(75, 23);
            this.btnD.TabIndex = 4;
            this.btnD.Text = "<---";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(387, 35);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(215, 148);
            this.rtbOutput.TabIndex = 5;
            this.rtbOutput.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.tbEXP);
            this.Controls.Add(this.tbMP);
            this.Controls.Add(this.tbHP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbHP;
        private System.Windows.Forms.TextBox tbMP;
        private System.Windows.Forms.TextBox tbEXP;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.RichTextBox rtbOutput;
    }
}

