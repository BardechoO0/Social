using UnityEngine;

public class Cojer_objeto : MonoBehaviour
{
    public Transform mano;
    public GameObject x;

    public bool activo;

    public bool inHand=false;

    public KeyCode Tecla = KeyCode.E;
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Plato" && inHand==false)
        {
            activo = true;

            x = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Plato" && inHand == false)
        {
            activo = false;

            x = null;
        }


    }
    void Update()
    {
        if (activo) {

            if (Input.GetKeyDown(Tecla) && inHand == false)
            {

                x.transform.SetParent(mano);

                inHand = true;

            }
            else if (Input.GetKeyDown(Tecla) && inHand == true) 
            
            {
                x.transform.SetParent(null);

                inHand = false;

            }
        
        
        }
    }
}
