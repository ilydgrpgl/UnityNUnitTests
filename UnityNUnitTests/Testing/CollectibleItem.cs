using UnityEngine;

namespace Testing
{
    public class CollectibleItem : MonoBehaviour
    {
        public string itemName;

        
       /* public void Collect()
        {
            
            PlayerInventory inventory = FindObjectOfType<PlayerInventory>(); // Oyuncuyu bulur ve envanterine ekler
            inventory.AddItem(itemName);
            
            Destroy(gameObject);
        }*/
       
       
       //CollectItem_InventoryDoesNotAddWhenFull() da karşılaştığım hata 
       public void Collect()
       {
           
           PlayerInventory inventory = FindObjectOfType<PlayerInventory>();

           
           if (inventory != null && inventory.inventory.Count < inventory.maxCapacity)
           {
               inventory.AddItem(itemName);
               Destroy(gameObject); 
           }
       }
    }
}