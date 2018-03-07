/*
    CIT 287 - Programming Project 1
    I have just developed a product called DISTURBO TAX 1.0
    which should calculate tax based on user data

    @Created by Olga Gavrylchenko,  2/16/2018
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisturboTax
{
    public class TaxpayerData: IDisplayable
    {
        private string FirstName;
        private string LastName;
        private string Address;
        private string City;
        private string State;
        private string ZipCode;
        private string SSN;
        private int NumExemption;

        private decimal GrossEarn;
        private decimal FedTaxWithheld;

        private decimal CapitalGain;
        private decimal RealEstateTax;
        private decimal ExciseTax;
        private decimal MedExpenses;

        private decimal AdjustedGross;
        private decimal TaxCalc;
        private decimal Penalty;
        private decimal TaxOwed;
        private decimal Refund;

        //constructor
        public TaxpayerData(string firstName, string lastName, string address, string city, string state, 
                        string zip, string ssn, int exemp, decimal gross, decimal fedTax, decimal capital,
                        decimal realEstate, decimal exciseTax, decimal medTax) {
            this.FirstName = firstName.ToUpper();
            this.LastName = lastName.ToUpper();
            this.Address = address.ToUpper();
            this.City = city.ToUpper();
            this.State = state;
            this.ZipCode = zip;
            this.SSN = ssn;
            this.NumExemption = exemp;
            this.GrossEarn = gross;
            this.FedTaxWithheld = fedTax;
            this.CapitalGain = capital;
            this.RealEstateTax = realEstate;
            this.ExciseTax = exciseTax;
            this.MedExpenses = medTax;

            //calculate tax
            SetAdjustedGross();
            SetTaxCalc();
            SetPenalty();
            SetTaxOwed();
            SetRefund();

        }//constructor

        //define mutator and accessor methods

        public string GetFirstName() { return this.FirstName; }

        public string GetLastName() { return this.LastName; }

        public string GetAddress() { return this.Address; }

        public string GetCity() { return this.City; }

        public string GetState() { return this.State; }

        public string GetZip() { return this.ZipCode; }

        public string GetSSN() { return this.SSN; }

        public int GetNumExemption() { return this.NumExemption; }

        public decimal GetGrossEarn() { return this.GrossEarn; }

        public decimal GetFedTaxWithheld() { return this.FedTaxWithheld; }

        public decimal GetCapitalGross() { return this.CapitalGain; }

        public decimal GetRealEstatetax() { return this.RealEstateTax; }

        public decimal GetExciseTax() { return this.ExciseTax; }

        public decimal GetMedExpenses() { return this.MedExpenses; }


        public void SetAdjustedGross() {
            //round value based on 5/4 rule
            this.AdjustedGross = Math.Round(CalcAdjustedGross(), 0);//MidpointRounding.AwayFromZero
        }

        public decimal GetAdjustedGross() {
            return this.AdjustedGross;
        }

        public void SetTaxCalc() {
            this.TaxCalc = Math.Round(CalcTaxFromEarning(), 0);
        }

        public decimal GetTaxCalc() { return this.TaxCalc; }

        public void SetPenalty() {
            this.Penalty = Math.Round(CalcPenalty(), 0);
        }

        public decimal GetPenalty() { return this.Penalty; }

        public void SetTaxOwed() {
            this.TaxOwed = Math.Round(CalcTaxOwed(), 0);
        }

        public decimal GetTaxOwed() { return this.TaxOwed; }

        public void SetRefund() {
            this.Refund = Math.Round(CalcRefund(), 0);
        }

        public decimal GetRefund() { return this.Refund; }


        private decimal CalcAdjustedGross() {

            decimal result = 0m;

            result = GetGrossEarn() - (GetNumExemption() * IRSData.ExemDeduction) - 
                    ((GetRealEstatetax() + GetExciseTax()) * IRSData.RealEstateDeduction) -
                    (GetMedExpenses() * IRSData.MedDeduction) + 
                    (GetCapitalGross() * IRSData.CapitalDeduction);

            if(result < 0)
            {
                result = 0m;
            }
            Console.WriteLine("ADJ gross "+result.ToString());
            return result;
        }//CalcAdjustedGross


        private decimal CalcTaxFromEarning() { //Amount of Tax Calculated

            decimal result = 0m;

            if (this.AdjustedGross >= 0 && this.AdjustedGross <= IRSData.EarningFirst)
            {
                result = this.AdjustedGross * IRSData.PercentZero;
            }
            else if (this.AdjustedGross >= IRSData.EarningSecondA && this.AdjustedGross <= IRSData.EarningSecondB)
            {
                result = this.AdjustedGross * IRSData.PercentOne;
            }
            else if (this.AdjustedGross >= IRSData.EarningThirdA && this.AdjustedGross <= IRSData.EarningThirdB)
            {
                result = this.AdjustedGross * IRSData.PercentTwo;
            }
            else if (this.AdjustedGross >= IRSData.EarningForthA && this.AdjustedGross <= IRSData.EarningForthB)
            {
                result = this.AdjustedGross * IRSData.PercentThree;
            }
            else if (this.AdjustedGross >= IRSData.EarningFifth)
            {
                result = this.AdjustedGross * IRSData.PercentFour;
            }
            Console.WriteLine("Tax Calc "+result.ToString());

            return result;
        }//CalcTaxFromEarning


        private decimal CalcPenalty()
        {
            decimal result = 0m;

            if (this.TaxCalc > 0)
            {
                decimal diff = (this.FedTaxWithheld / this.TaxCalc) * 100;
                Console.WriteLine("Percent "+diff.ToString());
                if (diff < 90) {
                    result = IRSData.PenaltyPercent * (this.TaxCalc - this.FedTaxWithheld);
                }
            }
            

            return result;
        }//CalcPenalty


        private decimal CalcTaxOwed()
        {
            decimal result = 0m;

            decimal data = this.TaxCalc - this.FedTaxWithheld;

            if (data > 0) {
                result = data + this.Penalty;
            }
            Console.WriteLine("Owed " + result.ToString());
            return result;
        }//CalcTaxOwed


        private decimal CalcRefund()
        {
            decimal result = 0m;

            decimal data = this.FedTaxWithheld - this.TaxCalc;

            if (data > 0)
            {
                result = data;
            }
            Console.WriteLine("Refund "+result.ToString());
            return result;
        }//CalcRefund


        //implement method from IDisplayable interface
        public string GetDisplayText(string sep)
        {
            return this.SSN.ToString() + sep + this.LastName + sep + this.FirstName + sep
                   + this.TaxOwed.ToString("c2") + sep + this.Refund.ToString("c2");
        }
    }
}
