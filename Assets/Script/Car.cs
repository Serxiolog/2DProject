using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public List<WheelJoint2D> Wheels;
    public float speed;
    private Camera _camera;
    public Transform moto;

    private void Start()
    {
        _camera = Camera.main;
        speed = 1500;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
            Restart();
        var horizantal = Input.GetAxis("Horizontal");
        if (Mathf.Abs(horizantal) > 0.1)
        {
            foreach (var wheel in Wheels)
            {
                wheel.useMotor = true;
                wheel.motor = new JointMotor2D()
                {
                    motorSpeed = speed * horizantal,
                    maxMotorTorque = 10000
                };
            }
        }
        else
        {
            foreach (var wheel in Wheels)
            {
                wheel.useMotor = false;
            }
        }

        float NewX = Mathf.Lerp(_camera.transform.position.x, moto.position.x, Time.deltaTime);
        float NewY = Mathf.Lerp(_camera.transform.position.y, moto.position.y, Time.deltaTime);
        _camera.transform.position = new Vector3(NewX, NewY, -10);
    }

    private void Restart()
    {
        moto.transform.position = new Vector3(moto.transform.position.x, moto.transform.position.y + 5, moto.transform.position.z);
        moto.transform.rotation = Quaternion.identity;
    }

}
