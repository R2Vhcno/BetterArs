namespace BetterArs.Services.Interfaces {
    public interface IMessageService {
        void PrintError(string message);

        void PrintInfo(string message);

        bool RequestConfirmation(string task);
    }
}
