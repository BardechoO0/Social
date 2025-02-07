using UnityEngine;

public class Cojer_objeto : MonoBehaviour
{
    public Transform mano;
    public GameObject x;

    public bool activo;

    public bool inHand=false;

    public KeyCode Tecla = KeyCode.E;

    public Vector2 h;
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

        if (collision.gameObject.tag == "Plato_2" && inHand == false)
        {
            activo = true;

            x = collision.gameObject;
        }

        if (collision.gameObject.tag == "Plato_3" && inHand == false)
        {
            activo = true;

            x = collision.gameObject;
        }

        if (collision.gameObject.tag == "Plato_1" && inHand == false)
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

        if (collision.gameObject.tag == "Plato_1" && inHand == false)
        {
            activo = false;

            x = null;
        }

        if (collision.gameObject.tag == "Plato_2" && inHand == false)
        {
            activo = false;

            x = null;
        }

        if (collision.gameObject.tag == "Plato_3" && inHand == false)
        {
            activo = false;

            x = null;
        }


    }
    void Update()
    {
        h = transform.position;
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

            if (inHand == true) 
            {
                x.transform.position = mano.position;
            }
        
        }
    }
}
