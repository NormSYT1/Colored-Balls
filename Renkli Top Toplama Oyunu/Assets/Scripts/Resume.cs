using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resume : MonoBehaviour
{
    public GameObject panel2;//Panel i�in gerekli oyun nesnesi
    void Start()
    {
        panel2.SetActive(false);//Paneli g�r�nmez yap
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))//Esc tu�una bas�l�rsa
        {
            Time.timeScale = 0;//Oyunu durdur
            panel2.SetActive(true);//Paneli g�r�n�r yap
            AudioListener.volume = 0;//Sesi sustur
        }
    }
    public void ResumeFun()
    {
        Time.timeScale = 1;//Oyun devam eder
        panel2.SetActive(false);//Paneli g�r�nmez yap
        AudioListener.volume = 1;//Sesi �al
    }
}
