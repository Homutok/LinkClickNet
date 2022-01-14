
namespace LinkClickNet
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
            this.link_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.Setting_button = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // link_button
            // 
            this.link_button.Location = new System.Drawing.Point(45, 12);
            this.link_button.Name = "link_button";
            this.link_button.Size = new System.Drawing.Size(181, 88);
            this.link_button.TabIndex = 0;
            this.link_button.Text = "Перейти по ссылке";
            this.link_button.UseVisualStyleBackColor = true;
            this.link_button.Click += new System.EventHandler(this.Link_button_Click);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(45, 106);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(181, 50);
            this.save_button.TabIndex = 1;
            this.save_button.Text = "Сохранить ссылку";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(45, 292);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(181, 47);
            this.exit.TabIndex = 2;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Setting_button
            // 
            this.Setting_button.Location = new System.Drawing.Point(45, 182);
            this.Setting_button.Name = "Setting_button";
            this.Setting_button.Size = new System.Drawing.Size(181, 43);
            this.Setting_button.TabIndex = 3;
            this.Setting_button.Text = "Настройка";
            this.Setting_button.UseVisualStyleBackColor = true;
            this.Setting_button.Click += new System.EventHandler(this.Setting_button_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(45, 231);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(181, 46);
            this.update.TabIndex = 4;
            this.update.Text = "Проверить на наличие обновлений";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 351);
            this.Controls.Add(this.update);
            this.Controls.Add(this.Setting_button);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.link_button);
            this.Name = "Form1";
            this.Text = "LinkClickNet";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button link_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button Setting_button;
        private System.Windows.Forms.Button update;
    }
}

