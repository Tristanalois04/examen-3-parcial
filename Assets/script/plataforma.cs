﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataforma : MonoBehaviour
{

    [Header("Balance variables")]

    public bool isMovingHorizontally = true;
    public bool starMovingRitghUp;
    public int movingDistance = 4;

    public float speed = 2;
    private Vector2 originalPosition;
    private Vector2 targetPosition;
    private Vector2 newPosition;

    // Start is called before the first frame update
    void Start()
    {


        originalPosition = transform.position;
        if (isMovingHorizontally)
        {
            if (starMovingRitghUp)
                targetPosition = new Vector2(originalPosition.x + movingDistance,originalPosition.y);
            else
                targetPosition = new Vector2(originalPosition.x - movingDistance, originalPosition.y);
        }
        else
        {
            if (starMovingRitghUp)
                targetPosition = new Vector2(originalPosition.x  , originalPosition.y + movingDistance);
            else
                targetPosition = new Vector2(originalPosition.x , originalPosition.y - movingDistance);
        }
    }

    // Update is called once per frame
    void Update()
    {
       if(isMovingHorizontally)
        {
            if (starMovingRitghUp)
            {

                if (transform.position.x >= targetPosition.x)
                {
                    newPosition = originalPosition;

                }
                else if (transform.position.x <= originalPosition.x)
                {
                    newPosition = targetPosition;
                }

            }
            else
            {

                if (transform.position.x <= targetPosition.x)
                {
                    newPosition = originalPosition;

                }
                else if (transform.position.x >= originalPosition.x)
                {
                    newPosition = targetPosition;
                }

            }



        }
       else //arriba a abajo 
        {
            if (starMovingRitghUp)
            {

                if (transform.position.y >= targetPosition.y)
                {
                    newPosition = originalPosition;

                }
                else if (transform.position.y <= originalPosition.y)
                {
                    newPosition = targetPosition;
                }

            }
            else
            {

                if (transform.position.y <= targetPosition.y)
                {
                    newPosition = originalPosition;

                }
                else if (transform.position.y >= originalPosition.y)
                {
                    newPosition = targetPosition;
                }

            }

        }
        transform.position = Vector3.MoveTowards(transform.position, newPosition, Time.deltaTime * speed);




    }
}
