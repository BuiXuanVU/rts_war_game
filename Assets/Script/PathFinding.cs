using Unity.Entities;
using Unity.Mathematics;

public partial struct PathFinding : IJobEntity
{
    public void Execute()
    {

    }
    private void FindPath(int2 startingPos,int2 endingPos)
    {
        
    }
    private struct pathNode
    {
        public int x;
        public int z;
        public int index;
        // di chuyển thực tế của thực thể được thực hiện từ khi bắt đầu đến node này
        public int gCost;
        // là chi phí ước tính từ node này đến cuối
        public int hCost;
        // g+h
        public int fCost;
        public bool isWalkAble;
        public int cameFromNodeIndex;
    }
}
