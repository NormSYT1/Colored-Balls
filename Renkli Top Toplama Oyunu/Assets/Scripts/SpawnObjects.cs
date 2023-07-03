using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public GameObject ball;//Oyundaki nesne i�in gerekli de�i�ken
    float counter = 1.5f, time1 = 1.5f;//Saya�-s�re de�i�kenleri
    PlayerMove control;
    void Start()
    {
        control = GetComponent<PlayerMove>();
    }
    void Update()//Belirli bir s�rede nesne olu�turmak i�in yap�lan d�ng�sel i�lem
    {
        time1 -= Time.deltaTime;//S�reyi azalt
        if (time1 < 0)//S�re s�f�rdan k���kse
        {
            Instantiate(ball, new Vector3(Random.Range(-19f, 19f), 1f, Random.Range(-40f, -30f)), Quaternion.identity);//Girilen rastgele konumda nesneyi olu�tur
            time1 = counter;//S�reyi sayaca e�itle
        }
    }
}
