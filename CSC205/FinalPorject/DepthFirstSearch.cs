using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class DepthFirstSearch : Algorithm
    {
        public DepthFirstSearch()
        {
            this.TimeComplexity = "O(n) - where n = # of nodes";
            this.SpaceComplexity = "O(h) - where h = maximum height of your tree";
        }
    }
}
