using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using TextBox = System.Windows.Forms.TextBox;
using MySqlX.XDevAPI.Relational;

namespace DBConnectionApplikation
{
    public partial class Form1 : Form
    {
        //Skapa ett MySQLCOnnector object
        MySqlConnection conn;

        TextBox[] txtBoxes;
        TextBox[] txtBoxes2;
        TextBox[] txtBoxes3;

        public Form1()
        {
            InitializeComponent();

            // Bygg upp information för MySQLCOnnection object
            string server = "localhost";
            string database = "mydb";
            string user = "root";
            string pass = "1234";
            //Establera kopplingar till Database
            string connString = $"SERVER={server};DATABASE={database};UID={user};PASSWORD={pass};";
            conn = new MySqlConnection(connString);

            //Skapa en array av textbox, för validering
            txtBoxes = new TextBox[] { txtName, txtAge, txtSibling, txtFunFact, txtNumber};
            txtBoxes2 = new TextBox[] { txtAge2, txtBirthday, txtNumber2};
            txtBoxes3 = new TextBox[] { txtSiblingName, txtSiblingAge, txtNumber3};
        }
        
        private void button1_Click(object sender, EventArgs e)//Insert
        {
            insertToDB();
        }
        
        private void button2_Click(object sender, EventArgs e)//Select
        {
            selectPeopleFromDB();
        }

