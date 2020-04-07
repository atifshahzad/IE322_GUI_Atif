using System;

using System.Windows.Forms;
using System.Speech.Synthesis; // Add it from Project -> Add Reference
namespace IE322_App_KAU
{
    public partial class frmTalk : Form
    {

        SpeechSynthesizer He = new SpeechSynthesizer();
        SpeechSynthesizer She = new SpeechSynthesizer();
        SpeechSynthesizer You = new SpeechSynthesizer();

        string HisName = "Ali";
        string HerName = "Julia";
        string yourName = "Bilal";

        public frmTalk()
        {
            InitializeComponent();
            
            
            He.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Senior);
            She.SelectVoiceByHints(VoiceGender.Female);
            You.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Teen);
                      

            He.Volume = 100; // min=0 and max= 100
            He.Rate = 4; // min=-10 and max =10
            
            She.Volume = 70;
            She.Rate = 1;

            You.Rate = 1;
        }

        private void frmTalk_Load(object sender, EventArgs e)
        {

        }

        private void BtnAli_Click(object sender, EventArgs e)
        {
            He.Speak("Hello" + HerName);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BtnJulia_Click(object sender, EventArgs e)
        {
            She.Speak("Hi" + HisName);
        }

        private void BtnTalk_Click(object sender, EventArgs e)
        {
            He.Speak("Hello Mr. " + yourName + ", How do you do?");

            You.SpeakAsync("Hi Mr. " + HisName + " and Miss " + HerName);
            You.Speak("I am quite fine and currently in the class of Computer Applications in Industrial Engineering");
            You.Speak("This is very easy course");
            You.Speak("because I don't look for the bonus marks only");

        }
    }
}
