using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Tree
    {
        private Branch _root;
        private Branch _current;

        public Tree()
        {

        }

        public void Initialize(Branch branch)
        {
            branch.Level = 1;
            Root = branch;
            Current = branch;
        }

        public void AddBranch(Branch branch)
        {
            var b = Current;
            b.AddBranch(branch);
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
            sb.Append(Root.Number);
            sb.AppendLine();

            if (Root.Branches != null)
            {
                foreach (var br in Root.Branches)
                {
                    sb.Append(br.Number + "         ");
                }

                sb.AppendLine();

                foreach (var br in Root.Branches)
                {

                    foreach (var child in br.Branches)
                    {
                        sb.Append(child.Number + " ");
                    }

                    sb.Append("         ");

                }

            }

            return sb.ToString();
        }

        public bool Contains(int number)
        {
            return Current.Branches.FirstOrDefault(b => b.Number == number) != null;
        }

        public bool HasChildren(List<Branch> branches)
        {
            return branches.Any(b => b.Branches.Count>0);
        }

        public List<Branch> GetChildren(List<Branch> branches)
        {
            return branches.SelectMany(b => b.Branches).ToList();
        }

        public Branch Root
        {
            get
            {
                return this._root;
            }
            set
            {
                this._root = value;
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
