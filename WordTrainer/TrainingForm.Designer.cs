namespace WordTrainer
{
    partial class TrainingForm
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
            this.lb_Word = new System.Windows.Forms.Label();
            this.lb_Tranlation = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Dunno = new System.Windows.Forms.Button();
            this.btn_Know = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Word
            // 
            this.lb_Word.AutoSize = true;
            this.lb_Word.ForeColor = System.Drawing.Color.Lime;
            this.lb_Word.Location = new System.Drawing.Point(81, 11);
            this.lb_Word.Name = "lb_Word";
            this.lb_Word.Size = new System.Drawing.Size(56, 20);
            this.lb_Word.TabIndex = 0;
            this.lb_Word.Text = "Occur";
            // 
            // lb_Tranlation
            // 
            this.lb_Tranlation.AutoSize = true;
            this.lb_Tranlation.ForeColor = System.Drawing.Color.Lime;
            this.lb_Tranlation.Location = new System.Drawing.Point(81, 42);
            this.lb_Tranlation.Name = "lb_Tranlation";
            this.lb_Tranlation.Size = new System.Drawing.Size(56, 20);
            this.lb_Tranlation.TabIndex = 0;
            this.lb_Tranlation.Text = "Occur";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.btn_Next);
            this.panel1.Controls.Add(this.btn_Know);
            this.panel1.Controls.Add(this.btn_Dunno);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 158);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.Lime;
            this.groupBox1.Location = new System.Drawing.Point(-1, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 177);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Try yourself";
            // 
            // btn_Dunno
            // 
            this.btn_Dunno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Dunno.ForeColor = System.Drawing.Color.Black;
            this.btn_Dunno.Location = new System.Drawing.Point(59, 97);
            this.btn_Dunno.Name = "btn_Dunno";
            this.btn_Dunno.Size = new System.Drawing.Size(75, 23);
            this.btn_Dunno.TabIndex = 1;
            this.btn_Dunno.Text = "I dunno";
            this.btn_Dunno.UseVisualStyleBackColor = true;
            // 
            // btn_Know
            // 
            this.btn_Know.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Know.ForeColor = System.Drawing.Color.Black;
            this.btn_Know.Location = new System.Drawing.Point(154, 97);
            this.btn_Know.Name = "btn_Know";
            this.btn_Know.Size = new System.Drawing.Size(75, 23);
            this.btn_Know.TabIndex = 1;
            this.btn_Know.Text = "I know";
            this.btn_Know.UseVisualStyleBackColor = true;
            // 
            // btn_Next
            // 
            this.btn_Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Next.ForeColor = System.Drawing.Color.Black;
            this.btn_Next.Location = new System.Drawing.Point(108, 126);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(75, 23);
            this.btn_Next.TabIndex = 1;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lb_Word);
            this.panel2.Controls.Add(this.lb_Tranlation);
            this.panel2.Location = new System.Drawing.Point(37, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 85);
            this.panel2.TabIndex = 3;
            // 
            // TrainingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 194);
            this.Controls.Add(this.groupBox1);
            this.Name = "TrainingForm";
            this.Text = "TrainingForm";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_Word;
        private System.Windows.Forms.Label lb_Tranlation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Know;
        private System.Windows.Forms.Button btn_Dunno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
    }
}