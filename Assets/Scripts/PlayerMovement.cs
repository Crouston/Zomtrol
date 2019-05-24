using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Script that controlled the players movement
/// </summary>
public class PlayerMovement : MonoBehaviour
{
    //private Rigidbody2D rb;

    [SerializeField]
    private float speed;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    //A function that move the gameobject according to the speed
    private void Move()
    {
        //float horAxis = Input.GetAxis("Horizontal");
        //rb.AddForce(transform.right * horAxis);
        //float verAxis = Input.GetAxis("Vertical");
        //rb.AddForce(transform.up * verAxis);

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * Time.deltaTime * speed);
            anim.SetBool("isWalking", true);
            return;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.up * Time.deltaTime * -speed);
            anim.SetBool("isWalking", true);
            return;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.right * Time.deltaTime * -speed);
            anim.SetBool("isWalking", true);
            return;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * Time.deltaTime * speed);
            anim.SetBool("isWalking", true);
            return;
        }
        anim.SetBool("isWalking", false);
    }
}
