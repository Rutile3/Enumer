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
            StringBuilder tmp = new StringBuilder();
            tmp.AppendLine("row(");
            tmp.AppendLine("row(123");
            tmp.AppendLine("rows(");
            tmp.AppendLine("rows(123");
            tmp.AppendLine("row()");
            tmp.AppendLine("row(123)");
            tmp.AppendLine("rows()");
            tmp.AppendLine("rows(123)");
            frontText.Text = "row(";
            MainTextBox.Text = tmp.ToString();
            frontText.Text = "row(";
        }

        private void button1_Click(object sender, EventArgs e){
            string[] list = MainTextBox.Text.Split('\n');
            string front_text = frontText.Text;

            StringBuilder result = new StringBuilder();
            int enum_count = (int)initCount.Value;
            foreach (string row in list) {
                int index = row.IndexOf(front_text);
                if (index != -1){
                    index += front_text.Length;
                    result.Append(row.Substring(0, index));
                    result.Append(enum_count);

                    while('0' <= row[index]  && row[index] <= '9'){
                        index++;
                    }

                    result.Append(row.Substring(index));
                    enum_count++;
                }
                else{
                    result.Append(row);
                }
                result.Append("\r\n");
            }
            MainTextBox.Text = result.ToString();
        }
    }
}
