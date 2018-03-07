/*
    CIT 287 - Programming Project 1
    I have just developed a product called DISTURBO TAX 1.0
    which should calculate tax based on user data

    @Created by Olga Gavrylchenko,  2/16/2018
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisturboTax
{
    public partial class TaxResultForm : Form
    {
        private int index = 0;
        private int count = 0;

        public TaxResultForm()
        {
            InitializeComponent();

            this.count = TaxpayerList.MainTaxpayerData.Count;
            TaxpayerData data = TaxpayerList.MainTaxpayerData[index];
            this.tfFullName.Text = (data.GetFirstName() + " " + data.GetLastName());
            this.tfSSN2.Text = data.GetSSN();
            this.tfAdjustedGross.Text = data.GetAdjustedGross().ToString("c2");
            this.tfAmountCalc.Text = data.GetTaxCalc().ToString("c2");
            this.tfAmountWithheld.Text = data.GetFedTaxWithheld().ToString("c2");
            this.tfPenalty.Text = data.GetPenalty().ToString("c2");
            this.tfTaxOwed.Text = data.GetTaxOwed().ToString("c2");
            this.tfRefund.Text = data.GetRefund().ToString("c2");
            index++;
        }

        private void btNextData_Click(object sender, EventArgs e)
        {

            if (index < count)
            {
                TaxpayerData data = TaxpayerList.MainTaxpayerData[index];
                this.tfFullName.Text = (data.GetFirstName() + " " + data.GetLastName());
                this.tfSSN2.Text = data.GetSSN();
                this.tfAdjustedGross.Text = data.GetAdjustedGross().ToString("c2");
                this.tfAmountCalc.Text = data.GetTaxCalc().ToString("c2");
                this.tfAmountWithheld.Text = data.GetFedTaxWithheld().ToString("c2");
                this.tfPenalty.Text = data.GetPenalty().ToString("c2");
                this.tfTaxOwed.Text = data.GetTaxOwed().ToString("c2");
                this.tfRefund.Text = data.GetRefund().ToString("c2");

                index++;
            }
            else {
                //show summary of all taxpayer in third form
                Form summaryForm = new SummaryForm();
                summaryForm.ShowDialog();
            }
 
        }


        private void btClose2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(this, "Would you like to DELETE ALL user's data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if(result == DialogResult.Yes)
            {
                //deleteall data
                TaxpayerList.MainIndex = 0;
                TaxpayerList.MainTaxpayerData.Clear();

                this.Close();
            }
            else
            {
                this.Close();
            }  
        }

        private void TaxResultForm_Load(object sender, EventArgs e)
        {

        }
    }
}
