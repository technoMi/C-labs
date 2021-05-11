namespace Baranov_CS.MenuClasses {

    public abstract class Core {

        public abstract string Title {
            get;
        }

        public abstract void Execute();

        public delegate void InfoUpdateHandler(string info);
        public event InfoUpdateHandler OnInfoUpdate;
        public void FireInfoUpdate(string info) {
            OnInfoUpdate?.Invoke(info);
        }
    }
}