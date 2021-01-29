
namespace Program11
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.системаКоординатToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фигураToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дугиИСекторыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.контуркакПутьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.контурнеПутьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прямоугольникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вычислениеПлощадиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.площадьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxS = new System.Windows.Forms.TextBox();
            this.labelS = new System.Windows.Forms.Label();
            this.labelN = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.фигураToolStripMenuItem,
            this.вычислениеПлощадиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(534, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 800);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.системаКоординатToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // системаКоординатToolStripMenuItem
            // 
            this.системаКоординатToolStripMenuItem.Name = "системаКоординатToolStripMenuItem";
            this.системаКоординатToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.системаКоординатToolStripMenuItem.Text = "Система координат";
            this.системаКоординатToolStripMenuItem.Click += new System.EventHandler(this.системаКоординатToolStripMenuItem_Click_1);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click_1);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click_1);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // фигураToolStripMenuItem
            // 
            this.фигураToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.дугиИСекторыToolStripMenuItem,
            this.контуркакПутьToolStripMenuItem,
            this.контурнеПутьToolStripMenuItem,
            this.прямоугольникToolStripMenuItem});
            this.фигураToolStripMenuItem.Name = "фигураToolStripMenuItem";
            this.фигураToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.фигураToolStripMenuItem.Text = "Фигура";
            // 
            // дугиИСекторыToolStripMenuItem
            // 
            this.дугиИСекторыToolStripMenuItem.Name = "дугиИСекторыToolStripMenuItem";
            this.дугиИСекторыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.дугиИСекторыToolStripMenuItem.Text = "Дуги и секторы";
            this.дугиИСекторыToolStripMenuItem.Click += new System.EventHandler(this.дугиИСекторыToolStripMenuItem_Click_1);
            // 
            // контуркакПутьToolStripMenuItem
            // 
            this.контуркакПутьToolStripMenuItem.Name = "контуркакПутьToolStripMenuItem";
            this.контуркакПутьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.контуркакПутьToolStripMenuItem.Text = "Контур (как путь)";
            this.контуркакПутьToolStripMenuItem.Click += new System.EventHandler(this.контуркакПутьToolStripMenuItem_Click_1);
            // 
            // контурнеПутьToolStripMenuItem
            // 
            this.контурнеПутьToolStripMenuItem.Name = "контурнеПутьToolStripMenuItem";
            this.контурнеПутьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.контурнеПутьToolStripMenuItem.Text = "Контур (не  путь)";
            this.контурнеПутьToolStripMenuItem.Click += new System.EventHandler(this.контурнеПутьToolStripMenuItem_Click_1);
            // 
            // прямоугольникToolStripMenuItem
            // 
            this.прямоугольникToolStripMenuItem.Name = "прямоугольникToolStripMenuItem";
            this.прямоугольникToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.прямоугольникToolStripMenuItem.Text = "Прямоугольник";
            this.прямоугольникToolStripMenuItem.Click += new System.EventHandler(this.прямоугольникToolStripMenuItem_Click_1);
            // 
            // вычислениеПлощадиToolStripMenuItem
            // 
            this.вычислениеПлощадиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.площадьToolStripMenuItem});
            this.вычислениеПлощадиToolStripMenuItem.Name = "вычислениеПлощадиToolStripMenuItem";
            this.вычислениеПлощадиToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
            this.вычислениеПлощадиToolStripMenuItem.Text = "Вычисление площади";
            // 
            // площадьToolStripMenuItem
            // 
            this.площадьToolStripMenuItem.Name = "площадьToolStripMenuItem";
            this.площадьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.площадьToolStripMenuItem.Text = "Площадь";
            this.площадьToolStripMenuItem.Click += new System.EventHandler(this.площадьToolStripMenuItem_Click);
            // 
            // textBoxS
            // 
            this.textBoxS.Location = new System.Drawing.Point(412, 28);
            this.textBoxS.Name = "textBoxS";
            this.textBoxS.Size = new System.Drawing.Size(100, 20);
            this.textBoxS.TabIndex = 2;
            this.textBoxS.Visible = false;
            // 
            // labelS
            // 
            this.labelS.AutoSize = true;
            this.labelS.Location = new System.Drawing.Point(380, 31);
            this.labelS.Name = "labelS";
            this.labelS.Size = new System.Drawing.Size(26, 13);
            this.labelS.TabIndex = 3;
            this.labelS.Text = "S = ";
            this.labelS.Visible = false;
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(242, 31);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(27, 13);
            this.labelN.TabIndex = 5;
            this.labelN.Text = "N = ";
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(274, 28);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(100, 20);
            this.textBoxN.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 861);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.labelS);
            this.Controls.Add(this.textBoxS);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem системаКоординатToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фигураToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дугиИСекторыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem контуркакПутьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem контурнеПутьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прямоугольникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вычислениеПлощадиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem площадьToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxS;
        private System.Windows.Forms.Label labelS;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.TextBox textBoxN;
    }
}

