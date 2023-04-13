using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerManager : MonoBehaviour
{
    public float health = 100f;
    public TextMeshProUGUI healthText;

    public GameManager gameManager;


    public void Hit(float damage)
    {
        health -= damage;
        healthText.text = "Health: " + health.ToString();

        //check if player life is 0
        if (health <= 0)
        {
            gameManager.EndGame();
        }
    }

}
