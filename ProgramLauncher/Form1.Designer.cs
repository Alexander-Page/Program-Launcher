namespace ProgramLauncher
{
    partial class Form1
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
            this.button_launch = new System.Windows.Forms.Button();
            this.button_add_new = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_DeleteProgram = new System.Windows.Forms.Button();
            this.listViewPrograms = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_launch
            // 
            this.button_launch.Location = new System.Drawing.Point(944, 680);
            this.button_launch.Name = "button_launch";
            this.button_launch.Size = new System.Drawing.Size(210, 65);
            this.button_launch.TabIndex = 1;
            this.button_launch.Text = "Launch";
            this.button_launch.UseVisualStyleBackColor = true;
            this.button_launch.Click += new System.EventHandler(this.button_launch_Click);
            // 
            // button_add_new
            // 
            this.button_add_new.Location = new System.Drawing.Point(582, 681);
            this.button_add_new.Name = "button_add_new";
            this.button_add_new.Size = new System.Drawing.Size(347, 65);
            this.button_add_new.TabIndex = 2;
            this.button_add_new.Text = "Add New Program";
            this.button_add_new.UseVisualStyleBackColor = true;
            this.button_add_new.Click += new System.EventHandler(this.button_add_new_Click);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(12, 682);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(252, 65);
            this.button_Update.TabIndex = 3;
            this.button_Update.Text = "Update List";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_DeleteProgram
            // 
            this.button_DeleteProgram.Location = new System.Drawing.Point(270, 682);
            this.button_DeleteProgram.Name = "button_DeleteProgram";
            this.button_DeleteProgram.Size = new System.Drawing.Size(306, 64);
            this.button_DeleteProgram.TabIndex = 4;
            this.button_DeleteProgram.Text = "Delete Program";
            this.button_DeleteProgram.UseVisualStyleBackColor = true;
            this.button_DeleteProgram.Click += new System.EventHandler(this.button_DeleteProgram_Click);
            // 
            // listViewPrograms
            // 
            this.listViewPrograms.BackColor = System.Drawing.Color.White;
            this.listViewPrograms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnPath});
            this.listViewPrograms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewPrograms.ForeColor = System.Drawing.Color.Black;
            this.listViewPrograms.FullRowSelect = true;
            this.listViewPrograms.GridLines = true;
            this.listViewPrograms.HideSelection = false;
            this.listViewPrograms.Location = new System.Drawing.Point(12, 24);
            this.listViewPrograms.MultiSelect = false;
            this.listViewPrograms.Name = "listViewPrograms";
            this.listViewPrograms.Size = new System.Drawing.Size(1357, 593);
            this.listViewPrograms.TabIndex = 5;
            this.listViewPrograms.UseCompatibleStateImageBehavior = false;
            this.listViewPrograms.View = System.Windows.Forms.View.Details;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 100;
            // 
            // columnPath
            // 
            this.columnPath.Text = "File Path";
            this.columnPath.Width = 1140;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(12, 623);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(1142, 53);
            this.textBoxSearch.TabIndex = 6;
            this.textBoxSearch.Text = "Search";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(1172, 623);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(197, 60);
            this.buttonSearch.TabIndex = 7;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1381, 757);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.listViewPrograms);
            this.Controls.Add(this.button_DeleteProgram);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_add_new);
            this.Controls.Add(this.button_launch);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Program Launcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_launch;
        private System.Windows.Forms.Button button_add_new;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_DeleteProgram;
        private System.Windows.Forms.ListView listViewPrograms;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnPath;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
    }
}

