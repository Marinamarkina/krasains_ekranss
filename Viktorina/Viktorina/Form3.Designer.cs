
namespace Viktorina
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.labRezultats = new System.Windows.Forms.Label();
            this.labVirsraksts = new System.Windows.Forms.Label();
            this.labKoment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labRezultats
            // 
            this.labRezultats.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.labRezultats, "labRezultats");
            this.labRezultats.ForeColor = System.Drawing.Color.Maroon;
            this.labRezultats.Name = "labRezultats";
            // 
            // labVirsraksts
            // 
            resources.ApplyResources(this.labVirsraksts, "labVirsraksts");
            this.labVirsraksts.ForeColor = System.Drawing.Color.Maroon;
            this.labVirsraksts.Name = "labVirsraksts";
            // 
            // labKoment
            // 
            resources.ApplyResources(this.labKoment, "labKoment");
            this.labKoment.ForeColor = System.Drawing.Color.Maroon;
            this.labKoment.Name = "labKoment";
            // 
            // Form3
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Viktorina.Properties.Resources.Latvija;
            this.Controls.Add(this.labKoment);
            this.Controls.Add(this.labRezultats);
            this.Controls.Add(this.labVirsraksts);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labRezultats;
        private System.Windows.Forms.Label labVirsraksts;
        private System.Windows.Forms.Label labKoment;
    }
}