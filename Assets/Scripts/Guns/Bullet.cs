using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private bool moveBullet;
    private float speed = 45;

    private float deleteTime = 1f;
    private float timeTillDeletion;

    // Start is called before the first frame update
    void Update()
    {
        timeTillDeletion += Time.deltaTime;
        MoveForward();
    }

    // Update is called once per frame
    private void MoveForward()
    {
        transform.position += transform.forward * (speed * Time.deltaTime);
        
        if(timeTillDeletion >= deleteTime) Destroy(this.gameObject);
    }
}
