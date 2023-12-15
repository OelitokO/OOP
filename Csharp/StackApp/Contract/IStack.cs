namespace StackApp.Contract;

public interface IStack
{
    void Push(Object item);
    Object Pop();
    Object Peek();
}