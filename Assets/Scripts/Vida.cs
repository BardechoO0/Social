using UnityEngine;
using UnityEngine.UI;

public class CanvasUI : MonoBehaviour
{
    [SerializeField] Image vidasImage;
    [SerializeField] Sprite[] vidasSprite;
    void Start()
    {
        //LA IMAGEN DE VIDAS QUE ME APAREZCA EN LA GUI SEA 1 VIDA 
        vidasImage.sprite = vidasSprite[3];
    }

    public void setActiveSprite(int spriteindex)
    {
        if (vidasSprite.Length >= spriteindex && spriteindex > 0)
        {
            vidasImage.sprite = vidasSprite[spriteindex - 1];
            //MUESTRA EL SPRITE 
            vidasImage.color = Color.white;
        }
        else
        {
            //OCULTA EL SPRITE 
            vidasImage.color = Color.clear;
        }


    }


}
