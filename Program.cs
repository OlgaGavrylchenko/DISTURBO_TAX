/*
    CIT 287 - Programming Project 1
    I have just developed a product called DISTURBO TAX 1.0
    which should calculate tax based on user data

    @Created by Olga Gavrylchenko,  2/16/2018
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisturboTax
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DemographicForm());
        }
    }
}
