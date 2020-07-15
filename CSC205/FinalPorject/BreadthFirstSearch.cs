using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class BreadthFirstSearch : Algorithm
    {
        public BreadthFirstSearch()
        {
            this.TimeComplexity = "O(n) - where n = # of nodes";
            this.SpaceComplexity = "O(w) - where w = maximum width of the tree";
        }
    }
}
