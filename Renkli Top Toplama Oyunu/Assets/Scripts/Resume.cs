using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resume : MonoBehaviour
{
    public GameObject panel2;//Panel için gerekli oyun nesnesi
    void Start()
    {
        panel2.SetActive(false);//Paneli görünmez yap
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))//Esc tuþuna basýlýrsa
        {
            Time.timeScale = 0;//Oyunu durdur
            panel2.SetActive(true);//Paneli görünür yap
            AudioListener.volume = 0;//Sesi sustur
        }
    }
    public void ResumeFun()
    {
        Time.timeScale = 1;//Oyun devam eder
        panel2.SetActive(false);//Paneli görünmez yap
        AudioListener.volume = 1;//Sesi çal
    }
}
