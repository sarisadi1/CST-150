/*
 * Sari Saiadi
 * CST-150
 * Activity three (Earth weight to mars)
 * 11-21-2023
 * Citations here
 */
namespace EarthWeightToMars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Hide the Weight on Mars labels
            lblMars.Visible = false;
            lblMarsWeight.Visible = false;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Click Even for Convert Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConvertButtonClickEvent(object sender, EventArgs e)
        {
            //Decalre and Initialize
            decimal earthWeight = 0.0M;
            decimal finalValue = 0.0M;
            decimal gravAccEarth = 9.81M;
            decimal gravAccMars = 3.711M;

            //Read in the earth weight
            earthWeight=Convert.ToDecimal(txtEarthWeight.Text);

            //Calculate the final value
            finalValue = (earthWeight / gravAccEarth) * gravAccMars;

            //Display the results
            //Use String.format to format the string and show only 2 decimal places.
            //This is a string argument
            lblMarsWeight.Text = string.Format("{0:.##} lbs", finalValue);


            //Make sure to show the mars value and label
            lblMars.Visible = true;
            lblMarsWeight.Visible=true;



        }
    }
}
