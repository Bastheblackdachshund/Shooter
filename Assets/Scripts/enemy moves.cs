using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemymoves : MonoBehaviour
{
    public NavMeshAgent badGuy;
    public float squareOfMovement = 20f;
    private float xMin;
    private float xMax;
    private float zMin;
    private float zMax;
    public float closeEnough = 5f;

    private float xPosition;
    private float yPosition;
    private float zPosition;

    // Start is called before the first frame update
    void Start()
    {
        badGuy = GetComponent<NavMeshAgent>(); // finding the mesh agent with code

        xMin = zMin - squareOfMovement;
        xMax = zMax = squareOfMovement;
        newLocation();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, new Vector3(xPosition, yPosition, zPosition)) <= closeEnough)
        {
            newLocation();
        }
    }

    public void newLocation()
    {
        xPosition = Random.Range(xMin, xMax);
        yPosition = transform.position.y;
        zPosition = Random.Range(zMin, zMax);

        badGuy.SetDestination(new Vector3(xPosition, yPosition, zPosition));
    }
}