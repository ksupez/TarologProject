using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TarologProject.Pages;
using System.Runtime.InteropServices;
using System.Drawing.Text;



namespace TarologProject
{
    public partial class MainPage : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
       IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font Inter, Kudry;
        public MainPage()
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

            roundButtonExit.Font = Kudry;
            roundButtonStart.Font = Kudry;
            roundButtonMore.Font = Kudry;

        }


        private void roundButtonStart_Click(object sender, EventArgs e)
        {
            Form choosingType = new ChoosingTypeOfWish();
            
            choosingType.Size = this.Size;

            choosingType.Show();
            choosingType.Location = this.Location;
            this.Hide();
        }

        private void roundButtonMore_Click(object sender, EventArgs e)
        {
            Form moreForm = new MoreForm();
            
            moreForm.Size = this.Size;
            
            
            moreForm.Show();
            moreForm.Location = this.Location;
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


    }
}

