using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    [SerializeField] GameObject Mas;
    [SerializeField] GameObject[] Tuto;

    public int TutoCount;

    bool PrimeraVez;
    void Start()
    {
        TutoCount = 0;
        Time.timeScale = 0f;
        Mas.SetActive(true);
        Tuto[TutoCount].SetActive(true);
        Tuto[1].SetActive(false);
        Tuto[2].SetActive(false);
        Tuto[3].SetActive(false);
        Tuto[4].SetActive(false);
        Tuto[5].SetActive(false);
        Tuto[6].SetActive(false);
        Tuto[7].SetActive(false);
        Tuto[8].SetActive(false);
        Tuto[9].SetActive(false);
        Tuto[10].SetActive(false);
        Tuto[11].SetActive(false);
        Tuto[12].SetActive(false);
        
        PrimeraVez = true;
        
    }

    public void Tu()
    {
        TutoCount = 0;
        Mas.SetActive(true);
        Tuto[TutoCount].SetActive(true);
        Tuto[1].SetActive(false);
        Tuto[2].SetActive(false);
        Tuto[3].SetActive(false);
        Tuto[4].SetActive(false);
        Tuto[5].SetActive(false);
        Tuto[6].SetActive(false);
        Tuto[7].SetActive(false);
        Tuto[8].SetActive(false);
        Tuto[9].SetActive(false);
        Tuto[10].SetActive(false);
        Tuto[11].SetActive(false);
        Tuto[12].SetActive(false);


    }
    void Update()
    {
        if (Input.anyKeyDown){
            
            if (Tuto.Length > TutoCount +1)
            {
                TutoCount++;
                Tuto[TutoCount].SetActive(true);

            }
            else if (TutoCount == 12){

                TutoCount++;
                Mas.SetActive(false);
                if (PrimeraVez)
                {
                    Time.timeScale = 1f;
                }
            }
        }
    }
}
