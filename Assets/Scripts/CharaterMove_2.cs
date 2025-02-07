using UnityEngine;
using UnityEngine.UIElements;

public class CharacterMove_2 : MonoBehaviour
{
    [SerializeField] Animator an;

    public float Speed_Character;

    public float correr;

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightShift)){

            correr = 2;
        }
        else
        {
            correr = 1;
        }
        float Des_X = Input.GetAxis("Horizontal_2");

        float Des_Y = Input.GetAxis("Vertical_2");

        an.SetFloat("Run_",Des_Y);

        an.SetFloat("Run_1",Des_X);

        transform.Translate(Vector2.up * Speed_Character * Time.deltaTime * Des_Y * correr);

        transform.Translate(Vector2.right * Speed_Character * Time.deltaTime * Des_X * correr);

    }
}
