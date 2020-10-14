namespace WindowsFormsApp1
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
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.CheckedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.SteelBlue;
            this.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button2.Location = new System.Drawing.Point(164, 161);
            this.Button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(215, 36);
            this.Button2.TabIndex = 13;
            this.Button2.Text = "Вход администратора";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.SteelBlue;
            this.Button1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button1.ForeColor = System.Drawing.SystemColors.Control;
            this.Button1.Location = new System.Drawing.Point(216, 262);
            this.Button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(102, 36);
            this.Button1.TabIndex = 12;
            this.Button1.Text = "Выход";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox1.Location = new System.Drawing.Point(308, 105);
            this.TextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(179, 25);
            this.TextBox1.TabIndex = 11;
            this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // CheckedListBox1
            // 
            this.CheckedListBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckedListBox1.FormattingEnabled = true;
            this.CheckedListBox1.Items.AddRange(new object[] {
            "Администратор",
            "Менеджер "});
            this.CheckedListBox1.Location = new System.Drawing.Point(308, 64);
            this.CheckedListBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CheckedListBox1.Name = "CheckedListBox1";
            this.CheckedListBox1.Size = new System.Drawing.Size(179, 24);
            this.CheckedListBox1.TabIndex = 10;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label2.Location = new System.Drawing.Point(229, 106);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(76, 22);
            this.Label2.TabIndex = 8;
            this.Label2.Text = "Пароль";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label1.Location = new System.Drawing.Point(134, 64);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(171, 22);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Имя пользователя";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.InitialImage = global::WindowsFormsApp1.Properties.Resources.logo;
            this.PictureBox1.Location = new System.Drawing.Point(9, 10);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(121, 71);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 9;
            this.PictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SteelBlue;
            this.button3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(164, 211);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(215, 36);
            this.button3.TabIndex = 14;
            this.button3.Text = "Вход менеджер";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(249, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 32);
            this.label3.TabIndex = 15;
            this.label3.Text = "Авторизация";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 309);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.CheckedListBox1);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Authorization";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.CheckedListBox CheckedListBox1;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
    }
}

