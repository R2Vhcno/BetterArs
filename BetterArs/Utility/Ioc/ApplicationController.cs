using System.Data.Entity.Infrastructure;

namespace BetterArs.Utility.Ioc {
    public class ApplicationController : IApplicationController {
        private readonly IContainer _container;

        public ApplicationController(IContainer container) {
            _container = container;

            _container.RegisterInstance<IApplicationController>(this);
        }

        public IApplicationController RegisterService<TService, TImpl>()
            where TImpl : class, TService {
            _container.Register<TService, TImpl>();

            return this;
        }
        
        public IApplicationController RegisterInstance<TArg>(TArg instance) {
            _container.RegisterInstance(instance);

            return this;
        }

        public IApplicationController RegisterView<TView, TImpl>()
            where TView : IView
            where TImpl : class, TView {
            _container.Register<TView, TImpl>();

            return this;
        }

        void IApplicationController.Run<TPresenter>() {
            if (!_container.IsRegistered<TPresenter>()) {
                _container.Register<TPresenter>();
            }

            var presenter = _container.Resolve<TPresenter>();
            
            presenter.Run();
        }

        void IApplicationController.Run<TPresenter, TArg>(TArg argument) {
            if (!_container.IsRegistered<TPresenter>()) {
                _container.Register<TPresenter>();
            }

            var presenter = _container.Resolve<TPresenter>();

            presenter.Run(argument);
        }
    }
}
