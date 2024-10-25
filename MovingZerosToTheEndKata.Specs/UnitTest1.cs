using Machine.Specifications;

namespace MovingZerosToTheEndKata.Specs
{
    public class When_Finding_Zeros
    {
        Establish context = () =>
        {
            inputs = new List<int[]>
            {
                new int[]{1, 2, 0, 1, 0, 1, 0, 3, 0, 1 },
                new int[]{0,0,0,0,0,0,0,0,1 },
                new int[]{0},
                new int[]{1 }
            };
            expectations = new List<int[]>
            {
                new int[]{1,2,1,1,3,1,0,0,0,0 },
                new int[]{1,0,0,0,0,0,0,0,0 },
                new int[]{0},
                new int[]{1 }
            };
            outcomes = new List<int[]>();
        };

        Because of = () =>
        {
            for (var i = 0; i < inputs.Count; i++)
            {
                outcomes.Add(MovingZeros.MoveZeros(inputs[i]));
            }
        };

        It Should_Return_An_Array_With_All_Zeros_At_The_End = () =>
        {
            for (var i = 0; i < expectations.Count; i++)
            {
                for(var j = 0; j < expectations[i].Length; j++)
                    outcomes[i][j].ShouldEqual(expectations[i][j]);
            }
        };

        private static List<int[]> inputs;
        private static List<int[]> expectations;
        private static List<int[]> outcomes;
    }
}