namespace Forth_Question
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtr = new System.Windows.Forms.TextBox();
            this.txth = new System.Windows.Forms.TextBox();
            this.Enter = new System.Windows.Forms.Button();
            this.lblvolume = new System.Windows.Forms.Label();
            this.lblarea = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "R:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(516, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "H:";
            // 
            // txtr
            // 
            this.txtr.Location = new System.Drawing.Point(204, 114);
            this.txtr.Name = "txtr";
            this.txtr.Size = new System.Drawing.Size(100, 22);
            this.txtr.TabIndex = 2;
            // 
            // txth
            // 
            this.txth.Location = new System.Drawing.Point(544, 112);
            this.txth.Name = "txth";
            this.txth.Size = new System.Drawing.Size(100, 22);
            this.txth.TabIndex = 3;
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(63, 251);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(377, 95);
            this.Enter.TabIndex = 4;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // lblvolume
            // 
            this.lblvolume.AutoSize = true;
            this.lblvolume.Location = new System.Drawing.Point(566, 290);
            this.lblvolume.Name = "lblvolume";
            this.lblvolume.Size = new System.Drawing.Size(55, 17);
            this.lblvolume.TabIndex = 5;
            this.lblvolume.Text = "Volume";
            // 
            // lblarea
            // 
            this.lblarea.AutoSize = true;
            this.lblarea.Location = new System.Drawing.Point(738, 290);
            this.lblarea.Name = "lblarea";
            this.lblarea.Size = new System.Drawing.Size(38, 17);
            this.lblarea.TabIndex = 6;
            this.lblarea.Text = "Area";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 485);
            this.Controls.Add(this.lblarea);
            this.Controls.Add(this.lblvolume);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.txth);
            this.Controls.Add(this.txtr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtr;
        private System.Windows.Forms.TextBox txth;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.Label lblvolume;
        private System.Windows.Forms.Label lblarea;
    }
}

