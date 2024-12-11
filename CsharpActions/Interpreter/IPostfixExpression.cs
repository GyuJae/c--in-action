namespace CSharpActions.Interpreter;

public interface IPostfixExpression
{
    int Interpret(Dictionary<char, int> context);
}