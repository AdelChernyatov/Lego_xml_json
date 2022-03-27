namespace Lego_xml_json
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGV_1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGV2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGV3 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailcount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profession = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_of = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spezialization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.combo_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.det_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialCombo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count_People = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGV_1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGV_1
            // 
            this.dataGV_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.surname,
            this.age,
            this.country,
            this.detailcount,
            this.profession});
            this.dataGV_1.Location = new System.Drawing.Point(3, 3);
            this.dataGV_1.Name = "dataGV_1";
            this.dataGV_1.RowHeadersWidth = 51;
            this.dataGV_1.RowTemplate.Height = 24;
            this.dataGV_1.Size = new System.Drawing.Size(789, 412);
            this.dataGV_1.TabIndex = 0;
            this.dataGV_1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_1_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGV2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGV2
            // 
            this.dataGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.title,
            this.date_of,
            this.floors,
            this.spezialization,
            this.capacity,
            this.color});
            this.dataGV2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGV2.Location = new System.Drawing.Point(3, 3);
            this.dataGV2.Name = "dataGV2";
            this.dataGV2.RowHeadersWidth = 51;
            this.dataGV2.RowTemplate.Height = 24;
            this.dataGV2.Size = new System.Drawing.Size(786, 415);
            this.dataGV2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGV3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 421);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGV3
            // 
            this.dataGV3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.combo_name,
            this.price,
            this.det_count,
            this.hero,
            this.villain,
            this.specialCombo,
            this.count_People});
            this.dataGV3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGV3.Location = new System.Drawing.Point(3, 3);
            this.dataGV3.Name = "dataGV3";
            this.dataGV3.RowHeadersWidth = 51;
            this.dataGV3.RowTemplate.Height = 24;
            this.dataGV3.Size = new System.Drawing.Size(786, 415);
            this.dataGV3.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // name
            // 
            this.name.HeaderText = "name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 125;
            // 
            // surname
            // 
            this.surname.HeaderText = "surname";
            this.surname.MinimumWidth = 6;
            this.surname.Name = "surname";
            this.surname.Width = 125;
            // 
            // age
            // 
            this.age.HeaderText = "age";
            this.age.MinimumWidth = 6;
            this.age.Name = "age";
            this.age.Width = 125;
            // 
            // country
            // 
            this.country.HeaderText = "country";
            this.country.MinimumWidth = 6;
            this.country.Name = "country";
            this.country.Width = 125;
            // 
            // detailcount
            // 
            this.detailcount.HeaderText = "detailcount";
            this.detailcount.MinimumWidth = 6;
            this.detailcount.Name = "detailcount";
            this.detailcount.Width = 125;
            // 
            // profession
            // 
            this.profession.HeaderText = "profession";
            this.profession.MinimumWidth = 6;
            this.profession.Name = "profession";
            this.profession.Width = 125;
            // 
            // number
            // 
            this.number.HeaderText = "number";
            this.number.MinimumWidth = 6;
            this.number.Name = "number";
            this.number.Width = 125;
            // 
            // title
            // 
            this.title.HeaderText = "title";
            this.title.MinimumWidth = 6;
            this.title.Name = "title";
            this.title.Width = 125;
            // 
            // date_of
            // 
            this.date_of.HeaderText = "date_of";
            this.date_of.MinimumWidth = 6;
            this.date_of.Name = "date_of";
            this.date_of.Width = 125;
            // 
            // floors
            // 
            this.floors.HeaderText = "floors";
            this.floors.MinimumWidth = 6;
            this.floors.Name = "floors";
            this.floors.Width = 125;
            // 
            // spezialization
            // 
            this.spezialization.HeaderText = "spezialization";
            this.spezialization.MinimumWidth = 6;
            this.spezialization.Name = "spezialization";
            this.spezialization.Width = 125;
            // 
            // capacity
            // 
            this.capacity.HeaderText = "capacity";
            this.capacity.MinimumWidth = 6;
            this.capacity.Name = "capacity";
            this.capacity.Width = 125;
            // 
            // color
            // 
            this.color.HeaderText = "color";
            this.color.MinimumWidth = 6;
            this.color.Name = "color";
            this.color.Width = 125;
            // 
            // index
            // 
            this.index.HeaderText = "index";
            this.index.MinimumWidth = 6;
            this.index.Name = "index";
            this.index.Width = 125;
            // 
            // combo_name
            // 
            this.combo_name.HeaderText = "combo_name";
            this.combo_name.MinimumWidth = 6;
            this.combo_name.Name = "combo_name";
            this.combo_name.Width = 125;
            // 
            // price
            // 
            this.price.HeaderText = "price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.Width = 125;
            // 
            // det_count
            // 
            this.det_count.HeaderText = "det_count";
            this.det_count.MinimumWidth = 6;
            this.det_count.Name = "det_count";
            this.det_count.Width = 125;
            // 
            // hero
            // 
            this.hero.HeaderText = "hero";
            this.hero.MinimumWidth = 6;
            this.hero.Name = "hero";
            this.hero.Width = 125;
            // 
            // villain
            // 
            this.villain.HeaderText = "villain";
            this.villain.MinimumWidth = 6;
            this.villain.Name = "villain";
            this.villain.Width = 125;
            // 
            // specialCombo
            // 
            this.specialCombo.HeaderText = "specialCombo";
            this.specialCombo.MinimumWidth = 6;
            this.specialCombo.Name = "specialCombo";
            this.specialCombo.Width = 125;
            // 
            // count_People
            // 
            this.count_People.HeaderText = "count_People";
            this.count_People.MinimumWidth = 6;
            this.count_People.Name = "count_People";
            this.count_People.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGV_1;
        private System.Windows.Forms.DataGridView dataGV2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGV3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn country;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailcount;
        private System.Windows.Forms.DataGridViewTextBoxColumn profession;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_of;
        private System.Windows.Forms.DataGridViewTextBoxColumn floors;
        private System.Windows.Forms.DataGridViewTextBoxColumn spezialization;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn combo_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn det_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn hero;
        private System.Windows.Forms.DataGridViewTextBoxColumn villain;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialCombo;
        private System.Windows.Forms.DataGridViewTextBoxColumn count_People;
    }
}

