namespace Tyuiu.GurzanVM.Sprint7.Project.V8
{
    partial class FormWelcome
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
            labelWelcome_GVM = new Label();
            pictureBoxWelcome_GVM = new PictureBox();
            panelWelcome_GVM = new Panel();
            label_GVM = new Label();
            buttonWelcome_GVM = new Button();
            textBoxWelcome1_GVM = new TextBox();
            textBoxWelcome2_GVM = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panelWelcome2_GVM = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWelcome_GVM).BeginInit();
            panelWelcome_GVM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelWelcome2_GVM.SuspendLayout();
            SuspendLayout();
            // 
            // labelWelcome_GVM
            // 
            labelWelcome_GVM.Anchor = AnchorStyles.Top;
            labelWelcome_GVM.AutoSize = true;
            labelWelcome_GVM.BackColor = Color.FromArgb(2, 49, 87);
            labelWelcome_GVM.FlatStyle = FlatStyle.Flat;
            labelWelcome_GVM.Font = new Font("Comic Sans MS", 30F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelWelcome_GVM.ForeColor = Color.White;
            labelWelcome_GVM.Location = new Point(393, 3);
            labelWelcome_GVM.Name = "labelWelcome_GVM";
            labelWelcome_GVM.Size = new Size(343, 69);
            labelWelcome_GVM.TabIndex = 0;
            labelWelcome_GVM.Text = "Авторизация";
            labelWelcome_GVM.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxWelcome_GVM
            // 
            pictureBoxWelcome_GVM.Image = Properties.Resources._8725498_car_icon;
            pictureBoxWelcome_GVM.Location = new Point(8, 3);
            pictureBoxWelcome_GVM.Name = "pictureBoxWelcome_GVM";
            pictureBoxWelcome_GVM.Size = new Size(80, 80);
            pictureBoxWelcome_GVM.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxWelcome_GVM.TabIndex = 2;
            pictureBoxWelcome_GVM.TabStop = false;
            // 
            // panelWelcome_GVM
            // 
            panelWelcome_GVM.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelWelcome_GVM.AutoSize = true;
            panelWelcome_GVM.BackColor = Color.FromArgb(2, 49, 87);
            panelWelcome_GVM.BorderStyle = BorderStyle.FixedSingle;
            panelWelcome_GVM.Controls.Add(pictureBoxWelcome_GVM);
            panelWelcome_GVM.Controls.Add(labelWelcome_GVM);
            panelWelcome_GVM.Controls.Add(label_GVM);
            panelWelcome_GVM.Location = new Point(-9, -3);
            panelWelcome_GVM.Name = "panelWelcome_GVM";
            panelWelcome_GVM.Size = new Size(1153, 142);
            panelWelcome_GVM.TabIndex = 8;
            panelWelcome_GVM.MouseDown += panelWelcome_GVM_MouseDown;
            panelWelcome_GVM.MouseMove += panelWelcome_GVM_MouseMove;
            // 
            // label_GVM
            // 
            label_GVM.BackColor = Color.FromArgb(2, 49, 87);
            label_GVM.Cursor = Cursors.Hand;
            label_GVM.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_GVM.ForeColor = Color.White;
            label_GVM.Location = new Point(1107, 0);
            label_GVM.Name = "label_GVM";
            label_GVM.Size = new Size(32, 32);
            label_GVM.TabIndex = 8;
            label_GVM.Text = "X";
            label_GVM.Click += label_GVM_Click;
            label_GVM.MouseEnter += label_GVM_MouseEnter;
            label_GVM.MouseLeave += label_GVM_MouseLeave;
            // 
            // buttonWelcome_GVM
            // 
            buttonWelcome_GVM.BackColor = Color.FromArgb(17, 92, 30);
            buttonWelcome_GVM.Cursor = Cursors.Hand;
            buttonWelcome_GVM.FlatAppearance.MouseDownBackColor = Color.Green;
            buttonWelcome_GVM.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 0);
            buttonWelcome_GVM.FlatStyle = FlatStyle.Flat;
            buttonWelcome_GVM.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonWelcome_GVM.ForeColor = Color.White;
            buttonWelcome_GVM.Location = new Point(150, 415);
            buttonWelcome_GVM.Name = "buttonWelcome_GVM";
            buttonWelcome_GVM.Size = new Size(272, 78);
            buttonWelcome_GVM.TabIndex = 13;
            buttonWelcome_GVM.Text = "Войти";
            buttonWelcome_GVM.UseVisualStyleBackColor = false;
            buttonWelcome_GVM.Click += buttonWelcome_GVM_Click_1;
            // 
            // textBoxWelcome1_GVM
            // 
            textBoxWelcome1_GVM.BackColor = SystemColors.Window;
            textBoxWelcome1_GVM.Font = new Font("Times New Roman", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxWelcome1_GVM.Location = new Point(150, 142);
            textBoxWelcome1_GVM.Multiline = true;
            textBoxWelcome1_GVM.Name = "textBoxWelcome1_GVM";
            textBoxWelcome1_GVM.Size = new Size(465, 80);
            textBoxWelcome1_GVM.TabIndex = 9;
            textBoxWelcome1_GVM.UseSystemPasswordChar = true;
            // 
            // textBoxWelcome2_GVM
            // 
            textBoxWelcome2_GVM.Font = new Font("Times New Roman", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxWelcome2_GVM.Location = new Point(150, 269);
            textBoxWelcome2_GVM.Name = "textBoxWelcome2_GVM";
            textBoxWelcome2_GVM.Size = new Size(465, 62);
            textBoxWelcome2_GVM.TabIndex = 10;
            textBoxWelcome2_GVM.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._211855_locked_icon;
            pictureBox2.Location = new Point(48, 269);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(80, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._285655_user_icon;
            pictureBox1.Location = new Point(48, 142);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // panelWelcome2_GVM
            // 
            panelWelcome2_GVM.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelWelcome2_GVM.AutoSize = true;
            panelWelcome2_GVM.BackColor = Color.FromArgb(86, 2, 30);
            panelWelcome2_GVM.Controls.Add(textBoxWelcome1_GVM);
            panelWelcome2_GVM.Controls.Add(buttonWelcome_GVM);
            panelWelcome2_GVM.Controls.Add(pictureBox1);
            panelWelcome2_GVM.Controls.Add(pictureBox2);
            panelWelcome2_GVM.Controls.Add(textBoxWelcome2_GVM);
            panelWelcome2_GVM.Location = new Point(0, 135);
            panelWelcome2_GVM.Name = "panelWelcome2_GVM";
            panelWelcome2_GVM.Size = new Size(1140, 550);
            panelWelcome2_GVM.TabIndex = 14;
            panelWelcome2_GVM.Paint += panelWelcome2_GVM_Paint;
            panelWelcome2_GVM.MouseDown += panelWelcome2_GVM_MouseDown;
            panelWelcome2_GVM.MouseMove += panelWelcome2_GVM_MouseMove;
            // 
            // FormWelcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1135, 680);
            Controls.Add(panelWelcome2_GVM);
            Controls.Add(panelWelcome_GVM);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormWelcome";
            Text = "FormWelcome";
            ((System.ComponentModel.ISupportInitialize)pictureBoxWelcome_GVM).EndInit();
            panelWelcome_GVM.ResumeLayout(false);
            panelWelcome_GVM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelWelcome2_GVM.ResumeLayout(false);
            panelWelcome2_GVM.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelWelcome_GVM;
        private PictureBox pictureBoxWelcome_GVM;
        private Panel panelWelcome_GVM;
        private Label label_GVM;
        private Button buttonWelcome_GVM;
        private TextBox textBoxWelcome1_GVM;
        private TextBox textBoxWelcome2_GVM;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel panelWelcome2_GVM;
    }
}