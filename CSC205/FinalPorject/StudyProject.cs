using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;    //Necessary in order to use StreamReader/Writer
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;       //Necessary in order to use ClassLibrary

namespace CSC205_StudyProject
{

    public partial class StudyProject : Form
    {
        
        public StudyProject()
        {
            InitializeComponent();

            string str1 = "WELCOME TO DATA STRUCTURES && ALGORITHMS";
            label4.Text = WelcomeMessage(str1);

            //Using a container(List) with a for loop
            List<string> notesLabel = new List<string>();
            notesLabel.Add("EXTRA NOTES");
            for (int i = 0; i < notesLabel.Count; i++)
            {
                label3.Text = notesLabel[i];
            }
        }
        //USE OF 1 NON-VOID METHOD
        public static string WelcomeMessage(string str1)
        {
            return str1;
        }

        //PRIVATE ACCESS MODIFIER which can only be accessed within the current class
        private void button10_Click(object sender, EventArgs e) //CLEAR BUTTON
        {
            richTextBox1.Clear();
            richTextBox2.Clear();
        }

        private void button22_Click(object sender, EventArgs e) //TIME / SPACE COMPLEXITY BUTTON
        {
            //Displaying ENUMS to windows form with extra notes for Big O notation and asymptotic analysis
            richTextBox1.AppendText("COMMON BIG O RUNTIMES\n");
            richTextBox1.AppendText("O(1): " + BigO.Constant.ToString() + " (Fastest)\n");
            richTextBox1.AppendText("O(log n): " + BigO.Logarithmic.ToString() + " (Good)\n");
            richTextBox1.AppendText("O(n): " + BigO.Linear.ToString() + " (Fair)\n");
            richTextBox1.AppendText("O(n log n): " + BigO.Linearithmic.ToString() + " (Bad)\n");
            richTextBox1.AppendText("O(n^2): " + BigO.Quadratic.ToString() + " (Really Bad)\n");
            richTextBox1.AppendText("O(2^n): " + BigO.Exponential.ToString() + " (Really Bad)\n");
            richTextBox1.AppendText("O(n!): " + BigO.Factorial.ToString() + " (Really Bad)\n\n");
            richTextBox1.AppendText("Big O – upper bound on the time in an algorithm.  Upper bounds for runtime. \n" +
                "Big Omega(Ω) – lower bound on the time in an algorithm.  Lower bounds for runtime. \n" +
                "Big Theta(Θ) – both Big O and Big Omega.  Theta gives a tight bound on runtime. \n" +
                "Runtimes for algorithms: Best -case, Worst -case, and Expected case describe the Big O (or big theta) time for particular inputs or scenarios.\n\n");
            richTextBox1.AppendText("Asymptotic Analysis:");
            richTextBox1.AppendText("-Drop constants (inputs are so large constants do not matter)\n" +
                "- Big O allows us to express how runtimes scale\n" +
                "- Drop the Non - Dominant Terms(O(N ^ 2) will drown out O(N))\n" +
                "- Add vs.Multiply\n" +
                "       - If your algorithm is in the form “do this, then, when you’re all done, do that” then ADD O(n)\n" +
                "       - If your algorithm is in the form “do this for each time you do that” then MULTIPLY O(n)\n");



            //Displaying extra notes from a rich text file in the bin
            using (StreamReader Reader = new StreamReader(@"C:\Users\Clayt\source\repos\CSC205\CSC205_StudyProject\CSC205_StudyProject\bin\BigONotes.rtf"))
            {
                while (!Reader.EndOfStream)
                {
                    richTextBox5.AppendText(Reader.ReadLine());
                }
            }
        }

        //USING ENUMS AS RATES FOR BIG O NOTATION
        enum BigO
        { 
            Constant,       //O(1)
            Logarithmic,    //O(log n)
            Linear,         //O(n)
            Linearithmic,   //O(n log n)
            Quadratic,      //O(n^2)
            Exponential,    //O(2^n)
            Factorial       //O(n!)
        }

