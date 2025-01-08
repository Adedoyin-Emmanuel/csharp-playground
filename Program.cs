class CustomArray {

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
        if(_size > _capacity)
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

        if(index < 0 || index > _size - 1)
        {
            throw new Exception("Invalid index!");
        }

        
        
    }

    public int IndexOf(int item)
    {
        return -1;
    }
    
}


class Program {
    public static void Main(string [] args)
    {
       
        List<int> numbers = [1, 2, 3];

        numbers.Add(4);

        

        foreach(var number in numbers)
        {
            System.Console.WriteLine(number);
        }

        System.Console.WriteLine($"The length of the List is {numbers.Count}");

    }
}