namespace PostsAndTasksApp.Utils
{
    public interface ICustomObservable<E>
    {
        void AddObserver(ICustomObserver<E> o);
        void DeleteObserver(ICustomObserver<E> o);

        void NotifyObservers();
    }
}
