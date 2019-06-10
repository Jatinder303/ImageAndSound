using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace ImageAndSound
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //code to display image in picture box on form load 
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("ImageAndSound.Resources.sports.jpg");
            Bitmap bmp = new Bitmap(myStream);
            PicBox_Main.Image = bmp;
        }


        private void Btn_First_Click(object sender, EventArgs e)
        {
            //code to display image in picture box on button click 
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("ImageAndSound.Resources.Cricket.jpg");
            Bitmap bmp = new Bitmap(myStream);
            PicBox_Main.Image = bmp;

            //code to play sound on button click but before writting below code we need to folow the below mentioned steps
            // 1. Open "Solution Explorer" from menu toolbar ("VIEW") or simply press Ctrl+Alt+L.
            //2. Click on drop - down list of "Properties".
            //3. Then select "Resource.resx" and press enter.
            //4. click on string drop down (top left corner of the Resources.resx file) and select "Audio" from the combobox list.
            //5. Then click on "Add Resource", choose audio files (.wav) and click "Open".
            //6. Select audio file(s) and change "Persistence" properties to "Embedded in .resx".
            //7. write below mentioned code
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(ImageAndSound.Properties.Resources.sound);
            snd.Play();
        }

        private void Btn_Second_Click(object sender, EventArgs e)
        {
            //code to display image in picture box on button click 
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("ImageAndSound.Resources.football.jpg");
            Bitmap bmp = new Bitmap(myStream);
            PicBox_Main.Image = bmp;

            //code to play sound on button click but before writting below code we need to folow the below mentioned steps
            // 1. Open "Solution Explorer" from menu toolbar ("VIEW") or simply press Ctrl+Alt+L.
            //2. Click on drop - down list of "Properties".
            //3. Then select "Resource.resx" and press enter.
            //4. click on string drop down (top left corner of the Resources.resx file) and select "Audio" from the combobox list.
            //5. Then click on "Add Resource", choose audio files (.wav) and click "Open".
            //6. Select audio file(s) and change "Persistence" properties to "Embedded in .resx".
            //7. write below mentioned code

            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(ImageAndSound.Properties.Resources.gun);
            snd.Play();
        }

        private void Btn_sound_Click(object sender, EventArgs e)
        {
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("ImageAndSound.Resources.spin.jpg");
            Bitmap bmp = new Bitmap(myStream);
            PicBox_Main.Image = bmp;

            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(ImageAndSound.Properties.Resources.spinnn);
            snd.Play();
        }
    }
}
