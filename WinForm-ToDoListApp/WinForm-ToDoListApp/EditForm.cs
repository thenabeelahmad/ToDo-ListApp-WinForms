using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Properties;
using MaterialSkin.Animations;

namespace WinForm_ToDoListApp
{
    public partial class EditForm : MaterialForm
    {
        private DataGridViewRow _rowData;

        public EditForm(DataGridViewRow rowData)
        {
            InitializeComponent();
            _rowData = rowData;
            LoadRowData();
            this.txtDesc.Multiline = true;
            this.txtDesc.WordWrap = true;

            ddlPriority.Items.Add("--SELECT PRIORITY--");
            ddlPriority.Items.Add("HIGH");
            ddlPriority.Items.Add("MODERATE");
            ddlPriority.Items.Add("LOW");
        }

        private void LoadRowData()
        {
            // Assume your DataGridView has columns "Column1", "Column2", etc.
            txtTitle.Text = _rowData.Cells["Title"].Value.ToString();
            txtDesc.Text = _rowData.Cells["Description"].Value.ToString();
            txtDate.Text = _rowData.Cells["DueDate"].Value.ToString();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Save changes back to the DataGridView row or to the data source
            string taskID = _rowData.Cells["TaskID"].Value.ToString();
            _rowData.Cells["Title"].Value = txtTitle.Text;
            _rowData.Cells["Description"].Value = txtDesc.Text;
            // Save other fields as necessary

            string qry = "update Tasks set Title='"+txtTitle.Text.Trim()+"',Description='"+txtDesc.Text.Trim()+ "',DueDate='"+ txtDate.Value.ToString("yyyy-MM-dd") +"',Priority='"+ ddlPriority.SelectedItem.ToString() +"' where TaskID='" + taskID+"'";
            int a = DBMaster.Commd_func(qry);

            if (a>0)
            {
                MessageBox.Show("Task Updated In The System  ", "Success Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Task Not Updated In The System ", "Failure Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }

            
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ToDoListApp frm = new ToDoListApp();
            frm.Show();
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            // Save changes back to the DataGridView row or to the data source
            string taskID = _rowData.Cells["TaskID"].Value.ToString();

            string qry = "delete Tasks where TaskID='" + taskID + "'";
            int a = DBMaster.Commd_func(qry);

            if (a > 0)
            {
                MessageBox.Show("Task Deleted From The System ", "Success Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Task Deletion Failed ", "Failure Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }

        }
    }
}
