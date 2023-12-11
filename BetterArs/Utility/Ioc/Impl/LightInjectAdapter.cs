using LightInject;
using System;
using System.Linq.Expressions;

namespace BetterArs.Utility.Ioc.Impl {
    public class LightInjectAdapter : IContainer {
        private readonly ServiceContainer _container = new ServiceContainer();

        public bool IsRegistered<TService>() {
            return _container.CanGetInstance(typeof(TService), string.Empty);
        }

        public void Register<TService, TImpl>() where TImpl : TService {
            _container.Register<TService, TImpl>();
        }

        public void Register<TService>() {
            _container.Register<TService>();
        }

        public void Register<TService, TArg>(Expression<Func<TArg, TService>> factory) {
            _container.Register(serviceFactory => factory);
        }

        public void RegisterInstance<T>(T instance) {
            _container.RegisterInstance(instance);
        }

        public TService Resolve<TService>() {
            return _container.GetInstance<TService>();
        }
    }
}
