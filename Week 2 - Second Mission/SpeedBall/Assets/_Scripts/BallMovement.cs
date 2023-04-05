using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed = 5f;
    
    void Update()
    {
        transform.position += Vector3.forward * speed * Time.deltaTime;

        // Giderek hýzlanma ve hýzlanmaya limit 
        if(speed <= 20)
            speed += 0.5f * Time.deltaTime;

        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            transform.localPosition = new Vector3(-0.4f, transform.position.y, transform.position.z);
        }
        else if (Input.GetAxisRaw("Horizontal") > 0)
        {
            transform.localPosition = new Vector3(0.5f, transform.position.y, transform.position.z);
        }


    }
}
