using ListaDeCompras.Application.Interfaces;
using ListaDeCompras.Domain.Entities;

namespace ListaDeCompras.Application.Services;

public class ShoppingListService : IShoppingListService
{
    private readonly List<ItemsEntities> items = [];
    
    public bool AddItem(string name)
    {
        var item = items.Find(i => i.Name.ToLower().Equals(name.ToLower()));
        if (item == null)
        {
            items.Add(new ItemsEntities(name));
            return true;
        }
        else
        {
            return false;
        }
    }

    public List<ItemsEntities> GetItems()
    {
        return items;
    }

    public void MarkAsPurchased(string name)
    {
        var item = items.Find(i => i.Name.ToLower().Equals(name.ToLower()));
        if (item != null)
            item.IsPurchased = true;
    }

    public bool RemoveItem(string name)
    {
        var item = items.Find(i => i.Name.ToLower().Equals(name.ToLower()));
        if (item != null)
        {
            items.RemoveAll(i => i.Name.ToLower().Equals(name.ToLower()));
            return true;
        }
        else
        {
            return false;
        }
    }
}