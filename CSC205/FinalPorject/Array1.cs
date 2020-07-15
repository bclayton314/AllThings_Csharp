using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Array1 : DataStructure
    {
        

        public Array1()
        {
            this.AccessTime = "Access Time: O(1)";
            this.SearchTime = "Search Time: O(n)";
            this.InsertTime = "Insert Time: O(n)";
            this.DeleteTime = "Delete Time: O(n)";
            this.SpaceComplexity = "Space: O(n)";
            this.Advantages();
            this.Disadvantages();
        }

        //CREATION OF NON-DEFAULT CONSTRUCTOR
        public Array1(string accessTime, string searchTime, string insertTime, string deleteTime, string spaceComplexity)
        {
            AccessTime = accessTime;
            SearchTime = searchTime;
            InsertTime = insertTime;
            DeleteTime = deleteTime;
            SpaceComplexity = spaceComplexity;
        }
        
        
        
        public string Advantages()
        {
            return "The advantages of using an array in C# are as follows: " +
                "It is used to represent similar types of multiple data items using a single name. " +
                "We can use arrays to implement other data structures such as linked lists, trees, graphs, " +
                "stacks, queues, etc." +
                "The two-dimensional arrays in C# are used to represent matrices." +
                "The Arrays in C# are strongly typed. That means they are used to store similar " +
                "types of multiple data items using a single name. As the arrays are strongly typed so we " +
                "are getting two advantages. First, the performance of the application will be much better " +
                "because boxing and unboxing will not happen. Secondly, runtime errors will be prevented because " +
                "of a type mismatch. In this case, at compile time it will give you the error if there is a type mismatch.";
            
        }
        public string Disadvantages()
        { 
            return "The disadvantages of using an array in C# are as follows: " + 
                "The array size is fixed. So, we should know in advance how many elements are going to be " +
                "stored in the array. Once the array is created, then we can never increase the size of an array. " +
                "If you want then we can do it manually by creating a new array and copying the old array elements " +
                "into the new array. As the array size is fixed, if we allocate more memory than the requirement " +
                "then the extra memory will be wasted.On the other hand, if we allocate less memory than the requirement, " +
                "then it will create the problem. As the elements of an array are stored in contiguous memory locations." +
                "So insertions and deletions of array elements are very difficult and also time - consuming.So the time " +
                "complexity increase in insertion and deletion operation. We can never insert an element into the middle " +
                "of an array. It is also not possible to delete or remove elements from the middle of an array.";
        }
    }
}
