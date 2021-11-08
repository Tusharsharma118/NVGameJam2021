using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObject : MonoBehaviour
{

    public GameObject _player;
    public GameObject _pickupPlacement;
    public float _minDist;

    public bool isPicked;
    
    void OnMouseDown()
    {
        PickupControls();  
    }

    private void PickupControls()
    {
        float dist = Vector3.Distance(gameObject.transform.position, _player.gameObject.transform.position);
        //checking if pickup placement has anything as its child if not pick the current object
        Debug.Log("Distance b/w object and player:: " + dist + "  Min Distance needed for pickup :: "+_minDist);
        if (dist < _minDist)  // 2 includes parent (player) and itself the placement location object
        {
            if(_player.GetComponent<InteractionSystem>().getItemsHeldCount() > 0)
            {
                //drop other item and pick this one up
                GameObject other = _player.GetComponent<InteractionSystem>().getItem();
                //drop other and pick this
                other.GetComponent<PickupObject>().Pickup();
                Pickup();
            }
            else
            {
                // player not holding something
                Pickup();
            }
           
        }
        
    }

    public void Pickup()
    {
        if (!isPicked)
        {
            isPicked = true;
            _player.GetComponent<InteractionSystem>().addItem(gameObject);
            gameObject.transform.position = _pickupPlacement.transform.position;
            gameObject.transform.parent = _pickupPlacement.transform;

        }
        else
        {
            isPicked = false;
            _player.GetComponent<InteractionSystem>().dropItem();
            gameObject.transform.parent = null;
        }
    }

    
}
