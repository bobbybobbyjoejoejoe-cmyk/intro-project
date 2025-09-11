using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float jumpspeed = 5f;
    public float speed = 5f;
    Rigidbody2D rb;
    GameObject character;
    // Start is called before the first frame update
    void Start()
    {

    }

    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += move * Time.deltaTime * speed;
    }
    void Jump()
    {
        rb.AddForce(new Vector2(0f, jumpspeed), ForceMode2D.Impulse);
    }
}