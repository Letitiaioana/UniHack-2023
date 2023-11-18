using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Poriect_Atestat_Info
{
    public partial class Form_Test : Form
    {
        Loadform loadf = new Loadform();

        public static Form_Test instance;
        public static string url = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= " + Application.StartupPath + @"\project_data.mdf;Integrated Security=True;Connect Timeout=30;";

        Random random = new Random();

        List<int> listnumbers = new List<int>();

        int rc = 0; 
        int countsec = 0;
        double countmin = 0;

        int playerScore = 0;

        int q;
        int cnt = 1;
       


        public Form_Test()
        {
            InitializeComponent();
            instance = this;
        }

        public void Askquestion( int n )
        {
            string intr="", r1="", r2 = "", r3 = "";


            SqlConnection con = new SqlConnection(url);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Intrebare, r1,r2,r3,rc FROM Intrebari WHERE IdQ=@id", con);
            cmd.Parameters.AddWithValue("id", n);
            SqlDataReader reader = cmd.ExecuteReader();
            if ( reader.Read() )
            {
                intr = reader[0].ToString().Trim();
                r1 = reader[1].ToString().Trim();
                r2 = reader[2].ToString().Trim();
                r3 = reader[3].ToString().Trim();
                rc = Convert.ToInt32(reader[4].ToString().Trim());
            }
            
            label_question.Text = intr;
            checkBox1.Text = r1;
            checkBox2.Text = r2;
            checkBox3.Text = r3;

            con.Close();
         

            switch ( cnt )
            {
                case 1:
                    label_nrq.Text = "Intrebarea I";
                    break;

                case 2:
                    label_nrq.Text = "Intrebarea II";
                    break;

                case 3:
                    label_nrq.Text = "Intrebarea III";
                    break;

                case 4:
                    label_nrq.Text = "Intrebarea IV";
                    break;

                case 5:
                    label_nrq.Text = "Intrebarea V";
                    break;

                case 6:
                    label_nrq.Text = "Intrebarea VI";
                    break;

                case 7:
                    label_nrq.Text = "Intrebarea VII";
                    break;

                case 8:
                    label_nrq.Text = "Intrebarea VIII";
                    break;

                case 9:
                    label_nrq.Text = "Intrebarea IX";
                    break;

                case 10:
                    label_nrq.Text = "Intrebarea X";
                    break;

                default:
                    MessageBox.Show("Ai raspuns la " + playerScore + " raspunsuri corecte! Felicitari!");
                    loadf.loadform(new Principal_Menu(), Form_start.instance.panelm);
                    break;
                    

            }
        }

        private void Form_Test_Load(object sender, EventArgs e)
        {
            q = random.Next(1, 15);
            listnumbers.Add(q);
            Askquestion(q);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (countsec == 59)
            {
                countmin++;
                countsec = 0;
            }
            else
            {
                countsec++;
            }
            if (countmin < 10)
                label_timer.Text = "0" + countmin + ":" + countsec;
            else
                label_timer.Text = countmin + ":" + countsec;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if ( checkBox1.Checked == true)
            {
                checkBox1.Checked = false;

                if (rc == 1)
                {
                    playerScore++;
                    label_score.Text = playerScore + "/10";
                }

                cnt++;

                do
                {
                    q = random.Next(1, 15);
                } while (listnumbers.Contains(q));
                listnumbers.Add(q);

                Askquestion(q);
            }
            else
            {
                return;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox2.Checked = false;

                if (rc == 2)
                {
                    playerScore++;
                    label_score.Text = playerScore + "/10";
                }

                cnt++;

                do
                {
                    q = random.Next(1, 15);
                } while (listnumbers.Contains(q));
                listnumbers.Add(q);

                Askquestion(q);
            }
            else
            {
                return;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox3.Checked = false;


                if (rc == 3)
                {
                    playerScore++;
                    label_score.Text = playerScore + "/10";
                }

                cnt++;

                do
                {
                    q = random.Next(1, 15);
                } while (listnumbers.Contains(q));
                listnumbers.Add(q);
                Askquestion(q);
            }
            else
            {
                return;
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            loadf.loadform(new Principal_Menu(), Form_start.instance.panelm);
        }
    }
}
