namespace ProgramLauncher
{
    partial class Add_New_Program
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
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.name_Label = new System.Windows.Forms.Label();
            this.textBox_Path = new System.Windows.Forms.TextBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.label_Path = new System.Windows.Forms.Label();
            this.button_Browse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // textBox_Name
            // 
            this.textBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_Name.Location = new System.Drawing.Point(76, 127);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(822, 53);
            this.textBox_Name.TabIndex = 0;
            // 
            // name_Label
            // 
            this.name_Label.AutoSize = true;
            this.name_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.name_Label.Location = new System.Drawing.Point(68, 68);
            this.name_Label.Name = "name_Label";
            this.name_Label.Size = new System.Drawing.Size(290, 46);
            this.name_Label.TabIndex = 1;
            this.name_Label.Text = "Program Name";
            // 
            // textBox_Path
            // 
            this.textBox_Path.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_Path.Location = new System.Drawing.Point(76, 250);
            this.textBox_Path.Name = "textBox_Path";
            this.textBox_Path.Size = new System.Drawing.Size(822, 53);
            this.textBox_Path.TabIndex = 2;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(443, 321);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(163, 81);
            this.button_Add.TabIndex = 3;
            this.button_Add.Text = "Add Program";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // label_Path
            // 
            this.label_Path.AutoSize = true;
            this.label_Path.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_Path.Location = new System.Drawing.Point(68, 201);
            this.label_Path.Name = "label_Path";
            this.label_Path.Size = new System.Drawing.Size(387, 46);
            this.label_Path.TabIndex = 4;
            this.label_Path.Text = "Executable File Path";
            // 
            // button_Browse
            // 
            this.button_Browse.Location = new System.Drawing.Point(945, 245);
            this.button_Browse.Name = "button_Browse";
            this.button_Browse.Size = new System.Drawing.Size(188, 69);
            this.button_Browse.TabIndex = 5;
            this.button_Browse.Text = "Browse";
            this.button_Browse.UseVisualStyleBackColor = true;
            this.button_Browse.Click += new System.EventHandler(this.button_Browse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Add_New_Program
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 431);
            this.Controls.Add(this.button_Browse);
            this.Controls.Add(this.label_Path);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.textBox_Path);
            this.Controls.Add(this.name_Label);
            this.Controls.Add(this.textBox_Name);
            this.Name = "Add_New_Program";
            this.Text = "Add New Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label name_Label;
        private System.Windows.Forms.TextBox textBox_Path;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Label label_Path;
        private System.Windows.Forms.Button button_Browse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}