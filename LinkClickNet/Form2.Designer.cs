
namespace LinkClickNet
{
    partial class Setting_Form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.edge = new System.Windows.Forms.RadioButton();
            this.explorer = new System.Windows.Forms.RadioButton();
            this.opera = new System.Windows.Forms.RadioButton();
            this.chrome = new System.Windows.Forms.RadioButton();
            this.yandex = new System.Windows.Forms.RadioButton();
            this.mozilla = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioDefault = new System.Windows.Forms.RadioButton();
            this.incognito = new System.Windows.Forms.RadioButton();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.browserDefault = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.browserDefault);
            this.groupBox1.Controls.Add(this.edge);
            this.groupBox1.Controls.Add(this.explorer);
            this.groupBox1.Controls.Add(this.opera);
            this.groupBox1.Controls.Add(this.chrome);
            this.groupBox1.Controls.Add(this.yandex);
            this.groupBox1.Controls.Add(this.mozilla);
            this.groupBox1.Location = new System.Drawing.Point(16, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 83);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите браузер по умолчанию";
            // 
            // edge
            // 
            this.edge.AutoSize = true;
            this.edge.Location = new System.Drawing.Point(244, 42);
            this.edge.Name = "edge";
            this.edge.Size = new System.Drawing.Size(96, 17);
            this.edge.TabIndex = 20;
            this.edge.TabStop = true;
            this.edge.Text = "Microsoft Edge";
            this.edge.UseVisualStyleBackColor = true;
            this.edge.CheckedChanged += new System.EventHandler(this.edge_CheckedChanged);
            // 
            // explorer
            // 
            this.explorer.AutoSize = true;
            this.explorer.Location = new System.Drawing.Point(121, 19);
            this.explorer.Name = "explorer";
            this.explorer.Size = new System.Drawing.Size(102, 17);
            this.explorer.TabIndex = 16;
            this.explorer.TabStop = true;
            this.explorer.Text = "Internet Explorer";
            this.explorer.UseVisualStyleBackColor = true;
            this.explorer.CheckedChanged += new System.EventHandler(this.explorer_CheckedChanged);
            // 
            // opera
            // 
            this.opera.AutoSize = true;
            this.opera.Location = new System.Drawing.Point(244, 19);
            this.opera.Name = "opera";
            this.opera.Size = new System.Drawing.Size(54, 17);
            this.opera.TabIndex = 18;
            this.opera.TabStop = true;
            this.opera.Text = "Opera";
            this.opera.UseVisualStyleBackColor = true;
            this.opera.CheckedChanged += new System.EventHandler(this.opera_CheckedChanged);
            // 
            // chrome
            // 
            this.chrome.AutoSize = true;
            this.chrome.Location = new System.Drawing.Point(5, 19);
            this.chrome.Name = "chrome";
            this.chrome.Size = new System.Drawing.Size(98, 17);
            this.chrome.TabIndex = 14;
            this.chrome.TabStop = true;
            this.chrome.Text = "Google Chrome";
            this.chrome.UseVisualStyleBackColor = true;
            this.chrome.CheckedChanged += new System.EventHandler(this.chrome_CheckedChanged);
            // 
            // yandex
            // 
            this.yandex.AutoSize = true;
            this.yandex.Location = new System.Drawing.Point(121, 42);
            this.yandex.Name = "yandex";
            this.yandex.Size = new System.Drawing.Size(61, 17);
            this.yandex.TabIndex = 17;
            this.yandex.TabStop = true;
            this.yandex.Text = "Yandex";
            this.yandex.UseVisualStyleBackColor = true;
            this.yandex.CheckedChanged += new System.EventHandler(this.yandex_CheckedChanged);
            // 
            // mozilla
            // 
            this.mozilla.AutoSize = true;
            this.mozilla.Location = new System.Drawing.Point(5, 42);
            this.mozilla.Name = "mozilla";
            this.mozilla.Size = new System.Drawing.Size(57, 17);
            this.mozilla.TabIndex = 15;
            this.mozilla.TabStop = true;
            this.mozilla.Text = "Mozilla";
            this.mozilla.UseVisualStyleBackColor = true;
            this.mozilla.CheckedChanged += new System.EventHandler(this.mozila_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioDefault);
            this.groupBox2.Controls.Add(this.incognito);
            this.groupBox2.Location = new System.Drawing.Point(16, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 72);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "В каком режиме открывать браузер";
            // 
            // radioDefault
            // 
            this.radioDefault.AutoSize = true;
            this.radioDefault.Location = new System.Drawing.Point(6, 42);
            this.radioDefault.Name = "radioDefault";
            this.radioDefault.Size = new System.Drawing.Size(123, 17);
            this.radioDefault.TabIndex = 1;
            this.radioDefault.TabStop = true;
            this.radioDefault.Text = "В обычном режиме";
            this.radioDefault.UseVisualStyleBackColor = true;
            this.radioDefault.CheckedChanged += new System.EventHandler(this.radioDefault_CheckedChanged);
            // 
            // incognito
            // 
            this.incognito.AutoSize = true;
            this.incognito.Location = new System.Drawing.Point(6, 19);
            this.incognito.Name = "incognito";
            this.incognito.Size = new System.Drawing.Size(130, 17);
            this.incognito.TabIndex = 0;
            this.incognito.TabStop = true;
            this.incognito.Text = "В режиме инкогнито";
            this.incognito.UseVisualStyleBackColor = true;
            this.incognito.CheckedChanged += new System.EventHandler(this.incognito_CheckedChanged);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(16, 232);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(129, 23);
            this.save.TabIndex = 4;
            this.save.Text = "Сохранить настройки";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(170, 232);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(144, 23);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "Закрыть без изменений";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // browserDefault
            // 
            this.browserDefault.AutoSize = true;
            this.browserDefault.Location = new System.Drawing.Point(5, 62);
            this.browserDefault.Name = "browserDefault";
            this.browserDefault.Size = new System.Drawing.Size(141, 17);
            this.browserDefault.TabIndex = 21;
            this.browserDefault.TabStop = true;
            this.browserDefault.Text = "Браузер по умолчанию";
            this.browserDefault.UseVisualStyleBackColor = true;
            this.browserDefault.CheckedChanged += new System.EventHandler(this.browserDefault_CheckedChanged);
            // 
            // Setting_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 278);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Setting_Form";
            this.Text = "Setting";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton edge;
        private System.Windows.Forms.RadioButton explorer;
        private System.Windows.Forms.RadioButton opera;
        private System.Windows.Forms.RadioButton chrome;
        private System.Windows.Forms.RadioButton yandex;
        private System.Windows.Forms.RadioButton mozilla;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioDefault;
        private System.Windows.Forms.RadioButton incognito;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.RadioButton browserDefault;
    }
}