namespace Gra_Statki.Forms
{
    partial class GameSettingsForm
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
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.btnRotate = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.pbPlayerBoard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPlayer.Location = new System.Drawing.Point(523, 72);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(54, 18);
            this.lblPlayer.TabIndex = 0;
            this.lblPlayer.Text = "Gracz";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPlayerName.ForeColor = System.Drawing.Color.Red;
            this.lblPlayerName.Location = new System.Drawing.Point(445, 178);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(201, 13);
            this.lblPlayerName.TabIndex = 1;
            this.lblPlayerName.Text = "Nalezy wprowadzic nazwe gracza.";
            // 
            // btnRotate
            // 
            this.btnRotate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRotate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRotate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRotate.Location = new System.Drawing.Point(485, 250);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(133, 43);
            this.btnRotate.TabIndex = 2;
            this.btnRotate.Text = "Obróć";
            this.btnRotate.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNext.Location = new System.Drawing.Point(485, 300);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(133, 43);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Dalej";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(485, 108);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(133, 20);
            this.txtPlayerName.TabIndex = 4;
            // 
            // pbPlayerBoard
            // 
            this.pbPlayerBoard.Image = global::Gra_Statki.Properties.Resources.board;
            this.pbPlayerBoard.InitialImage = global::Gra_Statki.Properties.Resources.board;
            this.pbPlayerBoard.Location = new System.Drawing.Point(12, 12);
            this.pbPlayerBoard.Name = "pbPlayerBoard";
            this.pbPlayerBoard.Size = new System.Drawing.Size(400, 400);
            this.pbPlayerBoard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayerBoard.TabIndex = 5;
            this.pbPlayerBoard.TabStop = false;
            // 
            // GameSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 425);
            this.Controls.Add(this.pbPlayerBoard);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnRotate);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.lblPlayer);
            this.Name = "GameSettingsForm";
            this.Text = "GameSettingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Button btnRotate;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.PictureBox pbPlayerBoard;
    }
}