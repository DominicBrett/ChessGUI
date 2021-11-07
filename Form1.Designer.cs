
namespace ChessGUI
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_enemyTurn = new System.Windows.Forms.Label();
            this.lbl_playerTurn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(6, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 500);
            this.panel1.TabIndex = 2;
            // 
            // lbl_enemyTurn
            // 
            this.lbl_enemyTurn.AutoSize = true;
            this.lbl_enemyTurn.Location = new System.Drawing.Point(229, 9);
            this.lbl_enemyTurn.Name = "lbl_enemyTurn";
            this.lbl_enemyTurn.Size = new System.Drawing.Size(0, 15);
            this.lbl_enemyTurn.TabIndex = 3;
            this.lbl_enemyTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_playerTurn
            // 
            this.lbl_playerTurn.AutoSize = true;
            this.lbl_playerTurn.Location = new System.Drawing.Point(245, 535);
            this.lbl_playerTurn.Name = "lbl_playerTurn";
            this.lbl_playerTurn.Size = new System.Drawing.Size(0, 15);
            this.lbl_playerTurn.TabIndex = 4;
            this.lbl_playerTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 555);
            this.Controls.Add(this.lbl_playerTurn);
            this.Controls.Add(this.lbl_enemyTurn);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Chess Piece Legal Moves";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_enemyTurn;
        private System.Windows.Forms.Label lbl_playerTurn;
    }
}

