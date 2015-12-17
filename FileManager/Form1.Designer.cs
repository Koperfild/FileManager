namespace FileManager
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.shellView1 = new GongSolutions.Shell.ShellView();
            this.fileDialogToolbar1 = new GongSolutions.Shell.FileDialogToolbar();
            this.shellTreeView1 = new GongSolutions.Shell.ShellTreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // shellView1
            // 
            this.shellView1.Location = new System.Drawing.Point(212, 46);
            this.shellView1.Name = "shellView1";
            this.shellView1.Size = new System.Drawing.Size(697, 414);
            this.shellView1.StatusBar = null;
            this.shellView1.TabIndex = 3;
            this.shellView1.Text = "shellView1";
            this.shellView1.DoubleClick += new System.EventHandler(this.shellView1_DoubleClick);
            this.shellView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.shellView1_KeyPress);
            // 
            // fileDialogToolbar1
            // 
            this.fileDialogToolbar1.AllowDrop = true;
            this.fileDialogToolbar1.AutoSize = true;
            this.fileDialogToolbar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.fileDialogToolbar1.Location = new System.Drawing.Point(0, 0);
            this.fileDialogToolbar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fileDialogToolbar1.Name = "fileDialogToolbar1";
            this.fileDialogToolbar1.ShellView = this.shellView1;
            this.fileDialogToolbar1.Size = new System.Drawing.Size(1007, 39);
            this.fileDialogToolbar1.TabIndex = 2;
            this.fileDialogToolbar1.LocationChanged += new System.EventHandler(this.fileDialogToolbar1_LocationChanged);
            // 
            // shellTreeView1
            // 
            this.shellTreeView1.Location = new System.Drawing.Point(12, 46);
            this.shellTreeView1.Name = "shellTreeView1";
            this.shellTreeView1.ShellView = this.shellView1;
            this.shellTreeView1.Size = new System.Drawing.Size(194, 414);
            this.shellTreeView1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 486);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Число файлов:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 486);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Общий размер:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(566, 485);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Размер текущего элемента:";
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 537);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shellTreeView1);
            this.Controls.Add(this.shellView1);
            this.Controls.Add(this.fileDialogToolbar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private GongSolutions.Shell.FileDialogToolbar fileDialogToolbar1;
        private GongSolutions.Shell.ShellView shellView1;
        private GongSolutions.Shell.ShellTreeView shellTreeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        

    }
}

