namespace Magnit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMaxL = new System.Windows.Forms.Label();
            this.txtbRadius = new System.Windows.Forms.TextBox();
            this.txtbN = new System.Windows.Forms.TextBox();
            this.txtbMaxL = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblOne = new System.Windows.Forms.Label();
            this.lblKoef = new System.Windows.Forms.Label();
            this.lblPackets = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Радиус магнитопровода";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Количество пакетов на половину сечения";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblMaxL
            // 
            this.lblMaxL.AutoSize = true;
            this.lblMaxL.Location = new System.Drawing.Point(50, 105);
            this.lblMaxL.Name = "lblMaxL";
            this.lblMaxL.Size = new System.Drawing.Size(226, 17);
            this.lblMaxL.TabIndex = 2;
            this.lblMaxL.Text = "Максимальная толщина сечения";
            this.lblMaxL.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtbRadius
            // 
            this.txtbRadius.Location = new System.Drawing.Point(359, 35);
            this.txtbRadius.Name = "txtbRadius";
            this.txtbRadius.Size = new System.Drawing.Size(100, 22);
            this.txtbRadius.TabIndex = 4;
            // 
            // txtbN
            // 
            this.txtbN.Location = new System.Drawing.Point(359, 67);
            this.txtbN.Name = "txtbN";
            this.txtbN.Size = new System.Drawing.Size(100, 22);
            this.txtbN.TabIndex = 5;
            // 
            // txtbMaxL
            // 
            this.txtbMaxL.Location = new System.Drawing.Point(359, 105);
            this.txtbMaxL.Name = "txtbMaxL";
            this.txtbMaxL.Size = new System.Drawing.Size(100, 22);
            this.txtbMaxL.TabIndex = 6;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(534, 39);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(346, 79);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Рассчитать";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblOne
            // 
            this.lblOne.AutoSize = true;
            this.lblOne.Location = new System.Drawing.Point(50, 163);
            this.lblOne.Name = "lblOne";
            this.lblOne.Size = new System.Drawing.Size(46, 17);
            this.lblOne.TabIndex = 9;
            this.lblOne.Text = "label4";
            this.lblOne.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblKoef
            // 
            this.lblKoef.AutoSize = true;
            this.lblKoef.Location = new System.Drawing.Point(50, 191);
            this.lblKoef.Name = "lblKoef";
            this.lblKoef.Size = new System.Drawing.Size(46, 17);
            this.lblKoef.TabIndex = 10;
            this.lblKoef.Text = "label5";
            // 
            // lblPackets
            // 
            this.lblPackets.AutoSize = true;
            this.lblPackets.Location = new System.Drawing.Point(53, 221);
            this.lblPackets.Name = "lblPackets";
            this.lblPackets.Size = new System.Drawing.Size(0, 17);
            this.lblPackets.TabIndex = 11;
            this.lblPackets.Click += new System.EventHandler(this.lblPackets_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 545);
            this.Controls.Add(this.lblPackets);
            this.Controls.Add(this.lblKoef);
            this.Controls.Add(this.lblOne);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtbMaxL);
            this.Controls.Add(this.txtbN);
            this.Controls.Add(this.txtbRadius);
            this.Controls.Add(this.lblMaxL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Magnitoprovod";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMaxL;
        private System.Windows.Forms.TextBox txtbRadius;
        private System.Windows.Forms.TextBox txtbN;
        private System.Windows.Forms.TextBox txtbMaxL;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblOne;
        private System.Windows.Forms.Label lblKoef;
        private System.Windows.Forms.Label lblPackets;
    }
}

