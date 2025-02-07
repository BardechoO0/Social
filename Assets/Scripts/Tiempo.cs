using System.Collections;
using Microsoft.Win32.SafeHandles;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tiempo : MonoBehaviour
{
    public int t = 10;

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

        if (t <= 0)
        {

            siguiente();
        }

    }

    void siguiente()
    {
        SceneManager.LoadScene(2);
    }
    void Update()
    {
        
    }
}
