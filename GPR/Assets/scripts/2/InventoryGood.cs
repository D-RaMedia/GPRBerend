using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryGood
{

    // ter voorbeeld is het nu een string voor KEY en string voor VALUE
    // waarschijnlijk wil je <string, Item> of iets dergelijks
    // of een <Enum, List<T>> om een collectie te kunnen opslaan
    private readonly Dictionary<string, string> _items = new Dictionary<string, string>();

    /// <summary>
    /// Deze method hanteert wel de open/closed principe
    /// aangezien hij uitgebreid kan worden van buitenaf
    /// en aanpassing van deze code is niet nodig
    /// Deze class is NIET specifiek voor een project
    /// </summary>
    /// <param name="type"></param>
    /// <returns></returns>
    public string GetItem(string type)
    {
        // happy path mogelijk maken
        if (!_items.ContainsKey(type))
        {
            return "";
        }

        // we kiezen de item aan de hand van type
        var currentItem = _items[type];

        // en we kunnen nog iets doen met het gekozen item
        // om dit te laten zien haal ik een letter van het woord af (wat natuurlijk nergens op slaat Berend...)
        currentItem = currentItem.Substring(1);

        return currentItem;
    }

    public void AddItem(string itemType, string value)
    {
        _items.Add(itemType, value);
    }
}
