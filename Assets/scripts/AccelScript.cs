using UnityEngine;
using UnityEngine.SceneManagement;

public class AccelScript : MonoBehaviour
{
    public Rigidbody submarine;

    public void Update()
    {
        var touches = Input.touchCount;
        var vec = new Vector3(0.0f, 0.0f, 0.0f);

        if (touches > 0)
        {
            transform.position -= transform.forward * Time.deltaTime * 30;
        }
        var x = Input.acceleration.x;
        var y = Input.acceleration.y;

        transform.Rotate(0, Time.deltaTime * x * 50, 0);
        transform.Rotate(-Time.deltaTime * y * 50, 0, 0);

        transform.position += vec;
        
    }

    void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene("end", LoadSceneMode.Additive);
    }
}
