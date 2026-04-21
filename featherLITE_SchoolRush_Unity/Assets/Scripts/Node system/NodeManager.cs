using UnityEngine;
using System.Collections.Generic;
using System.Linq;
public class NodeManager : MonoBehaviour
{
    public List<Node> allNodes = new List<Node>(); 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach (Node node in GetShortestPath(allNodes[1], allNodes[0]))
        {
            Debug.Log(node.gameObject.name);
        }
        
    }

    public List<Node> GetShortestPath(Node startNode, Node targetNode)
    {
        // 1. Initialize data structures
        Dictionary<Node, float> distances = new Dictionary<Node, float>();
        Dictionary<Node, Node> previousNodes = new Dictionary<Node, Node>();
        List<Node> unvisited = new List<Node>();

        foreach (Node node in allNodes)
        {
            distances[node] = float.MaxValue; // Set initial distance to infinity
            previousNodes[node] = null;
            unvisited.Add(node);
        }

        distances[startNode] = 0; // Distance from start to start is 0

        // 2. Main Algorithm Loop
        while (unvisited.Count > 0)
        {
            // Get the unvisited node with the smallest distance
            // (In a massive map, use a Priority Queue here for better performance)
            Node currentNode = unvisited.OrderBy(n => distances[n]).First();
            unvisited.Remove(currentNode);

            // If we reached the target, we can stop early
            if (currentNode == targetNode) break;

            foreach (Node neighbor in currentNode.connectedNodes)
            {
                float alt = distances[currentNode] + currentNode.DistanceTo(neighbor);

                if (alt < distances[neighbor])
                {
                    distances[neighbor] = alt;
                    previousNodes[neighbor] = currentNode;
                }
            }
        }

        // 3. Reconstruct the path from target to start
        List<Node> path = new List<Node>();
        Node current = targetNode;

        while (current != null)
        {
            path.Add(current);
            current = previousNodes[current];
        }

        path.Reverse(); // Flip it so it goes Start -> Target

        // Check if a path actually exists
        return path[0] == startNode ? path : new List<Node>();
    }


    //make function where if given a position find nearest node;



}