        private void insertToDB()
        {
            //ValideringsCheck
            bool valid = true;

            //Validering; kontrollera att varje textbox har ett värde
            foreach (TextBox textbox in txtBoxes)
            {
                //Cleanup
                textbox.Text = textbox.Text.Trim();

                //validering
                if (textbox.Text == "")
                {
                    //Validering has failed
                    textbox.BackColor = Color.Red;

                    valid = false;
                } else
                {
                    textbox.BackColor = TextBox.DefaultBackColor;
                }
            }

            //Kontrollerar validerings resultat
            if (!valid) {
                MessageBox.Show("Felaktig inmatning. Kontrollera röda fält.");
                return;
            }

            //Hämta data från textfält
            int number = Convert.ToInt32(txtNumber.Text);
            string name = txtName.Text;
            int age = Convert.ToInt32(txtAge.Text);
            string funfact = txtFunFact.Text;
            string sibling = txtSibling.Text;

            //Bygg upp SQL query
            string SQLquery = $"INSERT INTO people(idPeople, Person_Name, Age, Fun_Fact, Sibling) VALUES ('{number}','{name}','{age}','{funfact}','{sibling}');";
     
            //Skapar ett MySQLCommand objekt
            MySqlCommand cmd = new MySqlCommand(SQLquery, conn);

            //Try/Catch block
            try
            {
                //Öppna koppling till DB
                conn.Open();

                //Exekvera SQL querry
                cmd.ExecuteReader();

                // Bekräftelse till användaren
                MessageBox.Show("Insert finished successfully!");
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            //stänger kopplingen till DB
            conn.Close(); 
        }

        private void selectPeopleFromDB(string keyword = "")
        {
            string SQLquery;

            // Kontrollera om keyword har ett inkommade värde
            if (keyword == "")
            {
                //Skriv query för att hämta alla persons
                SQLquery = $"SELECT * FROM people;";
            }
            else
            {
                //Query för att söka på specifikt namn
                SQLquery = $"SELECT * FROM people WHERE person_name LIKE CONCAT('{keyword}');";
            }

            //Skapar ett MySQLCommand objekt
            MySqlCommand cmd = new MySqlCommand(SQLquery, conn);

            //Try/Catch block
            try
            {
                //Öppna koppling till DB
                conn.Open();

                //Exekvera SQL query
                MySqlDataReader reader = cmd.ExecuteReader();

                //Skriva till Grid
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                gridOutput.DataSource = dataTable;

                //Tömma Persons listan
                People.persons.Clear();

                //Exekvera SQL query
                reader = cmd.ExecuteReader();

                //While Loop för att skriva ut hämtad data
                while (reader.Read())
                {
                    //Hämta specifik data från Reader objekt
                    int id = Convert.ToInt32(reader["idpeople"]);
                    string name = reader["person_name"].ToString();
                    int age = Convert.ToInt32(reader["age"]);
                    string sibling = reader["sibling"].ToString();
                    string funfact = reader["fun_fact"].ToString();

                    //Skapa ett nytt objekt av People och sparar det i statisk lista
                    People.persons.Add(new People(id, name, age, sibling, funfact));
                    //Enable btnUpdate
                    btnDelete.Enabled = true;
                }                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            //stänger kopplingen till DB
            conn.Close();
        }

        private void gridOutput_Click(object sender, EventArgs e)
        {
            getSelectedRow();
        }

        private void getSelectedRow()
        {
            // Validering för att kontrollera att en rad har blivit hämtad
            if (gridOutput.SelectedRows.Count != 1) return;

            //Validering för att kontolerea att vi har lokal data från DB
            if (People.persons.Count == 0) return;

            //Hämtar ID från den markerade raden
            DataGridViewSelectedRowCollection rows = gridOutput.SelectedRows;
            //TODO: COmbine IF statements and add btnUpdate.enabled = false

            //Int vairabel för markerat id
            int id = Convert.ToInt32(rows[0].Cells[0].Value);

            foreach (DataGridViewRow row in rows)
            {
                id = Convert.ToInt32(row.Cells[0].Value);
            }

            foreach (People person in People.persons)
            {
                //Söker efter rätt post i listan
                if (person.Id == id)
                {
                    //Hittat rätt person

                    //Hämta properties från person och skriv in dem i textfält

                    txtBoxes[0].Text = person.Name;
                    txtBoxes[1].Text = person.Age.ToString();
                    txtBoxes[2].Text = person.Sibling;
                    txtBoxes[3].Text = person.FunFact;

                    //Avsluta med break
                    break;
                }
            }
        }

        private void gridOutput_SelectionChanged(object sender, EventArgs e)
        {
            getSelectedRow();
        }

        private void gridOutput_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getSelectedRow();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Anropa SELECTfromDB, med namne-text som parameter
            selectPeopleFromDB( txtName.Text );
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Validering för att kontrollera att en rad är markerad
            if (gridOutput.SelectedRows.Count != 1) return;

            //Int vairabel för markerat id
            int id = 0;

            //Hämtar ID från den markerade raden
            DataGridViewSelectedRowCollection rows = gridOutput.SelectedRows;
            id = Convert.ToInt32(rows[0].Cells[0].Value);

            //Skapa en SQL query
            string SQLQuery = $"DELETE FROM people WHERE idpeople = {id};"; 

            //Skapa ett MySQL Command
            MySqlCommand cmd = new MySqlCommand(SQLQuery, conn);

            //Execute, inside Try/Catch block
            try
            {
                //Öppna kommunimation
                conn.Open();

                //Exekvera command
                cmd.ExecuteReader();

                conn.Close();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            //Hämta data från DB
            selectPeopleFromDB();

            MessageBox.Show("Deleted Successfully!");
        }
        private void selectAgeButton_Click(object sender, EventArgs e)
        {
            selectAgeFromDB();
        }
        private void selectAgeFromDB(string keyword = "")
        {
            string SQLquery;

            // Kontrollera om keyword har ett inkommade värde
            if (keyword == "")
            {
                SQLquery = $"SELECT * FROM age;";
            }
            else
            {
                SQLquery = $"SELECT * FROM age WHERE age LIKE CONCAT('{keyword}');";
            }

            //Skapar ett MySQLCommand objekt
            MySqlCommand cmd = new MySqlCommand(SQLquery, conn);

            //Try/Catch block
            try
            {
                //Öppna koppling till DB
                conn.Open();

                //Exekvera SQL query
                MySqlDataReader reader = cmd.ExecuteReader();

                //Skriva till Grid
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                gridAgeOutput.DataSource = dataTable;

                //Tömma age listan
                People.age.Clear();

                //Exekvera SQL query
                reader = cmd.ExecuteReader();

                //While Loop för att skriva ut hämtad data
                while (reader.Read())
                {
                    //Hämta specifik data från Reader objekt
                    int id = Convert.ToInt32(reader["idage"]);
                    int age = Convert.ToInt32(reader["age"]);
                    string birthday = reader["birthday"].ToString();

                    //Skapa ett nytt objekt av People och sparar det i statisk lista
                    People.age.Add(new People(id, age, birthday));
                    //Enable btnUpdate
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            //stänger kopplingen till DB
            conn.Close();
        }        
        private void buttonAddtoPerson_Click(object sender, EventArgs e)
        {
            //ValideringsCheck
            bool valid = true;

            //Validering; kontrollera att varje textbox har ett värde
            foreach (TextBox textbox in txtBoxes2)
            {
                //Cleanup
                textbox.Text = textbox.Text.Trim();

                //validering
                if (textbox.Text == "")
                {
                    //Validering has failed
                    textbox.BackColor = Color.Red;

                    valid = false;
                }
                else
                {
                    textbox.BackColor = TextBox.DefaultBackColor;
                }
            }

            //Kontrollerar validerings resultat
            if (!valid)
            {
                MessageBox.Show("Felaktig inmatning. Kontrollera röda fält.");
                return;
            }

            //Hämta data från textfält
            int number = Convert.ToInt32(txtNumber2.Text);
            string age = txtAge2.Text;
            string birthday = txtBirthday.Text;

            //Bygg upp SQL query
            string SQLquery = $"INSERT INTO age(idage, Age, Birthday) VALUES ('{number}','{age}','{birthday}');";

            //Skapar ett MySQLCommand objekt
            MySqlCommand cmd = new MySqlCommand(SQLquery, conn);

            //Try/Catch block
            try
            {
                //Öppna koppling till DB
                conn.Open();

                //Exekvera SQL querry
                cmd.ExecuteReader();

                // Bekräftelse till användaren
                MessageBox.Show("Insert finished successfully!");
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
            }
            //stänger kopplingen till DB
            conn.Close();
        }
        private void gridAgeOutput_Click(object sender, DataGridViewCellEventArgs e)
        {
            getSelectedAgeRow();
        }
        private void getSelectedAgeRow()
        {
            // Validering för att kontrollera att en rad har blivit hämtad
            if (gridAgeOutput.SelectedRows.Count != 1) return;

            //Validering för att kontolerea att vi har lokal data från DB
            if (People.age.Count == 0) return;

            //Hämtar ID från den markerade raden
            DataGridViewSelectedRowCollection rows = gridAgeOutput.SelectedRows;
            //TODO: COmbine IF statements and add btnUpdate.enabled = false

            //Int vairabel för markerat id
            int id = Convert.ToInt32(rows[0].Cells[0].Value);

            foreach (DataGridViewRow row in rows)
            {
                id = Convert.ToInt32(row.Cells[0].Value);
            }

            foreach (People age in People.age)
            {
                //Söker efter rätt post i listan
                if (age.Id2 == id)
                {
                    //Hittat rätt age

                    //Hämta properties från age och skriv in dem i textfält
                    txtBoxes[0].Text = age.Age2.ToString();
                    txtBoxes[1].Text = age.Birthday;

                    //Avsluta med break
                    break;
                }
            }
        }
        private void gridSiblingOutput_Click(object sender, DataGridViewCellEventArgs e)
        {
            getSelectedSiblingRow();
        }
        private void getSelectedSiblingRow()
        {
            // Validering för att kontrollera att en rad har blivit hämtad
            if (gridAgeOutput.SelectedRows.Count != 1) return;

            //Validering för att kontolerea att vi har lokal data från DB
            if (People.sibling.Count == 0) return;

            //Hämtar ID från den markerade raden
            DataGridViewSelectedRowCollection rows = gridAgeOutput.SelectedRows;
            //TODO: COmbine IF statements and add btnUpdate.enabled = false

            //Int vairabel för markerat id
            int id = Convert.ToInt32(rows[0].Cells[0].Value);

            foreach (DataGridViewRow row in rows)
            {
                id = Convert.ToInt32(row.Cells[0].Value);
            }

            foreach (People sibling in People.sibling)
            {
                //Söker efter rätt post i listan
                if (sibling.Id3 == id)
                {
                    //Hittat rätt age

                    //Hämta properties från age och skriv in dem i textfält
                    txtBoxes[0].Text = sibling.Sibling_name;
                    txtBoxes[1].Text = sibling.Sibling_age.ToString();

                    //Avsluta med break
                    break;
                }
            }
        }
        private void selectSiblingButton_Click(object sender, EventArgs e)
        {
            selectSiblingFromDB();
        }
        private void selectSiblingFromDB(string keyword = "")
        {
            string SQLquery;

            // Kontrollera om keyword har ett inkommade värde
            if (keyword == "")
            {
                SQLquery = $"SELECT * FROM sibling;";
            }
            else
            {
                SQLquery = $"SELECT * FROM sibling WHERE sibling_name LIKE CONCAT('{keyword}');";
            }

            //Skapar ett MySQLCommand objekt
            MySqlCommand cmd = new MySqlCommand(SQLquery, conn);

            //Try/Catch block
            try
            {
                //Öppna koppling till DB
                conn.Open();

                //Exekvera SQL query
                MySqlDataReader reader = cmd.ExecuteReader();

                //Skriva till Grid
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                gridSiblingOutput.DataSource = dataTable;

                //Tömma age listan
                People.sibling.Clear();

                //Exekvera SQL query
                reader = cmd.ExecuteReader();

                //While Loop för att skriva ut hämtad data
                while (reader.Read())
                {
                    //Hämta specifik data från Reader objekt
                    int id = Convert.ToInt32(reader["idsibling"]);
                    string sibling_name = reader["sibling_name"].ToString();
                    int sibling_age = Convert.ToInt32(reader["sibling_age"]);
                    
                    //Skapa ett nytt objekt av People och sparar det i statisk lista
                    People.sibling.Add(new People(id, sibling_name, sibling_age));
                    //Enable btnUpdate
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            //stänger kopplingen till DB
            conn.Close();
        }
        private void buttonAddtoPerson2_Click(object sender, EventArgs e)
        {
            //ValideringsCheck
            bool valid = true;

            //Validering; kontrollera att varje textbox har ett värde
            foreach (TextBox textbox in txtBoxes3)
            {
                //Cleanup
                textbox.Text = textbox.Text.Trim();

                //validering
                if (textbox.Text == "")
                {
                    //Validering has failed
                    textbox.BackColor = Color.Red;

                    valid = false;
                }
                else
                {
                    textbox.BackColor = TextBox.DefaultBackColor;
                }
            }

            //Kontrollerar validerings resultat
            if (!valid)
            {
                MessageBox.Show("Felaktig inmatning. Kontrollera röda fält.");
                return;
            }

            //Hämta data från textfält
            int number = Convert.ToInt32(txtNumber3.Text);
            string sibling_name = txtSiblingName.Text;
            int sibling_age = Convert.ToInt32(txtSiblingAge.Text);

            //Bygg upp SQL query
            string SQLquery = $"INSERT INTO sibling(idsibling, Sibling_Name, Sibling_Age) VALUES ('{number}','{sibling_name}','{sibling_age}');";

            //Skapar ett MySQLCommand objekt
            MySqlCommand cmd = new MySqlCommand(SQLquery, conn);

            //Try/Catch block
            try
            {
                //Öppna koppling till DB
                conn.Open();

                //Exekvera SQL querry
                cmd.ExecuteReader();

                // Bekräftelse till användaren
                MessageBox.Show("Insert finished successfully!");
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.Message);
            }
            //stänger kopplingen till DB
            conn.Close();
        }
        private void GetAgeData(int id)
        {
            //Anropa DB med person-id som parameter
            //Bygg upp SQL query
            string SQLQuery = $"CALL getAgeByPerson({id});";

            //Skapa ett MySQLCommand objekt
            MySqlCommand cmd = new MySqlCommand(SQLQuery, conn);

            try
            {
                //Öppna connection till DB
                conn.Open();

                //Exekvera sql query
                MySqlDataReader reader = cmd.ExecuteReader();

                //Skapa en DataTable för att sedan placera den i gridAgeOutput
                DataTable dt = new DataTable();
                dt.Load(reader);
                gridAgeOutput.DataSource = dt;

                //Stäng connection
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
