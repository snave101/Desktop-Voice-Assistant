using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Speech.Synthesis;
using System.Speech.Recognition;


namespace Animus
{
 
    public partial class Form1 : Form
    {
        SpeechSynthesizer speaker = new SpeechSynthesizer();
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();

        
       
           
      //  SpeechRecognizer sR = new SpeechRecognizer();
        public bool found = false;

        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        ///
        /// Handling the window messages
        ///
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }

        
        public Form1()
        {
            
            InitializeComponent();
            IReadOnlyCollection<InstalledVoice> InstalledVoices = speaker.GetInstalledVoices();

         //   speaker.SelectVoice("Microsoft David");
            
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {

            speaker.Rate = 0;
            speaker.Volume = 100;
            
            

            string input = (Searchbox.Text).ToLower().ToString();


            if (input.Contains("read mode"))
            {
                textform frm = new textform();
                frm.Show();

               
                return;


            }


            if (input.Contains("next"))
            {
                SendKeys.SendWait("{PGDN}");

                return;


            }
            if (input.Contains("previous"))
            {
                SendKeys.SendWait("{PGUP}");

                return;


            }


            if (input.Contains("enter"))
            {
                SendKeys.SendWait("{ENTER}");

                return;


            }


            if (input.Contains("close firefox"))
            {
                Process[] p = Process.GetProcessesByName("firefox");
                p[0].Kill();
                answerbox.Text = "Closed";
                speaker.Speak("Closed");



                return;


            }



            if (input.Contains("close chrome"))
            {
                Process[] p = Process.GetProcessesByName("chrome");
                foreach(Process K in p)
                {
                    K.Kill();

                }
              //  MessageBox.Show(p[0].ToString());
                answerbox.Text = "Closed";
                speaker.Speak("Closed");



                return;


            }

            if (input.Contains("close notepad"))
            {
                Process[] p = Process.GetProcessesByName("notepad");
                p[0].Kill();
                answerbox.Text = "Closed";
                speaker.Speak("Closed");



                return;


            }

            if (input.Contains("close paint"))
            {
                Process[] p = Process.GetProcessesByName("mspaint");
                p[0].Kill();
                answerbox.Text = "Closed";
                speaker.Speak("Closed");



                return;


            }

            if (input.Contains("close command"))
            {
                Process[] p = Process.GetProcessesByName("cmd");
                p[0].Kill();
                answerbox.Text = "Closed";
                speaker.Speak("Closed");



                return;


            }








            if (input.Contains("close") == true || input.Contains("exit") == true|| input.Contains("bye") == true|| input.Contains("goodbye") == true)
            {
                speaker.Speak("GoodBye Master.");
                Application.Exit();
                return;
            
            
            
            }


            if (input.Contains("name") == true || input.Contains("who are") == true || (input.Contains("what") == true && input.Contains("you") == true&&input.Contains("called")))
            {
                string[] convo = { "I'm a voice assistant known by the name assistant.", "My name is assistant. What about you?", "I'm a voice assistant.",
                                 "Hello. just call me assistant."};
                Random rnd = new Random();
                int num = rnd.Next(0, convo.Length);
                answerbox.Text = convo[num];
                speaker.SpeakAsync( convo[num]);


                return;


            }


         






            if (input.Contains("hello") == true || input.Contains("hi") == true || input.Contains("hey assistant") == true || input.Contains("morning") == true || input.Contains("evening") == true || input.Contains("night") == true || input.Contains("afternoon") == true)
            {
                string[] convo = {"Hello.","Hey hi","Oh Hello there. A very good day to you.","How are you today","On your service","Yeah.","Your wish is my command."};
                Random rnd = new Random();
                int num = rnd.Next(0, convo.Length);
                answerbox.Text = convo[num];
                speaker.SpeakAsync(convo[num]);


                return;


            }
            if (input.Contains("open word") == true)
            {
                string[] convo = {"Oh Hello there. Give me a minute", "opening in a few", "Is it so?", "Yeah.", "Your wish is my command." };
                Random rnd = new Random();
                int num = rnd.Next(0, convo.Length);
                answerbox.Text = convo[num];
                speaker.SpeakAsync(convo[num]);
                Process.Start("WINWORD.EXE");
                


                return;


            }
            if (input.Contains("open excel") == true)
            {
                string[] convo = {  "Oh Hello there. Give me a minute", "opening in a few", "Is it so?", "Yeah.", "Your wish is my command." };
                Random rnd = new Random();
                int num = rnd.Next(0, convo.Length);
                answerbox.Text = convo[num];
                speaker.SpeakAsync(convo[num]);
                Process.Start("EXCEL.EXE");
                return;
            }




            if (input.Contains("i'm") == true || input.Contains("i am") == true || input.Contains("I'm fine") == true || input.Contains("my") == true)
            {
                string[] convo = { "Nice to meet you.", "Yes. Certainly.",
                                 "Amusing I must say.","What do you want to do today?"};
                Random rnd = new Random();
                int num = rnd.Next(0, convo.Length);
                answerbox.Text = convo[num];
                speaker.SpeakAsync(convo[num]);


                return;


            }
            if (input.Contains("why") == true || input.Contains("how") == true || input.Contains("what") == true || input.Contains("when") == true || input.Contains("who") == true)
            {
                string[] convo = { "I don't know. Would you like to search on Google.", "I don't know why."
                                 ,};
                Random rnd = new Random();
                int num = rnd.Next(0, convo.Length);
                answerbox.Text = convo[num];
                speaker.SpeakAsync(convo[num]);


                return;


            }
            if (input.Contains("thanks") == true || input.Contains("thank") == true || input.Contains("okay") == true || input.Contains("ok") == true)
            {
                string[] convo = { "Okay. No problem master.","Obvious, isn't it.",
                                 "I'm glad to help you.","Looks like we need to focus on something else."};
                Random rnd = new Random();
                int num = rnd.Next(0, convo.Length);
                answerbox.Text = convo[num];
                speaker.SpeakAsync(convo[num]);


                return;


            }
      
            if (input.ToString().ToLower().Contains("start") == true || input.ToString().ToLower().Contains("open") == true)
            {

                
                string[] lines = System.IO.File.ReadAllLines(@"../../resources/processes.txt");

                foreach (string line in lines)
                {
                    string []splitted=line.ToString().Split(' ');
                    foreach (string x in splitted)
                    {
                        //MessageBox.Show(x);
                        if (input.Contains(x) == true)
                        {
                            //MessageBox.Show(splitted[0]);
                            Process.Start(splitted[0] + ".exe");
                            answerbox.Text = "Okay Master. " + x + " has been started. What else do you want?";
                            speaker.Speak(answerbox.Text);

                            return;
                        
                        
                        }
                    
                    }

                 


                }
                if (found == false)
                {

                    answerbox.Text = "Sorry, I'm not that intelligent yet. Let me google the answer for you.";
                    speaker.Speak(answerbox.Text);
                    string query = Searchbox.Text.Replace(" ", "+");
                    string googleSearchUrl = $"http://www.google.com/search?q={Uri.EscapeDataString(query)}";
                    Process.Start(googleSearchUrl);
                    return;

                }

              


            }
            else
            {
                //implement thanks . else not working// 
                string[] convo = { "Let's ask someone who might know the answer.", "Sorry, I'm currently in a pre-alpha stage I Google might know it.", "I'm not that knowledgeble yet. Google might know it.",
                                     "I don't know. Let's ask google.",
                                 "Let me search that for you."};
                Random rnd = new Random();
                int num = rnd.Next(0, convo.Length);
                answerbox.Text = convo[num];
                speaker.SpeakAsync(convo[num]);

                string query = Searchbox.Text.Replace(" ", "+");
                string googleSearchUrl = $"http://www.google.com/search?q={Uri.EscapeDataString(query)}";
                Process.Start(googleSearchUrl);



                return;


            }

          
            
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {

            
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
           // Recordbtn.Image = recordimages.Images[0];
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            //Recordbtn.Image = recordimages.Images[1];
            
        }

        private void Recordbtn_MouseDown(object sender, MouseEventArgs e)
        {
          //  Recordbtn.Image = recordimages.Images[2];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Choices commands = new Choices();
            commands.Add(new string[] { "hello","who are you?" ,"what is your name?","say your name","i am","fine","good bye","bye","exit","okay",
               
                 "start chrome", "start internet", "start notepad", "start paint", "start cmd", "start command", "start word", 
                "close chrome","close notepad","close paint","close command","next","previous","enter","close word" });
            GrammarBuilder gBuilder = new GrammarBuilder();
            gBuilder.Append(commands);
            Grammar grammar = new Grammar(gBuilder);
            recEngine.LoadGrammarAsync(grammar);
            recEngine.SetInputToDefaultAudioDevice();
            recEngine.SpeechRecognized+=recEngine_SpeechRecognized;




           

            //Console.WriteLine("Cpu usage: " + cpuCounter.NextValue() + "%");
          //  Console.WriteLine("Free ram : " + ramCounter.NextValue() + "MB");










            //sR.SpeechRecognized += sR_SpeechRecognized;  
        }
        void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {

            Searchbox.Text = e.Result.Text;
            Searchbtn_Click(null,null);

      
        
        }


        void sR_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
           // Searchbox.AppendText(e.Result.Text.ToString() + " ");
           
        }

        private void eB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hB_Click(object sender, EventArgs e)
        {
            speaker.Rate = 1;
            speaker.Volume = 100;
            speaker.Speak("Opening explorer.");
            Process.Start("explorer.exe");
        }

        private void gB_Click(object sender, EventArgs e)
        {
            speaker.Rate = 1;
            speaker.Volume = 100;
            speaker.Speak("You can now search the internet.");
            Process.Start("http://www.google.com");
        }

        private void tB_Click(object sender, EventArgs e)
        {
            speaker.Rate = 1;
            speaker.Volume = 100;
            speaker.Speak("Here is the task manager, master.");
            Process.Start("taskmgr");
        }

        private void cB_Click(object sender, EventArgs e)
        {
            speaker.Rate = 1;
            speaker.Volume = 100;
            speaker.Speak("I've opened the control panel.");
            Process.Start("control");

        }

        private void wB_Click(object sender, EventArgs e)
        {
            speaker.Rate = 1;
            speaker.Volume = 100;
            speaker.Speak("Please enter your city name to get weather updates");

            weather wb = new weather();
            wb.Show();
        }

        private void mB_Click(object sender, EventArgs e)
        {
            speaker.Rate = 1;
            speaker.Volume = 100;
            speaker.Speak("Shutting down the system.");
            DialogResult result = MessageBox.Show("Your PC will shutdown. Click OK to proceed or Cancel to abort.", "Shutdown Warning", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Process.Start("shutdown", "/s /t 0");
            }
            else
            {
                MessageBox.Show("Shutdown process aborted.", "Abort", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

           this.dT.Text = DateTime.Now.ToString();

      







        }

        private void dT_Click(object sender, EventArgs e)
        {
            speaker.Rate = 0;
            speaker.Volume = 100;
            speaker.SpeakAsync(dT.Text);

        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsync(RecognizeMode.Multiple);
            btnDisable.Enabled = true;
            btnEnable.Enabled = false;

        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsyncStop();
            btnEnable.Enabled = true;
            btnDisable.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            PerformanceCounter cpuCounter = new PerformanceCounter();
            cpuCounter.CategoryName = "Processor";
            cpuCounter.CounterName = "% Processor Time";
            cpuCounter.InstanceName = "_Total";
            PerformanceCounter ramCounter = new PerformanceCounter("Memory", "Available MBytes");

            var unused = cpuCounter.NextValue(); // first call will always return 0
            // System.Threading.Thread.Sleep(1000); // wait a second, then try again
            cpulabel.Text = cpuCounter.NextValue() + "%";
            ramlabel.Text = ramCounter.NextValue() + "MB";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Searchbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cpulabel_Click(object sender, EventArgs e)
        {

        }

        private void ramlabel_Click(object sender, EventArgs e)
        {

        }

        private void lblRam_Click(object sender, EventArgs e)
        {

        }

        private void lblcpu_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            speaker.Rate = 1;
            speaker.Volume = 100;
            speaker.Speak("Here is the command list");
            command_list cd = new command_list();
            cd.Show();
            cd.BringToFront();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
