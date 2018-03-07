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
    public partial class DemographicForm : Form
    {
        private readonly string[] listOfState = {"ALABAMA", "ALASKA", "ARIZONA", "ARKANSAS", "CALIFORNIAA",
            "COLORADO", "CONNECTICUT", "DELAWARE", "FLORIDA", "GEORGIA", "HAWAII",
            "IDAHO", "ILLINOIS", "INDIANA", "IOWA", "KANSAS", "KENTUCKY",
            "LOUISIANA", "MAINE", "MARYLAND", "MASSACHUSETTS", "MICHIGAN",
            "MINNESOTA", "MISSISSIPPI", "MISSOURI", "MONTANA", "NEBRASKA",
            "NEVADA", "NEW HAMPSHIRE", "NEW JERSEY", "NEW MEXICO", "NEW YORK",
            "NORTH CAROLINA","NORTH DAKOTA", "OHIO", "OKLAHOMA", "OREGON", "PENNSYLVANIA",
            "RHODE ISLAND", "SOUTH CAROLINA", "SOUTH DAKOTA", "TENNESSEE", "TEXAS", "UTAH",
            "VERMONT", "VIRGINIA", "WASHINGTON", "WEST VIRGINIA", "WISCONSIN", "WYOMING", "DIS. COLUMBIA"};

        //define variable that stores 10 users' acounts
        private const int SIZE = 10;



        public DemographicForm()
        {
            InitializeComponent();

        }

        private void DemographicForm_Load(object sender, EventArgs e)
        {
            //loads the State combo box
            foreach (string state in listOfState) {
                this.cbState.Items.Add(state);
            }

            this.tfFirstName.Focus();
        }


        private void btResult_Click(object sender, EventArgs e)
        {
            //show summary of all taxpayer in third form
            Form summaryForm = new SummaryForm();
            summaryForm.ShowDialog();
        }


        private void btSubmit_Click(object sender, EventArgs e)
        {
            //get user input
            //add user data to linked list
            //open second form

            if (TaxpayerList.MainIndex < SIZE)
            {
                if (IsValidDataEmpty())
                {

                    //define local variables
                    string firstName = "", lastName = "", address = "", city = "", state = "", zipCode = "", ssn = "";
                    int numExem = 0;
                    decimal gross = 0m, fedTax = 0m, capital = 0m, realEstate = 0m, excise = 0m, medTax = 0m;

                    firstName = this.tfFirstName.Text;
                    lastName = this.tfLastName.Text;
                    address = this.tfAddress.Text;
                    city = this.tfCity.Text;
                    state = this.cbState.SelectedItem.ToString();
                    zipCode = this.tfZipCode.Text;
                    ssn = this.tfSSN.Text;

                    numExem = Convert.ToInt32(this.tfExemption.Text);

                    gross = Convert.ToDecimal(this.tfGrossEarnings.Text);
                    fedTax = Convert.ToDecimal(this.tfFedTax.Text);
                    capital = Convert.ToDecimal(this.tfCapital.Text);
                    realEstate = Convert.ToDecimal(this.tfRealEstate.Text);
                    excise = Convert.ToDecimal(this.tfExciseTax.Text);
                    medTax = Convert.ToDecimal(this.tfMedExpenses.Text);

                    //add data to object
                    TaxpayerData data = new TaxpayerData(firstName, lastName, address, city, state, zipCode,
                                             ssn, numExem, gross, fedTax, capital, realEstate, excise, medTax);
                    //add object to array list
                    TaxpayerList.setUserData(data);
                    clearFields();

                    //MessageBox.Show(this, data.GetDisplayText("\n"), "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.None);
                    
                    //increment index
                    TaxpayerList.MainIndex++;

                    if (TaxpayerList.MainIndex == SIZE) {
                        //open form #2
                        Form taxResultForm = new TaxResultForm();
                        taxResultForm.ShowDialog();
                    }
                }
                else
                {
                    //dispaly error msg
                    MessageBox.Show(this, "Your data is incorrect!\nPlease, correct ALL text fields with RED error-labels", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else
            {
                //open form #2
                Form taxResultForm = new TaxResultForm();
                taxResultForm.ShowDialog();
            }
        }

        public bool IsValidDataEmpty() {

            bool firstName, lastName, address, ssn, exempTax, gross, fedTax, capital, realEst, exciseTax, medExp;

            firstName = (DataValidation.IsPresent(this.tfFirstName, this.lErrorName) 
                         && DataValidation.IsName(this.tfFirstName, this.lErrorName));

            lastName = (DataValidation.IsPresent(this.tfLastName, this.lErrorLName)
                        && DataValidation.IsName(this.tfLastName, this.lErrorLName));

            address = (DataValidation.IsPresent(this.tfAddress, this.lErrorAddress) &&
                       DataValidation.IsPresent(this.tfCity, this.lErrorAddress) &&
                       DataValidation.IsPresent(this.tfZipCode, this.lErrorAddress) &&
                       DataValidation.IsStreetName(this.tfAddress, this.lErrorAddress) &&
                       DataValidation.IsCity(this.tfCity, this.lErrorAddress) &&
                       DataValidation.IsDigit(this.tfZipCode, this.lErrorAddress) &&
                       DataValidation.IsZipCode(this.tfZipCode, this.lErrorAddress)
                       && (this.cbState.SelectedIndex != -1));


            ssn = (DataValidation.IsPresent(this.tfSSN, this.lErrorSSN) &&
                   DataValidation.IsSSN(this.tfSSN, this.lErrorSSN));

            exempTax = (DataValidation.IsPresent(this.tfExemption, this.lErrorExemp) &&
                        DataValidation.IsInt32(this.tfExemption, this.lErrorExemp) &&
                        DataValidation.IsZero(this.tfExemption, this.lErrorExemp)); //can not be less or equal zero

            gross = (DataValidation.IsPresent(this.tfGrossEarnings, this.lErrorGross) &&
                     DataValidation.IsDecimal(this.tfGrossEarnings, this.lErrorGross) &&
                     DataValidation.IsZero(this.tfGrossEarnings, this.lErrorGross));

            fedTax = (DataValidation.IsPresent(this.tfFedTax, this.lErrorFedTax) &&
                      DataValidation.IsDecimal(this.tfFedTax, this.lErrorFedTax) &&
                      DataValidation.IsZero(this.tfFedTax, this.lErrorFedTax));

            capital = (DataValidation.IsPresent(this.tfCapital, this.lErrorCapital) &&
                       DataValidation.IsDecimal(this.tfCapital, this.lErrorCapital));

            realEst = (DataValidation.IsPresent(this.tfRealEstate, this.lErrorRealEstate) &&
                       DataValidation.IsDecimal(this.tfRealEstate, this.lErrorRealEstate) &&
                       DataValidation.IsNegativeNum(this.tfRealEstate, this.lErrorRealEstate));

            exciseTax = (DataValidation.IsPresent(this.tfExciseTax, this.lErrorExciseTax) &&
                         DataValidation.IsDecimal(this.tfExciseTax, this.lErrorExciseTax) &&
                         DataValidation.IsNegativeNum(this.tfExciseTax, this.lErrorExciseTax));

            medExp = (DataValidation.IsPresent(this.tfMedExpenses, this.lErrorMedTax) &&
                      DataValidation.IsDecimal(this.tfMedExpenses, this.lErrorMedTax) &&
                      DataValidation.IsNegativeNum(this.tfMedExpenses, this.lErrorMedTax));

            return (firstName && lastName && address && ssn && exempTax && gross 
                    && fedTax && capital && realEst && exciseTax && medExp);
        }


        //clean all text fields
        private void btClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }//btClear_Click


        private void clearFields()
        {
            this.tfFirstName.Text = "";
            this.tfLastName.Text = "";
            this.tfAddress.Text = "";
            this.tfCity.Text = "";
            this.tfZipCode.Text = "";
            this.tfSSN.Text = "";
            this.tfExemption.Text = "";
            this.tfGrossEarnings.Text = "";
            this.tfFedTax.Text = "";
            this.tfCapital.Text = "";
            this.tfRealEstate.Text = "";
            this.tfExciseTax.Text = "";
            this.tfMedExpenses.Text = "";
            this.cbState.SelectedIndex = -1;

            //hide error labels
            this.lErrorName.Visible = false;
            this.lErrorLName.Visible = false;
            this.lErrorAddress.Visible = false;
            this.lErrorSSN.Visible = false;
            this.lErrorExemp.Visible = false;
            this.lErrorGross.Visible = false;
            this.lErrorFedTax.Visible = false;
            this.lErrorCapital.Visible = false;
            this.lErrorRealEstate.Visible = false;
            this.lErrorExciseTax.Visible = false;
            this.lErrorMedTax.Visible = false;

            this.tfFirstName.Focus();
        }


        private void btClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult result;

            result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                this.tfFirstName.Focus();
            }
        }//btClose_Click


        private void DemographicForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.DialogResult result;

            result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
        }//DemographicForm_FormClosing



        private void tfFirstName_TextChanged(object sender, EventArgs e)
        {
            this.lErrorName.Visible = false;
        }

        private void tfLastName_TextChanged(object sender, EventArgs e)
        {
            this.lErrorLName.Visible = false;
        }

        private void tfAddress_TextChanged(object sender, EventArgs e)
        {
            this.lErrorAddress.Visible = false;
        }

        private void tfCity_TextChanged(object sender, EventArgs e)
        {
            this.lErrorAddress.Visible = false;
        }

        private void tfSSN_TextChanged(object sender, EventArgs e)
        {
            this.lErrorSSN.Visible = false;
        }

        private void tfExemption_TextChanged(object sender, EventArgs e)
        {
            this.lErrorExemp.Visible = false;
        }

        private void tfGrossEarnings_TextChanged(object sender, EventArgs e)
        {
            this.lErrorGross.Visible = false;
        }

        private void tfFedTax_TextChanged(object sender, EventArgs e)
        {
            this.lErrorFedTax.Visible = false;
        }

        private void tfCapital_TextChanged(object sender, EventArgs e)
        {
            this.lErrorCapital.Visible = false;
        }

        private void tfRealEstate_TextChanged(object sender, EventArgs e)
        {
            this.lErrorRealEstate.Visible = false;
        }

        private void tfExciseTax_TextChanged(object sender, EventArgs e)
        {
            this.lErrorExciseTax.Visible = false;
        }

        private void tfMedExpenses_TextChanged(object sender, EventArgs e)
        {
            this.lErrorMedTax.Visible = false;
        }

        private void tfZipCode_TextChanged(object sender, EventArgs e)
        {
            this.lErrorAddress.Visible = false;
        }

        private void cbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lErrorAddress.Visible = false;
        }

        private void lErrorAddress_Click(object sender, EventArgs e)
        {

        }
    }
}
