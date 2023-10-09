using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float startTime;
    private float elapsedTime;
    public float totalTime = 60f; // Toplam s�re (saniye cinsinden)

    void Start()
    {
        startTime = Time.time;
    }
    void Update()
    {
        elapsedTime = Time.time - startTime;
        // Zaman s�f�ra veya negatif de�ere d��t���nde, oyunun sona erdi�ini i�aretleyebilirsiniz.
        if (elapsedTime >= totalTime)
        {
            // Oyunun sona erdi�ini i�lemleri burada yapabilirsiniz.
            // �rne�in, oyunu durdurabilir veya sonu�lar� g�r�nt�leyebilirsiniz.
        }
    }
}
