
namespace LinkClickNetDev
{
    partial class LinkClickNetDev
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
            this.upload_update = new System.Windows.Forms.Button();
            this.version_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Выход = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // upload_update
            // 
            this.upload_update.Location = new System.Drawing.Point(74, 57);
            this.upload_update.Name = "upload_update";
            this.upload_update.Size = new System.Drawing.Size(216, 72);
            this.upload_update.TabIndex = 1;
            this.upload_update.Text = "Выгрузить обновление";
            this.upload_update.UseVisualStyleBackColor = true;
            this.upload_update.Click += new System.EventHandler(this.upload_update_Click);
            // 
            // version_box
            // 
            this.version_box.Location = new System.Drawing.Point(74, 31);
            this.version_box.Name = "version_box";
            this.version_box.Size = new System.Drawing.Size(216, 20);
            this.version_box.TabIndex = 2;
            this.version_box.TextChanged += new System.EventHandler(this.version_box_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите версию приложения:";
            // 
            // Выход
            // 
            this.Выход.Location = new System.Drawing.Point(74, 163);
            this.Выход.Name = "Выход";
            this.Выход.Size = new System.Drawing.Size(216, 53);
            this.Выход.TabIndex = 4;
            this.Выход.Text = "Выход";
            this.Выход.UseVisualStyleBackColor = true;
            this.Выход.Click += new System.EventHandler(this.Выход_Click);
            // 
            // LinkClickNetDev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 268);
            this.Controls.Add(this.Выход);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.version_box);
            this.Controls.Add(this.upload_update);
            this.Name = "LinkClickNetDev";
            this.Text = "LinkClickNetDev";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button upload_update;
        private System.Windows.Forms.TextBox version_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Выход;
    }
}

