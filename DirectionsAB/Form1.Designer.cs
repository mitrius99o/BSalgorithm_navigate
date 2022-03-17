using System.Windows.Forms;

namespace DirectionsAB
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.point_name = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.map = new System.Windows.Forms.PictureBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.stage7 = new System.Windows.Forms.TabPage();
            this.stage1 = new System.Windows.Forms.TabPage();
            this.stage2 = new System.Windows.Forms.TabPage();
            this.stage3 = new System.Windows.Forms.TabPage();
            this.stage4 = new System.Windows.Forms.TabPage();
            this.stage5 = new System.Windows.Forms.TabPage();
            this.stage6 = new System.Windows.Forms.TabPage();
            this.stage8 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.map)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.stage7.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tabControl1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1022, 40);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(341, 609);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(333, 592);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(325, 566);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Навигатор";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(6, 389);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(208, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Сбросить маршрут";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "ауд.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "ауд.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Построить маршрут";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(74, 163);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(101, 22);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(101, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Куда";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Откуда";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.point_name);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(325, 566);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Об аудитории";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(86, 296);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Точка";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(86, 259);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 13);
            this.label16.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(86, 225);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 13);
            this.label15.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 296);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Тип:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 259);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Y:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 225);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "X:";
            // 
            // point_name
            // 
            this.point_name.AutoSize = true;
            this.point_name.Location = new System.Drawing.Point(86, 183);
            this.point_name.Name = "point_name";
            this.point_name.Size = new System.Drawing.Size(0, 13);
            this.point_name.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(197, 26);
            this.label11.TabIndex = 0;
            this.label11.Text = "Кликните 2 раза по аудитории, чтобы\r\nознакомиться с информацией о ней.";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.listBox1);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(325, 566);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Разработка";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(19, 394);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(270, 41);
            this.button5.TabIndex = 7;
            this.button5.Text = "Изменить данные области";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(19, 252);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(270, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Обновить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(19, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(270, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "Связать две области";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(189, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Области, подключенные к системе:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(4, 111);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(307, 134);
            this.listBox1.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(88, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "в систему приложения.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(88, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "чтобы добавить аудиторию";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(88, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "область двумя кликами,";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Выделите прямоугольную";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 0;
            // 
            // map
            // 
            this.map.Image = global::DirectionsAB.Properties.Resources.seventhfloor_land;
            this.map.Location = new System.Drawing.Point(6, 140);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(989, 226);
            this.map.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.map.TabIndex = 0;
            this.map.TabStop = false;
            this.map.MouseClick += new System.Windows.Forms.MouseEventHandler(this.map_MouseClick);
            this.map.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.map_MouseDoubleClick);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.stage1);
            this.tabControl2.Controls.Add(this.stage2);
            this.tabControl2.Controls.Add(this.stage3);
            this.tabControl2.Controls.Add(this.stage4);
            this.tabControl2.Controls.Add(this.stage5);
            this.tabControl2.Controls.Add(this.stage6);
            this.tabControl2.Controls.Add(this.stage7);
            this.tabControl2.Controls.Add(this.stage8);
            this.tabControl2.Location = new System.Drawing.Point(12, 40);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1004, 610);
            this.tabControl2.TabIndex = 2;
            // 
            // stage7
            // 
            this.stage7.Controls.Add(this.map);
            this.stage7.Location = new System.Drawing.Point(4, 22);
            this.stage7.Name = "stage7";
            this.stage7.Padding = new System.Windows.Forms.Padding(3);
            this.stage7.Size = new System.Drawing.Size(996, 584);
            this.stage7.TabIndex = 0;
            this.stage7.Text = "7 Этаж";
            this.stage7.UseVisualStyleBackColor = true;
            // 
            // stage1
            // 
            this.stage1.Location = new System.Drawing.Point(4, 22);
            this.stage1.Name = "stage1";
            this.stage1.Padding = new System.Windows.Forms.Padding(3);
            this.stage1.Size = new System.Drawing.Size(996, 584);
            this.stage1.TabIndex = 1;
            this.stage1.Text = "1 Этаж";
            this.stage1.UseVisualStyleBackColor = true;
            // 
            // stage2
            // 
            this.stage2.Location = new System.Drawing.Point(4, 22);
            this.stage2.Name = "stage2";
            this.stage2.Padding = new System.Windows.Forms.Padding(3);
            this.stage2.Size = new System.Drawing.Size(996, 584);
            this.stage2.TabIndex = 2;
            this.stage2.Text = "2 Этаж";
            this.stage2.UseVisualStyleBackColor = true;
            // 
            // stage3
            // 
            this.stage3.Location = new System.Drawing.Point(4, 22);
            this.stage3.Name = "stage3";
            this.stage3.Size = new System.Drawing.Size(996, 584);
            this.stage3.TabIndex = 3;
            this.stage3.Text = "3 Этаж";
            this.stage3.UseVisualStyleBackColor = true;
            // 
            // stage4
            // 
            this.stage4.Location = new System.Drawing.Point(4, 22);
            this.stage4.Name = "stage4";
            this.stage4.Size = new System.Drawing.Size(996, 584);
            this.stage4.TabIndex = 4;
            this.stage4.Text = "4 Этаж";
            this.stage4.UseVisualStyleBackColor = true;
            // 
            // stage5
            // 
            this.stage5.Location = new System.Drawing.Point(4, 22);
            this.stage5.Name = "stage5";
            this.stage5.Size = new System.Drawing.Size(996, 584);
            this.stage5.TabIndex = 5;
            this.stage5.Text = "5 Этаж";
            this.stage5.UseVisualStyleBackColor = true;
            // 
            // stage6
            // 
            this.stage6.Location = new System.Drawing.Point(4, 22);
            this.stage6.Name = "stage6";
            this.stage6.Size = new System.Drawing.Size(996, 584);
            this.stage6.TabIndex = 6;
            this.stage6.Text = "6 Этаж";
            this.stage6.UseVisualStyleBackColor = true;
            // 
            // stage8
            // 
            this.stage8.Location = new System.Drawing.Point(4, 22);
            this.stage8.Name = "stage8";
            this.stage8.Size = new System.Drawing.Size(996, 584);
            this.stage8.TabIndex = 7;
            this.stage8.Text = "8 Этаж";
            this.stage8.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 728);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "BSMaps-v0.4";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.map)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.stage7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label point_name;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        public PictureBox map;
        private TabControl tabControl2;
        private TabPage stage7;
        private TabPage stage1;
        private Button button5;
        private TabPage stage2;
        private TabPage stage3;
        private TabPage stage4;
        private TabPage stage5;
        private TabPage stage6;
        private TabPage stage8;
    }
}