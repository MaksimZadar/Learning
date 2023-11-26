Console.WriteLine("Binary Tree");
var rootNode = new TreeNode<int>(0);

public class TreeNode<T>
{
    public T Value { get; set; }
    public TreeNode<T>? Left { get; set; } = null;
    public TreeNode<T>? Right { get; set; } = null;

    public TreeNode(T data)
    {
        Value = data;
    }

    public void AddLeft(TreeNode<T> left) => Left = left;
    public void AddRight(TreeNode<T> right) => Right = right;
}

public class BinaryTree<T>
{
    public TreeNode<T> RootNode { get; set; }
    public BinaryTree(TreeNode<T> rootNode)
    {
        RootNode = rootNode;
    }


}
