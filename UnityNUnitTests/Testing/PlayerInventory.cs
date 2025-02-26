using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public List<string> inventory = new List<string>();
    public int maxCapacity = 10;

    public void AddItem(string item)
    {
        inventory.Add(item);
    }
}
