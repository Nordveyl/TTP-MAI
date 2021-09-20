using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Зачёт
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Zachet"].ConnectionString);

            sqlConnection.Open();

            if (sqlConnection.State == ConnectionState.Open)
            {
                MessageBox.Show("Подключение установлено!"); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand command = new SqlCommand(
                    $"INSERT INTO Students(Name, Surname, Birthday, Phone, email, Residence_address) VALUES(N'{textBox1.Text}', N'{textBox2.Text}', '{textBox3.Text}', '{textBox4.Text}', '{textBox5.Text}', N'{textBox6.Text}')",
                    sqlConnection);

                MessageBox.Show(command.ExecuteNonQuery().ToString(), "ученик добавлен в базу");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Введите дату в формате: мм/дд/гггг");


            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(
               $"INSERT INTO AcademicPerformance (Name, Surname, Mathematics, Russian, Literature, History, Geography, English) VALUES(N'{textBox8.Text}', N'{textBox9.Text}', '{textBox10.Text}', '{textBox11.Text}', '{textBox12.Text}', '{textBox13.Text}', '{textBox14.Text}', '{textBox15.Text}')",
               sqlConnection);

            MessageBox.Show(command.ExecuteNonQuery().ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT Name AS 'Имя', Surname as 'Фамилия', Mathematics as 'Математика', Russian as 'Русский', Literature as 'Литература', History as 'История', Geography as 'География', English as 'Английский' FROM AcademicPerformance", sqlConnection);

            DataSet dataSet2 = new DataSet();

            dataAdapter.Fill(dataSet2);

            dataGridView2.DataSource = dataSet2.Tables[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT AVG(Mathematics) AS N'Средняя оценка по классу' FROM AcademicPerformance", sqlConnection);

            DataSet dataSet3 = new DataSet();

            dataAdapter.Fill(dataSet3);

            dataGridView3.DataSource = dataSet3.Tables[0];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT AVG(Russian) AS N'Средняя оценка по классу' FROM AcademicPerformance", sqlConnection);

            DataSet dataSet4 = new DataSet();

            dataAdapter.Fill(dataSet4);

            dataGridView3.DataSource = dataSet4.Tables[0];
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT AVG(Literature) AS N'Средняя оценка по классу' FROM AcademicPerformance", sqlConnection);

            DataSet dataSet5 = new DataSet();

            dataAdapter.Fill(dataSet5);

            dataGridView3.DataSource = dataSet5.Tables[0];
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT AVG(History) AS N'Средняя оценка по классу' FROM AcademicPerformance", sqlConnection);

            DataSet dataSet6 = new DataSet();

            dataAdapter.Fill(dataSet6);

            dataGridView3.DataSource = dataSet6.Tables[0];
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT AVG(Geography) AS N'Средняя оценка по классу' FROM AcademicPerformance", sqlConnection);

            DataSet dataSet7 = new DataSet();

            dataAdapter.Fill(dataSet7);

            dataGridView3.DataSource = dataSet7.Tables[0];
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT AVG(English) AS N'Средняя оценка по классу' FROM AcademicPerformance", sqlConnection);

            DataSet dataSet8 = new DataSet();

            dataAdapter.Fill(dataSet8);

            dataGridView3.DataSource = dataSet8.Tables[0];
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT MAX(Mathematics) as 'Максимальная оценка по предмету', MIN(Mathematics) as 'Минимальная оценка по предмету' FROM AcademicPerformance", sqlConnection);

            DataSet dataSet9 = new DataSet();

            dataAdapter.Fill(dataSet9);

            dataGridView3.DataSource = dataSet9.Tables[0];
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT MAX(Russian) as 'Максимальная оценка по предмету', MIN(Russian) as 'Минимальная оценка по предмету' FROM AcademicPerformance", sqlConnection);

            DataSet dataSet10 = new DataSet();

            dataAdapter.Fill(dataSet10);

            dataGridView3.DataSource = dataSet10.Tables[0];
        }

        private void button13_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT MAX(Literature) as 'Максимальная оценка по предмету', MIN(Literature) as 'Минимальная оценка по предмету' FROM AcademicPerformance", sqlConnection);

            DataSet dataSet11 = new DataSet();

            dataAdapter.Fill(dataSet11);

            dataGridView3.DataSource = dataSet11.Tables[0];
        }

        private void button14_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT MAX(History) as 'Максимальная оценка по предмету', MIN(History) as 'Минимальная оценка по предмету' FROM AcademicPerformance", sqlConnection);

            DataSet dataSet12 = new DataSet();

            dataAdapter.Fill(dataSet12);

            dataGridView3.DataSource = dataSet12.Tables[0];
        }

        private void button15_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT MAX(Geography) as 'Максимальная оценка по предмету', MIN(Geography) as 'Минимальная оценка по предмету' FROM AcademicPerformance", sqlConnection);

            DataSet dataSet12 = new DataSet();

            dataAdapter.Fill(dataSet12);

            dataGridView3.DataSource = dataSet12.Tables[0];
        }

        private void button16_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT MAX(English) as 'Максимальная оценка по предмету', MIN(English) as 'Минимальная оценка по предмету' FROM AcademicPerformance", sqlConnection);

            DataSet dataSet13 = new DataSet();

            dataAdapter.Fill(dataSet13);

            dataGridView3.DataSource = dataSet13.Tables[0];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Students", sqlConnection);

            DataSet dataSet14 = new DataSet();

            dataAdapter.Fill(dataSet14);

            dataGridView4.DataSource = dataSet14.Tables[0];
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       
    }
}
