using UnityEngine;
using UnityEngine.UI;

public class MovementScript : MonoBehaviour
{
    public Rigidbody submarine;
    public int ballast = 50;
    public Text ballastText;

    public void Start()
    {
    }

    public void Update()
    {

        if (Input.GetKey("space"))
        {
            transform.position -= transform.forward * Time.deltaTime * 30;
            if (Input.GetKey("right"))
            {
                transform.Rotate(0, Time.deltaTime  * 15, 0);
            }

            if (Input.GetKey("left"))
            {
                transform.Rotate(0, -(Time.deltaTime  * 15), 0);
            }

            if (Input.GetKey("up"))
            {
                transform.Rotate(Time.deltaTime * 15, 0, 0);
            }

            if (Input.GetKey("down"))
            {
                transform.Rotate(-(Time.deltaTime * 15), 0, 0);
            }
        }

        if (Input.GetKey("w"))
        {
            if (ballast < 100)
            {
                ballast += 1;
                ballastText.text = ballast + " %";
            }
        }
        if (Input.GetKey("s"))
        {
            if (ballast > 0)
            {
                ballast -= 1;
                ballastText.text = ballast + " %";
            }
        }

        var dy = (float) ((ballast - 50) * 0.001);
        if (transform.position.y + dy > 150)
        {
            dy = 150 - transform.position.y;
        }
        transform.position += new Vector3(0, dy, 0);
    }
}
