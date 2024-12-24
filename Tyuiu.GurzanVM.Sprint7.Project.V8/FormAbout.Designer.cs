namespace Tyuiu.GurzanVM.Sprint7.Project.V8
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            panelMY_GVM = new Panel();
            panel1 = new Panel();
            labelMY_GVM = new Label();
            buttonOK_GVM = new Button();
            pictureBoxMY_GVM = new PictureBox();
            textBoxMY_GVM = new TextBox();
            panelMY_GVM.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMY_GVM).BeginInit();
            SuspendLayout();
            // 
            // panelMY_GVM
            // 
            panelMY_GVM.BackColor = Color.FromArgb(86, 2, 30);
            panelMY_GVM.Controls.Add(panel1);
            panelMY_GVM.Controls.Add(buttonOK_GVM);
            panelMY_GVM.Controls.Add(pictureBoxMY_GVM);
            panelMY_GVM.Controls.Add(textBoxMY_GVM);
            panelMY_GVM.Dock = DockStyle.Fill;
            panelMY_GVM.Location = new Point(0, 0);
            panelMY_GVM.Name = "panelMY_GVM";
            panelMY_GVM.Size = new Size(668, 397);
            panelMY_GVM.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelMY_GVM);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(668, 92);
            panel1.TabIndex = 5;
            // 
            // labelMY_GVM
            // 
            labelMY_GVM.Dock = DockStyle.Fill;
            labelMY_GVM.Font = new Font("Comic Sans MS", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelMY_GVM.Location = new Point(0, 0);
            labelMY_GVM.Name = "labelMY_GVM";
            labelMY_GVM.Size = new Size(668, 92);
            labelMY_GVM.TabIndex = 0;
            labelMY_GVM.Text = "О программе";
            labelMY_GVM.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonOK_GVM
            // 
            buttonOK_GVM.FlatStyle = FlatStyle.Flat;
            buttonOK_GVM.ForeColor = Color.White;
            buttonOK_GVM.Location = new Point(490, 340);
            buttonOK_GVM.Name = "buttonOK_GVM";
            buttonOK_GVM.Size = new Size(129, 39);
            buttonOK_GVM.TabIndex = 4;
            buttonOK_GVM.Text = "OK";
            buttonOK_GVM.UseVisualStyleBackColor = false;
            buttonOK_GVM.Click += buttonOK_GVM_Click_1;
            // 
            // pictureBoxMY_GVM
            // 
            pictureBoxMY_GVM.Image = (Image)resources.GetObject("pictureBoxMY_GVM.Image");
            pictureBoxMY_GVM.Location = new Point(12, 98);
            pictureBoxMY_GVM.Name = "pictureBoxMY_GVM";
            pictureBoxMY_GVM.Size = new Size(261, 281);
            pictureBoxMY_GVM.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMY_GVM.TabIndex = 3;
            pictureBoxMY_GVM.TabStop = false;
            // 
            // textBoxMY_GVM
            // 
            textBoxMY_GVM.BackColor = Color.FromArgb(86, 2, 30);
            textBoxMY_GVM.BorderStyle = BorderStyle.None;
            textBoxMY_GVM.CausesValidation = false;
            textBoxMY_GVM.ForeColor = Color.White;
            textBoxMY_GVM.Location = new Point(298, 98);
            textBoxMY_GVM.Multiline = true;
            textBoxMY_GVM.Name = "textBoxMY_GVM";
            textBoxMY_GVM.ReadOnly = true;
            textBoxMY_GVM.Size = new Size(321, 236);
            textBoxMY_GVM.TabIndex = 2;
            textBoxMY_GVM.Text = resources.GetString("textBoxMY_GVM.Text");
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 397);
            Controls.Add(panelMY_GVM);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAbout";
            Text = "О программе";
            Load += FormAbout_Load;
            panelMY_GVM.ResumeLayout(false);
            panelMY_GVM.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxMY_GVM).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMY_GVM;
        private PictureBox pictureBoxMY_GVM;
        private TextBox textBoxMY_GVM;
        private Button buttonOK_GVM;
        private Panel panel1;
        private Label labelMY_GVM;
    }
}