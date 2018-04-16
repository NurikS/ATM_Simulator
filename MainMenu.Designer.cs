namespace A3ATM
{
    partial class MainMenu
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
            this.EnterATM = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.BoD = new System.Windows.Forms.Label();
            this.btnDataRace = new System.Windows.Forms.Button();
            this.DataRacelbl = new System.Windows.Forms.Label();
            this.btnDR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnterATM
            // 
            this.EnterATM.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EnterATM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterATM.Location = new System.Drawing.Point(143, 95);
            this.EnterATM.Name = "EnterATM";
            this.EnterATM.Size = new System.Drawing.Size(143, 59);
            this.EnterATM.TabIndex = 0;
            this.EnterATM.Text = "EnterATM";
            this.EnterATM.UseVisualStyleBackColor = false;
            this.EnterATM.Click += new System.EventHandler(this.EnterATM_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(292, 95);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(128, 59);
            this.ExitBtn.TabIndex = 1;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // BoD
            // 
            this.BoD.AutoSize = true;
            this.BoD.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BoD.Location = new System.Drawing.Point(94, 32);
            this.BoD.Name = "BoD";
            this.BoD.Size = new System.Drawing.Size(247, 37);
            this.BoD.TabIndex = 2;
            this.BoD.Text = "BankOfDundee";
            // 
            // btnDataRace
            // 
            this.btnDataRace.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDataRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDataRace.Location = new System.Drawing.Point(12, 95);
            this.btnDataRace.Name = "btnDataRace";
            this.btnDataRace.Size = new System.Drawing.Size(125, 59);
            this.btnDataRace.TabIndex = 3;
            this.btnDataRace.Text = "Toggle DataRace";
            this.btnDataRace.UseVisualStyleBackColor = false;
            this.btnDataRace.Click += new System.EventHandler(this.btnDataRace_Click_1);
            // 
            // DataRacelbl
            // 
            this.DataRacelbl.AutoSize = true;
            this.DataRacelbl.BackColor = System.Drawing.Color.White;
            this.DataRacelbl.Location = new System.Drawing.Point(12, 173);
            this.DataRacelbl.Name = "DataRacelbl";
            this.DataRacelbl.Size = new System.Drawing.Size(93, 13);
            this.DataRacelbl.TabIndex = 4;
            this.DataRacelbl.Text = "DataRace status: ";
            this.DataRacelbl.Click += new System.EventHandler(this.DataRacelbl_Click);
            // 
            // btnDR
            // 
            this.btnDR.BackColor = System.Drawing.Color.Red;
            this.btnDR.Location = new System.Drawing.Point(111, 171);
            this.btnDR.Name = "btnDR";
            this.btnDR.Size = new System.Drawing.Size(16, 16);
            this.btnDR.TabIndex = 5;
            this.btnDR.UseVisualStyleBackColor = false;
            this.btnDR.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(432, 261);
            this.Controls.Add(this.btnDR);
            this.Controls.Add(this.DataRacelbl);
            this.Controls.Add(this.btnDataRace);
            this.Controls.Add(this.BoD);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.EnterATM);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EnterATM;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label BoD;
        private System.Windows.Forms.Button btnDataRace;
        private System.Windows.Forms.Label DataRacelbl;
        private System.Windows.Forms.Button btnDR;
    }
}

