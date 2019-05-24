using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Make the star in star UI glow
/// </summary>
public class StarUIHandler : MonoBehaviour
{
    [SerializeField] private int star;

    // Update is called once per frame
    void Update()
    {
        if(FindObjectOfType<GameManager>().starsGotten == star)
        {
            GetComponent<Image>().color = new Color(255, 255, 255);
        }
    }

}
