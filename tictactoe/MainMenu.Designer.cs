namespace tictactoe
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pvp = new System.Windows.Forms.Button();
            this.pvai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pvp
            // 
            this.pvp.Location = new System.Drawing.Point(183, 221);
            this.pvp.Name = "pvp";
            this.pvp.Size = new System.Drawing.Size(94, 35);
            this.pvp.TabIndex = 0;
            this.pvp.Text = "vs Player";
            this.pvp.UseVisualStyleBackColor = true;
            this.pvp.Click += new System.EventHandler(this.pvp_Click);
            // 
            // pvai
            // 
            this.pvai.Location = new System.Drawing.Point(482, 223);
            this.pvai.Name = "pvai";
            this.pvai.Size = new System.Drawing.Size(74, 33);
            this.pvai.TabIndex = 1;
            this.pvai.Text = "vs AI";
            this.pvai.UseVisualStyleBackColor = true;
            this.pvai.Click += new System.EventHandler(this.btn_pvai_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pvai);
            this.Controls.Add(this.pvp);
            this.Name = "MainMenu";
            this.Text = "Nine-Dash-Grid";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button pvp;
        private Button pvai;
    }
}