// возвращает bool

using System.Linq.Expressions;

Predicate<int> predicate = i => i % 2 == 0;
bool Predicate(int i) => i % 2 == 0;
PredicateExeqution(Predicate);

// возвращает что угодно
Func<int> func = () => 42;
int Func1() => 42;
FuncExeqution(Func1);

// ничего не возвращает
Action<int> action = i => { }; 
void Action1(int i) { }
ActionExeqution(Action1);

// делегат, по сути общий случай, хотя это очень упрощённое определение
CustomDelegate customDelegate;
customDelegate = PrintHello;
customDelegate += PrintWorld; // пример объединения делегатов
customDelegate();

// expression tree
Expression<Func<int>> add;
add = () => 1 + 2;
ExpressionExeqution(add);

void PredicateExeqution(Predicate<int> predicate)
{
    var foo = 42;
    bool result = predicate(foo);
}

void FuncExeqution(Func<int> func)
{
    int result = func();
}

void ActionExeqution(Action<int> action)
{
    var foo = 42;
    action(foo);
}

void ExpressionExeqution(Expression<Func<int>> add)
{
    var func = add.Compile(); // Create Delegate
    var answer = func(); // Invoke Delegate
    Console.WriteLine(answer);
}

void PrintHello()
{
    Console.WriteLine("Hello ");
}

void PrintWorld()
{
    Console.WriteLine("world");
}

delegate void CustomDelegate();
