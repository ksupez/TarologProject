using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TarologProject.Pages;

namespace TarologProject
{
    public partial class TellingWishesForm : Form
    {
        public string[] fortunes = { "На нынешнем месте вашего прибывания вы чувствуете скованность, она не дает вам в свою очередь действовать активно и так как комфортно именно вам. Но скоро это закончится, грядет завершение вашего прибывания на этом месте, в новом вы обретаете покой и умиротворение.",
            "Грядет болезненное завершение любимого дела, вы будете не готовы к этому эмоционально. Из-за неготовности ожидается отстранение от общества людей и уход в себя, попытки других успокоить вас только усугубят положение.",
            "Вас будет ждать долгожданное завершение плохого этапа в вашей жизни и приятное путешествие. Желательно чтобы вы отправились в дальнюю дорогу в одиночестве, чтобы порассуждать наедине над своими проблемами. ",
            "Наступают благоприятные времена в вашей жизни. Вы будете обладать всеми ресурсами для достижения своих целей, но не забывайте грамотно распределять свои силы.",
        "Вы совершите дизморальный поступок, который будет завершать благоприятный этап в вашей жизни. После этого вы уйдете в состояние, непривычное для вас, которое будет осуждаться обществом. Берегите себя!"};
        public string path = Path.GetFullPath(@"Cards\ForFate");
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
        public TellingWishesForm()
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
            this.KeyDown += FateForm_KeyDown;

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

            if ((image1Name == "mir.jpg" || image1Name == "smert.jpg" || image1Name == "poveshen.jpg") &&
                (image2Name == "mir.jpg" || image2Name == "smert.jpg" || image2Name == "poveshen.jpg") &&
                (image3Name == "mir.jpg" || image3Name == "smert.jpg" || image3Name == "poveshen.jpg"))
            {
                label1.Text = fortunes[0];
                goodCount++;
                wishesQuantity++;

            }
            else if ((image1Name == "mir.jpg" || image1Name == "otshelka.jpg" || image1Name == "smert.jpg") &&
                (image2Name == "mir.jpg" || image2Name == "otshelka.jpg" || image2Name == "smert.jpg") &&
                (image3Name == "mir.jpg" || image3Name == "otshelka.jpg" || image3Name == "smert.jpg"))
            {
                label1.Text = fortunes[2];
                goodCount++;
                wishesQuantity++;

            }
            else if ((image1Name == "poveshen.jpg" || image1Name == "otshelka.jpg" || image1Name == "smert.jpg") &&
                (image2Name == "poveshen.jpg" || image2Name == "otshelka.jpg" || image2Name == "smert.jpg") &&
                (image3Name == "poveshen.jpg" || image3Name == "otshelka.jpg" || image3Name == "smert.jpg"))
            {
                label1.Text = fortunes[1];
                badCount++;
                wishesQuantity++;

            }
            else if ((image1Name == "poveshen.jpg" || image1Name == "otshelka.jpg" || image1Name == "mir.jpg") &&
                (image2Name == "poveshen.jpg" || image2Name == "otshelka.jpg" || image2Name == "mir.jpg") &&
                (image3Name == "poveshen.jpg" || image3Name == "otshelka.jpg" || image3Name == "mir.jpg"))
            {
                label1.Text = fortunes[3];
                goodCount++;
                wishesQuantity++;

            }
            else if ((image1Name == "poveshen.jpg" || image1Name == "smert.jpg" || image1Name == "sud.jpg") &&
                (image2Name == "poveshen.jpg" || image2Name == "smert.jpg" || image2Name == "sud.jpg") &&
                (image3Name == "poveshen.jpg" || image3Name == "smert.jpg" || image3Name == "sud.jpg"))
            {
                label1.Text = fortunes[4];
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

        private void roundButtonMenu_Click(object sender, EventArgs e)
        {
            Form choosingForm = new ChoosingTypeOfWish();
            
            choosingForm.Size = this.Size;
            choosingForm.Show();
            choosingForm.Location = this.Location;
            this.Hide();
        }

        private void roundButton1_Click_1(object sender, EventArgs e)
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

        private void FateForm_KeyDown(object sender, KeyEventArgs e)
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
