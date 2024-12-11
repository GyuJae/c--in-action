namespace CSharpActions.Interpreter;

public class VariableExpression(char character) : IPostfixExpression
{
    private readonly char _character = character;

    public int Interpret(Dictionary<char, int> context)
    {
        return context[_character];
    }
}