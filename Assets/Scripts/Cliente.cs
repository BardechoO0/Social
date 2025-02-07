using UnityEditor;
using UnityEngine;

public class Cliente : MonoBehaviour
{
    [SerializeField] Spawn_Clientes sp;

    [SerializeField] GameObject[] Texst = new GameObject[3] ;

    GameObject x;

    int N_plato;

    public int N_p;

    

    [SerializeField] Intancia_platos Oj;

    void Start()
    {
        N_plato = Random.Range(1, 4);


        if (N_plato == 1)
        {
            gameObject.tag = "Plato_1";
            
             x = Instantiate(Texst[0], gameObject.transform.position + new Vector3(1, 1, 0), Quaternion.Euler(0, 0, 0));

            N_p = 3; 


        } else if (N_plato == 2) 
        {
            gameObject.tag = "Plato_2";
            x = Instantiate(Texst[1], gameObject.transform.position + new Vector3(1, 1, 0), Quaternion.Euler(0, 0, 0));

            N_p = 2;
        }
        else if (N_plato == 3) 
        {
            gameObject.tag = "Plato_3";
            x = Instantiate(Texst[2], gameObject.transform.position + new Vector3(1, 1, 0), Quaternion.Euler(0, 0, 0));

            N_p = 3;
        }
        

    }

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == gameObject.tag) {


            Ac();
            Destroy(collision.gameObject);


        }
    }

    public void Ac()
    {
        Oj.comprobar();
        Destroy(x);
        sp.h();
        s();
        

    }

    public void s()
    {

        gameObject.tag = "ella me dice ola";


    }
    void Update()
    {
      
    }
}
