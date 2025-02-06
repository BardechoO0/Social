using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObjectPicker : MonoBehaviour
{
    public Transform holdPosition;
    public KeyCode interactKey = KeyCode.E;
    private GameObject heldObject = null;

    public List<PlaceableSpot> placeOrder; // Lista de puntos en orden
    private int currentStep = 0; // Paso actual del proceso

    void Update()
    {
        if (Input.GetKeyDown(interactKey))
        {
            if (heldObject == null)
            {
                TryPickUpObject();
            }
            else
            {
                TryPlaceObject();
            }
        }
    }

    void TryPickUpObject()
    {
        Collider2D obj = Physics2D.OverlapCircle(transform.position, 0.5f, LayerMask.GetMask("Pickupable"));
        if (obj != null)
        {
            heldObject = obj.gameObject;
            heldObject.GetComponent<Collider2D>().enabled = true;
            heldObject.GetComponent<Collider2D>().isTrigger = true;
            heldObject.transform.position = holdPosition.position;
            heldObject.transform.parent = transform;

        }
    }

    void TryPlaceObject()
    {
        if (currentStep < placeOrder.Count) // Verifica si hay más pasos por completar
        {
            PlaceableSpot spot = placeOrder[currentStep];

            if (spot.CanPlaceObject(heldObject))
            {
                heldObject.transform.position = spot.transform.position;
                heldObject.transform.parent = null;
                heldObject.GetComponent<Collider2D>().enabled = true;
                heldObject.GetComponent<Collider2D>().isTrigger = false;

                // Iniciar cambio de sprite
                StartCoroutine(ChangeSpriteAfterDelay(heldObject, spot));

                // Avanzar al siguiente paso
                currentStep++;

                // Soltar el objeto
                heldObject = null;
            }
            else
            {
                Debug.Log("No puedes colocar este objeto aquí o no es el orden correcto.");
            }
        }
        else
        {
            Debug.Log("Todos los pasos han sido completados.");
        }
    }

    IEnumerator ChangeSpriteAfterDelay(GameObject obj, PlaceableSpot spot)
    {
        yield return new WaitForSeconds(spot.timeToChange);
        obj.GetComponent<SpriteRenderer>().sprite = spot.newSprite;

        // Registrar el objeto como cambiado en este lugar
        spot.RegisterPlacedObject(obj);
    }
}
