using System.Collections.Generic;
using UnityEngine;
using Warudo.Core.Attributes;
using Warudo.Core.Graphs;

[NodeType(
    Id = "hanekit-c572faf8-5f42-43d8-83ed-71a37a3d0c34",
    Title = "FLOAT_MOVING_AVERAGE_NODE_TITLE",
    Category = "MOVING_AVERAGE_NODE_CATEGORY")]
public class FloatMovingAverageNode : Node
{
    private Queue<float> values = new Queue<float>();
    private float sum = 0;

    /* DATA INPUTS */
    [DataInput]
    [Label("MOVING_AVERAGE_SAMPLE_DATA_SOURCE")]
    public float newValue = 0;

    [DataInput]
    [IntegerSlider(1, 100)]
    [Label("MOVING_AVERAGE_SAMPLE_SIZE")]
    public int maxSize = 10;

    /* DATA OUTPUTS */
    [DataOutput]
    [Label("MOVING_AVERAGE_CURRENT_SAMPLE_LIST")]
    public float[] CurrentSampleList()
    {
        return values.ToArray();
    }

    [DataOutput]
    [Label("MOVING_AVERAGE_VALUE")]
    public float MovingAverageValue()
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
