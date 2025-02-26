using NUnit.Framework;
using Testing;
using UnityEngine;

public class ItemCollectionTest
{
    private GameObject player;
    private PlayerInventory playerInventory;
    private GameObject item;
    private CollectibleItem collectibleItem;

    [SetUp]
    public void Setup()
    {
        player = new GameObject();
        playerInventory = player.AddComponent<PlayerInventory>();
        
       player.AddComponent<BoxCollider2D>();
       
       item = new GameObject();
       collectibleItem = item.AddComponent<CollectibleItem>();
       collectibleItem.itemName = "Apple"; 

       
        item.AddComponent<BoxCollider2D>();

       
        item.transform.position = new Vector2(0, 0);
        player.transform.position = new Vector2(0, 0);
        
        Assert.NotNull(player.GetComponent<Collider2D>());
        Assert.NotNull(item.GetComponent<Collider2D>());
    }

    [Test]
    public void CollectItem_InventoryIncreases()
    {
        int initialItemCount = playerInventory.inventory.Count;
        
        item.GetComponent<CollectibleItem>().Collect();
        
        Assert.AreEqual(initialItemCount + 1, playerInventory.inventory.Count);
    }

    [Test]
    public void CollectItem_ItemIsInInventory()
    {
        item.GetComponent<CollectibleItem>().Collect();
        
        Assert.Contains("Apple", player.GetComponent<PlayerInventory>().inventory);
    }
    [Test]
    public void CollectItem_InventoryDoesNotExceedLimit()
    {
        int maxCapacity = 10; 
        playerInventory.maxCapacity = maxCapacity;
        
        for (int i = 0; i < maxCapacity; i++) 
        {
            collectibleItem.Collect();
        }

        
        Assert.AreEqual(maxCapacity, playerInventory.inventory.Count);
    }
    [Test]
    public void CollectItem_InventoryDoesNotAddWhenFull()
    {
        int maxCapacity = 10;
        playerInventory.maxCapacity = maxCapacity;
       
        for (int i = 0; i < maxCapacity; i++)
        {
            collectibleItem.Collect();
        }

        // kapasite dolduktan sonra ekleyebilyormyz onun testi.
        collectibleItem.Collect();
        
        Assert.AreEqual(maxCapacity, playerInventory.inventory.Count);
    }
}