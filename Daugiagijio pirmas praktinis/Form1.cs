using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;


namespace Daugiagijio_pirmas_praktinis
{
     
    public partial class Form1 : Form
    {
        bool fileExists = false;
        string temporaryText = "";
        bool checkEmpty = true;
        int progressBarCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void CateogoryButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browserDialog = new FolderBrowserDialog();

            if (browserDialog.ShowDialog(this) == DialogResult.OK)
                locationTextBox.Text = browserDialog.SelectedPath;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                searchButton.Enabled = false;
                Stopwatch timer = new Stopwatch();
                string location = locationTextBox.Text;
                if (string.IsNullOrWhiteSpace(fileTextBox.Text))
                    throw new Exception("Turite parašyti ieškomą failą/direkciją");
                if (string.IsNullOrWhiteSpace(locationTextBox.Text))
                    throw new Exception("Turite nurodytį pradedamojo katalogo lokaciją");

                checkEmpty = true;
                Thread searchThread = new Thread(new ParameterizedThreadStart(Search));
                timer.Start();
                searchThread.Start(location);
                Thread printThread = new Thread(() => Print(searchThread, timer));
                printThread.Start();

               // timerLabel.Text = watch.ElapsedMilliseconds.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        void Search(object obj)
        {
            try
            {
                foreach (string directory in Directory.GetDirectories(obj.ToString(), "*", SearchOption.TopDirectoryOnly))
                {
                    progressBarCount++;
                    Search(directory);
                }
                this.Invoke((Action)delegate
                {
                    if (obj.ToString() == Path.GetDirectoryName(obj.ToString()) + "\\" + fileTextBox.Text)
                    {
                        temporaryText = ("Katalogas „" + obj.ToString() + "“ rastas, lokacija: " + Path.GetDirectoryName(obj.ToString()).ToString() + "\r\n");
                        fileExists = true;
                    }
                });
                foreach (string file in Directory.GetFiles(obj.ToString()))
                {
                    progressBarCount++;
                    Thread.Sleep(30);
                    this.Invoke((Action)delegate
                    {
                        if (fileTextBox.Text == Path.GetFileNameWithoutExtension(file))
                        {
                            temporaryText = ("Failas „" + Path.GetFileName(file) + "“ rastas, lokacija: " + Path.GetDirectoryName(obj.ToString()).ToString() + "\r\n");
                            fileExists = true;
                        }
                    });
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        
        void Print(Thread searchThread, Stopwatch timer)
        { 
            try
            {
                progressBarSettings();
                for (int i = 0; ; i++)
                {
                    this.Invoke((Action)delegate
                    {
                        progressBar.Value = progressBarCount;
                    });
                    if (fileExists == true)
                    {
                        this.Invoke((Action)delegate {
                            resultsTextBox.Text += temporaryText;
                            fileExists = false;
                            checkEmpty = false;
                        });
                    };
                    if (!searchThread.IsAlive)
                    {
                        timer.Stop();
                        Thread.Sleep(500);
                        this.Invoke((Action)delegate
                        {
                            if (checkEmpty == true)
                                resultsTextBox.Text += "Nerasta failų ir katalogų \n";
                            else
                                resultsTextBox.Text += "Paieška baigta \n";
                            
                            resultsTextBox.Text += "Paieškos trukmė sekundėmis: " + timer.Elapsed.TotalSeconds.ToString("0.##") + "\n";
                            lines();
                            searchButton.Enabled = true;
                        });
                        progressBarCount = 0;
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        int getMaximumForProgressBar(string directory)
        {
            int count = 0;
            count = Directory.GetFiles(locationTextBox.Text, "*.*", SearchOption.AllDirectories).Length;
            foreach (string dir in Directory.GetDirectories(directory, "*", SearchOption.AllDirectories))
            {
                count++;
            }
            return count;
        }
        void lines()
        {
            for (int k = 0; k < 230; k++)
            {
                resultsTextBox.Text += "*";
            }
            resultsTextBox.Text += "\n";
        }
        void progressBarSettings()
        {
            this.Invoke((Action)delegate
            {
                progressBar.Minimum = 0;
                progressBar.Maximum = getMaximumForProgressBar(locationTextBox.Text);
                progressBar.Value = 0;

            });
        }
    }
}
