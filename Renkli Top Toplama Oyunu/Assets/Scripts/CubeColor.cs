using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeColor : MonoBehaviour
{
    Material objectColor;//Renk i�in gerekli de�i�ken
    int colorNo;//Renk numaras� i�in gereki de�i�ken
    void Start()
    {
        ColorChange();//Fonksiyonu �a��r
    }
    void Update()
    {
        
    }
    public void ColorChange()
    {
        objectColor = gameObject.GetComponent<Renderer>().material;//Nesnenin materyaline eri�mek i�in
        colorNo = Random.Range(0, 5);//Renk numaras�n� rastgele bir de�er ata
        if (colorNo == 0)//Renk no 0 ise
        {
            objectColor.color = Color.red;//Nesnenin rengini k�rm�z� yap
        }
        else if (colorNo == 1)//Renk no 1 ise
        {
            objectColor.color = Color.green;//Nesnenin rengini ye�il yap
        }
        else if (colorNo == 2)//Renk no 2 ise
        {
            objectColor.color = Color.blue;//Nesnenin rengini mavi yap
        }
        else if (colorNo == 3)//Renk no 3 ise
        {
            objectColor.color = Color.yellow;//Nesnenin rengini sar� yap
        }
        else if (colorNo == 4)//Renk no 4 ise
        {
            objectColor.color = Color.magenta;//Nesnenin rengini mor yap
        }
    }
}
