namespace Graphs.Classes
{
  public class Vertex<T>
  {
    public T Value { get; set; }
    public Vertex(T value)
    {
      Value = value;
    }
  }
}
