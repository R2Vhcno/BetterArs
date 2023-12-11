using BetterArs.Services.Interfaces;
using System.Windows.Forms;

namespace BetterArs.Services {
    public class MessageService : IMessageService {
        public void PrintError(string message) {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void PrintInfo(string message) {
            MessageBox.Show(message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
