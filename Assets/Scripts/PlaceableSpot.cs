using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class PlaceableSpot : MonoBehaviour
{
    public Sprite newSprite;
    public float timeToChange = 2f;
    public List<GameObject> placedObjects = new List<GameObject>();

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

    public bool CanPlaceObject_2(GameObject obj)
    {

        return placedObjects.Contains(obj);


    }

    private void Update()
    {
        if ((x.gameObject.tag=="Untagged"))
        {
            x.gameObject.tag = "Plato_1";
        }
    }



}
