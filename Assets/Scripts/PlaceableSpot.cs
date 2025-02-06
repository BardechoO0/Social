using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class PlaceableSpot : MonoBehaviour
{
    public Sprite newSprite;
    public float timeToChange = 2f;
    private List<GameObject> placedObjects = new List<GameObject>();

    public int N = 0;

    public GameObject x;


    public bool CanPlaceObject(GameObject obj)
    {

        return !placedObjects.Contains(obj);

        
    }

    public void RegisterPlacedObject(GameObject obj)
    {
        placedObjects.Add(obj); // Guarda qué objetos ya han sido colocados aquí
    }

    


    
}
