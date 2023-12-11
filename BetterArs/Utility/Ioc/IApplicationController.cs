namespace BetterArs.Utility.Ioc {
    public interface IApplicationController {
        IApplicationController RegisterView<TView, TImpl>()
            where TImpl : class, TView
            where TView : IView;

        IApplicationController RegisterService<TService, TImpl>()
            where TImpl : class, TService;

        IApplicationController RegisterInstance<TArg>(TArg instance);

        void Run<TPresenter>()
            where TPresenter : class, IPresenter;

        void Run<TPresenter, TArg>(TArg argument)
            where TPresenter : class, IPresenter<TArg>;
    }
}
