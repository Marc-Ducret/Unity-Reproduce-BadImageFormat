using Unity.Entities;

namespace TestPackage {
    public partial struct GenericSystem<T> : ISystem where T : unmanaged {
        public void OnUpdate(ref SystemState state) {
            UnityEngine.Debug.Log($"Hello {typeof(T)}");
        }
    }
}