#pragma once
#include "node.h"
#include <fstream>

// Define the character size
//#define CHAR_SIZE 128

//Class to construct a trie and call methods to read in data from a file, insert a string, search for a string
//Check for child nodes, auto completeion suggestions and auto complete prefix
//Printing a DOT file
class Trie {

    public:
        Node* root;
        
        std::ofstream output_file;
        
        //bool isLeaf;
        //int counter = 0;
        //Trie* character[CHAR_SIZE];

        // Constructor
        Trie();
        //Destructor
        ~Trie();
        void readFile(std::string file_name);
        
        void insert(std::string data, Node* root);
        //bool deletion(Node* current, std::string data);
        
        bool search(std::string data, Node* root);
        
        bool haveChildren(Node* root);
        void auto_comp_recur(Node* root, std::string prefx);
        int auto_comp(std::string data, Node* root);
        void print(std::string file_name, Node* root);
        void print_rec(Node* root, int& count);

        friend class Node;
};
