//using Unity.Authoring.Core;
using Unity.Entities;
using Unity.Mathematics;

namespace Snake {
    public struct SnakeHead : IComponentData {
        public float3 Direction;
    }
}
