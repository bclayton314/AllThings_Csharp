using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Tree1 : DataStructure
    {
        public Tree1(string accessTime, string searchTime, string insertTime, string deleteTime, string spaceComplexity)
        {
            AccessTime = accessTime; 
            SearchTime = searchTime;
            InsertTime = insertTime;
            DeleteTime = deleteTime;
            SpaceComplexity = spaceComplexity;
        }
    }
}
