using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domaci
{
    public partial class MatijaRistanovicS2720 : Form
    {
        public MatijaRistanovicS2720()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Otvori fajl
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Txt files (*.txt) |*.txt| Richtext files (*.rtf)|*.rtf";
            try
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    if(ofd.FileName != "")
                    {
                        if(Path.GetExtension(ofd.FileName) == ".rtf")
                        {
                            rtBox.LoadFile(ofd.FileName, RichTextBoxStreamType.RichText);
                        }
                        else
                        {
                            rtBox.LoadFile(ofd.FileName, RichTextBoxStreamType.PlainText);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e) // Pronadji i zameni
        {
            string pronadji = Pronadji.Text.Trim();
            string zameni = Zameni.Text.Trim();
            string rich = rtBox.Text.Trim();
            bool provera = true;

            while (provera)
            {
                try
                {
                    if(rich == "")
                    {
                        MessageBox.Show("Richtext mora imati sadrzaj");
                        break;
                    }
                    else if(pronadji == "")
                    {
                        MessageBox.Show("Tekst mora imati sadrzaj");
                        Pronadji.Focus();
                        break;
                    }
                    else if(zameni == "")
                    {
                        MessageBox.Show("Tekst koji se menja mora imati neki sadrzaj");
                        Zameni.Focus();
                        break;
                    }
                    string zamena = rich.Replace(pronadji, zameni);
                    rtBox.Text = zamena;
                    provera = false;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void button3_Click(object sender, EventArgs e) // Snimi fajl
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Richtext format(*.rtf) |*.rtf";
            bool izvrsi = true;

            while (izvrsi)
            {
                try
                {
                    if(rtBox.Text.Trim() == "")
                    {
                        MessageBox.Show("Morate uneti sadrzaj da bi ste sacuvali fajl");
                        break;
                    }
                    if(sfd.ShowDialog() == DialogResult.OK)
                    {
                        string sacuvaj = sfd.FileName;
                        rtBox.SaveFile(sacuvaj);
                        MessageBox.Show("Fajl uspesno sacuvan");
                        rtBox.Text = "";
                        izvrsi = false;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void button4_Click(object sender, EventArgs e) // Zatvori program
        {
            try
            {
                DialogResult dr = MessageBox.Show("Da li ste sigurni da zatvarate program?", "Application exit", MessageBoxButtons.YesNo);
                if(dr == DialogResult.Yes)
                {
                    Application.Exit();
                }
                return;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void fontBoldToolStripMenuItem_Click(object sender, EventArgs e) // Bold
        {
            try
            {
                rtBox.SelectionFont = new Font(rtBox.SelectionFont, FontStyle.Bold);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void fontItalicToolStripMenuItem_Click(object sender, EventArgs e) // Italic
        {
            try
            {
                rtBox.SelectionFont = new Font(rtBox.SelectionFont, FontStyle.Italic);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e) // Boja
        {
            try
            {
                ColorDialog color = new ColorDialog();
                if (color.ShowDialog() == DialogResult.OK)
                {
                    rtBox.SelectionColor = color.Color;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void selectFontToolStripMenuItem_Click(object sender, EventArgs e) // Font
        {
            try
            {
                FontDialog font = new FontDialog();
                if (font.ShowDialog() == DialogResult.OK)
                {
                    rtBox.SelectionFont = font.Font;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
