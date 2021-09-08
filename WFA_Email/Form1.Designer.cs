
namespace WFA_Email
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstboxEmails = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cboProviders = new System.Windows.Forms.ComboBox();
            this.btnAddRecipient = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboProviders);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 64);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sender";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(255, 28);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(99, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(54, 28);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(127, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Email";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddRecipient);
            this.groupBox2.Controls.Add(this.btnSend);
            this.groupBox2.Controls.Add(this.txtBody);
            this.groupBox2.Controls.Add(this.txtSubject);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lstboxEmails);
            this.groupBox2.Location = new System.Drawing.Point(13, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(574, 250);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Receiver";
            // 
            // lstboxEmails
            // 
            this.lstboxEmails.FormattingEnabled = true;
            this.lstboxEmails.Location = new System.Drawing.Point(18, 50);
            this.lstboxEmails.Name = "lstboxEmails";
            this.lstboxEmails.Size = new System.Drawing.Size(132, 121);
            this.lstboxEmails.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Recipients";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Subject";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(177, 50);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(380, 20);
            this.txtSubject.TabIndex = 3;
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(177, 76);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(380, 132);
            this.txtBody.TabIndex = 4;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(482, 214);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Provider";
            // 
            // cboProviders
            // 
            this.cboProviders.FormattingEnabled = true;
            this.cboProviders.Location = new System.Drawing.Point(430, 27);
            this.cboProviders.Name = "cboProviders";
            this.cboProviders.Size = new System.Drawing.Size(121, 21);
            this.cboProviders.TabIndex = 9;
            // 
            // btnAddRecipient
            // 
            this.btnAddRecipient.Location = new System.Drawing.Point(75, 177);
            this.btnAddRecipient.Name = "btnAddRecipient";
            this.btnAddRecipient.Size = new System.Drawing.Size(75, 23);
            this.btnAddRecipient.TabIndex = 6;
            this.btnAddRecipient.Text = "Add";
            this.btnAddRecipient.UseVisualStyleBackColor = true;
            this.btnAddRecipient.Click += new System.EventHandler(this.btnAddRecipient_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 341);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "ES Email";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstboxEmails;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ComboBox cboProviders;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddRecipient;
    }
}

