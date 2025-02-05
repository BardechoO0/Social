using UnityEngine;
using System.Collections.Generic;

public class PlaceableSpot : MonoBehaviour
{
    public Sprite newSprite;
    public float timeToChange = 2f;
    private List<GameObject> placedObjects = new List<GameObject>();

    public bool CanPlaceObject(GameObject obj)
    {
        return !placedObjects.Contains(obj); // Solo deja colocar si no ha sido dejado antes
    }

    public void RegisterPlacedObject(GameObject obj)
    {
        placedObjects.Add(obj); // Guarda qué objetos ya han sido colocados aquí
    }
}
