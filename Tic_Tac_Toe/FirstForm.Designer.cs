namespace Tic_Tac_Toe
{
    partial class FirstForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstForm));
            this.TwoPlayersbtn = new System.Windows.Forms.Button();
            this.OnePlayerbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TwoPlayersbtn
            // 
            this.TwoPlayersbtn.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.TwoPlayersbtn.ForeColor = System.Drawing.Color.Black;
            this.TwoPlayersbtn.Location = new System.Drawing.Point(52, 109);
            this.TwoPlayersbtn.Name = "TwoPlayersbtn";
            this.TwoPlayersbtn.Size = new System.Drawing.Size(114, 32);
            this.TwoPlayersbtn.TabIndex = 4;
            this.TwoPlayersbtn.Text = "2 Players";
            this.TwoPlayersbtn.UseVisualStyleBackColor = true;
            this.TwoPlayersbtn.Click += new System.EventHandler(this.TwoPlayersbtn_Click);
            // 
            // OnePlayerbtn
            // 
            this.OnePlayerbtn.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.OnePlayerbtn.ForeColor = System.Drawing.Color.Black;
            this.OnePlayerbtn.Location = new System.Drawing.Point(52, 32);
            this.OnePlayerbtn.Name = "OnePlayerbtn";
            this.OnePlayerbtn.Size = new System.Drawing.Size(114, 32);
            this.OnePlayerbtn.TabIndex = 3;
            this.OnePlayerbtn.Text = "1 Player";
            this.OnePlayerbtn.UseVisualStyleBackColor = true;
            this.OnePlayerbtn.Click += new System.EventHandler(this.OnePlayerbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Viner Hand ITC", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(121, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mirette Amin";
            // 
            // FirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 187);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TwoPlayersbtn);
            this.Controls.Add(this.OnePlayerbtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(239, 226);
            this.MinimumSize = new System.Drawing.Size(239, 226);
            this.Name = "FirstForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FirstForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TwoPlayersbtn;
        private System.Windows.Forms.Button OnePlayerbtn;
        private System.Windows.Forms.Label label2;
    }
}

