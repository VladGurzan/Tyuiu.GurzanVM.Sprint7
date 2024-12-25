using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.GurzanVM.Sprint7.Project.V8
{
    public partial class FormWelcome : Form
    {
        public FormWelcome()
        {
            InitializeComponent();
            this.textBoxWelcome2_GVM.Size = new Size(this.textBoxWelcome2_GVM.Size.Width, 80);
            this.textBoxWelcome2_GVM.AutoSize = false;
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void label_GVM_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label_GVM_MouseEnter(object sender, EventArgs e)
        {
            label_GVM.ForeColor = Color.Red;
        }

        private void label_GVM_MouseLeave(object sender, EventArgs e)
        {
            label_GVM.ForeColor = Color.White;
        }

        Point lastPoint;

        private void buttonWelcome_GVM_Click_1(object sender, EventArgs e)
        {
            string input1 = textBoxWelcome1_GVM.Text;
            string input = textBoxWelcome2_GVM.Text;
            if (string.IsNullOrWhiteSpace(textBoxWelcome1_GVM.Text) && string.IsNullOrWhiteSpace(textBoxWelcome2_GVM.Text))
            {
                MessageBox.Show("Строка не заполнена", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (input1.All(char.IsLetter) & input.All(char.IsDigit))
            {
                this.Hide();
                var FormMain = new FormMain();
                FormMain.Closed += (s, args) => this.Close();
                FormMain.Show();
            }
            else
            {
                MessageBox.Show("Введены некоректные символы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void panelWelcome_GVM_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }

        private void panelWelcome_GVM_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panelWelcome2_GVM_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }

        private void panelWelcome2_GVM_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panelWelcome2_GVM_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
