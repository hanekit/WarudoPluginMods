using UnityEngine;
using System;
using Warudo.Core.Attributes;
using Warudo.Core.Graphs;
using Warudo.Core.Data;


public abstract class FloatRangeToTypeCondition<T> : StructuredData, ICollapsibleStructuredData {

    /* DATA INPUTS */
    [DataInput]
    [Label("RANGE")]
    public Vector2 Range = new Vector2(0, 1);

    [DataInput]
    [Label("INCLUDE_X")]
    public bool IncludeX = false;

    [DataInput]
    [Label("INCLUDE_Y")]
    public bool IncludeY = false;

    [DataInput]
    [IntegerSlider(0, 10)]
    [Label("MATCH_OUTPUT")]
    public T MatchOutput;

    public FloatRangeToTypeCondition() {
        if (typeof(T) == typeof(string)) {
            MatchOutput = (T)(object)"Match";
        } else if (typeof(T) == typeof(int)) {
            MatchOutput = (T)(object)1;
        } else {
            MatchOutput = default(T);
        }
    }

    public string GetHeader() {
        var symbolX = IncludeX ? "≤" : "<";
        var symbolY = IncludeY ? "≤" : "<";

        string optionText;
        if (typeof(T) == typeof(string)) {
            optionText = $"\"{MatchOutput}\"";
        } else {
            optionText = MatchOutput.ToString();
        }

        return $"( {Range.x} {symbolX} 𝑥 {symbolY} {Range.y} ) ➜ {optionText}";
    }
}

public class FloatRangeToIntegerCondition : FloatRangeToTypeCondition<int> { }
public class FloatRangeToStringCondition : FloatRangeToTypeCondition<string> { }

[NodeType(
    Id = "hanekit-99bc73fc-7bdd-4df0-afdb-328d7e217d6e",
    Title = "FLOAT_RANGE_CONDITIONS_TO_INTEGER",
    Category = "RANGE_CONDITIONS",
    Width = 1.5f)]
public class FloatRangeConditionsToIntegerNode : Node {

    /* DATA INPUTS */
    [DataInput]
    [Label("INPUT_FLOAT_VARIABLE")]
    public float x;

    [DataInput]
    [Label("CONDITIONS")]
    public FloatRangeToIntegerCondition[] RangeConditions;

    [DataInput]
    [Label("NO_MATCH_OUTPUT")]
    public int NoMatchOutput = 0;

    /* DATA OUTPUTS */
    [DataOutput]
    [Label("OUTPUT_INTEGER")]
    public int OutputInteger() {
        foreach (var RangeCondition in RangeConditions) {
            bool conditionX = RangeCondition.IncludeX ? (x >= RangeCondition.Range.x) : (x > RangeCondition.Range.x);
            bool conditionY = RangeCondition.IncludeY ? (x <= RangeCondition.Range.y) : (x < RangeCondition.Range.y);
            if (conditionX && conditionY) {
                return RangeCondition.MatchOutput;
            }
        }
        return NoMatchOutput;
    }

}


[NodeType(
    Id = "hanekit-4a748d39-04b9-48fe-acad-d143905ea8f0",
    Title = "FLOAT_RANGE_CONDITIONS_TO_STRING",
    Category = "RANGE_CONDITIONS",
    Width = 1.5f)]
public class FloatRangeConditionsToStringNode : Node {

    /* DATA INPUTS */
    [DataInput]
    [Label("INPUT_FLOAT_VARIABLE")]
    public float x;

    [DataInput]
    [Label("CONDITIONS")]
    public FloatRangeToStringCondition[] RangeConditions;

    [DataInput]
    [Label("NO_MATCH_OUTPUT")]
    public string NoMatchOutput = "No Match";

    /* DATA OUTPUTS */
    [DataOutput]
    [Label("OUTPUT_STRING")]
    public string OutputString() {
        foreach (var RangeCondition in RangeConditions) {
            bool conditionX = RangeCondition.IncludeX ? (x >= RangeCondition.Range.x) : (x > RangeCondition.Range.x);
            bool conditionY = RangeCondition.IncludeY ? (x <= RangeCondition.Range.y) : (x < RangeCondition.Range.y);
            if (conditionX && conditionY) {
                return RangeCondition.MatchOutput;
            }
        }
        return NoMatchOutput;
    }

}
