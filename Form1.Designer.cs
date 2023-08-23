using System;

namespace LR4_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Pict = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.типКистиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сплошнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.штриховаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.штрихпунктирнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.штрихпунктирнаяС2ТочкамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.Treug = new System.Windows.Forms.RadioButton();
            this.priam = new System.Windows.Forms.RadioButton();
            this.chet = new System.Windows.Forms.RadioButton();
            this.piat = new System.Windows.Forms.RadioButton();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown8 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown9 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown10 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown11 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pict
            // 
            this.Pict.AccumBits = ((byte)(0));
            this.Pict.AutoCheckErrors = false;
            this.Pict.AutoFinish = false;
            this.Pict.AutoMakeCurrent = true;
            this.Pict.AutoSwapBuffers = true;
            this.Pict.BackColor = System.Drawing.Color.White;
            this.Pict.ColorBits = ((byte)(32));
            this.Pict.DepthBits = ((byte)(16));
            this.Pict.Location = new System.Drawing.Point(1, 126);
            this.Pict.Name = "Pict";
            this.Pict.Size = new System.Drawing.Size(1818, 613);
            this.Pict.StencilBits = ((byte)(0));
            this.Pict.TabIndex = 0;
            this.Pict.Load += new System.EventHandler(this.simpleOpenGlControl1_Load);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.типКистиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1822, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // типКистиToolStripMenuItem
            // 
            this.типКистиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сплошнаяToolStripMenuItem,
            this.штриховаяToolStripMenuItem,
            this.штрихпунктирнаяToolStripMenuItem,
            this.штрихпунктирнаяС2ТочкамиToolStripMenuItem});
            this.типКистиToolStripMenuItem.Name = "типКистиToolStripMenuItem";
            this.типКистиToolStripMenuItem.Size = new System.Drawing.Size(91, 26);
            this.типКистиToolStripMenuItem.Text = "Тип кисти";
            // 
            // сплошнаяToolStripMenuItem
            // 
            this.сплошнаяToolStripMenuItem.Name = "сплошнаяToolStripMenuItem";
            this.сплошнаяToolStripMenuItem.Size = new System.Drawing.Size(303, 26);
            this.сплошнаяToolStripMenuItem.Text = "Сплошная";
            this.сплошнаяToolStripMenuItem.Click += new System.EventHandler(this.spl_Click);
            // 
            // штриховаяToolStripMenuItem
            // 
            this.штриховаяToolStripMenuItem.Name = "штриховаяToolStripMenuItem";
            this.штриховаяToolStripMenuItem.Size = new System.Drawing.Size(303, 26);
            this.штриховаяToolStripMenuItem.Text = "Штриховая";
            this.штриховаяToolStripMenuItem.Click += new System.EventHandler(this.shtr_Click);
            // 
            // штрихпунктирнаяToolStripMenuItem
            // 
            this.штрихпунктирнаяToolStripMenuItem.Name = "штрихпунктирнаяToolStripMenuItem";
            this.штрихпунктирнаяToolStripMenuItem.Size = new System.Drawing.Size(303, 26);
            this.штрихпунктирнаяToolStripMenuItem.Text = "Штрихпунктирная";
            this.штрихпунктирнаяToolStripMenuItem.Click += new System.EventHandler(this.shtrpunkt_Click);
            // 
            // штрихпунктирнаяС2ТочкамиToolStripMenuItem
            // 
            this.штрихпунктирнаяС2ТочкамиToolStripMenuItem.Name = "штрихпунктирнаяС2ТочкамиToolStripMenuItem";
            this.штрихпунктирнаяС2ТочкамиToolStripMenuItem.Size = new System.Drawing.Size(303, 26);
            this.штрихпунктирнаяС2ТочкамиToolStripMenuItem.Text = "Штрихпунктирная с 2 точками";
            this.штрихпунктирнаяС2ТочкамиToolStripMenuItem.Click += new System.EventHandler(this.shtrpunkt2_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 63);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(82, 22);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(190, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Цвет фона";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(305, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Цвет объекта";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Treug
            // 
            this.Treug.AutoSize = true;
            this.Treug.Location = new System.Drawing.Point(750, 31);
            this.Treug.Name = "Treug";
            this.Treug.Size = new System.Drawing.Size(113, 20);
            this.Treug.TabIndex = 7;
            this.Treug.TabStop = true;
            this.Treug.Text = "Треугольник";
            this.Treug.UseVisualStyleBackColor = true;
            this.Treug.Click += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // priam
            // 
            this.priam.AutoSize = true;
            this.priam.Location = new System.Drawing.Point(798, 57);
            this.priam.Name = "priam";
            this.priam.Size = new System.Drawing.Size(130, 20);
            this.priam.TabIndex = 8;
            this.priam.TabStop = true;
            this.priam.Text = "Прямоугольник";
            this.priam.UseVisualStyleBackColor = true;
            this.priam.Click += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // chet
            // 
            this.chet.AutoSize = true;
            this.chet.Location = new System.Drawing.Point(750, 74);
            this.chet.Name = "chet";
            this.chet.Size = new System.Drawing.Size(143, 20);
            this.chet.TabIndex = 9;
            this.chet.TabStop = true;
            this.chet.Text = "Четырёхугольник";
            this.chet.UseVisualStyleBackColor = true;
            this.chet.Click += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // piat
            // 
            this.piat.AutoSize = true;
            this.piat.Location = new System.Drawing.Point(798, 100);
            this.piat.Name = "piat";
            this.piat.Size = new System.Drawing.Size(120, 20);
            this.piat.TabIndex = 10;
            this.piat.TabStop = true;
            this.piat.Text = "Пятиугольник";
            this.piat.UseVisualStyleBackColor = true;
            this.piat.Click += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(945, 29);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(68, 22);
            this.numericUpDown2.TabIndex = 13;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(945, 63);
            this.numericUpDown3.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(68, 22);
            this.numericUpDown3.TabIndex = 14;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(1019, 29);
            this.numericUpDown4.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(68, 22);
            this.numericUpDown4.TabIndex = 15;
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(1019, 63);
            this.numericUpDown5.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(68, 22);
            this.numericUpDown5.TabIndex = 16;
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(1097, 29);
            this.numericUpDown6.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(68, 22);
            this.numericUpDown6.TabIndex = 17;
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.Location = new System.Drawing.Point(1097, 63);
            this.numericUpDown7.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(68, 22);
            this.numericUpDown7.TabIndex = 18;
            // 
            // numericUpDown8
            // 
            this.numericUpDown8.Location = new System.Drawing.Point(1171, 29);
            this.numericUpDown8.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown8.Name = "numericUpDown8";
            this.numericUpDown8.Size = new System.Drawing.Size(68, 22);
            this.numericUpDown8.TabIndex = 19;
            // 
            // numericUpDown9
            // 
            this.numericUpDown9.Location = new System.Drawing.Point(1171, 63);
            this.numericUpDown9.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown9.Name = "numericUpDown9";
            this.numericUpDown9.Size = new System.Drawing.Size(68, 22);
            this.numericUpDown9.TabIndex = 20;
            // 
            // numericUpDown10
            // 
            this.numericUpDown10.Location = new System.Drawing.Point(1245, 29);
            this.numericUpDown10.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown10.Name = "numericUpDown10";
            this.numericUpDown10.Size = new System.Drawing.Size(68, 22);
            this.numericUpDown10.TabIndex = 21;
            // 
            // numericUpDown11
            // 
            this.numericUpDown11.Location = new System.Drawing.Point(1245, 63);
            this.numericUpDown11.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown11.Name = "numericUpDown11";
            this.numericUpDown11.Size = new System.Drawing.Size(68, 22);
            this.numericUpDown11.TabIndex = 22;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(340, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 35);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(218, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 35);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(623, 63);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 57);
            this.button4.TabIndex = 6;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(623, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1822, 744);
            this.Controls.Add(this.numericUpDown11);
            this.Controls.Add(this.numericUpDown10);
            this.Controls.Add(this.numericUpDown9);
            this.Controls.Add(this.numericUpDown8);
            this.Controls.Add(this.numericUpDown7);
            this.Controls.Add(this.numericUpDown6);
            this.Controls.Add(this.numericUpDown5);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.piat);
            this.Controls.Add(this.chet);
            this.Controls.Add(this.priam);
            this.Controls.Add(this.Treug);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Pict);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl Pict;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem типКистиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сплошнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem штриховаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem штрихпунктирнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem штрихпунктирнаяС2ТочкамиToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RadioButton Treug;
        private System.Windows.Forms.RadioButton priam;
        private System.Windows.Forms.RadioButton chet;
        private System.Windows.Forms.RadioButton piat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.NumericUpDown numericUpDown7;
        private System.Windows.Forms.NumericUpDown numericUpDown8;
        private System.Windows.Forms.NumericUpDown numericUpDown9;
        private System.Windows.Forms.NumericUpDown numericUpDown10;
        private System.Windows.Forms.NumericUpDown numericUpDown11;
    }
}

