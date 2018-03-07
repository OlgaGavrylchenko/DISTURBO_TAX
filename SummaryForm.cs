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
    public partial class SummaryForm : Form
    {
        public SummaryForm()
        {
            InitializeComponent();
        }

        private void SummaryForm_Load(object sender, EventArgs e)
        {
            initListView();
        }

        private void initListView() {

            this.lvSummary.View = View.Details;
            this.lvSummary.GridLines = true;
            //this.lvSummary.Sort();

            this.lvSummary.Columns.Add("SSN", 100);
            this.lvSummary.Columns.Add("Last Name", 150);
            this.lvSummary.Columns.Add("First Name", 150);
            this.lvSummary.Columns.Add("Tax Owed", 120);
            this.lvSummary.Columns.Add("Refund", 120);

            foreach (TaxpayerData data in TaxpayerList.MainTaxpayerData) {
                string[] arr = new string[5];
                arr[0] = data.GetSSN();
                arr[1] = data.GetLastName();
                arr[2] = data.GetFirstName();
                arr[3] = data.GetTaxOwed().ToString("c2");
                arr[4] = data.GetRefund().ToString("c2");

                ListViewItem item = new ListViewItem(arr);
                this.lvSummary.Items.Add(item);
            }
        }
    }
}
