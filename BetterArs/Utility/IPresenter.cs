namespace BetterArs.Utility {
    public interface IRefreshablePresenter {
        void Refresh();
    }

    public interface IPresenter : IRefreshablePresenter {
        void Run();
    }

    public interface IPresenter<in TArg> : IRefreshablePresenter {
        void Run(TArg argument);
    }
}
