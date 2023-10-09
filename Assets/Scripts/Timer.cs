using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float startTime;
    private float elapsedTime;
    public float totalTime = 60f; // Toplam süre (saniye cinsinden)

    void Start()
    {
        startTime = Time.time;
    }
    void Update()
    {
        elapsedTime = Time.time - startTime;
        // Zaman sýfýra veya negatif deðere düþtüðünde, oyunun sona erdiðini iþaretleyebilirsiniz.
        if (elapsedTime >= totalTime)
        {
            // Oyunun sona erdiðini iþlemleri burada yapabilirsiniz.
            // Örneðin, oyunu durdurabilir veya sonuçlarý görüntüleyebilirsiniz.
        }
    }
}
