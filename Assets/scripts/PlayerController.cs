using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Text scoreText;
    public Text winText;
    private int count;
    
    void Start()
    {
        count = 0;
        winText.text = "";
        SetScoreText();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count++;
            SetScoreText();
            if (count == 6)
            {
                winText.text = "You Won !";
            }
        }
    }

    void SetScoreText()
    {
        scoreText.text = "Score: " + count.ToString();
    }
}
