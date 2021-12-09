using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Trie
{
    public partial class Window : Form
    {
        public class Node : System.IDisposable
        {
            private string data = "";
            //int counter;
            //bool end_of_word;
            private Node next;

            //C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
            //		friend class trie;
            public Node()
            {
                this.data = " ";
                this.next = null;
            }

            public void Dispose()
            {
                if (this.next != null)
                {
                    if (this.next != null)
                    {
                        this.next.Dispose();
                    }
                }
            }

            public Node(string data)
            {
                this.data = data;
                this.next = null;
            }

            public Node(string data, Node next)
            {
                this.data = data;
                this.next = next;
            }
        }




        // Step 1: Array Declaration
        public string[] stringarr;
        public Window()
        {
            InitializeComponent();
        }
        public void addItems(AutoCompleteStringCollection col)
        {



            // This string array will contain a dictionary of strings
            // stringarr = File.ReadAllLines("words.txt", Encoding.UTF8); ;

            var list = new List<string>();
            var fileStream = new FileStream(@"C:\Users\venom\Documents\words.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    list.Add(line);
                }
            }

            stringarr = list.ToArray();
            for (int i = 0; i < stringarr.Length; i++)
            {
                // Here the for loop will iterate and add into a string collection
                string s = stringarr[i];
                col.Add(s);
            }
            
        }
        private void Search_Load(object sender, EventArgs e)
        {
            searchBar.AutoCompleteMode = AutoCompleteMode.Suggest;
            searchBar.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            addItems(DataCollection);
            searchBar.AutoCompleteCustomSource = DataCollection;
        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void enterKey_Click(object sender, EventArgs e)
        {
            this.searchBar.Click += new EventHandler(searchBar_Click);
            MessageBox.Show(searchBar.Text);
        }

        private void searchBar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            // This will counter the number of words that are 
            int counter;
            string reps = "Number of Repetitions: ";
            string newLine = Environment.NewLine;
            for (int i = 0; i < stringarr.Length; i++)
            {
                if (stringarr.Length != stringarr.Distinct().Count())
                {
                    
                    counter = i;                   
                    txtDisplay.Text = "Word: " + stringarr[i] + newLine + reps +  counter.ToString();
                }
                else
                {
                    txtDisplay.Text = "No repetitive words";
                }
            }
                

        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
