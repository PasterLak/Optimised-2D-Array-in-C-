using System;

public struct Array2D<T>
{
    private T[] _data;

    private int _width;
    private int _height;

    public int Width => _width;
    public int Height => _height;
    public int Count => _width * _height;

    public Array2D(int width, int height)
    {
        if (width <= 0 || height <= 0)
            throw new ArgumentException("Width and height must be positive values.");

        _data = new T[width * height];

        _width = width;
        _height = height;
    }
    
    public T this[int width, int height]
    {
        get => _data[GetIndex(width, height)];
        set => _data[GetIndex(width, height)] = value;
    }

    private int GetIndex(int x, int y) => x * _height + y;

    public override string ToString()
    {
        var sb = new StringBuilder();

        for (int i = 0; i < _width; i++)
        {
            sb.Append("\n");

            for (int x = 0; x < _height; x++)
            {
                sb.Append($"{_data[GetIndex(i, x)]},");
            }
        }

        return sb.ToString();
    }
}
 
