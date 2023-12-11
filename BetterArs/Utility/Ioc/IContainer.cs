using System;
using System.Linq.Expressions;

namespace BetterArs.Utility.Ioc {
    public interface IContainer {
        void Register<TService, TImpl>()
            where TImpl : TService;

        void Register<TService>();

        void RegisterInstance<T>(T instance);

        TService Resolve<TService>();

        bool IsRegistered<TService>();

        void Register<TService, TArg>(Expression<Func<TArg, TService>> factory);
    }
}
