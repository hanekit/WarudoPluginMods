using System.Collections.Generic;
using UnityEngine;
using Warudo.Core.Attributes;
using Warudo.Core.Graphs;

[NodeType(
    Id = "hanekit-e1136b66-7bff-4ff7-ac07-b8459c595e0b",
    Title = "VECTOR3_MOVING_AVERAGE_NODE_TITLE",
    Category = "MOVING_AVERAGE_NODE_CATEGORY")]
public class Vector3MovingAverageNode : Node
{
    private Queue<Vector3> values = new Queue<Vector3>();
    private Vector3 sum = new Vector3();

    /* DATA INPUTS */
    [DataInput]
    [Label("MOVING_AVERAGE_SAMPLE_DATA_SOURCE")]
    public Vector3 newValue = new Vector3();

    [DataInput]
    [IntegerSlider(1, 100)]
    [Label("MOVING_AVERAGE_SAMPLE_SIZE")]
    public int maxSize = 10;

    /* DATA OUTPUTS */
    [DataOutput]
    [Label("MOVING_AVERAGE_CURRENT_SAMPLE_LIST")]
    public Vector3[] CurrentSampleList()
    {
        return values.ToArray();
    }

    [DataOutput]
    [Label("MOVING_AVERAGE_VALUE")]
    public Vector3 MovingAverageValue()
    {
        if (values.Count == maxSize)
        {
            sum -= values.Dequeue(); // Remove the oldest value
            values.Enqueue(newValue); // Add a new value
            sum += newValue;
        }
        else
        {
            values.Clear();
            // Fill the values
            for (int i = 0; i < maxSize; i++)
            {
                values.Enqueue(newValue);
            }
            sum = newValue * maxSize;
        }

        return sum / maxSize;
    }
}
