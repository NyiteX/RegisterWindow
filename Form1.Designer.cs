namespace WindowsFormsApp3
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
            this.Button_close = new System.Windows.Forms.Label();
            this.Name_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Pass_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Registr = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button_VXOD = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Prof = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button_close
            // 
            this.Button_close.AutoSize = true;
            this.Button_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_close.Location = new System.Drawing.Point(386, 9);
            this.Button_close.Name = "Button_close";
            this.Button_close.Size = new System.Drawing.Size(20, 24);
            this.Button_close.TabIndex = 0;
            this.Button_close.Text = "x";
            this.Button_close.Click += new System.EventHandler(this.Button_close_Click);
            // 
            // Name_TextBox
            // 
            this.Name_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_TextBox.Location = new System.Drawing.Point(114, 93);
            this.Name_TextBox.Name = "Name_TextBox";
            this.Name_TextBox.Size = new System.Drawing.Size(223, 26);
            this.Name_TextBox.TabIndex = 1;
            this.Name_TextBox.TextChanged += new System.EventHandler(this.Name_TextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.SeaShell;
            this.label1.Location = new System.Drawing.Point(51, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Pass_TextBox
            // 
            this.Pass_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pass_TextBox.Location = new System.Drawing.Point(114, 141);
            this.Pass_TextBox.Name = "Pass_TextBox";
            this.Pass_TextBox.Size = new System.Drawing.Size(223, 26);
            this.Pass_TextBox.TabIndex = 6;
            this.Pass_TextBox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.SeaShell;
            this.label2.Location = new System.Drawing.Point(40, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль:";
            // 
            // button_Registr
            // 
            this.button_Registr.Location = new System.Drawing.Point(167, 212);
            this.button_Registr.Name = "button_Registr";
            this.button_Registr.Size = new System.Drawing.Size(90, 42);
            this.button_Registr.TabIndex = 5;
            this.button_Registr.Text = "Регистрация";
            this.button_Registr.UseVisualStyleBackColor = true;
            this.button_Registr.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.PowderBlue;
            this.label3.Location = new System.Drawing.Point(134, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "У меня уже есть аккаунт";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button_VXOD
            // 
            this.button_VXOD.Location = new System.Drawing.Point(167, 212);
            this.button_VXOD.Name = "button_VXOD";
            this.button_VXOD.Size = new System.Drawing.Size(90, 42);
            this.button_VXOD.TabIndex = 7;
            this.button_VXOD.Text = "Вход";
            this.button_VXOD.UseVisualStyleBackColor = true;
            this.button_VXOD.Click += new System.EventHandler(this.button_VXOD_Click);
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(180, 271);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(62, 29);
            this.button_back.TabIndex = 8;
            this.button_back.Text = "Назад";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(343, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "*";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Программер",
            "Повар",
            "Ололо",
            "АЛО"});
            this.comboBox1.Location = new System.Drawing.Point(114, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Prof
            // 
            this.Prof.AutoSize = true;
            this.Prof.BackColor = System.Drawing.Color.Transparent;
            this.Prof.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Prof.ForeColor = System.Drawing.Color.SeaShell;
            this.Prof.Location = new System.Drawing.Point(12, 61);
            this.Prof.Name = "Prof";
            this.Prof.Size = new System.Drawing.Size(97, 17);
            this.Prof.TabIndex = 11;
            this.Prof.Text = "Профессия:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(428, 398);
            this.Controls.Add(this.Prof);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_VXOD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_Registr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pass_TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Name_TextBox);
            this.Controls.Add(this.Button_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base_Window";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Button_close;
        private System.Windows.Forms.TextBox Name_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Pass_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Registr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_VXOD;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Prof;
    }
}

