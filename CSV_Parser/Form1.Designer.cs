namespace CSV_Parser
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Separator = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioBut_Separator_S = new System.Windows.Forms.RadioButton();
            this.radioBut_Separator_C = new System.Windows.Forms.RadioButton();
            this.button_SaveFile = new System.Windows.Forms.Button();
            this.button_OpenFile = new System.Windows.Forms.Button();
            this.button_AddRow = new System.Windows.Forms.Button();
            this.button_AddColumn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Separator.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(15, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(519, 235);
            this.dataGridView1.TabIndex = 6;
            // 
            // Separator
            // 
            this.Separator.Controls.Add(this.radioButton3);
            this.Separator.Controls.Add(this.radioBut_Separator_S);
            this.Separator.Controls.Add(this.radioBut_Separator_C);
            this.Separator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Separator.Location = new System.Drawing.Point(15, 12);
            this.Separator.Name = "Separator";
            this.Separator.Size = new System.Drawing.Size(147, 61);
            this.Separator.TabIndex = 7;
            this.Separator.TabStop = false;
            this.Separator.Text = "Разделитель данных:";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton3.Location = new System.Drawing.Point(94, 26);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(32, 24);
            this.radioButton3.TabIndex = 14;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "|";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioBut_Separator_S
            // 
            this.radioBut_Separator_S.AutoSize = true;
            this.radioBut_Separator_S.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBut_Separator_S.Location = new System.Drawing.Point(57, 26);
            this.radioBut_Separator_S.Name = "radioBut_Separator_S";
            this.radioBut_Separator_S.Size = new System.Drawing.Size(31, 24);
            this.radioBut_Separator_S.TabIndex = 13;
            this.radioBut_Separator_S.TabStop = true;
            this.radioBut_Separator_S.Text = ";";
            this.radioBut_Separator_S.UseVisualStyleBackColor = true;
            // 
            // radioBut_Separator_C
            // 
            this.radioBut_Separator_C.AutoSize = true;
            this.radioBut_Separator_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBut_Separator_C.Location = new System.Drawing.Point(20, 26);
            this.radioBut_Separator_C.Name = "radioBut_Separator_C";
            this.radioBut_Separator_C.Size = new System.Drawing.Size(31, 24);
            this.radioBut_Separator_C.TabIndex = 12;
            this.radioBut_Separator_C.TabStop = true;
            this.radioBut_Separator_C.Text = ",";
            this.radioBut_Separator_C.UseVisualStyleBackColor = true;
            // 
            // button_SaveFile
            // 
            this.button_SaveFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_SaveFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_SaveFile.Location = new System.Drawing.Point(431, 12);
            this.button_SaveFile.Name = "button_SaveFile";
            this.button_SaveFile.Size = new System.Drawing.Size(103, 37);
            this.button_SaveFile.TabIndex = 8;
            this.button_SaveFile.Text = "Сохранить";
            this.button_SaveFile.UseVisualStyleBackColor = true;
            this.button_SaveFile.Click += new System.EventHandler(this.button_SaveFile_Click);
            // 
            // button_OpenFile
            // 
            this.button_OpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_OpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_OpenFile.Location = new System.Drawing.Point(313, 12);
            this.button_OpenFile.Name = "button_OpenFile";
            this.button_OpenFile.Size = new System.Drawing.Size(103, 37);
            this.button_OpenFile.TabIndex = 9;
            this.button_OpenFile.Text = "Выбрать файл";
            this.button_OpenFile.UseVisualStyleBackColor = true;
            this.button_OpenFile.Click += new System.EventHandler(this.button_OpenFile_Click_1);
            // 
            // button_AddRow
            // 
            this.button_AddRow.Location = new System.Drawing.Point(21, 84);
            this.button_AddRow.Name = "button_AddRow";
            this.button_AddRow.Size = new System.Drawing.Size(90, 36);
            this.button_AddRow.TabIndex = 10;
            this.button_AddRow.Text = "Добавить строку";
            this.button_AddRow.UseVisualStyleBackColor = true;
            this.button_AddRow.Click += new System.EventHandler(this.button_AddRow_Click);
            // 
            // button_AddColumn
            // 
            this.button_AddColumn.Location = new System.Drawing.Point(128, 84);
            this.button_AddColumn.Name = "button_AddColumn";
            this.button_AddColumn.Size = new System.Drawing.Size(81, 35);
            this.button_AddColumn.TabIndex = 11;
            this.button_AddColumn.Text = "Добавить столбец";
            this.button_AddColumn.UseVisualStyleBackColor = true;
            this.button_AddColumn.Click += new System.EventHandler(this.button_AddColumn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 373);
            this.Controls.Add(this.button_AddColumn);
            this.Controls.Add(this.button_AddRow);
            this.Controls.Add(this.button_OpenFile);
            this.Controls.Add(this.button_SaveFile);
            this.Controls.Add(this.Separator);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Parser";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Separator.ResumeLayout(false);
            this.Separator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox Separator;
        private System.Windows.Forms.Button button_SaveFile;
        private System.Windows.Forms.Button button_OpenFile;
        private System.Windows.Forms.Button button_AddRow;
        private System.Windows.Forms.Button button_AddColumn;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioBut_Separator_S;
        private System.Windows.Forms.RadioButton radioBut_Separator_C;
    }
}

