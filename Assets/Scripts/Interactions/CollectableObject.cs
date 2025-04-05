using System.Collections.Generic;
using UnityEngine;

public class CollectableObject : InteractableObject
{
    public List<DoorObject> doorObjects = new List<DoorObject>();


    public override void Interact()
    {
        foreach (DoorObject obj in doorObjects)
        {
            obj.UnlockDoor();
            Debug.Log("O usa s-a deschis undeva!");
        }
        Destroy(gameObject);
    }
}
