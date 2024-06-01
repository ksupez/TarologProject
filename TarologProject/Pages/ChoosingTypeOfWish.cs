using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TarologProject.Pages;

namespace TarologProject
{
    public partial class ChoosingTypeOfWish : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
       IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font Inter, Kudry;
        public ChoosingTypeOfWish()
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
            Kudry = new Font(fonts.Families[1], 26.0F);

            workButton.Font = Kudry;
            fateButton.Font = Kudry;
            loveButton.Font = Kudry;
            roundButtonExit.Font = Inter;
            roundButtonMain.Font = Inter;
            roundButtonMore.Font = Inter;

            this.KeyPreview = true;
            
            this.KeyDown += ChoosingTypeOfWish_KeyDown;
        }

        private void workButton_Click(object sender, EventArgs e)
        {
            Form tellingFinance = new FinanceForm();
            
            tellingFinance.Size = this.Size;
            
            
            tellingFinance.Show();
            tellingFinance.Location = this.Location;
            this.Hide();
        }

        private void loveButton_Click(object sender, EventArgs e)
        {
            Form tellingLove = new LoveForm();
            
            tellingLove.Size = this.Size;
            
            
            tellingLove.Show();
            tellingLove.Location = this.Location;
            this.Hide();
        }

        private void fateButton_Click(object sender, EventArgs e)
        {
            Form telling3Card = new TellingWishesForm();
            
            telling3Card.Size = this.Size;
            
            
            telling3Card.Show();
            telling3Card.Location = this.Location;
            this.Hide();
        }

        private void roundButtonExit_Click(object sender, EventArgs e)
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

        private void roundButtonMore_Click(object sender, EventArgs e)
        {
            Form moreForm = new MoreForm();
            
            moreForm.Size = this.Size;
            
            moreForm.Show();
            moreForm.Location = this.Location;
            this.Hide();
        }

        private void roundButtonMain_Click(object sender, EventArgs e)
        {
            Form mainForm = new MainPage();
            
            mainForm.Size = this.Size;
            mainForm.Show();
            mainForm.Location = this.Location;
            this.Hide();
        }

        private void ChoosingTypeOfWish_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {

                Form mainForm = new MainPage();
                
                mainForm.Size = this.Size;
                
                
                mainForm.Show();
                mainForm.Location = this.Location;
                this.Hide();
            }
        }
    }
}
