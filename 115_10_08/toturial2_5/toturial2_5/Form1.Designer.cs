namespace toturial2_5
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
            System.Windows.Forms.PictureBox cardface;
            System.Windows.Forms.PictureBox cardback;
            this.showbackbutton = new System.Windows.Forms.Button();
            this.showfacebutton = new System.Windows.Forms.Button();
            cardface = new System.Windows.Forms.PictureBox();
            cardback = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(cardface)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(cardback)).BeginInit();
            this.SuspendLayout();
            // 
            // cardface
            // 
            cardface.Image = global::toturial2_5.Properties.Resources.Ace_Spades;
            cardface.Location = new System.Drawing.Point(313, 58);
            cardface.Name = "cardface";
            cardface.Size = new System.Drawing.Size(198, 274);
            cardface.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            cardface.TabIndex = 0;
            cardface.TabStop = false;
            cardface.Visible = false;
            // 
            // cardback
            // 
            cardback.Image = global::toturial2_5.Properties.Resources.Backface_Blue;
            cardback.Location = new System.Drawing.Point(313, 58);
            cardback.Name = "cardback";
            cardback.Size = new System.Drawing.Size(198, 274);
            cardback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            cardback.TabIndex = 1;
            cardback.TabStop = false;
            // 
            // showbackbutton
            // 
            this.showbackbutton.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.showbackbutton.Location = new System.Drawing.Point(199, 348);
            this.showbackbutton.Name = "showbackbutton";
            this.showbackbutton.Size = new System.Drawing.Size(198, 61);
            this.showbackbutton.TabIndex = 2;
            this.showbackbutton.Text = "顯示背面";
            this.showbackbutton.UseVisualStyleBackColor = true;
            this.showbackbutton.Click += new System.EventHandler(this.showbackbutton_Click);
            // 
            // showfacebutton
            // 
            this.showfacebutton.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.showfacebutton.Location = new System.Drawing.Point(431, 348);
            this.showfacebutton.Name = "showfacebutton";
            this.showfacebutton.Size = new System.Drawing.Size(198, 61);
            this.showfacebutton.TabIndex = 3;
            this.showfacebutton.Text = "顯示正面";
            this.showfacebutton.UseVisualStyleBackColor = true;
            this.showfacebutton.Click += new System.EventHandler(this.showfacebutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showfacebutton);
            this.Controls.Add(this.showbackbutton);
            this.Controls.Add(cardback);
            this.Controls.Add(cardface);
            this.Name = "Form1";
            this.Text = "撲克台展示";
            ((System.ComponentModel.ISupportInitialize)(cardface)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(cardback)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showbackbutton;
        private System.Windows.Forms.Button showfacebutton;
    }
}

