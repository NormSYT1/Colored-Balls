using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public GameObject ball;//Oyundaki nesne için gerekli deðiþken
    float counter = 1.5f, time1 = 1.5f;//Sayaç-süre deðiþkenleri
    PlayerMove control;
    void Start()
    {
        control = GetComponent<PlayerMove>();
    }
    void Update()//Belirli bir sürede nesne oluþturmak için yapýlan döngüsel iþlem
    {
        time1 -= Time.deltaTime;//Süreyi azalt
        if (time1 < 0)//Süre sýfýrdan küçükse
        {
            Instantiate(ball, new Vector3(Random.Range(-19f, 19f), 1f, Random.Range(-40f, -30f)), Quaternion.identity);//Girilen rastgele konumda nesneyi oluþtur
            time1 = counter;//Süreyi sayaca eþitle
        }
    }
}
