using System;
using System.Windows.Forms;

namespace WindowsFormsPractice
{
    /// <summary>
    ///     A basic calculator form
    /// </summary>
    public partial class Form1 : Form
    {

        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        #endregion


        #region Operator Methods
        /// <summary>
        /// Adds the Divides character ( '/' ) to the text at the currently selection possition
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void Divide_Button_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("/");

            //Focus the user input text
            FocusInputText();
        }
       
        /// <summary>
        /// Adds the Multiply character ( '*' ) to the text at the currently selection possition
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void Multiply_Button_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("*");

            //Focus the user input text
            FocusInputText();
        }
        
        /// <summary>
        /// Adds the Minus character ( '-' ) to the text at the currently selection possition
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void Minus_Button_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("-");

            //Focus the user input text
            FocusInputText();
        }
        
        /// <summary>
        /// Adds the Plus character ( '+' ) to the text at the currently selection possition
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void Plus_Button_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("+");

            //Focus the user input text
            FocusInputText();
        }
        
        /// <summary>
        /// Calculates the given equation in the user input text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void Equals_Button_Click(object sender, EventArgs e)
        {
            //Calculate the equation
            CalculateEquation();

            //Focus the user input text
            FocusInputText();
        }

        #endregion


        #region Number Methods

        /// <summary>
        /// Adds the Dot character ( '.' ) to the text at the currently selection possition
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void Dot_Button_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue(".");

            //Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Adds the Zero character ( '0' ) to the text at the currently selection possition
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void Zero_Button_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("0");

            //Focus the user input text
            FocusInputText();

        }

        /// <summary>
        /// Adds the One character ( '1' ) to the text at the currently selection possition
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void One_Button_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("1");

            //Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Adds the Two character ( '2' ) to the text at the currently selection possition
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void Two_Button_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("2");

            //Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Adds the Three character ( '3' ) to the text at the currently selection possition
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void Three_Button_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("3");

            //Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Adds the Four character ( '4' ) to the text at the currently selection possition
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void Four_Button_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("4");

            //Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Adds the Five character ( '5' ) to the text at the currently selection possition
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void Five_Button_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("5");

            //Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Adds the Six character ( '6' ) to the text at the currently selection possition
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void Six_Button_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("6");

            //Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Adds the Seven character ( '7' ) to the text at the currently selection possition
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void Seven_Button_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("7");

            //Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Adds the Eight character ( '8' ) to the text at the currently selection possition
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void Eight_Button_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("8");

            //Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Adds the Nine character ( '9' ) to the text at the currently selection possition
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void Nine_Button_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("9");

            //Focus the user input text
            FocusInputText();
        }
        #endregion


        #region Clearing Methods
        /// <summary>
        /// Clears the user input text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void CE_Button_Click(object sender, EventArgs e)
        {
            //Clears the text from the user input text box
            this.UserInputText.Text = string.Empty;

            //Focus the user input text
            FocusInputText();
        }
        /// <summary>
        /// Deletes the first character in front of the cursor
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void DELETE_Button_Click(object sender, EventArgs e)
        {
            //Delete the value after the selection position
            DeleteTextValue();

            //Focus the user input text
            FocusInputText();
        }
        #endregion


        /// <summary>
        /// Calculates the given equation and outputs the answer to the user label
        /// </summary>
        private void CalculateEquation()
        {
            
            FocusInputText();
        }


        #region Private Helpers
        /// <summary>
        /// Focuses the user input text
        /// </summary>
        private void FocusInputText()
        {
            this.UserInputText.Focus();
        }

        /// <summary>
        /// Inserts the given text into the user text box
        /// </summary>
        /// <param name="str">The value to insert</param>
        private void InsertTextValue(string value)
        {
            //Remember selection start
            var selectionstart = this.UserInputText.SelectionStart;

            //Set new text
            this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.SelectionStart,value);

            //Restore the selection start
            this.UserInputText.SelectionStart = selectionstart + value.Length;

            //Set selection length to zero
            this.UserInputText.SelectionLength = 0;
        }
       
        /// <summary>
        /// Deletes the character to the right of the selection start of the user text box
        /// </summary>
        /// <param name="str">The value to insert</param>
        private void DeleteTextValue()
        {
            // If we don't have a value to delete,return
            if (this.UserInputText.Text.Length < this.UserInputText.SelectionStart + 1)
                return;

            //Remember selection start
            var selectionstart = this.UserInputText.SelectionStart;

            //Delete the character to the right of the selection
            this.UserInputText.Text = this.UserInputText.Text.Remove(this.UserInputText.SelectionStart, 1);
           
            //Restore the selection start
            this.UserInputText.SelectionStart = selectionstart;
            
            //Set selection length to zero
            this.UserInputText.SelectionLength = 0;
        }

        #endregion
    }
}
