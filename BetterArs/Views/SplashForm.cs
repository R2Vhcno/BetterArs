using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterArs.Views {
    public partial class SplashForm : Form {
        private static Thread _splashThread;
        private static SplashForm _splashForm;

        public SplashForm() {
            InitializeComponent();
        }

        public static void ShowSplash() {
            if (_splashThread is null) {
                _splashThread = new Thread(DoShowSplash);
                
                _splashThread.IsBackground = true;
                _splashThread.Start();
            }
        }

        private static void DoShowSplash() {
            if (_splashForm is null) {
                _splashForm = new SplashForm();
            }

            Application.Run(_splashForm);
        }

        public static void CloseSplash() {
            if (_splashForm.InvokeRequired) {
                _splashForm.Invoke(new MethodInvoker(CloseSplash));
            } else {
                Application.ExitThread();
            }
        }
    }
}
