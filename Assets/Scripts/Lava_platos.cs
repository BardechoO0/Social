using UnityEngine;

public class Lava_platos : MonoBehaviour
{

    public KeyCode tecla = KeyCode.E;

    [SerializeField] Intancia_platos Oj;

    public int N;

    public bool dentro =false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Player_1"|| collision.gameObject.tag == "Player_2")
        {
            dentro= true;

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player_1" || collision.gameObject.tag == "Player_2")
        {
            dentro = false;

        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (dentro==true)
        {
            if (Input.GetKeyDown(tecla))
            {

                Oj.Conteo_platos();


            }

        }
    }
}
