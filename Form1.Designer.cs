namespace Enumer
{
    partial class Enumer
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.initIndexLabel = new System.Windows.Forms.Label();
            this.frontTextLabel = new System.Windows.Forms.Label();
            this.MainTextBox = new System.Windows.Forms.TextBox();
            this.initCount = new System.Windows.Forms.NumericUpDown();
            this.runButton = new System.Windows.Forms.Button();
            this.frontText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.initCount)).BeginInit();
            this.SuspendLayout();
            // 
            // initIndexLabel
            // 
            this.initIndexLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.initIndexLabel.AutoSize = true;
            this.initIndexLabel.Location = new System.Drawing.Point(44, 231);
            this.initIndexLabel.Name = "initIndexLabel";
            this.initIndexLabel.Size = new System.Drawing.Size(41, 12);
            this.initIndexLabel.TabIndex = 0;
            this.initIndexLabel.Text = "初期値";
            // 
            // frontTextLabel
            // 
            this.frontTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.frontTextLabel.AutoSize = true;
            this.frontTextLabel.Location = new System.Drawing.Point(10, 204);
            this.frontTextLabel.Name = "frontTextLabel";
            this.frontTextLabel.Size = new System.Drawing.Size(75, 12);
            this.frontTextLabel.TabIndex = 1;
            this.frontTextLabel.Text = "直前の文字列";
            // 
            // MainTextBox
            // 
            this.MainTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTextBox.Location = new System.Drawing.Point(12, 12);
            this.MainTextBox.Multiline = true;
            this.MainTextBox.Name = "MainTextBox";
            this.MainTextBox.Size = new System.Drawing.Size(200, 183);
            this.MainTextBox.TabIndex = 1;
            // 
            // initCount
            // 
            this.initCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.initCount.Location = new System.Drawing.Point(91, 228);
            this.initCount.Name = "initCount";
            this.initCount.Size = new System.Drawing.Size(40, 19);
            this.initCount.TabIndex = 3;
            this.initCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // runButton
            // 
            this.runButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.runButton.Location = new System.Drawing.Point(137, 226);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(75, 23);
            this.runButton.TabIndex = 4;
            this.runButton.Text = "列挙";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // frontText
            // 
            this.frontText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frontText.Location = new System.Drawing.Point(91, 201);
            this.frontText.Name = "frontText";
            this.frontText.Size = new System.Drawing.Size(121, 19);
            this.frontText.TabIndex = 2;
            // 
            // Enumer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 261);
            this.Controls.Add(this.frontText);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.initCount);
            this.Controls.Add(this.MainTextBox);
            this.Controls.Add(this.frontTextLabel);
            this.Controls.Add(this.initIndexLabel);
            this.MinimumSize = new System.Drawing.Size(240, 140);
            this.Name = "Enumer";
            this.Text = "Enumer";
            this.Load += new System.EventHandler(this.Enumer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.initCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label initIndexLabel;
        private System.Windows.Forms.Label frontTextLabel;
        private System.Windows.Forms.TextBox MainTextBox;
        private System.Windows.Forms.NumericUpDown initCount;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.TextBox frontText;
    }
}

