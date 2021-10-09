/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2020-2021 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 2
**				ÖĞRENCİ ADI............: TEA SHKURTİ
**				ÖĞRENCİ NUMARASI.......: B191210555
**                   DERSİN ALINDIĞI GRUP...: 1 Öğretim C grubu
****************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Soru2
{   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button15_Click(object sender, EventArgs e)
        {
                    Close();
        }
        //Toplama butonu basınca bu fonksiyon çalışacak
        //yeni bir tablo oluşturur
        private void btnToplama_Click(object sender, EventArgs e)
        {
            
            Label labelText1 = new Label();
            labelText1.Text = "Matris A + B";
            labelText1.Size = new Size(203, 29);
            labelText1.Location = new Point(70, 475);
            labelText1.BringToFront();
            labelText1.AutoSize = true;
            labelText1.Font = new Font("MV Boli", 14, FontStyle.Bold);
            labelText1.BackColor = Color.FromArgb(0, 0, 64);
            labelText1.ForeColor = Color.White;
            Controls.Add(labelText1);

            Label lblParantez = new Label();
            lblParantez.SendToBack();
            lblParantez.Text = "[";
            lblParantez.Location = new Point(29, 517);
            lblParantez.AutoSize = false;
            lblParantez.Font = new Font("MS Gothic", 72);
            lblParantez.BackColor = Color.FromArgb(0, 0, 64);
            lblParantez.ForeColor = Color.White;
            lblParantez.Size = new Size(180, 120);
            this.Controls.Add(lblParantez);

            Label lblC11 = new Label();
            lblC11.Location = new Point(107, 534);
            lblC11.AutoSize = false;
            lblC11.Font = new Font("Calibri", 11);
            lblC11.BackColor = Color.FromArgb(245, 245, 245);
            lblC11.ForeColor = Color.Black;
            lblC11.Size = new Size(35, 25);
            this.Controls.Add(lblC11);

            Label lblC12 = new Label();
            lblC12.Text = "";
            lblC12.Location = new Point(148, 534);
            lblC12.AutoSize = false;
            lblC12.Font = new Font("Calibri", 11);
            lblC12.BackColor = Color.FromArgb(245, 245, 245);
            lblC12.ForeColor = Color.Black;
            lblC12.Size = new Size(35, 25);
            this.Controls.Add(lblC12);

            Label lblC13 = new Label();
            lblC13.Text = "";
            lblC13.Location = new Point(189, 534);
            lblC13.AutoSize = false;
            lblC13.Font = new Font("Calibri", 11);
            lblC13.BackColor = Color.FromArgb(245, 245, 245);
            lblC13.ForeColor = Color.Black;
            lblC13.Size = new Size(35, 25);
            this.Controls.Add(lblC13);

            Label lblC21 = new Label();
            lblC21.Text = "";
            lblC21.Location = new Point(107, 568);
            lblC21.AutoSize = false;
            lblC21.Font = new Font("Calibri", 11);
            lblC21.BackColor = Color.FromArgb(245, 245, 245);
            lblC21.ForeColor = Color.Black;
            lblC21.Size = new Size(35, 25);
            this.Controls.Add(lblC21);

            Label lblC22 = new Label();
            lblC22.Text = "";
            lblC22.Location = new Point(148, 568);
            lblC22.AutoSize = false;
            lblC22.Font = new Font("Calibri", 11);
            lblC22.BackColor = Color.FromArgb(245, 245, 245);
            lblC22.ForeColor = Color.Black;
            lblC22.Size = new Size(35, 25);
            this.Controls.Add(lblC22);

            Label lblC23 = new Label();
            lblC23.Text = "";
            lblC12.BringToFront();
            lblC23.Location = new Point(189, 568);
            lblC23.AutoSize = false;
            lblC23.Font = new Font("Calibri", 11);
            lblC23.BackColor = Color.FromArgb(245, 245, 245);
            lblC23.ForeColor = Color.Black;
            lblC23.Size = new Size(35, 25);
            this.Controls.Add(lblC23);

            Label lblC31 = new Label();
            lblC31.Text = "";
            lblC31.Location = new Point(107, 601);
            lblC31.AutoSize = false;
            lblC31.Font = new Font("Calibri", 11);
            lblC31.BackColor = Color.FromArgb(245, 245, 245);
            lblC31.ForeColor = Color.Black;
            lblC31.Size = new Size(35, 25);
            this.Controls.Add(lblC31);

            Label lblC32 = new Label();
            lblC32.Text = "";
            lblC32.Location = new Point(148, 601);
            lblC32.AutoSize = false;
            lblC32.Font = new Font("Calibri", 11);
            lblC32.BackColor = Color.FromArgb(245, 245, 245);
            lblC32.ForeColor = Color.Black;
            lblC32.Size = new Size(35, 25);
            this.Controls.Add(lblC32);

            Label lblC33 = new Label();
            lblC33.Text = "";
            lblC33.Location = new Point(189, 601);
            lblC33.AutoSize = false;
            lblC33.Font = new Font("Calibri", 11);
            lblC33.BackColor = Color.FromArgb(245, 245, 245);
            lblC33.ForeColor = Color.Black;
            lblC33.Size = new Size(35, 25);
            this.Controls.Add(lblC33);

            Label lblParantez1 = new Label();
            lblParantez1.SendToBack();
            lblParantez1.Text = "]";
            lblParantez1.Location = new Point(202, 518);
            lblParantez1.AutoSize = false;
            lblParantez1.Font = new Font("MS Gothic", 72);
            lblParantez1.BackColor = Color.FromArgb(0, 0, 64);
            lblParantez1.ForeColor = Color.White;
            lblParantez1.Size = new Size(170, 120);
            this.Controls.Add(lblParantez1);

            int[,] a = new int[3, 3];    //A matristen girilen sayılar
             
            int[,] b = new int[3, 3];    // B matristen girilen sayılar

            int[,] c = new int[3, 3];    // yeni oluşturulacak matris

            //Değerleri okunur
            a[0, 0] = Convert.ToInt32(txtA11.Text);
            a[1, 0] = Convert.ToInt32(txtA12.Text);
            a[2, 0] = Convert.ToInt32(txtA13.Text);
            a[0, 1] = Convert.ToInt32(txtA21.Text);
            a[1, 1] = Convert.ToInt32(txtA22.Text);
            a[2, 1] = Convert.ToInt32(txtA23.Text);
            a[0, 2] = Convert.ToInt32(txtA31.Text);
            a[1, 2] = Convert.ToInt32(txtA32.Text);
            a[2, 2] = Convert.ToInt32(txtA33.Text);

            b[0, 0] = Convert.ToInt32(txtB11.Text);
            b[1, 0] = Convert.ToInt32(txtB12.Text);
            b[2, 0] = Convert.ToInt32(txtB13.Text);
            b[0, 1] = Convert.ToInt32(txtB21.Text);
            b[1, 1] = Convert.ToInt32(txtB22.Text);
            b[2, 1] = Convert.ToInt32(txtB23.Text);
            b[0, 2] = Convert.ToInt32(txtB31.Text);
            b[1, 2] = Convert.ToInt32(txtB32.Text);
            b[2, 2] = Convert.ToInt32(txtB33.Text);

            c = Matris.MatrisToplama(a, b);     //Matris static sınıfından MatrisToplama oluşturdum metodu kullanıyorum

            lblC11.Text = Convert.ToString(c[0,0]);
            lblC11.BringToFront();
            lblC12.Text = Convert.ToString(c[1, 0]);
            lblC12.BringToFront();
            lblC13.Text = Convert.ToString(c[2, 0]);
            lblC13.BringToFront();
            lblC21.Text = Convert.ToString(c[0, 1]);
            lblC21.BringToFront();
            lblC22.Text = Convert.ToString(c[1, 1]);
            lblC22.BringToFront();
            lblC23.Text = Convert.ToString(c[2, 1]);
            lblC23.BringToFront();
            lblC31.Text = Convert.ToString(c[0, 2]);
            lblC31.BringToFront();
            lblC32.Text = Convert.ToString(c[1, 2]);
            lblC32.BringToFront();
            lblC33.Text = Convert.ToString(c[2, 2]);
            lblC33.BringToFront();
        }
        //Çarpma butonu basınca bu fonksiyon çalışacak
        //yeni bir tablo oluşturur
        private void btnCarpma_Click(object sender, EventArgs e)
        {
            Label labelText2 = new Label();
            labelText2.Text = "Matris A x B";
            labelText2.BringToFront();
            labelText2.Size = new Size(223, 29);
            labelText2.Location = new Point(478, 475);
            labelText2.AutoSize = false;
            labelText2.Font = new Font("MV Boli", 14, FontStyle.Bold);
            labelText2.BackColor = Color.FromArgb(0, 0, 64);
            labelText2.ForeColor = Color.White;
            this.Controls.Add(labelText2);

            Label lblParantez2 = new Label();
            lblParantez2.SendToBack();
            lblParantez2.Text = "[";
            lblParantez2.Location = new Point(445, 519);
            lblParantez2.AutoSize = false;
            lblParantez2.Font = new Font("MS Gothic", 72);
            lblParantez2.BackColor = Color.FromArgb(0, 0, 64);
            lblParantez2.ForeColor = Color.White;
            lblParantez2.Size = new Size(170, 120);
            this.Controls.Add(lblParantez2);

            Label lblD11 = new Label();
            lblD11.BringToFront();
            lblD11.Location = new Point(523, 534);
            lblD11.AutoSize = false;
            lblD11.Font = new Font("Calibri", 11);
            lblD11.BackColor = Color.FromArgb(245, 245, 245);
            lblD11.ForeColor = Color.Black;
            lblD11.Size = new Size(35, 25);
            this.Controls.Add(lblD11);

            Label lblD12 = new Label();
            lblD12.Text = "";
            lblD12.Location = new Point(564, 534);
            lblD12.AutoSize = false;
            lblD12.Font = new Font("Calibri", 11);
            lblD12.BackColor = Color.FromArgb(245, 245, 245);
            lblD12.ForeColor = Color.Black;
            lblD12.Size = new Size(35, 25);
            this.Controls.Add(lblD12);

            Label lblD13 = new Label();
            lblD13.Text = "";
            lblD13.Location = new Point(605, 534);
            lblD13.AutoSize = false;
            lblD13.Font = new Font("Calibri", 11);
            lblD13.BackColor = Color.FromArgb(245, 245, 245);
            lblD13.ForeColor = Color.Black;
            lblD13.Size = new Size(35, 25);
            this.Controls.Add(lblD13);

            Label lblD21 = new Label();
            lblD21.Text = "";
            lblD21.Location = new Point(523, 568);
            lblD21.AutoSize = false;
            lblD21.Font = new Font("Calibri", 11);
            lblD21.BackColor = Color.FromArgb(245, 245, 245);
            lblD21.ForeColor = Color.Black;
            lblD21.Size = new Size(35, 25);
            this.Controls.Add(lblD21);

            Label lblD22 = new Label();
            lblD22.Text = "";
            lblD22.Location = new Point(564, 568);
            lblD22.AutoSize = false;
            lblD22.Font = new Font("Calibri", 11);
            lblD22.BackColor = Color.FromArgb(245, 245, 245);
            lblD22.ForeColor = Color.Black;
            lblD22.Size = new Size(35, 25);
            this.Controls.Add(lblD22);

            Label lblD23 = new Label();
            lblD23.Text = "43";
            lblD23.Location = new Point(605, 568);
            lblD23.AutoSize = false;
            lblD23.Font = new Font("Calibri", 11);
            lblD23.BackColor = Color.FromArgb(245, 245, 245);
            lblD23.ForeColor = Color.Black;
            lblD23.Size = new Size(35, 25);
            this.Controls.Add(lblD23);

            Label lblD31 = new Label();
            lblD31.Text = "";
            lblD31.Location = new Point(523, 601);
            lblD31.AutoSize = false;
            lblD31.Font = new Font("Calibri", 11);
            lblD31.BackColor = Color.FromArgb(245, 245, 245);
            lblD31.ForeColor = Color.Black;
            lblD31.Size = new Size(35, 25);
            this.Controls.Add(lblD31);

            Label lblD32 = new Label();
            lblD32.Text = "";
            lblD32.Location = new Point(564, 601);
            lblD32.AutoSize = false;
            lblD32.Font = new Font("Calibri", 11);
            lblD32.BackColor = Color.FromArgb(245, 245, 245);
            lblD32.ForeColor = Color.Black;
            lblD32.Size = new Size(35, 25);
            this.Controls.Add(lblD32);

            Label lblD33 = new Label();
            lblD33.Text = "";
            lblD33.Location = new Point(605, 601);
            lblD33.AutoSize = false;
            lblD33.Font = new Font("Calibri", 11);
            lblD33.BackColor = Color.FromArgb(245, 245, 245);
            lblD33.ForeColor = Color.Black;
            lblD33.Size = new Size(35, 25);
            this.Controls.Add(lblD33);

            Label lblParantez3 = new Label();
            lblParantez3.SendToBack();
            lblParantez3.Text = "]";
            lblParantez3.Location = new Point(617, 518);
            lblParantez3.AutoSize = false;
            lblParantez3.Font = new Font("MS Gothic", 72);
            lblParantez3.BackColor = Color.FromArgb(0, 0, 64);
            lblParantez3.ForeColor = Color.White;
            lblParantez3.Size = new Size(170, 120);
            this.Controls.Add(lblParantez3);

            Int32[,] a = new Int32[3, 3];           //A matristen girilen sayılar

            Int32[,] b = new Int32[3, 3];           // B matristen girilen sayılar

            Int32[,] d = new Int32[3, 3];           // yeni oluşturulacak matris

            //Değerleri okunur
            a[0, 0] = Convert.ToInt32(txtA11.Text);
            a[1, 0] = Convert.ToInt32(txtA12.Text);
            a[2, 0] = Convert.ToInt32(txtA13.Text);
            a[0, 1] = Convert.ToInt32(txtA21.Text);
            a[1, 1] = Convert.ToInt32(txtA22.Text);
            a[2, 1] = Convert.ToInt32(txtA23.Text);
            a[0, 2] = Convert.ToInt32(txtA31.Text);
            a[1, 2] = Convert.ToInt32(txtA32.Text);
            a[2, 2] = Convert.ToInt32(txtA33.Text);

            b[0, 0] = Convert.ToInt32(txtB11.Text);
            b[1, 0] = Convert.ToInt32(txtB12.Text);
            b[2, 0] = Convert.ToInt32(txtB13.Text);
            b[0, 1] = Convert.ToInt32(txtB21.Text);
            b[1, 1] = Convert.ToInt32(txtB22.Text);
            b[2, 1] = Convert.ToInt32(txtB23.Text);
            b[0, 2] = Convert.ToInt32(txtB31.Text);
            b[1, 2] = Convert.ToInt32(txtB32.Text);
            b[2, 2] = Convert.ToInt32(txtB33.Text);

            d = Matris.MatrisCarpma(a, b);               //Matris static sınıfından MatrisCarpma oluşturdum metodu kullanıyorum

            lblD11.Text = Convert.ToString(d[0, 0]);
            lblD11.BringToFront();
            lblD12.Text = Convert.ToString(d[1, 0]);
            lblD12.BringToFront();
            lblD13.Text = Convert.ToString(d[2, 0]);
            lblD13.BringToFront();
            lblD21.Text = Convert.ToString(d[0, 1]);
            lblD21.BringToFront();
            lblD22.Text = Convert.ToString(d[1, 1]);
            lblD22.BringToFront();
            lblD23.Text = Convert.ToString(d[2, 1]);
            lblD23.BringToFront();
            lblD31.Text = Convert.ToString(d[0, 2]);
            lblD31.BringToFront();
            lblD32.Text = Convert.ToString(d[1, 2]);
            lblD32.BringToFront();
            lblD33.Text = Convert.ToString(d[2, 2]);
            lblD33.BringToFront();
        }
        //Ters butonu basınca bu fonksiyon çalışacak
        //yeni bir tablo oluşturur
        private void btnATers_Click(object sender, EventArgs e)
        {
            Label labelText3 = new Label();
            labelText3.Text = "A Tersi";
            labelText3.Size = new Size(192, 29);
            labelText3.Location = new Point(115, 663);
            labelText3.BringToFront();
            labelText3.AutoSize = true;
            labelText3.Font = new Font("MV Boli", 14, FontStyle.Bold);
            labelText3.BackColor = Color.FromArgb(0, 0, 64);
            labelText3.ForeColor = Color.White;
            Controls.Add(labelText3);

            Label lblParantez4 = new Label();
            lblParantez4.Text = "[";
            lblParantez4.SendToBack();
            lblParantez4.Location = new Point(13, 692);
            lblParantez4.AutoSize = false;
            lblParantez4.Font = new Font("MS Gothic", 72);
            lblParantez4.BackColor = Color.FromArgb(0, 0, 64);
            lblParantez4.ForeColor = Color.White;
            lblParantez4.Size = new Size(170, 120);
            this.Controls.Add(lblParantez4);

            Label lblTA11 = new Label();
            lblTA11.Text = "";
            lblTA11.BringToFront();
            lblTA11.Location = new Point(93, 709);
            lblTA11.AutoSize = false;
            lblTA11.Font = new Font("Calibri", 11);
            lblTA11.BackColor = Color.FromArgb(245, 245, 245);
            lblTA11.ForeColor = Color.Black;
            lblTA11.Size = new Size(45, 25);
            this.Controls.Add(lblTA11);

            Label lblTA12 = new Label();
            lblTA12.Text = "";
            lblTA12.BringToFront();
            lblTA12.Location = new Point(150, 709);
            lblTA12.AutoSize = false;
            lblTA12.Font = new Font("Calibri", 11);
            lblTA12.BackColor = Color.FromArgb(245, 245, 245);
            lblTA12.ForeColor = Color.Black;
            lblTA12.Size = new Size(45, 25);
            this.Controls.Add(lblTA12);

            Label lblTA13 = new Label();
            lblTA13.Text = "";
            lblTA13.BringToFront();
            lblTA13.Location = new Point(208, 709);
            lblTA13.AutoSize = false;
            lblTA13.Font = new Font("Calibri", 11);
            lblTA13.BackColor = Color.FromArgb(245, 245, 245);
            lblTA13.ForeColor = Color.Black;
            lblTA13.Size = new Size(45, 25);
            this.Controls.Add(lblTA13);

            Label lblTA21 = new Label();
            lblTA21.Text = "";
            lblTA21.BringToFront();
            lblTA21.Location = new Point(93, 743);
            lblTA21.AutoSize = false;
            lblTA21.Font = new Font("Calibri", 11);
            lblTA21.BackColor = Color.FromArgb(245, 245, 245);
            lblTA21.ForeColor = Color.Black;
            lblTA21.Size = new Size(45, 25);
            this.Controls.Add(lblTA21);

            Label lblTA22 = new Label();
            lblTA22.Text = "";
            lblTA22.BringToFront();
            lblTA22.Location = new Point(150, 743);
            lblTA22.AutoSize = false;
            lblTA22.Font = new Font("Calibri", 11);
            lblTA22.BackColor = Color.FromArgb(245, 245, 245);
            lblTA22.ForeColor = Color.Black;
            lblTA22.Size = new Size(45, 25);
            this.Controls.Add(lblTA22);

            Label lblTA23 = new Label();
            lblTA23.Text = "";
            lblTA23.BringToFront();
            lblTA23.Location = new Point(208, 743);
            lblTA23.AutoSize = false;
            lblTA23.Font = new Font("Calibri", 11);
            lblTA23.BackColor = Color.FromArgb(245, 245, 245);
            lblTA23.ForeColor = Color.Black;
            lblTA23.Size = new Size(45, 25);
            this.Controls.Add(lblTA23);

            Label lblTA31 = new Label();
            lblTA31.Text = "";
            lblTA31.BringToFront();
            lblTA31.Location = new Point(93, 776);
            lblTA31.AutoSize = false;
            lblTA31.Font = new Font("Calibri", 11);
            lblTA31.BackColor = Color.FromArgb(245, 245, 245);
            lblTA31.ForeColor = Color.Black;
            lblTA31.Size = new Size(45, 25);
            this.Controls.Add(lblTA31);

            Label lblTA32 = new Label();
            lblTA32.Text = "";
            lblTA32.BringToFront();
            lblTA32.Location = new Point(150, 776);
            lblTA32.AutoSize = false;
            lblTA32.Font = new Font("Calibri", 11);
            lblTA32.BackColor = Color.FromArgb(245, 245, 245);
            lblTA32.ForeColor = Color.Black;
            lblTA32.Size = new Size(45, 25);
            this.Controls.Add(lblTA32);

            Label lblTA33 = new Label();
            lblTA33.Text = "";
            lblTA33.BringToFront();
            lblTA33.Location = new Point(208, 776);
            lblTA33.AutoSize = false;
            lblTA33.Font = new Font("Calibri", 11);
            lblTA33.BackColor = Color.FromArgb(245, 245, 245);
            lblTA33.ForeColor = Color.Black;
            lblTA33.Size = new Size(45, 25);
            this.Controls.Add(lblTA33);

            Label lblParantez5 = new Label();
            lblParantez5.Text = "]";
            lblParantez5.SendToBack();
            lblParantez5.Location = new Point(233, 693);
            lblParantez5.AutoSize = false;
            lblParantez5.Font = new Font("MS Gothic", 72);
            lblParantez5.BackColor = Color.FromArgb(0, 0, 64);
            lblParantez5.ForeColor = Color.White;
            lblParantez5.Size = new Size(170, 120);
            this.Controls.Add(lblParantez5);

            Int32[,] a = new Int32[3, 3];         //A matristen girilen sayılar

            double[,] ters = new double[3, 3];   // yeni oluşturulacak matris

            //Değerleri okunur
            a[0, 0] = Convert.ToInt32(txtA11.Text);
            a[1, 0] = Convert.ToInt32(txtA12.Text);
            a[2, 0] = Convert.ToInt32(txtA13.Text);
            a[0, 1] = Convert.ToInt32(txtA21.Text);
            a[1, 1] = Convert.ToInt32(txtA22.Text);
            a[2, 1] = Convert.ToInt32(txtA23.Text);
            a[0, 2] = Convert.ToInt32(txtA31.Text);
            a[1, 2] = Convert.ToInt32(txtA32.Text);
            a[2, 2] = Convert.ToInt32(txtA33.Text);

            ters = Matris.MatrisTersi(a);            //Matris static sınıfından MatrisTersi oluşturdum metodu kullanıyorum

            lblTA11.Text = Convert.ToString(ters[0, 0]);
            lblTA11.BringToFront();
            lblTA12.Text = Convert.ToString(ters[1, 0]);
            lblTA12.BringToFront();
            lblTA13.Text = Convert.ToString(ters[2, 0]);
            lblTA13.BringToFront();
            lblTA21.Text = Convert.ToString(ters[0, 1]);
            lblTA21.BringToFront();
            lblTA22.Text = Convert.ToString(ters[1, 1]);
            lblTA22.BringToFront();
            lblTA23.Text = Convert.ToString(ters[2, 1]);
            lblTA23.BringToFront();
            lblTA31.Text = Convert.ToString(ters[0, 2]);
            lblTA31.BringToFront();
            lblTA32.Text = Convert.ToString(ters[1, 2]);
            lblTA32.BringToFront();
            lblTA33.Text = Convert.ToString(ters[2, 2]);
            lblTA33.BringToFront();
        }
        //Ters butonu basınca bu fonksiyon çalışacak
        //yeni bir tablo oluşturur
        private void btnBTers_Click(object sender, EventArgs e)
        {
            Label labelText4 = new Label();
            labelText4.Text = "B Tersi";
            labelText4.Size = new Size(192, 29);
            labelText4.Location = new Point(509, 663);
            labelText4.BringToFront();
            labelText4.AutoSize = true;
            labelText4.Font = new Font("MV Boli", 14, FontStyle.Bold);
            labelText4.BackColor = Color.FromArgb(0, 0, 64);
            labelText4.ForeColor = Color.White;
            Controls.Add(labelText4);

            Label lblParantez5 = new Label();
            lblParantez5.Text = "[";
            lblParantez5.SendToBack();
            lblParantez5.Location = new Point(408, 692);
            lblParantez5.AutoSize = false;
            lblParantez5.Font = new Font("MS Gothic", 72);
            lblParantez5.BackColor = Color.FromArgb(0, 0, 64);
            lblParantez5.ForeColor = Color.White;
            lblParantez5.Size = new Size(170, 120);
            this.Controls.Add(lblParantez5);

            Label lblTB11 = new Label();
            lblTB11.Text = "";
            lblTB11.BringToFront();
            lblTB11.Location = new Point(484, 709);
            lblTB11.AutoSize = false;
            lblTB11.Font = new Font("Calibri", 11);
            lblTB11.BackColor = Color.FromArgb(245, 245, 245);
            lblTB11.ForeColor = Color.Black;
            lblTB11.Size = new Size(45, 25);
            this.Controls.Add(lblTB11);

            Label lblTB12 = new Label();
            lblTB12.Text = "";
            lblTB12.BringToFront();
            lblTB12.Location = new Point(541, 709);
            lblTB12.AutoSize = false;
            lblTB12.Font = new Font("Calibri", 11);
            lblTB12.BackColor = Color.FromArgb(245, 245, 245);
            lblTB12.ForeColor = Color.Black;
            lblTB12.Size = new Size(45, 25);
            this.Controls.Add(lblTB12);

            Label lblTB13 = new Label();
            lblTB13.Text = "";
            lblTB13.BringToFront();
            lblTB13.Location = new Point(599, 709);
            lblTB13.AutoSize = false;
            lblTB13.Font = new Font("Calibri", 11);
            lblTB13.BackColor = Color.FromArgb(245, 245, 245);
            lblTB13.ForeColor = Color.Black;
            lblTB13.Size = new Size(45, 25);
            this.Controls.Add(lblTB13);

            Label lblTB21 = new Label();
            lblTB21.Text = "";
            lblTB21.BringToFront();
            lblTB21.Location = new Point(484, 743);
            lblTB21.AutoSize = false;
            lblTB21.Font = new Font("Calibri", 11);
            lblTB21.BackColor = Color.FromArgb(245, 245, 245);
            lblTB21.ForeColor = Color.Black;
            lblTB21.Size = new Size(45, 25);
            this.Controls.Add(lblTB21);

            Label lblTB22 = new Label();
            lblTB22.Text = "";
            lblTB22.BringToFront();
            lblTB22.Location = new Point(541, 743);
            lblTB22.AutoSize = false;
            lblTB22.Font = new Font("Calibri", 11);
            lblTB22.BackColor = Color.FromArgb(245, 245, 245);
            lblTB22.ForeColor = Color.Black;
            lblTB22.Size = new Size(45, 25);
            this.Controls.Add(lblTB22);

            Label lblTB23 = new Label();
            lblTB23.Text = "";
            lblTB23.BringToFront();
            lblTB23.Location = new Point(599, 743);
            lblTB23.AutoSize = false;
            lblTB23.Font = new Font("Calibri", 11);
            lblTB23.BackColor = Color.FromArgb(245, 245, 245);
            lblTB23.ForeColor = Color.Black;
            lblTB23.Size = new Size(45, 25);
            this.Controls.Add(lblTB23);

            Label lblTB31 = new Label();
            lblTB31.Text = "";
            lblTB31.BringToFront();
            lblTB31.Location = new Point(484, 776);
            lblTB31.AutoSize = false;
            lblTB31.Font = new Font("Calibri", 11);
            lblTB31.BackColor = Color.FromArgb(245, 245, 245);
            lblTB31.ForeColor = Color.Black;
            lblTB31.Size = new Size(45, 25);
            this.Controls.Add(lblTB31);

            Label lblTB32 = new Label();
            lblTB32.Text = "";
            lblTB32.BringToFront();
            lblTB32.Location = new Point(541, 776);
            lblTB32.AutoSize = false;
            lblTB32.Font = new Font("Calibri", 11);
            lblTB32.BackColor = Color.FromArgb(245, 245, 245);
            lblTB32.ForeColor = Color.Black;
            lblTB32.Size = new Size(45, 25);
            this.Controls.Add(lblTB32);

            Label lblTB33 = new Label();
            lblTB33.Text = "";
            lblTB33.BringToFront();
            lblTB33.Location = new Point(599, 776);
            lblTB33.AutoSize = false;
            lblTB33.Font = new Font("Calibri", 11);
            lblTB33.BackColor = Color.FromArgb(245, 245, 245);
            lblTB33.ForeColor = Color.Black;
            lblTB33.Size = new Size(45, 25);
            this.Controls.Add(lblTB33);

            Label lblParantez6 = new Label();
            lblParantez6.Text = "]";
            lblParantez6.SendToBack();
            lblParantez6.Location = new Point(620, 693);
            lblParantez6.AutoSize = false;
            lblParantez6.Font = new Font("MS Gothic", 72);
            lblParantez6.BackColor = Color.FromArgb(0, 0, 64);
            lblParantez6.ForeColor = Color.White;
            lblParantez6.Size = new Size(170, 120);
            this.Controls.Add(lblParantez6);

            Int32[,] b = new Int32[3, 3];            // B matristen girilen sayılar

            double [,] ters = new double [3, 3];      // yeni oluşturulacak matris

            //Değerleri okunur
            b[0, 0] = Convert.ToInt32(txtB11.Text);
            b[1, 0] = Convert.ToInt32(txtB12.Text);
            b[2, 0] = Convert.ToInt32(txtB13.Text);
            b[0, 1] = Convert.ToInt32(txtB21.Text);
            b[1, 1] = Convert.ToInt32(txtB22.Text);
            b[2, 1] = Convert.ToInt32(txtB23.Text);
            b[0, 2] = Convert.ToInt32(txtB31.Text);
            b[1, 2] = Convert.ToInt32(txtB32.Text);
            b[2, 2] = Convert.ToInt32(txtB33.Text);

            ters = Matris.MatrisTersi(b);                  //Matris static sınıfından MatrisTersi oluşturdum metodu kullanıyorum


            lblTB11.BringToFront();
            lblTB11.Text = Convert.ToString(ters[0, 0]);
            lblTB12.BringToFront();
            lblTB12.Text = Convert.ToString(ters[1, 0]);
            lblTB31.BringToFront();
            lblTB13.Text = Convert.ToString(ters[2, 0]);
            lblTB21.BringToFront();
            lblTB21.Text = Convert.ToString(ters[0, 1]);
            lblTB22.BringToFront();
            lblTB22.Text = Convert.ToString(ters[1, 1]);
            lblTB23.BringToFront();
            lblTB23.Text = Convert.ToString(ters[1, 1]);
            lblTB31.BringToFront();
            lblTB31.Text = Convert.ToString(ters[0, 2]);
            lblTB32.BringToFront();
            lblTB32.Text = Convert.ToString(ters[1, 2]);
            lblTB33.BringToFront();
            lblTB33.Text = Convert.ToString(ters[2, 2]);

        }
        //Sil butonu basınca bu fonksiyon çalışacak
        //A matrisinin textBoxta bulunan değerleri silecek
        private void btnASil_Click(object sender, EventArgs e)
        {
            //Değerleri siliyor
            txtA11.Text = String.Empty;
            txtA12.Text = String.Empty;
            txtA13.Text = String.Empty;
            txtA21.Text = String.Empty;
            txtA22.Text = String.Empty;
            txtA23.Text = String.Empty;
            txtA31.Text = String.Empty;
            txtA32.Text = String.Empty;
            txtA33.Text = String.Empty;
        }
        //Sil butonu basınca bu fonksiyon çalışacak
        //A matrisinin textBoxta bulunan değerleri silecek
        private void btnBSil_Click(object sender, EventArgs e)
        { 
            //Değerleri siliyor
            txtB11.Text = String.Empty;
            txtB12.Text = String.Empty;
            txtB13.Text = String.Empty;
            txtB21.Text = String.Empty;
            txtB22.Text = String.Empty;
            txtB23.Text = String.Empty;
            txtB31.Text = String.Empty;
            txtB32.Text = String.Empty;
            txtB33.Text = String.Empty;
        }
        //Izi butonu basınca bu fonksiyon çalışacak
        //yeni bir label oluşturur
        private void btnAIz_Click(object sender, EventArgs e)
        {
            Label lblAizi = new Label();
            lblAizi.Location = new Point(261, 313);
            lblAizi.AutoSize = false;
            lblAizi.Font = new Font("MV Boli", 12);
            lblAizi.BackColor = Color.FromArgb(245, 245, 245);
            lblAizi.ForeColor = Color.Black;
            lblAizi.Size = new Size(59, 35);
            this.Controls.Add(lblAizi);

            int izi;               

            Int32[,] a = new Int32[3, 3];              //A matristen girilen sayılar

            //Değerleri okunur
            a[0, 0] = Convert.ToInt32(txtA11.Text);
            a[1, 0] = Convert.ToInt32(txtA12.Text);
            a[2, 0] = Convert.ToInt32(txtA13.Text);
            a[0, 1] = Convert.ToInt32(txtA21.Text);
            a[1, 1] = Convert.ToInt32(txtA22.Text);
            a[2, 1] = Convert.ToInt32(txtA23.Text);
            a[0, 2] = Convert.ToInt32(txtA31.Text);
            a[1, 2] = Convert.ToInt32(txtA32.Text);
            a[2, 2] = Convert.ToInt32(txtA33.Text);

            //Matris static sınıfından MatrisIzi oluşturdum metodu kullanıyorum
            izi = Matris.MatrisIzi(a);

            lblAizi.Text = Convert.ToString(izi);
        }
        //Izi butonu basınca bu fonksiyon çalışacak
        //yeni bir label oluşturur
        private void btnBIz_Click(object sender, EventArgs e)
        {
            Label lblBizi = new Label();
            lblBizi.Location = new Point(672, 313);
            lblBizi.AutoSize = false;
            lblBizi.Font = new Font("MV Boli", 12);
            lblBizi.BackColor = Color.FromArgb(245, 245, 245);
            lblBizi.ForeColor = Color.Black;
            lblBizi.Size = new Size(59, 35);
            this.Controls.Add(lblBizi);

            int izi;

            Int32[,] b = new Int32[3, 3];                 //B matristen girilen sayılar

            //Değerleri okunur
            b[0, 0] = Convert.ToInt32(txtB11.Text);
            b[1, 0] = Convert.ToInt32(txtB12.Text);
            b[2, 0] = Convert.ToInt32(txtB13.Text);
            b[0, 1] = Convert.ToInt32(txtB21.Text);
            b[1, 1] = Convert.ToInt32(txtB22.Text);
            b[2, 1] = Convert.ToInt32(txtB23.Text);
            b[0, 2] = Convert.ToInt32(txtB31.Text);
            b[1, 2] = Convert.ToInt32(txtB32.Text);
            b[2, 2] = Convert.ToInt32(txtB33.Text);

            //Matris static sınıfından MatrisIzi oluşturdum metodu kullanıyorum
            izi = Matris.MatrisIzi(b);

            lblBizi.Text = Convert.ToString(izi);
        }
        //Transpoz butonu basınca bu fonksiyon çalışacak
        //yeni bir tablo oluşturur
        private void btnATranspoz_Click(object sender, EventArgs e)
        {
            Label labelText5 = new Label();
            labelText5.Text = "A Transpozu";
            labelText5.BringToFront();
            labelText5.Size = new Size(203, 29);
            labelText5.Location = new Point(88, 823);
            labelText5.AutoSize = false;
            labelText5.Font = new Font("MV Boli", 14, FontStyle.Bold);
            labelText5.BackColor = Color.FromArgb(0, 0, 64);
            labelText5.ForeColor = Color.White;
            this.Controls.Add(labelText5);

            Label lblParantez8 = new Label();
            lblParantez8.SendToBack();
            lblParantez8.Text = "[";
            lblParantez8.Location = new Point(29, 861);
            lblParantez8.AutoSize = false;
            lblParantez8.Font = new Font("MS Gothic", 72);
            lblParantez8.BackColor = Color.FromArgb(0, 0, 64);
            lblParantez8.ForeColor = Color.White;
            lblParantez8.Size = new Size(170, 120);
            this.Controls.Add(lblParantez8);

            Label lblATrans11 = new Label();
            lblATrans11.BringToFront();
            lblATrans11.Location = new Point(110, 873);
            lblATrans11.AutoSize = false;
            lblATrans11.Font = new Font("Calibri", 11);
            lblATrans11.BackColor = Color.FromArgb(245, 245, 245);
            lblATrans11.ForeColor = Color.Black;
            lblATrans11.Size = new Size(35, 25);
            this.Controls.Add(lblATrans11);

            Label lblATrans12 = new Label();
            lblATrans12.Text = "";
            lblATrans12.Location = new Point(151, 873);
            lblATrans12.AutoSize = false;
            lblATrans12.Font = new Font("Calibri", 11);
            lblATrans12.BackColor = Color.FromArgb(245, 245, 245);
            lblATrans12.ForeColor = Color.Black;
            lblATrans12.Size = new Size(35, 25);
            this.Controls.Add(lblATrans12);

            Label lblATrans13 = new Label();
            lblATrans13.Text = "";
            lblATrans13.Location = new Point(192, 873);
            lblATrans13.AutoSize = false;
            lblATrans13.Font = new Font("Calibri", 11);
            lblATrans13.BackColor = Color.FromArgb(245, 245, 245);
            lblATrans13.ForeColor = Color.Black;
            lblATrans13.Size = new Size(35, 25);
            this.Controls.Add(lblATrans13);

            Label lblATrans21 = new Label();
            lblATrans21.Text = "";
            lblATrans21.Location = new Point(110, 907);
            lblATrans21.AutoSize = false;
            lblATrans21.Font = new Font("Calibri", 11);
            lblATrans21.BackColor = Color.FromArgb(245, 245, 245);
            lblATrans21.ForeColor = Color.Black;
            lblATrans21.Size = new Size(35, 25);
            this.Controls.Add(lblATrans21);

            Label lblATrans22 = new Label();
            lblATrans22.Text = "";
            lblATrans22.Location = new Point(151, 907);
            lblATrans22.AutoSize = false;
            lblATrans22.Font = new Font("Calibri", 11);
            lblATrans22.BackColor = Color.FromArgb(245, 245, 245);
            lblATrans22.ForeColor = Color.Black;
            lblATrans22.Size = new Size(35, 25);
            this.Controls.Add(lblATrans22);

            Label lblATrans23 = new Label();
            lblATrans23.Text = "";
            lblATrans23.Location = new Point(192, 907);
            lblATrans23.AutoSize = false;
            lblATrans23.Font = new Font("Calibri", 11);
            lblATrans23.BackColor = Color.FromArgb(245, 245, 245);
            lblATrans23.ForeColor = Color.Black;
            lblATrans23.Size = new Size(35, 25);
            this.Controls.Add(lblATrans23);

            Label lblATrans31 = new Label();
            lblATrans31.Text = "";
            lblATrans31.Location = new Point(110, 942);
            lblATrans31.AutoSize = false;
            lblATrans31.Font = new Font("Calibri", 11);
            lblATrans31.BackColor = Color.FromArgb(245, 245, 245);
            lblATrans31.ForeColor = Color.Black;
            lblATrans31.Size = new Size(35, 25);
            this.Controls.Add(lblATrans31);

            Label lblATrans32 = new Label();
            lblATrans32.Text = "";
            lblATrans32.Location = new Point(151, 942);
            lblATrans32.AutoSize = false;
            lblATrans32.Font = new Font("Calibri", 11);
            lblATrans32.BackColor = Color.FromArgb(245, 245, 245);
            lblATrans32.ForeColor = Color.Black;
            lblATrans32.Size = new Size(35, 25);
            this.Controls.Add(lblATrans32);

            Label lblATrans33 = new Label();
            lblATrans33.Text = "";
            lblATrans33.Location = new Point(192, 942);
            lblATrans33.AutoSize = false;
            lblATrans33.Font = new Font("Calibri", 11);
            lblATrans33.BackColor = Color.FromArgb(245, 245, 245);
            lblATrans33.ForeColor = Color.Black;
            lblATrans33.Size = new Size(35, 25);
            this.Controls.Add(lblATrans33);

            Label lblParantez9 = new Label();
            lblParantez9.SendToBack();
            lblParantez9.Text = "]";
            lblParantez9.Location = new Point(205, 861);
            lblParantez9.AutoSize = false;
            lblParantez9.Font = new Font("MS Gothic", 72);
            lblParantez9.BackColor = Color.FromArgb(0, 0, 64);
            lblParantez9.ForeColor = Color.White;
            lblParantez9.Size = new Size(170, 120);
            this.Controls.Add(lblParantez9);

            Int32[,] a = new Int32[3, 3];       //A matristen girilen sayılar

            int[,] trans = new int[3, 3];      // yeni oluşturulacak matris

            //Değerleri okunur
            a[0, 0] = Convert.ToInt32(txtA11.Text);
            a[1, 0] = Convert.ToInt32(txtA12.Text);
            a[2, 0] = Convert.ToInt32(txtA13.Text);
            a[0, 1] = Convert.ToInt32(txtA21.Text);
            a[1, 1] = Convert.ToInt32(txtA22.Text);
            a[2, 1] = Convert.ToInt32(txtA23.Text);
            a[0, 2] = Convert.ToInt32(txtA31.Text);
            a[1, 2] = Convert.ToInt32(txtA32.Text);
            a[2, 2] = Convert.ToInt32(txtA33.Text);

            trans = Matris.MatrisTranspoz(a);           //Matris static sınıfından MatrisTranspoz oluşturdum metodu kullanıyorum


            lblATrans11.Text = Convert.ToString(trans[0, 0]);
            lblATrans11.BringToFront();
            lblATrans12.Text = Convert.ToString(trans[1, 0]);
            lblATrans12.BringToFront();
            lblATrans13.Text = Convert.ToString(trans[2, 0]);
            lblATrans13.BringToFront();
            lblATrans21.Text = Convert.ToString(trans[0, 1]);
            lblATrans21.BringToFront();
            lblATrans22.Text = Convert.ToString(trans[1, 1]);
            lblATrans22.BringToFront();
            lblATrans23.Text = Convert.ToString(trans[2, 1]);
            lblATrans23.BringToFront();
            lblATrans31.Text = Convert.ToString(trans[0, 2]);
            lblATrans31.BringToFront();
            lblATrans32.Text = Convert.ToString(trans[1, 2]);
            lblATrans32.BringToFront();
            lblATrans33.Text = Convert.ToString(trans[2, 2]);
            lblATrans33.BringToFront();
        }
        //Transpoz butonu basınca bu fonksiyon çalışacak
        //yeni bir tablo oluşturur
        private void btnBTranspoz_Click(object sender, EventArgs e)
        {
            Label labelText6 = new Label();
            labelText6.Text = "B Transpozu";
            labelText6.BringToFront();
            labelText6.Size = new Size(203, 29);
            labelText6.Location = new Point(486, 823);
            labelText6.AutoSize = false;
            labelText6.Font = new Font("MV Boli", 14, FontStyle.Bold);
            labelText6.BackColor = Color.FromArgb(0, 0, 64);
            labelText6.ForeColor = Color.White;
            this.Controls.Add(labelText6);

            Label lblParantez10 = new Label();
            lblParantez10.SendToBack();
            lblParantez10.Text = "[";
            lblParantez10.Location = new Point(425, 861);
            lblParantez10.AutoSize = false;
            lblParantez10.Font = new Font("MS Gothic", 72);
            lblParantez10.BackColor = Color.FromArgb(0, 0, 64);
            lblParantez10.ForeColor = Color.White;
            lblParantez10.Size = new Size(170, 120);
            this.Controls.Add(lblParantez10);

            Label lblBTrans11 = new Label();
            lblBTrans11.BringToFront();
            lblBTrans11.Location = new Point(506, 873);
            lblBTrans11.AutoSize = false;
            lblBTrans11.Font = new Font("Calibri", 11);
            lblBTrans11.BackColor = Color.FromArgb(245, 245, 245);
            lblBTrans11.ForeColor = Color.Black;
            lblBTrans11.Size = new Size(35, 25);
            this.Controls.Add(lblBTrans11);

            Label lblBTrans12 = new Label();
            lblBTrans12.Text = "";
            lblBTrans12.Location = new Point(547, 873);
            lblBTrans12.AutoSize = false;
            lblBTrans12.Font = new Font("Calibri", 11);
            lblBTrans12.BackColor = Color.FromArgb(245, 245, 245);
            lblBTrans12.ForeColor = Color.Black;
            lblBTrans12.Size = new Size(35, 25);
            this.Controls.Add(lblBTrans12);

            Label lblBTrans13 = new Label();
            lblBTrans13.Text = "";
            lblBTrans13.Location = new Point(588, 873);
            lblBTrans13.AutoSize = false;
            lblBTrans13.Font = new Font("Calibri", 11);
            lblBTrans13.BackColor = Color.FromArgb(245, 245, 245);
            lblBTrans13.ForeColor = Color.Black;
            lblBTrans13.Size = new Size(35, 25);
            this.Controls.Add(lblBTrans13);

            Label lblBTrans21 = new Label();
            lblBTrans21.Text = "";
            lblBTrans21.Location = new Point(506, 907);
            lblBTrans21.AutoSize = false;
            lblBTrans21.Font = new Font("Calibri", 11);
            lblBTrans21.BackColor = Color.FromArgb(245, 245, 245);
            lblBTrans21.ForeColor = Color.Black;
            lblBTrans21.Size = new Size(35, 25);
            this.Controls.Add(lblBTrans21);

            Label lblBTrans22 = new Label();
            lblBTrans22.Text = "";
            lblBTrans22.Location = new Point(547, 907);
            lblBTrans22.AutoSize = false;
            lblBTrans22.Font = new Font("Calibri", 11);
            lblBTrans22.BackColor = Color.FromArgb(245, 245, 245);
            lblBTrans22.ForeColor = Color.Black;
            lblBTrans22.Size = new Size(35, 25);
            this.Controls.Add(lblBTrans22);

            Label lblBTrans23 = new Label();
            lblBTrans23.Text = "";
            lblBTrans23.Location = new Point(588, 907);
            lblBTrans23.AutoSize = false;
            lblBTrans23.Font = new Font("Calibri", 11);
            lblBTrans23.BackColor = Color.FromArgb(245, 245, 245);
            lblBTrans23.ForeColor = Color.Black;
            lblBTrans23.Size = new Size(35, 25);
            this.Controls.Add(lblBTrans23);

            Label lblBTrans31 = new Label();
            lblBTrans31.Text = "";
            lblBTrans31.Location = new Point(506, 942);
            lblBTrans31.AutoSize = false;
            lblBTrans31.Font = new Font("Calibri", 11);
            lblBTrans31.BackColor = Color.FromArgb(245, 245, 245);
            lblBTrans31.ForeColor = Color.Black;
            lblBTrans31.Size = new Size(35, 25);
            this.Controls.Add(lblBTrans31);

            Label lblBTrans32 = new Label();
            lblBTrans32.Text = "";
            lblBTrans32.Location = new Point(547, 942);
            lblBTrans32.AutoSize = false;
            lblBTrans32.Font = new Font("Calibri", 11);
            lblBTrans32.BackColor = Color.FromArgb(245, 245, 245);
            lblBTrans32.ForeColor = Color.Black;
            lblBTrans32.Size = new Size(35, 25);
            this.Controls.Add(lblBTrans32);

            Label lblBTrans33 = new Label();
            lblBTrans33.Text = "";
            lblBTrans33.Location = new Point(588, 942);
            lblBTrans33.AutoSize = false;
            lblBTrans33.Font = new Font("Calibri", 11);
            lblBTrans33.BackColor = Color.FromArgb(245, 245, 245);
            lblBTrans33.ForeColor = Color.Black;
            lblBTrans33.Size = new Size(35, 25);
            this.Controls.Add(lblBTrans33);

            Label lblParantez11 = new Label();
            lblParantez11.SendToBack();
            lblParantez11.Text = "]";
            lblParantez11.Location = new Point(601, 861);
            lblParantez11.AutoSize = false;
            lblParantez11.Font = new Font("MS Gothic", 72);
            lblParantez11.BackColor = Color.FromArgb(0, 0, 64);
            lblParantez11.ForeColor = Color.White;
            lblParantez11.Size = new Size(170, 120);
            this.Controls.Add(lblParantez11);

            Int32[,] b = new Int32[3, 3];              // B matristen girilen sayılar

            int[,] trans = new int[3, 3];             // yeni oluşturulacak matris

            //Değerleri okunur
            b[0, 0] = Convert.ToInt32(txtB11.Text);
            b[1, 0] = Convert.ToInt32(txtB12.Text);
            b[2, 0] = Convert.ToInt32(txtB13.Text);
            b[0, 1] = Convert.ToInt32(txtB21.Text);
            b[1, 1] = Convert.ToInt32(txtB22.Text);
            b[2, 1] = Convert.ToInt32(txtB23.Text);
            b[0, 2] = Convert.ToInt32(txtB31.Text);
            b[1, 2] = Convert.ToInt32(txtB32.Text);
            b[2, 2] = Convert.ToInt32(txtB33.Text);

            trans = Matris.MatrisTranspoz(b);              //Matris static sınıfından MatrisTranspoz oluşturdum metodu kullanıyorum

            lblBTrans11.Text = Convert.ToString(trans[0, 0]);
            lblBTrans11.BringToFront();
            lblBTrans12.Text = Convert.ToString(trans[1, 0]);
            lblBTrans12.BringToFront();
            lblBTrans13.Text = Convert.ToString(trans[2, 0]);
            lblBTrans13.BringToFront();
            lblBTrans21.Text = Convert.ToString(trans[0, 1]);
            lblBTrans21.BringToFront();
            lblBTrans22.Text = Convert.ToString(trans[1, 1]);
            lblBTrans22.BringToFront();
            lblBTrans23.Text = Convert.ToString(trans[2, 1]);
            lblBTrans23.BringToFront();
            lblBTrans31.Text = Convert.ToString(trans[0, 2]);
            lblBTrans31.BringToFront();
            lblBTrans32.Text = Convert.ToString(trans[1, 2]);
            lblBTrans32.BringToFront();
            lblBTrans33.Text = Convert.ToString(trans[2, 2]);
            lblBTrans33.BringToFront();
        }
    }
    //Static bir sınıf oluşturdum
    public static class Matris
    {
        //MatrisToplama static metodu oluşturuldu
        public static int[,] MatrisToplama(int[,] a, int[,] b)                    
        {
            int[,] c = new int[3, 3];                      //bu dizinde bulunan sonuçları atılanacak

            c[0, 0] = a[0, 0] + b[0, 0];
            c[1, 0] = a[1, 0] + b[1, 0];
            c[2, 0] = a[2, 0] + b[2, 0];
            c[0, 1] = a[0, 1] + b[0, 1];
            c[1, 1] = a[1, 1] + b[1, 1];
            c[2, 1] = a[2, 1] + b[2, 1];
            c[0, 2] = a[0, 2] + b[0, 2];
            c[1, 2] = a[1, 2] + b[1, 2];
            c[2, 2] = a[2, 2] + b[2, 2];

            return c;
        }
        //MatrisCarpma static metodu oluşturuldu
        public static int[,] MatrisCarpma(int[,] a, int [,] b)                
        {
            int[,] d = new int[3, 3];                  //bu dizinde bulunan sonuçları atılanacak

            d[0, 0] = a[0, 0] * b[0, 0] + a[1, 0] * b[0, 1] + a[2, 0] * b[0, 2];
            d[1, 0] = a[0, 0] * b[1, 0] + a[1, 0] * b[1, 1] + a[2, 0] * b[1, 2];
            d[2, 0] = a[0, 0] * b[2, 0] + a[1, 0] * b[2, 1] + a[2, 0] * b[2, 2];
            d[0, 1] = a[0, 1] * b[0, 0] + a[1, 1] * b[0, 1] + a[2, 1] * b[0, 2];
            d[1, 1] = a[0, 1] * b[1, 0] + a[1, 1] * b[1, 1] + a[2, 1] * b[1, 2];
            d[2, 1] = a[0, 1] * b[2, 0] + a[1, 1] * b[2, 1] + a[2, 1] * b[2, 2];
            d[0, 2] = a[0, 2] * b[0, 0] + a[1, 2] * b[0, 1] + a[2, 2] * b[0, 2];
            d[1, 2] = a[0, 2] * b[1, 0] + a[1, 2] * b[1, 1] + a[2, 2] * b[1, 2];
            d[2, 2] = a[0, 2] * b[2, 0] + a[1, 2] * b[2, 1] + a[2, 2] * b[2, 2];

            return d;
        }
        //MatrisTersi static metodu oluşturuldu
        public static double[,] MatrisTersi(int[,] a)
        {
            double det;         //matrisin determinantı bulunacak
             
            Int32[,] ek = new Int32[3, 3];            //bu dizinde matrisin Ek sonuçları atılınacak 

            double[,] ters = new double[3, 3];                  //bu dizinde bulunan sonuçları atılanacak

            //bu förmül ile matrisin determinantı bulunacak
            det = ((a[0, 0] * a[1, 1] * a[2, 2]) + (a[0, 1] * a[1, 2] * a[2, 0]) + (a[0, 2] * a[1, 0] * a[2, 1])) - ((a[2, 0] * a[1, 1] * a[0, 2]) + (a[2, 1] * a[1, 2] * a[0, 0]) + (a[2, 2] * a[1, 0] * a[0, 1]));

            if (det == 0)      //eğer determinant 0 ise o zamam bir mesaj çıkaçak
            {
                MessageBox.Show("Determinant 0'dır, matris tersine çevrilemez.");
            }
            else
            {
                //matrisin Ek bulunan förmülü
                ek[0, 0] = (a[1, 2] * a[2, 1]) - (a[1, 1] * a[2, 2]);
                ek[1, 0] = (a[2, 1] * a[0, 2]) - (a[0, 1] * a[2, 2]);
                ek[2, 0] = (a[1, 1] * a[0, 2]) - (a[0, 1] * a[1, 2]);
                ek[0, 1] = (a[1, 2] * a[2, 0]) - (a[1, 0] * a[2, 2]);
                ek[1, 1] = (a[2, 0] * a[0, 2]) - (a[0, 0] * a[2, 2]);
                ek[2, 1] = (a[1, 0] * a[0, 2]) - (a[0, 0] * a[1, 2]);
                ek[0, 2] = (a[2, 0] * a[1, 1]) - (a[1, 0] * a[2, 1]);
                ek[1, 2] = (a[2, 0] * a[0, 1]) - (a[0, 0] * a[2, 1]);
                ek[2, 2] = (a[0, 1] * a[1, 0]) - (a[0, 0] * a[1, 1]);

                //matrisin ter bulunan förmülü
                ters[0, 0] = (ek[0, 0]) / det;
                ters[0, 1] = (ek[1, 0]) / det;
                ters[0, 2] = (ek[2, 0]) / det;
                ters[1, 0] = (ek[0, 1]) / det;
                ters[1, 1] = (ek[1, 1]) / det;
                ters[1, 2] = (ek[2, 1]) / det;
                ters[2, 0] = (ek[0, 2]) / det;
                ters[2, 1] = (ek[1, 2]) / det;
                ters[2, 2] = (ek[2, 2]) / det;
            }
            return ters;
        }
        //MatrisIzi static metodu oluşturuldu
        public static int MatrisIzi(int [,] a)
        {
            int izi = a[0, 0] + a[1, 1] + a[2, 2];        //bu förmül ile matrisin izi bulunur

            return izi;                 //izin değeri döndürür
        }
        //MatrisTranspoz static metodu oluşturuldu
        public static int [,] MatrisTranspoz(int[,] a)
        {
            int[,] trans = new int[3, 3];             //bu dizinde bulunan sonuçlar atılacak

            //transpoz bulmak için gerekli işlemler
            trans[0, 0] = a[0, 0];
            trans[0, 1] = a[1, 0];
            trans[0, 2] = a[2, 0];
            trans[1, 0] = a[0, 1];
            trans[1, 1] = a[1, 1];
            trans[1, 2] = a[2, 1];
            trans[2, 0] = a[0, 2];
            trans[2, 1] = a[1, 2];
            trans[2, 2] = a[2, 2];

            return trans;
        }
    }    
}
