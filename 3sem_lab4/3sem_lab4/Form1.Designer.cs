namespace _3sem_lab4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonReadText = new System.Windows.Forms.Button();
            this.textBoxReadTime = new System.Windows.Forms.TextBox();
            this.labelReadTime = new System.Windows.Forms.Label();
            this.labelSearchWord = new System.Windows.Forms.Label();
            this.textBoxSearchWord = new System.Windows.Forms.TextBox();
            this.buttonSearchWord = new System.Windows.Forms.Button();
            this.labelSearchTime = new System.Windows.Forms.Label();
            this.textBoxSearchTime = new System.Windows.Forms.TextBox();
            this.labelFoundWord = new System.Windows.Forms.Label();
            this.listBoxFoundWords = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(55, 418);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(196, 23);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "Закрыть приложение";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonReadText
            // 
            this.buttonReadText.Location = new System.Drawing.Point(55, 25);
            this.buttonReadText.Name = "buttonReadText";
            this.buttonReadText.Size = new System.Drawing.Size(75, 23);
            this.buttonReadText.TabIndex = 12;
            this.buttonReadText.Text = "Чтение из файла";
            this.buttonReadText.UseVisualStyleBackColor = true;
            this.buttonReadText.Click += new System.EventHandler(this.buttonReadText_Click_1);
            // 
            // textBoxReadTime
            // 
            this.textBoxReadTime.Location = new System.Drawing.Point(282, 27);
            this.textBoxReadTime.Name = "textBoxReadTime";
            this.textBoxReadTime.Size = new System.Drawing.Size(261, 20);
            this.textBoxReadTime.TabIndex = 13;
            // 
            // labelReadTime
            // 
            this.labelReadTime.AutoSize = true;
            this.labelReadTime.Location = new System.Drawing.Point(149, 30);
            this.labelReadTime.Name = "labelReadTime";
            this.labelReadTime.Size = new System.Drawing.Size(127, 13);
            this.labelReadTime.TabIndex = 14;
            this.labelReadTime.Text = "Время чтения из файла";
            // 
            // labelSearchWord
            // 
            this.labelSearchWord.AutoSize = true;
            this.labelSearchWord.Location = new System.Drawing.Point(52, 88);
            this.labelSearchWord.Name = "labelSearchWord";
            this.labelSearchWord.Size = new System.Drawing.Size(98, 13);
            this.labelSearchWord.TabIndex = 15;
            this.labelSearchWord.Text = "Слово для поиска";
            // 
            // textBoxSearchWord
            // 
            this.textBoxSearchWord.Location = new System.Drawing.Point(156, 85);
            this.textBoxSearchWord.Name = "textBoxSearchWord";
            this.textBoxSearchWord.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearchWord.TabIndex = 16;
            // 
            // buttonSearchWord
            // 
            this.buttonSearchWord.Location = new System.Drawing.Point(55, 137);
            this.buttonSearchWord.Name = "buttonSearchWord";
            this.buttonSearchWord.Size = new System.Drawing.Size(120, 23);
            this.buttonSearchWord.TabIndex = 17;
            this.buttonSearchWord.Text = "Искать слово";
            this.buttonSearchWord.UseVisualStyleBackColor = true;
            this.buttonSearchWord.Click += new System.EventHandler(this.buttonSearchWord_Click);
            // 
            // labelSearchTime
            // 
            this.labelSearchTime.AutoSize = true;
            this.labelSearchTime.Location = new System.Drawing.Point(181, 142);
            this.labelSearchTime.Name = "labelSearchTime";
            this.labelSearchTime.Size = new System.Drawing.Size(112, 13);
            this.labelSearchTime.TabIndex = 18;
            this.labelSearchTime.Text = "Время поиска слова";
            // 
            // textBoxSearchTime
            // 
            this.textBoxSearchTime.Location = new System.Drawing.Point(299, 140);
            this.textBoxSearchTime.Name = "textBoxSearchTime";
            this.textBoxSearchTime.Size = new System.Drawing.Size(244, 20);
            this.textBoxSearchTime.TabIndex = 19;
            // 
            // labelFoundWord
            // 
            this.labelFoundWord.AutoSize = true;
            this.labelFoundWord.Location = new System.Drawing.Point(52, 189);
            this.labelFoundWord.Name = "labelFoundWord";
            this.labelFoundWord.Size = new System.Drawing.Size(98, 13);
            this.labelFoundWord.TabIndex = 20;
            this.labelFoundWord.Text = "Найденные слова";
            // 
            // listBoxFoundWords
            // 
            this.listBoxFoundWords.FormattingEnabled = true;
            this.listBoxFoundWords.Location = new System.Drawing.Point(55, 221);
            this.listBoxFoundWords.Name = "listBoxFoundWords";
            this.listBoxFoundWords.Size = new System.Drawing.Size(346, 173);
            this.listBoxFoundWords.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 453);
            this.Controls.Add(this.listBoxFoundWords);
            this.Controls.Add(this.labelFoundWord);
            this.Controls.Add(this.textBoxSearchTime);
            this.Controls.Add(this.labelSearchTime);
            this.Controls.Add(this.buttonSearchWord);
            this.Controls.Add(this.textBoxSearchWord);
            this.Controls.Add(this.labelSearchWord);
            this.Controls.Add(this.labelReadTime);
            this.Controls.Add(this.textBoxReadTime);
            this.Controls.Add(this.buttonReadText);
            this.Controls.Add(this.buttonExit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonReadText;
        private System.Windows.Forms.TextBox textBoxReadTime;
        private System.Windows.Forms.Label labelReadTime;
        private System.Windows.Forms.Label labelSearchWord;
        private System.Windows.Forms.TextBox textBoxSearchWord;
        private System.Windows.Forms.Button buttonSearchWord;
        private System.Windows.Forms.Label labelSearchTime;
        private System.Windows.Forms.TextBox textBoxSearchTime;
        private System.Windows.Forms.Label labelFoundWord;
        private System.Windows.Forms.ListBox listBoxFoundWords;
    }
}

