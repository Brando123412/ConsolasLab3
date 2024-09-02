using MoreMountains.CorgiEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelDesign : MonoBehaviour
{
    public float velocity = 1f;
    public Health controllerObject;
    private AudioSource myAS;

    private void Update()
    {
        
        transform.position = transform.position + Vector3.left * velocity * Time.deltaTime;
    }
}
