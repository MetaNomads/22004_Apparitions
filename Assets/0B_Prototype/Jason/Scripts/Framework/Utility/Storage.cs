using System.Collections;
using System.Collections.Generic;
using QFramework;
using UnityEngine;

public interface IStorage : IUtility
{
    public void save<T>(string name, T value);
    public T load<T>(string name);
}


public class PlayerPrefStorage : IStorage
{
    public void save<T>(string name, T value)
    {
        throw new System.NotImplementedException();
    }

    public T load<T>(string name)
    {
        throw new System.NotImplementedException();
    }
}
