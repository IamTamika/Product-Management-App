using System;
using System.Windows.Forms;

namespace ProductMaintenance
{
    /// <summary>
    /// a collection of validation methods
    /// </summary>

    public static class Validator
    {
        /// <summary>
        /// validates if textbox has something in it
        /// </summary>
        /// <param name="tb">text box to validate</param>
        /// <param name="name">name for error message</param>
        /// <returns>true if valid, and false if not</returns>
        public static bool IsPresent(TextBox tb, string name)
        {
            bool isValid = true; // "innocent until proven guilty"
            if (tb.Text == "") // bad
            {
                isValid = false;
                MessageBox.Show(name + " is required", "Input error");
                tb.Focus();
            }
            return isValid;
        }

        /// <summary>
        /// validates if textbox contains non-negative int
        /// </summary>
        /// <param name="tb">text box to validate</param>
        /// <param name="name">name for error message</param>
        /// <returns>true if valid, and false if not</returns>
        public static bool IsNonNegativeInt(TextBox tb, string name)
        {
            bool isValid = true; // "innocent until proven guilty"
            int value;
            if (!Int32.TryParse(tb.Text, out value)) //not an int
            {
                isValid = false;
                MessageBox.Show(name + " has to be whole number", "Input error");
                tb.SelectAll();
                tb.Focus();
            }
            else if (value < 0)// cannot be negative
            {
                isValid = false;
                MessageBox.Show(name + " has to positive or zero", "Input error");
                tb.SelectAll();
                tb.Focus();
            }
            return isValid;
        }

        /// <summary>
        /// validates if textbox contains non-negative double
        /// </summary>
        /// <param name="tb">text box to validate</param>
        /// <param name="name">name for error message</param>
        /// <returns>true if valid, and false if not</returns>
        public static bool IsNonNegativeDouble(TextBox tb, string name)
        {
            bool isValid = true; // "innocent until proven guilty"
            double value;
            if (!Double.TryParse(tb.Text, out value)) //not an int
            {
                isValid = false;
                MessageBox.Show(name + " has to be a number", "Input error");
                tb.SelectAll();
                tb.Focus();
            }
            else if (value < 0)// cannot be negative
            {
                isValid = false;
                MessageBox.Show(name + " has to positive or zero", "Input error");
                tb.SelectAll();
                tb.Focus();
            }
            return isValid;
        }

        /// <summary>
        /// validates if textbox contains non-negative decimal
        /// </summary>
        /// <param name="tb">text box to validate</param>
        /// <param name="name">name for error message</param>
        /// <returns>true if valid, and false if not</returns>
        public static bool IsNonNegativeDecimal(TextBox tb, string name)
        {
            bool isValid = true; // "innocent until proven guilty"
            decimal value;
            if (!Decimal.TryParse(tb.Text, out value)) //not an int
            {
                isValid = false;
                MessageBox.Show(name + " has to be a number", "Input error");
                tb.SelectAll();
                tb.Focus();
            }
            else if (value < 0)// cannot be negative
            {
                isValid = false;
                MessageBox.Show(name + " has to positive or zero", "Input error");
                tb.SelectAll();
                tb.Focus();
            }
            return isValid;
        }

        public static string LineEnd { get; set; } = "\n";

        public static string IsPresent(string value, string name)
        {
            string msg = "";
            if (value == "")
            {
                msg += name + " is a required field." + LineEnd;
            }
            return msg;
        }

        public static string IsDecimal(string value, string name)
        {
            string msg = "";
            if (!Decimal.TryParse(value, out _))
            {
                msg += name + " must be a valid decimal value." + LineEnd;
            }
            return msg;
        }

        //public static string IsDateTime(string value)
        //{
        //    string msg = "";
        //    if (String.Format("{0:d}") != value)
        //    {
        //        msg = " must be a valid date format M/d/yyyy .";
        //    }
        //    return msg;
        //}

        // The IsInt32 and IsWithinRange methods were omitted from figure 12-15.
        public static string IsInt32(string value, string name)
        {
            string msg = "";
            if (!Int32.TryParse(value, out _))
            {
                msg += name + " must be a valid integer value." + LineEnd;
            }
            return msg;
        }

        public static string IsDateTime(string tempDate, string name)

        {
            DateTime fromDateValue;
            string msg = "";
            var formats = new[] { "dd/MM/yyyy", "yyyy-MM-dd" };

            if (!DateTime.TryParseExact(tempDate, formats, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out fromDateValue))

            {
                msg += name + " must be a valid data format." + LineEnd;
            }
            return msg;
        }

        public static string IsWithinRange(string value, string name, decimal min,
            decimal max)
        {
            string msg = "";
            if (Decimal.TryParse(value, out decimal number))
            {
                if (number < min || number > max)
                {
                    msg += name + " must be between " + min + " and " + max + "." + LineEnd;
                }
            }
            return msg;
        }

        //public static bool IsBeforeToday(TextBox tbinput, string name)
        //{
        //    bool isValid = true; // "innocent until proven guilty"
        //    if (Convert.ToDateTime(tbinput.Text) > DateTime.Now)
        //    {
        //        isValid = false;
        //        MessageBox.Show(name + " input should be before today", "Input error");
        //        tbinput.Focus();
        //    }
        //    else
        //    {
        //        return isValid;
        //    }
        //}
    }
}