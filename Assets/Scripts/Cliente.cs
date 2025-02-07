using System.Collections;
using TMPro;
using UnityEditor;
using UnityEngine;

public class Cliente : MonoBehaviour
{
    [SerializeField] Spawn_Clientes sp;

    [SerializeField] GameObject[] Texst = new GameObject[3] ;

    [SerializeField] Transform sillas;

    [SerializeField] Animator[] ani= new Animator[3];

    [SerializeField] TextMeshProUGUI tex;
    int puntos;

    GameObject x;
    GameObject y;
    int N_plato;

    public int N_p;

    public bool ver = false;

    [SerializeField] Rigidbody2D rb;
    

    [SerializeField] Intancia_platos Oj;

    [SerializeField] GameObject[] clentes = new GameObject[3];

    public int p;

    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        N_plato = Random.Range(1, 4);
        p = Random.Range(0, 4);

        y = Instantiate(clentes[p],gameObject.transform.position, Quaternion.Euler(0,0,0));

        y.transform.SetParent(gameObject.transform);

        ani[1].SetBool("Andar", true);

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

        x.transform.SetParent(gameObject.transform);
        rb.AddForce(new Vector2(-20,0));
    }

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == gameObject.tag) {


            Ac();
            Destroy(collision.gameObject);


        }

        if (collision.gameObject.tag == "Silla")
        {
            rb.linearVelocity = Vector2.zero;

            transform.position = collision.gameObject.transform.position;

            ver = true;


        }
    }

    IEnumerator tiempo()
    {
        yield return new WaitForSeconds(30f);

    }

    public void perder()
    {

    }
    public void Ac()
    {

        Oj.comprobar();
        Destroy(x);

        puntos += 10;

        tex.text = puntos.ToString();

        e();
        sp.h();
        s();
        

    }

    public void e()
    {
        transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, -(transform.localScale.z));
        y.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, -(transform.localScale.z));

        
        rb.AddForce(new Vector2(80, 0));
    }
    public void s()
    {

        gameObject.tag = "ella me dice ola";


    }
    void Update()
    {
      
    }
}
