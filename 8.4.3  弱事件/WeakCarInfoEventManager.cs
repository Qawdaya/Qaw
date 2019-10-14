using System;
using System.Windows;

namespace Wrox.ProCSharp.Delegates
{
    public class WeakCarInfoEventManager : WeakEventManager
    {
        public static void AddListener(object source, IWeakEventListener listener)
        {
            CurrentManager.ProtectedAddListener(source, listener);
        }

        private void ProtectedAddListener(object source, IWeakEventListener listener)
        {
            throw new NotImplementedException();
        }

        public static void RemoveListener(object source, IWeakEventListener listener)
        {
            CurrentManager.ProtectedRemoveListener(source, listener);
        }

        private void ProtectedRemoveListener(object source, IWeakEventListener listener)
        {
            throw new NotImplementedException();
        }

        public static WeakCarInfoEventManager CurrentManager
        {
            get
            {
                if (!(GetCurrentManager(typeof(WeakCarInfoEventManager)) is WeakCarInfoEventManager manager))
                {
                    manager = new WeakCarInfoEventManager();
                    GetCurrentManager(typeof(WeakCarInfoEventManager), manager);
                }
                return manager;
            }
        }

        private static void GetCurrentManager(Type type, WeakCarInfoEventManager manager)
        {
            throw new NotImplementedException();
        }

        private static WeakCarInfoEventManager GetCurrentManager(Type type)
        {
            throw new NotImplementedException();
        }

        protected override void StartListening(object source)
        {
            (source as CarDealer).NewCarInfo += CarDealer_NewCarInfo;
        }

        void CarDealer_NewCarInfo(object sender, CarInfoEventArgs e)
        {
            DeliverEvent(sender, e);
        }
        protected override void StopListening(object source)
        {
            (source as CarDealer).NewCarInfo -= CarDealer_NewCarInfo;
        }
    }

    public class WeakEventManager
    {
    }
}
