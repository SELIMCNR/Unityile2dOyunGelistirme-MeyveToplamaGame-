using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;//TEXTDE BU
using TMPro;
using Unity.VisualScripting;//Text mesh proda bu

public class engeller : MonoBehaviour
{
    private static int skor;
    public TextMeshProUGUI skorYazisi,bitisYazisi;
    float xPozisyonu;
    float yPozisyonu;

    // Sesi depolamak i�in bir AudioSource bile�eni
  
    private AudioSource sesKaynagi;

    // Sesi y�r�tmek i�in kullan�lacak AudioClip
    public AudioClip sesDosyasi;

    void Start()
    {
        skor = 0;
        xPozisyonu = Random.Range(-5f, 5f);
        yPozisyonu = Random.Range(6.5f, 15f);
        //nesne �arp��ma �zellikleri
     

     
    }

private void Update()
    {
        xPozisyonu = Random.Range(-7f, 7f);
        yPozisyonu = Random.Range(6.5f, 15f);
        //Skor g�sterme
        skorYazisi.text = skor.ToString();
        bitisYazisi.text = "Oyun bitti !  Skor : " + skor.ToString(); ;

    }
    //nesne �arp��ma �zellikleri
    void OnCollisionEnter2D(Collision2D temas)
    {      //kontrol cubu�una �arparsa yeni pozisyona g�t�r nesneleri
        if (temas.gameObject.tag == "Kontrol Cubugu")
        {
            transform.position = new Vector2(Mathf.Lerp(-0.10f, -0.21f, 0.10f), Mathf.Lerp(-7.5f, -9.24f, 1.62f));

        }
        else if (temas.gameObject.tag == "Karakter")
        {
            sesKaynagi = gameObject.AddComponent<AudioSource>();

            // Ses dosyas�n� atay�n
            sesKaynagi.clip = sesDosyasi;
            // Sesi oynat
            sesKaynagi.Play();
            skor += Random.Range(8, 15);
            transform.position = new Vector2(xPozisyonu, yPozisyonu);

        }
        if(temas.gameObject.tag == "new")
        {
            hak.kalanHak--; //hakk� zzalt
            transform.position = new Vector2(xPozisyonu, yPozisyonu);
        }
        
    }


}
