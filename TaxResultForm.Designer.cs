namespace DisturboTax
{
    partial class TaxResultForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tfFullName = new System.Windows.Forms.TextBox();
            this.tfAdjustedGross = new System.Windows.Forms.TextBox();
            this.tfAmountCalc = new System.Windows.Forms.TextBox();
            this.tfAmountWithheld = new System.Windows.Forms.TextBox();
            this.tfPenalty = new System.Windows.Forms.TextBox();
            this.tfTaxOwed = new System.Windows.Forms.TextBox();
            this.tfRefund = new System.Windows.Forms.TextBox();
            this.btNextData = new System.Windows.Forms.Button();
            this.btClose2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tfSSN2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adjusted Gross:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount of Tax (Calculated):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount of Tax Withheld from W-2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Penalty:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(278, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tax Owed to the Federal Government:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Refund Due to the Taxpayer:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Taxpayer Full Name:";
            // 
            // tfFullName
            // 
            this.tfFullName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tfFullName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfFullName.Location = new System.Drawing.Point(346, 44);
            this.tfFullName.Name = "tfFullName";
            this.tfFullName.ReadOnly = true;
            this.tfFullName.Size = new System.Drawing.Size(150, 25);
            this.tfFullName.TabIndex = 1;
            // 
            // tfAdjustedGross
            // 
            this.tfAdjustedGross.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tfAdjustedGross.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfAdjustedGross.Location = new System.Drawing.Point(346, 133);
            this.tfAdjustedGross.Name = "tfAdjustedGross";
            this.tfAdjustedGross.ReadOnly = true;
            this.tfAdjustedGross.Size = new System.Drawing.Size(150, 25);
            this.tfAdjustedGross.TabIndex = 3;
            // 
            // tfAmountCalc
            // 
            this.tfAmountCalc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tfAmountCalc.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfAmountCalc.Location = new System.Drawing.Point(346, 181);
            this.tfAmountCalc.Name = "tfAmountCalc";
            this.tfAmountCalc.ReadOnly = true;
            this.tfAmountCalc.Size = new System.Drawing.Size(150, 25);
            this.tfAmountCalc.TabIndex = 4;
            // 
            // tfAmountWithheld
            // 
            this.tfAmountWithheld.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tfAmountWithheld.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfAmountWithheld.Location = new System.Drawing.Point(346, 230);
            this.tfAmountWithheld.Name = "tfAmountWithheld";
            this.tfAmountWithheld.ReadOnly = true;
            this.tfAmountWithheld.Size = new System.Drawing.Size(150, 25);
            this.tfAmountWithheld.TabIndex = 5;
            // 
            // tfPenalty
            // 
            this.tfPenalty.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tfPenalty.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfPenalty.Location = new System.Drawing.Point(346, 280);
            this.tfPenalty.Name = "tfPenalty";
            this.tfPenalty.ReadOnly = true;
            this.tfPenalty.Size = new System.Drawing.Size(150, 25);
            this.tfPenalty.TabIndex = 6;
            // 
            // tfTaxOwed
            // 
            this.tfTaxOwed.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tfTaxOwed.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfTaxOwed.Location = new System.Drawing.Point(346, 329);
            this.tfTaxOwed.Name = "tfTaxOwed";
            this.tfTaxOwed.ReadOnly = true;
            this.tfTaxOwed.Size = new System.Drawing.Size(150, 25);
            this.tfTaxOwed.TabIndex = 7;
            // 
            // tfRefund
            // 
            this.tfRefund.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tfRefund.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfRefund.Location = new System.Drawing.Point(346, 377);
            this.tfRefund.Name = "tfRefund";
            this.tfRefund.ReadOnly = true;
            this.tfRefund.Size = new System.Drawing.Size(150, 25);
            this.tfRefund.TabIndex = 8;
            // 
            // btNextData
            // 
            this.btNextData.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNextData.Location = new System.Drawing.Point(396, 438);
            this.btNextData.Name = "btNextData";
            this.btNextData.Size = new System.Drawing.Size(100, 30);
            this.btNextData.TabIndex = 10;
            this.btNextData.Text = "NEXT DATA";
            this.btNextData.UseVisualStyleBackColor = true;
            this.btNextData.Click += new System.EventHandler(this.btNextData_Click);
            // 
            // btClose2
            // 
            this.btClose2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose2.Location = new System.Drawing.Point(290, 438);
            this.btClose2.Name = "btClose2";
            this.btClose2.Size = new System.Drawing.Size(100, 30);
            this.btClose2.TabIndex = 9;
            this.btClose2.Text = "CLOSE";
            this.btClose2.UseVisualStyleBackColor = true;
            this.btClose2.Click += new System.EventHandler(this.btClose2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(45, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "SSN #:";
            // 
            // tfSSN2
            // 
            this.tfSSN2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tfSSN2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfSSN2.Location = new System.Drawing.Point(346, 86);
            this.tfSSN2.Name = "tfSSN2";
            this.tfSSN2.ReadOnly = true;
            this.tfSSN2.Size = new System.Drawing.Size(150, 25);
            this.tfSSN2.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(138, 477);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(256, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "@Created by Olga Gavrylchenko, 2018";
            // 
            // TaxResultForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(532, 503);
            this.ControlBox = false;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tfSSN2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btClose2);
            this.Controls.Add(this.btNextData);
            this.Controls.Add(this.tfRefund);
            this.Controls.Add(this.tfTaxOwed);
            this.Controls.Add(this.tfPenalty);
            this.Controls.Add(this.tfAmountWithheld);
            this.Controls.Add(this.tfAmountCalc);
            this.Controls.Add(this.tfAdjustedGross);
            this.Controls.Add(this.tfFullName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TaxResultForm";
            this.Text = "DISTURBO TAX 1.0 - Taxpayer Result";
            this.Load += new System.EventHandler(this.TaxResultForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tfFullName;
        private System.Windows.Forms.TextBox tfAdjustedGross;
        private System.Windows.Forms.TextBox tfAmountCalc;
        private System.Windows.Forms.TextBox tfAmountWithheld;
        private System.Windows.Forms.TextBox tfPenalty;
        private System.Windows.Forms.TextBox tfTaxOwed;
        private System.Windows.Forms.TextBox tfRefund;
        private System.Windows.Forms.Button btNextData;
        private System.Windows.Forms.Button btClose2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tfSSN2;
        private System.Windows.Forms.Label label9;
    }
}