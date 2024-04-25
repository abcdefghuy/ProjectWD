using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class StatisticForm : Form
    {
        private Dictionary<string, Dictionary<string, double>> GetDaTaByCategory = new Dictionary<string, Dictionary<string, double>>();
        private static string id;
        public static string ID { get => id; set => id = value; }
        public StatisticForm()
        {
            InitializeComponent();
            guna2VScrollBar1.BindingContainer = dgvStatistic;
            guna2VScrollBar1.AutoScroll = true;
            GetDaTaByCategory.Add("Da Lam", new Dictionary<string, double>());
            GetDaTaByCategory.Add("Doanh Thu", new Dictionary<string, double>());
            dgvStatistic.DataSource = WorkerDAO.loadsoluong(ID);
        }

        private double GetDataForCateGory(string category, string month)
        {
            if (GetDaTaByCategory.ContainsKey(category) && GetDaTaByCategory[category].ContainsKey(month))
            {
                return GetDaTaByCategory[category][month];
            }
            return 0;
        }
        private void UpdateChartDataAndChartRevenue()
        {
            gunaChart1.Hide();
            gunaChart2.Show();
            var charts =  cDoanhThu;

            // Xóa dữ liệu cũ của biểu đồ
            charts.DataPoints.Clear();

            double totalSum = 0.0;

            foreach (DataGridViewRow row in dgvStatistic.Rows)
            {
                var cellValue = row.Cells[1].Value;
                if (cellValue != null)
                {
                    if (double.TryParse(cellValue.ToString(), out double value))
                    {
                        string monthName = row.Cells[0].Value.ToString();
                        charts.DataPoints.Add(monthName, value);
                        totalSum += value;
                    }
                }
            }

            gunaChart2.Update();

            // Cập nhật tổng tùy thuộc vào loại dữ liệu

            doanhthuSum = totalSum;
            

            
            lblDoanhThu.Text = doanhthuSum.ToString();
        }
        private void UpdateChartDataAndChart()
        {
            gunaChart2.Hide();
            gunaChart1.Show();
            var charts = cSoluongKhach;

            // Xóa dữ liệu cũ của biểu đồ
            charts.DataPoints.Clear();

            double totalSum = 0.0;

            foreach (DataGridViewRow row in dgvStatistic.Rows)
            {
                var cellValue = row.Cells[1].Value;
                if (cellValue != null)
                {
                    if (double.TryParse(cellValue.ToString(), out double value))
                    {
                        string monthName = row.Cells[0].Value.ToString();
                        charts.DataPoints.Add(monthName, value);
                        totalSum += value;
                    }
                }
            }

            gunaChart1.Update();

            // Cập nhật tổng tùy thuộc vào loại dữ liệu
            
            dalamSum = totalSum;
                  

            lblDalam.Text = dalamSum.ToString();
           
        }
        private double dalamSum = 0.0;
        private double doanhthuSum = 0.0;


        

        private void StatisticForm_Load(object sender, EventArgs e)
        {
            UpdateChartDataAndChart();
        }

        private void guna2ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectComboboxItem = guna2ComboBox1.Text;
            if (guna2ComboBox1.Text == "Da Lam")
            {
                dgvStatistic.DataSource = WorkerDAO.loadsoluong(ID);
                UpdateChartDataAndChart();
            }
            else
            {
                dgvStatistic.DataSource = WorkerDAO.loadSoTien(ID);
                UpdateChartDataAndChartRevenue();
            }
        }
    }
}
