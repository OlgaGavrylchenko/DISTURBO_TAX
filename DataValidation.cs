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
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DisturboTax
{
    //the class consists methods to validate user's input
    public static class DataValidation
    {
        public static bool IsPresent(TextBox textBox, Label label) {

            if (textBox.Text == "") {
                label.Visible = true;
                textBox.Focus();
                return false;
            }
            return true;
        }//IsPresent


        public static bool IsName(TextBox textBox, Label label)
        {
            if (!Regex.IsMatch(textBox.Text, "^[a-zA-Z]+$")) {
                label.Visible = true;
                textBox.Focus();
                return false;
            }

            return true;
        }//IsName


        public static bool IsSSN(TextBox textBox, Label label)
        {
            if(!Regex.IsMatch(textBox.Text, "^\\d{3}[-]\\d{2}[-]\\d{4}$"))
            {
                label.Visible = true;
                textBox.Focus();
                return false;
            }
            return true;
        }//IsSSN


        public static bool IsStreetName(TextBox textBox, Label label)
        {
            //"^\\d+\\s+[a-zA-Z]{1,}[ .-]{0,1}[a-zA-Z]{1,}[ ]{0,1}[a-zA-Z]{0,}$" - 10 Brenton street or 12 levanevskogo-gogolya street
            string regExpAlpha = "^\\d+\\s+[\\p{L}]{1,}[ .-]{0,1}[\\p{L}]{1,}[ ]{0,1}[\\p{L}]{0,}$";

            if(!Regex.IsMatch(textBox.Text, regExpAlpha))
            {
                label.Visible = true;
                textBox.Focus();
                return false;
            }
            return true;
        }//IsStreetName


        public static bool IsCity(TextBox textBox, Label label)
        {
            string regExpAlpha = "^[\\p{L}]{1,}[ -]{0,1}[\\p{L}]{0,}$";

            if (!Regex.IsMatch(textBox.Text, regExpAlpha))
            {
                label.Visible = true;
                textBox.Focus();
                return false;
            }
            return true;
        }//IsStreetName



        public static bool IsZipCode(TextBox textBox, Label label)
        {
            if (textBox.Text.Length != 5) {
                label.Visible = true;
                textBox.Focus();
                return false;
            }
            return true;
        }


        //check number on digital characters only
        public static bool IsDigit(TextBox textBox, Label label)
        {
            if(!Regex.IsMatch(textBox.Text, "^[0-9]+$"))
            {
                label.Visible = true;
                textBox.Focus();
                return false;
            }
            return true;
        }//IsDigit


        public static bool IsDecimal(TextBox textBox, Label label) {
            decimal number = 0m;

            try
            {
                if (!Decimal.TryParse(textBox.Text, out number))
                {

                    label.Visible = true;
                    textBox.Focus();
                    return false;

                }else
                {
                    return true;
                }   
            }
            catch (OverflowException)
            {
                label.Visible = true;
                return false;
            }
 
        }//IsDecimal

        public static bool IsZero(TextBox textBox, Label label) {

            decimal num = Convert.ToDecimal(textBox.Text);
            decimal zero = 0m;

            if ( num <= zero) //if less than zero
            {

                label.Visible = true;
                textBox.Focus();
                return false;
            }

            return true;
        }

        public static bool IsNegativeNum(TextBox textBox, Label label)
        {
            decimal num = Convert.ToDecimal(textBox.Text);
            decimal zero = 0m;

            if (num < zero) //if less than zero
            {

                label.Visible = true;
                textBox.Focus();
                return false;
            }

            return true;
        }


        public static bool IsInt32(TextBox textBox, Label label) {
            int number = 0;

            if (!Int32.TryParse(textBox.Text, out number))
            {
                label.Visible = true;
                textBox.Focus();
                return false;
            }

            return true;
        }//IsInt32


        public static bool IsWithinRange(int number, int min, int max) {

            if (number >= min && number <= max) {
                return true;
            }else
            {
                return false;
            }
        }//IsWithinRange
    }
}
