using MetroFramework.Forms;
using System;

namespace WFAPersonelTakibi
{
    public partial class Form1 : MetroForm
    {
        private IService<Employee> _employeeService;
        public Form1()
        {
            InitializeComponent(); 
            _employeeService = new EmployeeService();
        }

        public static string ad, soyad, mail, tel, birth, adres;

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {

        }

        //txtFirstName.Text = param;
        //txtLastName.Text = param;
        //txtAddress.Text = param;
        //txtMail.Text = param;
        //txtPhone.Text = param;
        //dtBirthDate.Text = param;


        private void btnSave_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            
            employee.FirstName = txtFirstName.Text;
            employee.LastName = txtLastName.Text;
            employee.Mail = txtMail.Text;
            employee.Phone = txtPhone.Text;
            employee.BirthDate = dtBirthDate.Value;
            employee.Address = txtAddress.Text;
            //employee.Department = cmbDepartment.Text.ToString();
            //employee.Gender = rdRandom.Text;

            ad = txtFirstName.Text;
            soyad = txtLastName.Text;
            mail = txtMail.Text;
            birth = dtBirthDate.Text;
            tel = txtPhone.Text;
            adres = txtAddress.Text;


            //Department department = new Department();
            //department = cmbDepartment.Text;


            _employeeService.Add(employee);
            Form2 frm = new Form2();
            frm.Show();




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
