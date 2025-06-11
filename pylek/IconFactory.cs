namespace pylek;

public class IconFactory
{
    private readonly Dictionary<string, Icon> _icons = new();

    public Icon GetIcon(string name, string filePath)
    {
        if (!_icons.ContainsKey(name))
        {
            _icons[name] = new Icon(name, filePath);
        }
        return _icons[name];
    }

    public int IconCount => _icons.Count;
}