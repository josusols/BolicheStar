namespace BolicheStar
{
    partial class ChuzaTiroExtra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChuzaTiroExtra));
            this.L_tiroExtra = new System.Windows.Forms.Label();
            this.BTN_tirarExtra = new System.Windows.Forms.Button();
            this.TB_tirarExtra = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // L_tiroExtra
            // 
            this.L_tiroExtra.AutoSize = true;
            this.L_tiroExtra.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_tiroExtra.Location = new System.Drawing.Point(19, 9);
            this.L_tiroExtra.Name = "L_tiroExtra";
            this.L_tiroExtra.Size = new System.Drawing.Size(139, 25);
            this.L_tiroExtra.TabIndex = 10;
            this.L_tiroExtra.Text = "Tiro Extra";
            // 
            // BTN_tirarExtra
            // 
            this.BTN_tirarExtra.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_tirarExtra.Enabled = false;
            this.BTN_tirarExtra.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_tirarExtra.Location = new System.Drawing.Point(62, 37);
            this.BTN_tirarExtra.Name = "BTN_tirarExtra";
            this.BTN_tirarExtra.Size = new System.Drawing.Size(75, 23);
            this.BTN_tirarExtra.TabIndex = 8;
            this.BTN_tirarExtra.Text = "¡Tirar!";
            this.BTN_tirarExtra.UseVisualStyleBackColor = false;
            this.BTN_tirarExtra.Click += new System.EventHandler(this.BTN_tirarExtra_Click);
            // 
            // TB_tirarExtra
            // 
            this.TB_tirarExtra.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_tirarExtra.Location = new System.Drawing.Point(34, 36);
            this.TB_tirarExtra.Name = "TB_tirarExtra";
            this.TB_tirarExtra.Size = new System.Drawing.Size(22, 26);
            this.TB_tirarExtra.TabIndex = 11;
            this.TB_tirarExtra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_tirarExtra.TextChanged += new System.EventHandler(this.TB_tirarExtra_TextChanged);
            this.TB_tirarExtra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_tirarExtra_KeyPress);
            // 
            // ChuzaTiroExtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(173, 68);
            this.Controls.Add(this.TB_tirarExtra);
            this.Controls.Add(this.L_tiroExtra);
            this.Controls.Add(this.BTN_tirarExtra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChuzaTiroExtra";
            this.Text = "Chuza";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_tiroExtra;
        private System.Windows.Forms.Button BTN_tirarExtra;
        private System.Windows.Forms.TextBox TB_tirarExtra;

    }
}