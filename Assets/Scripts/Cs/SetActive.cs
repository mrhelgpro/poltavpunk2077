using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActive : MonoBehaviour
{
    public GameObject Target;

    public void Activate()
    {
        Target?.SetActive(true);
    }
}
