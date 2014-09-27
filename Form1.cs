using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorApp
{
    public partial class Form1 : Form
    {
        SalaryCalculator salary=new SalaryCalculator();
        public Form1()
        {
            InitializeComponent();
        }

        private void showSalaryButton_Click(object sender, EventArgs e)
        {
            salary.employeeName = employeeNameTextBox.Text;
            salary.basicAmount = Convert.ToDouble(basicAmountTextBox.Text);
            salary.rent = Convert.ToDouble(houseRentTextBox.Text);
            salary.allowance = Convert.ToDouble(medicalAllowanceTextBox.Text);

            salary.CalculateSalary();

            MessageBox.Show(salary.employeeName + " Your Salary is" + salary.CalculateSalary().ToString());
        }

       
    }
}
