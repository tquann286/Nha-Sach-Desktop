using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Nha_Sach_Desktop.BUS;
using Nha_Sach_Desktop.DTO;

namespace Nha_Sach_Desktop.UI
{
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-1TEJ4NIL;Initial Catalog=BatOnBookStore;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT HOADON.mahd, HOADON.makh, HOADON.tenkh, HOADON.ngaylap, HOADON.tongtien, PHIEUBAN.masach, PHIEUBAN.soluong\r\nFROM HOADON\r\nJOIN PHIEUBAN ON HOADON.mahd = PHIEUBAN.maphieuban;", conn);
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM SACH", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
            SqlDataReader reader = cmd1.ExecuteReader();

            while (reader.Read())
            {
                string value = reader["masach"].ToString();
                comboBox1.Items.Add(value);
            }
           

            reader.Close();
            conn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedmasach = comboBox1.SelectedItem.ToString();

            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-1TEJ4NIL;Initial Catalog=BatOnBookStore;Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT tensach FROM SACH WHERE masach = @Masach", conn);
            cmd.Parameters.AddWithValue("@Masach", selectedmasach);
            string tensach = cmd.ExecuteScalar()?.ToString();

            conn.Close();

            textBox1.Text = tensach;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DTOHoaDon dTOHoaDon = new DTOHoaDon();
            BUSHoaDon bUSHoa = new BUSHoaDon();
            dTOHoaDon.Mahd = textBox5.Text;
            dTOHoaDon.Masach = comboBox1.SelectedValue.ToString();

        }
    }
}
