using MaterialSkin.Controls;
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

namespace Курсовая
{
    public partial class Form1 : MaterialForm
    {
        
        static public string Who;
        public Form1()
        {
            InitializeComponent();

            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme            
                (
                Primary.Brown200,
                Primary.Grey700,
                Primary.Purple500,
                Accent.Orange400,
                TextShade.WHITE
                );
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (materialSingleLineTextField1.Text == "1" & materialSingleLineTextField2.Text == "1")
            {
                Who = "Работник";
                Form2 a = new Form2();
                a.Show();
                Hide();
              

            }else if (materialSingleLineTextField1.Text == "2" & materialSingleLineTextField2.Text == "2")
            {
                Who = "Администратор";
                Form2 a = new Form2();
                a.Show();
                Hide();
                
            }
            else MessageBox.Show("Неверный логин или пароль!","Попробуйте ещё раз");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
