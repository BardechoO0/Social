using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Clientes : MonoBehaviour
{
    [SerializeField] GameObject cliente;

    [SerializeField] GameObject silla;

    public int R;

    
    void Start()
    {
        
    }

    public void h() {

        StartCoroutine(spawn_cliente());

         IEnumerator spawn_cliente()
        {
            

            yield return new WaitForSeconds(Random.Range(5f,10f));

            Instantiate(cliente, silla.transform.position, Quaternion.Euler(0, 0, 0));

            yield return new WaitForSeconds(2f);


        }
    }
    

 
    
    void Update()
    {
       

       

    }
}
