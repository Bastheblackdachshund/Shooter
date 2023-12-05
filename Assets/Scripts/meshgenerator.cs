using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshCollider))]

public class meshgenerator : MonoBehaviour
{
    Mesh mesh;

    Vector3[] vertices;
    int[] triangles;


    // Start is called before the first frame update
    void Start()
    {
        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
        createShape();
        updateMesh();
    }

    // Update is called once per frame
    void createShape()
    {
        vertices = new Vector3[]
        {
            new Vector3( 0f, 0f, 0f),
            new Vector3( 0f, 0.0f, 1.0f),
            new Vector3( 1.0f, 0f, 0f),
            new Vector3 ( 1.0f, 0.0f, 1.0f),
            new Vector3 ( 0.5f, 1.0f, 0.5f),
            new Vector3 ( 0.5f, -1.0f, 0.5f),

        };
        triangles = new int[]
        {
            2,1,0,
            1,2,3,
            1,3,4,
            3,2,4,
            2,0,4,
            0,1,4,
            1,3,5,
            3,2,5,
            2,0,5,
            0,1,5,

        };
    }
    void updateMesh()
    {
        mesh.Clear();

        mesh.vertices = vertices;
        mesh.triangles = triangles;

        GetComponent<MeshCollider>().sharedMesh = mesh;
        GetComponent<MeshCollider>().convex = mesh;
    }
}
