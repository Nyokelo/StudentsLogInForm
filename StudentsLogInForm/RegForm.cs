using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using DataAccess;
using StudentsLogInForm.Models;

namespace StudentsLogInForm
{
    public partial class RegForm : Form
    {
        public static RegForm Instance { get; set; } = new RegForm();
        public RegForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void RegForm_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
        }
        private void LoadComboBoxes()
        {
            var countiesPath = Path.GetFullPath("Json/County.json");
            var genderPath = Path.GetFullPath("Json/Gender.json");
            var cityPath = Path.GetFullPath("Json/City.json");

            var countiesContent = File.ReadAllText(countiesPath);
            var genderContent = File.ReadAllText(genderPath);
            var cityContent = File.ReadAllText(cityPath);

            var counties = JsonSerializer.Deserialize<List<County>>(countiesContent);
            var genders = JsonSerializer.Deserialize<List<Gender>>(genderContent);
            var cities = JsonSerializer.Deserialize<List<City>>(cityContent);


            foreach (var county in counties)
            {
                comboCounty.Items.Add(county.Name);
            }
            foreach (var gender in genders)
            {
                comboGender.Items.Add(gender.Name);
            }
            foreach (var city in cities)
            {
                comboCity.Items.Add(city.Name);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var success = SqlManager.SaveStudentToDatabase(CreateStudent());
            if (success)
            {
                MessageBox.Show("student saved successfully", "save student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private Student CreateStudent() => new Student {
            Admin = txtAdmin.Text.Trim(),
            City = comboCity.SelectedItem.ToString(),
            County = comboCounty.SelectedItem.ToString(),
            FirstName = txtFirstName.Text.Trim(),
            Gender = comboGender.SelectedItem.ToString(),
            LastName = txtLastName.Text.Trim(),
            MobileNumber = txtMobileNumber.Text.Trim()
        };
        private void comboGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
