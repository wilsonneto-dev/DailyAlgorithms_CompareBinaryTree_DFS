Node exampleTree1 = new(1, new(2), new(3));
Node exampleTree2 = new(1, new(2), new(3));
Node exampleTree3 = new(1, new(2, new(4), new(5)), new(3));
Node exampleTree4 = new(1, new(2, new(4), new(5)), new(3));

Console.WriteLine($"Test 1 - equals - {(Solution.IsEquals(exampleTree1, exampleTree2) ? "Ok" : "X")}");
Console.WriteLine($"Test 2- not equals - {(!Solution.IsEquals(exampleTree2, exampleTree3) ? "Ok" : "X")}");
Console.WriteLine($"Test 3 - equals - {(Solution.IsEquals(exampleTree3, exampleTree4) ? "Ok" : "X")}");
Console.WriteLine($"Test 4 - not equals - {(!Solution.IsEquals(exampleTree4, exampleTree1) ? "Ok" : "X")}");

class Node
{
    public Node(int value, Node? left = null, Node? right = null)
    {
        Value = value;
        Left = left;
        Right = right;
    }

    public int Value { get; set; }
    public Node? Left { get; set; }
    public Node? Right { get; set; }
}

static class Solution
{
    internal static bool IsEquals(Node? rootNode1, Node? rootNode2)
    {
        // when stop? The null nodes
        if (rootNode1 is null || rootNode2 is null)
            return (rootNode1 == rootNode2);

        // process: check equality, if is equals call it again
        if (rootNode1.Value != rootNode2.Value)
            return false;

        return (IsEquals(rootNode1.Left, rootNode2!.Left) && IsEquals(rootNode1.Right, rootNode1!.Right));
    }
}

