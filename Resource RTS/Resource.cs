using UnityEngine.UI;


class Resource
{
    int _count;
    Image _icon;
    string _hint;
    int _ID;

    private static int IDCounter = 0;

    public Resource(int count, Image icon, string hint)
    {
        _count = count;
        _icon = icon;
        _hint = hint;
        _ID = ++IDCounter;
    }

    ~Resource()
    {
        --IDCounter;
    }

    public int Count
    {
        get
        {
            return _count;
        }

        set
        {
            _count = value;
        }
    }

    public string Hint
    {
        get
        {
            return _hint;
        }
    }

    public int ID
    {
        get
        {
            return _ID;
        }
    }
}
