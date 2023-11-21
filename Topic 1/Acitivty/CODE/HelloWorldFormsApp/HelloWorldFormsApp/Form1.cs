/* 
 * Sari Saiadi
 * CST-150
 * Activity 1
 * 11-21-2023
 * Citations:
 */

namespace HelloWorldFormsApp
{
    //Class
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }
        //Form declartion
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Create an even handler for the click here button
        /// Method name must be pascalCasing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        //Button Click Function
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello World!!!";
        }
        //Label click function
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
