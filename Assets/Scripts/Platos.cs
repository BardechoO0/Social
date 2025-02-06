using UnityEngine;

public class Platos : MonoBehaviour
{
    public int N_paso;


    public void Cuneta()
    {

        N_paso++;


        if (N_paso >= 4)
        {

            N_paso = 3;

        }
    }
}
