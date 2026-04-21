using System;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;
using System.Collections.Generic;

public class Node : MonoBehaviour
{
    public List<Node> connectedNodes;


    public float DistanceTo(Node other)
    {
        return Vector3.Distance(transform.position, other.transform.position);
    }
}


