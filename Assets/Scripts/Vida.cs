using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Vida : MonoBehaviour
{
    [SerializeField] Image vidasImage;
    [SerializeField] Sprite[] vidasSprite;
    public int vidasCount; 
    void Start()
    {
        //LA IMAGEN DE VIDAS QUE ME APAREZCA EN LA GUI SEA 1 VIDA 
        vidasImage.sprite = vidasSprite[3];

        vidasCount = vidasSprite.Length -1 ;
    }

    public void setActiveSprite(int spriteindex)
    {
        if (vidasSprite.Length >= spriteindex && spriteindex > 0)
        {
            
            vidasImage.sprite = vidasSprite[vidasCount - spriteindex];
            //MUESTRA EL SPRITE 
            vidasImage.color = Color.white;
            vidasCount --;
        }
        else
        {
            SceneManager.LoadScene(3);
        }


    }


}
