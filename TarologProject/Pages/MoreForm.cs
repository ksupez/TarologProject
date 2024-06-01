using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TarologProject.Pages
{
    public partial class MoreForm : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
       IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font Inter, Kudry;
        public MoreForm()
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
            Kudry = new Font(fonts.Families[1], 28.0F);

            roundButtonExit.Font = Inter;
            roundButtonMain.Font = Inter;
            roundButtonTopics.Font = Inter;

            this.KeyPreview = true;
            this.KeyDown += MoreForm_KeyDown;
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

        private void roundButtonTopics_Click(object sender, EventArgs e)
        {
            Form choosingForm = new ChoosingTypeOfWish();
            
            choosingForm.Size = this.Size;
            
            choosingForm.Show();
            choosingForm.Location = this.Location;
            this.Hide();
        }

        private void roundButtonMain_Click(object sender, EventArgs e)
        {
            Form mainF = new MainPage();
            
            mainF.Size = this.Size;
            
            mainF.Show();
            mainF.Location = this.Location;
            this.Hide();
        }

        private void MoreForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {

                Form mainF = new MainPage();

                mainF.Size = this.Size;
                
                mainF.Show();
                mainF.Location = this.Location;
                this.Hide();
            }
        }
    }
}
