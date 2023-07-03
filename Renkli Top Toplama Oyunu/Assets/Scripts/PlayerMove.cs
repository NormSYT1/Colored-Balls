using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMove : MonoBehaviour
{
    float vertical, horizontal;//Hareket için yön deðiþkenleri
    float speed = 8f;//Hýz deðiþkeni
    Rigidbody rb;//Rigidbody eklentisine eriþim
    CubeColor control;//Baþka script'e eriþim
    public TMP_Text pointText, timeText, lastText;//Yazý için gerekli deðiþkenler
    float point = 0, time = 120;//Puan ve süre deðiþkenleri
    public GameObject panel1;//Panel için gerekli deðiþken
    public AudioClip sound;//Ses için gerekli deðiþken
    void Start()
    {
        Time.timeScale = 1;//Oyunu baþlat
        panel1.SetActive(false);//Paneli görünmez yap
        rb = GetComponent<Rigidbody>();//Rigidbody'e eriþim
        control = GetComponent<CubeColor>();//Baþka script'e eriþim
        control.ColorChange();//Baþka script'deki fonksiyonu çaðýr
    }
    void Update()
    {
        if (time >= 0)//Süre sýfýrdan büyük eþitse
        {
            time -= Time.deltaTime;//Süreyi azalt
            timeText.text = "Time: " + (int)time;//Süreyi ekrana yazdýr
        }
        if (time <= 1)//Süre 1 den küçük eþitse
        {
            Time.timeScale = 0;//Oyunu durdur
            panel1.SetActive(true);//Paneli görünür yap
            lastText.text = "Your Score: " + point;//Son puaný ekrana yazdýr
            AudioListener.volume = 0;//Sesi sustur       
        }
        vertical = Input.GetAxis("Vertical");//Dikey yönde hareket için
        horizontal = Input.GetAxis("Horizontal");//Yatay yönde hareket için
        rb.velocity = new Vector3(horizontal * speed, 0, vertical * speed);//Oyuncuyu hareket ettirir
        pointText.text = "Score: " + point;//Puaný yazdýr        
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ball")//Temas edilen nesnenin etiketi 'Ball' ise
        {
            AudioSource.PlayClipAtPoint(sound, transform.position);//Çarpma sesini çal
            if (gameObject.GetComponent<Renderer>().material.color == other.gameObject.GetComponent<Renderer>().material.color)//Oyuncunun rengi ile nesnenin rengi ayný ise
            {
                point++;//Puaný arttýr
            }
            else//Oyuncunun rengi ile nesnenin rengi farklý ise
            {
                if (point > 0)//Puan sýfýrdan büyükse 
                {
                    point--;//Puaný azalt
                }              
            }
            Destroy(other.gameObject);//Temas edilen nesneyi yok et
            control.ColorChange();//Baþka script'deki fonksiyonu çaðýr
        }    
    }
}
