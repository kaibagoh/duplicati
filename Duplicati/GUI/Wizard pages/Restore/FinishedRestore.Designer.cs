namespace Duplicati.GUI.Wizard_pages.Restore
{
    partial class FinishedRestore
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinishedRestore));
            this.Summary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RunInBackground = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Summary
            // 
            resources.ApplyResources(this.Summary, "Summary");
            this.Summary.Name = "Summary";
            this.Summary.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // RunInBackground
            // 
            resources.ApplyResources(this.RunInBackground, "RunInBackground");
            this.RunInBackground.Checked = true;
            this.RunInBackground.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RunInBackground.Name = "RunInBackground";
            this.RunInBackground.UseVisualStyleBackColor = true;
            // 
            // FinishedRestore
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RunInBackground);
            this.Controls.Add(this.Summary);
            this.Controls.Add(this.label1);
            this.Name = "FinishedRestore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox Summary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox RunInBackground;
    }
}
