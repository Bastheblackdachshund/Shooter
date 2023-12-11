using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    public int Wealth;
    public int NumCoin;

    public Image[] Coins;
    public Sprite FullPoach;
    public Sprite EmptyPoach;
    public float cooldown = 3f;
    public float cooldownduration = 0f;

    void Update()
    {
        if (cooldownduration > 0)
        {
            cooldownduration -= Time.deltaTime;
        }
        if (Wealth > NumCoin){
            Wealth = NumCoin;
        }
        for (int i = 0; i < Coins.Length; i++) 
        {
            if(i < Wealth) 
            {
                Coins[i].sprite = FullPoach;
            }
            else
            {
                Coins[i].sprite = EmptyPoach;
            }
            if (i < NumCoin) 
            {
                Coins[i].enabled = true;
            }
            else
            {
                Coins[i].enabled = false;
            }
        }
        if( Wealth == 0) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }

    public void damage(int damage)
    { 
        if (cooldownduration <= 0)
        {
            Wealth -= damage;
            cooldownduration = cooldown;
        }
    }


}
