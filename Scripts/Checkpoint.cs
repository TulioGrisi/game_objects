﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    Tatu t; //Variável do tipo tatu
    public GameObject tatu; //Recebe o tatu
    public ParticleSystem p1, p2;
    public int altCheckpoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            t.checkpoint = new Vector3(transform.position.x, transform.position.y + altCheckpoint, transform.position.z);
            var em1 = p1.emission;
            var em2 = p2.emission;
            em1.rateOverTime = 50;
            em2.rateOverTime = 50;
            Destroy(this);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        t = tatu.GetComponent<Tatu>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
