#include "node.h"
#include "trie.h"
#include <iostream>



int main(int argc, char**argv) {

    std::string fileName = argv[1];


    //Trie* head = new Trie();
    
    
    Trie t;
    
    t.readFile(fileName);
    
    //WORD IS IN TRIE
    t.search("unable", t.root);
    
    //WORD IS NOT IN TRIE
    t.search("undesired", t.root);
    
    //INSERT WORD INTO TRIE
    t.insert("undesired", t.root);
    
    //WORD IS NOW IN TRIE
    t.search("undesired", t.root);
    
    //Demonstrate Autocomplete
    t.auto_comp("un", t.root);
    
   
    
    std::string outFile = "dotfile.txt";
    
    t.print(outFile,t.root);
    
    return 0;

}