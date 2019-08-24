using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA_Trainer_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            richTextBox1.Text = aboutmessage;
        }
        public string aboutmessage = "This trainer is created by Ahmed Shahriar, codenamed Dark Chokolate " +
                "I hope you you like it and please provide issues and requests at here  \n" +
                "https://github.com/shahriar0247/gta-sa-trainer-1  \n \n" +
                "If you want to contact me for any job or anything  \n" +
                "Youtube channel: https://www.youtube.com/channel/UCacoBm0kneh6pGBe4gJvY4g \n" +
                "Email: shahriar0247@gmail.com \n" +
                "Instagram: https://www.instagram.com/shahriar0247/ \n" +
                "Discord: https://discord.gg/v4Q5PVR \n" +
                "Github: https://github.com/shahriar0247 \n" +
                "Patreon: https://www.patreon.com/shahriar0247 \n \n" +
                "Thank you for trying my software! \n";

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
