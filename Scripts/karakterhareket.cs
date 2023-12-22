using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakterhareket : MonoBehaviour
{


    public float hareketHizi;
  
    // Update is called once per frame
    void Update()
    {
        //kareket hareket verme
        float hiz = hareketHizi * Input.GetAxis("Horizontal");
        transform.Translate(hiz * Time.deltaTime,0,0);

    }
}
