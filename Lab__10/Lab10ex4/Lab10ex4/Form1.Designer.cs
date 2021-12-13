namespace Lab10ex4
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.formatBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.fonColor = new System.Windows.Forms.ToolStripMenuItem();
            this.fontBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileBtn,
            this.formatBtn});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileBtn
            // 
            this.fileBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openBtn});
            this.fileBtn.Name = "fileBtn";
            this.fileBtn.Size = new System.Drawing.Size(48, 20);
            this.fileBtn.Text = "Файл";
            // 
            // formatBtn
            // 
            this.formatBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fonColor,
            this.fontBtn});
            this.formatBtn.Name = "formatBtn";
            this.formatBtn.Size = new System.Drawing.Size(62, 20);
            this.formatBtn.Text = "Формат";
            // 
            // fonColor
            // 
            this.fonColor.Name = "fonColor";
            this.fonColor.Size = new System.Drawing.Size(132, 22);
            this.fonColor.Text = "Цвет фона";
            this.fonColor.Click += new System.EventHandler(this.fonColor_Click);
            // 
            // fontBtn
            // 
            this.fontBtn.Name = "fontBtn";
            this.fontBtn.Size = new System.Drawing.Size(132, 22);
            this.fontBtn.Text = "Шрифт";
            this.fontBtn.Click += new System.EventHandler(this.fontBtn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 426);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // openBtn
            // 
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(180, 22);
            this.openBtn.Text = "Открыть";
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileBtn;
        private System.Windows.Forms.ToolStripMenuItem formatBtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem fonColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem fontBtn;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem openBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

