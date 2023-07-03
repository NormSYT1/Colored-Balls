using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMove : MonoBehaviour
{
    float vertical, horizontal;//Hareket i�in y�n de�i�kenleri
    float speed = 8f;//H�z de�i�keni
    Rigidbody rb;//Rigidbody eklentisine eri�im
    CubeColor control;//Ba�ka script'e eri�im
    public TMP_Text pointText, timeText, lastText;//Yaz� i�in gerekli de�i�kenler
    float point = 0, time = 120;//Puan ve s�re de�i�kenleri
    public GameObject panel1;//Panel i�in gerekli de�i�ken
    public AudioClip sound;//Ses i�in gerekli de�i�ken
    void Start()
    {
        Time.timeScale = 1;//Oyunu ba�lat
        panel1.SetActive(false);//Paneli g�r�nmez yap
        rb = GetComponent<Rigidbody>();//Rigidbody'e eri�im
        control = GetComponent<CubeColor>();//Ba�ka script'e eri�im
        control.ColorChange();//Ba�ka script'deki fonksiyonu �a��r
    }
    void Update()
    {
        if (time >= 0)//S�re s�f�rdan b�y�k e�itse
        {
            time -= Time.deltaTime;//S�reyi azalt
            timeText.text = "Time: " + (int)time;//S�reyi ekrana yazd�r
        }
        if (time <= 1)//S�re 1 den k���k e�itse
        {
            Time.timeScale = 0;//Oyunu durdur
            panel1.SetActive(true);//Paneli g�r�n�r yap
            lastText.text = "Your Score: " + point;//Son puan� ekrana yazd�r
            AudioListener.volume = 0;//Sesi sustur       
        }
        vertical = Input.GetAxis("Vertical");//Dikey y�nde hareket i�in
        horizontal = Input.GetAxis("Horizontal");//Yatay y�nde hareket i�in
        rb.velocity = new Vector3(horizontal * speed, 0, vertical * speed);//Oyuncuyu hareket ettirir
        pointText.text = "Score: " + point;//Puan� yazd�r        
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ball")//Temas edilen nesnenin etiketi 'Ball' ise
        {
            AudioSource.PlayClipAtPoint(sound, transform.position);//�arpma sesini �al
            if (gameObject.GetComponent<Renderer>().material.color == other.gameObject.GetComponent<Renderer>().material.color)//Oyuncunun rengi ile nesnenin rengi ayn� ise
            {
                point++;//Puan� artt�r
            }
            else//Oyuncunun rengi ile nesnenin rengi farkl� ise
            {
                if (point > 0)//Puan s�f�rdan b�y�kse 
                {
                    point--;//Puan� azalt
                }              
            }
            Destroy(other.gameObject);//Temas edilen nesneyi yok et
            control.ColorChange();//Ba�ka script'deki fonksiyonu �a��r
        }    
    }
}
