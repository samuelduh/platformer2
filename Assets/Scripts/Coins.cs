using UnityEngine;
using System.Collections;

public class Coins : MonoBehaviour
{
    public int worth = 1;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        gameObject.SetActive(false);
        FindObjectOfType<Gamemanager>().CoinWasPickedUp(worth);
    }
}
