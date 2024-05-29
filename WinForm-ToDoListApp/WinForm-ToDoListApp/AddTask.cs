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
    public partial class AddTask : MaterialForm
    {
        public AddTask()
        {
            InitializeComponent();
            ddlPriority.Items.Add("--SELECT PRIORITY--");
            ddlPriority.Items.Add("HIGH");
            ddlPriority.Items.Add("MODERATE");
            ddlPriority.Items.Add("LOW");
            ddlPriority.SelectedIndex = 0;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            try
            {

                string date = txtDate.Value.ToString("yyyy-MM-dd");
                string priority = ddlPriority.SelectedItem.ToString();
                string s = "INSERT INTO [DB_TODOApp].[dbo].[Tasks] (UserID, Title, Description, DueDate, Priority, CreatedAt) VALUES ('1', '" + txtTitle.Text.Trim() + "', '" + txtDesc.Text.Trim() + "', '" + date + "', '" + priority + "', GETDATE())";

                int a = DBMaster.Commd_func(s);

                if (a > 0)
                {
                    MessageBox.Show("New Task Added To The System : ", "Success Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    ToDoListApp frm = new ToDoListApp();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("System Failed To Add Task : ", "Failure Update", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
                    this.Hide();
                    ToDoListApp frm = new ToDoListApp();
                    frm.Show();
                }
            }
            catch (Exception ee)
            {

                MessageBox.Show("System Throws Error : " + ee.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                this.Hide();
                ToDoListApp frm = new ToDoListApp();
                frm.Show();
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ToDoListApp frm = new ToDoListApp();
            frm.Show();
        }
    }
}
