using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public Rigidbody submarine;

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
                transform.Rotate(0, Time.deltaTime * 5 * 50, 0);
            }

            if (Input.GetKey("left"))
            {
                transform.Rotate(0, -(Time.deltaTime * 5 * 50), 0);
            }

            if (Input.GetKey("up"))
            {
                transform.Rotate(Time.deltaTime * 5 * 50, 0, 0);
            }

            if (Input.GetKey("down"))
            {
                transform.Rotate(-(Time.deltaTime * 5 * 50), 0, 0);
            }
        }

        if (Input.GetKey("w"))
        {
            transform.position += new Vector3(0, 1, 0);
        }
        if (Input.GetKey("s"))
        {
            transform.position += new Vector3(0, -1, 0);
        }
    }
}
