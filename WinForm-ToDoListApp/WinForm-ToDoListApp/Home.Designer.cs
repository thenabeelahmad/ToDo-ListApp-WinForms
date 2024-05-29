using System.Windows.Forms;

namespace WinForm_ToDoListApp
{
    partial class ToDoListApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdTasks = new System.Windows.Forms.DataGridView();
            this.btnLoadData = new MaterialSkin.Controls.MaterialButton();
            this.btnAddTask = new MaterialSkin.Controls.MaterialButton();
            this.switchTheme = new MaterialSkin.Controls.MaterialSwitch();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.grdTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // grdTasks
            // 
            this.grdTasks.AllowUserToAddRows = false;
            this.grdTasks.AllowUserToResizeColumns = false;
            this.grdTasks.AllowUserToResizeRows = false;
            this.grdTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdTasks.DefaultCellStyle = dataGridViewCellStyle10;
            this.grdTasks.Location = new System.Drawing.Point(18, 188);
            this.grdTasks.MinimumSize = new System.Drawing.Size(1023, 361);
            this.grdTasks.MultiSelect = false;
            this.grdTasks.Name = "grdTasks";
            this.grdTasks.ReadOnly = true;
            this.grdTasks.RowHeadersVisible = false;
            this.grdTasks.RowTemplate.Height = 24;
            this.grdTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTasks.Size = new System.Drawing.Size(1023, 361);
            this.grdTasks.TabIndex = 5;
            this.grdTasks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTasks_CellClick);
            // 
            // btnLoadData
            // 
            this.btnLoadData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLoadData.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLoadData.Depth = 0;
            this.btnLoadData.HighEmphasis = true;
            this.btnLoadData.Icon = null;
            this.btnLoadData.Location = new System.Drawing.Point(18, 558);
            this.btnLoadData.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLoadData.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.NoAccentTextColor = System.Drawing.Color.DodgerBlue;
            this.btnLoadData.Size = new System.Drawing.Size(100, 36);
            this.btnLoadData.TabIndex = 6;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLoadData.UseAccentColor = false;
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddTask.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddTask.Depth = 0;
            this.btnAddTask.HighEmphasis = true;
            this.btnAddTask.Icon = null;
            this.btnAddTask.Location = new System.Drawing.Point(925, 558);
            this.btnAddTask.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddTask.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddTask.Size = new System.Drawing.Size(91, 36);
            this.btnAddTask.TabIndex = 7;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddTask.UseAccentColor = false;
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // switchTheme
            // 
            this.switchTheme.AutoSize = true;
            this.switchTheme.Depth = 0;
            this.switchTheme.Location = new System.Drawing.Point(18, 117);
            this.switchTheme.Margin = new System.Windows.Forms.Padding(0);
            this.switchTheme.MouseLocation = new System.Drawing.Point(-1, -1);
            this.switchTheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.switchTheme.Name = "switchTheme";
            this.switchTheme.Ripple = true;
            this.switchTheme.Size = new System.Drawing.Size(165, 37);
            this.switchTheme.TabIndex = 10;
            this.switchTheme.Text = "Change Theme";
            this.switchTheme.UseVisualStyleBackColor = true;
            this.switchTheme.CheckedChanged += new System.EventHandler(this.switchTheme_CheckedChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(464, 105);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(106, 19);
            this.materialLabel1.TabIndex = 11;
            this.materialLabel1.Text = "To-Do List App";
            // 
            // ToDoListApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1061, 614);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.switchTheme);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.grdTasks);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MaximizeBox = false;
            this.Name = "ToDoListApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToDo List App - An Ahmad Product";
            ((System.ComponentModel.ISupportInitialize)(this.grdTasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grdTasks;
        private MaterialSkin.Controls.MaterialButton btnLoadData;
        private MaterialSkin.Controls.MaterialButton btnAddTask;
        private MaterialSkin.Controls.MaterialSwitch switchTheme;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}

