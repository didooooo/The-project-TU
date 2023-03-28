namespace The_project
{
    partial class ChoiceForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(598, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // ChoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 533);
            this.Controls.Add(this.label1);
            this.Name = "ChoiceForm";
            this.Text = "ChoiceForm";
            this.Load += new System.EventHandler(this.ChoiceForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
    }
}