using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Script that make player lose when touching human
/// </summary>
public class HumanHandler : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<GameManager>().isLosing = true;
    }
}
