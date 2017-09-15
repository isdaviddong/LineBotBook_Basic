namespace LinebotFirst
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonSendButtonTemplate = new System.Windows.Forms.Button();
            this.buttonSendConfirmTemplate = new System.Windows.Forms.Button();
            this.buttonSendCarouselTemplate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("PMingLiU", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(71, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 76);
            this.button1.TabIndex = 0;
            this.button1.Text = "發送";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("PMingLiU", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(71, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(390, 76);
            this.button2.TabIndex = 1;
            this.button2.Text = "發送貼圖";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("PMingLiU", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(71, 380);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(390, 76);
            this.button3.TabIndex = 2;
            this.button3.Text = "發送圖片";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonSendButtonTemplate
            // 
            this.buttonSendButtonTemplate.Font = new System.Drawing.Font("PMingLiU", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonSendButtonTemplate.Location = new System.Drawing.Point(653, 66);
            this.buttonSendButtonTemplate.Name = "buttonSendButtonTemplate";
            this.buttonSendButtonTemplate.Size = new System.Drawing.Size(467, 76);
            this.buttonSendButtonTemplate.TabIndex = 3;
            this.buttonSendButtonTemplate.Text = "發送ButtonTemplate";
            this.buttonSendButtonTemplate.UseVisualStyleBackColor = true;
            this.buttonSendButtonTemplate.Click += new System.EventHandler(this.buttonSendButtonTemplate_Click);
            // 
            // buttonSendConfirmTemplate
            // 
            this.buttonSendConfirmTemplate.Font = new System.Drawing.Font("PMingLiU", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonSendConfirmTemplate.Location = new System.Drawing.Point(653, 229);
            this.buttonSendConfirmTemplate.Name = "buttonSendConfirmTemplate";
            this.buttonSendConfirmTemplate.Size = new System.Drawing.Size(467, 76);
            this.buttonSendConfirmTemplate.TabIndex = 4;
            this.buttonSendConfirmTemplate.Text = "發送ConfirmTemplate";
            this.buttonSendConfirmTemplate.UseVisualStyleBackColor = true;
            this.buttonSendConfirmTemplate.Click += new System.EventHandler(this.buttonSendConfirmTemplate_Click);
            // 
            // buttonSendCarouselTemplate
            // 
            this.buttonSendCarouselTemplate.Font = new System.Drawing.Font("PMingLiU", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonSendCarouselTemplate.Location = new System.Drawing.Point(653, 380);
            this.buttonSendCarouselTemplate.Name = "buttonSendCarouselTemplate";
            this.buttonSendCarouselTemplate.Size = new System.Drawing.Size(467, 76);
            this.buttonSendCarouselTemplate.TabIndex = 5;
            this.buttonSendCarouselTemplate.Text = "發送CarouselTemplate";
            this.buttonSendCarouselTemplate.UseVisualStyleBackColor = true;
            this.buttonSendCarouselTemplate.Click += new System.EventHandler(this.buttonSendCarouselTemplate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 651);
            this.Controls.Add(this.buttonSendCarouselTemplate);
            this.Controls.Add(this.buttonSendConfirmTemplate);
            this.Controls.Add(this.buttonSendButtonTemplate);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonSendButtonTemplate;
        private System.Windows.Forms.Button buttonSendConfirmTemplate;
        private System.Windows.Forms.Button buttonSendCarouselTemplate;
    }
}

