﻿using Caliburn.Micro.Extensions;

namespace XunitDemo
{
    public class SimpleContainerRegisteringInstances
    {
        [Fact]
        public void Instances_registed_Singleton_return_the_same_instance_for_each_call()
        {
            var container = new SimpleContainer();
            container.Singleton<object>();

            var instanceA = container.GetInstance(typeof(object), null);
            var instanceB = container.GetInstance(typeof(object), null);

            Assert.Same(instanceA, instanceB);
        }

        [Fact]
        public void Instances_registered_PerRequest_returns_a_different_instance_for_each_call()
        {
            var container = new SimpleContainer();
            container.PerRequest<object>();

            var instanceA = container.GetInstance(typeof(object), null);
            var instanceB = container.GetInstance(typeof(object), null);

            Assert.NotSame(instanceA, instanceB);
        }

        [Fact]
        public void Instances_registered_with_different_keys_get_all_instances_return_all()
        {
            var container = new SimpleContainer();
            container.RegisterInstance(typeof(object), "test", new object());
            container.RegisterInstance(typeof(object), "test", new object());

            var results = container.GetAllInstances<object>("test");

            Assert.Equal(2, results.Count());
        }

    }
}
