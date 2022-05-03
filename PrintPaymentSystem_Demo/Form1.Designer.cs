
namespace PrintPaymentSystem_Demo
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
            this.btnShowAccount = new System.Windows.Forms.Button();
            this.btnAddAmount = new System.Windows.Forms.Button();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnShowAccount
            // 
            this.btnShowAccount.Location = new System.Drawing.Point(180, 215);
            this.btnShowAccount.Name = "btnShowAccount";
            this.btnShowAccount.Size = new System.Drawing.Size(373, 68);
            this.btnShowAccount.TabIndex = 0;
            this.btnShowAccount.Text = "Afficher les informations du compte";
            this.btnShowAccount.UseVisualStyleBackColor = true;
            this.btnShowAccount.Click += new System.EventHandler(this.btnShowAccount_Click);
            // 
            // btnAddAmount
            // 
            this.btnAddAmount.Location = new System.Drawing.Point(180, 289);
            this.btnAddAmount.Name = "btnAddAmount";
            this.btnAddAmount.Size = new System.Drawing.Size(373, 68);
            this.btnAddAmount.TabIndex = 1;
            this.btnAddAmount.Text = "Recharger le compte";
            this.btnAddAmount.UseVisualStyleBackColor = true;
            this.btnAddAmount.Click += new System.EventHandler(this.btnAddAmount_Click);
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(388, 115);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(165, 26);
            this.txtAccount.TabIndex = 2;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(388, 163);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(165, 26);
            this.txtAmount.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username ou Id de la carte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Montant en CHF";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.btnAddAmount);
            this.Controls.Add(this.btnShowAccount);
            this.Name = "Form1";
            this.Text = "Démo du système de paiement d\'imprimante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowAccount;
        private System.Windows.Forms.Button btnAddAmount;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

