#include "node.h"

Node::Node(){
    //setting root node of whole trie to blank space
    this->data = ' ';
    this->next = nullptr;
}

Node::~Node(){
    if(this->next != nullptr){
        delete this->next;
    }
}

Node::Node(char data){
    this->data = data;
    this->counter = 0;
    this->isLeaf = false;
    // Each node is given Children nodes that point to Nullptr for the amount
    // of characters we are considering
    for (unsigned int i = 0; i < CHAR_SIZE; i++) {

        // Set each child to nullptr
        this->character[i] = nullptr;

        }
}


Node::Node(std::string data, Node* next){
    this->data = data;
    this->next = next;
}