#pragma once
#include <iostream>
#include <string>

//Define the character size
#define CHAR_SIZE 128

//class for each node in the trie
//Properties of each node is the data it holds,
//A counter to check for repeat words
//boolean check for the end of a string
//pointer pointing to next node or null
class Node{
    public:

        std::string data;
        int counter;
        bool isLeaf;
        Node* next;
        Node* character[CHAR_SIZE];
        friend class trie;


        Node();
        ~Node();
        Node(char data);
        Node(std::string data, Node* next);
};