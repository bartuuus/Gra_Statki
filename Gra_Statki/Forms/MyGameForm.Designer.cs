namespace Gra_Statki.Forms
{
    partial class MyGameForm
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
            this.components = new System.ComponentModel.Container();
            this.pbComputerBoard = new System.Windows.Forms.PictureBox();
            this.pbPlayerBoard = new System.Windows.Forms.PictureBox();
            this.timerComputerMove = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbComputerBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // pbComputerBoard
            // 
            this.pbComputerBoard.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pbComputerBoard.Image = global::Gra_Statki.Properties.Resources.board;
            this.pbComputerBoard.InitialImage = global::Gra_Statki.Properties.Resources.board;
            this.pbComputerBoard.Location = new System.Drawing.Point(28, 32);
            this.pbComputerBoard.Name = "pbComputerBoard";
            this.pbComputerBoard.Size = new System.Drawing.Size(400, 400);
            this.pbComputerBoard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbComputerBoard.TabIndex = 0;
            this.pbComputerBoard.TabStop = false;
            this.pbComputerBoard.Click += new System.EventHandler(this.PbComputerBoard_Click);
            this.pbComputerBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.PbComputerBoard_Paint);
            this.pbComputerBoard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PbComputerBoard_MouseMove);
            // 
            // pbPlayerBoard
            // 
            this.pbPlayerBoard.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pbPlayerBoard.Image = global::Gra_Statki.Properties.Resources.board;
            this.pbPlayerBoard.InitialImage = global::Gra_Statki.Properties.Resources.board;
            this.pbPlayerBoard.Location = new System.Drawing.Point(504, 32);
            this.pbPlayerBoard.Name = "pbPlayerBoard";
            this.pbPlayerBoard.Size = new System.Drawing.Size(400, 400);
            this.pbPlayerBoard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayerBoard.TabIndex = 1;
            this.pbPlayerBoard.TabStop = false;
            this.pbPlayerBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.PbPlayerBoard_Paint);
            // 
            // timerComputerMove
            // 
            this.timerComputerMove.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // MyGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(933, 457);
            this.Controls.Add(this.pbPlayerBoard);
            this.Controls.Add(this.pbComputerBoard);
            this.Name = "MyGameForm";
            this.Text = "MyGameForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MyGameForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pbComputerBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerBoard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbComputerBoard;
        private System.Windows.Forms.PictureBox pbPlayerBoard;
        private System.Windows.Forms.Timer timerComputerMove;
    }
}