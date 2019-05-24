using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Script that handle goals gameobject
/// </summary>
public class GoalHandler : MonoBehaviour
{
    public bool isPressed;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        isPressed = false;
        FindObjectOfType<GameManager>().goals.Add(this);
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            isPressed = true;
            anim.SetBool("isPressed", true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            isPressed = false;
            anim.SetBool("isPressed", false);
        }
    }
}
