using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playemove : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float jump;
    private Rigidbody2D rb;
    Vector3 mom;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
   
    private void FixedUpdate()
    {
        mom = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
        transform.position += mom * speed * Time.deltaTime;
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
        }
       
    }
}
