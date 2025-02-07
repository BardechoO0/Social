using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Clientes : MonoBehaviour
{
    [SerializeField] GameObject[] cliente = new GameObject[0];

    [SerializeField] GameObject silla;

    public int R;

    
    void Start()
    {
        
    }

    public void h() {

        StartCoroutine(spawn_cliente());

         IEnumerator spawn_cliente()
        {
            R = Random.Range(0, cliente.Length);

            yield return new WaitForSeconds(Random.Range(5f,10f));

            Instantiate(cliente[0], silla.transform.position, Quaternion.Euler(0, 0, 0));

            yield return new WaitForSeconds(2f);


        }
    }
    

 
    
    void Update()
    {
       

       

    }
}
