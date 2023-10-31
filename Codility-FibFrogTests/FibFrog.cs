using Codility_FibFrog;

namespace Codility_FibFrogTests
{
    public class SolutionTests
    {
        [Fact]
        public void TestExampleCase()
        {
            Solution solution = new Solution();
            int[] A = { 0, 0, 0, 1, 1, 0, 1, 0, 0, 0, 0 };
            int expected = -1;
            int result = solution.solution(A);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestNoLeaves()
        {
            Solution solution = new Solution();
            int[] A = { 0, 0, 0, 0, 0, 0, 0 };
            int expected = -1;
            int result = solution.solution(A);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestNoRiver()
        {
            Solution solution = new Solution();
            int[] A = { };
            int expected = -1;
            int result = solution.solution(A);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestMaximumRange()
        {
            Solution solution = new Solution();
            int[] A = new int[Solution.RANGE_HIGHEST_VALUE + 1];
            A[Solution.RANGE_HIGHEST_VALUE] = 1;
            int expected = -1;
            int result = solution.solution(A);
            Assert.Equal(expected, result);
        }
    }
}