using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalabrasApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Text Files|*.txt";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                String path = openFileDialog.FileName;
                readBox.Text = File.ReadAllText(path);
            }
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            String words = readBox.Text;
            String[] wordsArr = words.Split(' ', '\n');


            // array into a list
            // initialize the list

            List<WordOccurance> track = new List<WordOccurance>();

            // tracking each word whether is in the list or not. If it is in the list, add 1 to occurance
            // otherwise, add the word to the list and set occurance to 1

            foreach(string i in wordsArr)
            {
                WordOccurance detected = track.Find(x => x.word == i);

                if(detected == null)
                {
                    // add the word to the list because it is not detected

                    track.Add(new WordOccurance(i,1));

                }
                else
                {
                    // the word is in the list so increase occurance by 1

                    detected.occurance++;
                }
            }

            // TextBox design with word and occurance columns

            parsedBox.Columns.Add("Occurance", 150, HorizontalAlignment.Center);
            parsedBox.Columns.Add("Word", 150, HorizontalAlignment.Center);
            parsedBox.GridLines = true;
            parsedBox.FullRowSelect = true;
            parsedBox.View = View.Details;

            parsedBox.Sorting = SortOrder.Descending;

            foreach(WordOccurance j in track)
            {
                String[] tableItem = new string[] { j.occurance.ToString("D2"), j.word };
                parsedBox.Items.Add(new ListViewItem(tableItem));
            }

            // write to the output.txt file

            using (var tw = new StreamWriter("output.txt"))
            {
                string O = "Occur";
                string B = "   ";
                string W = "Words";
                tw.WriteLine("{0}{1}{2}", O, B, W);
                StringBuilder sb;

                if (parsedBox.Items.Count > 0)
                {
                    // the actual data
                    foreach (ListViewItem lvi in parsedBox.Items)
                    {
                        sb = new StringBuilder();

                        foreach (ListViewItem.ListViewSubItem listViewSubItem in lvi.SubItems)
                        {
                            sb.Append(string.Format("{0}\t", listViewSubItem.Text));
                        }
                        tw.WriteLine(sb.ToString());
                    }
                    tw.WriteLine();

                    dispOutput.Text = "Output file was created successfully!";
                }
            }
        }
    }
}
