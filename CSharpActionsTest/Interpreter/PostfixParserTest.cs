using CSharpActions.Interpreter;
using JetBrains.Annotations;

namespace CSharpActionsTest.Interpreter;

[TestSubject(typeof(PostfixParser))]
public class PostfixParserTest
{
    [Fact(DisplayName = "(Interpreter) 후위표기법으로 표시된 식을 계산할 수 있습니다.")]
    public void Postfix_Parser_TEST()
    {
        var expression = PostfixParser.Parse("xy+z-a+");
        var context = new Dictionary<char, int>
        {
            { 'x', 1 },
            { 'y', 2 },
            { 'z', 3 },
            { 'a', 4 }
        };

        var result = expression.Interpret(context);

        Assert.Equal(4, result);
    }
}