using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Cassandra;
using cassandra_demo.BLL;
using cassandra_demo.Model;

namespace cassandra_demo
{
    public partial class frmDemo : Form
    {
        private readonly IdolBUS _idolBUS;

        public frmDemo()
        {
            InitializeComponent();

            _idolBUS = new IdolBUS();
        }

        private void frmDemo_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDgv(_idolBUS.GetAllIdol());
            }
            catch (ExecutionException ex)
            {
                MessageBox.Show(@"Cassandra error: " + ex.Message, @"Error", MessageBoxButtons.OK);
            }
        }

        private void LoadDgv(IEnumerable<Idol> dataSource)
        {
            var bindingSource = new BindingSource
            {
                DataSource = dataSource
            };
            dgvIdol.DataSource = bindingSource;
            dgvIdol.ClearSelection();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtStageName.Text.Trim().Equals(string.Empty)
                    || txtFullName.Text.Trim().Equals(string.Empty)) return;

                var idol = new Idol(
                    txtStageName.Text.Trim(),
                    txtFullName.Text.Trim(),
                    new LocalDate(dtpDateOfBirth.Value.Year, dtpDateOfBirth.Value.Month, dtpDateOfBirth.Value.Day),
                    txtGroup.Text.Trim(),
                    txtCountry.Text.Trim(),
                    txtBirthPlace.Text.Trim(),
                    chkFemale.Checked ? "F" : "M",
                    txtInstagram.Text.Trim());

                _idolBUS.InsertIdol(idol);
                LoadDgv(_idolBUS.GetAllIdol());
                MessageBox.Show(@"Insert successfully!", @"Notification", MessageBoxButtons.OK);
            }
            catch (ExecutionException ex)
            {
                MessageBox.Show(@"Cassandra error: " + ex.Message, @"Error", MessageBoxButtons.OK);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Text.Trim().Equals(string.Empty)) return;

                var results = _idolBUS.SearchIdol(txtSearch.Text.Trim());
                LoadDgv(results);
            }
            catch (ExecutionException ex)
            {
                MessageBox.Show(@"Cassandra error: " + ex.Message, @"Error", MessageBoxButtons.OK);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Text.Trim().Equals(string.Empty)) return;

                txtSearch.Clear();
                LoadDgv(_idolBUS.GetAllIdol());
            }
            catch (ExecutionException ex)
            {
                MessageBox.Show(@"Cassandra error: " + ex.Message, @"Error", MessageBoxButtons.OK);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dgvIdol.ClearSelection();

            foreach (Control control in pnlInput.Controls)
                switch (control)
                {
                    case TextBox txt:
                        txt.Clear();
                        break;
                    case CheckBox chk:
                        chk.Checked = false;
                        break;
                    case DateTimePicker dtp:
                        dtp.Value = dtpDateOfBirth.MinDate;
                        break;
                }

            btnInsert.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            txtStageName.ReadOnly = false;
            txtFullName.ReadOnly = false;
        }

        private void MapCellContent(DataGridViewSelectedCellCollection cells)
        {
            var contents = new string[8];
            for (var i = 0; i < 8; ++i) contents[i] = cells[i].Value == null ? string.Empty : cells[i].Value.ToString();

            txtStageName.Text = contents[0];
            txtFullName.Text = contents[1];
            dtpDateOfBirth.Text = contents[2];
            txtGroup.Text = contents[3];
            txtCountry.Text = contents[4];
            txtBirthPlace.Text = contents[5];
            chkFemale.Checked = contents[6] == "F";
            txtInstagram.Text = contents[7];
        }

        private void dgvIdol_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MapCellContent(dgvIdol.SelectedCells);
            btnInsert.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            txtStageName.ReadOnly = true;
            txtFullName.ReadOnly = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtStageName.Text.Trim().Equals(string.Empty)
                    || txtFullName.Text.Trim().Equals(string.Empty)) return;

                var idol = new Idol(
                    txtStageName.Text.Trim(),
                    txtFullName.Text.Trim(),
                    new LocalDate(dtpDateOfBirth.Value.Year, dtpDateOfBirth.Value.Month, dtpDateOfBirth.Value.Day),
                    txtGroup.Text.Trim(),
                    txtCountry.Text.Trim(),
                    txtBirthPlace.Text.Trim(),
                    chkFemale.Checked ? "F" : "M",
                    txtInstagram.Text.Trim());

                _idolBUS.UpdateIdol(idol);
                LoadDgv(_idolBUS.GetAllIdol());
                MessageBox.Show(@"Update successfully!", @"Notification", MessageBoxButtons.OK);
            }
            catch (ExecutionException ex)
            {
                MessageBox.Show(@"Cassandra error: " + ex.Message, @"Error", MessageBoxButtons.OK);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtStageName.Text.Trim().Equals(string.Empty)) return;

                _idolBUS.DeleteIdol(txtStageName.Text.Trim());
                LoadDgv(_idolBUS.GetAllIdol());
                MessageBox.Show(@"Delete successfully!", @"Notification", MessageBoxButtons.OK);
            }
            catch (ExecutionException ex)
            {
                MessageBox.Show(@"Cassandra error: " + ex.Message, @"Error", MessageBoxButtons.OK);
            }
        }
    }
}