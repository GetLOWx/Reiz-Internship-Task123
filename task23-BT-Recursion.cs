using System;

public class Node
{
    public int value;
    public Node left, right;

    public Node(int val)
    {
        value = val;
        left = right = null;
    }
}

public class BinaryTree
{
    Node root;

    int maxDepth(Node root)
    {
        if (root == null)

            return 0;

        // Recursively finding deth of subtrees
        int LeftDepth = maxDepth(root.left);
        int RightDepth = maxDepth(root.right);

        // Get larger depth and +1
        if (LeftDepth > RightDepth)
            return (LeftDepth + 1);
        else
            return (RightDepth + 1);
    }

    public static void Main()
    {
        BinaryTree tree = new BinaryTree();
        tree.root = new Node(1);
        tree.root.left = new Node(2);
        tree.root.right = new Node(3);
        tree.root.left.left = new Node(4);
        tree.root.right.left = new Node(5);
        tree.root.right.right = new Node(6);
        tree.root.right.left.left = new Node(7);
        tree.root.right.right.left = new Node(8);
        tree.root.right.right.right = new Node(9);
        tree.root.right.right.left.left = new Node(10);
        Console.WriteLine("Depth is: " + tree.maxDepth(tree.root));
    }
}