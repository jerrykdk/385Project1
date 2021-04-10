using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed = 10f;

    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey("q"))
        {
            pos.x -= speed * Time.deltaTime;
            pos.y += speed * Time.deltaTime;
        }
          if (Input.GetKey("e"))
        {
            pos.x += speed * Time.deltaTime;
            pos.y += speed * Time.deltaTime;
        }

        if (Input.GetKey("w"))
        {
            pos.y += speed * Time.deltaTime;
        }

        if (Input.GetKey("s"))
        {
            pos.y -= speed * Time.deltaTime;
        }

        if (Input.GetKey("d"))
        {
            pos.x += speed * Time.deltaTime;
        }

        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;
        }

           if (Input.GetKey("z"))
        {
            pos.x -= speed * Time.deltaTime;
            pos.y -= speed * Time.deltaTime;
        }

           if (Input.GetKey("x"))
        {
            pos.x += speed * Time.deltaTime;
            pos.y -= speed * Time.deltaTime;
        }
        transform.position = pos;
    }
}
