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
    public static class IRSData
    {
        public static readonly decimal ExemDeduction = 1000.0m;

        public static readonly decimal RealEstateDeduction = 0.25m;

        public static readonly decimal MedDeduction = 0.08m;

        public static readonly decimal CapitalDeduction = 0.15m;

        public static readonly decimal PenaltyPercent = 0.1m;

        //tax percent of adjucted gross
        public static readonly decimal PercentZero = 0.1m;
        public static readonly decimal PercentOne = 0.15m;
        public static readonly decimal PercentTwo = 0.2m;
        public static readonly decimal PercentThree = 0.25m;
        public static readonly decimal PercentFour = 0.28m;

        //ernings
        public static readonly decimal EarningFirst = 999.99m;
        public static readonly decimal EarningSecondA = 1000.00m;
        public static readonly decimal EarningSecondB = 9999.99m;
        public static readonly decimal EarningThirdA = 10000.00m;
        public static readonly decimal EarningThirdB = 19999.99m;
        public static readonly decimal EarningForthA = 20000.00m;
        public static readonly decimal EarningForthB = 29999.99m;
        public static readonly decimal EarningFifth = 30000.00m;

    }
}
