using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CST_150_Activity5
{
    public partial class FileStatsForm : Form
    {
        public FileStatsForm()
        {
            InitializeComponent();
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            //create an OpenFileDialog for the user to select a file
            OpenFileDialog fileBrowserDialog = new OpenFileDialog();
            fileBrowserDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            fileBrowserDialog.ShowDialog();
            if (File.Exists(fileBrowserDialog.FileName))
            {
                using (StreamReader reader = new StreamReader(fileBrowserDialog.FileName, Encoding.UTF8))
                {
                    string fileData = reader.ReadToEnd();
                    string[] arrayOfFileData = fileData.Split(' ');

                    //convert all data to lowercase
                    string lowercaseFileData = fileData.ToLower();

                    //get the longest word
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

                    //alphabetize
                    string firstInAlphabet = arrayOfFileData.OrderBy(x => x.ToLower()).First();
                    string lastInAlphabet = arrayOfFileData.OrderBy(x => x.ToLower()).Last();

                    //compare vowels to each letter
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
                    // set textbox text to the data
                    fileStats.Text = "Lowercase: " + lowercaseFileData + "\r\nFirst Ascending: " + firstInAlphabet + "\r\nFirst Descending: " + lastInAlphabet + "\r\nLongest Word: " + longestWord + "\r\nMost Vowels: " + mostVowels;
                    
                }

            }
        }
        private void downloadButton_Click(object sender, EventArgs e)
        {
            // write all data to new file
            System.IO.File.WriteAllText($@"C:\Users\Public\{userFileName.Text}.txt", fileStats.Text);
            downloadLabel.Text = $"{userFileName.Text}.txt downloaded successfully!";
        }
    }
}
