namespace DigitalClock
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
            this.components = new System.ComponentModel.Container();
            this.timeCatcher = new System.Windows.Forms.Timer(this.components);
            this.txtClock = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.Label();
            this.txtDay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timeCatcher
            // 
            this.timeCatcher.Tick += new System.EventHandler(this.timeCatcher_Tick);
            // 
            // txtClock
            // 
            this.txtClock.AutoSize = true;
            this.txtClock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtClock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtClock.Font = new System.Drawing.Font("PMingLiU-ExtB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtClock.ForeColor = System.Drawing.Color.White;
            this.txtClock.Location = new System.Drawing.Point(104, 14);
            this.txtClock.Name = "txtClock";
            this.txtClock.Size = new System.Drawing.Size(94, 34);
            this.txtClock.TabIndex = 0;
            this.txtClock.Text = "label1";
            // 
            // txtDate
            // 
            this.txtDate.AutoSize = true;
            this.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtDate.Font = new System.Drawing.Font("PMingLiU-ExtB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDate.ForeColor = System.Drawing.Color.White;
            this.txtDate.Location = new System.Drawing.Point(33, 75);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(94, 34);
            this.txtDate.TabIndex = 0;
            this.txtDate.Text = "label1";
            // 
            // txtDay
            // 
            this.txtDay.AutoSize = true;
            this.txtDay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtDay.Font = new System.Drawing.Font("PMingLiU-ExtB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDay.ForeColor = System.Drawing.Color.White;
            this.txtDay.Location = new System.Drawing.Point(209, 75);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(94, 34);
            this.txtDay.TabIndex = 0;
            this.txtDay.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(364, 135);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtClock);
            this.Name = "Form1";
            this.Text = "Digital Clock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timeCatcher;
        private Label txtClock;
        private Label txtDate;
        private Label txtDay;
    }
}