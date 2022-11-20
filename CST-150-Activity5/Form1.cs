using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CST_150_Activity5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fo = new OpenFileDialog();
            fo.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            fo.ShowDialog();
            if (File.Exists(fo.FileName))
            {
                using (StreamReader reader = new StreamReader(fo.FileName, Encoding.UTF8))
                {
                    string fileData = reader.ReadToEnd();
                    string[] arrayOfFileData = fileData.Split(' ');

                    string lowercaseFileData = fileData.ToLower();

                    int lengthOfWord = 0;
                    string longestWord = "";

                    for (int i = 0; i < arrayOfFileData.Length; i++)
                    {
                        if (arrayOfFileData[i].Split().Length > lengthOfWord)
                        {
                            lengthOfWord = arrayOfFileData[i].Split().Length;
                            longestWord = arrayOfFileData[i];
                        }
                    }

                    //ascending order
                    string firstInAlphabet = arrayOfFileData.OrderBy(x => x.ToLower()).First();
                    //last in ascending order
                    string lastInAlphabet = arrayOfFileData.OrderBy(x => x.ToLower()).Last();

                    string[] arrayOfVowels = {"a", "e", "i", "o", "u"};

                    int highestVowelCount = 0;
                    string mostVowels = "";

                    for(int i = 0; i < arrayOfVowels.Length; i ++)
                    {
                        for(int j = 0; j < arrayOfFileData.Length; j ++)
                        {
                            int newCount = 0;
                            string[] arrayOfLetters = arrayOfFileData[j].Split();
                            for(int k = 0; k < arrayOfLetters.Length; k ++)
                            {
                                if (arrayOfLetters[k].Contains(arrayOfVowels[i]))
                                {
                                    newCount++;
                                }
                            }
                            if (newCount > highestVowelCount)
                            {
                                highestVowelCount = newCount;
                                mostVowels = arrayOfFileData[j];
                            }
                        }
                    }

                    fileStats.Text = "Lowercase: " + lowercaseFileData + "\r\nFirst Ascending: " + firstInAlphabet + "\r\nFirst Descending: " + lastInAlphabet + "\r\nLongest Word: " + longestWord + "\r\nMost Vowels: " + mostVowels;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        System.IO.File.WriteAllText(@"C:\Users\Public\fileStats.txt", fileStats.Text);
        downloadLabel.Text = "fileStats.txt downloaded successfully!";
        }
    }
}
