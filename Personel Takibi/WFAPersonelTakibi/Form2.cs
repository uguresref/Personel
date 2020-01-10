using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace WFAPersonelTakibi
{
    public partial class Form2 : MetroForm
    {
        private IService<Employee> _employeeService;
        private IService<Department> _departmentService;
        public Form2()
        {
            InitializeComponent();
            _employeeService = new EmployeeService();
        }

        void PersonelListesi()
        {
            dgvEmployees.DataSource = _employeeService.GetAll();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Ad.HeaderText= Form1.ad;
            Soyad.DataPropertyName = Form1.soyad;
            Telefon.ToolTipText = Form1.tel;
            Mail.ToolTipText = Form1.mail;
            Adres.ToolTipText = Form1.adres;
            DoğumTarihi.ToolTipText= Form1.birth;
        }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_DoubleClick(object sender, EventArgs e)
        {
          
        }

        private void Form2_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            this.Hide();
        }
    }
}
