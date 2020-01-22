namespace HearthstoneDIY
{
    partial class FormStart
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
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.buttonDeckEditor = new System.Windows.Forms.Button();
            this.buttonCardDIY = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Location = new System.Drawing.Point(413, 128);
            this.buttonStartGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(205, 48);
            this.buttonStartGame.TabIndex = 0;
            this.buttonStartGame.Text = "StartGame";
            this.buttonStartGame.UseVisualStyleBackColor = true;
            this.buttonStartGame.Click += new System.EventHandler(this.buttonStartGame_Click);
            // 
            // buttonDeckEditor
            // 
            this.buttonDeckEditor.Location = new System.Drawing.Point(413, 182);
            this.buttonDeckEditor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDeckEditor.Name = "buttonDeckEditor";
            this.buttonDeckEditor.Size = new System.Drawing.Size(205, 48);
            this.buttonDeckEditor.TabIndex = 1;
            this.buttonDeckEditor.Text = "DeckEditor";
            this.buttonDeckEditor.UseVisualStyleBackColor = true;
            // 
            // buttonCardDIY
            // 
            this.buttonCardDIY.Location = new System.Drawing.Point(413, 238);
            this.buttonCardDIY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCardDIY.Name = "buttonCardDIY";
            this.buttonCardDIY.Size = new System.Drawing.Size(205, 48);
            this.buttonCardDIY.TabIndex = 2;
            this.buttonCardDIY.Text = "CardDIY";
            this.buttonCardDIY.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 339);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(645, 168);
            this.button1.TabIndex = 3;
            this.button1.Text = "test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCardDIY);
            this.Controls.Add(this.buttonDeckEditor);
            this.Controls.Add(this.buttonStartGame);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormStart";
            this.Text = "StartMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStartGame;
        private System.Windows.Forms.Button buttonDeckEditor;
        private System.Windows.Forms.Button buttonCardDIY;
        private System.Windows.Forms.Button button1;
    }
}

