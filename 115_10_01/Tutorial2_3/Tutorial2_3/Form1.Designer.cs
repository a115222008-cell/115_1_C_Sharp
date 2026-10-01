namespace Tutorial2_3
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
            this.label1 = new System.Windows.Forms.Label();
            this.translateLabel = new System.Windows.Forms.Label();
            this.義大利按鈕 = new System.Windows.Forms.Button();
            this.西班牙按鈕 = new System.Windows.Forms.Button();
            this.德國按鈕 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(37, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(699, 132);
            this.label1.TabIndex = 0;
            this.label1.Text = "選擇一個語言，我告訴你怎麼說\"早安\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // translateLabel
            // 
            this.translateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.translateLabel.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.translateLabel.Location = new System.Drawing.Point(148, 182);
            this.translateLabel.Name = "translateLabel";
            this.translateLabel.Size = new System.Drawing.Size(480, 111);
            this.translateLabel.TabIndex = 1;
            this.translateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.translateLabel.Click += new System.EventHandler(this.translateLabel_Click);
            // 
            // 義大利按鈕
            // 
            this.義大利按鈕.Location = new System.Drawing.Point(77, 325);
            this.義大利按鈕.Name = "義大利按鈕";
            this.義大利按鈕.Size = new System.Drawing.Size(125, 63);
            this.義大利按鈕.TabIndex = 2;
            this.義大利按鈕.Text = "義大利";
            this.義大利按鈕.UseVisualStyleBackColor = true;
            this.義大利按鈕.Click += new System.EventHandler(this.義大利按鈕_Click);
            // 
            // 西班牙按鈕
            // 
            this.西班牙按鈕.Location = new System.Drawing.Point(321, 325);
            this.西班牙按鈕.Name = "西班牙按鈕";
            this.西班牙按鈕.Size = new System.Drawing.Size(125, 63);
            this.西班牙按鈕.TabIndex = 3;
            this.西班牙按鈕.Text = "西班牙";
            this.西班牙按鈕.UseVisualStyleBackColor = true;
            this.西班牙按鈕.Click += new System.EventHandler(this.西班牙按鈕_Click);
            // 
            // 德國按鈕
            // 
            this.德國按鈕.Location = new System.Drawing.Point(611, 325);
            this.德國按鈕.Name = "德國按鈕";
            this.德國按鈕.Size = new System.Drawing.Size(125, 63);
            this.德國按鈕.TabIndex = 4;
            this.德國按鈕.Text = "德國";
            this.德國按鈕.UseVisualStyleBackColor = true;
            this.德國按鈕.Click += new System.EventHandler(this.德國按鈕_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.德國按鈕);
            this.Controls.Add(this.西班牙按鈕);
            this.Controls.Add(this.義大利按鈕);
            this.Controls.Add(this.translateLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label translateLabel;
        private System.Windows.Forms.Button 義大利按鈕;
        private System.Windows.Forms.Button 西班牙按鈕;
        private System.Windows.Forms.Button 德國按鈕;
    }
}

