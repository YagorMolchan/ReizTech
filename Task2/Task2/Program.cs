using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 1;

            Console.WriteLine("Input the maximum depth:");
            int maxDepth = int.Parse(Console.ReadLine());

            Tree tree = new Tree(maxDepth);
            Branch branch = new Branch(number++);
            tree.Initialize(branch);

            while (true)
            {
                Console.WriteLine("0 - Exit");
                Console.WriteLine("U - Move up");
                Console.WriteLine("D - Move down");
                Console.WriteLine("C - Current position");
                Console.WriteLine("V - All branches");
                Console.WriteLine("M - Maximum depth");
                Console.WriteLine("P - Tree depth");
                Console.WriteLine("A - Add new branch");

                string code = Console.ReadLine();

                //DONE
                if (code == "0")
                {
                    break;
                }
                //DONE
                if (code == "A")
                {
                    if(tree.Current.Level == tree.MaxDepth)
                    {
                        Console.WriteLine("The current branch has the level value equal to maximum depth");
                    }
                    else
                    {
                        Branch b = new Branch(number++);
                        tree.AddBranch(b);
                        Console.WriteLine("The branch of number {0} is successfully added to level {1}", b.Number, b.Level);
                    }                    
                }
                //DONE
                if (code == "C")
                {
                    Branch b = tree.Current;
                    Console.WriteLine("Number: {0}. Level: {1}",b.Number,b.Level);
                }
                //DONE
                if (code == "V")
                {
                    string s = tree.AllBranchesToString();
                    Console.WriteLine(s);
                }
                //DONE
                if (code == "D")
                {
                    if (tree.Current.Branches.Count == 0)
                    {
                        Console.WriteLine("The branch of number {0} doesn't have the children", tree.Current.Number);
                    }
                    else
                    {
                        Console.WriteLine("Input the number of the tree");
                        int n = int.Parse(Console.ReadLine());
                        if (tree.Contains(n))
                        {
                            tree.MoveDown(n);
                            Console.WriteLine("The pointer to the tree is moved down to the branch of number {0} and level {1}",
                                tree.Current.Number, tree.Current.Level);
                        }
                        else
                        {
                            Console.WriteLine("The branch of number {0} doesn't have the child of number {1}", tree.Current.Number, n);
                        }
                    }
                }
                //DONE
                if (code == "U")
                {
                    if (tree.Current.Parent == null)
                    {
                        Console.WriteLine("The branch of number {0} is the root. Level {1}", tree.Current.Number, tree.Current.Level);
                    }
                    else
                    {
                        tree.MoveUp();
                        Console.WriteLine("The pointer to the tree is moved up to the branch of number {0} and level {1}",
                            tree.Current.Number, tree.Current.Level);
                    }                    
                }
                //DONE
                if (code == "P")
                {
                    var depth = tree.Depth;
                    Console.WriteLine("Depth of tree: " + depth);
                }
            }            
        }
    }
}
