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
            this.pbComputerBoard = new System.Windows.Forms.PictureBox();
            this.pbPlayerBoard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputerBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // pbComputerBoard
            // 
            this.pbComputerBoard.Image = global::Gra_Statki.Properties.Resources.Board;
            this.pbComputerBoard.InitialImage = global::Gra_Statki.Properties.Resources.Board;
            this.pbComputerBoard.Location = new System.Drawing.Point(28, 32);
            this.pbComputerBoard.Name = "pbComputerBoard";
            this.pbComputerBoard.Size = new System.Drawing.Size(400, 400);
            this.pbComputerBoard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbComputerBoard.TabIndex = 0;
            this.pbComputerBoard.TabStop = false;
            // 
            // pbPlayerBoard
            // 
            this.pbPlayerBoard.Image = global::Gra_Statki.Properties.Resources.Board;
            this.pbPlayerBoard.InitialImage = global::Gra_Statki.Properties.Resources.Board;
            this.pbPlayerBoard.Location = new System.Drawing.Point(504, 32);
            this.pbPlayerBoard.Name = "pbPlayerBoard";
            this.pbPlayerBoard.Size = new System.Drawing.Size(400, 400);
            this.pbPlayerBoard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayerBoard.TabIndex = 1;
            this.pbPlayerBoard.TabStop = false;
            // 
            // MyGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 457);
            this.Controls.Add(this.pbPlayerBoard);
            this.Controls.Add(this.pbComputerBoard);
            this.Name = "MyGameForm";
            this.Text = "MyGameForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbComputerBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerBoard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbComputerBoard;
        private System.Windows.Forms.PictureBox pbPlayerBoard;
    }
}