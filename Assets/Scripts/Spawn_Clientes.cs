using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Clientes : MonoBehaviour
{
    [SerializeField] GameObject[] cliente = new GameObject[0];

    [SerializeField] GameObject silla;

    public int R;

    public bool ocupado = false;
    void Start()
    {
        StartCoroutine(spawn_cliente());
    }

    IEnumerator spawn_cliente()
    {
        R = Random.Range(0,cliente.Length);

        Instantiate(cliente[0],silla.transform);

        yield return new WaitForSeconds(2f);

        ocupado = true;
    }

    IEnumerator receta()
    {
        print("Hola");

        yield return new WaitForSeconds(5f);

        StartCoroutine(spawn_cliente());


        
    }
    
    void Update()
    {
       

        if (Input.GetKeyUp(KeyCode.E) && ocupado) {

            ocupado = false;

            StartCoroutine(receta());
        
        
        
        }

    }
}
