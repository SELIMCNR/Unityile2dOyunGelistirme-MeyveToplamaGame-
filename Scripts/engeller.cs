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

    // Sesi depolamak için bir AudioSource bileþeni
  
    private AudioSource sesKaynagi;

    // Sesi yürütmek için kullanýlacak AudioClip
    public AudioClip sesDosyasi;

    void Start()
    {
        skor = 0;
        xPozisyonu = Random.Range(-5f, 5f);
        yPozisyonu = Random.Range(6.5f, 15f);
        //nesne çarpýþma özellikleri
     

     
    }

private void Update()
    {
        xPozisyonu = Random.Range(-7f, 7f);
        yPozisyonu = Random.Range(6.5f, 15f);
        //Skor gösterme
        skorYazisi.text = skor.ToString();
        bitisYazisi.text = "Oyun bitti !  Skor : " + skor.ToString(); ;

    }
    //nesne çarpýþma özellikleri
    void OnCollisionEnter2D(Collision2D temas)
    {      //kontrol cubuðuna çarparsa yeni pozisyona götür nesneleri
        if (temas.gameObject.tag == "Kontrol Cubugu")
        {
            transform.position = new Vector2(Mathf.Lerp(-0.10f, -0.21f, 0.10f), Mathf.Lerp(-7.5f, -9.24f, 1.62f));

        }
        else if (temas.gameObject.tag == "Karakter")
        {
            sesKaynagi = gameObject.AddComponent<AudioSource>();

            // Ses dosyasýný atayýn
            sesKaynagi.clip = sesDosyasi;
            // Sesi oynat
            sesKaynagi.Play();
            skor += Random.Range(8, 15);
            transform.position = new Vector2(xPozisyonu, yPozisyonu);

        }
        if(temas.gameObject.tag == "new")
        {
            hak.kalanHak--; //hakký zzalt
            transform.position = new Vector2(xPozisyonu, yPozisyonu);
        }
        
    }


}
