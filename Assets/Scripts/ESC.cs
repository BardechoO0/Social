using UnityEngine;

public class ESC : MonoBehaviour
{
    [SerializeField] GameObject menu_esc;

    public bool X;
    void Start()
    {
        menu_esc.SetActive(false);
        X = false;
    }

    public void Volver()
    {
        Time.timeScale = 1;
        menu_esc.SetActive(false);
        X = false;
    }
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape) && !X) {

            Time.timeScale = 0;
            menu_esc.SetActive(true);
            X = true;
        }else if  (Input.GetKeyDown(KeyCode.Escape) && X) 
        {
            Time.timeScale = 1;
            menu_esc.SetActive(false);
            X = false;
        }
    }
}
