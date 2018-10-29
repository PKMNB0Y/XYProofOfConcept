﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consumables : MonoBehaviour {

    public static int speed;
    public static int regen;
    public static int health;
    public static int hunger;
    public GameObject fruit;
    public Transform player;
    public float fruitspeed;

    //ParticleSystem.MainModule main = consume[i].main;
    public ParticleSystem consume;

    // Use this for initialization
    void Awake()
    {
        CircleCollider2D cc;
        cc = gameObject.AddComponent<CircleCollider2D>();
    }


    void Start () {
       
    }

    void OnTriggerEnter2D(Collider2D coll)
    {

        float step = fruitspeed * Time.deltaTime;
        if (coll.tag == "Fruit")
        {
            ImAFruit.moving = true;
        
          //  coll.transform.position = Vector3.MoveTowards(coll.transform.position, player.position, step);
        }

      
    }

    void OnCollisionEnter2D(Collision2D colli)
    {
        if (colli.gameObject.tag == "Fruit")
        {
            //Destroy(colli.gameObject);
        }
    }

    // Update is called once per frame
    void Update () {

        
        ParticleSystem.MainModule main = consume.main;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            consume.Play();
            main.loop = true;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            main.loop = false;
            consume.Stop();
        }

    }
}