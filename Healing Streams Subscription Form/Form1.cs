using System.Data.SqlClient;

namespace Healing_Streams_Subscription_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_Save_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N0LOUUT;Initial Catalog=Healing_School_Sub;Integrated Security=True");


            SqlCommand cmd = new SqlCommand("StoredProceduresHealth", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@firstname", txt_FirstName.Text.ToString());
            cmd.Parameters.AddWithValue("@lastname", txt_LastName.Text.ToString());
            cmd.Parameters.AddWithValue("@mobileno", txt_MobileNo.Text.ToString());
            cmd.Parameters.AddWithValue("@emailaddress", txt_EmailAddress.Text.ToString());
            cmd.Parameters.AddWithValue("@audioconfessions", txt_AudioConfessions.Checked);
            cmd.Parameters.AddWithValue("@healthylivingbooks", txt_HealingLivingBooks.Checked);
            cmd.Parameters.AddWithValue("@newsletters", txt_Newsletters.Checked);
            cmd.Parameters.AddWithValue("@partnershipopportunities", txt_PartnershipOpportunities.Checked);
            cmd.Parameters.AddWithValue("@programnotification", txt_ProgramNotifications.Checked);
            cmd.Parameters.AddWithValue("@healingschoolmagazine", txt_HealingMagazine.Checked);
            cmd.Parameters.AddWithValue("@password", txt_Password.Text.ToString());
            conn.Open();
            try
            {

                int i = cmd.ExecuteNonQuery();
                MessageBox.Show("Welcome Esteemed Partner");
            }
            catch
            {
                MessageBox.Show("Error");
            }
            conn.Close();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_HealingLivingBooks_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}