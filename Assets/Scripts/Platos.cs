using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR;

public class Platos : MonoBehaviour
{
    public Sprite[] newSprite =new Sprite[2];

    public int N_paso = 0;

    public bool ola = false;

    public int plc;

    public int pll;

    public float tiempo;

    public int IMG;

    public string Selecinecapa;

    [SerializeField] GameObject x;

    [SerializeField] Cojer_objeto Co;

    public bool Segundo_paso;
    public void Plato_Sl() {

        

        if (x.layer == pll)
        {

            StartCoroutine(mesa());

        }else if(ola == false)
        {

            StopAllCoroutines();

        }
        IEnumerator mesa()
        {
            yield return new WaitForSeconds(tiempo);


            x.GetComponent<SpriteRenderer>().sprite = newSprite[1];

            x.layer = plc;

            if (Segundo_paso == true)
            {
                x.gameObject.tag = Selecinecapa;

            }

        }






    }

  

    public void Cuneta()
    {

        N_paso++;


        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Plato")
        {
            ola = true;

            StartCoroutine(Comprobar());

            x = collision.gameObject;

            
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Plato")
        {
            ola = false;
            StartCoroutine(Comprobar());

            
        }


    }
    IEnumerator Comprobar()
    {

        yield return new WaitForSeconds(1f);

        if (ola == true)
        {


            N_paso++;
            Plato_Sl();



        }
        else if (ola == false) {


            StopAllCoroutines();

        }
        
        



    }


}
