
namespace WFA_Email
{
    partial class FormInput
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
            this.lblCustom = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCustom
            // 
            this.lblCustom.AutoSize = true;
            this.lblCustom.Location = new System.Drawing.Point(12, 9);
            this.lblCustom.Name = "lblCustom";
            this.lblCustom.Size = new System.Drawing.Size(35, 13);
            this.lblCustom.TabIndex = 0;
            this.lblCustom.Text = "label1";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(15, 25);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(163, 20);
            this.txtValue.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(114, 51);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(64, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // FormInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 96);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.lblCustom);
            this.Name = "FormInput";
            this.Text = "FormInput";
            this.Load += new System.EventHandler(this.FormInput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustom;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnOk;
    }
}