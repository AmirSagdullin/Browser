namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.закладкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.историяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.йцуйцуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.йцуйцуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Назад = new System.Windows.Forms.ToolStripButton();
            this.Вперед = new System.Windows.Forms.ToolStripButton();
            this.Обновить = new System.Windows.Forms.ToolStripButton();
            this.Закрыть_вкладку = new System.Windows.Forms.ToolStripButton();
            this.Новая_вкладка = new System.Windows.Forms.ToolStripButton();
            this.Поиск = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.добаувитьВЗакладкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закладкиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.сохранитьИсториюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьИсториюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.историяToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Сохранить_страницу = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Назад,
            this.Вперед,
            this.Обновить,
            this.Закрыть_вкладку,
            this.Новая_вкладка,
            this.Поиск,
            this.toolStripTextBox1,
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.Сохранить_страницу});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(856, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(500, 25);
            this.toolStripTextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox1_KeyUp);
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(856, 425);
            this.tabControl1.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.закладкиToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(126, 26);
            // 
            // закладкиToolStripMenuItem
            // 
            this.закладкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.историяToolStripMenuItem});
            this.закладкиToolStripMenuItem.Name = "закладкиToolStripMenuItem";
            this.закладкиToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.закладкиToolStripMenuItem.Text = "Закладки";
            // 
            // историяToolStripMenuItem
            // 
            this.историяToolStripMenuItem.Name = "историяToolStripMenuItem";
            this.историяToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.историяToolStripMenuItem.Text = "История";
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.йцуйцуToolStripMenuItem});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(115, 26);
            // 
            // йцуйцуToolStripMenuItem
            // 
            this.йцуйцуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.йцуйцуToolStripMenuItem1});
            this.йцуйцуToolStripMenuItem.Name = "йцуйцуToolStripMenuItem";
            this.йцуйцуToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.йцуйцуToolStripMenuItem.Text = "йцуйцу";
            // 
            // йцуйцуToolStripMenuItem1
            // 
            this.йцуйцуToolStripMenuItem1.Name = "йцуйцуToolStripMenuItem1";
            this.йцуйцуToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.йцуйцуToolStripMenuItem1.Text = "йцуйцу";
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(757, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(92, 106);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Назад
            // 
            this.Назад.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Назад.Image = global::WindowsFormsApp1.Properties.Resources.back;
            this.Назад.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Назад.Name = "Назад";
            this.Назад.Size = new System.Drawing.Size(23, 22);
            this.Назад.Text = "toolStripButton1";
            this.Назад.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Вперед
            // 
            this.Вперед.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Вперед.Image = global::WindowsFormsApp1.Properties.Resources.forward;
            this.Вперед.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Вперед.Name = "Вперед";
            this.Вперед.Size = new System.Drawing.Size(23, 22);
            this.Вперед.Text = "toolStripButton2";
            this.Вперед.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // Обновить
            // 
            this.Обновить.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Обновить.Image = global::WindowsFormsApp1.Properties.Resources.update;
            this.Обновить.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Обновить.Name = "Обновить";
            this.Обновить.Size = new System.Drawing.Size(23, 22);
            this.Обновить.Text = "toolStripButton3";
            this.Обновить.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // Закрыть_вкладку
            // 
            this.Закрыть_вкладку.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Закрыть_вкладку.Image = global::WindowsFormsApp1.Properties.Resources.close1;
            this.Закрыть_вкладку.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Закрыть_вкладку.Name = "Закрыть_вкладку";
            this.Закрыть_вкладку.Size = new System.Drawing.Size(23, 22);
            this.Закрыть_вкладку.Text = "toolStripButton4";
            this.Закрыть_вкладку.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // Новая_вкладка
            // 
            this.Новая_вкладка.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Новая_вкладка.Image = global::WindowsFormsApp1.Properties.Resources._new;
            this.Новая_вкладка.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Новая_вкладка.Name = "Новая_вкладка";
            this.Новая_вкладка.Size = new System.Drawing.Size(23, 22);
            this.Новая_вкладка.Text = "toolStripButton5";
            this.Новая_вкладка.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // Поиск
            // 
            this.Поиск.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Поиск.Image = global::WindowsFormsApp1.Properties.Resources.search;
            this.Поиск.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Поиск.Name = "Поиск";
            this.Поиск.Size = new System.Drawing.Size(23, 22);
            this.Поиск.Text = "toolStripButton6";
            this.Поиск.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добаувитьВЗакладкиToolStripMenuItem,
            this.закладкиToolStripMenuItem1});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // добаувитьВЗакладкиToolStripMenuItem
            // 
            this.добаувитьВЗакладкиToolStripMenuItem.Name = "добаувитьВЗакладкиToolStripMenuItem";
            this.добаувитьВЗакладкиToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.добаувитьВЗакладкиToolStripMenuItem.Text = "Добаувить в закладки";
            this.добаувитьВЗакладкиToolStripMenuItem.Click += new System.EventHandler(this.добаувитьВЗакладкиToolStripMenuItem_Click);
            // 
            // закладкиToolStripMenuItem1
            // 
            this.закладкиToolStripMenuItem1.Name = "закладкиToolStripMenuItem1";
            this.закладкиToolStripMenuItem1.Size = new System.Drawing.Size(193, 22);
            this.закладкиToolStripMenuItem1.Text = "Закладки";
            this.закладкиToolStripMenuItem1.Click += new System.EventHandler(this.закладкиToolStripMenuItem1_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьИсториюToolStripMenuItem,
            this.удалитьИсториюToolStripMenuItem,
            this.историяToolStripMenuItem1});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton2.Text = "toolStripDropDownButton2";
            // 
            // сохранитьИсториюToolStripMenuItem
            // 
            this.сохранитьИсториюToolStripMenuItem.Name = "сохранитьИсториюToolStripMenuItem";
            this.сохранитьИсториюToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.сохранитьИсториюToolStripMenuItem.Text = "Сохранить историю";
            this.сохранитьИсториюToolStripMenuItem.Click += new System.EventHandler(this.сохранитьИсториюToolStripMenuItem_Click);
            // 
            // удалитьИсториюToolStripMenuItem
            // 
            this.удалитьИсториюToolStripMenuItem.Name = "удалитьИсториюToolStripMenuItem";
            this.удалитьИсториюToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.удалитьИсториюToolStripMenuItem.Text = "Удалить историю";
            this.удалитьИсториюToolStripMenuItem.Click += new System.EventHandler(this.удалитьИсториюToolStripMenuItem_Click);
            // 
            // историяToolStripMenuItem1
            // 
            this.историяToolStripMenuItem1.Name = "историяToolStripMenuItem1";
            this.историяToolStripMenuItem1.Size = new System.Drawing.Size(185, 22);
            this.историяToolStripMenuItem1.Text = "История";
            this.историяToolStripMenuItem1.Click += new System.EventHandler(this.историяToolStripMenuItem1_Click);
            // 
            // Сохранить_страницу
            // 
            this.Сохранить_страницу.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Сохранить_страницу.Image = ((System.Drawing.Image)(resources.GetObject("Сохранить_страницу.Image")));
            this.Сохранить_страницу.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Сохранить_страницу.Name = "Сохранить_страницу";
            this.Сохранить_страницу.Size = new System.Drawing.Size(23, 22);
            this.Сохранить_страницу.Text = "toolStripButton1";
            this.Сохранить_страницу.Click += new System.EventHandler(this.Сохранить_страницу_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.HelpButton = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Назад;
        private System.Windows.Forms.ToolStripButton Вперед;
        private System.Windows.Forms.ToolStripButton Обновить;
        private System.Windows.Forms.ToolStripButton Закрыть_вкладку;
        private System.Windows.Forms.ToolStripButton Новая_вкладка;
        private System.Windows.Forms.ToolStripButton Поиск;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem закладкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem историяToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem йцуйцуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem йцуйцуToolStripMenuItem1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem добаувитьВЗакладкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закладкиToolStripMenuItem1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem сохранитьИсториюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьИсториюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem историяToolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton Сохранить_страницу;
    }
}

