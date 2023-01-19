using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Branch
    {
        private int _number;
        private int _level;
        private Branch _parent;

        private List<Branch> _branches;

        public Branch(int number)
        {
            _number = number;

            if(_branches==null)
            {
                _branches = new List<Branch>();
            }
        }

        public void AddBranch(Branch b)
        {
            b.Parent = this;
            b.Level = b.Parent.Level + 1;
            Branches.Add(b);
        }

        public int Number
        {
            get
            {
                return _number;
            }
            set
            {
                this._number = value;
            }
        }

        public int Level
        {
            get
            {
                return _level;
            }
            set
            {
                this._level = value;
            }
        }

        public Branch Parent
        {
            get
            {
                return this._parent;
            }
            set
            {
                this._parent = value;
            }
        }

        public List<Branch> Branches
        {
            get
            {
                return this._branches;
            }
            set
            {
                this._branches = value;
            }
        }

    }
}
