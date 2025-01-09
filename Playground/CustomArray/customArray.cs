namespace Csharp_Playground.Playground.CustomArray;

class CustomArray
{

    // insert
    // removeAt
    // indexOf

    private int[] _items;
    private int _size;
    private int _capacity;

    public CustomArray()
    {
        _items = new int[5];
        _size = 0;
        _capacity = 5;
    }


    public void Insert(int item)
    {
        if (_size > _capacity)
        {
            _capacity *= 2;

            int[] newArray = new int[_capacity];

            for (int i = 0; i < _size - 1; i++)
            {
                newArray[i] = _items[i];
            }

            _items = newArray;

        }

        _items[_size] = item;


        _size++;
    }

    public void RemoveAt(int index)
    {
        // Validate index.

        /*
            Index must not be < 0 or > size - 1
        */

        if (index < 0 || index > _size - 1)
        {
            throw new Exception("Invalid index!");
        }

        for (int i = index; i < _size - 1; i++)
        {
            _items[i] = _items[i + 1];
        }

        _items[_size - 1] = default;
        _size--;

    }

    public int IndexOf(int value)
    {

        for (int i = 0; i < _size; i++)
        {
            if (_items[i] == value)
            {
                return i;
            }
        }

        return -1;
    }

    public int Max()
    {

        int highestNumber = 0;

        for (int i = 0; i < _size; i++)
        {
            if(_items[i] > highestNumber)
            {
                highestNumber = _items[i];
            }
        }

        return highestNumber;
    }

    public CustomArray Intersect(int[] array)
    {
        var intersectArray = new CustomArray();

        for (int i = 0; i < _size; i++)
        {
            for (int j = 0; j < array.Count(); j++)
            {
                if(_items[i].Equals(array[j]))
                {
                    intersectArray.Insert(_items[i]);
                }
            }
        }

        return intersectArray;
    }

    public CustomArray Reverse()
    {
        var reversedArray = new CustomArray();

        for (int i = _size - 1; i >= 0; i--)
        {
            reversedArray.Insert(_items[i]);
        }

        return reversedArray;
    }


    public void InsertAt(int item, int index)
    {
        if(index < 0 || index > _size)
        {
            throw new ArgumentOutOfRangeException("Index must not be less than 0!");
        }

        if(_size >= _capacity)
        {
            _capacity *= 2;

            int[] newArray = new int[_capacity];

            for (int i = 0; i < _size; i++)
            {
                newArray[i] = _items[i];
            }

            _items = newArray;
        }


        for (int i = _size - 1; i >= index; i--)
        {
            _items[i + 1] = _items[i];
        }

        _items[index] = item;
        _size++;

    }


    public int Count() 
    {
        return _size;
    }


    /*An array shouldn't know anything about printing to the console 
      According to Software Design principles.
      But for the sake of this practise, I will add it
    */

    public void Print()
    {
       
        for (int i = 0; i < _size; i++)
        {
            System.Console.WriteLine(_items[i]);
        }
        
    }

    
}
