﻿namespace CV9Library
{
    public interface IMyQueue<T> : IMyCollection<T>
    {
        void Add(T item);
        T Get();
    }
}
