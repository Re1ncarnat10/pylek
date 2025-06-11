namespace pylek;

public class IconFactory
{
    private readonly Dictionary<string, Icon> _icons = new();

    public Icon GetIcon(string name, int size)
    {
        if (!_icons.ContainsKey(name))
        {
            _icons[name] = new Icon(name, size);
        }
        return _icons[name];
    }

    public int IconCount => _icons.Count;

    public void DisplayAllIcons()
    {
        foreach (var icon in _icons.Values)
        {
            icon.Display();
        }
    }
}