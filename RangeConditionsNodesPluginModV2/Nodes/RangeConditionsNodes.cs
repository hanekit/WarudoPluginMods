using UnityEngine;
using Warudo.Core.Attributes;
using Warudo.Core.Graphs;
using Warudo.Core.Data;

namespace Warudo.Plugins.RangeConditionsNodes.Nodes {

    public abstract class FloatRangeToTCondition<T> : StructuredData, ICollapsibleStructuredData {

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

        public FloatRangeToTCondition() {
            if (typeof(T) == typeof(bool)) {
                MatchOutput = (T)(object)true;
            } else if (typeof(T) == typeof(int)) {
                MatchOutput = (T)(object)1;
            } else if (typeof(T) == typeof(string)) {
                MatchOutput = (T)(object)"Match";
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

    public abstract class FloatRangeConditionsToTNode<T> : Node {

        public FloatRangeConditionsToTNode() {
            if (typeof(T) == typeof(string)) {
                NoMatchOutput = (T)(object)"No Match";
            } else {
                NoMatchOutput = default(T);
            }
        }

        /* DATA INPUTS */
        [DataInput]
        [Label("INPUT_FLOAT_VARIABLE")]
        public float x;

        public class FloatRangeToTCondition : FloatRangeToTCondition<T> { }

        [DataInput]
        [Label("CONDITIONS")]
        public FloatRangeToTCondition[] RangeConditions;

        [DataInput]
        [Label("NO_MATCH_OUTPUT")]
        public T NoMatchOutput;

        /* DATA OUTPUTS */
        public T GetOutput() {
            foreach (var RangeCondition in RangeConditions) {
                bool conditionX = RangeCondition.IncludeX ? (x >= RangeCondition.Range.x) : (x > RangeCondition.Range.x);
                bool conditionY = RangeCondition.IncludeY ? (x <= RangeCondition.Range.y) : (x < RangeCondition.Range.y);
                if (conditionX && conditionY) {
                    return (T)(object)RangeCondition.MatchOutput;
                }
            }
            return (T)(object)NoMatchOutput;
        }

    }

    [NodeType(
        Id = "hanekit-484a6e37-4630-4fbb-b884-08f94698163c",
        Title = "FLOAT_RANGE_CONDITIONS_TO_BOOLEAN",
        Category = "RANGE_CONDITIONS",
        Width = 1.5f)]
    public class FloatRangeConditionsToBooleanNode : FloatRangeConditionsToTNode<bool> {

        /* DATA OUTPUTS */
        [DataOutput]
        [Label("OUTPUT_BOOLEAN")]
        public bool OutputBool() {
            return GetOutput();
        }

    }


    [NodeType(
        Id = "hanekit-99bc73fc-7bdd-4df0-afdb-328d7e217d6e",
        Title = "FLOAT_RANGE_CONDITIONS_TO_INTEGER",
        Category = "RANGE_CONDITIONS",
        Width = 1.5f)]
    public class FloatRangeConditionsToIntegerNode : FloatRangeConditionsToTNode<int> {

        /* DATA OUTPUTS */
        [DataOutput]
        [Label("OUTPUT_INTEGER")]
        public int OutputInteger() {
            return GetOutput();
        }

    }

    [NodeType(
        Id = "hanekit-4a748d39-04b9-48fe-acad-d143905ea8f0",
        Title = "FLOAT_RANGE_CONDITIONS_TO_STRING",
        Category = "RANGE_CONDITIONS",
        Width = 1.5f)]
    public class FloatRangeConditionsToStringNode : FloatRangeConditionsToTNode<string> {

        /* DATA OUTPUTS */
        [DataOutput]
        [Label("OUTPUT_STRING")]
        public string OutputString() {
            return GetOutput();
        }

    }

}
