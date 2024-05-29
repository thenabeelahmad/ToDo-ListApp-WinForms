namespace WinForm_ToDoListApp
{
    partial class AddTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTask));
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.txtTitle = new MaterialSkin.Controls.MaterialTextBox();
            this.txtDesc = new MaterialSkin.Controls.MaterialTextBox();
            this.btnBack = new MaterialSkin.Controls.MaterialButton();
            this.ddlPriority = new MaterialSkin.Controls.MaterialComboBox();
            this.btnAddTask = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // Label1
            // 
            resources.ApplyResources(this.Label1, "Label1");
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Name = "Label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // txtDate
            // 
            resources.ApplyResources(this.txtDate, "txtDate");
            this.txtDate.Name = "txtDate";
            // 
            // txtTitle
            // 
            this.txtTitle.AnimateReadOnly = false;
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Depth = 0;
            resources.ApplyResources(this.txtTitle, "txtTitle");
            this.txtTitle.LeadingIcon = null;
            this.txtTitle.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.TrailingIcon = null;
            // 
            // txtDesc
            // 
            this.txtDesc.AnimateReadOnly = false;
            this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDesc.Depth = 0;
            resources.ApplyResources(this.txtDesc, "txtDesc");
            this.txtDesc.LeadingIcon = null;
            this.txtDesc.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.TrailingIcon = null;
            // 
            // btnBack
            // 
            resources.ApplyResources(this.btnBack, "btnBack");
            this.btnBack.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBack.Depth = 0;
            this.btnBack.HighEmphasis = true;
            this.btnBack.Icon = null;
            this.btnBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBack.Name = "btnBack";
            this.btnBack.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBack.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBack.UseAccentColor = false;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ddlPriority
            // 
            this.ddlPriority.AutoResize = false;
            this.ddlPriority.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ddlPriority.Depth = 0;
            this.ddlPriority.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ddlPriority.DropDownHeight = 174;
            this.ddlPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlPriority.DropDownWidth = 121;
            resources.ApplyResources(this.ddlPriority, "ddlPriority");
            this.ddlPriority.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ddlPriority.FormattingEnabled = true;
            this.ddlPriority.MouseState = MaterialSkin.MouseState.OUT;
            this.ddlPriority.Name = "ddlPriority";
            this.ddlPriority.StartIndex = 0;
            // 
            // btnAddTask
            // 
            resources.ApplyResources(this.btnAddTask, "btnAddTask");
            this.btnAddTask.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnAddTask.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddTask.Depth = 0;
            this.btnAddTask.HighEmphasis = true;
            this.btnAddTask.Icon = null;
            this.btnAddTask.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddTask.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddTask.UseAccentColor = false;
            this.btnAddTask.UseVisualStyleBackColor = false;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // AddTask
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.ddlPriority);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.MaximizeBox = false;
            this.Name = "AddTask";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker txtDate;
        private MaterialSkin.Controls.MaterialTextBox txtTitle;
        private MaterialSkin.Controls.MaterialTextBox txtDesc;
        private MaterialSkin.Controls.MaterialButton btnBack;
        private MaterialSkin.Controls.MaterialComboBox ddlPriority;
        private MaterialSkin.Controls.MaterialButton btnAddTask;
    }
}