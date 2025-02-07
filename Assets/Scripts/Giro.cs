using UnityEngine;
using UnityEngine.UIElements;

public class Giro : MonoBehaviour
{
    public KeyCode Arriba = KeyCode.UpArrow;
    public KeyCode Abajo = KeyCode.DownArrow;
    public KeyCode Derecha = KeyCode.RightArrow;
    public KeyCode Izquierda = KeyCode.LeftArrow;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(Arriba))
        {

            transform.rotation = Quaternion.Euler(0f, 0f, 90f);


        }else  if (Input.GetKeyDown(Abajo))
        {

            transform.rotation = Quaternion.Euler(0f, 0f, -90f);
        }
        else if (Input.GetKeyDown(Derecha))
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
        else if (Input.GetKeyDown(Izquierda))

        {
            transform.rotation = Quaternion.Euler(0f, 0f, 180f);

        }
    }
}
