namespace tutorial2_4
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
            this.德國pictureBox = new System.Windows.Forms.PictureBox();
            this.法國pictureBox = new System.Windows.Forms.PictureBox();
            this.芬蘭pictureBox = new System.Windows.Forms.PictureBox();
            this.國家label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.德國pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.法國pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.芬蘭pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // 德國pictureBox
            // 
            this.德國pictureBox.ErrorImage = null;
            this.德國pictureBox.Image = global::tutorial2_4.Properties.Resources.Germany1;
            this.德國pictureBox.Location = new System.Drawing.Point(565, 162);
            this.德國pictureBox.Name = "德國pictureBox";
            this.德國pictureBox.Size = new System.Drawing.Size(190, 105);
            this.德國pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.德國pictureBox.TabIndex = 2;
            this.德國pictureBox.TabStop = false;
            this.德國pictureBox.Click += new System.EventHandler(this.德國pictureBox_Click);
            // 
            // 法國pictureBox
            // 
            this.法國pictureBox.Image = global::tutorial2_4.Properties.Resources.France;
            this.法國pictureBox.Location = new System.Drawing.Point(292, 162);
            this.法國pictureBox.Name = "法國pictureBox";
            this.法國pictureBox.Size = new System.Drawing.Size(211, 105);
            this.法國pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.法國pictureBox.TabIndex = 1;
            this.法國pictureBox.TabStop = false;
            this.法國pictureBox.Click += new System.EventHandler(this.法國pictureBox_Click);
            // 
            // 芬蘭pictureBox
            // 
            this.芬蘭pictureBox.Image = global::tutorial2_4.Properties.Resources.Finland;
            this.芬蘭pictureBox.Location = new System.Drawing.Point(49, 162);
            this.芬蘭pictureBox.Name = "芬蘭pictureBox";
            this.芬蘭pictureBox.Size = new System.Drawing.Size(202, 105);
            this.芬蘭pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.芬蘭pictureBox.TabIndex = 0;
            this.芬蘭pictureBox.TabStop = false;
            this.芬蘭pictureBox.Click += new System.EventHandler(this.芬蘭pictureBox_Click);
            // 
            // 國家label
            // 
            this.國家label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.國家label.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.國家label.Location = new System.Drawing.Point(235, 306);
            this.國家label.Name = "國家label";
            this.國家label.Size = new System.Drawing.Size(301, 94);
            this.國家label.TabIndex = 3;
            this.國家label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.國家label.Click += new System.EventHandler(this.國家label_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(788, 159);
            this.label1.TabIndex = 4;
            this.label1.Text = "點選一個國旗我告訴你是哪一個國家";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.國家label);
            this.Controls.Add(this.德國pictureBox);
            this.Controls.Add(this.法國pictureBox);
            this.Controls.Add(this.芬蘭pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.德國pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.法國pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.芬蘭pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox 芬蘭pictureBox;
        private System.Windows.Forms.PictureBox 法國pictureBox;
        private System.Windows.Forms.PictureBox 德國pictureBox;
        private System.Windows.Forms.Label 國家label;
        private System.Windows.Forms.Label label1;
    }
}

