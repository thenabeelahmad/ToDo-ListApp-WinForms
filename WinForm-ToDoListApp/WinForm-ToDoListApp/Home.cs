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
    public partial class ToDoListApp : MaterialForm
    {
        public ToDoListApp()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            DataTable dt = DBMaster.Get_DT("select TaskID,Title,Description,DueDate,Priority,CreatedAt from tasks");

            grdTasks.DataSource = dt;

            this.grdTasks.Columns["TaskID"].Width = 80;
            this.grdTasks.Columns["Title"].Width = 200;
            this.grdTasks.Columns["Description"].Width = 250;
            this.grdTasks.Columns["DueDate"].Width = 120;
            this.grdTasks.Columns["Priority"].Width = 200;
            this.grdTasks.Columns["CreatedAt"].Width = 120;
            this.grdTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            AddTask frm = new AddTask();
            frm.Show();
        }


        private void grdTasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the click is on a row, not the column header
            {
                DataGridViewRow selectedRow = this.grdTasks.Rows[e.RowIndex];
                EditForm editForm = new EditForm(selectedRow);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    // Optionally refresh the grid or take other actions
                }
            }
        }
        private void switchTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (switchTheme.Checked)
            {
                var materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.AddFormToManage(this);
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            }
            else
            {
                var materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.AddFormToManage(this);
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            }
        }
    }
}
