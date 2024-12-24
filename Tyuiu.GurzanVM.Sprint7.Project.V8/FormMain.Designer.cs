namespace Tyuiu.GurzanVM.Sprint7.Project.V8
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelMain_GVM = new Panel();
            buttonMY_GVM = new Button();
            labelMain_GVM = new Label();
            panelMain2_GVM = new Panel();
            label_GVM = new Label();
            pictureBoxWelcome_GVM = new PictureBox();
            panelMain_GVM.SuspendLayout();
            panelMain2_GVM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWelcome_GVM).BeginInit();
            SuspendLayout();
            // 
            // panelMain_GVM
            // 
            panelMain_GVM.BackColor = Color.FromArgb(86, 2, 30);
            panelMain_GVM.Controls.Add(buttonMY_GVM);
            panelMain_GVM.Dock = DockStyle.Bottom;
            panelMain_GVM.Location = new Point(0, 137);
            panelMain_GVM.Name = "panelMain_GVM";
            panelMain_GVM.Size = new Size(664, 581);
            panelMain_GVM.TabIndex = 0;
            // 
            // buttonMY_GVM
            // 
            buttonMY_GVM.BackColor = Color.FromArgb(86, 2, 30);
            buttonMY_GVM.FlatStyle = FlatStyle.Flat;
            buttonMY_GVM.Image = (Image)resources.GetObject("buttonMY_GVM.Image");
            buttonMY_GVM.Location = new Point(572, 489);
            buttonMY_GVM.Name = "buttonMY_GVM";
            buttonMY_GVM.Size = new Size(80, 80);
            buttonMY_GVM.TabIndex = 0;
            buttonMY_GVM.UseVisualStyleBackColor = false;
            buttonMY_GVM.Click += buttonMY_GVM_Click;
            // 
            // labelMain_GVM
            // 
            labelMain_GVM.Dock = DockStyle.Fill;
            labelMain_GVM.Font = new Font("Comic Sans MS", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelMain_GVM.ForeColor = Color.White;
            labelMain_GVM.ImageAlign = ContentAlignment.TopCenter;
            labelMain_GVM.Location = new Point(0, 0);
            labelMain_GVM.Name = "labelMain_GVM";
            labelMain_GVM.Size = new Size(664, 140);
            labelMain_GVM.TabIndex = 0;
            labelMain_GVM.Text = "Автотранспортное предприятие";
            labelMain_GVM.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelMain2_GVM
            // 
            panelMain2_GVM.BackColor = Color.FromArgb(2, 49, 87);
            panelMain2_GVM.Controls.Add(label_GVM);
            panelMain2_GVM.Controls.Add(pictureBoxWelcome_GVM);
            panelMain2_GVM.Controls.Add(labelMain_GVM);
            panelMain2_GVM.Dock = DockStyle.Top;
            panelMain2_GVM.Location = new Point(0, 0);
            panelMain2_GVM.Name = "panelMain2_GVM";
            panelMain2_GVM.Size = new Size(664, 140);
            panelMain2_GVM.TabIndex = 1;
            // 
            // label_GVM
            // 
            label_GVM.BackColor = Color.FromArgb(2, 49, 87);
            label_GVM.Cursor = Cursors.Hand;
            label_GVM.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_GVM.ForeColor = Color.White;
            label_GVM.Location = new Point(632, 0);
            label_GVM.Name = "label_GVM";
            label_GVM.Size = new Size(32, 32);
            label_GVM.TabIndex = 9;
            label_GVM.Text = "X";
            label_GVM.Click += label_GVM_Click;
            // 
            // pictureBoxWelcome_GVM
            // 
            pictureBoxWelcome_GVM.Image = Properties.Resources._8725498_car_icon;
            pictureBoxWelcome_GVM.Location = new Point(24, 28);
            pictureBoxWelcome_GVM.Name = "pictureBoxWelcome_GVM";
            pictureBoxWelcome_GVM.Size = new Size(80, 80);
            pictureBoxWelcome_GVM.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxWelcome_GVM.TabIndex = 3;
            pictureBoxWelcome_GVM.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 718);
            Controls.Add(panelMain2_GVM);
            Controls.Add(panelMain_GVM);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMain";
            Text = "Автотранспортное предприятие";
            panelMain_GVM.ResumeLayout(false);
            panelMain2_GVM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxWelcome_GVM).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain_GVM;
        private Label labelMain_GVM;
        private Panel panelMain2_GVM;
        private PictureBox pictureBoxWelcome_GVM;
        private Label label_GVM;
        private Button buttonMY_GVM;
    }
}
