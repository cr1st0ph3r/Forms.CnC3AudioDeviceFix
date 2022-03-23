namespace Cnc3Launcher
{
    partial class MainForm
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
            this.btnLaunchGame = new System.Windows.Forms.Button();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.btnLaunchExpansion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLaunchGame
            // 
            this.btnLaunchGame.Location = new System.Drawing.Point(9, 9);
            this.btnLaunchGame.Name = "btnLaunchGame";
            this.btnLaunchGame.Size = new System.Drawing.Size(328, 45);
            this.btnLaunchGame.TabIndex = 0;
            this.btnLaunchGame.Text = "Launch CNC3";
            this.btnLaunchGame.UseVisualStyleBackColor = true;
            this.btnLaunchGame.Click += new System.EventHandler(this.btnLaunchGame_Click);
            // 
            // lbLog
            // 
            this.lbLog.FormattingEnabled = true;
            this.lbLog.ItemHeight = 15;
            this.lbLog.Location = new System.Drawing.Point(9, 60);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(662, 154);
            this.lbLog.TabIndex = 1;
            // 
            // btnLaunchExpansion
            // 
            this.btnLaunchExpansion.Location = new System.Drawing.Point(343, 9);
            this.btnLaunchExpansion.Name = "btnLaunchExpansion";
            this.btnLaunchExpansion.Size = new System.Drawing.Size(328, 45);
            this.btnLaunchExpansion.TabIndex = 0;
            this.btnLaunchExpansion.Text = "Launch CNC3KW";
            this.btnLaunchExpansion.UseVisualStyleBackColor = true;
            this.btnLaunchExpansion.Click += new System.EventHandler(this.btnLaunchExpansion_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 225);
            this.Controls.Add(this.lbLog);
            this.Controls.Add(this.btnLaunchExpansion);
            this.Controls.Add(this.btnLaunchGame);
            this.Name = "MainForm";
            this.Text = "Command and Conquer 3 Game Launcher";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnLaunchGame;
        private ListBox lbLog;
        private Button btnLaunchExpansion;
    }
}