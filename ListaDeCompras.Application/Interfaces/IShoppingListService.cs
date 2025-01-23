using ListaDeCompras.Domain.Entities;

namespace ListaDeCompras.Application.Interfaces;

public interface IShoppingListService
{
    bool AddItem(string name);
    bool RemoveItem(string name);
    void MarkAsPurchased(string name);
    List<ItemsEntities> GetItems();
}