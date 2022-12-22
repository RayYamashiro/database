
namespace database.win
{
    partial class Seller
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодПродавцаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеПродавцаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.иННDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.выводПродавцаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbDataSet = new database.dbDataSet();
            this.вывод_ПродавцаTableAdapter = new database.dbDataSetTableAdapters.Вывод_ПродавцаTableAdapter();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.выводПродавцаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодПродавцаDataGridViewTextBoxColumn,
            this.наименованиеПродавцаDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn,
            this.иННDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.выводПродавцаBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(869, 284);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодПродавцаDataGridViewTextBoxColumn
            // 
            this.кодПродавцаDataGridViewTextBoxColumn.DataPropertyName = "Код продавца";
            this.кодПродавцаDataGridViewTextBoxColumn.HeaderText = "Код продавца";
            this.кодПродавцаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодПродавцаDataGridViewTextBoxColumn.Name = "кодПродавцаDataGridViewTextBoxColumn";
            this.кодПродавцаDataGridViewTextBoxColumn.Width = 125;
            // 
            // наименованиеПродавцаDataGridViewTextBoxColumn
            // 
            this.наименованиеПродавцаDataGridViewTextBoxColumn.DataPropertyName = "Наименование продавца";
            this.наименованиеПродавцаDataGridViewTextBoxColumn.HeaderText = "Наименование продавца";
            this.наименованиеПродавцаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.наименованиеПродавцаDataGridViewTextBoxColumn.Name = "наименованиеПродавцаDataGridViewTextBoxColumn";
            this.наименованиеПродавцаDataGridViewTextBoxColumn.Width = 125;
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            this.адресDataGridViewTextBoxColumn.Width = 125;
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            this.телефонDataGridViewTextBoxColumn.Width = 125;
            // 
            // иННDataGridViewTextBoxColumn
            // 
            this.иННDataGridViewTextBoxColumn.DataPropertyName = "ИНН";
            this.иННDataGridViewTextBoxColumn.HeaderText = "ИНН";
            this.иННDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.иННDataGridViewTextBoxColumn.Name = "иННDataGridViewTextBoxColumn";
            this.иННDataGridViewTextBoxColumn.Width = 125;
            // 
            // выводПродавцаBindingSource
            // 
            this.выводПродавцаBindingSource.DataMember = "Вывод Продавца";
            this.выводПродавцаBindingSource.DataSource = this.dbDataSet;
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // вывод_ПродавцаTableAdapter
            // 
            this.вывод_ПродавцаTableAdapter.ClearBeforeFill = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(589, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(98, 23);
            this.button6.TabIndex = 11;
            this.button6.Text = "Товар";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(471, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Склад";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(352, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Продажа";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(234, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Продавец";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(111, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Покупатель";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Доставка";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1087, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(95, 23);
            this.button7.TabIndex = 12;
            this.button7.Text = "закрыть";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(686, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 93;
            this.label6.Text = "ИНН";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(632, 351);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(155, 22);
            this.textBox10.TabIndex = 92;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(670, 331);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 91;
            this.label9.Text = "Телефон";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(503, 425);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 90;
            this.label7.Text = "Адрес";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(445, 374);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 17);
            this.label8.TabIndex = 89;
            this.label8.Text = "Наименование продавца";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(233, 350);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(155, 22);
            this.textBox9.TabIndex = 88;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(472, 331);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 17);
            this.label10.TabIndex = 87;
            this.label10.Text = "Код продавца";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(454, 351);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(155, 22);
            this.textBox8.TabIndex = 86;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(632, 395);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(154, 22);
            this.textBox5.TabIndex = 85;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(454, 445);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(155, 22);
            this.textBox6.TabIndex = 84;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(454, 395);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(155, 22);
            this.textBox7.TabIndex = 83;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1007, 374);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(155, 22);
            this.textBox4.TabIndex = 82;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1032, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 81;
            this.label5.Text = "Код продавца";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 80;
            this.label3.Text = "ИНН";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 79;
            this.label4.Text = "Телефон";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 78;
            this.label2.Text = "Адрес";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 17);
            this.label1.TabIndex = 77;
            this.label1.Text = "Наименование продавца";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(35, 446);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(154, 22);
            this.textBox3.TabIndex = 76;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(35, 399);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(155, 22);
            this.textBox2.TabIndex = 75;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 351);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 22);
            this.textBox1.TabIndex = 74;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1043, 404);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(83, 23);
            this.button9.TabIndex = 73;
            this.button9.Text = "Удалить";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(635, 444);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(137, 23);
            this.button8.TabIndex = 72;
            this.button8.Text = "Редактировать";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(258, 398);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(87, 23);
            this.button10.TabIndex = 71;
            this.button10.Text = "Создать";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(1035, 255);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(101, 30);
            this.button11.TabIndex = 94;
            this.button11.Text = "Обновить";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(454, 476);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(137, 23);
            this.button12.TabIndex = 95;
            this.button12.Text = "Загрузить данные";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // Seller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 511);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Seller";
            this.Text = "Seller";
            this.Load += new System.EventHandler(this.Seller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.выводПродавцаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private dbDataSet dbDataSet;
        private System.Windows.Forms.BindingSource выводПродавцаBindingSource;
        private dbDataSetTableAdapters.Вывод_ПродавцаTableAdapter вывод_ПродавцаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПродавцаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеПродавцаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn иННDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
    }
}