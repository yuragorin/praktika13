using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace studentys
{
    public partial class Form1 : Form
    {
        private List<Student> studentList = new List<Student>();

        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Name", "���");
            dataGridView1.Columns.Add("Surname", "�������");
            dataGridView1.Columns.Add("RecordBookNumber", "����� �������");
        }

        private void AddStudent(string name, string surname, string recordBookNumber)
        {
            studentList.Add(new Student(name, surname, recordBookNumber));
            MessageBox.Show($"������� {name} {surname} ��������.");
            ShowListInGrid();
        }

        private void DeleteStudent(int index)
        {
            studentList.RemoveAt(index);
            ShowListInGrid();
        }

        private void ShowListInGrid()
        {
            dataGridView1.Rows.Clear();
            MessageBox.Show($"���������� ���������: {studentList.Count}");

            foreach (var student in studentList)
            {
                dataGridView1.Rows.Add(student.Name, student.Surname, student.RecordBookNumber);
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {


            string name = txtName.Text.Trim();
            string surname = txtSurname.Text.Trim();
            string recordBookNumber = txtRecordBookNumber.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(surname) ||
                string.IsNullOrWhiteSpace(recordBookNumber))
            {
                MessageBox.Show("����������, ��������� ��� ����.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AddStudent(name, surname, recordBookNumber);

            txtName.Clear();
            txtSurname.Clear();
            txtRecordBookNumber.Clear();
        }

        private void deleteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                DialogResult result = MessageBox.Show("�� �������, ��� ������ ������� ����� ��������?", "������������� ��������", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DeleteStudent(selectedIndex);
                }
            }
            else
            {
                MessageBox.Show("����������, �������� �������� ��� ��������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string RecordBookNumber { get; set; }

        public Student(string name, string surname, string recordBookNumber)
        {
            Name = name;
            Surname = surname;
            RecordBookNumber = recordBookNumber;
        }
    }
}