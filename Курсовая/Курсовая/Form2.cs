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
using System.IO;

namespace Курсовая
{
	public partial class Form2 : MaterialForm
	{
		bool Поиск = false;
		bool редактировать = false;

		public Form2()
		{
			InitializeComponent();
			MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
			materialSkinManager.AddFormToManage(this);
			materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

			materialSkinManager.ColorScheme = new ColorScheme(
				Primary.Brown200,
				Primary.Grey700,
				Primary.Purple500,
				Accent.Orange400,
				TextShade.WHITE
			);
		}

		private void Form2_Load(object sender, EventArgs e)
		{
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ip521_11_Ivakov_Курсовая1DataSet.Поставщики". При необходимости она может быть перемещена или удалена.
            this.поставщикиTableAdapter.Fill(this._ip521_11_Ivakov_Курсовая1DataSet.Поставщики);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ip521_11_Ivakov_Курсовая1DataSet.Товары_на_складе". При необходимости она может быть перемещена или удалена.
            this.товары_на_складеTableAdapter.Fill(this._ip521_11_Ivakov_Курсовая1DataSet.Товары_на_складе);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ip521_11_Ivakov_Курсовая1DataSet.Склады". При необходимости она может быть перемещена или удалена.
            this.складыTableAdapter1.Fill(this._ip521_11_Ivakov_Курсовая1DataSet.Склады);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ip521_11_Ivakov_Курсовая1DataSet.Поставки". При необходимости она может быть перемещена или удалена.
            this.поставкиTableAdapter.Fill(this._ip521_11_Ivakov_Курсовая1DataSet.Поставки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ip521_11_Ivakov_Курсовая1DataSet.Товары". При необходимости она может быть перемещена или удалена.
            this.товарыTableAdapter.Fill(this._ip521_11_Ivakov_Курсовая1DataSet.Товары);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ip521_11_Ivakov_Курсовая1DataSet.Категории_товаров". При необходимости она может быть перемещена или удалена.
            this.категории_товаровTableAdapter.Fill(this._ip521_11_Ivakov_Курсовая1DataSet.Категории_товаров);
            Size = new Size(774, 487);
			groupBox3.Visible = false;

			if (Form1.Who == "Работник")
			{
				//tabControl1.Visible = false;
				//tabControl2.Visible = true;
				this.Text = "БД Работник";
				dataGridView1.ReadOnly = true;
				dataGridView2.ReadOnly = true;				
				dataGridView4.ReadOnly = true;
				dataGridView5.ReadOnly = true;
				bindingNavigator4.Visible = false;
				
				dataGridView6.Visible = false;
				dataGridView7.Visible = false;
				
				toolStripButton2.Visible = false;
				toolStripButton5.Visible = false;
			}
			else
			if (Form1.Who == "Администратор")
			{
				//tabControl1.Visible = true;
				//tabControl2.Visible = false;
				this.Text = "БД Администратор";
				label1.Visible = false;
				label2.Visible = false;
				
				

			}
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_ip521_11_Ivakov_Курсовая1DataSet.Цветы". При необходимости она может быть перемещена или удалена.
			this.категории_товаровTableAdapter.Fill(this._ip521_11_Ivakov_Курсовая1DataSet.Категории_товаров);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_ip521_11_Ivakov_Курсовая1DataSet.Склады". При необходимости она может быть перемещена или удалена.
			this.товарыTableAdapter.Fill(this._ip521_11_Ivakov_Курсовая1DataSet.Товары);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_ip521_11_Ivakov_Курсовая1DataSet.Работники". При необходимости она может быть перемещена или удалена.
			this.поставкиTableAdapter.Fill(this._ip521_11_Ivakov_Курсовая1DataSet.Поставки);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_ip521_11_Ivakov_Курсовая1DataSet.Приходы". При необходимости она может быть перемещена или удалена.
			this.складыTableAdapter1.Fill(this._ip521_11_Ivakov_Курсовая1DataSet.Склады);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_ip521_11_Ivakov_Курсовая1DataSet.Поставщик". При необходимости она может быть перемещена или удалена.
			this.товары_на_складеTableAdapter.Fill(this._ip521_11_Ivakov_Курсовая1DataSet.Товары_на_складе);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_ip521_11_Ivakov_Курсовая1DataSet.Заказы". При необходимости она может быть перемещена или удалена.
			this.поставщикиTableAdapter.Fill(this._ip521_11_Ivakov_Курсовая1DataSet.Поставщики);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_ip521_11_Ivakov_Курсовая1DataSet.Клиенты". При необходимости она может быть перемещена или удалена.
			
		}

		private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
		{
			Form1 a = new Form1();
			a.Show();
			Hide();

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			//клиентыBindingSource.AddNew();
		}
		private void button2_Click(object sender, EventArgs e)
		{
			категориитоваровBindingSource.EndEdit();
			категории_товаровTableAdapter.Update(_ip521_11_Ivakov_Курсовая1DataSet);

			товарыBindingSource.EndEdit();
			товарыTableAdapter.Update(_ip521_11_Ivakov_Курсовая1DataSet);

			поставкиBindingSource.EndEdit();
			поставкиTableAdapter.Update(_ip521_11_Ivakov_Курсовая1DataSet);

			складыBindingSource.EndEdit();
			складыTableAdapter1.Update(_ip521_11_Ivakov_Курсовая1DataSet);

			товарынаскладеBindingSource.EndEdit();
			товары_на_складеTableAdapter.Update(_ip521_11_Ivakov_Курсовая1DataSet);

			поставщикиBindingSource.EndEdit();
			поставщикиTableAdapter.Update(_ip521_11_Ivakov_Курсовая1DataSet);

			складыBindingSource.EndEdit();
			складыTableAdapter.Update(___AAA_SegaIp521_18DataSet);

			цветыBindingSource.EndEdit();
			цветыTableAdapter.Update(___AAA_SegaIp521_18DataSet);
		}
		private void tabPage3_Click(object sender, EventArgs e)
		{
			
		}

		private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void toolStripButton3_Click(object sender, EventArgs e)
		{
			string a = textBox3.Text;
			if (radioButton3.Checked == true)
			{

				switch (a)
				{
					case "Категории_товаров": категориитоваровBindingSource.Filter = textBox1.Text + " LIKE ('" + textBox2.Text + "')"; break;
					case "Товары": товарыBindingSource.Filter = textBox1.Text + " LIKE ('" + textBox2.Text + "')"; break;
					case "Поставки": поставкиBindingSource.Filter = textBox1.Text + " LIKE ('" + textBox2.Text + "')"; break;
					case "Склады": складыBindingSource.Filter = textBox1.Text + " LIKE ('" + textBox2.Text + "')"; break;
					case "Товары_на_складе": товарынаскладеBindingSource.Filter = textBox1.Text + " LIKE ('" + textBox2.Text + "')"; break;
					case "Поставщики": поставщикиBindingSource.Filter = textBox1.Text + " LIKE ('" + textBox2.Text + "')"; break;
					
					default: MessageBox.Show("Таблица не найдена", "Ошибка"); break;
				}
			}
			else
			{

				if (radioButton2.Checked == false)
				{
					switch (a)
					{
						case "Категории_товаров": категориитоваровBindingSource.Filter = textBox1.Text + " LIKE ('" + textBox2.Text + "') and " + textBox5.Text + " LIKE('" + textBox4.Text + "')"; break;
						case "Товары": товарыBindingSource.Filter = textBox1.Text + " LIKE ('" + textBox2.Text + "') and " + textBox5.Text + " LIKE('" + textBox4.Text + "')"; break;
						case "Поставки": поставкиBindingSource.Filter = textBox1.Text + " LIKE ('" + textBox2.Text + "') and " + textBox5.Text + " LIKE('" + textBox4.Text + "')"; break;
						case "Склады": складыBindingSource.Filter = textBox1.Text + " LIKE ('" + textBox2.Text + "') and " + textBox5.Text + " LIKE('" + textBox4.Text + "')"; break;
						case "Товары_на_складе": товарынаскладеBindingSource.Filter = textBox1.Text + " LIKE ('" + textBox2.Text + "') and " + textBox5.Text + " LIKE('" + textBox4.Text + "')"; break;
						case "Поставщики": поставщикиBindingSource.Filter = textBox1.Text + " LIKE ('" + textBox2.Text + "') and " + textBox5.Text + " LIKE('" + textBox4.Text + "')"; break;
						
						default: MessageBox.Show("Таблица не найдена", "Ошибка"); break;
					}



				}
				else
				{
					switch (a)
					{
						case "Категории_товаров": категориитоваровBindingSource.Filter = textBox1.Text + " LIKE ('" + textBox2.Text + "') or " + textBox5.Text + " LIKE('" + textBox4.Text + "')"; break;
						case "Товары": товарыBindingSource.Filter = textBox1.Text + " LIKE ('" + textBox2.Text + "') or " + textBox5.Text + " LIKE('" + textBox4.Text + "')"; break;
						case "Поставки": поставкиBindingSource.Filter = textBox1.Text + " LIKE ('" + textBox2.Text + "') or " + textBox5.Text + " LIKE('" + textBox4.Text + "')"; break;
						case "Склады": складыBindingSource.Filter = textBox1.Text + " LIKE ('" + textBox2.Text + "') or " + textBox5.Text + " LIKE('" + textBox4.Text + "')"; break;
						case "Товары_на_складе": товарынаскладеBindingSource.Filter = textBox1.Text + " LIKE ('" + textBox2.Text + "') or " + textBox5.Text + " LIKE('" + textBox4.Text + "')"; break;
						case "Поставщики": поставщикиBindingSource.Filter = textBox1.Text + " LIKE ('" + textBox2.Text + "') or " + textBox5.Text + " LIKE('" + textBox4.Text + "')"; break;
						
						default: MessageBox.Show("Таблица не найдена", "Ошибка"); break;
					}
				}
			}
		}
		private void timer1_Tick(object sender, EventArgs e)
		{
			if (radioButton3.Checked == false)
			{
				groupBox2.Visible = true;
			}else groupBox2.Visible = false;

			if (Поиск == true & редактировать == true)
			{
				groupBox4.Location = new System.Drawing.Point(18, 586);
				Size = new Size(774, 727);
				groupBox3.Visible = true;
				groupBox4.Visible = true;
			}
			else if (Поиск == true)
			{
				Size = new Size(774, 610);
				groupBox3.Visible = true;
				groupBox4.Visible = false;
			}
			else if (редактировать == true)
			{
				groupBox4.Location = new System.Drawing.Point(16, 464);
				Size = new Size(774, 610);
				groupBox3.Visible = false;
				groupBox4.Visible = true;
			}
			else 
			{
				
				Size = new Size(774, 487);
				groupBox3.Visible = false;
				groupBox4.Visible = false;
			}
		}
        private void toolStripButton3_Click_1(object sender, EventArgs e)
        {
			if (Поиск == true)
			{
				Поиск = false;
			}
			else Поиск = true;
		}

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
			if (редактировать == true)
			{
				редактировать = false;
			}
			else редактировать = true;
		}

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
		

