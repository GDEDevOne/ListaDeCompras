namespace ListaDeCompras.Domain.Entities;

public class ItemsEntities
{
    public string Name { get; set; }
    public bool IsPurchased { get; set; }

    public ItemsEntities(string name)
    {
        Name = name;
        IsPurchased = false;
    }
}