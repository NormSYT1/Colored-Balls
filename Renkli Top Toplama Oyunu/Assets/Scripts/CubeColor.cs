using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeColor : MonoBehaviour
{
    Material objectColor;//Renk için gerekli deðiþken
    int colorNo;//Renk numarasý için gereki deðiþken
    void Start()
    {
        ColorChange();//Fonksiyonu çaðýr
    }
    void Update()
    {
        
    }
    public void ColorChange()
    {
        objectColor = gameObject.GetComponent<Renderer>().material;//Nesnenin materyaline eriþmek için
        colorNo = Random.Range(0, 5);//Renk numarasýný rastgele bir deðer ata
        if (colorNo == 0)//Renk no 0 ise
        {
            objectColor.color = Color.red;//Nesnenin rengini kýrmýzý yap
        }
        else if (colorNo == 1)//Renk no 1 ise
        {
            objectColor.color = Color.green;//Nesnenin rengini yeþil yap
        }
        else if (colorNo == 2)//Renk no 2 ise
        {
            objectColor.color = Color.blue;//Nesnenin rengini mavi yap
        }
        else if (colorNo == 3)//Renk no 3 ise
        {
            objectColor.color = Color.yellow;//Nesnenin rengini sarý yap
        }
        else if (colorNo == 4)//Renk no 4 ise
        {
            objectColor.color = Color.magenta;//Nesnenin rengini mor yap
        }
    }
}
