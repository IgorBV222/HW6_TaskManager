namespace HW6_TaskManager
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
            this.dgMain = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.времяОбновленияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьСДиалогомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_note = new System.Windows.Forms.Button();
            this.btn_calculator = new System.Windows.Forms.Button();
            this.btn_paint = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_AppName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgMain)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgMain
            // 
            this.dgMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMain.ContextMenuStrip = this.contextMenuStrip1;
            this.dgMain.Location = new System.Drawing.Point(13, 12);
            this.dgMain.Name = "dgMain";
            this.dgMain.Size = new System.Drawing.Size(651, 543);
            this.dgMain.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.времяОбновленияToolStripMenuItem,
            this.закрытьToolStripMenuItem,
            this.закрытьСДиалогомToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(187, 70);
            // 
            // времяОбновленияToolStripMenuItem
            // 
            this.времяОбновленияToolStripMenuItem.Name = "времяОбновленияToolStripMenuItem";
            this.времяОбновленияToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.времяОбновленияToolStripMenuItem.Text = "Время обновления";
            this.времяОбновленияToolStripMenuItem.Click += new System.EventHandler(this.времяОбновленияToolStripMenuItem_Click_1);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            // 
            // закрытьСДиалогомToolStripMenuItem
            // 
            this.закрытьСДиалогомToolStripMenuItem.Name = "закрытьСДиалогомToolStripMenuItem";
            this.закрытьСДиалогомToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.закрытьСДиалогомToolStripMenuItem.Text = "Закрыть с диалогом";
            // 
            // btn_note
            // 
            this.btn_note.Location = new System.Drawing.Point(1004, 27);
            this.btn_note.Name = "btn_note";
            this.btn_note.Size = new System.Drawing.Size(86, 23);
            this.btn_note.TabIndex = 1;
            this.btn_note.Text = "Блокнот";
            this.btn_note.UseVisualStyleBackColor = true;
            this.btn_note.Click += new System.EventHandler(this.btn_note_Click);
            // 
            // btn_calculator
            // 
            this.btn_calculator.Location = new System.Drawing.Point(1004, 65);
            this.btn_calculator.Name = "btn_calculator";
            this.btn_calculator.Size = new System.Drawing.Size(86, 23);
            this.btn_calculator.TabIndex = 2;
            this.btn_calculator.Text = "Калькулятор";
            this.btn_calculator.UseVisualStyleBackColor = true;
            this.btn_calculator.Click += new System.EventHandler(this.btn_calculator_Click);
            // 
            // btn_paint
            // 
            this.btn_paint.Location = new System.Drawing.Point(1004, 103);
            this.btn_paint.Name = "btn_paint";
            this.btn_paint.Size = new System.Drawing.Size(86, 23);
            this.btn_paint.TabIndex = 3;
            this.btn_paint.Text = "Paint";
            this.btn_paint.UseVisualStyleBackColor = true;
            this.btn_paint.Click += new System.EventHandler(this.btn_paint_Click);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(1015, 198);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 4;
            this.btn_start.Text = "Старт";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(936, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите название приложения для запуска";
            // 
            // tbox_AppName
            // 
            this.tbox_AppName.Location = new System.Drawing.Point(939, 172);
            this.tbox_AppName.Name = "tbox_AppName";
            this.tbox_AppName.Size = new System.Drawing.Size(227, 20);
            this.tbox_AppName.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 567);
            this.Controls.Add(this.tbox_AppName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_paint);
            this.Controls.Add(this.btn_calculator);
            this.Controls.Add(this.btn_note);
            this.Controls.Add(this.dgMain);
            this.Name = "Form1";
            this.Text = "Диспетчер задач";
            ((System.ComponentModel.ISupportInitialize)(this.dgMain)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMain;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem времяОбновленияToolStripMenuItem;
        private System.Windows.Forms.Button btn_note;
        private System.Windows.Forms.Button btn_calculator;
        private System.Windows.Forms.Button btn_paint;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_AppName;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьСДиалогомToolStripMenuItem;
    }
}