        private void btnArray_Click(object sender, EventArgs e) //ARRAY BUTTON
        {
            //USE OF NON-DEFAULT CONSTRUCTOR
            Array1 array2 = new Array1("Access Time: O(1)", "Search Time: O(n)", "Insertion Time: O(n)", "Deletion Time: O(n)", "Space Complexity: O(n)");
            int i = 0;
            while (i < 1)
            {
                richTextBox2.AppendText(array2.AccessTime + "       ");
                richTextBox2.AppendText(array2.SearchTime + "\n");
                richTextBox2.AppendText(array2.InsertTime + "        ");
                richTextBox2.AppendText(array2.DeleteTime + "\n");
                richTextBox2.AppendText(array2.SpaceComplexity + "\n");
                richTextBox2.AppendText("*All Big-O values represent worst-case scenarios unless otherwise noted");
                i++;
            }

            //Declaring new object and using class methods to display advantages and disadvantgaes of Arrays
            Array1 array1 = new Array1();
            for (int j = 0; j < 1; j++)
            {
                richTextBox1.AppendText("ARRAYS: \n");
                richTextBox1.AppendText(array1.Advantages());
                richTextBox1.AppendText("\n\n");
                richTextBox1.AppendText(array1.Disadvantages());
            }

            //Displaying extra notes from a rich text file in the bin
            using (StreamReader Reader = new StreamReader(@"C:\Users\Clayt\source\repos\CSC205\CSC205_StudyProject\CSC205_StudyProject\bin\ArrayFile.rtf"))
            {
                while (!Reader.EndOfStream)
                {
                    richTextBox5.AppendText(Reader.ReadLine());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) //HASH BUTTON
        {
            //Declaring a new instance of HashTable and displaying properties to the Windows Form
            HashTable1 Hash1 = new HashTable1();
            
            richTextBox2.AppendText(Hash1.AccessTime + "        ");
            richTextBox2.AppendText(Hash1.SearchTime + "\n");
            richTextBox2.AppendText(Hash1.InsertTime + "        ");
            richTextBox2.AppendText(Hash1.DeleteTime + "\n");
            richTextBox2.AppendText(Hash1.SpaceComplexity + "\n");
            richTextBox2.AppendText("These values represent worst case scenarios,\n" +
                "the expected running time for search, insert, and delete are usually: O(1)");

            //Displaying the Advantages and Disadvantages of HashTables to the Windows Form
            richTextBox1.AppendText(Hash1.Advantages("HASH TABLE: \n"));
            richTextBox1.AppendText(Hash1.Advantages("A hash table is a data structure that maps keys to values for highly efficient lookup.  \n" +
                "Watch out for collisions where two different hash keys map to the same index.\n" +
                "Lookup time is usually: O(1) \n" +
                "Can be O(n) if number of collisions is very high. \n" +
                "Alternatively, we can use a balanced binary search tree with lookup of O(log n), this will also use less space.  And it’s possible to iterate through the keys in order."));
            richTextBox1.AppendText("\n\n");
            richTextBox1.AppendText(Hash1.Disadvantages("The disadvantages of using a Hash Table in C# are: \n" +
                "-Hash collisions are practically unavoidable.\n" +
                "-Hash tables become quite inefficient when there are many collisions.\n" +
                "-Hash table does not allow null values, like hash map.\n" +
                "-There is also the extra space consideration when using a hash table."));

            //Displaying extra notes from a rich text file in the bin
            using (StreamReader Reader = new StreamReader(@"C:\Users\Clayt\source\repos\CSC205\CSC205_StudyProject\CSC205_StudyProject\bin\HashTable.rtf"))
            {
                while (!Reader.EndOfStream)
                {
                    richTextBox5.AppendText(Reader.ReadLine());
                }
            }
            
        }

        private void button11_Click(object sender, EventArgs e) //SAVE BUTTON
        {
            //Makes it possible to save notes to a separate word document
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save File";
            save.Filter = "Rich Text Files (*.rtf)|*.rtf| All Files (*.*)|*.*";

            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(File.Create(save.FileName));

                write.Write(richTextBox5.Text);
                write.Dispose();
            }

            
        }

        private void button1_Click(object sender, EventArgs e) //SECOND CLEAR BUTTON
        {
            
            richTextBox5.Clear();
        }

        private void btnLinkedList_Click(object sender, EventArgs e) //LINKED LIST BUTTON
        {
            //Declaring a new instance of Linked List and displaying properties to the Windows Form
            LinkedList1 LinkList = new LinkedList1();
            richTextBox2.AppendText(LinkList.AccessTime + "        ");
            richTextBox2.AppendText(LinkList.SearchTime + "\n");
            richTextBox2.AppendText(LinkList.InsertTime + "        ");
            richTextBox2.AppendText(LinkList.DeleteTime + "\n");
            richTextBox2.AppendText(LinkList.SpaceComplexity + "\n");
            richTextBox2.AppendText("*All Big-O values represent worst-case scenarios unless otherwise noted");

            //Displaying the Advantages and Disadvantages of Linked List to the Windows Form
            richTextBox1.AppendText("LINKED LIST: \n");
            richTextBox1.AppendText(LinkList.Advantages("A linked List is a data structure that represents a sequence of nodes.  " +
                "In a singly linked list, each node points to the next node in the linked list.  " +
                "A double linked list gives each pointers to both the next node and the previous node.  "));
            richTextBox1.AppendText("\n\n");
            richTextBox1.AppendText(LinkList.Disadvantages("Unlike an array a linked list does not provide " +
                "constant time access to a particular “index” within the list.  " +
                "In order to find the Kth element in a list you would have to iterate through K elements.  "));

            //Displaying extra notes from a rich text file in the bin
            using (StreamReader Reader = new StreamReader(@"C:\Users\Clayt\source\repos\CSC205\CSC205_StudyProject\CSC205_StudyProject\bin\LinkedList.rtf"))
            {
                while (!Reader.EndOfStream)
                {
                    richTextBox5.AppendText(Reader.ReadLine());
                }
            }
        }

        private void btnStack_Click(object sender, EventArgs e) //STACK BUTTON
        {
            //Declaring a new instance of Stacks and displaying properties to the Windows Form
            Stack1 stack1 = new Stack1();
            richTextBox2.AppendText(stack1.AccessTime + "        ");
            richTextBox2.AppendText(stack1.SearchTime + "\n");
            richTextBox2.AppendText(stack1.InsertTime + "        ");
            richTextBox2.AppendText(stack1.DeleteTime + "\n");
            richTextBox2.AppendText(stack1.SpaceComplexity + "\n");
            richTextBox2.AppendText("*All Big-O values represent worst-case scenarios unless otherwise noted");

            //Displaying the Advantages and Disadvantages of Stacks to the Windows Form
            richTextBox1.AppendText("STACK: \n");
            richTextBox1.AppendText(stack1.Advantages("A stack stores data in the same way that arrays do—it’s simply a list of elements." +
                "A stack uses LIFO (last -in first -out) ordering.\n" +
                "It uses the following operations:\n" +
                "   -pop(): Remove the top item from the stack.\n" +
                "   -push(item): Add an item to the top of the stack.\n" +
                "   -peek(): return the top of the stack.\n" +
                "   -isEmpty(): Return true if and only if the stack is empty.\n" +
                "Stacks are useful in certain recursive algorithms.  And allows constant time adds and removes."));
            richTextBox1.AppendText("\n\n");
            richTextBox1.AppendText(stack1.Disadvantages("Disadvantages of a stack: \n" + 
                "   -Stack memory is very limited.\n" +
                "   -Creating too many objects on the stacks can increase the risk of stack overflow. \n" +
                "   -Random access is not possible. \n" +
                "   -Variable storage will be overwritten, which sometimes leads to undefined behavior of the function or program."));

            //Displaying extra notes from a rich text file in the bin
            using (StreamReader Reader = new StreamReader(@"C:\Users\Clayt\source\repos\CSC205\CSC205_StudyProject\CSC205_StudyProject\bin\Stack.rtf"))
            {
                while (!Reader.EndOfStream)
                {
                    richTextBox5.AppendText(Reader.ReadLine());
                }
            }
        }

        private void btnQUEUE_Click(object sender, EventArgs e) //QUEUE BUTTON
        {
            //Declaring a new instance of Queue and displaying properties to the Windows Form
            Queue1 queue = new Queue1();
            richTextBox2.AppendText(queue.AccessTime + "        ");
            richTextBox2.AppendText(queue.SearchTime + "\n");
            richTextBox2.AppendText(queue.InsertTime + "        ");
            richTextBox2.AppendText(queue.DeleteTime + "\n");
            richTextBox2.AppendText(queue.SpaceComplexity + "\n");
            richTextBox2.AppendText("*All Big-O values represent worst-case scenarios unless otherwise noted");

            //Displaying the Advantages and Disadvantages of Queue to the Windows Form
            richTextBox1.AppendText("QUEUE: \n");
            richTextBox1.AppendText(queue.Advantages("A queue deals with temporary data elegantly, " +
                "and it is like a stack in that it is an array with restrictions.  " +
                "A queue implements FIFO (First-in first-out) ordering.  It uses the following operations:\n" +
                "   -add(item): Add an item to the end of the list.\n" +
                "   -remove(): Remove the first item in the list.\n" +
                "   -peek(): Return the top of the queue. \n" +
                "   -isEmpty(): Return true if and only if the queue is empty.\n" +
                "A queue can also be implemented with a linked list.  In fact, they are essentially " +
                "the same thing, as long as items are added and removed from opposite sides.Queues are " +
                "often used in breadth - first search or in implementing a cache."));
            richTextBox1.AppendText("\n\n");
            richTextBox1.AppendText(queue.Disadvantages("The disadvantages of Queues: \n" +
                "   -A queue is not readily searchable.\n" +
                "   -Adding or deleting from the middle of the queue is complex as well.\n"));

            //Displaying extra notes from a rich text file in the bin
            using (StreamReader Reader = new StreamReader(@"C:\Users\Clayt\source\repos\CSC205\CSC205_StudyProject\CSC205_StudyProject\bin\Queue.rtf"))
            {
                while (!Reader.EndOfStream)
                {
                    richTextBox5.AppendText(Reader.ReadLine());
                }
            }
        }

        private void btnBinarySeacrh_Click(object sender, EventArgs e) //BINARY SEARCH TREE BUTTON
        {
            //Declaring a new instance of Binary Search Tree and displaying properties to the Windows Form
            Tree1 tree1 = new Tree1("Access Time: O(n)","Search Time: O(n)","Insert Time: O(n)","Delete Time: O(n)","Space Complexity: O(n)");
            richTextBox2.AppendText(tree1.AccessTime + "        ");
            richTextBox2.AppendText(tree1.SearchTime + "\n");
            richTextBox2.AppendText(tree1.InsertTime + "        ");
            richTextBox2.AppendText(tree1.DeleteTime + "\n");
            richTextBox2.AppendText(tree1.SpaceComplexity + "\n");
            richTextBox2.AppendText("*All Big-O values represent worst-case scenarios unless otherwise noted");

            //Displaying the Advantages and Disadvantages of Binary Search Tree to the Windows Form
            richTextBox1.AppendText("TREES\n");
            richTextBox1.AppendText(tree1.Advantages("A tree is a data structure composed of nodes.\n" +
                "   - Each tree has a root node.\n" +
                "   - The root node has zero or more child nodes.\n" +
                "   - Each child node has zero or more child nodes, and so on.\n" +
                "The tree cannot contain cycles.The nodes may or may not be in a particular order, " +
                "they could have any data type as values, and they may or may not have links back to their " +
                "parent nodes.A node is called a “leaf” node if it has no children."));
            richTextBox1.AppendText("\n\n");
            richTextBox1.AppendText("Binary Search Tree(BST): \n" +
                "   -BSTs are the best options when trying to optimize for efficient searching and flexible updates. " +
                "The best / worst cases are differentiated by how well balanced the tree is. Balanced trees are more " +
                "efficient than unbalanced trees\n");
            richTextBox1.AppendText(tree1.Disadvantages("\nThe disadvantages of Binary Search Tree: \n" +
                "   -BSTs have more overhead and complexity to initialize and maintain.\n" +
                "   -The main disadvantage is that we should always implement a balanced binary search tree: AVL tree, " +
                "Red-Black tree, Splay tree. Otherwise the cost of operations may not be logarithmic and degenerate " +
                "into a linear search on an array."));

            //Displaying extra notes from a rich text file in the bin
            using (StreamReader Reader = new StreamReader(@"C:\Users\Clayt\source\repos\CSC205\CSC205_StudyProject\CSC205_StudyProject\bin\BinarySearchTree.rtf"))
            {
                while (!Reader.EndOfStream)
                {
                    richTextBox5.AppendText(Reader.ReadLine());
                }
            }
        }

        private void btnAVLTree_Click(object sender, EventArgs e) //AVL TREE BUTTON
        {
            //Declaring a new instance of AVL Tree and displaying properties to the Windows Form
            Tree1 avlTree = new Tree1("Access Time: O(log(n))", "Search Time: O(log(n))", "Insert Time: O(log(n))", "Delete Time: O(log(n))", "Space Complexity: O(n)");
            richTextBox2.AppendText(avlTree.AccessTime + "        ");
            richTextBox2.AppendText(avlTree.SearchTime + "\n");
            richTextBox2.AppendText(avlTree.InsertTime + "        ");
            richTextBox2.AppendText(avlTree.DeleteTime + "\n");
            richTextBox2.AppendText(avlTree.SpaceComplexity + "\n");
            richTextBox2.AppendText("*All Big-O values represent worst-case scenarios unless otherwise noted");

            //Displaying the Advantages and Disadvantages of AVL Tree to the Windows Form
            richTextBox1.AppendText("AVL TREES:\n");
            richTextBox1.AppendText(avlTree.Advantages("The advantages of AVL: \n" +
                "   -The most prevalent benefit of AVL trees is the fact that they offer faster search operations than their counterparts such as red-black trees\n" +
                "   -with AVL trees, there is a higher likelihood of them being balanced."));
            richTextBox1.AppendText("\n(AVL stands for Adelson-Velskii and Landis)");
            richTextBox1.AppendText("\n\n");
            richTextBox1.AppendText(avlTree.Disadvantages("The disadvantages of AVL: \n " +
                "   -Slow inserts and deletes if slightly unbalanced.\n" +
                "   -Don't work well with systems that update quickly and regularly."));

            //Displaying extra notes from a rich text file in the bin
            using (StreamReader Reader = new StreamReader(@"C:\Users\Clayt\source\repos\CSC205\CSC205_StudyProject\CSC205_StudyProject\bin\AVLTree.rtf"))
            {
                while (!Reader.EndOfStream)
                {
                    richTextBox5.AppendText(Reader.ReadLine());
                }
            }
        }

        private void btnRedBlackTree_Click(object sender, EventArgs e) //RED-BLACK TREE BUTTON
        {
            //Declaring a new instance of Red-Black Tree and displaying properties to the Windows Form
            Tree1 redBlackTree = new Tree1("Access Time: O(log(n))", "Search Time: O(log(n))", "Insert Time: O(log(n))", "Delete Time: O(log(n))", "Space Complexity: O(n)");
            richTextBox2.AppendText(redBlackTree.AccessTime + "        ");
            richTextBox2.AppendText(redBlackTree.SearchTime + "\n");
            richTextBox2.AppendText(redBlackTree.InsertTime + "        ");
            richTextBox2.AppendText(redBlackTree.DeleteTime + "\n");
            richTextBox2.AppendText(redBlackTree.SpaceComplexity + "\n");
            richTextBox2.AppendText("*All Big-O values represent worst-case scenarios unless otherwise noted");

            //Displaying the Advantages and Disadvantages of Red-Black Tree to the Windows Form
            richTextBox1.AppendText("RED-BLACK TREES\n");
            richTextBox1.AppendText(redBlackTree.Advantages("Red-Black Tree is a self-balancing " +
                "Binary Search Tree (BST) where every node follows following rules.\n" +
                "   -Every node has a color either red or black.\n" +
                "   -Root of tree is always black.\n" +
                "   -There are no two adjacent red nodes (A red node cannot have a red parent or red child).\n" +
                "   -Every path from a node (including root) to any of its descendant NULL node has the same number of black nodes.\n" +
                "Red-Black Trees are designed such that as elements are added or " +
                "removed, the whole tree shifts to accommodate the change. It keeps the tree balanced so that you can search the tree very fast."));
            richTextBox1.AppendText("\n\n");
            richTextBox1.AppendText(redBlackTree.Disadvantages("The disadvantages of Red-Black Tree: \n" +
                "   -can be complicated to implement."));

            //Displaying extra notes from a rich text file in the bin
            using (StreamReader Reader = new StreamReader(@"C:\Users\Clayt\source\repos\CSC205\CSC205_StudyProject\CSC205_StudyProject\bin\RedBlackTree.rtf"))
            {
                while (!Reader.EndOfStream)
                {
                    richTextBox5.AppendText(Reader.ReadLine());
                }
            }
        }

        private void btnGraph_Click(object sender, EventArgs e) //GRAPH BUTTON
        {
            //Declaring a new instance of Graph and displaying properties to the Windows Form
            Graph1 graph = new Graph1();
            richTextBox2.AppendText(graph.AccessTime + "        ");
            richTextBox2.AppendText(graph.SearchTime + "\n");
            richTextBox2.AppendText(graph.InsertTime + "        ");
            richTextBox2.AppendText(graph.DeleteTime + "\n");
            richTextBox2.AppendText(graph.SpaceComplexity + "\n");
            richTextBox2.AppendText("*All Big-O values represent worst-case scenarios unless otherwise noted");

            //Displaying the Advantages and Disadvantages of Graph to the Windows Form
            richTextBox1.AppendText("GRAPHS\n");
            richTextBox1.AppendText(graph.Advantages("A Graph is a non-linear data structure consisting of " +
                "nodes and edges. Graphs are used to solve many real-life problems. Graphs are used to represent networks.  Trees are a type of graph."));
            richTextBox1.AppendText("\n\n");
            richTextBox1.AppendText(graph.Disadvantages("Types of Graph: \n" +
                "Undirected Graph: nodes are connected by edges that are all bidirectional. \n" +
                "Directed Graph: nodes are connected by directed edges - they only go in one direction. \n" +
                "\nTypes of Graph Represntations: \n" +
                "Adjacency List is an array of lists.  The size of the array is equal to the number of nodes.\n" +
                "Adjacency Matrix is a 2D array of size n*n where n is the number of nodes in a graph."));

            //Displaying extra notes from a rich text file in the bin
            using (StreamReader Reader = new StreamReader(@"C:\Users\Clayt\source\repos\CSC205\CSC205_StudyProject\CSC205_StudyProject\bin\Graph.rtf"))
            {
                while (!Reader.EndOfStream)
                {
                    richTextBox5.AppendText(Reader.ReadLine());
                }
            }
        }

        private void btnQuickSort_Click(object sender, EventArgs e) //QUICKSORT BUTTON
        {
            //Declaring a new instance of QuickSort and displaying properties to the Windows Form
            QuickSort quickSort = new QuickSort();
            richTextBox2.AppendText(quickSort.TimeComplexity + "\n");
            richTextBox2.AppendText(quickSort.SpaceComplexity);
            richTextBox2.AppendText("\n*All Big-O values represent worst-case scenarios unless otherwise noted");

            //Displaying the Advantages and Disadvantages of QuickSort to the Windows Form
            StringBuilder qs = new StringBuilder();
            qs.Append("QUICKSORT: \nQuicksort is a recursive sorting routine that works by partitioning the array so that items with" +
                "smaller keys are separated from those with larger keys and recursively applying itself to the two" +
                "groups.\n\nAdvantages of Quicksort: \n    -Its average -case time complexity to sort an array of n elements is O(n lg n). \n" +
                "   -On the average it runs very fast, even faster than Merge Sort. \n    -It requires no additional memory.\n\nDisadvantages of " +
                "Quicksort:\n   -Its running time can differ depending on the contents of the array.  \n    -Quicksort's running time degrades if given an " +
                "array that is almost sorted (or almost reverse sorted).Its worst -case running time, O(n2) to sort an array of n elements, happens " +
                "when given a sorted array.  \n     -It is not stable.");
            richTextBox1.AppendText(qs.ToString());
            

            //Displaying extra notes from a rich text file in the bin
            using (StreamReader Reader = new StreamReader(@"C:\Users\Clayt\source\repos\CSC205\CSC205_StudyProject\CSC205_StudyProject\bin\QuickSort.rtf"))
            {
                while (!Reader.EndOfStream)
                {
                    richTextBox5.AppendText(Reader.ReadLine());
                }
            }
        }

        private void btnMergeSort_Click(object sender, EventArgs e) //MERGESORT BUTTON
        {
            //Declaring a new instance of MergeSort and displaying properties to the Windows Form
            MergeSort mergeSort = new MergeSort();
            richTextBox2.AppendText(mergeSort.TimeComplexity + "\n");
            richTextBox2.AppendText(mergeSort.SpaceComplexity);
            richTextBox2.AppendText("\n*All Big-O values represent worst-case scenarios unless otherwise noted");

            //Displaying the Advantages and Disadvantages of MergeSort to the Windows Form
            StringBuilder qs = new StringBuilder();
            qs.Append("MERGE SORT:\nMerge Sort is a type of sorting algorithm which follows the principle of 'divide and conquer'. " +
                "The first stage is where the list is split until it forms individual elements called sub-lists. After this, the 'merge' stage begins. " +
                "Here the sub-lists  are paired up and are arranged according to the order stated (ascending/descending). these paired lists are " +
                "paired again to form groups of 4 and are again arranged according to the intended/ given order. This process happens until the sub-lists form " +
                "one list. \n\nAdvantages of Merge Sort:\n  -It is quicker for larger lists because unlike insertion and bubble sort it doesnt go through the whole list seveal times.\n" +
                "   -It has a consistent running time, carries out different bits with similar  times in a stage.\n\n" +
                "Disadvantages of Merge Sort:\n     -Slower comparative to the other sort algorithms for smaller tasks.\n     -Goes through the whole process even i he list is sorted(just like insertion and bubble sort?)" +
                "\n     -Uses more memory space to store the sub elements of the initial split list.");
            richTextBox1.AppendText(qs.ToString());

            //Displaying extra notes from a rich text file in the bin
            using (StreamReader Reader = new StreamReader(@"C:\Users\Clayt\source\repos\CSC205\CSC205_StudyProject\CSC205_StudyProject\bin\MergeSort.rtf"))
            {
                while (!Reader.EndOfStream)
                {
                    richTextBox5.AppendText(Reader.ReadLine());
                }
            }
        }

        private void btnBubbleSort_Click(object sender, EventArgs e) //BUBBLESORT BUTTON
        {
            //Declaring a new instance of BubbleSort and displaying properties to the Windows Form
            BubbleSort bubbleSort = new BubbleSort();
            richTextBox2.AppendText(bubbleSort.TimeComplexity + "\n");
            richTextBox2.AppendText(bubbleSort.SpaceComplexity);
            richTextBox2.AppendText("\n*All Big-O values represent worst-case scenarios unless otherwise noted");

            //Displaying the Advantages and Disadvantages of BubbleSort to the Windows Form
            StringBuilder qs = new StringBuilder();
            qs.Append("BUBBLE SORT:\nBubble sort algorithms cycle through a list, analyzing pairs of elements from left to right, " +
                "or beginning to end.If the leftmost element in the pair is less than the rightmost element, the pair will remain in that order.If the rightmost " +
                "element is less than the leftmost element, then the two elements will be switched.This cycle repeats from beginning to end until a pass in which " +
                "no switch occurs.The bubble sort is a very memory-efficient because all of the ordering occurs within the array or list itself(7).No new memory " +
                "is allocated(7). No new data structures are necessary, for the same reason. \n\nAdvantages of Bubble Sort:\n  -The bubble sort requires very little memory other than" +
                "that which the array or list itself occupies.\n    -The bubble sort is comprised of relatively few lines of code.\n     -With a best -case running time of O(n), the bubble sort " +
                "is good for testing whether or not a list is sorted or not.Other sorting methods often cycle through their whole sorting sequence, which often have runningtimes of " +
                "O(n ^ 2) or O(n log n) for this task.\n    -The same applies for data sets that have only a few items that need to be swapped a few times. " +
                "\n\nDisadvantages of Bubble Sort:\n    -The main disadvantage of the bubble sort method is the time it requires.With a running time of " +
                "O(n ^ 2), it is highly inefficient for large data sets.");
            richTextBox1.AppendText(qs.ToString());

            //Displaying extra notes from a rich text file in the bin
            using (StreamReader Reader = new StreamReader(@"C:\Users\Clayt\source\repos\CSC205\CSC205_StudyProject\CSC205_StudyProject\bin\BubbleSort.rtf"))
            {
                while (!Reader.EndOfStream)
                {
                    richTextBox5.AppendText(Reader.ReadLine());
                }
            }
        }

        private void btnSelectionSort_Click(object sender, EventArgs e) //SELECTIONSORT BUTTON
        {
            //Declaring a new instance of selectionSort and displaying properties to the Windows Form
            SelectionSort selectionSort = new SelectionSort();
            richTextBox2.AppendText(selectionSort.TimeComplexity + "\n");
            richTextBox2.AppendText(selectionSort.SpaceComplexity);
            richTextBox2.AppendText("\n*All Big-O values represent worst-case scenarios unless otherwise noted");

            //Displaying the Advantages and Disadvantages of selectionSort to the Windows Form
            StringBuilder qs = new StringBuilder();
            qs.Append("SELECTION SORT:\nThe selection sort works by repeatedly going through the list of items, " +
                "each time selecting an item according to its ordering and placing it in the correct position in the sequence." +
                "\n\nAdvantages of Selection Sort:\n    -The main advantage of the selection sort is that it performs well on a small list." +
                "\n   -The primary disadvantage of the selection sort is its poor efficiency when dealing with a huge list of items." +
                "\n   -Because it is an in-place sorting algorithm, no additional temporary storage is required beyond what is needed to hold the original list." +
                "\n\nDisadvantages of Selection Sort:" +
                "\n   -The selection sort requires n-squared number of steps for sorting n elements." +
                "\n   -Its performance is easily influenced by the initial ordering of the items before the sorting process." +
                "\n   -Quick Sort is much more efficient than selection sort");
            richTextBox1.AppendText(qs.ToString());

            //Displaying extra notes from a rich text file in the bin
            using (StreamReader Reader = new StreamReader(@"C:\Users\Clayt\source\repos\CSC205\CSC205_StudyProject\CSC205_StudyProject\bin\SelectionSort.rtf"))
            {
                while (!Reader.EndOfStream)
                {
                    richTextBox5.AppendText(Reader.ReadLine());
                }
            }
        }

        private void btnInsertionSort_Click(object sender, EventArgs e) //INSERTIONSORT BUTTON
        {
            //Declaring a new instance of insertionSort and displaying properties to the Windows Form
            InsertionSort insertionSort = new InsertionSort();
            richTextBox2.AppendText(insertionSort.TimeComplexity + "\n");
            richTextBox2.AppendText(insertionSort.SpaceComplexity);
            richTextBox2.AppendText("\n*All Big-O values represent worst-case scenarios unless otherwise noted");

            //Displaying the Advantages and Disadvantages of insertionSort to the Windows Form
            StringBuilder qs = new StringBuilder();
            qs.Append("INSERTION SORT:\nInsertion sort is a simple sorting algorithm that builds the final sorted array one item at a time. " +
                "Insertion sort keeps a prefix of the array sorted. At each step, this prefix is grown by inserting the next value into it at the correct place.  " +
                "Eventually, the prefix is the entire array, which is therefore sorted.\n\nAdvantages of Insertion Sort:" +
                "\n  -Efficient for small sets of data\n     -Simple to implement\n     -Passes through the array only once.\n      -They are adaptive; efficient for data sets that are " +
                "already sorted.\n\nDisadvantages of Insertion Sort:\n      -Less efficient on larger list and arrays\n     -Best case: the array is already sorted" +
                "\n     -Worst case: elements are completely backwards");
            richTextBox1.AppendText(qs.ToString());

            //Displaying extra notes from a rich text file in the bin
            using (StreamReader Reader = new StreamReader(@"C:\Users\Clayt\source\repos\CSC205\CSC205_StudyProject\CSC205_StudyProject\bin\InsertionSort.rtf"))
            {
                while (!Reader.EndOfStream)
                {
                    richTextBox5.AppendText(Reader.ReadLine());
                }
            }
        }

        private void btnShellSort_Click(object sender, EventArgs e) //SHELLSORT BUTTON
        {
            //Declaring a new instance of ShellSort and displaying properties to the Windows Form
            ShellSort shellSort = new ShellSort();
            richTextBox2.AppendText(shellSort.TimeComplexity + "\n");
            richTextBox2.AppendText(shellSort.SpaceComplexity);
            richTextBox2.AppendText("\n*All Big-O values represent worst-case scenarios unless otherwise noted");

            //Displaying the Advantages and Disadvantages of ShellSort to the Windows Form
            StringBuilder qs = new StringBuilder();
            qs.Append("SHELL SORT:\nShell sort algorithm is also known as Shell's method algorithm which is the variation of insertion sort algorithm. " +
                "Shell sort algorithm is an improved form of insertion sort algorithm as it compares elements separated by a gap of several position. " +
                "In Shell sort algorithm, the elements in an array are sorted in multiple passes and in each pass, data are taken with smaller and smaller " +
                "gap sizes. However, the finale of shell sort algorithm is a plain insertion sort algorithm. But the time we reach the last part, " +
                "the elements in an array are already sorted, thus Shell sort algorithm provides better performance." +
                "\n\nAdvantages of Shell Sort:\n    -Shell sort algorithm is only efficient for finite number of elements in an array." +
                "\n    -Shell sort algorithm is 5.32 x faster than bubble sort algorithm.\n\nDisadvantages of Shell Sort:" +
                "\n     -Shell sort algorithm is complex in structure and bit more difficult to understand.\n     -Shell sort algorithm is significantly " +
                "slower than the merge sort, quick sort and heap sort algorithms.");
            richTextBox1.AppendText(qs.ToString());

            //Displaying extra notes from a rich text file in the bin
            using (StreamReader Reader = new StreamReader(@"C:\Users\Clayt\source\repos\CSC205\CSC205_StudyProject\CSC205_StudyProject\bin\ShellSort.rtf"))
            {
                while (!Reader.EndOfStream)
                {
                    richTextBox5.AppendText(Reader.ReadLine());
                }
            }
        }

        private void btnHeapSort_Click(object sender, EventArgs e) //HEAPSORT BUTTON
        {
            //Declaring a new instance of HeapSort and displaying properties to the Windows Form
            HeapSort heapSort = new HeapSort();
            richTextBox2.AppendText(heapSort.TimeComplexity + "\n");
            richTextBox2.AppendText(heapSort.SpaceComplexity);
            richTextBox2.AppendText("\n*All Big-O values represent worst-case scenarios unless otherwise noted");

            //Displaying the Advantages and Disadvantages of HeapSort to the Windows Form
            StringBuilder qs = new StringBuilder();
            qs.Append("HEAP SORT:\nA Heap sort algorithm works by first organsizing the data to be sorted into a special " +
                "type of binary tree by setting the largest element of an array in the top of the binary tree, so the heap " +
                "sort algorithm is very capable of reversing its order at any time.\n\nAdvantages of Heap Sort:\n   " +
                "-The Heap sort algorithm is widely used because of its efficiency.\n   -The Heap sort algorithm can be implemented " +
                "as an in-place sorting algorithm\n   -Its memory usage is minimal" +
                "\n\nDisadvantages of Heap Sort:\n   -Heap sort requires more space for sorting\n    -Quick sort is much more efficient than Heap in many cases");
            richTextBox1.AppendText(qs.ToString());

            //Displaying extra notes from a rich text file in the bin
            using (StreamReader Reader = new StreamReader(@"C:\Users\Clayt\source\repos\CSC205\CSC205_StudyProject\CSC205_StudyProject\bin\HeapSort.rtf"))
            {
                while (!Reader.EndOfStream)
                {
                    richTextBox5.AppendText(Reader.ReadLine());
                }
            }
        }

        private void btnBreadthFirstSearch_Click(object sender, EventArgs e) //BREADTH FIRST SEARCH BUTTON
        {
            //Declaring a new instance of BreadthFirstSearch and displaying properties to the Windows Form
            BreadthFirstSearch bfsSort = new BreadthFirstSearch();
            richTextBox2.AppendText(bfsSort.TimeComplexity + "\n");
            richTextBox2.AppendText(bfsSort.SpaceComplexity + "\n");

            //Displaying the Advantages and Disadvantages of BreadthFirstSearch to the Windows Form
            StringBuilder qs = new StringBuilder();
            qs.Append("BREADTH FIRST SEARCH: \nThe Breadth First Search (BFS) is an algorithm for traversing or searching tree or graph data structures. " +
                "It explores all the nodes at the present depth before moving on to the nodes at the next depth level. It can be implemented using a queue." +
                "\n\n    -BFS starts traversal from the root node and visits nodes in a level by level manner (i.e., visiting the ones closest to the root first)." +
                "\n   -Usually implemented using a queue data structure.\n    -Generally requires more memory than DFS.\n   -Optimal for finding the shortest " +
                "distance.\n    -Used for finding the shortest path between two nodes, testing if a graph is bipartite, finding all connected components in a graph, etc.");
            richTextBox1.AppendText(qs.ToString());

            //Displaying extra notes from a rich text file in the bin
            using (StreamReader Reader = new StreamReader(@"C:\Users\Clayt\source\repos\CSC205\CSC205_StudyProject\CSC205_StudyProject\bin\BreadthFirstSearch.rtf"))
            {
                while (!Reader.EndOfStream)
                {
                    richTextBox5.AppendText(Reader.ReadLine());
                }
            }
        }

        private void btnDepthFirstSearch_Click(object sender, EventArgs e) //DEPTH FIRST SEARCH BUTTON
        {
            //Declaring a new instance of DepthFirstSearch and displaying properties to the Windows Form
            DepthFirstSearch dfsSort = new DepthFirstSearch();
            richTextBox2.AppendText(dfsSort.TimeComplexity + "\n");
            richTextBox2.AppendText(dfsSort.SpaceComplexity + "\n");

            //Displaying the Advantages and Disadvantages of DepthFirstSearch to the Windows Form
            StringBuilder qs = new StringBuilder();
            qs.Append("DEPTH FIRST SEARCH: \nThe Depth First Search (DFS) is an algorithm for traversing or searching tree or graph data " +
                "structures which uses the idea of backtracking. It explores all the nodes by going forward if possible or uses backtracking. " +
                "It can be implemented using a stack.\n\n      -DFS starts the traversal from the root node and visits nodes as far as " +
                "possible from the root node (i.e., depth wise).\n     -Usually implemented using a stack data structure.\n      " +
                "-Generally requires less memory than BFS.\n      -Not optimal for finding the shortest distance.\n     -Used for topological sorting, " +
                "solving problems that require graph backtracking, detecting cycles in a graph, finding paths between two nodes, etc.");
            richTextBox1.AppendText(qs.ToString());

            //Displaying extra notes from a rich text file in the bin
            using (StreamReader Reader = new StreamReader(@"C:\Users\Clayt\source\repos\CSC205\CSC205_StudyProject\CSC205_StudyProject\bin\DepthFirstSearch.rtf"))
            {
                while (!Reader.EndOfStream)
                {
                    richTextBox5.AppendText(Reader.ReadLine());
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)  //Question Mark - References
        {
            richTextBox1.AppendText("REFERENCES\n\n");
            richTextBox1.AppendText("Cracking the Coding Interview by Gayle Laakmann McDowell\n");
            richTextBox1.AppendText("https://www.bigocheatsheet.com/ \n");
            richTextBox1.AppendText("https://www.tutorialsteacher.com/csharp/csharp-tutorials \n");
            richTextBox1.AppendText("https://www.geeksforgeeks.org/ \n");
            richTextBox1.AppendText("https://study.com/academy/lesson/sorting-algorithm-comparison-strengths-weaknesses.html \n");
            richTextBox1.AppendText("https://www.educative.io/edpresso \n");
            richTextBox1.AppendText("https://visualgo.net/en \n");

        }
    }
}
