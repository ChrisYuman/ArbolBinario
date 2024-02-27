using System;

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int value)
    {
        val = value;
        left = null;
        right = null;
    }
}

public class BinaryTree
{
    private TreeNode root;

    public BinaryTree()
    {
        root = null;
    }

    public void Insert(int value)
    {
        root = InsertRec(root, value);
    }

    private TreeNode InsertRec(TreeNode root, int value)
    {
        if (root == null)
        {
            root = new TreeNode(value);
            return root;
        }

        if (value < root.val)
        {
            root.left = InsertRec(root.left, value);
        }
        else if (value > root.val)
        {
            root.right = InsertRec(root.right, value);
        }

        return root;
    }

    public void PreorderTraversal()
    {
        PreorderTraversal(root);
    }

    private void PreorderTraversal(TreeNode root)
    {
        if (root != null)
        {
            Console.Write(root.val + " ");
            PreorderTraversal(root.left);
            PreorderTraversal(root.right);
        }
    }

    public void InorderTraversal()
    {
        InorderTraversal(root);
    }

    private void InorderTraversal(TreeNode root)
    {
        if (root != null)
        {
            InorderTraversal(root.left);
            Console.Write(root.val + " ");
            InorderTraversal(root.right);
        }
    }

    public void PostorderTraversal()
    {
        PostorderTraversal(root);
    }

    private void PostorderTraversal(TreeNode root)
    {
        if (root != null)
        {
            PostorderTraversal(root.left);
            PostorderTraversal(root.right);
            Console.Write(root.val + " ");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        BinaryTree tree = new BinaryTree();
        int[] elements = { 10, 5, 15, 3, 7, 12, 20 };

        foreach (int element in elements)
        {
            tree.Insert(element);
        }

        Console.WriteLine("Recorrido Preorder:");
        tree.PreorderTraversal();
        Console.WriteLine("\nRecorrido Inorder:");
        tree.InorderTraversal();
        Console.WriteLine("\nRecorrido Postorder:");
        tree.PostorderTraversal();
    }
}
