using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using System.Windows.Forms;

namespace UserCRUDApp
{
    public partial class lab : Form
    {
        HttpClient client = new HttpClient();
        string baseUrl = "https://dummy-user-api-omega.vercel.app/api/users";

        public lab()
        {
            InitializeComponent();
        }

        // READ MANY 
        private async void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                var response = await client.GetStringAsync(baseUrl);
                var result = JsonConvert.DeserializeObject<ApiResponse>(response);

                dataGridView1.DataSource = result.data;

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.ReadOnly = true;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                dataGridView1.Columns["id"].HeaderText = "ID";
                dataGridView1.Columns["name"].HeaderText = "Nama";
                dataGridView1.Columns["saldo"].HeaderText = "Saldo";
                dataGridView1.Columns["hutang"].HeaderText = "Hutang";
                dataGridView1.Columns["netWorth"].HeaderText = "Net Worth";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // READ ONE 
        private async void btnGet_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtId.Text;

                var response = await client.GetStringAsync(baseUrl + "/" + id);
                var result = JsonConvert.DeserializeObject<ApiResponse>(response);

                if (result.data != null && result.data.Count > 0)
                {
                    var user = result.data[0];
                    txtName.Text = user.name;
                    txtSaldo.Text = user.saldo.ToString();
                    txtHutang.Text = user.hutang.ToString();
                    txtNetWorth.Text = user.netWorth.ToString();
                }
                else
                {
                    MessageBox.Show("Data tidak ditemukan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // CREATE 
        private async void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "" || txtSaldo.Text == "" || txtHutang.Text == "")
                {
                    MessageBox.Show("Semua field harus diisi!");
                    return;
                }

                var user = new User
                {
                    name = txtName.Text,
                    saldo = long.Parse(txtSaldo.Text),
                    hutang = long.Parse(txtHutang.Text)
                };

                var json = JsonConvert.SerializeObject(user);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                await client.PostAsync(baseUrl, content);

                MessageBox.Show("Data berhasil ditambahkan!");

                txtId.Clear();
                txtName.Clear();
                txtSaldo.Clear();
                txtHutang.Clear();
                txtNetWorth.Clear();

                btnLoad_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // UPDATE 
        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == "")
                {
                    MessageBox.Show("Pilih data dulu!");
                    return;
                }

                if (txtName.Text == "" || txtSaldo.Text == "" || txtHutang.Text == "")
                {
                    MessageBox.Show("Semua field harus diisi!");
                    return;
                }

                string id = txtId.Text;

                var user = new User
                {
                    name = txtName.Text,
                    saldo = long.Parse(txtSaldo.Text),
                    hutang = long.Parse(txtHutang.Text)
                };

                var json = JsonConvert.SerializeObject(user);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                await client.PutAsync(baseUrl + "/" + id, content);

                MessageBox.Show("Data berhasil diupdate!");

                txtId.Clear();
                txtName.Clear();
                txtSaldo.Clear();
                txtHutang.Clear();
                txtNetWorth.Clear();

                btnLoad_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //  DELETE 
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == "")
                {
                    MessageBox.Show("Pilih data dulu!");
                    return;
                }

                string id = txtId.Text;

                await client.DeleteAsync(baseUrl + "/" + id);

                MessageBox.Show("Data berhasil dihapus!");

                txtId.Clear();
                txtName.Clear();
                txtSaldo.Clear();
                txtHutang.Clear();
                txtNetWorth.Clear();

                btnLoad_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // DATAGRID CLICK 
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    var row = dataGridView1.Rows[e.RowIndex];

                    txtId.Text = row.Cells["id"].Value?.ToString() ?? "";
                    txtName.Text = row.Cells["name"].Value?.ToString() ?? "";
                    txtSaldo.Text = row.Cells["saldo"].Value?.ToString() ?? "";
                    txtHutang.Text = row.Cells["hutang"].Value?.ToString() ?? "";
                    txtNetWorth.Text = row.Cells["netWorth"].Value?.ToString() ?? "";
                }
            }
            catch { }
        }

        //  NETWORTH AUTO 
        private void txtSaldo_TextChanged(object sender, EventArgs e)
        {
            HitungNetWorth();
        }

        private void txtHutang_TextChanged(object sender, EventArgs e)
        {
            HitungNetWorth();
        }

        private void HitungNetWorth()
        {
            long saldo = 0;
            long hutang = 0;

            long.TryParse(txtSaldo.Text, out saldo);
            long.TryParse(txtHutang.Text, out hutang);

            txtNetWorth.Text = (saldo - hutang).ToString();
        }

        // AGAR DESIGNER AMAN
        private void label1_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}