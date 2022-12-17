
namespace database
{
    partial class Delivery
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
            this.кодДоставкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пунктОтправленияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пунктНазначенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отметкаОВыполненииDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.выводДоставкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbDataSet = new database.dbDataSet();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.вывод_ДоставкиTableAdapter = new database.dbDataSetTableAdapters.Вывод_ДоставкиTableAdapter();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.выводДоставкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодДоставкиDataGridViewTextBoxColumn,
            this.пунктОтправленияDataGridViewTextBoxColumn,
            this.пунктНазначенияDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.отметкаОВыполненииDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.выводДоставкиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(869, 284);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // кодДоставкиDataGridViewTextBoxColumn
            // 
            this.кодДоставкиDataGridViewTextBoxColumn.DataPropertyName = "Код доставки";
            this.кодДоставкиDataGridViewTextBoxColumn.HeaderText = "Код доставки";
            this.кодДоставкиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодДоставкиDataGridViewTextBoxColumn.Name = "кодДоставкиDataGridViewTextBoxColumn";
            this.кодДоставкиDataGridViewTextBoxColumn.Width = 125;
            // 
            // пунктОтправленияDataGridViewTextBoxColumn
            // 
            this.пунктОтправленияDataGridViewTextBoxColumn.DataPropertyName = "Пункт отправления";
            this.пунктОтправленияDataGridViewTextBoxColumn.HeaderText = "Пункт отправления";
            this.пунктОтправленияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.пунктОтправленияDataGridViewTextBoxColumn.Name = "пунктОтправленияDataGridViewTextBoxColumn";
            this.пунктОтправленияDataGridViewTextBoxColumn.Width = 125;
            // 
            // пунктНазначенияDataGridViewTextBoxColumn
            // 
            this.пунктНазначенияDataGridViewTextBoxColumn.DataPropertyName = "Пункт назначения";
            this.пунктНазначенияDataGridViewTextBoxColumn.HeaderText = "Пункт назначения";
            this.пунктНазначенияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.пунктНазначенияDataGridViewTextBoxColumn.Name = "пунктНазначенияDataGridViewTextBoxColumn";
            this.пунктНазначенияDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            this.датаDataGridViewTextBoxColumn.Width = 125;
            // 
            // отметкаОВыполненииDataGridViewCheckBoxColumn
            // 
            this.отметкаОВыполненииDataGridViewCheckBoxColumn.DataPropertyName = "Отметка о выполнении";
            this.отметкаОВыполненииDataGridViewCheckBoxColumn.HeaderText = "Отметка о выполнении";
            this.отметкаОВыполненииDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.отметкаОВыполненииDataGridViewCheckBoxColumn.Name = "отметкаОВыполненииDataGridViewCheckBoxColumn";
            this.отметкаОВыполненииDataGridViewCheckBoxColumn.Width = 125;
            // 
            // выводДоставкиBindingSource
            // 
            this.выводДоставкиBindingSource.DataMember = "Вывод Доставки";
            this.выводДоставкиBindingSource.DataSource = this.dbDataSet;
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(601, 7);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(98, 23);
            this.button6.TabIndex = 11;
            this.button6.Text = "Товар";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(483, 7);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Склад";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(364, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Продажа";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(246, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Продавец";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(121, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Покупатель";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Доставка";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // вывод_ДоставкиTableAdapter
            // 
            this.вывод_ДоставкиTableAdapter.ClearBeforeFill = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(246, 398);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(87, 23);
            this.button7.TabIndex = 12;
            this.button7.Text = "Создать";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(623, 444);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(137, 23);
            this.button8.TabIndex = 13;
            this.button8.Text = "Редактировать";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1031, 404);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(83, 23);
            this.button9.TabIndex = 14;
            this.button9.Text = "Удалить";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 351);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 22);
            this.textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(23, 399);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(155, 22);
            this.textBox2.TabIndex = 16;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(23, 446);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(154, 22);
            this.textBox3.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "пункт отправления";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "пункт назначения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "да/нет";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(1087, 12);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(95, 23);
            this.button10.TabIndex = 26;
            this.button10.Text = "закрыть";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(201, 351);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 27;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "дата доставки";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1020, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Код доставки";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(995, 374);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(155, 22);
            this.textBox4.TabIndex = 30;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(668, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "да/нет";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(454, 422);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "пункт назначения";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(454, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 17);
            this.label8.TabIndex = 34;
            this.label8.Text = "пункт отправления";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(620, 395);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(154, 22);
            this.textBox5.TabIndex = 33;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(442, 445);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(155, 22);
            this.textBox6.TabIndex = 32;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(442, 395);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(155, 22);
            this.textBox7.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(657, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 17);
            this.label9.TabIndex = 38;
            this.label9.Text = "дата доставки";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(620, 351);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(472, 330);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 17);
            this.label10.TabIndex = 40;
            this.label10.Text = "Код доставки";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(442, 351);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(155, 22);
            this.textBox8.TabIndex = 39;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(1034, 179);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(101, 30);
            this.button11.TabIndex = 41;
            this.button11.Text = "Обновить";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 511);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "delivery";
            this.Text = "delivery";
            this.Load += new System.EventHandler(this.delivery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.выводДоставкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private dbDataSet dbDataSet;
        private System.Windows.Forms.BindingSource выводДоставкиBindingSource;
        private dbDataSetTableAdapters.Вывод_ДоставкиTableAdapter вывод_ДоставкиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодДоставкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn пунктОтправленияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn пунктНазначенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn отметкаОВыполненииDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button11;
    }
}