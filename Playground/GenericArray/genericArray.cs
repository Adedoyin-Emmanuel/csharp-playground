namespace Csharp_Playground.Playground.GenericArray;

class GenericArray<T> 
{

    private int _size;
    private int _capacity;
    private T[] _items;


    public GenericArray()
    {
        _size = 0;
        _capacity = 5;
        _items = new T[5];
    }


    /*
        Insert,
        RemoveAt, 
        IndexOf
        Count
        Print
    */

    public void Insert(T element)
    {
        if(_size > _capacity)
        {
            _capacity *= 2;

            T[] newArray = new T[_capacity];

            for (int i = 0; i < _size - 1; i++)
            {
                newArray[i] = _items[i];
            }

            _items = newArray;

        }

        _items[_size] = element;
        _size++;
    }


    public void RemoveAt(int index)
    {
       
       if(index < 0 || index > _size - 1)
       {
            throw new ArgumentOutOfRangeException("Invalid index!");
        }

        for (int i = index; i < _size - 1; i++)
        {
            _items[i] = _items[i + 1];
        }

        _items[_size - 1] = default!;
        _size--;
    }


    public int IndexOf(T value)
    {
        for (int i = 0; i < _size; i++)
        {
            if(_items[i]!.Equals(value))
            {
                return i;
            }
        }

        return -1;
    }


    public int Count()
    {
        return _size;
    }

    public void Print()
    {
        for (int i = 0; i < _size; i++)
        {
            System.Console.WriteLine(_items[i]);
        }
    }


}