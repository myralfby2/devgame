using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoreboard : MonoBehaviour
{
    int score = 0; // Текущее количество очков
    int target = 0;// Сколько нужно очков
    GameObject label; // Надпись
    
    public void Start()
    {
        label.enabled = false;
        score = 0;
        target = Random.Range(40,80);
    }
    public void OnClick()
    {
        score += 1;
        if (score >= target)
        {
                label.enabled = true;
                target += 10;
                score = 0;
        }
    }
}
