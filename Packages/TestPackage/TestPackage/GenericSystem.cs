using Unity.Entities;

[assembly: RegisterGenericSystemType(typeof(TestPackage.GenericSystem<int>))]

namespace TestPackage {
    public partial struct GenericSystem<T> : ISystem where T : unmanaged {
        public void OnUpdate(ref SystemState state) {
            UnityEngine.Debug.Log($"Hello {typeof(T)}");
        }
    }
}