namespace FlappyBird
{
    partial class Partida
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
            this.timerScroll = new System.Windows.Forms.Timer(this.components);
            this.timerTuberia = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timerScroll
            // 
            this.timerScroll.Interval = 30;
            this.timerScroll.Tick += new System.EventHandler(this.timerScroll_Tick);
            // 
            // timerTuberia
            // 
            this.timerTuberia.Interval = 2000;
            this.timerTuberia.Tick += new System.EventHandler(this.timerTuberia_Tick);
            // 
            // Partida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Partida";
            this.Text = "Partida";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Partida_FormClosed);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Partida_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Partida_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Partida_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerScroll;
        private System.Windows.Forms.Timer timerTuberia;
    }
}