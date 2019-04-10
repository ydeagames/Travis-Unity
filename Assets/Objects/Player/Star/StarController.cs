﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour
{
    public static GameObject latestStar;

    public List<GripController> grips;
    Rigidbody2D rigid;
    public float speed = 1;
    int vel = 1;
    public bool enablegrip;
    [HideInInspector]
    public GameObject currentJoint = null;
    float timer;

    void Awake()
    {
        latestStar = gameObject;
    }

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Grip"))
            enablegrip = true;
        if (Input.GetButtonUp("Grip"))
            enablegrip = false;
        rigid.angularVelocity = vel * speed;
        timer += Time.deltaTime;
    }

    public void DetachAll()
    {
        foreach (var grip in grips)
            grip.Detatch();
    }

    public void SetCurrentJoint(GripController grip, GameObject point)
    {
        if (((enablegrip && timer > 0.3f) || currentJoint == null) && currentJoint != point)
        {
            GetComponent<AudioSource>().Play();
            DetachAll();
            grip.Attach(point);
            //enablegrip = false;
            timer = 0;
            grip.EmitParticle();
            currentJoint = point;
            point.SendMessage("OnAttached", SendMessageOptions.DontRequireReceiver);
        }
    }
}
