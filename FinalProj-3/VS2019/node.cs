using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trie
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


}
