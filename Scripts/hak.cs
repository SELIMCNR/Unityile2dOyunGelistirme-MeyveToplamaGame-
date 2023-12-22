using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class hak : MonoBehaviour
{
    //Oyun kullanýcý hakký
    [SerializeField]
    public static int kalanHak = 3;
    public TextMeshProUGUI hakYazisi;
    public GameObject bitisPaneli;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hakYazisi.text = "Hak : " + kalanHak.ToString();
        if(kalanHak == 0)
        {
            bitisPaneli.SetActive(true);
            Time.timeScale = 0;  //oyunu durdur.
        }
    }
}
