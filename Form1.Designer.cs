﻿namespace GRBL_CTRL
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.conBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.leftBtn = new System.Windows.Forms.Button();
            this.upBtn = new System.Windows.Forms.Button();
            this.rightBtn = new System.Windows.Forms.Button();
            this.downBtn = new System.Windows.Forms.Button();
            this.penBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(434, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(452, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Отправить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 97);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(434, 266);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // conBtn
            // 
            this.conBtn.BackColor = System.Drawing.Color.Lime;
            this.conBtn.Location = new System.Drawing.Point(139, 13);
            this.conBtn.Name = "conBtn";
            this.conBtn.Size = new System.Drawing.Size(75, 23);
            this.conBtn.TabIndex = 4;
            this.conBtn.Text = "Connect";
            this.conBtn.UseVisualStyleBackColor = false;
            this.conBtn.Click += new System.EventHandler(this.conBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(220, 13);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshBtn.TabIndex = 5;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // leftBtn
            // 
            this.leftBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftBtn.Location = new System.Drawing.Point(464, 213);
            this.leftBtn.Name = "leftBtn";
            this.leftBtn.Size = new System.Drawing.Size(70, 70);
            this.leftBtn.TabIndex = 6;
            this.leftBtn.Text = "left";
            this.leftBtn.UseVisualStyleBackColor = true;
            // 
            // upBtn
            // 
            this.upBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.upBtn.Location = new System.Drawing.Point(540, 137);
            this.upBtn.Name = "upBtn";
            this.upBtn.Size = new System.Drawing.Size(70, 70);
            this.upBtn.TabIndex = 7;
            this.upBtn.Text = "up";
            this.upBtn.UseVisualStyleBackColor = true;
            // 
            // rightBtn
            // 
            this.rightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightBtn.Location = new System.Drawing.Point(616, 213);
            this.rightBtn.Name = "rightBtn";
            this.rightBtn.Size = new System.Drawing.Size(70, 70);
            this.rightBtn.TabIndex = 8;
            this.rightBtn.Text = "right";
            this.rightBtn.UseVisualStyleBackColor = true;
            // 
            // downBtn
            // 
            this.downBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.downBtn.Location = new System.Drawing.Point(540, 289);
            this.downBtn.Name = "downBtn";
            this.downBtn.Size = new System.Drawing.Size(70, 70);
            this.downBtn.TabIndex = 9;
            this.downBtn.Text = "down";
            this.downBtn.UseVisualStyleBackColor = true;
            // 
            // penBtn
            // 
            this.penBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.penBtn.Location = new System.Drawing.Point(540, 213);
            this.penBtn.Name = "penBtn";
            this.penBtn.Size = new System.Drawing.Size(70, 70);
            this.penBtn.TabIndex = 10;
            this.penBtn.Text = "penup";
            this.penBtn.UseVisualStyleBackColor = true;
            this.penBtn.Click += new System.EventHandler(this.penBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 485);
            this.Controls.Add(this.penBtn);
            this.Controls.Add(this.downBtn);
            this.Controls.Add(this.rightBtn);
            this.Controls.Add(this.upBtn);
            this.Controls.Add(this.leftBtn);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.conBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button conBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button leftBtn;
        private System.Windows.Forms.Button upBtn;
        private System.Windows.Forms.Button rightBtn;
        private System.Windows.Forms.Button downBtn;
        private System.Windows.Forms.Button penBtn;
    }
}

