using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TarologProject.Pages
{
    public partial class LoveForm : Form
    {
        public string[] fortunes = { "У вас намечается период романтики, так же возможны новые надежды в отношениях с вашим избранником.",
            "Ожидайте удачу в своей любовной жизни, то, что вы задумали будет осуществляться! Так же в взаимоотношениях с вашим партнером вас будет ждать радость и благополучие, вселенная дает вам возможность быть в счастливых отношениях.",
            "Упс..! Похоже, что вы проводили очень много времени со своим партнером и каждый из вас находится в стадии ухода в себя (вам нужно подумать над отношениями и о том, как хорошо вы понимаете друг друга). Но только не паникуйте, после того как вы выйдете из этого состояния все наладится, ведь между вами действительно зародилась любовь!",
            "Ваш нынешний союз вероятно скоро закончится, человек с которым вы были в паре уйдет в себя и примет решение, что эти взаимоотношения ему не к чему. Но можете не переживать, в ближайшее время вы встретите подходящего партнера, с которым вас ждет счастье."};
        public string path = Path.GetFullPath(@"Cards\ForLove");

        public List<int> usedCards = new List<int>();
        public int goodCount = 0;
        public int badCount = 0;
        public int procentGood = 0;
        public int procentBad = 0;
        public int wishesQuantity = 0;
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
       IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font Inter, Kudry;
        public LoveForm()
        {
            InitializeComponent();
            byte[] fontData = Properties.Resources.Inter_Light;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.Inter_Light.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.Inter_Light.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);
            Inter = new Font(fonts.Families[0], 11.0F);

            fontData = Properties.Resources.kudry_weird_headline;
            fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.kudry_weird_headline.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.kudry_weird_headline.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);
            Kudry = new Font(fonts.Families[1], 20.0F);

            roundButton1.Font = Inter;
            tellMoreButton.Font = Inter;
            statisticsButton.Font = Inter;
            roundButtonMenu.Font = Inter;
            label1.Font = Inter;
            label2.Font = Kudry;

            label1.TextAlign = ContentAlignment.MiddleCenter;
            card1.SizeMode = PictureBoxSizeMode.StretchImage;
            card2.SizeMode = PictureBoxSizeMode.StretchImage;
            card3.SizeMode = PictureBoxSizeMode.StretchImage;
            Random rand = new Random();
            GenerateUniqueRandomImage(rand, card1);
            GenerateUniqueRandomImage(rand, card2);
            GenerateUniqueRandomImage(rand, card3);
            UpdateLabel();
            this.KeyPreview = true;
            this.KeyDown += LoveForm_KeyDown;
        }

        private void GenerateUniqueRandomImage(Random rand, PictureBox pictureBox)
        {
            string[] files = Directory.GetFiles(path);
            int randomIndex = rand.Next(files.Length);

            while (usedCards.Contains(randomIndex))
            {
                randomIndex = rand.Next(files.Length);
            }

            usedCards.Add(randomIndex);
            pictureBox.Image = new Bitmap(files[randomIndex]);
            pictureBox.Tag = Path.GetFileName(files[randomIndex]);
        }

        private string GetImageName(PictureBox pictureBox)
        {
            string imageName = "";
            if (pictureBox.Tag != null)
            {
                imageName = pictureBox.Tag.ToString();
            }

            return imageName;
        }


        private void UpdateLabel()
        {
            string image1Name = GetImageName(card1);
            string image2Name = GetImageName(card2);
            string image3Name = GetImageName(card3);

            if ((image1Name == "luna.jpg" || image1Name == "star.jpg" || image1Name == "vlubl.jpg") &&
                (image2Name == "luna.jpg" || image2Name == "star.jpg" || image2Name == "vlubl.jpg") &&
                (image3Name == "luna.jpg" || image3Name == "star.jpg" || image3Name == "vlubl.jpg"))
            {
                label1.Text = fortunes[0];
                goodCount++;
                wishesQuantity++;

            }
            else if ((image1Name == "solnce.jpg" || image1Name == "star.jpg" || image1Name == "vlubl.jpg") &&
                (image2Name == "solnce.jpg" || image2Name == "star.jpg" || image2Name == "vlubl.jpg") &&
                (image3Name == "solnce.jpg" || image3Name == "star.jpg" || image3Name == "vlubl.jpg"))
            {
                label1.Text = fortunes[1];
                goodCount++;
                wishesQuantity++;

            }
            else if ((image1Name == "solnce.jpg" || image1Name == "mag.jpg" || image1Name == "vlubl.jpg") &&
                (image2Name == "solnce.jpg" || image2Name == "mag.jpg" || image2Name == "vlubl.jpg") &&
                (image3Name == "solnce.jpg" || image3Name == "mag.jpg" || image3Name == "vlubl.jpg"))
            {
                label1.Text = fortunes[2];
                goodCount++;
                wishesQuantity++;

            }
            else if ((image1Name == "luna.jpg" || image1Name == "star.jpg" || image1Name == "mag.jpg") &&
                (image2Name == "luna.jpg" || image2Name == "star.jpg" || image2Name == "mag.jpg") &&
                (image3Name == "luna.jpg" || image3Name == "star.jpg" || image3Name == "mag.jpg"))
            {
                label1.Text = fortunes[3];
                badCount++;
                wishesQuantity++;

            }
            else
            {
                label1.Text = "Не вижу вашу судьбу.. Попробуйте еще раз!";
                wishesQuantity++;
            }
        }

        private void statisticsButton_Click(object sender, EventArgs e)
        {
            procentGood = goodCount * 100 / wishesQuantity;
            procentBad = badCount * 100 / wishesQuantity;
            MessageBox.Show(String.Format("Количество хороших предсказаний: {0}\n Количество плохих предсказаний: {1}\n Процент хороших предсказаний: {2}%\n Процент плохих предсказаний: {3}%\n Всего предсказаний: {4}", goodCount, badCount, procentGood, procentBad, wishesQuantity));
        }

        private void tellMoreButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            usedCards.Clear();
            GenerateUniqueRandomImage(rand, card1);
            GenerateUniqueRandomImage(rand, card2);
            GenerateUniqueRandomImage(rand, card3);
            UpdateLabel();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите выйти из приложения?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Form exitForm = new GoodByeForm();
                
                exitForm.Size = this.Size;
                exitForm.Show();
                exitForm.Location = this.Location;
                this.Hide();
            }
        }

        private void roundButtonMenu_Click(object sender, EventArgs e)
        {
            Form choosingForm = new ChoosingTypeOfWish();
            
            choosingForm.Size = this.Size;
            choosingForm.Show();
            choosingForm.Location = this.Location;
            this.Hide();
        }

        private void LoveForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {

                Form choosing = new ChoosingTypeOfWish();
                
                choosing.Size = this.Size;
                choosing.Show();
                choosing.Location = this.Location;
                this.Hide();
            }
        }
    }
}
