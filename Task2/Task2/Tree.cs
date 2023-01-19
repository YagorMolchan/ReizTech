using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Tree
    {
        private int _depth;
        private int _maxDepth;
        private Branch _first;
        private Branch _current;

        public Tree(int _maxDepth)
        {
            this._maxDepth = _maxDepth;
        }

        public void Initialize(Branch branch)
        {
            _depth = 1;
            branch.Level = 1;
            First = branch;
            Current = branch;
        }

        public void AddBranch(Branch branch)
        {
            var b = Current;
            b.AddBranch(branch);
            if (branch.Level>Depth)
            {
                Depth++;
            }
        }

        public bool Contains(int number)
        {
            return Current.Branches.FirstOrDefault(b => b.Number == number) != null;
        }

        public void MoveUp()
        {
            var branch = Current.Parent;
            Current = branch;
        }

        public void MoveDown(int number)
        {
            var branch = Current;           
            Current = branch.Branches.FirstOrDefault(b => b.Number == number);
        }

        public string AllBranchesToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(First.Number);
            sb.AppendLine();

            foreach(var br in First.Branches)
            {
                sb.Append(br.Number + "         ");
            }
            sb.AppendLine();
            foreach(var br in First.Branches)
            {
                foreach(var child in br.Branches)
                {
                    sb.Append(child.Number + " ");
                }
                sb.Append("         ");
            }

            return sb.ToString();
        }

        
        public int Depth
        {
            get
            {
                return _depth;
            }
            set
            {
                if (_depth <= _maxDepth)
                {
                    _depth = value;
                }
            }
        }

        public int MaxDepth
        {
            get
            {
                return _maxDepth;
            }
            set
            {
                _maxDepth = value;
            }
        }

        public Branch First
        {
            get
            {
                return this._first;
            }
            set
            {
                this._first = value;
            }
        }

        public Branch Current
        {
            get
            {
                return this._current;
            }
            set
            {
                this._current = value;
            }
        }
    }
}
