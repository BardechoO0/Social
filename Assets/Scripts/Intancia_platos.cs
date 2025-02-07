using UnityEngine;

public class Intancia_platos : MonoBehaviour
{
    public int x = 0;

    public bool Max_platos = false;

    [SerializeField] GameObject[] local_platos = new GameObject[4];

    [SerializeField] GameObject comida;

    [SerializeField] GameObject Instanciador;

    public Transform mano;

    



    public void Conteo_platos()
    {
        if (Max_platos == false && local_platos[0] == null)
        {
            x++;
            local_platos[0] = Instantiate(comida, Instanciador.transform.position, Quaternion.Euler(0, 0, 0));

        }
        else if (Max_platos == false && local_platos[1] == null)
        {

            x++;
            local_platos[1] = Instantiate(comida, Instanciador.transform.position, Quaternion.Euler(0, 0, 0));



        }
        else if (Max_platos == false && local_platos[2] == null)
        {

            x++;
            local_platos[2] = Instantiate(comida, Instanciador.transform.position, Quaternion.Euler(0, 0, 0));

        }
        else if (Max_platos == false && local_platos[3] == null)
        {

            x++;
            local_platos[3] = Instantiate(comida, Instanciador.transform.position, Quaternion.Euler(0, 0, 0));


        }
        else
        {

            Max_platos = true;


        }




    }

    public void comprobar()
    {
        if (x >= 4 && Max_platos == true)
        {
            x--;

            Max_platos = false;
        }
        else
        {
            x--;
        }


    }
}
