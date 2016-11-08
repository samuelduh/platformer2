using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour
{

    public int coins = 0;
    public int lives = 3;
    public Text coinsText;
    public Text livesText;

    // Use this for initialization
    void Start()
    {
        coinsText.text = coins.ToString();
        livesText.text = lives.ToString();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CoinWasPickedUp(int worth)
    {
        coins += worth;
        coinsText.text = coins.ToString();
    }

    public void lifewaslost()
    {
        lives--;
        livesText.text = lives.ToString();
    }

}
