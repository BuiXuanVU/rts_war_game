using Unity.Burst;
using Unity.Entities;
using Unity.Transforms;

partial struct UnitMoveOrderSystem : ISystem
{
    [BurstCompile]
    public void OnCreate(ref SystemState state)
    {
        
    }

    [BurstCompile]
    public void OnUpdate(ref SystemState state)
    {
        foreach(RefRO<LocalTransform> LocalTransform  in SystemAPI.Query<RefRO<LocalTransform>>() ){
            
        }
    }

    [BurstCompile]
    public void OnDestroy(ref SystemState state)
    {
        
    }
}
