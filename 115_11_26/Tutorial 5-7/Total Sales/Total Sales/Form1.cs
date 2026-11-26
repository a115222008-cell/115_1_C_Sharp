using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Total_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 計算按鈕點擊事件處理
            try
            {
                StreamReader inputFile;
                // 打開文件
                inputFile = File.OpenText("Sales.txt");

                decimal total = 0m; // 儲存總銷售額

                // 讀取文件中的每一行，直到文件結束

                while (!inputFile.EndOfStream)
                {
                    

                    if (decimal.TryParse(inputFile.ReadLine(), out decimal sales))
                    {
                        total += sales; 
                    }
                    else
                    {
                        MessageBox.Show("檔案中包含無效的銷售額數據。");
                    }
                }
                // 顯示總銷售額
                inputFile.Close();

                totalLabel.Text = total.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"發生錯誤：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
