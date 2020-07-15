using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Stack1 : DataStructure
    {
        public Stack1()
        {
            this.AccessTime = "Access Time: O(n)";
            this.SearchTime = "Search Time: O(n)";
            this.InsertTime = "Insert Time: O(1)";
            this.DeleteTime = "Delete Time: O(1)";
            this.SpaceComplexity = "Space: O(n)";
        }
    }
}
