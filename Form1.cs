using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private const string V1 = @"save";

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            if (InternetCheck.isInternet())
            {
                GetAllStudent();
            }
            else
            {
                MessageBox.Show("Please check your Internet connection !!!", caption: "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
         
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            if (NametextBox.Text == string.Empty)
            {
                MessageBox.Show("Please Enter all Information", caption: "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else if (RegistrationtextBox.Text == string.Empty)
            {
                MessageBox.Show("Please Enter all Information", caption: "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (MobileNotextBox4.Text == string.Empty)
            {
                MessageBox.Show("Please Enter all Information", caption: "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                Student student = new Student();
                student.name = NametextBox.Text;
                student.registrationNO = RegistrationtextBox.Text;
                student.mobileNo = MobileNotextBox4.Text;
                student.departmentName = DepartmenttextBox5.Text;
                student.address = AddresstextBox3.Text;
                student.Id = Idlabel.Text;
                

                IFirebaseConfig firebaseConfig = new FirebaseConfig()
                {
                    AuthSecret = "0q034wxR0p8grjvFHJtPzXLmMhlTNH3yrgrqlAEf",
                    BasePath = "https://crudforms.firebaseio.com/"
                };
                IFirebaseClient client = new FirebaseClient(firebaseConfig);
                if (InternetCheck.isInternet())
                {

                    if (Save.Text == @"Save")
                    {
                        PushResponse message = await client.PushAsync("StudentList", student);
                        if (message != null)
                        {
                            MessageBox.Show("Student Saved Successfully.", caption: "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Reset();
                            GetAllStudent();


                        }
                        else
                        {
                            MessageBox.Show("Student doesn't saved.", caption: "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (Save.Text == @"Update")
                    {
                        var message = await client.UpdateAsync("StudentList/" + student.Id, student);
                        if (message != null)
                        {
                            MessageBox.Show("Student Updated Successfully.", caption: "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Reset();
                            GetAllStudent();
                            Save.Text = "Save";


                        }
                        else
                        {
                            MessageBox.Show("Student doesn't Updated.", caption: "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please check your Internet connection !!!", caption: "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }

            }
        }

        private void Reset()
        {
            NametextBox.Clear();
            RegistrationtextBox.Clear();
            AddresstextBox3.Clear();
            MobileNotextBox4.Clear();
            DepartmenttextBox5.Clear();
            Deletebutton.Enabled = false;
        }

       public async void GetAllStudent()
        {
            IFirebaseConfig firebaseConfig = new FirebaseConfig()
            {
                AuthSecret = "0q034wxR0p8grjvFHJtPzXLmMhlTNH3yrgrqlAEf",
                BasePath = "https://crudforms.firebaseio.com/"
            };
            IFirebaseClient client = new FirebaseClient(firebaseConfig);
            var data = await client.GetAsync("StudentList");

            if (data.Body!="null")
            {
                Dictionary<string, Student> studentList = data.ResultAs<Dictionary<string, Student>>();

                foreach (var students in studentList)
                {
                    StudentdataGridView.Rows.Add(students.Key, students.Value.name, students.Value.registrationNO, students.Value.mobileNo,
                        students.Value.address, students.Value.departmentName);
                }
            }
        }


        private  void StudentdataGridView_DoubleClick_1(object sender, EventArgs e)
        {
            try
            {

                Idlabel.Text = StudentdataGridView.SelectedCells[0].Value.ToString();
                NametextBox.Text = StudentdataGridView.SelectedCells[1].Value.ToString();
                RegistrationtextBox.Text = StudentdataGridView.SelectedCells[2].Value.ToString();
                MobileNotextBox4.Text = StudentdataGridView.SelectedCells[3].Value.ToString();
                AddresstextBox3.Text = StudentdataGridView.SelectedCells[4].Value.ToString();
                DepartmenttextBox5.Text = StudentdataGridView.SelectedCells[5].Value.ToString();
                Save.Text = "Update";
                Deletebutton.Enabled = true;
            }
            catch (Exception)
            {

            }

        }

        private void StudentdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StudentdataGridView_DoubleClick(object sender, EventArgs e)
        {
          
            



        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {

        }

        private async void Deletebutton_Click(object sender, EventArgs e)
        {
            IFirebaseConfig firebaseConfig = new FirebaseConfig()
            {
                AuthSecret = "0q034wxR0p8grjvFHJtPzXLmMhlTNH3yrgrqlAEf",
                BasePath = "https://crudforms.firebaseio.com/"
            };
            IFirebaseClient client = new FirebaseClient(firebaseConfig);
            Idlabel.Text = StudentdataGridView.SelectedCells[0].Value.ToString();
            string id = Idlabel.Text;

            var message = await client.DeleteAsync("StudentList/" +id);
                if (message.StatusCode.ToString()=="OK")
                {
                    MessageBox.Show("Student Deleted Successfully.", caption: "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                    GetAllStudent();
                    Save.Text = "Save";


                }
            }
    }
}
