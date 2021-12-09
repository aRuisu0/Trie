/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trie
{
	using System;

	//class for each node in the trie
	//Properties of each node is the data it holds,
	//A counter to check for repeat words
	//boolean check for the end of a string
	//pointer pointing to next node or null
	public class Node : System.IDisposable
	{
		private string data = "";
		//int counter;
		//bool end_of_word;
		private Node next;
	}

	// Define the character size
	public class Trie : System.IDisposable
	{

		public Node root;
		public bool isLeaf;
		public int counter = 0;
		public std::ofstream output_file = new std::ofstream();

		public Trie[] character = new Trie[DefineConstants.CHAR_SIZE];

		// Constructor

		// Constructor Function
		public Trie()
		{
			//Creating a blank root node for the whole Trie to branch from
			this.root = new Node();

			// The First node of the tree is not a leaf
			this.isLeaf = false;

			// Each node is given Children nodes that point to Nullptr for the amount
			// of characters we are considering
			for (uint i = 0; i < DefineConstants.CHAR_SIZE; i++)
			{

				// Set each child to nullptr
				this.character[i] = null;

			}
		}


		// Destructor function
		public void Dispose()
		{

			//removeChild(this);
			//delete this->root;
		}


		//void removeChild()


		// Function to read input file and store words in tree
		public void readFile(string file_name)
		{

			//Create a stream object of File_Name
			ifstream file = new ifstream(file_name);

			// Create string object of line
			string line;
			// Loop to look at each line in the file
			while (getline(file, line))
			{
				// Create a stream object that contains each line in the file
				istringstream stream = new istringstream(line);

				// Create a string object for each word
				string key;

				// Loop to insert each word into the trie
				while ((stream >> key) != 0)
				{

					insert(key);

				}
				// After each word, continue to next word till line is done
			}
			//After each line, continue to next line till file is done

		}

        private bool getline(ifstream file, string line)
        {
            throw new NotImplementedException();
        }


        // Function to insert a word into the Trie
        public void insert(string data)
		{

			// Starting from the root node from constructor
			Trie current = this;
			//std::cout<<(*curr)<<std::endl;
			// Loop to check each letter in the word to see if a child node of the key already exists
			Console.Write("Adding ");
			Console.Write(data);
			Console.Write(" to the trie. . . ");
			Console.Write("\n");
			for (uint i = 0; i < data.Length; i++)
			{


				// If a child node of that key does not already exist
				if (current.character[data[i]] == null)
				{

					// Create a new node of that data
					current.character[data[i]] = new Trie();
				}

				// If a child node of that key does exist, or has been created then,
				// go to the next node.
				current = current.character[data[i]];
			}

			// Once the end of the key word being inserted has been reached,
			// mark the current node as a leaf

			current.isLeaf = true;
			current.counter += 1;
		}


	internal static class DefineConstants
	{
		public const int CHAR_SIZE = 128;
	}
		public partial class Trie
		{
			public bool search(string data)
			{
				// return false if Trie is empty
				if (this.root == null)
				{
					Console.Write("The trie is empty");
					Console.Write("\n");
					return false;
				}

				Trie current = this;

				//std::cout<<(*curr)<<std::endl;

				Console.Write("Searching for ");
				Console.Write(data);
				Console.Write(" within trie");
				Console.Write("\n");

				for (uint i = 0; i < data.Length; i++)

				{
					// go to the next node
					current = current.character[data[i]];
					// if the string is invalid (reached end of a path in the Trie)
					if (current == null)
					{
						Console.Write("Word was not found in trie");
						Console.Write("\n");
						return false;
					}
				}

				// return true if the current node is a leaf and the
				// end of the string is reached
				Console.Write(data);
				Console.Write(": ");
				Console.Write(current.counter);
				Console.Write("\n");
				return current.isLeaf;
			}
			public bool haveChildren(Trie curr)
			{
				// Loop to check if
				for (int i = 0; i < CHAR_SIZE; i++)
				{
					if (curr.character[i])
					{
						return true; // child found
					}
				}
				return false;
			}
			using System;

//C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
//ORIGINAL LINE: int Trie::auto_comp(string data)

//C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
//ORIGINAL LINE: void Trie::auto_comp_recur(Trie* root, string prefx)

public partial class Trie
	{
		public int auto_comp(string data)
		{

			Trie current = this;
			Console.Write(data.Length);
			Console.Write("\n");
			for (uint height = 0; height < data.Length; height++)
			{
				Console.Write("does this shit work at all ");
				Console.Write("\n");
				int idx = data[height];
				Console.Write("Here is idx ");
				Console.Write(idx);
				Console.Write("\n");
				if (!current.character[idx])
				{
					return 0;
				}
				current = current.character[idx];
				Console.Write("Here is idx ");
				Console.Write(idx);
				Console.Write("\n");
			}
			bool end_of_word = (current.isLeaf == true);

			bool child = haveChildren(current);

			if (end_of_word && !child)
			{
				Console.Write(data);
				Console.Write("\n");
				return -1;
			}
			if (child)
			{
				string prefx = data;
				Console.Write("We Are Here");
				Console.Write("\n");
				auto_comp_recur(current, prefx);
				return 1;
			}
			//Code should never reach here
			return 0;
		}
		public void auto_comp_recur(Trie root, string prefx)
		{

			if (root.isLeaf)
			{
				Console.Write(prefx);
				Console.Write("\n");
			}

			if (!haveChildren(root))
			{
				return;
			}

			for (int i = 0; i < CHAR_SIZE; i++)
			{
				if (root.character[i])
				{

					prefx.push_back(i);

					auto_comp_recur(root.character[i], prefx);

					prefx.pop_back();

				}
			}
		}
	}

	public partial class Trie
		{
            private Trie output_file;

            public int auto_comp(string data)
			{

				Trie curr = this;
				Console.Write(data.Length);
				Console.Write("\n");
				for (uint height = 0; height < data.Length; height++)
				{
					int idx = CHAR_TO_INDEX(data[height]);
					Console.Write("Here is idx ");
					Console.Write(idx);
					Console.Write("\n");
					if (!curr.character[idx])
					{
						return 0;
					}
					curr = curr.character[idx];
					Console.Write("Here is idx ");
					Console.Write(idx);
					Console.Write("\n");
				}
				bool end_of_word = (curr.isLeaf == true);

				bool child = haveChildren(curr);

				if (end_of_word && child)
				{
					Console.Write(data);
					Console.Write("\n");
					return -1;
				}
				if (!child)
				{
					string prefx = data;
					auto_comp_recur(curr, prefx);
					return 1;
				}
				//Code should never reach here
				return 0;
			}
			public void print(string file_name)
			{
				output_file.open(file_name);
				output_file << "graph {\n";
				Trie curr = this;
				int count = 0;
				print_rec(curr, count);
				output_file << "}";
				output_file.close();
				return;
			}
			public object print_rec(Trie root, ref int count)
			{
				for (int i = 0; i < CHAR_SIZE; i++)
				{
					if (!haveChildren(root))
					{
						continue;
					}
					Trie letter = new Trie();
					letter = root.character[i];
					output_file << letter << count << " -- " << root.character[i + 1] << "[Label = \" " << letter << " \"]";
					count++;
					letter = null;
					print_rec(root.character[i + 1], count);
				}
				return;
			}
		}

	}
*/