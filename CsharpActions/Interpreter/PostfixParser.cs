namespace CSharpActions.Interpreter;

public class PostfixParser
{
    public static IPostfixExpression Parse(string expression)
    {
        var stack = new Stack<IPostfixExpression>();

        foreach (var c in expression) stack.Push(GetExpression(c, stack));

        return stack.Pop();
    }

    private static IPostfixExpression GetExpression(char c, Stack<IPostfixExpression> stack)
    {
        switch (c)
        {
            case '+':
                return new PlusExpression(stack.Pop(), stack.Pop());
            case '-':
                var right = stack.Pop();
                var left = stack.Pop();
                return new MinusExpression(left, right);
            case '*':
                return new MultiplyExpression(stack.Pop(), stack.Pop());
            default:
                return new VariableExpression(c);
        }
    }
}