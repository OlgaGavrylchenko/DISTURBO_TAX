﻿/*
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
    public static class TaxpayerList
    {
        public static int MainIndex = 0;

        public static List<TaxpayerData> MainTaxpayerData = new List<TaxpayerData>();

        public static void setUserData(TaxpayerData data) {
            MainTaxpayerData.Add(data);
        }


    }
}
