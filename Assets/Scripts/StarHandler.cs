using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>
public class StarHandler : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        AddStar();
    }

    //Add star or point to script game manager
    private void AddStar()
    {
        FindObjectOfType<GameManager>().starsGotten++;
        GetComponentInParent<AudioSource>().Play();
        Destroy(gameObject);
    }
}
