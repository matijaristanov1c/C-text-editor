namespace Domaci
{
    partial class MatijaRistanovicS2720
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
            this.rtBox = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fontBoldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontItalicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Pronadji = new System.Windows.Forms.TextBox();
            this.Zameni = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtBox
            // 
            this.rtBox.ContextMenuStrip = this.contextMenuStrip1;
            this.rtBox.Location = new System.Drawing.Point(12, 158);
            this.rtBox.Name = "rtBox";
            this.rtBox.Size = new System.Drawing.Size(776, 280);
            this.rtBox.TabIndex = 0;
            this.rtBox.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontBoldToolStripMenuItem,
            this.fontItalicToolStripMenuItem,
            this.fontColorToolStripMenuItem,
            this.selectFontToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(133, 92);
            // 
            // fontBoldToolStripMenuItem
            // 
            this.fontBoldToolStripMenuItem.Name = "fontBoldToolStripMenuItem";
            this.fontBoldToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.fontBoldToolStripMenuItem.Text = "Font Bold";
            this.fontBoldToolStripMenuItem.Click += new System.EventHandler(this.fontBoldToolStripMenuItem_Click);
            // 
            // fontItalicToolStripMenuItem
            // 
            this.fontItalicToolStripMenuItem.Name = "fontItalicToolStripMenuItem";
            this.fontItalicToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.fontItalicToolStripMenuItem.Text = "Font Italic";
            this.fontItalicToolStripMenuItem.Click += new System.EventHandler(this.fontItalicToolStripMenuItem_Click);
            // 
            // fontColorToolStripMenuItem
            // 
            this.fontColorToolStripMenuItem.Name = "fontColorToolStripMenuItem";
            this.fontColorToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.fontColorToolStripMenuItem.Text = "Font Color";
            this.fontColorToolStripMenuItem.Click += new System.EventHandler(this.fontColorToolStripMenuItem_Click);
            // 
            // selectFontToolStripMenuItem
            // 
            this.selectFontToolStripMenuItem.Name = "selectFontToolStripMenuItem";
            this.selectFontToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.selectFontToolStripMenuItem.Text = "Select Font";
            this.selectFontToolStripMenuItem.Click += new System.EventHandler(this.selectFontToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pronadji";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Zameni";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Pronadji
            // 
            this.Pronadji.Location = new System.Drawing.Point(274, 42);
            this.Pronadji.Name = "Pronadji";
            this.Pronadji.Size = new System.Drawing.Size(100, 20);
            this.Pronadji.TabIndex = 7;
            // 
            // Zameni
            // 
            this.Zameni.Location = new System.Drawing.Point(274, 77);
            this.Zameni.Name = "Zameni";
            this.Zameni.Size = new System.Drawing.Size(100, 20);
            this.Zameni.TabIndex = 8;
            this.Zameni.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button4
            // 
            this.button4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button4.Image = global::Domaci.Properties.Resources.Delete_80_icon_icons_com_57340;
            this.button4.Location = new System.Drawing.Point(694, 42);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 94);
            this.button4.TabIndex = 4;
            this.button4.Text = "Zatvori program";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Image = global::Domaci.Properties.Resources._1904659_arrow_backup_down_download_save_storage_transfer_122509;
            this.button3.Location = new System.Drawing.Point(516, 42);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 94);
            this.button3.TabIndex = 3;
            this.button3.Text = "Snimi fajl";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Image = global::Domaci.Properties.Resources.find_replace_117642;
            this.button2.Location = new System.Drawing.Point(406, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 94);
            this.button2.TabIndex = 2;
            this.button2.Text = "Pronadji i zameni";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::Domaci.Properties.Resources._3643772_archive_archives_document_folder_open_113445;
            this.button1.Location = new System.Drawing.Point(12, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 94);
            this.button1.TabIndex = 1;
            this.button1.Text = "Otvori fajl";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MatijaRistanovicS2720
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button4;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Zameni);
            this.Controls.Add(this.Pronadji);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtBox);
            this.Name = "MatijaRistanovicS2720";
            this.Text = "MatijaRistanovicS2720";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Pronadji;
        private System.Windows.Forms.TextBox Zameni;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fontBoldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontItalicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectFontToolStripMenuItem;
    }
}

