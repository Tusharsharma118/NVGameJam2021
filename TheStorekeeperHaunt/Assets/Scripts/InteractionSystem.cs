using UnityEngine;

public class InteractionSystem : MonoBehaviour
{
    private int itemsHeldCount = 0;
    private GameObject itemHeld;

    public int getItemsHeldCount()
    {
        return itemsHeldCount;
    }

    public GameObject getItem()
    {
        return itemHeld;
    }

    public void addItem(GameObject item)
    {
        itemHeld = item;
        itemsHeldCount += 1;
    }

    public void dropItem()
    {
        itemsHeldCount -= 1;
        itemHeld = null;
    }
}
