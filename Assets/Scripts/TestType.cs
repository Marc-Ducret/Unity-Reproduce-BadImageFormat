using MainAssembly;
using TestPackage;
using Unity.Entities;

[assembly: RegisterGenericSystemType(typeof(GenericSystem<TestType>))]

namespace MainAssembly {
    public struct TestType {
        public int value;
    }
}