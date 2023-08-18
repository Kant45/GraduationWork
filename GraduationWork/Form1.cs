using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Threading;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Sql;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraduationWork {
    public partial class Form1 : MaterialForm {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        MaterialSkinManager ThemeManager = MaterialSkinManager.Instance;
        public Form1() {
            InitializeComponent(); 
            
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange700, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'graduationWorkDbDataSet.Equipment' table. You can move, or remove it, as needed.
            this.equipmentTableAdapter.Fill(this.graduationWorkDbDataSet.Equipment);

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Coral;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
        }

        private void ReloadButton_Click(object sender, EventArgs e) {
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void InsertButton_Click(object sender, EventArgs e) {
            Application.Run(new InformationForm());
        }

        private void DeleteAllDatalButton_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Sure?", "Delete all data", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                GW gW = new GW();
                gW.Database.ExecuteSqlCommand("TRUNCATE TABLE dbo.Equipment");
            } else if (dialogResult == DialogResult.No) {                
            }
        }

        private void materialSwitch1_CheckedChanged(object sender, EventArgs e) {
            if (materialSwitch1.Checked) {
                ThemeManager.Theme = MaterialSkinManager.Themes.LIGHT;
            } else {
                ThemeManager.Theme = MaterialSkinManager.Themes.DARK;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void SearchButton_Click(object sender, EventArgs e) {
            string searchValue = SearchTextBox1.Text;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try {
                bool valueResult = false;
                foreach (DataGridViewRow row in dataGridView1.Rows) {
                    for (int i = 0; i < row.Cells.Count; i++) {
                        if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().Equals(searchValue)) {
                            int rowIndex = row.Index;
                            dataGridView1.Rows[rowIndex].Selected = true;
                            valueResult = true;
                            break;
                        }
                    }

                }
                if (!valueResult) {
                    MessageBox.Show("Unable to find " + SearchTextBox1.Text, "Not Found");
                    return;
                }
            } catch (Exception exc) {
                MessageBox.Show(exc.Message);
            }
        }

        private void SearchButton_Click_1(object sender, EventArgs e) {
            string searchValue = materialMultiLineTextBox1.Text;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try {
                bool valueResult = false;
                foreach (DataGridViewRow row in dataGridView2.Rows) {
                    for (int i = 0; i < row.Cells.Count; i++) {
                        if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().Equals(searchValue)) {
                            int rowIndex = row.Index;
                            dataGridView2.Rows[rowIndex].Selected = true;
                            valueResult = true;
                            break;
                        }
                    }

                }
                if (!valueResult) {
                    MessageBox.Show("Unable to find " + materialMultiLineTextBox1.Text, "Not Found");
                    return;
                }
            } catch (Exception exc) {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
