using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerHandler : MonoBehaviour
{
    [SerializeField]
    private int open, close;
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            FindObjectOfType<GateTriggerHandler>().ChangeGateState(open, close);
            int temp = open;
            open = close;
            close = temp;
            anim.SetTrigger("Pressed");
            GetComponent<AudioSource>().Play();
        }
    }

}
