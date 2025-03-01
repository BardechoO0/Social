using UnityEngine;
using UnityEngine.UIElements;

public class CharacterMove : MonoBehaviour
{
    [SerializeField] Animator an;

    public float Speed_Character;

    public float correr;

    void Start()
    {
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.LeftShift))
        {

            correr = 2;
        }
        else
        {
            correr = 1;
        }

        float Des_X1 = Input.GetAxis("Horizontal");

        float Des_Y1 = Input.GetAxis("Vertical");

        an.SetFloat("Run_", Des_Y1);

        an.SetFloat("Run_1", Des_X1);

        transform.Translate(Vector2.up * Speed_Character * Time.deltaTime * Des_Y1 * correr);

        transform.Translate(Vector2.right * Speed_Character * Time.deltaTime * Des_X1 * correr);

    }
}
