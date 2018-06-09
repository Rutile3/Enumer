using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enumer{
    public partial class Enumer : Form{
        public Enumer(){
            InitializeComponent();
        }

        private void Enumer_Load(object sender, EventArgs e) {
#if DEBUG
            StringBuilder tmp = new StringBuilder();
            tmp.AppendLine("row(");
            tmp.AppendLine("row(123");
            tmp.AppendLine("rows(");
            tmp.AppendLine("rows(123");
            tmp.AppendLine("row()");
            tmp.AppendLine("row(123)");
            tmp.AppendLine("rows()");
            tmp.AppendLine("rows(123)");
            tmp.AppendLine("row(");
            MainTextBox.Text = tmp.ToString();
            frontText.Text = "row(";
#endif
        }

        private void runButton_Click(object sender, EventArgs e){
            string[] rows = MainTextBox.Text.Split('\n');
            string front_text = frontText.Text;

            StringBuilder result = new StringBuilder();
            int enum_count = (int)initCount.Value;
            for(int i = 0; i < rows.Length; i++){ 
                int index = rows[i].IndexOf(front_text);
                if (index != -1){
                    index += front_text.Length;
                    result.Append(rows[i].Substring(0, index)); //列挙部の前
                    result.Append(enum_count);                  //列挙部
                    try{                                        //列挙部の後ろ
                        while ('0' <= rows[i][index] && rows[i][index] <= '9') {
                            index++;
                        }
                        result.Append(rows[i].Substring(index));
                    }
                    catch(IndexOutOfRangeException){
                        //列挙部以降に文字がない場合を想定して
                    }

                    enum_count++;
                }
                else{
                    result.Append(rows[i]);
                }

                if(i < rows.Length - 1) {//最終行のみ改行しない
                    result.Append("\r\n");
                }
            }

            MainTextBox.Text = result.ToString();
        }
    }
}
