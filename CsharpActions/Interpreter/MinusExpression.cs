namespace CSharpActions.Interpreter;

public class MinusExpression(IPostfixExpression left, IPostfixExpression right) : IPostfixExpression
{
    private readonly IPostfixExpression _left = left;
    private readonly IPostfixExpression _right = right;

    public int Interpret(Dictionary<char, int> context)
    {
        return _left.Interpret(context) - _right.Interpret(context);
    }
}