        private void button3_Click_1(object sender, EventArgs e)
        {
			товарыBindingSource.Filter = string.Empty;
			категориитоваровBindingSource.Filter = string.Empty;
			складыBindingSource.Filter = string.Empty;
			поставщикиBindingSource.Filter = string.Empty;
			товарынаскладеBindingSource.Filter = string.Empty;
			поставкиBindingSource.Filter = string.Empty;
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();


		}

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
			
			if (dataGridView1.Rows.Count == 0)
			{
				MessageBox.Show("Нет данных для экспорта.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Показываем диалог сохранения файла
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "CSV файл (*.csv)|*.csv";
			saveFileDialog.Title = "Сохранить CSV файл";

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				// Вызываем метод для экспорта в CSV
				ExportToCSV(dataGridView1, saveFileDialog.FileName);
				MessageBox.Show("Данные успешно экспортированы в CSV!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

		}
		private void ExportToCSV(DataGridView dataGridView, string filePath)
		{
			using (StringWriter sw = new StringWriter())
			{
				// Добавить заголовки столбцов
				foreach (DataGridViewColumn col in dataGridView.Columns)
				{
					sw.Write($"\"{col.HeaderText}\"" + "\t");
				}
				sw.WriteLine();

				// Добавить данные
				foreach (DataGridViewRow row in dataGridView.Rows)
				{
					foreach (DataGridViewCell cell in row.Cells)
					{
						sw.Write($"\"{cell.Value}\"" + "\t");
					}
					sw.WriteLine();
				}

				// Записать в файл с указанием кодировки UTF-8 без BOM
				File.WriteAllText(filePath, sw.ToString(), Encoding.UTF8);
			}
		}

        private void button4_Click(object sender, EventArgs e)
        {
			
		}

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
			this.Validate();
			this.поставщикиBindingSource.EndEdit();
			this.поставщикиTableAdapter.Update(this._ip521_11_Ivakov_Курсовая1DataSet.Поставщики);



		}
    }
}
