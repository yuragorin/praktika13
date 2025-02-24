using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace studenti2
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Car> carDictionary = new Dictionary<string, Car>();

        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Brand", "�����");
            dataGridView1.Columns.Add("Model", "������");
            dataGridView1.Columns.Add("Year", "��� �������");
            dataGridView1.Columns.Add("Color", "����");
            dataGridView1.Columns.Add("VIN", "VIN-���");
        }

        private void AddCar(string brand, string model, int year, string color, string vin)
        {
            if (!carDictionary.ContainsKey(vin))
            {
                carDictionary.Add(vin, new Car(brand, model, year, color, vin));
                ShowCarsInGrid();
            }
            else
            {
                MessageBox.Show("���������� � ����� VIN-����� ��� ����������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteCar(string vin)
        {
            if (carDictionary.ContainsKey(vin))
            {
                carDictionary.Remove(vin);
                ShowCarsInGrid();
            }
        }

        private void ShowCarsInGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (var car in carDictionary.Values)
            {
                dataGridView1.Rows.Add(car.Brand, car.Model, car.Year, car.Color, car.VIN);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string brand = txtBrand.Text.Trim();
            string model = txtModel.Text.Trim();
            int year;
            if (!int.TryParse(txtYear.Text.Trim(), out year))
            {
                MessageBox.Show("��� ������� ������ ���� ������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string color = txtColor.Text.Trim();
            string vin = txtVIN.Text.Trim();

            if (string.IsNullOrWhiteSpace(brand) ||
                string.IsNullOrWhiteSpace(model) ||
                string.IsNullOrWhiteSpace(color) ||
                string.IsNullOrWhiteSpace(vin))
            {
                MessageBox.Show("����������, ��������� ��� ����.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AddCar(brand, model, year, color, vin);

            // ������� ��������� ����
            txtBrand.Clear();
            txtModel.Clear();
            txtYear.Clear();
            txtColor.Clear();
            txtVIN.Clear();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string selectedVIN = dataGridView1.SelectedRows[0].Cells["VIN"].Value.ToString();
                DialogResult result = MessageBox.Show("�� �������, ��� ������ ������� ���� ����������?", "������������� ��������", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DeleteCar(selectedVIN);
                }
            }
            else
            {
                MessageBox.Show("����������, �������� ���������� ��� ��������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public string VIN { get; set; }

        public Car(string brand, string model, int year, string color, string vin)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Color = color;
            VIN = vin;
        }
    }
}