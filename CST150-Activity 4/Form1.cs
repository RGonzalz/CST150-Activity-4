namespace CST150_Activity_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_count_Click(object sender, EventArgs e)
        {
            int seconds = 0; //designated measured times
            int minutes;
            int hours;
            int days;

            seconds = int.Parse(txt_inputSec.Text);


            //if loop to cicle through values between 60 to 3599 seconds
            if (seconds >= 60 && seconds <= 3599) 
            {
                minutes = seconds / 60;
                txt_min.Text = minutes.ToString();
            }

            //if else, seconds between 3600 and 86399 become hours
            else if (seconds >= 3600 && seconds <= 86399) 
            {
                hours = seconds / 3600;
                txt_hrs.Text = hours.ToString();
            }

            //if else, anything greater than 86400 become days
            else if (seconds >= 86400)
            {
                days = seconds / 86400;
                txt_days.Text = days.ToString();
            }
            else
            {
                MessageBox.Show("Invalid Entery, Please try again", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}