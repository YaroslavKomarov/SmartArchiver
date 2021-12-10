using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archiver.Domain.Models.Haffman
{
    public class Tree
    {
        public Tree LeftNode { get; private set; }
        public Tree RightNode { get; private set; }
        public byte Value { get; private set; }

        //public Tree(byte left, byte right)
        //{
        //    Value = left + right;
        //    Left = new Tree(left);
        //    Right = new Tree(right);
        //}

        public Tree(byte value)
        {
            Value = value;
        }
    }
}
