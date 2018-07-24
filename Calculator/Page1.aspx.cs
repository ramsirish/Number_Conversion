using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculator
{
    public partial class Page1 : System.Web.UI.Page
    {
        string fromInput;
        string finalNum;

        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            fromInput = getInput.Text;

            // Input is Binary
            if(convertFrom.SelectedIndex == 1)
            {
                if(convertTo.SelectedIndex == 1)
                {
                    resultBox.Text = "The number is already in Binary";
                }

                // Binary to Decimal
                else if(convertTo.SelectedIndex == 2)
                {
                    finalNum = Convert.ToInt64(fromInput, 2).ToString();
                    resultBox.Text = finalNum;
                }
                // Binary to Hexadecimal
                else if (convertTo.SelectedIndex == 3)
                {
                    finalNum = Convert.ToInt64(fromInput, 2).ToString("X");
                    resultBox.Text = finalNum;

                }
            }

            // Input is Decimal
            if (convertFrom.SelectedIndex == 2)
            {
                // Decimal to Binary
                if (convertTo.SelectedIndex == 1)
                {
                    finalNum = Convert.ToString(Convert.ToInt64(fromInput), 2);
                    resultBox.Text = finalNum;
                }

                else if (convertTo.SelectedIndex == 2)
                {
                    resultBox.Text = "The number is already a Decimal";
                }
                // Decimal to Hexadecimal
                else if (convertTo.SelectedIndex == 3)
                {
                    finalNum = Convert.ToInt64(fromInput).ToString("X");
                    resultBox.Text = finalNum;
                }
            }


            // Input is Hexadecimal
            if (convertFrom.SelectedIndex == 3)
            {
                // Hexadecimal to Binary
                if (convertTo.SelectedIndex == 1)
                {
                    finalNum = Convert.ToString(Convert.ToInt64(fromInput, 16), 2);
                    resultBox.Text = finalNum;
                }

                // Hexadecimal to Decimal
                else if (convertTo.SelectedIndex == 2)
                {
                    finalNum = Convert.ToInt64(fromInput, 16).ToString();
                    resultBox.Text = finalNum;
                }
              
                else if (convertTo.SelectedIndex == 3)
                {
                    resultBox.Text = "The number is already a Hexadecimal";
                }

            }
        }
    }
}