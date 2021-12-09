#include "trie.h"
#include <sstream>
#include <fstream>
#include <vector>

// Constructor Function
Trie::Trie(){

        //Creating a blank root node for the whole Trie to branch from
        this->root = new Node();


}

// Destructor function
Trie::~Trie(){

    //removeChild(this);
    //delete this->root;
}

//void removeChild()


// Function to read input file and store words in tree
void Trie::readFile(std::string file_name){

    //Create a stream object of File_Name
    std::ifstream file(file_name);

    // Create string object of line
    std::string line;

    // Loop to look at each line in the file
    while(std::getline(file, line)){

        // Create a stream object that contains each line in the file
        std::istringstream stream(line);

        // Create a string object for each word
        std::string key;

        // Loop to insert each word into the trie
        while(stream >> key){

            insert(key, this->root);

        }
        // After each word, continue to next word till line is done
        }
    //After each line, continue to next line till file is done

}



// Function to insert a word into the Trie
void Trie::insert(std::string data, Node* root) {

    // Starting from the root node from constructor
    Node* current = root;
    //std::cout<<(*curr)<<std::endl;
    // Loop to check each letter in the word to see if a child node of the key already exists
    std::cout<< "Adding " << data << " to the trie. . . "<<std::endl;
    for (unsigned int i = 0; i < data.length(); i++) {


        // If a child node of that key does not already exist

        if (current->character[data[i]] == nullptr) {

            // Create a new node of that data
            current->character[data[i]] = new Node(data[i]);
        }

        // If a child node of that key does exist, or has been created then,
        // go to the next node.
        current = current->character[data[i]];
    }

    // Once the end of the key word being inserted has been reached,
    // mark the current node as a leaf

    current->isLeaf = true;
    current->counter += 1;
}




// Iterative function to search a key in a Trie. It returns true
// if the key is found in the Trie; otherwise, it returns false
bool Trie::search(std::string data, Node* root)
{
    // return false if Trie is empty
    if (root == nullptr) {
        std::cout<<"The trie is empty"<<std::endl;
        return false;
    }

    Node* current = root;

    //std::cout<<(*curr)<<std::endl;

    std::cout<<"Searching for "<< data<< " within trie"<<std::endl;

    for (unsigned int i = 0; i < data.length(); i++)

    {
        //Traverese to the next node
        current = current->character[data[i]];
        // if the string is invalid, reaching the end of a path in the Trie
        if (current == nullptr) {
            std::cout<<"Word was not found in trie"<<std::endl;
            return false;
        }
    }

    // return true if the current node is a leaf and the
    // end of the string is reached
    std::cout << data<< ": "<<current->counter << std::endl;
    return current->isLeaf;
}


 //Function to check if the current node has any children

bool Trie::haveChildren(Node* root) {
     // Loop to check if
     for (int i = 0; i < CHAR_SIZE; i++) {
         if (root->character[i]) {
             return true;    // child found
         }
    }
     return false;
}


//Function to print out all words in trie, if found, containing the prefix passed into the parameter
int Trie::auto_comp(std::string data, Node* root){
    std::cout << "Looking for prefix 'un'" << std::endl;
    Node* current = root;
    
    //For loop to traverse through the string, data, passed into to check if each character is found in the trie
    for(unsigned int height = 0; height < data.length(); height++){
        //Used to indicate the "level" at which point the character is found in the trie
        int idx = data[height];
        //Conditional to check if the character at index level exists if not it's not in the trie
        if(!current->character[idx]){
            std::cout<< "No words found for prefix"<<std::endl;
            return 0;
        }
        
        //sets current to the character at index level
        current = current->character[idx];
    }
    
    //boolean used to check if the node is the end of the word
    bool end_of_word = (current->isLeaf == true);
    
    //boolean to check if the current node has a child
    bool child = haveChildren(current);
    
    //Conditional to check if the end of the prefix is the end of the word 
    //meaning no more words are found to match it
    if(end_of_word && !child){
        std::cout<< data << std::endl;
        std::cout<< "No more words matching prefix"<< std::endl;
        return -1;
    }
    
    //Conditional to check if there is a child node and call recursive function
    if(child){
        std::string prefx = data;
        auto_comp_recur(current, prefx);
        
        return 1;
    }
    //Code should never reach here
    return 0;
}

void Trie::auto_comp_recur(Node* root, std::string prefx){
    //base case if root character is leaf node
    if (root ->isLeaf){
        std::cout<< "Found: " <<prefx<<std::endl;
    }

    //base case if the root has no more children
    if(!haveChildren(root)){
        return;
    }

    //Loop to iterate through the trie and pop remaining characters for an autocomplete of word onto the output
    for(int i = 0; i < CHAR_SIZE; i++){
        //Conditional if the charcater exists then push it onto string and recursively call function
        if(root->character[i]){

            prefx.push_back(i);

            auto_comp_recur(root->character[i], prefx);
            //Remove charcater off of prefix for next autocomplete word
            prefx.pop_back();

        }
    }
}



// // Recursive function to delete a key in the Trie
// bool Trie::deletion( std::string data)
// {
//     // return if Trie is empty
//     if (curr == nullptr) {
//         return false;
//     }

//     // if the end of the key is not reached
//     if (key.length())
//     {
//         // recur for the node corresponding to the next character in the key
//         // and if it returns true, delete the current node (if it is non-leaf)

//         if (curr != nullptr &&
//             curr->character[key[0]] != nullptr &&
//             deletion(curr->character[key[0]], key.substr(1)) &&
//             curr->isLeaf == false)
//         {
//             if (!haveChildren(curr))
//             {
//                 delete curr;
//                 curr = nullptr;
//                 return true;
//             }
//             else {
//                 return false;
//             }
//         }
//     }

//     // if the end of the key is reached
//     if (key.length() == 0 && curr->isLeaf)
//     {
//         // if the current node is a leaf node and doesn't have any children
//         if (!haveChildren(curr))
//         {
//             // delete the current node
//             delete curr;
//             curr = nullptr;

//             // delete the non-leaf parent nodes
//             return true;
//         }

//         // if the current node is a leaf node and has children
//         else {
//             // mark the current node as a non-leaf node (DON'T DELETE IT)
//             curr->isLeaf = false;

//             // don't delete its parent nodes
//             return false;
//         }
//     }

//     return false;
// }



// void Trie:: print(std::string file_name, Node* root){
//     output_file.open(file_name);
//     output_file << "graph {\n";
//     Node* curr = root;
//     int count = 0;
//     print_rec(curr, count);
//     output_file << "}";
//     output_file.close();
//     return;
// }

// void Trie::print_rec(Node* root, int& count){

//     // for(int i = 0; i < CHAR_SIZE; i++){
//     //     if(haveChildren(root)){
//     //         continue;
//     //     }

//     //     std::string letter = root->data;
//     //     std::cout << "asjdhkfasdlifajsdifahsdfhaksdf" <<std::endl;
//     //     //output_file << letter <<count << " -- "<< root->character[i + 1]<<"[Label = \" " << letter<< " \"]";

//     //     count++;
//     //     print_rec(root->character[i + 1], count);
    
    
//     if (root->isLeaf) {
        
//     }
    
//     if (!haveChildren(root)) {
//         return;
//     }
    
    
    
//     std::cout << root->data std::endl;
    
    
    
    
// }


// https://www.graphviz.org/pdf/dotguide.pdf

//start at root
//check if root has children
//if root has children, move onto next child
//if root does not have children, print current node connected to previous node