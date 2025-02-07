using System.Collections;
using TMPro;
using UnityEngine;

public class Tiempo : MonoBehaviour
{
    public int t = 300;

    [SerializeField] TextMeshProUGUI tiemp;
    void Start()
    {
        StartCoroutine(tiempo());

        tiemp.text = t.ToString();
    }
    
    IEnumerator tiempo()
    {
        yield return new WaitForSeconds(1f);

        t--;

        tiemp.text = t.ToString();

        StartCoroutine(tiempo());

        print(t);

    }
    void Update()
    {
        
    }
}
