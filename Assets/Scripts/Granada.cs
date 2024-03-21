using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Granada : MonoBehaviour
{

    public float inteval;
    private float timer = 0;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > inteval)
            Destroy(gameObject);
    }
}
